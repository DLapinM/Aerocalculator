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
    public partial class Form_making_vent_sys : Form
    {
        string vent_sys_type_str;

        string vent_sys_number_str;

        string last_sys_type_input;

        public Form_making_vent_sys()
        {
            InitializeComponent();
            button_create_vent_sys.Enabled = false;
            
        }

        private void Form_making_vent_sys_Load(object sender, EventArgs e)
        {
            comboBox_vent_sys_type.Text = "В (вытяжная общеобменная с механическим побуждением)";
            last_sys_type_input = "В (вытяжная общеобменная с механическим побуждением)";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStatic.vent_sys_new_type = vent_sys_type_str;
            DataStatic.vent_sys_new_number = vent_sys_number_str;
            DataStatic.vent_sys_new_name = (vent_sys_type_str + vent_sys_number_str);

            DataStatic.vent_sys_napor_ventiliatora = (double)numericUpDown_napor_ventiliatora.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            last_sys_type_input = comboBox_vent_sys_type.Text;

            if (last_sys_type_input == "П (приточная общеобменная с механическим побуждением)") vent_sys_type_str = "П";
            else if (last_sys_type_input == "В (вытяжная общеобменная с механическим побуждением)") vent_sys_type_str = "В";
            else if (last_sys_type_input == "ПЕ (приточная общеобменная с естественным побужением)") vent_sys_type_str = "ПЕ";
            else if (last_sys_type_input == "ВЕ (вытяжная общеобменная с естественным побуждением)") vent_sys_type_str = "ВЕ";
            else if (last_sys_type_input == "ДП (подпор воздуха)") vent_sys_type_str = "ДП";
            else if (last_sys_type_input == "ДВ (дымоудаление)") vent_sys_type_str = "ДВ";
            else if (last_sys_type_input == "У (для воздушной завесы)") vent_sys_type_str = "У";
            else vent_sys_type_str = "В";

            vent_sys_number_str = textBox_vent_sys_number.Text;

            richTextBox_show_sys_name.Text = vent_sys_type_str + vent_sys_number_str;

            if ((vent_sys_type_str != "") && (vent_sys_number_str != "") && (comboBox_vent_sys_type.Text != "")) button_create_vent_sys.Enabled = true;
            else button_create_vent_sys.Enabled = false;
        }

        private void textBox_vent_sys_number_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_vent_sys_type.Text == "П (приточная общеобменная с механическим побуждением)") vent_sys_type_str = "П";
            else if (comboBox_vent_sys_type.Text == "В (вытяжная общеобменная с механическим побуждением)") vent_sys_type_str = "В";
            else if (comboBox_vent_sys_type.Text == "ПЕ (приточная общеобменная с естественным побужением)") vent_sys_type_str = "ПЕ";
            else if (comboBox_vent_sys_type.Text == "ВЕ (вытяжная общеобменная с естественным побуждением)") vent_sys_type_str = "ВЕ";
            else if (comboBox_vent_sys_type.Text == "ДП (подпор воздуха)") vent_sys_type_str = "ДП";
            else if (comboBox_vent_sys_type.Text == "ДВ (дымоудаление)") vent_sys_type_str = "ДВ";
            else if (comboBox_vent_sys_type.Text == "У (для воздушной завесы)") vent_sys_type_str = "У";
            else
            {
                comboBox_vent_sys_type.Text = last_sys_type_input;
            }

            vent_sys_number_str = textBox_vent_sys_number.Text;

            richTextBox_show_sys_name.Text = vent_sys_type_str + vent_sys_number_str;

            if ((vent_sys_type_str != "") && (vent_sys_number_str != "") && (comboBox_vent_sys_type.Text != "")) button_create_vent_sys.Enabled = true;
            else button_create_vent_sys.Enabled = false;
        }

        private void richTextBox_show_sys_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
