using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UrIHelpers_HtmlHelpers_TagHelpers.TagHelpers
{
    [HtmlTargetElement("e-mail")]//So we can rename the tag to anything we want, We called the tag with the name "e-mail" not "email"
    public class EmailTagHelper : TagHelper
    {
        public string Mail { get; set; }
        public string Display { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Display);
            //base.Process(context, output);
        }
    }
    public class SendMailFormTagHelper : TagHelper
    {

    }
}
