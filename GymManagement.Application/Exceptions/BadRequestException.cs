using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Exceptions
{
    internal class BadRequestException : ApplicationException
    {
        public BadRequestException(string message) : base(message)
        {
            
        }
    }
}
