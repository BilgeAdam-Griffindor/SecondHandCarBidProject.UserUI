using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.AdditionalFeeDtos
{
    public class NotaryFeeUpdateDTO
    {
        public Guid Id { get; set; }
        public decimal FeeAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
