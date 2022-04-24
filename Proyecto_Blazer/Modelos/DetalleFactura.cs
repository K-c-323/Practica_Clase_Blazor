using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public String CodigoProducto { get; set; }
        public String Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

    }
}
