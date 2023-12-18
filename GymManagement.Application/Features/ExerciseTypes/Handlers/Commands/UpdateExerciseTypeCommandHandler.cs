using AutoMapper;
using GymManagement.Application.Features.ExerciseTypes.Requests;
using GymManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GymManagement.Application.Features.ExerciseTypes.Handlers.Commands
{
    public class UpdateExerciseTypeCommandHandler : IRequestHandler<UpdateExerciseTypeCommand, Unit>
    {
        private readonly IExerciseTypeRepository _exerciseTypeRepository;
        private readonly IMapper _mapper;

        public UpdateExerciseTypeCommandHandler(IExerciseTypeRepository exerciseTypeRepository, IMapper mapper)
        {
            this._exerciseTypeRepository = exerciseTypeRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateExerciseTypeCommand request, CancellationToken cancellationToken)
        {
            var exerciseType = await _exerciseTypeRepository.Get(request.ExerciseTypeDto.Id);

            _mapper.Map(request.ExerciseTypeDto, exerciseType);

            await _exerciseTypeRepository.Update(exerciseType);

            return Unit.Value;
        }
    }
}
