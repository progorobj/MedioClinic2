using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
	public interface IRepository<TDto>
	{

		/// <summary>
		/// Gets all items from the source.
		/// </summary>
		/// <returns>All items.</returns>
		IEnumerable<TDto> GetAll();

		/// <summary>
		/// Gets all items from the source asynchronously.
		/// </summary>
		/// <returns>All items.</returns>
		Task<IEnumerable<TDto>> GetAllAsync(CancellationToken? cancellationToken = default);
	}
}
