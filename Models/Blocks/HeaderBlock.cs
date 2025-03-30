using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.Blocks
{
    [ContentType(DisplayName ="Header Block",GUID = "f3b4b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b4b")]
    public class HeaderBlock :  BlockData
    {
        [Display(Name ="Header Title",GroupName =SystemTabNames.Content,Order =10)]
        public virtual string? HeaderTitle { get; set; }

        [Display(Name = "Header Subtitle", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string? HeaderSubtitle { get; set; }


    }
}
