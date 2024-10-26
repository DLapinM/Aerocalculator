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
    public partial class Form_making_protivopojarniy_klapan : Form
    {
        string s_oboznachenie;
        string s_naznachenie;
        string s_ispolnenie;
        string s_tip_klapana;

        string s_marka_1;
        string s_marka_2;

        string s_razmeri;

        string s_marka;
        public Form_making_protivopojarniy_klapan()
        {
            InitializeComponent();
            radioButton_kpu_not_rotated.Checked = true;
            radioButton_kpu_rotated.Checked = false;

            if (DataStatic.forma_mestnogo_soprotivlenia == "circle")
            {
                radioButton_kpu_not_rotated.Enabled = false;
                radioButton_kpu_rotated.Enabled = false;
            }

            textBox_kpu_show_marka.Enabled = false;

            refresh_kpu_marka();
        }

        public void refresh_kpu_marka()
        {
            s_oboznachenie = comboBox_kpu_oboznachenie.Text;

            if (comboBox_kpu_naznachenie.Text == "О - нормально открытый") s_naznachenie = "О";
            else if (comboBox_kpu_naznachenie.Text == "З - нормально закрытый") s_naznachenie = "З";
            else if (comboBox_kpu_naznachenie.Text == "Д - дымовой") s_naznachenie = "Д";
            else s_naznachenie = "О";

            if (comboBox_kpu_ispolnenie.Text == "Н - общепромышленное") s_ispolnenie = "Н";
            else if (comboBox_kpu_ispolnenie.Text == "В - взрывозащищённое") s_ispolnenie = "В";
            else if (comboBox_kpu_ispolnenie.Text == "К - коррозионностойкое") s_ispolnenie = "К";
            else if (comboBox_kpu_ispolnenie.Text == "ВК - взрывозащищённое коррозионностойкое") s_ispolnenie = "ВК";
            else if (comboBox_kpu_ispolnenie.Text == "МС - морозостойкое") s_ispolnenie = "МС";
            else if (comboBox_kpu_ispolnenie.Text == "МСК - морозостойкое коррозионностойкое") s_ispolnenie = "МСК";
            else if (comboBox_kpu_ispolnenie.Text == "ВМС - взрывозащищённое морозостойкое") s_ispolnenie = "ВМС";
            else if (comboBox_kpu_ispolnenie.Text == "ВМСК - взрывозащищённое морозостойкое коррозионностойкое") s_ispolnenie = "ВМСК";
            else s_ispolnenie = "Н";

            if (comboBox_kpu_tip_klapana.Text == "1*ф - стеновой") s_tip_klapana = "1*ф";
            else if (comboBox_kpu_tip_klapana.Text == "2*ф - канальный") s_tip_klapana = "2*ф";
            else s_tip_klapana = "2*ф";

            if (comboBox_kpu_oboznachenie.Text != "КПУ-3-ДД")
            {
                s_marka_1 = s_oboznachenie + "-" + s_naznachenie + "-" + s_ispolnenie;
            }
            else
            {
                s_marka_1 = s_oboznachenie + "-" + s_ispolnenie;
            }

            s_marka_2 = s_tip_klapana;

            if (DataStatic.forma_mestnogo_soprotivlenia == "rectangle")
            {
                if (radioButton_kpu_not_rotated.Checked)
                {
                    s_razmeri = DataStatic.width.ToString() + "x" + DataStatic.height.ToString();
                }
                else
                {
                    s_razmeri = DataStatic.height.ToString() + "x" + DataStatic.width.ToString();
                }
            }
            else
            {
                s_razmeri = DataStatic.diameter.ToString();
            }

            s_marka = s_marka_1 + "-" + s_razmeri + "-" + s_marka_2;

            textBox_kpu_show_marka.Text = s_marka;
        }

        private void radioButton_kpu_not_rotated_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_kpu_rotated.Checked = !radioButton_kpu_not_rotated.Checked;
            refresh_kpu_marka();
        }

        private void radioButton_kpu_rotated_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_kpu_not_rotated.Checked = !radioButton_kpu_rotated.Checked;
            refresh_kpu_marka();
        }

        private void comboBox_kpu_oboznachenie_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox_kpu_oboznachenie.Text == "КПУ-3-ДД")
            {
                comboBox_kpu_ispolnenie.Text = "";

                comboBox_kpu_ispolnenie.Enabled = false;
            }
            else
            {
                comboBox_kpu_ispolnenie.Enabled = true;

                if (comboBox_kpu_ispolnenie.Text == "")
                {
                    comboBox_kpu_ispolnenie.Text =  "Н - общепромышленное";
                }
            }

            refresh_kpu_marka();
        }

        private void comboBox_kpu_naznachenie_TextUpdate(object sender, EventArgs e)
        {
            refresh_kpu_marka();
        }

        private void comboBox_kpu_ispolnenie_TextUpdate(object sender, EventArgs e)
        {
            refresh_kpu_marka();
        }

        private void comboBox_kpu_tip_klapana_TextUpdate(object sender, EventArgs e)
        {
            refresh_kpu_marka();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_kpu_marka();
            DataStatic.rotated_or_not = radioButton_kpu_rotated.Checked;
            DataStatic.marka_before_razmeri = s_marka_1;
            DataStatic.marka_after_razmeri = s_marka_2;
            DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia = (int)numericUpDown_kolichestvo_klapanov_kpu.Value;
        }

        private void comboBox_kpu_oboznachenie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_kpu_oboznachenie.Text == "КПУ-3-ДД")
            {
                comboBox_kpu_ispolnenie.Text = "";

                comboBox_kpu_ispolnenie.Enabled = false;
            }
            else
            {
                comboBox_kpu_ispolnenie.Enabled = true;

                if (comboBox_kpu_ispolnenie.Text == "")
                {
                    comboBox_kpu_ispolnenie.Text = "Н - общепромышленное";
                }
            }

            refresh_kpu_marka();
        }

        private void comboBox_kpu_naznachenie_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_kpu_marka();
        }

        private void comboBox_kpu_ispolnenie_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_kpu_marka();
        }

        private void comboBox_kpu_tip_klapana_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_kpu_marka();
        }
    }
}
