using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.Dto
{
    public class CarDetailDto
    {

        public string SelectedItem { get; set; }
        public List<SelectListItem> selectItemList
        {
            get; set;
        }

    }
}
