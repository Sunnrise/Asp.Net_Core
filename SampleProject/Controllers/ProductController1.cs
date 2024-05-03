using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    public class ProductController : Controller
    {
        #region ViewResult
        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;

        //}
        #endregion
        #region PartialViewResult
        public PartialViewResult GetProducts()
        {
            PartialViewResult result = PartialView();

            return result;

        }
        #endregion
        #region JsonResult

        #endregion
        #region EmptyResult

        #endregion
        #region ContentResult
        #endregion
        #region ActionResult
        #endregion
        #region IActionResult

        #endregion
    }
}
