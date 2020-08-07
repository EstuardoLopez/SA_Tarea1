using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelCreator.Creator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGenerarDocumento_Click(object sender, EventArgs e)
        {
            ReaderInformation reader = new ReaderInformation();
            List<ItemFile> lista = reader.ObtenerInformacion(@"c:\Users\BDGSA\Documents\test.txt");
            if (reader.GetErros().Count > 0)
            {
                MessageBox.Show("El arhcivo de entrada contiene errores");
            }
            else
            {
                GeneradorExcel generador = new GeneradorExcel();
                generador.setItms(lista);
                string result = generador.CrearDocumento();
                MessageBox.Show(result);
            }
        }
    }
}
