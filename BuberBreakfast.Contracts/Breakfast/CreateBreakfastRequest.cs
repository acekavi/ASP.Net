namespace BuberBreakfast.Contracts.Breakfast.CreateBreakfastRequest;

public record CreateBreakfastRequest
(
    string Name,
    string Description,
    DateTime CreatedAt,
    DateTime EndedAt,
    List<string> SavoryItems,
    List<string> SweetItems
);
