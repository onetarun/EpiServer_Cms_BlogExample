using Part1.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.ViewModels
{
    public class HomePageViewModel : PageViewModel<Homepage>
    {
        public HomePageViewModel(Homepage model) : base(model)
        {
        }

        public List<ArticlePage> FeaturedArticles { get; set; }
        public List<ArticlePage> RecentArticles { get; set; }
        public int CurrentPageNumber { get; set; }
        public int TotalPages { get; set; }
    }
}
