using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Exceptions
{
    public class UndefinedSignException : Exception
    {
        public override string Message => "Undefined sign";
    }
}
