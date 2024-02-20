using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagement.Application.Responses
{
    public class BaseCommandResponse
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        
        public int Id { get; set; }
            
    }
}
