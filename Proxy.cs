using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Proxy
{
    class Proxy : ISubject
    {
        private RealSubject realSubject;

        public Proxy(RealSubject realSubject)
        {
            this.realSubject = realSubject ?? throw new ArgumentNullException(nameof(realSubject));
        }

        public string Operation()
        {
            /* Works as a proxy:
             * PROTECTION PROXY: security proxy that authenticates client before allowing access to RealSubject
             * VIRTUAL PROXY: proxy that limits access to expencive subject, so it is not created befure needed
             * REMOTE PROXY: hides complex network communication from client
             */
            return "This is from Proxy and " + realSubject.Operation();
        }
    }
}
