using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Companie;

namespace Firma_de_transport_public
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofer s = new Sofer("gigel","marian",12);
            Console.WriteLine(s.ToString());
        }
    }
}
