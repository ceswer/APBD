using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task10.Enums;
using Task10.Models;

namespace Task10.Repositories.Interfaces
{
    public interface IDbRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieAsync(int? ID);
        Task CreateMovieAsync(Movie movie);
        Task<DbAnswer> EditAsync(Movie movie);
        Task<bool> MovieExistsAsync(int? ID);
        Task DeleteAsync(int ID);
        Task<MovieGenreViewModel> SearchAsync(string genre, string title);
    }
}
