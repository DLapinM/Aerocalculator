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
    public partial class Form_making_otvod : Form
    {
        public Form_making_otvod()
        {
            InitializeComponent();
            radioButton_povorot_vdol_visoti.Checked = true;
            radioButton_povorot_vdol_shirini.Checked = !radioButton_povorot_vdol_visoti.Checked;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_povorot_vdol_visoti.Enabled = false;
                pictureBox_povorot_vdol_visoti.Enabled = false;

                radioButton_povorot_vdol_shirini.Enabled = false;
                pictureBox_povorot_vdol_shirini.Enabled = false;
            }
        }

        private void Form_making_otvod_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_povorot_vdol_visoti_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_povorot_vdol_shirini.Checked = !radioButton_povorot_vdol_visoti.Checked;
        }

        private void radioButton_povorot_vdol_shirini_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_povorot_vdol_visoti.Checked = !radioButton_povorot_vdol_shirini.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStatic.ugol_povorota_otvoda = (double)numericUpDown_ugol_povorota_otvoda.Value;
            DataStatic.povorot_vdol_shirini_true_vdol_visoti_false = radioButton_povorot_vdol_shirini.Checked;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_otvodov.Value;
        }
    }
}
