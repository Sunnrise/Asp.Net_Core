using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Validation.Models.ModelMetadataTypes;

namespace Validation.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]//This attribute is used to link the Product class with the ProductMetadata class
    public class Product
    {
        #region WithoutModelMetaDataType
        //[Required(ErrorMessage = "Please type a product name")]
        //[StringLength(50, ErrorMessage = "Product name must be less than 50 characters")]
        //public string ProductName { get; set; }
        //public int Quantity { get; set; }

        //[EmailAddress(ErrorMessage = "Please type a correct e-mail")]
        //public string Email { get; set; }
        #endregion

        #region ModelMetaDataType
        
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
        #endregion

    }
}
