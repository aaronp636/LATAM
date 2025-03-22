using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LATAM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pasajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pasajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LATAMDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LATAMDataSet.Pasaje' Puede moverla o quitarla según sea necesario.
            this.pasajeTableAdapter.Fill(this.bD_LATAMDataSet.Pasaje);

        }
    }
}
