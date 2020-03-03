using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Proxy
{
    class RealSubject : ISubject
    {
        public string Operation()
        {
            return "Real Subject Object";
        }
    }
}
