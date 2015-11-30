using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceGateway.Services;

namespace ServiceGateway
{
    public class Facade
    {
        public AboutGatewayService GetAboutGatewayService()
        {
            return new AboutGatewayService();
        }
    }
}
