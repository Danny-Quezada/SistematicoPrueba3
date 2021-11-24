using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
	public class CalendarioListRepository : BaseRepository<Calendario>, ICalendarioRepository
	{
		public void Delete(Calendario calendario)
		{
			throw new NotImplementedException();
		}

		public void QuitarLista(Calendario calendario)
		{
			throw new NotImplementedException();
		}
	}
}
