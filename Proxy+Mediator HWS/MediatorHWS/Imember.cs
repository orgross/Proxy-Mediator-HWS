using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HWS.MediatorHWS
{
    internal interface Imember
    {
        void Send(string message);
        void recieve(string message);
    }
}
