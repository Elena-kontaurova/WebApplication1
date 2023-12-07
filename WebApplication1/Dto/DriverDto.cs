namespace WebApplication1.Dto
{
    public record DriverDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronymic { get; set; }
    }
}
