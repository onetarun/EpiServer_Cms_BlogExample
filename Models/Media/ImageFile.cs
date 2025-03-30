using EPiServer.Framework.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Models.Media
{
    [ContentType(GUID= "f4b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b4b")]
    [MediaDescriptor(ExtensionString ="jpeg,jpg,png,gif,ico")]
    public class ImageFile : ImageData
    {

    }
}
