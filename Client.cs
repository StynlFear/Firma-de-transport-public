using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma_de_transport_public
{
    public class Client
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public List<string> IstoricCălătorii { get; set; }
        public List<string> PreferințePlată { get; set; }
    }

    public class ClientService
    {
        private List<Client> _clienti;

        public ClientService()
        {
            _clienti = new List<Client>();
        }

        public void AdaugăClient(Client client)
        {
            client.Id = _clienti.Count + 1;
            _clienti.Add(client);
        }

        public void ȘtergeClient(Client client)
        {
            _clienti.Remove(client);
        }

        public List<Client> ObțineToțiClienții()
        {
            return _clienti;
        }

        public Client ObțineClient(int id)
        {
            return _clienti.FirstOrDefault(c => c.Id == id);
        }

        public void ActualizeazăIstoricCălătorii(Client client, string călătorie)
        {
            client.IstoricCălătorii.Add(călătorie);
        }

        public void ActualizeazăPreferințePlată(Client client, string preferință)
        {
            client.PreferințePlată.Add(preferință);
        }
    }
}
