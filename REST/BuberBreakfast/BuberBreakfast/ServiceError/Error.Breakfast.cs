using ErrorOr;
using BuberBreakfast.Models;

namespace BuberBreakfast.ServiceError;
public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at leats {BuberBreakfast.Models.Breakfast.MinNameLength} " +
            $"chatacters long and at most {BuberBreakfast.Models.Breakfast.MaxNameLength} characters long.");

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast description must be at leats {BuberBreakfast.Models.Breakfast.MinDescriptionLength} " +
            $"chatacters long and at most {BuberBreakfast.Models.Breakfast.MaxDescriptionLength} characters long.");

        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found");
    }
}
