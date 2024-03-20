using FluentValidation;
using MinimalApi.Contracts;

namespace MinimalApi.Validators;

public class CreateClientRequestValidator : AbstractValidator<CreateClientRequest>
{
    public CreateClientRequestValidator()
    {
        RuleFor(request => request.Email).NotEmpty().Matches("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
        RuleFor(request => request.Name).NotEmpty();
        RuleFor(request => request.LastName).NotEmpty();
    }
}
