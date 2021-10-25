using Core.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XperienceAdapter.Localization;

namespace MedioClinic1.Controllers
{
	public class FormTestController : BaseController
	{
		public FormTestController(ILogger<BaseController> logger,
							  IOptionsMonitor<XperienceOptions> optionsMonitor,
							  IStringLocalizer<SharedResource> stringLocalizer)
			: base(logger, optionsMonitor, stringLocalizer)
		{
		}

		public async Task<IActionResult> Index() => View();
	}
}
