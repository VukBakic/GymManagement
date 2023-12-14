using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Domain
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ExerciseType Type { get; set; }

    }
}
