using GymManagement.Application.DTOs.ExerciseType;
using GymManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Features.ExerciseTypes.Requests
{
    public class CreateExerciseTypeCommand : IRequest<BaseCommandResponse>
    {
        public CreateExerciseTypeDto CreateExerciseTypeDto { get; set; }
    }
}
