﻿using Microsoft.AspNetCore.Mvc;

namespace ChatApplication.Controllers
{

    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
