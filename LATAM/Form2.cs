﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void avionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_LATAMDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_LATAMDataSet.Avion' Puede moverla o quitarla según sea necesario.
            this.avionTableAdapter.Fill(this.bD_LATAMDataSet.Avion);

        }
    }
}
