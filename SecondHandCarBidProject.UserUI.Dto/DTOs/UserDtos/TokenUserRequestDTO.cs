using System.ComponentModel.DataAnnotations;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs.UserDtos
{
    public class TokenUserRequestDTO
    {
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        [Display(Name = "Kullanıcı Adı")]
        public string LoginUser { get; set; }
        [Required]
        //[Range(6,18,ErrorMessage = "{0} en az {1} karakter,en çok {2} karakter uzunluğunda olmalı.")]
        [StringLength(18, ErrorMessage = "{0} en az {2} karakter,en çok {1} karakter uzunluğunda olmalı.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string LoginPassword { get; set; }
    }
}
