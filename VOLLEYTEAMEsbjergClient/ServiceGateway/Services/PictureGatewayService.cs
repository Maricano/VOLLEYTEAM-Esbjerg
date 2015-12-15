using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DtoModel;

namespace ServiceGateway.Services
{
    public class PictureGatewayService
    {
        public IEnumerable<PictureDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:9372/api/PictureApi").Result;
                return response.Content.ReadAsAsync<IEnumerable<PictureDto>>().Result;
            }
        }

        public PictureDto Add(PictureDto pictureDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:9372/api/PictureApi", pictureDto).Result;
                return response.Content.ReadAsAsync<PictureDto>().Result;
            }
        }

        public PictureDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync("http://localhost:9372/api/PictureApi" + id).Result;
                return response.Content.ReadAsAsync<PictureDto>().Result;
            }
        }

        public PictureDto Update(PictureDto pictureDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/PictureApi" + pictureDto.Id, pictureDto).Result;
                return response.Content.ReadAsAsync<PictureDto>().Result;
            }
        }

        public PictureDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/PictureApi" + id.ToString()).Result;
                return response.Content.ReadAsAsync<PictureDto>().Result;
            }
        }
    }
}
