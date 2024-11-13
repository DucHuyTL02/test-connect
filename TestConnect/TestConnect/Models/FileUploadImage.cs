using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestConnect.Models
{
    public class FileUploadImage
    {
        [DataType(DataType.Upload)]
        [DisplayName("Upload Image")]
        public string fileImage {  get; set; }
    }
}