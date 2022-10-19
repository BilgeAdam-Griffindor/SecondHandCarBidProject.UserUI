using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs
{
    public class BidAddSendDTO
    {
        public string BidName { get; set; }
        public bool IsCorporate { get; set; }
        public int? CorporationId { get; set; }
        public int StatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Guid> CarIds { get; set; }
    }

    public class BidAddPageDTO
    {
        public List<IdNameListDTO> CorporationList { get; set; }
        public List<IdNameListDTO> StatusList { get; set; }
        public List<IdNameListDTO> CarList { get; set; }
    }

    public class IdNameListDTO
    {
        public object Id { get; set; }
        public string Name { get; set; }
    }
}
