using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Proxy
{
    class Client
    {
        ISubject subject;

        public Client()
        {
            subject = new Proxy(new RealSubject());
        }

        public void DoTheThing()
        {
            Console.WriteLine(subject.Operation());
        }
    }
}
