using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Part1.Models.Pages;
using Part1.Models.ViewModels;


namespace Part1.Controllers
{
    public class HomepageController : BasePageController<Homepage>
    {
        private readonly IContentLoader _contentLoader;
       
        public HomepageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }
        public IActionResult Index(Homepage currentPage, int page = 1)
        {
            // Load all articles under HomePage
            var allArticles = _contentLoader.GetChildren<ArticlePage>(currentPage.ContentLink)
                                            .OrderByDescending(a => a.StartPublish)
                                            .ToList();

            // Featured Articles - where IsFeatured is true
            var featuredArticles = allArticles.Where(a => a.IsFeatured==true).Take(3).ToList();

            // Recent Articles - Paging Logic
            int pageSize = currentPage.PageSize > 0 ? currentPage.PageSize : 2;
            //var nonFeaturedArticles = allArticles.Where(a => !a.IsFeatured).ToList();
            int totalItems = allArticles.Count;

            var pagedArticles = allArticles.Skip((page - 1) * pageSize)
                                                   .Take(pageSize)
                                                   .ToList();


            



            // Prepare ViewModel
            var model = new HomePageViewModel(currentPage)
            {
               
                FeaturedArticles = featuredArticles,
                RecentArticles = pagedArticles,
                CurrentPageNumber = page,
                TotalPages = (int)Math.Ceiling((double)totalItems / pageSize)
            };

            return RenderPage(model);
        }
    }
}
