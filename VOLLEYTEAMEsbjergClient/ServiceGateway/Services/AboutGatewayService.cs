using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DtoModel;

namespace ServiceGateway.Services
{
    public class AboutGatewayService
    {
        public IEnumerable<AboutDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/AboutApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<AboutDto>>().Result;
            }
        }

        public AboutDto Add(AboutDto aboutDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/AboutApi/", aboutDto).Result;
                return response.Content.ReadAsAsync<AboutDto>().Result;
            }
        }

        public AboutDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/AboutApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<AboutDto>().Result;
            }
        }

        public AboutDto Update(AboutDto aboutDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/AboutApi/", aboutDto.Id).Result;
                return response.Content.ReadAsAsync<AboutDto>().Result;
            }
        }

        public AboutDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/AboutApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<AboutDto>().Result;
            }
        }
    }
}
