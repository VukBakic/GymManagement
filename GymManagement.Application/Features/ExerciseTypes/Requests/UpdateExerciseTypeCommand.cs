using GymManagement.Application.DTOs.ExerciseType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Features.ExerciseTypes.Requests
{
    public class UpdateExerciseTypeCommand : IRequest<Unit>
    {
        public ExerciseTypeDto ExerciseTypeDto { get; set; }
    }
}
