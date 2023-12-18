using GymManagement.Application.DTOs.ExerciseType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Features.ExerciseTypes.Requests
{
    public class GetExerciseTypeListRequest : IRequest<List<ExerciseTypeDto>>
    {
    }
}
