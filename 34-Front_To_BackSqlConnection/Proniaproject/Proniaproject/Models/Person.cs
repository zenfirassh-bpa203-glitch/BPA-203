using Proniaproject.Models.Base;

namespace Proniaproject.Models
{
    public class Person : BaseEntity
    {
        public string ImageUrl3 { get; set; }
        public string PersonName { get; set; }
        public string PersonDetail { get; set; }
        public string PersonDescription { get; set; }
    }
}
