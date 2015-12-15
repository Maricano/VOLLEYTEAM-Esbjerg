using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGateway.Services
{
    public class RoleGatewayService
    {
        public IEnumerable<RoleDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/RoleApi/").Result;
                return response.Content.ReadAsAsync<IEnumerable<RoleDto>>().Result;
            }
        }

        public RoleDto Add(RoleDto roleDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/RoleApi/", roleDto).Result;
                return response.Content.ReadAsAsync<RoleDto>().Result;
            }
        }

        public RoleDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/RoleApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<RoleDto>().Result;
            }
        }

        public RoleDto Update(RoleDto roleDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:9372/api/RoleApi/" + roleDto.Id, roleDto).Result;
                return response.Content.ReadAsAsync<RoleDto>().Result;
            }
        }

        public RoleDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/RoleApi/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<RoleDto>().Result;
            }
        }
    }
}
