using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs
{
    public class BidAddSendUserDTO
    {
        public string BidName { get; set; }
        public int? CorporationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Guid> CarIds { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
