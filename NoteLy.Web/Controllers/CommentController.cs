using Microsoft.AspNetCore.Mvc;
using NoteLy.Data;
using NoteLy.Web.ViewModels.Playlist;
using System.Security.Claims;

namespace NoteLy.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly NoteLyDbContext _dbContext;
        public CommentController(NoteLyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddPlayListInputModel inputModel)
        {
            return View();
        }

    }
}
