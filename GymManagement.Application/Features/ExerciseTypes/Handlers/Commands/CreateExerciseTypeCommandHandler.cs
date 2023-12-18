using AutoMapper;
using GymManagement.Application.Features.ExerciseTypes.Requests;
using GymManagement.Application.Persistence.Contracts;
using GymManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GymManagement.Application.Features.ExerciseTypes.Handlers.Commands
{
    public class CreateExerciseTypeCommandtHandler : IRequestHandler<CreateExerciseTypeCommand, int>
    {
        private readonly IExerciseTypeRepository _exerciseTypeRepository;
        private readonly IMapper _mapper;

        public CreateExerciseTypeCommandtHandler(IExerciseTypeRepository exerciseTypeRepository, IMapper mapper)
        {
            this._exerciseTypeRepository = exerciseTypeRepository;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateExerciseTypeCommand request, CancellationToken cancellationToken)
        {
            var exerciseType = _mapper.Map<ExerciseType>(request.CreateExerciseTypeDto);

            exerciseType = await _exerciseTypeRepository.Add(exerciseType);

            return exerciseType.Id;
        }
    }
}
