using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MedioClinic1.Models
{
	public class PageTemplateProperties : IPageTemplateProperties
	{
		[JsonIgnore]
		public UserMessage? UserMessage { get; set; }
	}
}
