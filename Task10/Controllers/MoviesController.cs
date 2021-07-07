using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task10.Enums;
using Task10.Models;
using Task10.Repositories.Interfaces;

namespace Task10.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IDbRepository repository;

        public MoviesController(IDbRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IActionResult> Index(string genre, string title) => View(await repository.SearchAsync(genre, title));
        public IActionResult Create() => View();

        public async Task<IActionResult> Details(int? ID)
        {
            if (ID == null) return NotFound();
            var movie = await repository.GetMovieAsync(ID);
            if (movie == null) return NotFound();
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                await repository.CreateMovieAsync(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public async Task<IActionResult> Edit(int? ID)
        {
            if (ID == null) NotFound();
            var movie = await repository.GetMovieAsync(ID);
            if (movie == null) NotFound();
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        {
            if (id != movie.ID) return NotFound();

            if (ModelState.IsValid)
            {
                var answer = await repository.EditAsync(movie);
                if (answer == DbAnswer.NotFound) return NotFound();
                else return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public async Task<IActionResult> Delete(int? ID)
        {
            if (ID == null) return NotFound();
            var movie = await repository.GetMovieAsync(ID);
            if (movie == null) return NotFound();
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int ID)
        {
            await repository.DeleteAsync(ID);
            return RedirectToAction(nameof(Index));
        }
    }
}