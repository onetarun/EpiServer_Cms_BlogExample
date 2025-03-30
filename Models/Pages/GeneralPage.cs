using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.Pages
{
    [ContentType(DisplayName ="General Page", GUID = "f3b3b3b3-3b3b-4b3b-3b3b-3b3b3b3b3b3b")]
    public class GeneralPage :  PageData
    {
        [Display(Name ="Heading",Description ="Heading of Page",
            GroupName =SystemTabNames.Content,Order =10)]
        public virtual string? Heading { get; set; }

        [Display(Name = "Heading", Description = "Heading of Page",
            GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string? Body { get; set; }

    }
}
