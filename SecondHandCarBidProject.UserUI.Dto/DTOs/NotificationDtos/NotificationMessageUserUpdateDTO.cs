using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.NotificationDtos
{
    public class NotificationMessageUserUpdateDTO
    {
        public Guid Id { get; set; }
        public int NotificationMessageId { get; set; }
        public Guid SendToBaseUserId { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
