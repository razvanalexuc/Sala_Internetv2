using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase;
using System.Collections;

namespace Administrare_Fisier
{
    public class AdministrarePeriferice_FisierText
    {
        private const int NR_PERIFERICE = 50;
        private string numeFisier;
        public AdministrarePeriferice_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


        public Periferice GetPeriferic(int IdSetPerif)
        {
            ArrayList periferice = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Periferice idsetDinFisier = new Periferice(line);
                        if (idsetDinFisier.IdSetPerif == IdSetPerif)
                            return idsetDinFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }

            return null;
        }

        public void AddPeriferice(Periferice periferic)
        {
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    streamWriterFisierText.WriteLine(periferic.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }
        }

        public Periferice[] GetPeriferice(out int nrPeriferice)
        {
            Periferice[] periferic = new Periferice[NR_PERIFERICE];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrPeriferice = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    periferic[nrPeriferice++] = new Periferice(linieFisier);
                }

            }
            return periferic;
        }



        public ArrayList GetPeriferice()
        {
            ArrayList periferice = new ArrayList();

            try
           { 
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Periferice periferic = new Periferice(linieFisier);
                    periferice.Add(periferic);
                }
                
            }
        }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }

            return periferice;
        }

        public bool EditarePeriferic(int index, Periferice perifericEditat)
        {
            ArrayList periferice = GetPeriferice();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Periferice periferic in periferice)
                    {
                        Periferice perifericPentruScrisInFisier = periferic;

                        if (periferice[index] == periferic)
                        {
                            perifericPentruScrisInFisier = perifericEditat;
                        }
                        streamWriterFisierText.WriteLine(perifericPentruScrisInFisier.ConversieLaSir_PentruFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }
            return actualizareCuSucces;
        }

        public bool StergerePeriferic(int index)
        {
            ArrayList periferice = GetPeriferice();
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Periferice periferic in periferice)
                    {
                        if (i != index)
                        {
                            streamWriterFisierText.WriteLine(periferic.ConversieLaSir_PentruFisier());
                        }
                        i++;
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
            }
            return actualizareCuSucces;
        }


        public Periferice CautarePeriferic(string nume_periferic, string cod_periferic)
        {
            Periferice periferic = new Periferice();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    periferic = new Periferice(linieFisier);
                    if (periferic.Getmonitor() == nume_periferic)
                    {
                        return periferic;
                    }
                    continue;
                }
                return null;
            }

        }

    }

   
}

