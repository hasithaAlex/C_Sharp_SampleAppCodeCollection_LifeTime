using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CustomException
{
    class ApiFailException : Exception
    {
        public ApiFailException()
        {

        }

        public ApiFailException(string name)
        : base(String.Format("Invalid Student Name: {0}", name))
    {

        }

    }
}
