namespace FreeCourse.Services.Basket.Dtos
{
    public class BasketItemDto
    {
        public int Quentity { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
    }
}
