using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UrIHelpers_HtmlHelpers_TagHelpers.Extensions
{
    static public class Extensions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value, string placeHolder)
        =>//return htmlHelper.TextBox();
           htmlHelper.TextBox(name, value, new
           {
               style= "background-color:yellow; color:white; font-size:11px;",
               @class ="form-input",
               a="a",
               b = "b",
               placeholder = placeHolder
           });
        
        
    }
}
