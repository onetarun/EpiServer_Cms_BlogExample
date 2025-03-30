using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.ViewModels
{
    public abstract class PageViewModel
    {
        public string? PageTitle { get; set; }

    }
    public class PageViewModel<T> : PageViewModel
    {
        public PageViewModel(T model)
        {
            Page = model;
        }

        public T Page { get; }
    }
}
