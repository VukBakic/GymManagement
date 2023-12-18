using AutoMapper;
using GymManagement.Application.DTOs.ExerciseType;
using GymManagement.Application.Features.ExerciseTypes.Requests;
using GymManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GymManagement.Application.Features.ExerciseTypes.Handlers.Queries
{
    public class GetExerciseTypeRequestHandler : IRequestHandler<GetExerciseTypeListRequest, List<ExerciseTypeDto>>
    {
        private readonly IExerciseTypeRepository _exerciseTypeRepository;
        private readonly IMapper _mapper;

        public GetExerciseTypeRequestHandler(IExerciseTypeRepository exerciseTypeRepository, IMapper mapper)
        {
            this._exerciseTypeRepository = exerciseTypeRepository;
            this._mapper = mapper;
        }
        public async Task<List<ExerciseTypeDto>> Handle(GetExerciseTypeListRequest request, CancellationToken cancellationToken)
        {
            var exerciseTypes = await _exerciseTypeRepository.GetAll();
            return _mapper.Map<List<ExerciseTypeDto>>(exerciseTypes);
        }
    }
}
