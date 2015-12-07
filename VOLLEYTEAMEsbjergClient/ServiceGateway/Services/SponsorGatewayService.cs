using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGateway.Services
{
    public class SponsorGatewayService
    {
        public IEnumerable<SponsorDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/SponsorApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<SponsorDto>>().Result;
            }
        }

        public SponsorDto Add(SponsorDto sponsorDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/SponsorApi/", sponsorDto).Result;
                return response.Content.ReadAsAsync<SponsorDto>().Result;
            }
        }

        public SponsorDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/SponsorApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<SponsorDto>().Result;
            }
        }

        public SponsorDto Update(SponsorDto sponsorDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:9372/api/SponsorApi/"+ sponsorDto.Id, sponsorDto).Result;
                return response.Content.ReadAsAsync<SponsorDto>().Result;
            }
        }

        public SponsorDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/SponsorApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<SponsorDto>().Result;
            }
        }
    }
}
