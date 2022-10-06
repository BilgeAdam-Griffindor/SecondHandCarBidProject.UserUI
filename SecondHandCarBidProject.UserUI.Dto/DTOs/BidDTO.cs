using System;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs
{
    public class BidDTO
    {
        public int BidID { get; set; }
        public string BidName { get; set; }
        public string BidUserType { get; set; }
        public DateTime BidStartDate { get; set; }
        public DateTime BidEndDate { get; set; }
        public string Statu { get; set; }
        public string User { get; set; }
        public string BidCreatedDate { get; set; }
    }
}
