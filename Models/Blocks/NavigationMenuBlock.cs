using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.Blocks
{
    [ContentType(DisplayName = "Navigation Menu Block", GUID = "edc148ed-9d42-4b8b-b4e7-bd857fa4a345", Description = "Menu block for top navigation")]
    public class NavigationMenuBlock : BlockData
    {
        [Display(Name = "Menu Items", Order = 10)]
        public virtual LinkItemCollection MenuItems { get; set; }
    }
}
