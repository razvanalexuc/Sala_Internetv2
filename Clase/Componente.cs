using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
      public class Componente
	{
		private const char SEPARATOR_PRINCIPAL_FISIER = ';';

		public string Mobo { get; set; }
		public int Ram { get; set; }
		public string Cpu { get; set; }
		public string Gpu { get; set; }
		public string Cooler { get; set; }
		public string Hdd { get; set; }
		public string Ssd { get; set; }

		public int IdSetComp; // identificatorul unic al setului de componente
		public const int ID = 0;
		public const int MOBO = 1;
		public const int RAM = 2;
		public const int CPU = 3;
		public const int GPU = 4;
		public const int COOLER = 5;
		public const int HDD = 6;
		public const int SSD = 7;

		public Componente()
        {
			Mobo = string.Empty;
			Ram = 0;
			Cpu = string.Empty;
			Gpu = string.Empty;
			Cooler = string.Empty;
			Hdd = string.Empty;
			Ssd = string.Empty;
        }
		public Componente(int idsetcomp, string mobo, int ram, string procesor, string placa, string cool, string HardDisk, string SolidDrive)
		{
			this.IdSetComp = idsetcomp;
			this.Mobo = mobo;
			this.Ram = ram;
			this.Cpu = procesor;
			this.Gpu = placa;
			this.Cooler = cool;
			this.Hdd = HardDisk;
			this.Ssd = SolidDrive;
		}

		public void SetcodComponenta(int id)
		{
			IdSetComp = id;
		}

		public Componente(string linieFisier)
		{
			var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

			IdSetComp = Convert.ToInt32(dateFisier[ID]);
			Mobo = dateFisier[MOBO];
			Ram = Convert.ToInt32(dateFisier[RAM]);
			Cpu = dateFisier[CPU];
			Gpu = dateFisier[GPU];
			Cooler = dateFisier[COOLER];
			Hdd = dateFisier[HDD];
			Ssd = dateFisier[SSD];
		}

		public string ConversieLaSir_PentruFisier()
		{
			string obiectComponentePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}",
				SEPARATOR_PRINCIPAL_FISIER,
				IdSetComp.ToString(),
				(Mobo ?? " NECUNOSCUT "),
				Ram.ToString(),
				(Cpu ?? " NECUNOSCUT "),
				(Gpu ?? " NECUNOSCUT "),
				(Cooler ?? " NECUNOSCUT "),
				(Hdd ?? " NECUNOSCUT "),
				(Ssd ?? " NECUNOSCUT "));
			return obiectComponentePentruFisier;
		}

		public string ConversieLaSir_PentruAfisare()
		{
			return $"id: {IdSetComp}, mobo: {Mobo}, ram: {Ram}, cpu: {Cpu}, gpu: {Gpu}, cooler: {Cooler}, hdd: {Hdd}, ssd: {Ssd}";

		}



		public int GetIdSetComp()
		{
			return IdSetComp;
		}

		public string GetMOBO()
        {
			return Mobo;
        }

		public int GetRAM()
        {
			return Ram;
        }

		public string GetCPU()
        {
			return Cpu;
        }

		public string Getcool()
        {
			return Cooler;
        }

		public string GetHardDisk()
        {
			return Hdd;
        }

		public string GetSolidDrive()
        {
			return Ssd;
        }

	}
}
