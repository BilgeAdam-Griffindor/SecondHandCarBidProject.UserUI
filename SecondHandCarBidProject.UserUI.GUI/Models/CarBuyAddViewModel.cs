﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.GUI.Models
{
    public class CarBuyAddViewModel
    {
        public int Kilometre { get; set; }
        public short CarYear { get; set; }
        public string CarDescription { get; set; }
        public short CarBrandId { get; set; }
        public int CarModelId { get; set; }
        public Guid BodyTypeId { get; set; }
        public Guid FuelTypeId { get; set; }
        public Guid GearTypeId { get; set; }
        public Guid VersionId { get; set; }
        public Guid ColorId { get; set; }
        public List<Guid> OptionalHardwareIds { get; set; } //TODO may need to adjust
        public string CarImages { get; set; } //TODO correct?
        public List<SelectListItem> BrandList { get; set; }
        public List<SelectListItem> ModelList { get; set; }
        public List<SelectListItem> BodyTypeList { get; set; }
        public List<SelectListItem> FuelTypeList { get; set; }
        public List<SelectListItem> GearTypeList { get; set; }
        public List<SelectListItem> VersionList { get; set; }
        public List<SelectListItem> ColorList { get; set; }
        public List<SelectListItem> OptionalHardwareList { get; set; }
    }
}