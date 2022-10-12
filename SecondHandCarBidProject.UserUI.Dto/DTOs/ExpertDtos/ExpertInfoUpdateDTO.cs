using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.ExpertDtos
{
    public class ExpertInfoUpdateDTO
    {
        public int Id { get; set; }
        public string/*?*/ CentreName { get; set; }
        public int AddressInfoId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public byte[]/*?*/ Picture { get; set; }
        public byte IsActive { get; set; }
        public string/*?*/ ExpertAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
