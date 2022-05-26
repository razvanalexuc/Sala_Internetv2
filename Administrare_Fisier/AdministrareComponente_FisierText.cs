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
    public class AdministrareComponente_FisierText
    {
        private const int NR_Componente = 50;
        private string numeFisier;
        public AdministrareComponente_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddComponente(Componente componenta)
        {
            try
        { 
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(componenta.ConversieLaSir_PentruFisier());
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

        public Componente[] GetComponente(out int nrComp)
        {
            Componente[] componenta = new Componente[NR_Componente];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrComp = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    componenta[nrComp++] = new Componente(linieFisier);
                }

            }
            return componenta;
        }

        public Componente GetComponent(int IdSetComp)
        {
            ArrayList componente = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Componente idsetDinFisier = new Componente(line);
                        if (idsetDinFisier.IdSetComp == IdSetComp)
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

        public ArrayList GetComponente()
        {
            ArrayList componente = new ArrayList();
            try
        { 
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Componente componenta = new Componente(linieFisier);
                    componente.Add(componenta);
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

            return componente;
        }


        public bool EditareComponenta(int index, Componente componentaEditat)
        {
            ArrayList componente = GetComponente();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Componente componenta in componente)
                    {
                        Componente componentaPentruScrisInFisier = componenta;

                        if (componente[index] == componenta)
                        {
                            componentaPentruScrisInFisier = componentaEditat;
                        }
                        streamWriterFisierText.WriteLine(componentaPentruScrisInFisier.ConversieLaSir_PentruFisier());
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


        public bool StergereComponenta(int index)
        {
            ArrayList componente = GetComponente();
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Componente componenta in componente)
                    {
                        if (i != index)
                        {
                            streamWriterFisierText.WriteLine(componenta.ConversieLaSir_PentruFisier());
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



        public Componente CautareComponenta(string nume_comp, string cod_comp)
        {
            Componente componenta = new Componente();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    componenta = new Componente(linieFisier);
                    if (componenta.GetMOBO() == nume_comp)
                    {
                        return componenta;
                    }
                    continue;
                }
                return null;
            }

        }

    }
}

