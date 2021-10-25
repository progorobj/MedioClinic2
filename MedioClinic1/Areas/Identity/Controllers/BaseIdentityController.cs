using Core.Configuration;
using Identity.Models;
using Kentico.Content.Web.Mvc;
using MedioClinic1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XperienceAdapter.Localization;

namespace MedioClinic1.Areas.Identity.Controllers
{
	public class BaseIdentityController : BaseController
	{
		private readonly IPageUrlRetriever _pageUrlRetriever;

		public BaseIdentityController(
			ILogger<BaseController> logger,
			IOptionsMonitor<XperienceOptions> optionsMonitor,
			IStringLocalizer<SharedResource> stringLocalizer,
			IPageUrlRetriever pageUrlRetriever)
			: base(logger, optionsMonitor, stringLocalizer)
		{
			_pageUrlRetriever = pageUrlRetriever ?? throw new ArgumentNullException(nameof(pageUrlRetriever));
		}

		protected void AddIdentityErrors<TResultState>(IdentityManagerResult<TResultState> result)
			where TResultState : Enum
		{
			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(string.Empty, error);
			}
		}

		/// <summary>
		/// Gets the home page URL.
		/// </summary>
		/// <returns>Home page URL.</returns>
		protected string GetHomeUrl() =>
			_pageUrlRetriever.Retrieve("/Home").RelativePath;


		/// <summary>
		/// Redirects to a local URL.
		/// </summary>
		/// <param name="returnUrl">Local URL to redirect to.</param>
		/// <returns>Redirect to a URL.</returns>
		protected ActionResult RedirectToLocal(string returnUrl)
		{
			if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}

			return RedirectToLocal(GetHomeUrl());
		}
	}
}
