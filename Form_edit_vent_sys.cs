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
    public partial class Form_edit_vent_sys : Form
    {
        public Form_edit_vent_sys()
        {
            InitializeComponent();

            textBox_nomer_vent_sys_edit.Text = DataStatic.vent_sys_new_number;
            numericUpDown_napor_vent_sys_edit.Value = (decimal)DataStatic.vent_sys_napor_ventiliatora;
        }

        private void button_vent_sys_edit_ok_Click(object sender, EventArgs e)
        {
            DataStatic.vent_sys_new_number = textBox_nomer_vent_sys_edit.Text;
            DataStatic.vent_sys_napor_ventiliatora = (double)numericUpDown_napor_vent_sys_edit.Value;
        }
    }
}
