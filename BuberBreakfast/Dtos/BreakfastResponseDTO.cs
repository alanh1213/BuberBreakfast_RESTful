namespace BuberBreakfast.Dtos
{
    public record BreakfastResponseDTO(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<string> Sweet);
}
