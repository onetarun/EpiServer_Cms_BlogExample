using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Part1.Models.Pages;

namespace Part1.Controllers
{
    public class ArticlePageController : BasePageController<ArticlePage>
    {
        public IActionResult Index(ArticlePage currentPage)
        {

            return RenderPage(currentPage);
        }
    }
}
