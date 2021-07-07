using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task10.Enums;
using Task10.Models;
using Task10.Repositories.Interfaces;

namespace Task10.Repositories.Implementations
{
    public class DbRepository : IDbRepository
    {
        private readonly MovieDbContex contex;

        public DbRepository(MovieDbContex contex)
        {
            this.contex = contex;
        }

        public async Task CreateMovieAsync(Movie movie)
        {
            await contex.Movie.AddAsync(movie);
            await contex.SaveChangesAsync();
        }

        public async Task DeleteAsync(int ID)
        {
            var movie = await GetMovieAsync(ID);
            contex.Movie.Remove(movie);
            await contex.SaveChangesAsync();
        }

        public async Task<DbAnswer> EditAsync(Movie movie)
        {
            try
            {
                contex.Movie.Update(movie);
                await contex.SaveChangesAsync();
                return DbAnswer.OK;
            } 
            catch (Exception)
            {
                if (await MovieExistsAsync(movie.ID)) return DbAnswer.NotFound;
                else throw;
            }
        }

        public async Task<Movie> GetMovieAsync(int? ID) => await contex.Movie.FirstOrDefaultAsync(m => m.ID == ID);
        public async Task<IEnumerable<Movie>> GetMoviesAsync() =>  await contex.Movie.ToListAsync();
        public async Task<bool> MovieExistsAsync(int? ID) => await contex.Movie.AnyAsync(m => m.ID == ID);

        public async Task<MovieGenreViewModel> SearchAsync(string genre, string title)
        {
            IQueryable<string> query = from m in contex.Movie orderby m.Genre select m.Genre;
            var movies = from m in contex.Movie select m;

            if (!string.IsNullOrEmpty(title)) movies = movies.Where(m => m.Title.Contains(title.Trim()));
            if (!string.IsNullOrEmpty(genre)) movies = movies.Where(m => m.Genre == genre);

            var model = new MovieGenreViewModel
            {
                Genres = new SelectList(await query.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };

            return model;
        }
    }
}