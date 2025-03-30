using Part1.Models.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Part1.Models.Pages
{
    [ContentType(DisplayName = "Homepage", GUID = "f3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b")]
    public class Homepage : PageData
    {
        [Display(Name = "Page Size", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual int PageSize { get; set; }

        [Display(Name ="Header Block",GroupName =SystemTabNames.Content,Order =30)]
        [AllowedTypes(AllowedTypes = new[] {typeof(HeaderBlock)})]
        public virtual ContentArea HeaderBlock { get; set; }

        [Display(Name = "Footer Block", GroupName = SystemTabNames.Content, Order = 30)]
        [AllowedTypes(AllowedTypes = new[] { typeof(HeaderBlock) })]
        public virtual ContentArea FooterBlock { get; set; }
    }
}
