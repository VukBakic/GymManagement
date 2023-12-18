using GymManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.DTOs.ExerciseType
{
    public class ExerciseTypeDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
