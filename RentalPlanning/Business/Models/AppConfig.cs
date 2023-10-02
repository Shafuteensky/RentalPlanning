namespace RentalPlanning.Business.Models
{
    public record AppConfig
    {
        public string? Environment { get; init; }
    }
}