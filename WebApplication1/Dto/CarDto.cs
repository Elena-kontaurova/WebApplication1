namespace WebApplication1.Dto
{
    public record CarDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int DriverId { get; set; }
    }
}
