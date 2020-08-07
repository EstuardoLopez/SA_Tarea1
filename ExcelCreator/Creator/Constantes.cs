using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCreator.Creator
{
    public static class Constantes
    {
        public static int LONGITUD_VECTOR = 10;
        public static char ROW_DELMITATOR = ',';
        public static char COLUM_DELIMITATOR = ',';
        public static String DEFAULT_NUMBER = "1";
        public static String DEFAULT_SEDE = "Capital";
        public static String DEFAULT_ESTADO = "Inventario";
        public static int DEFAULT_CANTIDAD = 1;
        public static String[] COLUMN_NAME = { "REPITENCIA", "PROVEEDOR", "CODIGO_PRODUCTO", "FECHA_ADQUISICION", "DESCRIPCION", "LINEA", "TALLA", "COLOR", "COSTO_UNITARIO", "PRECIO_PRESUPUESTADO"};

        public static String GetColumnName(int index)
        {
            return COLUMN_NAME[index];
        }
    }

    public static class Index_Column
    {
        public static int REPITENCIA = 0;
        public static int NUMBER = 0;
        public static int PROVEEDOR = 1;
        public static int CODIGO_PRODUCTO = 2;
        public static int FECHA_ADQUISICION = 3;
        public static int DESCRIPCION = 4;
        public static int LINEA = 5;
        public static int TALLA = 6;
        public static int COLOR = 7;
        public static int COSTO_UNITARIO = 8;
        public static int PRECIO_PRESUPUESTADO = 9;

        public static int COMISION_VENDEDOR = 8;
        public static int CANTIDAD = 9;
        public static int SEDE = 10;
        public static int ESTADO = 11;
        public static int TIPO_VENTA = 12;
        public static int CLIENTE = 13;
        public static int COSTO_UNITARIO_INDEX = 14;
        public static int PRECIO_PRESUPUESTADO_INDEX = 15;
        public static int PORCENTAJE_GANANCIA_PRESUPUESTADA = 16;
        public static int GANANCIA_PRESUPUESTADA = 17;
    }

    public static class Categorias
    {
        public const string JUGUETES = "JUGUETES";
        public const string RELOJES = "RELOJES";
        public const string AUDIO = "AUDIO";
        public const string ACCESORIOS_PARA_CELULAR = "ACCESORIOS PARA CELULAR";
        public const string HOGAR = "HOGAR";
        public const string ROPA_INTERIOR = "ROPA_INTERIOR";
        public const string CALZADO_MULTIMODAS = "CALZADO MULTIMODAS";
        public const string CALZADO_CHECHA = "CALZADO CHECHA";
        public const string ROPA = "ROPA";
        public const string JOYAS = "JOYAS";


        public static int PRCT_JUGUETES = 20;
        public static int PRCT_RELOJES = 15;
        public static int PRCT_AUDIO = 15;
        public static int PRCT_ACCESORIOS_PARA_CELULAR = 15;
        public static int PRCT_HOGAR = 15;
        public static int PRCT_ROPA_INTERIOR = 20;
        public static int PRCT_CALZADO_MULTIMODAS = 12;
        public static int PRCT_CALZADO_CHECHA = 20;
        public static int PRCT_ROPA = 20;
        public static int PRCT_JOYAS = 20;

        public static int GetPorcentajeCategoria(string param)
        {
            int result = 0;
            switch (param)
            {
                case JUGUETES:
                    result = PRCT_JUGUETES;
                    break;
                case RELOJES:
                    result = PRCT_RELOJES;
                    break;
                case AUDIO:
                    result = PRCT_AUDIO;
                    break;
                case ACCESORIOS_PARA_CELULAR:
                    result = PRCT_ACCESORIOS_PARA_CELULAR;
                    break;
                case HOGAR:
                    result = PRCT_HOGAR;
                    break;
                case ROPA_INTERIOR:
                    result = PRCT_ROPA_INTERIOR;
                    break;
                case CALZADO_MULTIMODAS:
                    result = PRCT_CALZADO_MULTIMODAS;
                    break;
                case CALZADO_CHECHA:
                    result = PRCT_CALZADO_CHECHA;
                    break;
                case ROPA:
                    result = PRCT_ROPA;
                    break;
                case JOYAS:
                    result = PRCT_JOYAS;
                    break;
            }
            return result;
        }
    }

}
