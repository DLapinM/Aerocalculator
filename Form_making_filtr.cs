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
    public partial class Form_making_filtr : Form
    {
        public Form_making_filtr()
        {
            InitializeComponent();
            radioButton_filtr_veza.Checked = true;
            radioButton_filtr_klass_g3.Checked = true;
        }

        private void button_create_filtr_Click(object sender, EventArgs e)
        {
            string f_proizvoditel;
            string f_klass;

            if (radioButton_filtr_veza.Checked) f_proizvoditel = "Веза";
            else if (radioButton_filtr_arktika.Checked) f_proizvoditel = "Арктика";
            else f_proizvoditel = "Веза";

            if (radioButton_filtr_klass_g3.Checked) f_klass = "G3";
            else if (radioButton_filtr_klass_g4.Checked) f_klass = "G4";
            else if (radioButton_filtr_klass_f5.Checked) f_klass = "F5";
            else if (radioButton_klass_f7.Checked) f_klass = "F7";
            else f_klass = "G3";

            DataStatic.filtr_proizvoditel = f_proizvoditel;
            DataStatic.filtr_klass = f_klass;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_filtrov.Value;
        }
    }
}
