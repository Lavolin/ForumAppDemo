using ForumAppDemo.Data;
using ForumAppDemo.Data.Models;
using ForumAppDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ForumAppDemo.Controllers
{
    public class PostController : Controller
    {
        private readonly ForumAppDbContext context;

        public PostController(ForumAppDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await context.Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new PostViewModel();

            ViewData["Title"] = "Add new post";

            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = model.Id == 0 ? "Add new Post" : "Edit Post";

                return View(model);
            }

            if (model.Id == 0)
            {
                context.Add(new Post()
                {
                    Title = model.Title,
                    Content = model.Content
                });
            }
            else
            {
                var post = await context.Posts.FindAsync(model.Id);

                if (post != null)
                {
                    post.Title = model.Title;
                    post.Content = model.Content;
                }
            }
           await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
