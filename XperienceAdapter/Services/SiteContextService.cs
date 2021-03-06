using System;
using Microsoft.AspNetCore.Http;
using Kentico.Web.Mvc;
using Kentico.Content.Web.Mvc;

namespace XperienceAdapter.Services
{
	public class SiteContextService : ISiteContextService
	{
		public bool IsPreviewEnabled => HttpContextAccessor.HttpContext.Kentico().Preview().Enabled;

		private IHttpContextAccessor HttpContextAccessor { get; }

		public SiteContextService(IHttpContextAccessor httpContextAccessor)
		{
			HttpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
		}
	}
}
