using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HWS
{
    internal class ServiceMachine : IServiceMachine
    {
        public InteriorOffice interiorOffice { get; set; }

        public ServiceMachine(InteriorOffice interiorOffice)
        {
            this.interiorOffice = interiorOffice;
        }

        public void ChangeLocation()
        {
            interiorOffice.ChangeLocation();
        }

        public void RenewPassport()
        {
            interiorOffice.RenewPassport();
        }

        public void WatchInfo()
        {
            interiorOffice.WatchInfo();
        }
    }
}
