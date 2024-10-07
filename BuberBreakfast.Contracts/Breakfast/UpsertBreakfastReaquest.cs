namespace BuberBreakfast.Contracts.Breakfast.CreateBreakfastRequest;

public record UpsertBreakfastRequest
(
    string Name,
    string Description,
    DateTime CreatedAt,
    DateTime EndedAt,
    List<string> SavoryItems,
    List<string> SweetItems,
);
