﻿using GymManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.DTOs
{
    public class ExerciseDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ExerciseTypeDto Type { get; set; }
    }
}
