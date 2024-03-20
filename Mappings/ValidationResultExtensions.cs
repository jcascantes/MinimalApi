using FluentValidation.Results;

namespace MinimalApi.Mappings;

public class ValidationFailureResponse
{
    public IEnumerable<string> Errors { get; set; } = [];
}

public static class ValidationResultExtensions
{
    public static ValidationFailureResponse ToResponse(this IEnumerable<ValidationFailure> failures)
    {
        return new ValidationFailureResponse
        {
            Errors = failures.Select(e => e.ErrorMessage)
        };
    }
}
