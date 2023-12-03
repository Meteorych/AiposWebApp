namespace Lab6_7Logic.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Description { get; set; }

        public string Name()
        {
            return FirstName + " " + LastName;
        }
    }
}
