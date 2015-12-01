using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGateway.Services
{
    public class NewsGatewayService
    {
        public IEnumerable<NewsDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/NewsApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<NewsDto>>().Result;
            }
        }

        public NewsDto Add(NewsDto newsDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/NewsApi/", newsDto).Result;
                return response.Content.ReadAsAsync<NewsDto>().Result;
            }
        }

        public NewsDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/NewsApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<NewsDto>().Result;
            }
        }

        public NewsDto Update(NewsDto newsDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/NewsApi/", newsDto.Id).Result;
                return response.Content.ReadAsAsync<NewsDto>().Result;
            }
        }

        public NewsDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/NewsApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<NewsDto>().Result;
            }
        }
    }
}
