namespace BuberBreakfast.Dtos
{
    public record UpsertBreakfastDTO(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet);
}
