using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.ViewComponents.Posting
{
    public class PostList : ViewComponent
    {
        private PostManager postManager = new PostManager(new EFPostRepository());
        public IViewComponentResult Invoke()
        {
            var values = postManager.GetPostListWithCategory();
            return View(values);
        }
    }
}
