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

        public ContactGatewayService GetContactGatewayService()
        {
            return new ContactGatewayService();
        }

        public NewsGatewayService GetNewsGatewayService()
        {
            return new NewsGatewayService();
        }

        public PlayerGatewayService GetPlayerGatewayService()
        {
            return new PlayerGatewayService(); 
        }

        public RoleGatewayService GetRoleGatewayService()
        {
            return new RoleGatewayService();
        }

        public SponsorGatewayService GetSponsorGatewayService()
        {
            return new SponsorGatewayService();
        }

        public TeamGatewayService GetTeamGatewayService()
        {
            return new TeamGatewayService();
        }

        public TournamentGatewayService GetTournamentGatewayService()
        {
            return new TournamentGatewayService();
        }

        public EnglishGatewayService GetEnglishGatewayService()
        {
            return new EnglishGatewayService();
        }
    }
}
