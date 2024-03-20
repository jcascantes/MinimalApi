
using FluentValidation;
using MinimalApi.Mappings;

namespace MinimalApi.Filters;

public class ValidationFilter<T> : IEndpointFilter where T : class
{
    readonly IValidator<T> validator;

    public ValidationFilter(IValidator<T> validator)
    {
        this.validator = validator;
    }

    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        if (context.Arguments.SingleOrDefault(p => p?.GetType() == typeof(T)) is not T validatable)
        {
            return Results.BadRequest();
        }
        var validationResult = await validator.ValidateAsync(validatable);
        
        return !validationResult.IsValid? Results.BadRequest(validationResult.Errors.ToResponse()) : await next(context);
    }
}
