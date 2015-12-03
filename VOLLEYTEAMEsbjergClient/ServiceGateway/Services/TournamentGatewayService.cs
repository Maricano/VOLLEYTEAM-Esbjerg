using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGateway.Services
{
    public class TournamentGatewayService
    {
        public IEnumerable<TournamentDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/TournamentApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<TournamentDto>>().Result;
            }
        }

        public TournamentDto Add(TournamentDto tournamentDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/TournamentApi/", tournamentDto).Result;
                return response.Content.ReadAsAsync<TournamentDto>().Result;
            }
        }

        public TournamentDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/TournamentApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<TournamentDto>().Result;
            }
        }

        public TournamentDto Update(TournamentDto tournamentDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/TournamentApi/"+ tournamentDto.Id, tournamentDto).Result;
                return response.Content.ReadAsAsync<TournamentDto>().Result;
            }
        }

        public TournamentDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/TournamentApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<TournamentDto>().Result;
            }
        }
    }
}
