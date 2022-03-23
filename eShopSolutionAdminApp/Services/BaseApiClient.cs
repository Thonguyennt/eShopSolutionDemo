using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Utilities.Constants;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace eShopSolutionAdminApp.Services
{
    public class BaseApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected BaseApiClient(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public BaseApiClient()
        {
        }

        protected async Task<TResponse> GetAsync<TResponse>(string url)
        {
            var client = GetHeader();
            var response = await client.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TResponse myDeserializedObjList = (TResponse)JsonConvert.DeserializeObject(body, typeof(TResponse));
                return myDeserializedObjList;
            }

            return JsonConvert.DeserializeObject<TResponse>(body);
        }


        public async Task<List<T>> GetListAsync<T>(string url, bool requiredLogin = false)
        {

            var client = GetHeader();
            var response = await client.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var data = (List<T>)JsonConvert.DeserializeObject(body, typeof(List<T>));
                return data;
            }
            throw new Exception(body);
        }

        protected async Task<TResponse> AddAsync<TResponse>(string url, dynamic request)
        {
            var client = GetHeader();
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, httpContent);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync());
            }
            return JsonConvert.DeserializeObject<TResponse>(await response.Content.ReadAsStringAsync());
        }

        protected async Task<TResponse> DeleteAsync<TResponse>(string url)
        {
            var client = GetHeader();
            var response = await client.DeleteAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TResponse>(body);
            }

            return JsonConvert.DeserializeObject<TResponse>(body);
        }

        protected async Task<TResponse> UpdateAsync<TResponse>(string url, dynamic request)
        {
            var client = GetHeader();
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TResponse>(result);
            }
            return JsonConvert.DeserializeObject<TResponse>(result);
        }



        protected HttpClient GetHeader()
        {
            var session = _httpContextAccessor
            .HttpContext
            .Session
            .GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);

            return client;
        }

        protected string LanguageId()
        {
            return _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);
        }


    }
}
