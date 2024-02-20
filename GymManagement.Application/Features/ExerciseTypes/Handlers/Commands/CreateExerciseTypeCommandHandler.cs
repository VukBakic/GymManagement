using AutoMapper;
using FluentValidation;
using GymManagement.Application.DTOs.ExerciseType.Validators;
using GymManagement.Application.Exceptions;
using GymManagement.Application.Features.ExerciseTypes.Requests;
using GymManagement.Application.Persistence.Contracts;
using GymManagement.Application.Responses;
using GymManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ValidationException = GymManagement.Application.Exceptions.ValidationException;


namespace GymManagement.Application.Features.ExerciseTypes.Handlers.Commands
{
    public class CreateExerciseTypeCommandHandler : IRequestHandler<CreateExerciseTypeCommand, BaseCommandResponse>
    {
        private readonly IExerciseTypeRepository _exerciseTypeRepository;
        private readonly IMapper _mapper;

        public CreateExerciseTypeCommandHandler(IExerciseTypeRepository exerciseTypeRepository, IMapper mapper)
        {
            this._exerciseTypeRepository = exerciseTypeRepository;
            this._mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateExerciseTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateExerciseTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CreateExerciseTypeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(p => p.ErrorMessage).ToList();
            }


            var exerciseType = _mapper.Map<ExerciseType>(request.CreateExerciseTypeDto);

            exerciseType = await _exerciseTypeRepository.Add(exerciseType);

            response.Success = true;
            response.Message = "Creation Succesful";
            response.Id = exerciseType.Id;

            return response;
        }
    }
}
