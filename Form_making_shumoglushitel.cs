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
    public partial class Form_making_shumoglushitel : Form
    {
        public Form_making_shumoglushitel()
        {
            InitializeComponent();

            radioButton_shumoglushitel_veza.Checked = true;

            if (DataStatic.forma_mestnogo_soprotivlenia == "rectangle")
            {
                radioButton_shumoglushitel_dlina_1000.Checked = true;
                radioButton_shumoglushitel_dlina_1000.Enabled = false;
                radioButton_shumoglushitel_dlina_600.Enabled = false;
                radioButton_shumoglushitel_dlina_900.Enabled = false;
            }
            else
            {
                radioButton_shumoglushitel_dlina_600.Checked = true;
                radioButton_shumoglushitel_dlina_1000.Enabled = false;
            }
        }

        private void button_create_shumoglushitel_Click(object sender, EventArgs e)
        {
            if (radioButton_shumoglushitel_veza.Checked) DataStatic.shumoglushitel_proizvoditel = "Веза";
            else if (radioButton_shumoglushitel_arktika.Checked) DataStatic.shumoglushitel_proizvoditel = "Арктика";
            else DataStatic.shumoglushitel_proizvoditel = "Веза";

            if (radioButton_shumoglushitel_dlina_600.Checked) DataStatic.shumoglushitel_dlina = 600;
            else if (radioButton_shumoglushitel_dlina_900.Checked) DataStatic.shumoglushitel_dlina = 900;
            else if (radioButton_shumoglushitel_dlina_1000.Checked) DataStatic.shumoglushitel_dlina = 1000;
            else
            {
                if (DataStatic.forma_mestnogo_soprotivlenia == "rectangle")
                {
                    DataStatic.shumoglushitel_dlina = 600;
                }
                else
                {
                    DataStatic.shumoglushitel_dlina = 1000;
                }
            }

            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_shumoglushiteley.Value;
        }
    }
}
