using SecondHandCarBidProject.UserUI.Dto.Validation;
using System.Collections.Generic;

namespace SecondHandCarBidProject.UserUI.Dto.DTOs
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public BusinessValidationRule businessValidationRule { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
