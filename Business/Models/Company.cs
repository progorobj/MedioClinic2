using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using XperienceAdapter.Models;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Models
{
	public class Company : BasePage
	{
		public override IEnumerable<string> SourceColumns => base.SourceColumns.Concat(new[]
		{
		"Street",
		"City",
		"Country",
		"PostalCode",
		"EmailAddress",
		"PhoneNumber"
	});

		public string? Street { get; set; }

		public string? City { get; set; }

		[UIHint("Country")]
		public string? Country { get; set; }

		public string? PostalCode { get; set; }

		[EmailAddress]
		public string? EmailAddress { get; set; }

		public string? PhoneNumber { get; set; }
	}

	/// <summary>
	/// Stores company information.
	/// </summary>
	public class CompanyRepository : BasePageRepository<Models.Company, CMS.DocumentEngine.Types.MedioClinic.Company>
	{
		public override void MapDtoProperties(CMS.DocumentEngine.Types.MedioClinic.Company page, Models.Company dto)
		{
			dto.City = page.City;
			dto.Country = page.Country;
			dto.EmailAddress = page.EmailAddress;
			dto.PhoneNumber = page.PhoneNumber;
			dto.PostalCode = page.PostalCode;
			dto.Street = page.Street;
		}

		public CompanyRepository(IRepositoryServices repositoryDependencies) : base(repositoryDependencies)
		{
		}
	}
}
