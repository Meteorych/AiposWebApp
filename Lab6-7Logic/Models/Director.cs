namespace Lab6_7Logic.Models
{
    public class Director
    {
        public int Id { get;set; }
        public required string Name { get; set; }
        public DateOnly? BirthDate { get;set; }
        public string? Description { get; set; }
    }
}
