using Kentico.Forms.Web.Mvc;
using MedioClinic1.Components;
using MedioClinic1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedioClinic1.PageTemplates
{
	public class EventTemplateProperties : PageTemplateProperties
	{
		[EditingComponent(ComponentIdentifiers.AirportSelectionFormComponent,
			Label = "{$" + ComponentIdentifiers.AirportSelectionFormComponent + ".LocationAirport$}",
			Order = 0)]
		public string? EventLocationAirport { get; set; }
	}
}
