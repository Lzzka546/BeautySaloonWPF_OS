using BeautySaloonWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonWPF.Controllers
{
    public static class UsersController
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Auth(string login, string password) 
        { 
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/{login}/{password}").Result;
                
                return response.IsSuccessStatusCode;

            }
        }
        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool AddUser(Users user)
        {
            string jsonStr=JsonConvert.SerializeObject(user);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage respons = client.PostAsync($"{Manager.RootUrl}Users", byteContent).Result;
                return respons.IsSuccessStatusCode;
            }
        }
    } 
}
