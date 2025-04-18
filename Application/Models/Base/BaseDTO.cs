namespace Application.Models.Base
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public required Guid CreateById { get; set; }
        public Guid? UpdateById { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
