namespace Proniaproject.Models.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
