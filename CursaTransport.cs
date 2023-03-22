using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    

    public class CursaTransport
    {
        public int ID { get; set; }
        public DateTime DataPlecare { get; set; }
        public string OrasPlecare { get; set; }
        public string OrasDestinatie { get; set; }
        public int LocuriDisponibile { get; set; }
        public List<Vehicul> VehiculeDisponibile { get; set; }
        public List<Sofer> SoferiDisponibili { get; set; }

        public CursaTransport(int id, DateTime dataPlecare, string orasPlecare, string orasDestinatie, int locuriDisponibile)
        {
            ID = id;
            DataPlecare = dataPlecare;
            OrasPlecare = orasPlecare;
            OrasDestinatie = orasDestinatie;
            LocuriDisponibile = locuriDisponibile;
            VehiculeDisponibile = new List<Vehicul>();
            SoferiDisponibili = new List<Sofer>();
        }

        public void AdaugaVehiculDisponibil(Vehicul vehicul)
        {
            VehiculeDisponibile.Add(vehicul);
        }

        public void AdaugaSoferDisponibil(Sofer sofer)
        {
            SoferiDisponibili.Add(sofer);
        }

        public override string ToString()
        {
            return $"Cursa cu ID {ID} pe data de {DataPlecare.ToShortDateString()} de la ora {DataPlecare.ToShortTimeString()} din {OrasPlecare} către {OrasDestinatie} cu {LocuriDisponibile} locuri disponibile.";
        }
    }

    public class Vehicul
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }

        public Vehicul(string marca, string model, int anFabricatie)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
        }

        public override string ToString()
        {
            return $"{Marca} {Model} fabricat în anul {AnFabricatie}.";
        }
    }

    public class Sofer
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }

        public Sofer(string nume, string prenume, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
        }

        public override string ToString()
        {
            return $"{Nume} {Prenume}, varsta {Varsta} ani.";
        }
    }
}
