using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MvcApp.Helper;
using MvcApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MvcApp.Controllers
{
    public class TournamentController : Controller
    {
        private IConfiguration _config;

        public TournamentController(IConfiguration config)
        {
            _config = config;
        }

        private string token;

        NameLessAPI _api = new NameLessAPI();

        public async Task<IActionResult> Index()
        {
            List<Tournament> tournament = new List<Tournament>();

            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = await client.GetAsync("tournament");

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                tournament = JsonConvert.DeserializeObject<List<Tournament>>(result);
            }

            return View(tournament);
        }


        public async Task<IActionResult> Details(long id)
        {
            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = await client.GetAsync("tournament/" + id.ToString());

            return View(response.Content.ReadAsAsync<Tournament>().Result);
        }


        public async Task<IActionResult> CreateorEdit(long id = 0)
        {
            if (id == 0)
            {
                return View(new Tournament());
            }
            else
            {
                token = await GetApiToken();

                HttpClient client = _api.Initial();

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                HttpResponseMessage response = await client.GetAsync("tournament/" + id.ToString());              

                return View(response.Content.ReadAsAsync<Tournament>().Result);
            }           
        }

        [HttpPost]
        public async Task<IActionResult> CreateorEdit(Tournament tournament)
        {
            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            if (tournament.TournamentID == 0)
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("tournament", tournament);
                TempData["SuccessMessage"] = "Saved Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                HttpResponseMessage response = await client.PutAsJsonAsync("tournament/" + tournament.TournamentID, tournament);
                TempData["SuccessMessage"] = "Updated Successfully";
                return RedirectToAction("Index");
            }

            
        }

        public async Task<IActionResult> Delete(long id)
        {
            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = await client.DeleteAsync("tournament/" + id.ToString());
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");

        }

        public async Task<string> GetApiToken()
        {
            HttpClient client = _api.Initial();

            string myJson = "{'UserName':'testuser','Password': 'notanotherpassword'}";

            HttpResponseMessage responseMessage = await client.PostAsync("users/auth", new StringContent(myJson, Encoding.UTF8, "application/json"));

            var responseJson = responseMessage.Content.ReadAsStringAsync().Result;
            var jObject = JObject.Parse(responseJson);
            return jObject.GetValue("token").ToString();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
