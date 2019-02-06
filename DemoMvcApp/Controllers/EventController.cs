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
using DemoMvcApp.Helper;
using DemoMvcApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DemoMvcApp.Models.ViewModels;

namespace DemoMvcApp.Controllers
{
    public class EventController : Controller
    {
        private IConfiguration _config;

        public EventController(IConfiguration config)
        {
            _config = config;
        }

        private string token;

        NameLessAPI _api = new NameLessAPI();

        public async Task<ActionResult> Index(long tournamentID)
        {
            //List<TournamentDisplayViewModel> tournaments = new List<TournamentDisplayViewModel>();
            List<TournamentEventListViewModel> model = new List<TournamentEventListViewModel>();
            List<EventDisplayViewModel> eventsListVm = new List<EventDisplayViewModel>();

            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = await client.GetAsync("tournament");

            var result = response.Content.ReadAsStringAsync().Result;
            var tournament = JsonConvert.DeserializeObject<List<TournamentDisplayViewModel>>(result);
            foreach (var x in tournament)
            {
                var tournamentEventsListVm = new TournamentEventListViewModel()
                {
                    TournamentID = x.TournamentID,
                    TournamentName = x.TournamentName
                };

                HttpResponseMessage responseTwo = await client.GetAsync("event/" + tournamentID);

                var resultTwo = response.Content.ReadAsStringAsync().Result;
                var events = JsonConvert.DeserializeObject<List<EventDisplayViewModel>>(result);
                foreach (var y in events.ToList())
                {
                    eventsListVm.Add(new EventDisplayViewModel
                        {
                        EventID = y.EventID,
                        EventName = y.EventName,
                        EventNumber = y.EventNumber,
                        EventDateTime = y.EventDateTime,
                        EventEndDateTime = y.EventEndDateTime,
                        AutoClose = y.AutoClose
                    });

                    tournamentEventsListVm.Events = eventsListVm;
                }
                model = tournamentEventsListVm;
            }
            return View(model);
        }

    //public async Task<IActionResult> CreateorEdit(long id = 0)
    //{
    //    if (id == 0)
    //    {
    //        return View(new EventDisplayViewModel());
    //    }
    //    else
    //    {
    //        token = await GetApiToken();

    //        HttpClient client = _api.Initial();

    //        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

    //        HttpResponseMessage response = await client.GetAsync("Event/" + id.ToString());

    //        return View(response.Content.ReadAsAsync<EventDisplayViewModel>().Result);
    //    }
    //}

    [HttpPost]
        public async Task<IActionResult> Index(TournamentEventListViewModel model)
        {
            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            if (model.Events != null)
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("Event", model);
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            return View(model);

            //if (Event.EventID == 0)
            //{
            //    HttpResponseMessage response = await client.PostAsJsonAsync("Event", Event);
            //    TempData["SuccessMessage"] = "Saved Successfully";
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    HttpResponseMessage response = await client.PutAsJsonAsync("Event/" + Event.EventID, Event);
            //    TempData["SuccessMessage"] = "Updated Successfully";
            //    return RedirectToAction("Index");
            //}
        }

        public async Task<IActionResult> Delete(long id)
        {
            token = await GetApiToken();

            HttpClient client = _api.Initial();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpResponseMessage response = await client.DeleteAsync("Event/" + id.ToString());
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
