using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DtoModel;

namespace ServiceGateway.Services
{
  public  class EnglishGatewayService
  {
      public IEnumerable<EnglishDto> ReadAll()
      {
          using (var client = new HttpClient())
          {
              HttpResponseMessage response = client.GetAsync("http://localhost:9372/api/EnglishApi").Result;
              return response.Content.ReadAsAsync<IEnumerable<EnglishDto>>().Result;
          }
      }

      public EnglishDto Add(EnglishDto englishDto)
      {
          using (var client = new HttpClient())
          {
              HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:9372/api/EnglishApi",englishDto).Result;
              return response.Content.ReadAsAsync<EnglishDto>().Result;
          }
      }

      public EnglishDto Delete(int Id)
      {
          using (var client = new HttpClient())
          {
              HttpResponseMessage response =
                  client.DeleteAsync("http://localhost:9372/api/EnglishApi" +Id.ToString()).Result;
              return response.Content.ReadAsAsync<EnglishDto>().Result;
          }
      }

      public EnglishDto Update(EnglishDto englishDto)
      {
          using (var client = new HttpClient())
          {
              HttpResponseMessage response =
                  client.PutAsJsonAsync("http://localhost:9372/api/EnglishApi" + englishDto.Id, englishDto).Result;
              return response.Content.ReadAsAsync<EnglishDto>().Result;
          }
      }

      public EnglishDto Read(int Id)
      {
          using (var client = new HttpClient())
          {
              HttpResponseMessage response = client.GetAsync("http://localhost:9372/api/EnglishApi" + Id.ToString()).Result;
              return response.Content.ReadAsAsync<EnglishDto>().Result;
          }
      }

  }
}
