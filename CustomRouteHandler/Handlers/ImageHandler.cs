using ImageMagick;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace CustomRouteHandler.Handlers
{ 
    public class ImageHandler
    {
        public RequestDelegate Handler(string filePath)
        {
            return async c =>
            {
               FileInfo fileInfo=new FileInfo($"{filePath}\\{c.Request.RouteValues["imageName"].ToString()}"); 
               
                using MagickImage magicS= new MagickImage(fileInfo);

                int width= magicS.Width, height = magicS.Height;

                if (!string.IsNullOrEmpty(c.Request.Query["w"].ToString()))
                {
                    width = int.Parse(c.Request.Query["w"].ToString());

                }
                if (!string.IsNullOrEmpty(c.Request.Query["h"].ToString()))
                {
                    height = int.Parse(c.Request.Query["h"].ToString());

                }
                magicS.Resize(width, height);

                var buffer = magicS.ToByteArray();
                c.Response.Clear();
                c.Response.ContentType = string.Concat("image/", fileInfo.Extension.Replace(".", ""));

                await c.Response.Body.WriteAsync(buffer, 0, buffer.Length);
                await c.Response.WriteAsync(filePath);
            };
        }
    }
}