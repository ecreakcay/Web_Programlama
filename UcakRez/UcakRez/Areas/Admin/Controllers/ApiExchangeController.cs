﻿using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UcakRez.Areas.Admin.Models;

namespace UcakRez.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://corona-virus-world-and-india-data.p.rapidapi.com/api"),
                Headers =
    {
        { "X-RapidAPI-Key", "6225f49b2emshd09ddf57fb2a584p1d6031jsn324adda27882" },
        { "X-RapidAPI-Host", "corona-virus-world-and-india-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingExchangeViewModel>(body);
                return View(values.countries_stat);
            }
        }
    }
}
