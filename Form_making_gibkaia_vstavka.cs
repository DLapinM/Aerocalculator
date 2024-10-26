using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aerocalculator
{
    public partial class Form_making_gibkaia_vstavka : Form
    {
        public Form_making_gibkaia_vstavka()
        {
            InitializeComponent();

            radioButton_gibkaia_vstavka_veza.Checked = true;
        }

        private void button_create_gibkaia_vstavka_Click(object sender, EventArgs e)
        {
            if (radioButton_gibkaia_vstavka_veza.Checked) DataStatic.gibkaia_vstavka_proizvoditel = "Веза";
            else if (radioButton_gibkaia_vstavka_arktika.Checked) DataStatic.gibkaia_vstavka_proizvoditel = "Арктика";
            else DataStatic.gibkaia_vstavka_proizvoditel = "Веза";

            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_gibkih_vstavok.Value;
        }
    }
}
