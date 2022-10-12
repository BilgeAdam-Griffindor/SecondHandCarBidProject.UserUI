﻿using System;

namespace SecondHandCarBidProject.UserUI.GUI.ViewModels
{
    public class NotaryFeeUpdateViewModels
    {
        public Guid Id { get; set; } 
        public decimal FeeAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}