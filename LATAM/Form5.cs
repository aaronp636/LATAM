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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pasajeroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pasajeroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LATAMDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LATAMDataSet.Pasajero' Puede moverla o quitarla según sea necesario.
            this.pasajeroTableAdapter.Fill(this.bD_LATAMDataSet.Pasajero);

        }
    }
}
