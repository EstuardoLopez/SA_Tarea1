using ExcelLibrary.SpreadSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCreator.Creator
{
    public class GeneradorExcel
    {

        private List<ItemFile> items = null;

        public void setItms(List<ItemFile> pItems)
        {
            this.items = pItems;
        }

        public string CrearDocumento()
        {
            string result = "";
            try
            {
                int countRow = 0;
                string file = "newdoc.xls";
                Workbook workbook = new Workbook();
                Worksheet worksheet = new Worksheet("Import data");

                //Agregamos titulos
                worksheet.Cells[countRow, Index_Column.NUMBER] = new Cell("No.");
                worksheet.Cells[countRow, Index_Column.PROVEEDOR] = new Cell("Proveedor");
                worksheet.Cells[countRow, Index_Column.CODIGO_PRODUCTO] = new Cell("Cod. Producto");
                worksheet.Cells[countRow, Index_Column.FECHA_ADQUISICION] = new Cell("Fecha de adquisición Producto");
                worksheet.Cells[countRow, Index_Column.DESCRIPCION] = new Cell("Descripción Producto");
                worksheet.Cells[countRow, Index_Column.LINEA] = new Cell("Línea");
                worksheet.Cells[countRow, Index_Column.TALLA] = new Cell("Talla");
                worksheet.Cells[countRow, Index_Column.COLOR] = new Cell("Color");
                worksheet.Cells[countRow, Index_Column.COMISION_VENDEDOR] = new Cell("% Comisión a vendedor");
                worksheet.Cells[countRow, Index_Column.CANTIDAD] = new Cell("Cantidad");
                worksheet.Cells[countRow, Index_Column.SEDE] = new Cell("Sede");
                worksheet.Cells[countRow, Index_Column.ESTADO] = new Cell("Estado");
                worksheet.Cells[countRow, Index_Column.TIPO_VENTA] = new Cell("Tipo de venta");
                worksheet.Cells[countRow, Index_Column.CLIENTE] = new Cell("Cliente");
                worksheet.Cells[countRow, Index_Column.COSTO_UNITARIO_INDEX] = new Cell("Costo Unitario");
                worksheet.Cells[countRow, Index_Column.PRECIO_PRESUPUESTADO_INDEX] = new Cell("Precio Presupuestado");
                worksheet.Cells[countRow, Index_Column.PORCENTAJE_GANANCIA_PRESUPUESTADA] = new Cell("% Ganancia Presupuestada");
                worksheet.Cells[countRow, Index_Column.GANANCIA_PRESUPUESTADA] = new Cell("Q. Ganancia Presupuestada");

                countRow++;

                foreach (ItemFile item in items)
                {
                    for (int i = 0; i < item.Repitencia; i++)
                    {
                        worksheet.Cells[countRow, Index_Column.NUMBER] = new Cell(item.Numero);
                        worksheet.Cells[countRow, Index_Column.PROVEEDOR] = new Cell(item.Proveedor);
                        worksheet.Cells[countRow, Index_Column.CODIGO_PRODUCTO] = new Cell(item.CodigoProducto);
                        worksheet.Cells[countRow, Index_Column.FECHA_ADQUISICION] = new Cell(item.FechaAdquisicionProducto);
                        worksheet.Cells[countRow, Index_Column.DESCRIPCION] = new Cell(item.DescripcionProducto);
                        worksheet.Cells[countRow, Index_Column.LINEA] = new Cell(item.Linea);
                        worksheet.Cells[countRow, Index_Column.TALLA] = new Cell(item.Talla);
                        worksheet.Cells[countRow, Index_Column.COLOR] = new Cell(item.Color);
                        worksheet.Cells[countRow, Index_Column.COMISION_VENDEDOR] = new Cell(item.ComisionAVendedor);
                        worksheet.Cells[countRow, Index_Column.CANTIDAD] = new Cell(item.Cantidad);
                        worksheet.Cells[countRow, Index_Column.SEDE] = new Cell(item.Sede);
                        worksheet.Cells[countRow, Index_Column.ESTADO] = new Cell(item.Estado);
                        worksheet.Cells[countRow, Index_Column.TIPO_VENTA] = new Cell("");
                        worksheet.Cells[countRow, Index_Column.CLIENTE] = new Cell("");
                        worksheet.Cells[countRow, Index_Column.COSTO_UNITARIO_INDEX] = new Cell(item.CostoUnitario);
                        worksheet.Cells[countRow, Index_Column.PRECIO_PRESUPUESTADO_INDEX] = new Cell(item.PrecioPresupuestado);
                        worksheet.Cells[countRow, Index_Column.PORCENTAJE_GANANCIA_PRESUPUESTADA] = new Cell(item.PorcentajeGananciaPresupuestada);
                        worksheet.Cells[countRow, Index_Column.GANANCIA_PRESUPUESTADA] = new Cell(item.GananciaPresupuestada);
                        countRow++;
                    }
                }

                //create new xls file 
                workbook.Worksheets.Add(worksheet);
                workbook.Save(file);
                // open xls file 
                Workbook book = Workbook.Load(file);
                Worksheet sheet = book.Worksheets[0];
                result = "Archivo xlsx generado con exito";
            }catch(Exception e)
            {
                result = "No fue posible generar el archivo xlsx. " + e.Message;
            }
            return result;
        }
    }
}
