using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGateway.Services
{
    public class TeamGatewayService
    {
        public IEnumerable<TeamDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/TeamApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<TeamDto>>().Result;
            }
        }

        public TeamDto Add(TeamDto teamDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/TeamApi/", teamDto).Result;
                return response.Content.ReadAsAsync<TeamDto>().Result;
            }
        }

        public TeamDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/TeamApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<TeamDto>().Result;
            }
        }

        public TeamDto Update(TeamDto teamDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/TeamApi/", teamDto.Id).Result;
                return response.Content.ReadAsAsync<TeamDto>().Result;
            }
        }

        public TeamDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/TeamApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<TeamDto>().Result;
            }
        }
    }
}
