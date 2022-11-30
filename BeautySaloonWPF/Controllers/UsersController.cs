using BeautySaloonWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonWPF.Controllers
{
    public static class UsersController
    {
        public static bool Auth(string login, string password) 
        { 
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/{login}/{password}").Result;
                
                return response.IsSuccessStatusCode;

            }
        }
    }
}
