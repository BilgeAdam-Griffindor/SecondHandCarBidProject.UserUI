using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondHandCarBidProject.UserUI.Dto
{
    public class CarDetailDto
    {

        public string SelectedItem { get; set; }
        public List<SelectListItem> selectItemList
        {
            get; set;
        }
        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }
        public string description { get; set; }

    }
}
