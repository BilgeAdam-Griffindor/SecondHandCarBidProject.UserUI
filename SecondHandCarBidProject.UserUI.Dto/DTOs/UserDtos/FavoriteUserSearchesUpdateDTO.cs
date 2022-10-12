using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.UserDtos
{
    public class FavoriteUserSearchesUpdateDTO
    {
        public Guid Id { get; set; }
        public string SearchText { get; set; }
        public Guid BaseUserId { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
