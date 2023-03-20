using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Dominio { get; set; } = "andreitoledo.com";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var prefixo = await output.GetChildContentAsync();
            var meuemail = prefixo.GetContent() + "@" + Dominio;
            output.Attributes.SetAttribute(name:"href",value:"mailto:" + meuemail);
            output.Content.SetContent(meuemail);

        }

    }
}
