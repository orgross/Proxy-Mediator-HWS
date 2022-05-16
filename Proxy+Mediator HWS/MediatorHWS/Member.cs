using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HWS.MediatorHWS
{
    internal class Member : Imember
    {
        private IFacebookGroup FacebookGroup { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public Member(IFacebookGroup facebookGroup, string userName, int userId)
        {
            FacebookGroup = facebookGroup;
            UserName = userName;
            UserId = userId;
        }
        public void recieve(string message)
        {
            Console.WriteLine($"{this.UserName} the message you sent is:\n{message}");
        }

        public void Send(string message)
        {
            Console.WriteLine($"{this.UserName} the message you sent is:\n{message}");
            FacebookGroup.SendMessage(message, this);
        }
    }
}
