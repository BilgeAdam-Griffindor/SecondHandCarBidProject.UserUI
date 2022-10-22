using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.BidDtos
{
    public class BidListDto
    {
        public List<CarBrand> Brands { get; set; }
        public List<BidCarDetailDto> Bids { get; set; }
        public List<BidCarColor> BidCarColors { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }

    }
    public class CarBrand
    {
        public string BrandId { get; set; }
        public string BrandName { get; set; }
    }
    public class BidCarDetailDto
    {
        public int BidId { get; set; }
        public string CarName { get; set; }
        public decimal BidPrice { get; set; }
        public string FirstImage { get; set; }
        public decimal MinimumBidPrice { get; set; }
    }
    public class BidCarColor
    {
        public string ColorId { get; set; }
        public string Color { get; set; }
        public string ColorName { get; set; }
    }
}
