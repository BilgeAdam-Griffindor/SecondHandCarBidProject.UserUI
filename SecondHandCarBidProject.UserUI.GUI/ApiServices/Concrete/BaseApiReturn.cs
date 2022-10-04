using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondHandCarBidProject.UserUI.GUI.ApiServices.Concrete
{
    public class BaseApiReturn
    {
        public int StatusCode { get; set; }
        public string ReasonPhrase { get; set; }
        public string Content { get; set; }
    }
}