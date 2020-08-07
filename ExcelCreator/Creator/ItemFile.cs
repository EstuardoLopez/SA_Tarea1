using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCreator.Creator
{
    public class ItemFile
    {
        public Int32 Repitencia { get; set; }
        public string Numero { get; set; }
        public string Proveedor { get; set; }
        public string CodigoProducto { get; set; }
        public DateTime FechaAdquisicionProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string Linea { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public int ComisionAVendedor { get; set; }
        public int Cantidad { get; set; }
        public string Sede { get; set; }
        public string Estado { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioPresupuestado { get; set; }
        public decimal PorcentajeGananciaPresupuestada { get; set; }
        public decimal GananciaPresupuestada { get; set; }
    }
}
