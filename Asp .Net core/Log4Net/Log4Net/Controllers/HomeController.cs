﻿using Log4Net.Models;
using Log4Net_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Log4Net.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILoggerManager _logger;

		public HomeController(ILoggerManager logger)
		{
			_logger = logger;

		}

		public IActionResult Index()
		{
			_logger.LogInformation("Running Index");
			return View();
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
