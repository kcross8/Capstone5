using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Capstone5CarDealership.Models
{
    public class CarsAPIDAL
    {
        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44350/");
            return client;
        }
        public async Task<List<Cars>> GetCars()
        {
            var client = GetHttpClient();
            var response = await client.GetAsync("api/cars");
            var cars = await response.Content.ReadAsAsync<List<Cars>>();
            return cars;
        }
        public async Task<Cars> GetCar(int id)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/cars/{id}");
            var car = await response.Content.ReadAsAsync<Cars>();
            return car;
        }
        public async void DeleteCar(int id)
        {
            var client = GetHttpClient();
            var response = await client.DeleteAsync($"api/cars/{id}");
        }
        public async void AddCars(Cars car)
        {
            //car.Id = 1;
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync($"api/cars", car);
            //var carResult = await response.Content.ReadAsAsync<Cars>();
            //return carResult;
        }
        public async void UpdateCar(int id, Cars updatedCar)
        {
            var client = GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/cars/{id}", updatedCar);
        }
    }
}
