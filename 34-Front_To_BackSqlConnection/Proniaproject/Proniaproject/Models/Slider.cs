namespace Proniaproject.Models
{
    public class Slider : Base.BaseEntity
    {
        
        public string Title { get; set; }

        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
       



    }
}
