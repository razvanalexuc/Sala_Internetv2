using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase;
using System.Collections;
using System.Configuration;

namespace Administrare_Fisier
{
    public class AdministrarePersoane_FisierText
    {
        private const int NR_PERSOANE = 50;
        private string numeFisier;
        public AdministrarePersoane_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate); 
            streamFisierText.Close(); 
        }

        public void AddPersoane(Persoana persoana)
        {
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
                {
                    streamWriterFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
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

            public Persoana[] GetPersoane (out int nrPers)
        {
            Persoana[] persoane = new Persoana[NR_PERSOANE];

            using(StreamReader streamReader = new StreamReader (numeFisier))
            {
                string linieFisier;
                nrPers = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoane[nrPers++] = new Persoana(linieFisier);
                }
                
            }
            return persoane;
        }

        public ArrayList GetPersoane()
        {
            ArrayList persoane = new ArrayList();

            try
            {
                using (StreamReader streamReader = new StreamReader(numeFisier))
                {
                    string linieFisier;

                    while ((linieFisier = streamReader.ReadLine()) != null)
                    {
                        Persoana persoana = new Persoana(linieFisier);
                        persoane.Add(persoana);
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

            return persoane;

        }

        public bool EditarePersoana(int index, Persoana persoanaEditata)
        {
            ArrayList persoane = GetPersoane();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Persoana persoana in persoane)
                    {
                        Persoana persoanaPentruScrisInFisier = persoana;
                        if (persoane[index] == persoana)
                        {
                            persoanaPentruScrisInFisier = persoanaEditata;
                        }
                        streamWriterFisierText.WriteLine(persoanaPentruScrisInFisier.ConversieLaSir_PentruFisier());
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

        public bool StergePersoana(int index)
        {
            ArrayList persoane = GetPersoane();
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Persoana persoana in persoane)
                    {
                        if (i != index)
                        {
                            streamWriterFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
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

        public Persoana CautarePersoana (string nume_pers, string cod_pers)
        {
            Persoana persoana = new Persoana();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoana = new Persoana(linieFisier);
                    if (persoana.GetNume() == nume_pers)
                    { return persoana;
                    }
                    continue;
                }
                return null;
                }

            }

        }
    }


