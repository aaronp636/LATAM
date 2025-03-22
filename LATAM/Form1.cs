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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void asientoAvionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asientoAvionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LATAMDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LATAMDataSet.AsientoAvion' Puede moverla o quitarla según sea necesario.
            this.asientoAvionTableAdapter.Fill(this.bD_LATAMDataSet.AsientoAvion);

        }
    }
}
