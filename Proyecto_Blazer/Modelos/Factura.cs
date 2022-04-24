using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public String IdentidadCliente { get; set; }
        public String Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

    }
}
