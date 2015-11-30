using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServiceGateway.Services
{
    public class ContactGatewayService
    {
        public IEnumerable<ContactsDto> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/Contact/").Result;
                return response.Content.ReadAsAsync<IEnumerable<ContactsDto>>().Result;
            }
        }

        public ContactsDto Add(ContactsDto contactsDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/Contacts/", contactsDto).Result;
                return response.Content.ReadAsAsync<ContactsDto>().Result;
            }
        }

        public ContactsDto Delete(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:9372/api/Contacts/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<ContactsDto>().Result;
            }
        }

        public ContactsDto Update(ContactsDto contactsDto)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:9372/api/Contacts/", contactsDto.Id).Result;
                return response.Content.ReadAsAsync<ContactsDto>().Result;
            }
        }

        public ContactsDto Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:9372/api/Contacts/" + id.ToString()).Result;
                return response.Content.ReadAsAsync<ContactsDto>().Result;
            }
        }
    }
}
