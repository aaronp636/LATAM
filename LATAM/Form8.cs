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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void vueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vueloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LATAMDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LATAMDataSet.Vuelo' Puede moverla o quitarla según sea necesario.
            this.vueloTableAdapter.Fill(this.bD_LATAMDataSet.Vuelo);

        }
    }
}
