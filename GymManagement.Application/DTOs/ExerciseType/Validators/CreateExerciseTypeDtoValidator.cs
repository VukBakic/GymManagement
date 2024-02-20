using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.DTOs.ExerciseType.Validators
{
    public class CreateExerciseTypeDtoValidator : AbstractValidator<CreateExerciseTypeDto>
    {
        public CreateExerciseTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
