using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCreator.Creator
{
    public class ReaderInformation
    {
        public string statusMessage;
        public bool status;
        private List<String> Errs = null;

        public ReaderInformation()
        {
            status = false;
            statusMessage = "";
            Errs = new List<string>();
        }

        public List<String> GetErros()
        {
            return Errs;
        }

        private List<String> ReadFile(string pathFile)
        {
            int counter = 0;
            string line;
            List<String> lines = new List<string>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                //new System.IO.StreamReader(@"c:\test.txt");
                new System.IO.StreamReader(pathFile);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                lines.Add(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            //System.Console.ReadLine();
            return lines;
        }

        public List<ItemFile> ObtenerInformacion(string pathFile)
        {
            var result = new List<ItemFile>();
            var lines = ReadFile(pathFile);
            int RowCount = 0;
            foreach (String line in lines)
            {
                RowCount++;
                string[] ArrayLine = line.Split(Constantes.ROW_DELMITATOR);
                if (ArrayLine.Length == Constantes.LONGITUD_VECTOR)//verificamos que el numero de columnas sea el correcto
                {
                    ItemFile item = new ItemFile()
                    {
                        Numero = Constantes.DEFAULT_NUMBER,
                        Proveedor = ArrayLine[Index_Column.PROVEEDOR],
                        CodigoProducto = ArrayLine[Index_Column.CODIGO_PRODUCTO],
                        DescripcionProducto = ArrayLine[Index_Column.DESCRIPCION],
                        Linea = ArrayLine[Index_Column.LINEA],
                        Talla = ArrayLine[Index_Column.TALLA],
                        Color = ArrayLine[Index_Column.COLOR],
                        Cantidad = Constantes.DEFAULT_CANTIDAD,
                        Sede = Constantes.DEFAULT_SEDE,
                        Estado = Constantes.DEFAULT_ESTADO,
                    };

                    bool resultConvert = false;
                    resultConvert = Int32.TryParse(ArrayLine[Index_Column.REPITENCIA], out Int32 CantidadRepitencia);
                    if (!resultConvert)
                    {
                        AddErr(string.Format("La columna {0} de la fila {1} no contine un valor valido", Constantes.GetColumnName(Index_Column.REPITENCIA), RowCount));
                    }
                    resultConvert = DateTime.TryParse(ArrayLine[Index_Column.FECHA_ADQUISICION], out DateTime Fecha);
                    if (!resultConvert)
                    {
                        //AddErr(string.Format("La columna {0} de la fila {1} no contine un valor valido", Constantes.GetColumnName(Index_Column.FECHA_ADQUISICION), RowCount));
                    }
                    resultConvert = Decimal.TryParse(ArrayLine[Index_Column.COSTO_UNITARIO], out Decimal CostoUnitario);
                    if (!resultConvert)
                    {
                        AddErr(string.Format("La columna {0} de la fila {1} no contine un valor valido", Constantes.GetColumnName(Index_Column.COSTO_UNITARIO), RowCount));
                    }
                    resultConvert = Decimal.TryParse(ArrayLine[Index_Column.PRECIO_PRESUPUESTADO], out Decimal PrecioPresupuestado);
                    if (!resultConvert)
                    {
                        AddErr(string.Format("La columna {0} de la fila {1} no contine un valor valido", Constantes.GetColumnName(Index_Column.PRECIO_PRESUPUESTADO), RowCount));
                    }

                    int comisionCalculada = Categorias.GetPorcentajeCategoria(ArrayLine[Index_Column.LINEA].ToUpper());
                    if (comisionCalculada > 0)
                    {
                        item.ComisionAVendedor = comisionCalculada;
                    }
                    else
                    {
                        AddErr(string.Format("La columna {0} de la fila {1} no contine un valor valido", Constantes.GetColumnName(Index_Column.LINEA), RowCount));
                    }

                    item.Repitencia = CantidadRepitencia;
                    //item.FechaAdquisicionProducto = Fecha;
                    item.CostoUnitario = CostoUnitario;
                    item.PrecioPresupuestado = PrecioPresupuestado;
                    item.PorcentajeGananciaPresupuestada = item.CostoUnitario * item.PrecioPresupuestado;
                    item.GananciaPresupuestada = item.PrecioPresupuestado - item.CostoUnitario;
                    result.Add(item);
                }
                else
                {
                    AddErr(string.Format("La fila {0} no cuenta con el numero exacto de columnas", RowCount));
                }
            }
            return result;
        }

        private void AddErr(String err)
        {
            Errs.Add(err);
            status = false;
        }
    }
}
