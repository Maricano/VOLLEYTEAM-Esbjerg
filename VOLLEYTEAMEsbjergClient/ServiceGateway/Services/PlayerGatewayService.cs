using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtoModel;
using System.Net.Http;

namespace ServiceGateway.Services
{
    public class PlayerGatewayService
    {
        public IEnumerable<PlayerDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/PlayerApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<PlayerDto>>().Result;
            }
        }

        public PlayerDto Add(PlayerDto playerDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/PlayerApi/", playerDto).Result;
                return response.Content.ReadAsAsync<PlayerDto>().Result;
            }
        }

        public PlayerDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/PlayerApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<PlayerDto>().Result;
            }
        }

        public PlayerDto Update(PlayerDto PlayerDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:9372/api/PlayerApi/" + PlayerDto.Id, PlayerDto).Result;
                return response.Content.ReadAsAsync<PlayerDto>().Result;
            }
        }

        public PlayerDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/PlayerApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<PlayerDto>().Result;
            }
        }
    }
}
