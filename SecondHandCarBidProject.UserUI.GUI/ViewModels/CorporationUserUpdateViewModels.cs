﻿using System;

namespace SecondHandCarBidProject.UserUI.GUI.ViewModels
{
    public class CorporationUserUpdateViewModels
    {
        public Guid BaseUserId { get; set; } 
        public int CorporationId { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}