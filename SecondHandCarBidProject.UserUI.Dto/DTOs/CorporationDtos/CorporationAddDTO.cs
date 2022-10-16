using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.CorporationDtos
{
    public class CorporationAddDTO
    {
        public string CompanyName { get; set; }
        public int AddressInfoId { get; set; }
        public string PhoneNumber { get; set; }
        public int CorporationTypeId { get; set; }
        public Int16 CorporatePackageTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
