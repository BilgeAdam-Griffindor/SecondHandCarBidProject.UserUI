using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.CarDtos
{
    public class CarListTableRowDTO
    {
        public Guid CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string IndividualOrCorporate { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
