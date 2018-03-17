using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Github.Users.Common.Contracts;
using Github.Users.Common.Models;
using Newtonsoft.Json;

namespace Github.Users.Common.Concrete
{
    public class UsersRepository : IUsersRepository
    {
        private readonly HttpClient _client;

        public UsersRepository()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users")
            };
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var response = await _client.GetAsync(string.Empty);
            response.EnsureSuccessStatusCode();
            return await DeserializeResponse<IEnumerable<User>>(response);
        }
        
        private async Task<T> DeserializeResponse<T>(HttpResponseMessage message)
        {
            var jsonString = await message.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
