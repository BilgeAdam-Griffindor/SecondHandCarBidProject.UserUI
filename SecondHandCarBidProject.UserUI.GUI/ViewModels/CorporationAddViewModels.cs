﻿using System;

namespace SecondHandCarBidProject.UserUI.GUI.ViewModels
{
    public class CorporationAddViewModels
    {
        public string CompanyName { get; set; }
        public int AddressInfoId { get; set; }
        public string PhoneNumber { get; set; }
        public int CorporationTypeId { get; set; }
        public Int16 CorporatePackageTypeId { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}