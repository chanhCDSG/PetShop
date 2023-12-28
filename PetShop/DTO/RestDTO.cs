namespace PetShop.DTO
{
    public class RestDTO<T>
    {


        public T Data { get; set; } = default!;
        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
        public int? RecordCount { get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
    }
}
