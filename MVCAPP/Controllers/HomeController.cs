﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using MVCAPP.Models;
using Newtonsoft.Json;
using MVCAPP.Utility;
namespace MVCAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Employee> employee = null;
            try
            {

                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("http://localhost:51780/api/values");
                httpClient.DefaultRequestHeaders.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var responseMessage = httpClient.GetAsync("http://localhost:51780/api/values").Result;
                if (responseMessage != null)
                {
                    string data = responseMessage.Content.ReadAsStringAsync().Result;
                    employee = JsonConvert.DeserializeObject<List<Employee>>(data);
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.LogError(ex);
            }

            return View(employee);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
           
            return View();
        }
    }
}