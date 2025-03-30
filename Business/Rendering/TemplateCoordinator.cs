using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using Part1.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Business.Rendering
{
    [ServiceConfiguration(typeof(IViewTemplateModelRegistrator))]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(HeaderBlock), new TemplateModel
            {
                Name = "HeaderBlock-Default",
                AvailableWithoutTag = true,
                //Tags = new[] { "Mobile" },
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/HeaderBlock/Index.cshtml"
            });
        }
    }
}
