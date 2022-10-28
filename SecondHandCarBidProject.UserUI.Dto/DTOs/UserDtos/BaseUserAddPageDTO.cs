using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.UserDtos
{
    public class BaseUserAddPageDTO
    {
        [Required(ErrorMessage = "Adınızı Giriniz")]
        [Display(Name = "Adı")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyadınızı Giriniz")]
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "{0} en az {2} karakter,en çok {1} karakter uzunluğunda olmalı.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "{0} en az {2} karakter,en çok {1} karakter uzunluğunda olmalı.", MinimumLength = 3)]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("PasswordSalt")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Giriniz")]
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Adres Seçiniz")]
        [NotMapped]
        public int AddressCityInfoId { get; set; }
        public List<SelectListItem> Cities { get; set; } = new List<SelectListItem>();
        public int AddressInfoId { get; set; }
        public List<SelectListItem> District { get; set; } = new List<SelectListItem>();
        public bool IsApproved { get; set; }
        public Guid ApprovedBy { get; set; }
        public bool EmailVerified { get; set; }
        public bool isCorporate { get; set; }
        [Display(Name = "KVKK Onay")]
        public bool KVKKChecked { get; set; }
        public short RoleTypeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
