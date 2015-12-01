using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DtoModel;

namespace ServiceGateway.Services
{
    public class BoardGatewayService
    {
        public IEnumerable<BoardDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/BoardApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<BoardDto>>().Result;
            }
        }

        public BoardDto Add(BoardDto boardDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/BoardApi/", boardDto).Result;
                return response.Content.ReadAsAsync<BoardDto>().Result;
            }
        }

        public BoardDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/BoardApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<BoardDto>().Result;
            }
        }

        public BoardDto Update(BoardDto boardDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/BoardApi/", boardDto.Id).Result;
                return response.Content.ReadAsAsync<BoardDto>().Result;
            }
        }

        public BoardDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/BoardApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<BoardDto>().Result;
            }
        }
    }
}
