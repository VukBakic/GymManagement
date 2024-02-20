using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Exceptions
{
    internal class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"{name} (${key}) was not found.")
        {
            
        }
    }
}
