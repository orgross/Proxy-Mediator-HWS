using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HWS.MediatorHWS
{
    internal class FacebookGroup: IFacebookGroup
    {
        public List<Imember> members = new List<Imember>();

        public void RegisterUser(Imember imember)
        {
            members.Add(imember);
        }

        public void SendMessage(string message, Imember imember)
        {
            foreach (Imember member in members)
            {
                if(member != imember)
                {
                    member.recieve(message);
                }
            }
        }
    }
}
