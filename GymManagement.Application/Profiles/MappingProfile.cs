using AutoMapper;
using GymManagement.Application.DTOs.Exercise;
using GymManagement.Application.DTOs.ExerciseType;
using GymManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ExerciseType, ExerciseTypeDto>().ReverseMap();
            CreateMap<Exercise, ExerciseDto>().ReverseMap();
        }
    }
}
