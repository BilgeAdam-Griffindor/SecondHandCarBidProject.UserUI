namespace SecondHandCarBidProject.UserUI.Dto.DTOs.AddressInfoDTOs
{
    public class AddressInfoListDTO
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public int TopAddressInfoId { get; set; }
        public int AddressTypeId { get; set; }
        public bool isActive { get; set; }
    }
}
