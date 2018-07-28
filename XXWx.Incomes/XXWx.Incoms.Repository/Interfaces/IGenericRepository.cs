using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XXWx.Incoms.Repository.Interfaces
{
	public interface IGenericRepository<T, Key> where T: new() where Key: struct
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		T GetById(Key Id);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		IEnumerable<T> GetAll();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		Nullable<Key> CreateOrUpdate(T entity);
	}
}
