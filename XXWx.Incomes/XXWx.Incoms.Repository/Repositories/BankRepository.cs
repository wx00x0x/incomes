using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XXWx.Incoms.Model;
using XXWx.Incoms.Repository.Interfaces;

namespace XXWx.Incoms.Repository.Repositories
{
	public class BankRepository : IBankRepository, IGenericRepository<Bank, Guid>
	{
		public Guid? CreateOrUpdate(Bank entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Bank> GetAll()
		{
			throw new NotImplementedException();
		}

		public Bank GetById(Guid Id)
		{
			throw new NotImplementedException();
		}
	}
}
