using Business.Models;
using CMS.CustomTables;
using CMS.DataEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CMS.CustomTables.Types.MedioClinic;

namespace Business.Repositories
{
	public class AirportRepository : IAirportRepository
	{
		private static ObjectQuery<AirportsItem> GetQuery(Func<ObjectQuery<AirportsItem>, ObjectQuery<AirportsItem>>? filter)
		{
			var query = CustomTableItemProvider.GetItems<AirportsItem>();

			if (filter != null)
			{
				query = filter(query);
			}

			return query;
		}

		private static Airport MapDtoProperties(AirportsItem item) => new Airport
		{
			AirportIataCode = item.AirportIataCode,
			AirportName = item.AirportName
		};

		private async Task<IEnumerable<Airport>> GetResultAsync(
	Func<ObjectQuery<AirportsItem>, ObjectQuery<AirportsItem>>? filter,
	CancellationToken? cancellationToken)
		{
			var query = GetQuery(filter);

			return (await query.GetEnumerableTypedResultAsync(cancellationToken: cancellationToken))
				.Select(item => MapDtoProperties(item));
		}

		private IEnumerable<Airport> GetResult(Func<ObjectQuery<AirportsItem>, ObjectQuery<AirportsItem>>? filter)
		{
			var query = GetQuery(filter);

			return query.GetEnumerableTypedResult()
				.Select(item => MapDtoProperties(item));
		}

		private const string Name = "AirportName";

		public IEnumerable<Airport> GetAll() => GetResult(null);

		public async Task<IEnumerable<Airport>> GetAllAsync(CancellationToken? cancellationToken = default) =>
			await GetResultAsync(null, cancellationToken);

		public async Task<IEnumerable<Airport>> GetBySearchPhraseAsync(string? searchPhrase = default,
			CancellationToken? cancellationToken = default) =>
			!string.IsNullOrEmpty(searchPhrase)
			? await GetResultAsync(filter => filter
				.WhereContains(Name, searchPhrase),
				cancellationToken)
			: Enumerable.Empty<Airport>();
	}
}
