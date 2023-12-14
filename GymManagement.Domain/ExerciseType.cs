using GymManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Domain
{
    public class ExerciseType : BaseDomainEntity
    {
        public string Name {  get; set; }
        public string Description { get; set; }

    }
}
