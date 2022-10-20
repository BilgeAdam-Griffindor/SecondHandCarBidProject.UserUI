using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.NavbarDtos
{
    public class AboutAddDTO
    {
        public string HeadLine1 { get; set; }
        public string Content1 { get; set; }
        public string HeadLine2 { get; set; }
        public string Content2 { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
