using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface ICalendarioRepository: IModel<Calendario>
	{
		void Delete(Calendario calendario);
		void QuitarLista(Calendario calendario);
	}
}
