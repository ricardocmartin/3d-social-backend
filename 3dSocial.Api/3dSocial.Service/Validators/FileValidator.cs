using _3dSocial.Domain.Entities;
using FluentValidation;
using System;

namespace _3dSocial.Service.Validators
{
    public class FileValidator : AbstractValidator<File>
    {
        public FileValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });
        }
    }

}
