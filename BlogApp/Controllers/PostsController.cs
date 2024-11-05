using Microsoft.AspNetCore.Mvc;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.Data.Abstract;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _repository;

        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var list = _repository.Posts.ToList();
            return View(list);
        }
    }
}
