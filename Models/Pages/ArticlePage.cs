using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.Pages
{
    [ContentType(DisplayName ="Article page"
        ,Description ="Page type for destailed or article pages",
        GUID = "f3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b4b")]
    public class ArticlePage :  PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",            
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string? Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Short Description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHintAttribute(UIHint.Textarea)]
        public virtual string? ShortDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Full Content",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString? FullContent { get; set; }

        [CultureSpecific]
        [Display(
     Name = "Featured Image",
     GroupName = SystemTabNames.Content,
     Order = 4)]
        public virtual ContentReference? FeaturedImage { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Author Name",
           GroupName = SystemTabNames.Content,
           Order = 5)]
        public virtual string? AuthorName { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Published Date",
           GroupName = SystemTabNames.Content,
           Order = 6)]
        public virtual DateTime? PublishedDate { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Tags (Comma-Separated)",
          GroupName = SystemTabNames.Content,
          Order = 7)]
        public virtual string? Tags { get; set; }

        
        [Display(
        Name = "Is Featured Article?",
        GroupName = SystemTabNames.Content,
        Order = 8)]
        public virtual bool? IsFeatured { get; set; }

    }
}
