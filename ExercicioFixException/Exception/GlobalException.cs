using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixException.Exception
{
    class GlobalException : ApplicationException
    {
        public GlobalException (string message) : base(message)
        {
        }
    }
}
