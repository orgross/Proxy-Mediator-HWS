using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HWS
{
    internal class InteriorOfficeMan : IInteriorOffice
    {
        public InteriorOffice InteriorOffice { get; set; }

        public InteriorOfficeMan(InteriorOffice interiorOffice)
        {
            InteriorOffice = interiorOffice;
        }

        public void BirthCert()
        {
            InteriorOffice.BirthCert();
        }

        public void ChangeFirstName()
        {
            InteriorOffice.ChangeFirstName();
        }

        public void ChangeLastName()
        {
            InteriorOffice.ChangeLastName();
        }
    }
}
