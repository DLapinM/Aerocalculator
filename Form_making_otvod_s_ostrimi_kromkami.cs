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
    public partial class Form_making_otvod_s_ostrimi_kromkami : Form
    {
        public Form_making_otvod_s_ostrimi_kromkami()
        {
            InitializeComponent();
            radioButton_povorot_vokrug_visoti.Checked = true;
            radioButton_povorot_vokrug_shirini.Checked = !radioButton_povorot_vokrug_visoti.Checked;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_povorot_vokrug_visoti.Enabled = false;
                pictureBox_povorot_vokrug_visoti.Enabled = false;

                radioButton_povorot_vokrug_shirini.Enabled = false;
                pictureBox_povorot_vokrug_shirini.Enabled = false;
            }
        }

        private void button_add_otvod_s_ostrimi_kromkami_Click(object sender, EventArgs e)
        {
            DataStatic.ugol_povorota_otvoda = (int)numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value;
            DataStatic.povorot_vdol_shirini_true_vdol_visoti_false = radioButton_povorot_vokrug_shirini.Checked;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_otvodov_s_ostrimi_kromkami.Value;
        }

        private void radioButton_povorot_vokrug_visoti_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_povorot_vokrug_shirini.Checked = !radioButton_povorot_vokrug_visoti.Checked;
        }

        private void radioButton_povorot_vokrug_shirini_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_povorot_vokrug_visoti.Checked = !radioButton_povorot_vokrug_shirini.Checked;
        }

        private void numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota_ValueChanged(object sender, EventArgs e)
        {
            int i_val = (int)numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value;

            if (i_val < 30) numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = 30;
            else if ((i_val > 30) && (i_val < 60)) numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = 60;
            else if ((i_val > 60) && (i_val < 90)) numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = 90;
            else if ((i_val > 90) && (i_val < 120)) numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = 120;
            else if ((i_val > 120) && (i_val < 180)) numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = 180;
            //else numericUpDown_otvod_s_ostrimi_kromkami_ugol_povorota.Value = 180;
        }
    }
}
