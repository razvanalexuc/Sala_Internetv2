using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Periferice
	{
		private const char SEPARATOR_PRINCIPAL_FISIER = ';';
		public string Monitor { get; set; }
		public string Mouse { get; set; }
		public string Tastatura { get; set; }
		public string Casti { get; set; }

		public int IdSetPerif; // Identificatorul unic al setului de periferice
		private const int ID = 0;
		private const int MONITOR = 1;
		private const int MOUSE = 2;
		private const int TASTATURA = 3;
		private const int CASTI = 4;

		public Periferice()
        {
			Monitor = string.Empty;
			Mouse = string.Empty;
			Tastatura = string.Empty;
			Casti = string.Empty;
        }

		public Periferice(int idsetperif, string monitor, string mouse, string tastatura, string casti)
		{
			this.IdSetPerif = idsetperif;
			this.Monitor = monitor;
			this.Mouse = mouse;
			this.Tastatura = tastatura;
			this.Casti = casti;
		}

		public void SetCodPeriferice(int id)
		{
			IdSetPerif = id;
		}

		public Periferice(string linieFisier)
		{
			var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

			IdSetPerif = Convert.ToInt32(dateFisier[ID]);
			Monitor = dateFisier[MONITOR];
			Mouse = dateFisier[MOUSE];
			Tastatura = dateFisier[TASTATURA];
			Casti = dateFisier[CASTI];
		}

		public string ConversieLaSir_PentruFisier()
		{
			string obiectPerifericePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
				SEPARATOR_PRINCIPAL_FISIER,
				IdSetPerif.ToString(),
				(Monitor ?? " NECUNOSCUT "),
				(Mouse ?? " NECUNOSCUT "),
				(Tastatura ?? " NECUNOSCUT "),
				(Casti ?? " NECUNOSCUT "));
			return obiectPerifericePentruFisier;
		}
		public string ConversieLaSir_PentruAfisare()
		{
			return $"id: {IdSetPerif}, monitor: {Monitor}, mouse: {Mouse}, Tastatura: {Tastatura}, casti: {Casti}";

		}


		public void StergePeriferice()
		{
		}

		public int GetIdSetPerif()
		{
			return IdSetPerif;
		}

		public string Getmonitor()
        {
			return Monitor;
        }

		public string Getmouse()
        {
			return Mouse;
        }

		public string Gettastatura()
        {
			return Tastatura;
        }

		public string Getcasti()
        {
			return Casti;
        }



	}
}
