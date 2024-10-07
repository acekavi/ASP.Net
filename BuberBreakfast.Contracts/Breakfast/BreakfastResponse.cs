namespace BuberBreakfast.Contracts.Breakfast.CreateBreakfastRequest;

public record BreakfastResponse
(
    Guid Id,
    string Name,
    string Description,
    DateTime CreatedAt,
    DateTime EndedAt,
    DateTime UpdatedAt,
    List<string> SavoryItems,
    List<string> SweetItems
);
