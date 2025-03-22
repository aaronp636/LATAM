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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void tarifaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarifaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LATAMDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LATAMDataSet.Tarifa' Puede moverla o quitarla según sea necesario.
            this.tarifaTableAdapter.Fill(this.bD_LATAMDataSet.Tarifa);

        }
    }
}
