using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Repositories
{
	public class EventLandingPageRepository : BasePageRepository<EventLandingPage, CMS.DocumentEngine.Types.MedioClinic.EventLandingPage>
	{
		public EventLandingPageRepository(IRepositoryServices repositoryServices) : base(repositoryServices)
		{
		}

		public override void MapDtoProperties(CMS.DocumentEngine.Types.MedioClinic.EventLandingPage page, EventLandingPage dto)
		{
			dto.EventDate = page.EventDate;
		}
	}
}
