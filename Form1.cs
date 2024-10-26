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
    [Serializable]
    public partial class Form1 : Form
    {
        List<Ventilation_system> VentSysList = new List<Ventilation_system>();

        public void refresh_listbox_uchastki()
        {
            if (listBox_vent_systems.SelectedIndex >= 0)
            {
                int index = listBox_vent_systems.SelectedIndex;

                Ventilation_system vs = VentSysList.ElementAt<Ventilation_system>(index);

                List<string> lu_str = vs.get_Uchastki_List_String();

                listBox_uchastki.Items.Clear();

                foreach (string st in lu_str)
                {
                    listBox_uchastki.Items.Add(st);
                }

                if (listBox_uchastki.SelectedIndex < 0)
                {
                    button_edit_uchastok.Enabled = false;
                    button_delete_uchastok.Enabled = false;
                    button_create_mestnoe_soprotivlenie.Enabled = false;
                }
                else
                {
                    button_edit_uchastok.Enabled = true;
                    button_delete_uchastok.Enabled = true;
                    button_create_mestnoe_soprotivlenie.Enabled = true;
                }
            }
            else
            {
                listBox_uchastki.Items.Clear();
            }
            refresh_mestnie_soprotivlenia();
            refresh_enable_buttons_move_mestnie_soprotivlenia();
        }

        public void refresh_mestnie_soprotivlenia()
        {
            int vent_sys_index = listBox_vent_systems.SelectedIndex;
            int uchastki_index = listBox_uchastki.SelectedIndex;

            if ((vent_sys_index >= 0) && (uchastki_index >= 0))
            {
                Ventilation_system vent_sys_current = VentSysList[vent_sys_index];
                Uchastok uchastok_current = vent_sys_current.Get_Uchastok_By_Number(uchastki_index + 1);

                List<string> current_ms_list_string = uchastok_current.get_Mestnie_Soprotivlenia_List_String();

                listBox_mestnie_soprotivlenia.Items.Clear();

                foreach (string str_ms in current_ms_list_string)
                {
                    listBox_mestnie_soprotivlenia.Items.Add(str_ms);
                }
            }
            else
            {
                listBox_mestnie_soprotivlenia.Items.Clear();
            }

            if ((listBox_mestnie_soprotivlenia.SelectedIndex >= 0) && (listBox_mestnie_soprotivlenia.Items.Count > 0))
            {
                button_delete_mestnoe_soprotivlenie.Enabled = true;
            }
            else
            {
                button_delete_mestnoe_soprotivlenie.Enabled = false;
            }
        }

        public void refresh_buttons_move_vent_system()
        {
            if (button_delete_vent_sys.Enabled)
            {
                if (listBox_vent_systems.SelectedIndex > 0)
                {
                    button_move_vent_system_up.Enabled = true;
                }
                else
                {
                    button_move_vent_system_up.Enabled = false;
                }

                if ((listBox_vent_systems.SelectedIndex < (listBox_vent_systems.Items.Count - 1)) && (listBox_vent_systems.SelectedIndex >= 0))
                {
                    button_move_vent_system_down.Enabled = true;
                }
                else
                {
                    button_move_vent_system_down.Enabled = false;
                }
            }
            else
            {
                button_move_vent_system_up.Enabled = false;
                button_move_vent_system_down.Enabled = false;
            }
        }
        public Form1()
        {
            InitializeComponent();

            button1.Visible = false;

            button_delete_vent_sys.Enabled = false;

            button_create_uchastok.Enabled = false;
            button_edit_uchastok.Enabled = false;
            button_delete_uchastok.Enabled = false;

            button_create_mestnoe_soprotivlenie.Enabled = false;
            button_delete_mestnoe_soprotivlenie.Enabled = false;
            button_delete_mestnie_soprotivlenia_before.Enabled = false;
            button_delete_mestnie_soprotivlenia_after.Enabled = false;
            button_delete_mestnie_soprotivlenia_all.Enabled = false;

            refresh_button_edit_vent_sys();
            refresh_buttons_move_uchastki();

            refresh_button_make_airodynamic_calculation();
        }

        /*
        public void consondeb()
        {
            if (NativeMethods.AllocConsole())
            {
                IntPtr stdHandle = NativeMethods.GetStdHandle(NativeMethods.STD_OUTPUT_HANDLE);
                Console.WriteLine("Console!");
            }
            else
            {
                Console.WriteLine("Activated!");
            }
        }
        
        public partial class NativeMethods
        {
            public static Int32 STD_OUTPUT_HANDLE = -11;

            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "GetStdHandle")]
            public static extern System.IntPtr GetStdHandle(Int32 nStdHandle);

            [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "AllocConsole")]
            [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]

            public static extern bool AllocConsole();
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            consondeb();

            Ventilation_system v_1_1 = new Ventilation_system("В", "1.1");

            v_1_1.Add_Rectangle_Uchastok(1500, 2, 300, 200, "листовая сталь");
            v_1_1.Add_Circle_Uchastok(1500, 1.5, 250, "листовая сталь");
            v_1_1.Add_Rectangle_Uchastok(3000, 3, 400, 200, "листовая сталь");
            v_1_1.Add_Circle_Uchastok(5000, 4, 600, "листовая сталь");
            v_1_1.Add_Rectangle_Uchastok(3000, 3, 550, 350, "листовая сталь");
            v_1_1.Add_Rectangle_Uchastok(5000, 3, 700, 400, "листовая сталь");
            v_1_1.Add_Rectangle_Uchastok(3000, 3, 500, 300, "листовая сталь");
            
            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(1 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }
            
            v_1_1.Add_Vozdushnaia_zaslonka(1, false, "ABK");

            v_1_1.Add_Germoklapan(1, "общепромышленный", false, 5);

            v_1_1.Add_Otvod(1, 45, false);
            v_1_1.Add_Otvod(1, 90, false);
            v_1_1.Add_Otvod(1, 90, true, 5);

            v_1_1.Add_Otvod_s_ostrimi_kromkami(1, 45, false);
            v_1_1.Add_Otvod_s_ostrimi_kromkami(1, 90, false);
            v_1_1.Add_Otvod_s_ostrimi_kromkami(1, 90, true, 5);

            v_1_1.Add_Protivopojarniy_klapan(1, false, "КПУ-1Н-О-Н", "2*ф-MB220-T-СН-0-Р-0-0-0-0");

            v_1_1.Add_Klapan_protivopojarniy_dimoudalenia(1, false, 2);

            v_1_1.Add_Dimovoy_klapan(1, true, false, 2);

            v_1_1.Add_Klapan_izbitochnogo_davlenia(1, false, 3);

            v_1_1.Add_Obratniy_klapan(1, 1, false, 4);

            v_1_1.Add_Obratniy_klapan_s_elektroprivodom(1, false, 2);

            v_1_1.Add_ElektroNagrevatel(1, 6.0, 2);

            v_1_1.Add_Freonoviy_ohladitel(1, 3);

            v_1_1.Add_Filtr(1, "Веза", "G4");
            v_1_1.Add_Filtr(1, "Арктика", "G3, 2");

            v_1_1.Add_Otvod(7, 90, true);

            v_1_1.Add_Perehod_To_End_Of_Stream(7, 700, 500, 200);

            foreach (Uchastok u in v_1_1.Spisok_uchastkov)
            {
                Console.WriteLine(u.ToString());
            }

            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(7 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }

            v_1_1.Change_Uchastok_by_Rectangle(7, 400, 2, 500, 600, "листовая сталь");

            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(7 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }

            v_1_1.Change_Uchastok_by_Rectangle(7, 400, 2, 800, 700, "листовая сталь");

            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(7 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }

            v_1_1.Change_Uchastok_by_Rectangle(7, 400, 2, 500, 700, "листовая сталь");

            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(7 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }

            v_1_1.Add_Perehod_Between(5, 6, 0);

            Console.WriteLine("Местные сопротивления на участке 5:");
            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(5 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }

            Console.WriteLine("Местные сопротивления на участке 6:");
            foreach (Mestnoe_soprotivlenie m in v_1_1.Spisok_uchastkov.ElementAt<Uchastok>(6 - 1).Spisok_soprotivleniy)
            {
                Console.WriteLine(m.ToString());
            }
            */
        }
        private void refresh_listbox_vent_systems()
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;

            listBox_vent_systems.Items.Clear();

            int i = 0;

            foreach (Ventilation_system vs in VentSysList)
            {
                listBox_vent_systems.Items.Add(VentSysList[i].Name_of_sys);
                i++;
            }

            if (index_vs >= 0) listBox_vent_systems.SetSelected(index_vs, true);

            if (index_uch >= 0) listBox_uchastki.SetSelected(index_uch, true);

            if (index_ms >= 0) listBox_mestnie_soprotivlenia.SetSelected(index_ms, true);
        }
        private void button_add_vent_sys_Click(object sender, EventArgs e)
        {
            Form_making_vent_sys f = new Form_making_vent_sys();

            DialogResult dialog_vent_sys_creating = f.ShowDialog(this);

            if (dialog_vent_sys_creating == DialogResult.OK)
            {
                bool flag_good = true;

                foreach (string el in listBox_vent_systems.Items)
                {
                    if (DataStatic.vent_sys_new_name == el)
                    {
                        flag_good = false;
                        break;
                    }
                }

                if (flag_good)
                {
                    Ventilation_system vent_sys_new = new Ventilation_system(DataStatic.vent_sys_new_type, DataStatic.vent_sys_new_number, DataStatic.vent_sys_napor_ventiliatora);

                    VentSysList.Add(vent_sys_new);
                    listBox_vent_systems.Items.Add(DataStatic.vent_sys_new_name);

                    refresh_button_make_airodynamic_calculation();
                }
                else
                {
                    MessageBox.Show("Ошибка. Система вентиляции с таким именем уже существует. Новая система вентиляции не создана.");
                }
            }
        }

        private void listBox_vent_systems_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_delete_vent_sys.Enabled = true;
            button_create_uchastok.Enabled = true;
            refresh_listbox_uchastki();
            refresh_buttons_move_vent_system();
            refresh_buttons_move_uchastki();
            refresh_enable_buttons_move_mestnie_soprotivlenia();

            refresh_button_make_airodynamic_calculation();
        }

        private void button_delete_vent_sys_Click(object sender, EventArgs e)
        {
            int selected_index = listBox_vent_systems.SelectedIndex;

            //MessageBox.Show(selected_index.ToString() + "   " + VentSysList[selected_index].Name_of_sys);

            VentSysList.RemoveAt(selected_index);
            listBox_vent_systems.Items.RemoveAt(selected_index);

            if (listBox_vent_systems.SelectedIndex < 0)
            {
                button_delete_vent_sys.Enabled = false;
                button_create_uchastok.Enabled = false;
                button_edit_uchastok.Enabled = false;
                button_delete_uchastok.Enabled = false;
                button_create_mestnoe_soprotivlenie.Enabled = false;
                button_delete_mestnoe_soprotivlenie.Enabled = false;
                refresh_listbox_uchastki();
            }

            if (listBox_vent_systems.Items.Count <= 0)
            {
                button_delete_vent_sys.Enabled = false;
                button_create_uchastok.Enabled = false;
                button_edit_uchastok.Enabled = false;
                button_delete_uchastok.Enabled = false;
                button_create_mestnoe_soprotivlenie.Enabled = false;
                button_delete_mestnoe_soprotivlenie.Enabled = false;
                refresh_listbox_uchastki();
            }
        }

        private void listBox_uchastki_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_edit_uchastok.Enabled = true;
            button_delete_uchastok.Enabled = true;
            button_create_mestnoe_soprotivlenie.Enabled = true;
            refresh_mestnie_soprotivlenia();
            refresh_buttons_move_uchastki();
            refresh_enable_buttons_move_mestnie_soprotivlenia();

            refresh_button_make_airodynamic_calculation();
        }

        private void listBox_mestnie_soprotivlenia_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_delete_mestnoe_soprotivlenie.Enabled = true;
            refresh_enable_buttons_move_mestnie_soprotivlenia();

            refresh_button_make_airodynamic_calculation();
        }

        private void button_create_uchastok_Click(object sender, EventArgs e)
        {
            Form_making_uchastok fmu = new Form_making_uchastok();

            DialogResult dialog_uchastok_creating = fmu.ShowDialog(this);

            if (dialog_uchastok_creating == DialogResult.OK)
            {
                string u_material = DataStatic.getMaterial(DataStatic.uchastok_material);
                double u_temperatura = DataStatic.uchastok_temperatura;
                double u_rashod = DataStatic.uchastok_rashod_m3_in_hour;
                double u_dlina = DataStatic.uchastok_dlina_m;

                double u_diameter;
                double u_shirina;
                double u_visota;

                int sys_number = (listBox_vent_systems.SelectedIndex + 1);

                int u_number;

                if (listBox_uchastki.Items.Count >= 0)
                {
                    u_number = listBox_uchastki.Items.Count + 1;
                }
                else
                {
                    u_number = 1;
                }

                if (DataStatic.uchastok_rectangle_or_not)
                {
                    u_shirina = DataStatic.uchastok_shirina_mm;
                    u_visota = DataStatic.uchastok_visota_mm;

                    VentSysList.ElementAt<Ventilation_system>(sys_number - 1).Add_Rectangle_Uchastok(u_rashod, u_dlina, u_shirina, u_visota, u_material);
                    VentSysList.ElementAt<Ventilation_system>(sys_number - 1).Spisok_uchastkov.ElementAt<Uchastok>(u_number - 1).t = u_temperatura;
                }
                else
                {
                    u_diameter = DataStatic.uchastok_diameter_mm;

                    VentSysList.ElementAt<Ventilation_system>(sys_number - 1).Add_Circle_Uchastok(u_rashod, u_dlina, u_diameter, u_material);
                    VentSysList.ElementAt<Ventilation_system>(sys_number - 1).Spisok_uchastkov.ElementAt<Uchastok>(u_number - 1).t = u_temperatura;
                }

                refresh_listbox_uchastki();
            }
            else
            {

            }
        }

        private void button_delete_uchastok_Click(object sender, EventArgs e)
        {
            int selected_index_u = listBox_uchastki.SelectedIndex;

            int seclected_index_vs = listBox_vent_systems.SelectedIndex;

            VentSysList.ElementAt<Ventilation_system>(seclected_index_vs).Remove_Uchastok(selected_index_u + 1);

            refresh_listbox_uchastki();

            button_create_mestnoe_soprotivlenie.Enabled = false;
            button_delete_mestnoe_soprotivlenie.Enabled = false;

            refresh_buttons_move_uchastki();
        }

        private void refresh_button_edit_vent_sys()
        {
            if (button_delete_vent_sys.Enabled)
            {
                button_edit_vent_sys.Enabled = true;
            }
            else
            {
                button_edit_vent_sys.Enabled = false;
            }
        }
        private void button_delete_vent_sys_EnabledChanged(object sender, EventArgs e)
        {
            refresh_button_edit_vent_sys();
            refresh_buttons_move_vent_system();
        }

        private void button_move_vent_system_up_Click(object sender, EventArgs e)
        {
            if ((listBox_vent_systems.SelectedIndex > 0) && (VentSysList.Count > 1))
            {
                int index_1 = listBox_vent_systems.SelectedIndex;
                int index_0 = index_1 - 1;

                Ventilation_system vs_1 = VentSysList.ElementAt<Ventilation_system>(index_1);
                VentSysList[index_1] = VentSysList[index_0];
                VentSysList[index_0] = vs_1;

                string lb_vs_1 = listBox_vent_systems.Items[index_1].ToString();
                listBox_vent_systems.Items[index_1] = listBox_vent_systems.Items[index_0];
                listBox_vent_systems.Items[index_0] = lb_vs_1;

                listBox_vent_systems.SelectedIndex--;

                refresh_listbox_uchastki();
            }
        }

        private void button_move_vent_system_down_Click(object sender, EventArgs e)
        {
            if ((listBox_vent_systems.SelectedIndex < (VentSysList.Count - 1)) && (VentSysList.Count > 1))
            {
                int index_1 = listBox_vent_systems.SelectedIndex + 1;
                int index_0 = index_1 - 1;

                Ventilation_system vs_1 = VentSysList.ElementAt<Ventilation_system>(index_1);
                VentSysList[index_1] = VentSysList[index_0];
                VentSysList[index_0] = vs_1;

                string lb_vs_1 = listBox_vent_systems.Items[index_1].ToString();
                listBox_vent_systems.Items[index_1] = listBox_vent_systems.Items[index_0];
                listBox_vent_systems.Items[index_0] = lb_vs_1;

                listBox_vent_systems.SelectedIndex++;

                refresh_listbox_uchastki();
            }
        }

        private void button_create_mestnoe_soprotivlenie_Click(object sender, EventArgs e)
        {
            Form_making_mestnoe_soprotivlenie f_ms = new Form_making_mestnoe_soprotivlenie();
            DialogResult dr_ms = f_ms.ShowDialog(this);

            if (dr_ms == DialogResult.OK)
            {
                int vent_sys_index = listBox_vent_systems.SelectedIndex;
                int uchastki_index = listBox_uchastki.SelectedIndex;

                if ((vent_sys_index >= 0) && (uchastki_index >= 0))
                {
                    Ventilation_system vent_sys_current = VentSysList[vent_sys_index];
                    Uchastok uchastok_current = vent_sys_current.Get_Uchastok_By_Number(uchastki_index + 1);
                    DataStatic.forma_mestnogo_soprotivlenia = uchastok_current.Forma_sechenia;

                    DataStatic.width = uchastok_current.Width_mm;
                    DataStatic.height = uchastok_current.Height_mm;
                    DataStatic.diameter = uchastok_current.Diameter_mm;

                    if (DataStatic.tip_mestnogo_soprotivlenia == "Отвод")
                    {
                        Form_making_otvod f_m_otv = new Form_making_otvod();
                        DialogResult dr_f_m_otv = f_m_otv.ShowDialog(this);

                        if (dr_f_m_otv == DialogResult.OK)
                        {
                            vent_sys_current.Add_Otvod((uchastki_index + 1), DataStatic.ugol_povorota_otvoda,
                                DataStatic.povorot_vdol_shirini_true_vdol_visoti_false, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Отвод с острыми кромками")
                    {
                        Form_making_otvod_s_ostrimi_kromkami f_m_otv_s_kr = new Form_making_otvod_s_ostrimi_kromkami();
                        DialogResult dr_f_m_otv_s_kr = f_m_otv_s_kr.ShowDialog(this);

                        if (dr_f_m_otv_s_kr == DialogResult.OK)
                        {
                            vent_sys_current.Add_Otvod_s_ostrimi_kromkami((uchastki_index + 1), DataStatic.ugol_povorota_otvoda,
                                DataStatic.povorot_vdol_shirini_true_vdol_visoti_false, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Воздушная заслонка (дроссель)")
                    {
                        Form_making_vozdushnaia_zaslonka f_vz = new Form_making_vozdushnaia_zaslonka();
                        DialogResult dr_f_vz = f_vz.ShowDialog(this);

                        if (dr_f_vz == DialogResult.OK)
                        {
                            vent_sys_current.Add_Vozdushnaia_zaslonka((uchastki_index + 1), DataStatic.rotated_or_not, DataStatic.marka_before_razmeri, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Противопожарный клапан")
                    {
                        Form_making_protivopojarniy_klapan f_pk = new Form_making_protivopojarniy_klapan();
                        DialogResult dr_f_pk = f_pk.ShowDialog(this);

                        if (dr_f_pk == DialogResult.OK)
                        {
                            vent_sys_current.Add_Protivopojarniy_klapan((uchastki_index + 1), DataStatic.rotated_or_not, DataStatic.marka_before_razmeri,
                                DataStatic.marka_after_razmeri, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Дымовой клапан")
                    {
                        Form_making_dimovoy_klapan f_dk = new Form_making_dimovoy_klapan();
                        DialogResult dr_f_dk = f_dk.ShowDialog(this);
                        
                        if (dr_f_dk == DialogResult.OK)
                        {
                            vent_sys_current.Add_Dimovoy_klapan((uchastki_index + 1), DataStatic.klapan_kanalniy_true_stenovoy_false,
                                DataStatic.rotated_or_not, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Обратный клапан")
                    {
                        Form_making_klapan_obratniy f_ko = new Form_making_klapan_obratniy();
                        DialogResult dr_f_ko = f_ko.ShowDialog(this);

                        if (dr_f_ko == DialogResult.OK)
                        {
                            vent_sys_current.Add_Obratniy_klapan((uchastki_index + 1), DataStatic.klapan_na_gorizontali_1_na_vertikali_2,
                                DataStatic.rotated_or_not, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Обратный клапан (Сигмавент)")
                    {
                        Form_obratniy_klapan_s_elektroprivodom f_ok_el = new Form_obratniy_klapan_s_elektroprivodom();
                        DialogResult dr_f_ok_el = f_ok_el.ShowDialog(this);

                        if (dr_f_ok_el == DialogResult.OK)
                        {
                            vent_sys_current.Add_Obratniy_klapan_s_elektroprivodom((uchastki_index + 1), DataStatic.rotated_or_not, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Клапан избыточного давления")
                    {
                        Form_make_klapan_izbitochnogo_davlenia f_kid = new Form_make_klapan_izbitochnogo_davlenia();
                        DialogResult dr_f_kid = f_kid.ShowDialog(this);

                        if (dr_f_kid == DialogResult.OK)
                        {
                            vent_sys_current.Add_Klapan_izbitochnogo_davlenia((uchastki_index + 1), DataStatic.rotated_or_not, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Гермоклапан")
                    {
                        if (uchastok_current.Forma_sechenia == "rectangle")
                        {
                            MessageBox.Show("Ошибка! Вы пытаетесь добавить гермоклапан на участок прямоугольного сечения. Гермоклапан можно добавить только на участок круглого сечения.");
                        }
                        else
                        {
                            Form_making_germoklapan f_ger = new Form_making_germoklapan();
                            DialogResult dr_f_ger = f_ger.ShowDialog(this);

                            if (dr_f_ger == DialogResult.OK)
                            {
                                vent_sys_current.Add_Germoklapan((uchastki_index + 1), DataStatic.tip_germoklapana,
                                    DataStatic.germoklapan_kor_or_not, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                                refresh_mestnie_soprotivlenia();
                            }
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Фильтр воздушный")
                    {
                        Form_making_filtr f_f = new Form_making_filtr();
                        DialogResult dr_f_f = f_f.ShowDialog(this);

                        if (dr_f_f == DialogResult.OK)
                        {
                            vent_sys_current.Add_Filtr((uchastki_index + 1), DataStatic.filtr_proizvoditel, DataStatic.filtr_klass, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Нагреватель электрический")
                    {
                        Form_making_elektricheskiy_nagrevatel f_el_nag = new Form_making_elektricheskiy_nagrevatel();
                        DialogResult dr_f_el_nag = f_el_nag.ShowDialog(this);

                        if (dr_f_el_nag == DialogResult.OK)
                        {
                            vent_sys_current.Add_ElektroNagrevatel((uchastki_index + 1), DataStatic.moschnost_nagrevatelia, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Охладитель фреоновый")
                    {
                        Form_making_freonoviy_ohladitel f_fr_oh = new Form_making_freonoviy_ohladitel();
                        DialogResult dr_f_fr_oh = f_fr_oh.ShowDialog(this);

                        if (dr_f_fr_oh == DialogResult.OK)
                        {
                            vent_sys_current.Add_Freonoviy_ohladitel((uchastki_index + 1), DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Шумоглушитель")
                    {
                        Form_making_shumoglushitel f_shum = new Form_making_shumoglushitel();
                        DialogResult dr_f_shum = f_shum.ShowDialog(this);

                        if (dr_f_shum == DialogResult.OK)
                        {
                            vent_sys_current.Add_Shumoglushitel((uchastki_index + 1), DataStatic.shumoglushitel_proizvoditel,
                                DataStatic.shumoglushitel_dlina, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Гибкая вставка")
                    {
                        Form_making_gibkaia_vstavka f_gibk = new Form_making_gibkaia_vstavka();
                        DialogResult dr_f_gibk = f_gibk.ShowDialog(this);

                        if (dr_f_gibk == DialogResult.OK)
                        {
                            vent_sys_current.Add_Gibkaia_vstavka((uchastki_index + 1), DataStatic.gibkaia_vstavka_proizvoditel, DataStatic.kolichestvo_elementov_mestnogo_soprotivlenia);
                            refresh_mestnie_soprotivlenia();
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Решётка воздухораспределительная")
                    {
                        vent_sys_current.Add_Reshetka(uchastki_index + 1);
                        refresh_mestnie_soprotivlenia();
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Сетка воздухораспределительная")
                    {
                        vent_sys_current.Add_Setka(uchastki_index + 1);
                        refresh_mestnie_soprotivlenia();
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Диффузор (воздухораспределитель)")
                    {
                        vent_sys_current.Add_Diffuzor(uchastki_index + 1);
                        refresh_mestnie_soprotivlenia();
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Диффузор со статической камерой")
                    {
                        vent_sys_current.Add_Diffuzor_stat_kamera(uchastki_index + 1);
                        refresh_mestnie_soprotivlenia();
                    }
                    else if ((DataStatic.tip_mestnogo_soprotivlenia == "Переходник") || (DataStatic.tip_mestnogo_soprotivlenia == "Внезапный переход"))
                    {
                        int number_uchastok_current = uchastki_index + 1;
                        int number_uchastok_before = number_uchastok_current - 1;
                        int number_uchastok_after = number_uchastok_current + 1;
                        int kolichestvo_uchastkov = vent_sys_current.Spisok_uchastkov.Count();

                        DataStatic.number_uchastok_current = number_uchastok_current;
                        DataStatic.number_uchastok_before = number_uchastok_before;
                        DataStatic.number_uchastok_after = number_uchastok_after;
                        DataStatic.kolichestvo_uchastkov = kolichestvo_uchastkov;

                        if (DataStatic.tip_mestnogo_soprotivlenia == "Переходник") DataStatic.vnezapniy_perehod = false;
                        else if (DataStatic.tip_mestnogo_soprotivlenia == "Внезапный переход") DataStatic.vnezapniy_perehod = true;
                        else DataStatic.vnezapniy_perehod = false;

                        int kolichestvo_elementov_current_uchastok = uchastok_current.Spisok_soprotivleniy.Count;

                        if (kolichestvo_uchastkov < 1)
                        {
                            MessageBox.Show("Ошибка! В выбранной системе вентиляции не существует ни одного участка. Переход добавить нельзя. Для построения перехода необходимо, чтобы в системе было минимум 2 участка.");
                        }
                        else if (kolichestvo_uchastkov == 1)
                        {
                            MessageBox.Show("Ошибка! В выбранной системе вентиляции существует только 1 участок. Переход добавить нельзя. Для построения перехода необходимо, чтобы в системе было минимум 2 участка.");
                        }
                        else
                        {
                            Form_making_perehod f_perehod = new Form_making_perehod();
                            DialogResult dr_f_perehod = f_perehod.ShowDialog(this);

                            if (dr_f_perehod == DialogResult.OK)
                            {
                                Uchastok uch_before;
                                Uchastok uch_after;

                                int kolichestvo_elementov_uch_before = 0;
                                int kolichestvo_elementov_uch_after = 0;

                                if (number_uchastok_before >= 1)
                                {
                                    uch_before = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_before);
                                    kolichestvo_elementov_uch_before = uch_before.Spisok_soprotivleniy.Count;
                                }

                                if (number_uchastok_after <= DataStatic.kolichestvo_uchastkov)
                                {
                                    uch_after = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_after);
                                    kolichestvo_elementov_uch_after = uch_after.Spisok_soprotivleniy.Count();
                                }

                                vent_sys_current.Add_Perehod_Between(DataStatic.first_uchastok_number, DataStatic.second_uchastok_number, DataStatic.perehod_dlina);
                                refresh_mestnie_soprotivlenia();

                                int kolichestvo_elementov_current_uchastok_new = uchastok_current.Spisok_soprotivleniy.Count;

                                if (kolichestvo_elementov_current_uchastok_new > kolichestvo_elementov_current_uchastok)
                                {
                                    MessageBox.Show("Переходник добавлен на текущий участок");
                                }
                                else if (number_uchastok_before < 1)
                                {
                                    MessageBox.Show("Переходник добавлен на следующий (по номеру) участок");
                                }
                                else if (number_uchastok_after > DataStatic.kolichestvo_uchastkov)
                                {
                                    MessageBox.Show("Переходник добавлен на предыдущий (по номеру) участок");
                                }
                                else
                                {
                                    Uchastok uch_before_new = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_before);
                                    Uchastok uch_after_new = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_after);

                                    int kolichestvo_elementov_uch_before_new = uch_before_new.Spisok_soprotivleniy.Count;
                                    int kolichestvo_elementov_uch_after_new = uch_after_new.Spisok_soprotivleniy.Count;

                                    if (kolichestvo_elementov_uch_before_new > kolichestvo_elementov_uch_before)
                                    {
                                        MessageBox.Show("Переходник добавлен на предыдущий (по номеру) участок");
                                    }
                                    else if (kolichestvo_elementov_uch_after_new > kolichestvo_elementov_uch_after)
                                    {
                                        MessageBox.Show("Переходник добавлен на следующий (по номеру) участок");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ошибка! Непонятно, на какой участок добавлен переходник. Возможно, он вообще не добавлен.");
                                    }
                                }
                            }
                        }
                    }
                    else if (DataStatic.tip_mestnogo_soprotivlenia == "Тройник")
                    {
                        int number_uchastok_current = uchastki_index + 1;
                        int number_uchastok_before = number_uchastok_current - 1;
                        int number_uchastok_after = number_uchastok_current + 1;
                        int kolichestvo_uchastkov = vent_sys_current.Spisok_uchastkov.Count();

                        DataStatic.number_uchastok_current = number_uchastok_current;
                        DataStatic.number_uchastok_before = number_uchastok_before;
                        DataStatic.number_uchastok_after = number_uchastok_after;
                        DataStatic.kolichestvo_uchastkov = kolichestvo_uchastkov;

                        DataStatic.vent_sys_type = vent_sys_current.Vent_sys_type;

                        int kolichestvo_elementov_current_uchastok = uchastok_current.Spisok_soprotivleniy.Count;

                        if (kolichestvo_uchastkov < 1)
                        {
                            MessageBox.Show("Ошибка! В выбранной системе вентиляции не существует ни одного участка. Тройник добавить нельзя. Для построения тройника необходимо, чтобы в системе для расчётного направления было минимум 2 участка.");
                        }
                        else if (kolichestvo_uchastkov == 1)
                        {
                            MessageBox.Show("Ошибка! В выбранной системе вентиляции существует только 1 участок. Тройник добавить нельзя. Для построения тройника необходимо, чтобы в системе для расчётного направления было минимум 2 участка.");
                        }
                        else
                        {
                            Form_making_troynik f_troynik = new Form_making_troynik();
                            DialogResult dr_f_troynik = f_troynik.ShowDialog(this);

                            if (dr_f_troynik == DialogResult.OK)
                            {
                                Uchastok uch_before;
                                Uchastok uch_after;

                                int kolichestvo_elementov_uch_before = 0;
                                int kolichestvo_elementov_uch_after = 0;

                                if (number_uchastok_before >= 1)
                                {
                                    uch_before = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_before);
                                    kolichestvo_elementov_uch_before = uch_before.Spisok_soprotivleniy.Count;
                                }

                                if (number_uchastok_after <= DataStatic.kolichestvo_uchastkov)
                                {
                                    uch_after = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_after);
                                    kolichestvo_elementov_uch_after = uch_after.Spisok_soprotivleniy.Count();
                                }

                                vent_sys_current.Add_Troynik_Between(DataStatic.first_uchastok_number, DataStatic.second_uchastok_number, DataStatic.troynik_type,
                                    DataStatic.other_uchastok_width, DataStatic.other_uchastok_height, DataStatic.other_uchastok_diameter);
                                refresh_mestnie_soprotivlenia();

                                int kolichestvo_elementov_current_uchastok_new = uchastok_current.Spisok_soprotivleniy.Count;

                                if (kolichestvo_elementov_current_uchastok_new > kolichestvo_elementov_current_uchastok)
                                {
                                    MessageBox.Show("Тройник добавлен на текущий участок");
                                }
                                else
                                {
                                    Uchastok uch_before_new = null;
                                    if (number_uchastok_before >= 1) uch_before_new = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_before);
                                    Uchastok uch_after_new = null;
                                    if (number_uchastok_after > DataStatic.kolichestvo_uchastkov) uch_after_new = vent_sys_current.Get_Uchastok_By_Number(number_uchastok_after);

                                    int kolichestvo_elementov_uch_before_new = 0;
                                    if (!(uch_before_new is null)) kolichestvo_elementov_uch_before_new = uch_before_new.Spisok_soprotivleniy.Count;
                                    int kolichestvo_elementov_uch_after_new = 0;
                                    if (!(uch_after_new is null)) kolichestvo_elementov_uch_after_new = uch_after_new.Spisok_soprotivleniy.Count;

                                    if (kolichestvo_elementov_uch_before_new > kolichestvo_elementov_uch_before)
                                    {
                                        MessageBox.Show("Тройник добавлен на предыдущий (по номеру) участок");
                                    }
                                    else if (kolichestvo_elementov_uch_after_new > kolichestvo_elementov_uch_after)
                                    {
                                        MessageBox.Show("Тройник добавлен на следующий (по номеру) участок");
                                    }
                                    else if ((number_uchastok_before) < 1 && (uch_after_new is null))
                                    {
                                        MessageBox.Show("Тройник не может быть добавлен никуда. Перед текущим участком другого участка не существует. А расход текущего участка не является меньшим по отношению к следующему участку (тройник должен добавляться на участок с меньшим расходом).");
                                    }
                                    else if ((uch_before_new is null) && (number_uchastok_after > DataStatic.kolichestvo_uchastkov))
                                    {
                                        MessageBox.Show("Тройник не может быть добавлен никуда. После текущего участка другого участка не существует. А расход текущего участка не является меньшим по отношению к предыдущему участку (тройник должен добавляться на участок с меньшим расходом).");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ошибка! Непонятно, на какой участок добавлен тройник. Возможно, он вообще не добавлен.");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {

            }
        }

        private void button_delete_uchastok_EnabledChanged(object sender, EventArgs e)
        {
            refresh_mestnie_soprotivlenia();
            if (listBox_uchastki.SelectedIndex < 0)
            {
                button_delete_uchastok.Enabled = false;
                button_edit_uchastok.Enabled = false;
            }
        }

        private void button_delete_mestnoe_soprotivlenie_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;

            VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy.RemoveAt(index_ms);

            refresh_mestnie_soprotivlenia();
        }

        private void refresh_buttons_move_uchastki()
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int q = listBox_uchastki.Items.Count;

            if ((index_vs >= 0) && (index_uch >= 0))
            {
                if (index_uch == 0)
                {
                    button_move_uchastok_up.Enabled = false;
                }
                else
                {
                    button_move_uchastok_up.Enabled = true;
                }

                if (index_uch >= (q - 1))
                {
                    button_move_uchastok_down.Enabled = false;
                }
                else
                {
                    button_move_uchastok_down.Enabled = true;
                }
            }
            else
            {
                button_move_uchastok_up.Enabled = false;
                button_move_uchastok_down.Enabled = false;
            }
        }
        private void refresh_enable_buttons_move_mestnie_soprotivlenia()
        {
            if (button_delete_mestnoe_soprotivlenie.Enabled)
            {
                int index_vs = listBox_vent_systems.SelectedIndex;
                int index_uch = listBox_uchastki.SelectedIndex;
                int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;
                int q = listBox_mestnie_soprotivlenia.Items.Count;

                if ((index_vs >= 0) && (index_uch >= 0) && (index_ms >= 0))
                {
                    if (index_ms == 0)
                    {
                        button_move_mestnoe_soprotivlenie_up.Enabled = false;
                    }
                    else
                    {
                        button_move_mestnoe_soprotivlenie_up.Enabled = true;
                    }

                    if (index_ms >= (q - 1))
                    {
                        button_move_mestnoe_soprotivlenie_down.Enabled = false;
                    }
                    else
                    {
                        button_move_mestnoe_soprotivlenie_down.Enabled = true;
                    }
                }
            }
            else
            {
                button_move_mestnoe_soprotivlenie_up.Enabled = false;
                button_move_mestnoe_soprotivlenie_down.Enabled = false;
            }
        }
        private void button_delete_mestnoe_soprotivlenie_EnabledChanged(object sender, EventArgs e)
        {
            if (listBox_mestnie_soprotivlenia.SelectedIndex < 0)
            {
                button_delete_mestnoe_soprotivlenie.Enabled = false;
            }

            button_delete_mestnie_soprotivlenia_before.Enabled = button_delete_mestnoe_soprotivlenie.Enabled;
            button_delete_mestnie_soprotivlenia_after.Enabled = button_delete_mestnoe_soprotivlenie.Enabled;
            button_delete_mestnie_soprotivlenia_all.Enabled = button_delete_mestnoe_soprotivlenie.Enabled;

            refresh_enable_buttons_move_mestnie_soprotivlenia();
        }

        private void button_create_mestnoe_soprotivlenie_EnabledChanged(object sender, EventArgs e)
        {
            if (listBox_uchastki.SelectedIndex < 0)
            {
                button_create_mestnoe_soprotivlenie.Enabled = false;
            }
        }

        private void button_delete_mestnie_soprotivlenia_before_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;

            int i_new = 0;

            while (i_new != index_ms)
            {
                VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy.RemoveAt(0);
                i_new++;
            }
            refresh_mestnie_soprotivlenia();
        }

        private void button_delete_mestnie_soprotivlenia_after_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;

            int q = listBox_mestnie_soprotivlenia.Items.Count;

            for (int i = (q-1); i > index_ms; i--)
            {
                VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy.RemoveAt(i);
            }

            refresh_mestnie_soprotivlenia();
        }

        private void button_delete_mestnie_soprotivlenia_all_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;

            VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy.Clear();

            refresh_mestnie_soprotivlenia();
        }

        private void button_edit_uchastok_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;

            if ((index_vs >= 0) && (index_uch >= 0))
            {
                Uchastok uch_cur = VentSysList[index_vs].Spisok_uchastkov[index_uch];

                if (uch_cur.Forma_sechenia == "circle")
                {
                    DataStatic.uchastok_rectangle_or_not = false;
                }
                else
                {
                    DataStatic.uchastok_rectangle_or_not = true;
                }

                DataStatic.uchastok_material = uch_cur.Material;
                DataStatic.uchastok_temperatura = uch_cur.t;
                DataStatic.uchastok_rashod_m3_in_hour = uch_cur.Rashod_m3_in_hour;
                DataStatic.uchastok_dlina_m = uch_cur.Length_m;
                DataStatic.diameter = uch_cur.Diameter_mm;
                DataStatic.uchastok_shirina_mm = uch_cur.Width_mm;
                DataStatic.uchastok_visota_mm = uch_cur.Height_mm;

                Form_edit_uchastok f_edit_uch = new Form_edit_uchastok();
                DialogResult dr_f_edit_uch = f_edit_uch.ShowDialog(this);

                if (dr_f_edit_uch == DialogResult.OK)
                {
                    if (DataStatic.uchastok_rectangle_or_not)
                    {
                        VentSysList[index_vs].Change_Uchastok_by_Rectangle((index_uch + 1), DataStatic.uchastok_rashod_m3_in_hour, DataStatic.uchastok_dlina_m,
                            DataStatic.uchastok_shirina_mm, DataStatic.uchastok_visota_mm, DataStatic.uchastok_material);
                        VentSysList[index_vs].Spisok_uchastkov[index_uch].t = DataStatic.uchastok_temperatura;
                    }
                    else
                    {
                        VentSysList[index_vs].Change_Uchastok_by_Circle((index_uch + 1), DataStatic.uchastok_rashod_m3_in_hour, DataStatic.uchastok_dlina_m,
                            DataStatic.uchastok_diameter_mm, DataStatic.uchastok_material);
                        VentSysList[index_vs].Spisok_uchastkov[index_uch].t = DataStatic.uchastok_temperatura;
                    }
                }

                refresh_listbox_uchastki();
                refresh_mestnie_soprotivlenia();
            }
            else
            {

            }
        }

        private void button_move_mestnoe_soprotivlenie_up_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;

            if (index_ms > 0)
            {
                Mestnoe_soprotivlenie ms_current = VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms];

                VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms] =
                    VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms - 1];

                VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms - 1] = ms_current;

                listBox_mestnie_soprotivlenia.SelectedIndex--;

                refresh_mestnie_soprotivlenia();

                refresh_enable_buttons_move_mestnie_soprotivlenia();

                index_ms--;
                listBox_mestnie_soprotivlenia.SetSelected(index_ms, true);
            }
        }

        private void button_move_mestnoe_soprotivlenie_down_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int index_ms = listBox_mestnie_soprotivlenia.SelectedIndex;

            int q = listBox_mestnie_soprotivlenia.Items.Count;

            if (index_ms < (q - 1))
            {
                Mestnoe_soprotivlenie ms_current = VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms];

                VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms] =
                    VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms + 1];

                VentSysList[index_vs].Spisok_uchastkov[index_uch].Spisok_soprotivleniy[index_ms + 1] = ms_current;

                listBox_mestnie_soprotivlenia.SelectedIndex++;

                refresh_mestnie_soprotivlenia();
                refresh_enable_buttons_move_mestnie_soprotivlenia();

                index_ms++;
                listBox_mestnie_soprotivlenia.SetSelected(index_ms, true);
            }
        }

        private void button_move_uchastok_up_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;
            int q = listBox_uchastki.Items.Count;

            if (index_uch > 0)
            {
                VentSysList[index_vs].Spisok_uchastkov[index_uch].Number = (q + 1);
                Uchastok uch_current = VentSysList[index_vs].Spisok_uchastkov[index_uch];

                VentSysList[index_vs].Spisok_uchastkov[index_uch - 1].Number = (index_uch + 1);
                VentSysList[index_vs].Spisok_uchastkov[index_uch] = VentSysList[index_vs].Spisok_uchastkov[index_uch - 1];

                VentSysList[index_vs].Spisok_uchastkov[index_uch - 1] = uch_current;
                VentSysList[index_vs].Spisok_uchastkov[index_uch - 1].Number = index_uch;

                listBox_uchastki.SelectedIndex--;

                refresh_listbox_uchastki();
                refresh_mestnie_soprotivlenia();
                refresh_buttons_move_uchastki();

                index_uch--;

                listBox_uchastki.SetSelected(index_uch, true);
            }
        }

        private void button_move_uchastok_down_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;
            int index_uch = listBox_uchastki.SelectedIndex;

            int q = listBox_uchastki.Items.Count;

            if (index_uch < (q - 1))
            {
                VentSysList[index_vs].Spisok_uchastkov[index_uch].Number = (q + 1);
                Uchastok uch_current = VentSysList[index_vs].Spisok_uchastkov[index_uch];

                VentSysList[index_vs].Spisok_uchastkov[index_uch + 1].Number = (index_uch + 1);
                VentSysList[index_vs].Spisok_uchastkov[index_uch] = VentSysList[index_vs].Spisok_uchastkov[index_uch + 1];

                VentSysList[index_vs].Spisok_uchastkov[index_uch + 1] = uch_current;
                VentSysList[index_vs].Spisok_uchastkov[index_uch + 1].Number = (index_uch + 2);

                listBox_uchastki.SelectedIndex++;

                refresh_listbox_uchastki();
                refresh_mestnie_soprotivlenia();
                refresh_buttons_move_uchastki();

                index_uch++;

                listBox_uchastki.SetSelected(index_uch, true);
            }
        }

        private void button_edit_vent_sys_Click(object sender, EventArgs e)
        {
            int index_vs = listBox_vent_systems.SelectedIndex;

            if (index_vs >= 0)
            {
                DataStatic.vent_sys_new_type = VentSysList[index_vs].Vent_sys_type;
                DataStatic.vent_sys_new_number = VentSysList[index_vs].Number_of_system_string;
                DataStatic.vent_sys_napor_ventiliatora = VentSysList[index_vs].Napor_ventiliatora_m3_in_hour;

                string old_vent_sys_number = VentSysList[index_vs].Number_of_system_string;
                double old_vent_sys_napor = VentSysList[index_vs].Napor_ventiliatora_m3_in_hour;

                Form_edit_vent_sys f_edit_vs = new Form_edit_vent_sys();
                DialogResult dr_f_edit_vs = f_edit_vs.ShowDialog(this);

                if (dr_f_edit_vs == DialogResult.OK)
                {
                    VentSysList[index_vs].Napor_ventiliatora_m3_in_hour = DataStatic.vent_sys_napor_ventiliatora;

                    string vs_name_new = (DataStatic.vent_sys_new_type + DataStatic.vent_sys_new_number);

                    bool flag = true;

                    foreach (Ventilation_system vs in VentSysList)
                    {
                        if (vs.Name_of_sys == vs_name_new)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        VentSysList[index_vs].Change_number_of_system(DataStatic.vent_sys_new_number);
                    }
                    else
                    {
                        if ((DataStatic.vent_sys_new_number != old_vent_sys_number) && (DataStatic.vent_sys_napor_ventiliatora != old_vent_sys_napor))
                        {
                            MessageBox.Show("Новое значение напора вентилятора (вентустановки) принято. Но переименовать систему не получилось, поскольку система с именем " + vs_name_new + " уже существует. Задайте другой номер системы, чтобы переименовать систему.");
                        }
                        else if ((DataStatic.vent_sys_new_number != old_vent_sys_number) && (DataStatic.vent_sys_napor_ventiliatora == old_vent_sys_napor))
                        {
                            MessageBox.Show("Переименовать систему не получилось, поскольку система с именем " + vs_name_new + " уже существует. Задайте другой номер системы, чтобы переименовать систему.");
                        }
                    }

                    refresh_listbox_vent_systems();
                }
            }
        }

        private void refresh_button_make_airodynamic_calculation()
        {
            if (VentSysList.Count > 0)
            {
                button_make_airodynamic_calculation.Enabled = true;
            }
            else
            {
                button_make_airodynamic_calculation.Enabled = false;
            }
        }

        private List<string> get_statistic_table_of_ventilation_systems()
        {
            List<string> rez_list = new List<string>();

            rez_list.Add(@"<b><p style='padding-top: 20px;'><font face='ISOCPEUR' style='font-weight: 2000; color: #5f0000;' size='5'>Данные систем вентиляции по напору и их оценка.</font></p></b>");
            rez_list.Add(@"<center><table style='border: 1px solid black; background-color: #fffcdf;' border='1' width='1420 px' cellspacing='0'>");
            rez_list.Add(@"<tr style='background-color: #f5d5b0;' height = '25 px'>");
            rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b><font face='ISOCPEUR'>Имя системы</font></b></td>");
            rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Потери давления, [Па]</font></b></td>");
            rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Требуемый напор вентилятора, [Па]</font></b></td>");
            rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Фактический напор вентилятора, [Па]</font></b></td>");
            rez_list.Add(@"<td width = '420 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Результат оценки</font></b></td>");
            rez_list.Add(@"</tr>");

            foreach (Ventilation_system vs in VentSysList)
            {
                double p_treb = Math.Round((vs.Poteri_davlenia_v_sisteme_polnie * 1.2), 0);
                double p_fact = Math.Round(vs.Napor_ventiliatora_m3_in_hour, 2);

                string rez_str;
                string str_color;

                if (p_fact < p_treb)
                {
                    rez_str = "Недостаток напора вентилятора " + (p_treb - p_fact).ToString() + " Па";
                    str_color = @"#f87d7d";
                }
                else if ((p_fact - p_treb) <= 200.0)
                {
                    rez_str = "Напор вентилятора в норме, избыток " + (p_fact - p_treb).ToString() + " Па";
                    str_color = @"#7df87d";
                }
                else
                {
                    rez_str = "Переизбыток напора вентилятора " + (p_fact - p_treb).ToString() + " Па";
                    str_color = @"#7d97f8";
                }

                rez_list.Add(@"<tr style='background-color: " + str_color + @";' height = '25 px'>");
                rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<b><font face='ISOCPEUR'>" + vs.Name_of_sys + @"</font></b></td>");
                rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<b>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(vs.Poteri_davlenia_v_sisteme_polnie, 2).ToString() + @"</font></b></td>");
                rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<b>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + p_treb.ToString() + @"</font></b></td>");
                rez_list.Add(@"<td width = '250 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<b>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + p_fact.ToString() + @"</font></b></td>");
                rez_list.Add(@"<td width = '420 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<b>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + rez_str + @"</font></b></td>");
                rez_list.Add(@"</tr>");
            }

            rez_list.Add(@"</table></center>");

            return rez_list;
        }
        private List<string> get_raschet_mestnie_soprotivlenia_table(Ventilation_system vs, Uchastok uch)
        {
            List<string> rez_list = new List<string>();

            rez_list.Add(@"<p><font face='ISOCPEUR' style='font-size: 16pt; font-weight: 700; color: #5f0000;'>Участок " + uch.Number + @". Система " + vs.Name_of_sys + @".</font></p>");
            rez_list.Add(@"<center><table style='border: 1px solid black; background-color: #fffcdf;' border='1' width='800' cellspacing='0'>");
            rez_list.Add(@"<tr style='background-color: #f5d5b0;' height = '25 px'>");
            rez_list.Add(@"<td width = '500 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b><font face='ISOCPEUR'>Наименование местного сопротивления</font></b></td>");
            rez_list.Add(@"<td width = '150 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>ζ</font></b></td>");
            rez_list.Add(@"<td width = '150 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Pм.c., [Па]</font></b></td>");
            rez_list.Add(@"</tr>");

            foreach (Mestnoe_soprotivlenie mest_sopr in uch.Spisok_soprotivleniy)
            {
                rez_list.Add(@"<tr height = '25 px'>");
                rez_list.Add(@"<td width = '500 px' style='border: 1px solid black;' align='left'>");
                rez_list.Add(@"<p style='margin-left: 10px'><font face='ISOCPEUR'>" + mest_sopr.Name + @"<span lang='en-us'></span></font></td>");
                rez_list.Add(@"<td width = '150 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(mest_sopr.KMS, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width = '150 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(((mest_sopr.KMS * uch.plotnost * Math.Pow(uch.v, 2.0)) / 2.0), 2).ToString() + @"</font></td>");
                rez_list.Add(@"</tr>");
            }

            rez_list.Add(@"<tr height = '25 px'>");
            rez_list.Add(@"<td width = '500 px' style='border: 1px solid black;' align='right'>");
            rez_list.Add(@"<p style='margin-right: 10px'><b><font face='ISOCPEUR'>Итого:</font></b></td>");
            rez_list.Add(@"<td width = '150 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Sum_of_kms, 2).ToString() + @"</font></td>");
            rez_list.Add(@"<td width = '150 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Poteri_davlenia_na_mestnie_soprotivlenia_Pa, 2).ToString() + @"</font></td>");
            rez_list.Add(@"</tr>");
            rez_list.Add(@"</table></center>");

            return rez_list;
        }
        private List<string> get_raschet_uchastki_table(Ventilation_system vs)
        {
            List<string> rez_list = new List<string>();

            rez_list.Add(@"<p align='center'>");
            rez_list.Add(@"<font face='ISOCPEUR' style='font-weight: 700; margin-top: 0 px' color='#5f0000' size='5'>Система вентиляции " + vs.Name_of_sys + @"</font></p>");
            rez_list.Add(@"<center><table style='border: 1px solid black; background-color: #fffcdf;' cellspacing='0' width='1420'>");
            rez_list.Add(@"<tr style='background-color: #f5d5b0;'>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>№ уч.</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>L, [м³/ч]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>l, [м]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>A, [мм]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>B, [мм]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>dэкв, [мм]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='Calibri'>t</font><font face='ISOCPEUR'>, [°C]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='Calibri'>ρ</font><font face='ISOCPEUR'>, [кг/м³]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Re</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Kэ, [мм]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>λ</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Fэкв, [м²]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>v, [м/с]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>ΔPдл., [Па]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>∑ζ</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>∑Pм.c., [Па]</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>ΔP, [Па]</font></b></td>");
            rez_list.Add(@"</tr>");

            foreach (Uchastok uch in vs.Spisok_uchastkov)
            {
                rez_list.Add(@"<tr>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + uch.Number.ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Rashod_m3_in_hour, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Length_m, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + (uch.Forma_sechenia == "rectangle" ? Math.Round(uch.Width_mm, 0).ToString() : "-") + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + (uch.Forma_sechenia == "rectangle" ? Math.Round(uch.Height_mm, 0).ToString() : "-") + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Diameter_mm, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.t, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.plotnost, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Re, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.K_ekv, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Liambda, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.f, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.v, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Poteri_davlenia_po_dline_Pa, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Sum_of_kms, 2).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Poteri_davlenia_na_mestnie_soprotivlenia_Pa, 3).ToString() + @"</font></td>");
                rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
                rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(uch.Poteri_davlenia_polnie_Pa, 3).ToString() + @"</font></td>");
                rez_list.Add(@"</tr>");
            }

            rez_list.Add(@"<tr>");
            rez_list.Add(@"<td width='3304' style='border: 1px solid black;' align='center' colspan='15'>&nbsp;</td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<b>");
            rez_list.Add(@"<font face='ISOCPEUR'>Итого:</font></b></td>");
            rez_list.Add(@"<td width='236 px' style='border: 1px solid black;' align='center'>");
            rez_list.Add(@"<font face='ISOCPEUR'>" + Math.Round(vs.Poteri_davlenia_v_sisteme_polnie, 2).ToString() + @"</font></td>");
            rez_list.Add(@"</tr>");
            rez_list.Add(@"</table></center>");

            foreach (Uchastok uch in vs.Spisok_uchastkov)
            {
                rez_list.AddRange(get_raschet_mestnie_soprotivlenia_table(vs, uch));
            }

            return rez_list;
        }

        private List<string> get_raschet_ventilation_systems()
        {
            List<string> rez_list = new List<string>();

            rez_list.Add(@"<html>");
            rez_list.Add(@"<head>");
            rez_list.Add(@"<meta http-equiv='Content-Language' content='ru'>");
            rez_list.Add(@"<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>");
            rez_list.Add(@"<title>Результаты аэродинамического расчёта систем вентиляции</title>");
            rez_list.Add(@"<style>");
            rez_list.Add(@"td");
            rez_list.Add(@"{");
            rez_list.Add(@"1px solid black;");
            rez_list.Add(@"}");
            rez_list.Add(@"</style>");
            rez_list.Add(@"</head>");
            rez_list.Add(@"<body style='margin-top: 0 px; margin-bottom: 0 px; background-color:#7dc7d2;'>");
            rez_list.Add(@"<center><table border='0' width='1500 px' style='height: 100%; background-color:#efffff; text-align: center;'>");
            rez_list.Add(@"<tr>");
            rez_list.Add(@"<td style='vertical-align: top;'>");

            rez_list.AddRange(get_statistic_table_of_ventilation_systems());

            foreach (Ventilation_system vs in this.VentSysList)
            {
                rez_list.AddRange(get_raschet_uchastki_table(vs));
            }
            rez_list.Add(@"<p style='padding-bottom: 20px;'></p>");
            rez_list.Add(@"</td>");
            rez_list.Add(@"</tr>");
            rez_list.Add(@"</table></center>");
            rez_list.Add(@"</body>");
            rez_list.Add(@"</html>");

            return rez_list;
        }
        private void button_make_airodynamic_calculation_Click(object sender, EventArgs e)
        {
            Form_make_file_otcheta f_f_otch = new Form_make_file_otcheta();
            DialogResult dr_f_f_otch = f_f_otch.ShowDialog(this);

            if (dr_f_f_otch == DialogResult.OK)
            {
                if ((DataStatic.file_otchet_name != "") && (DataStatic.file_otchet_path != ""))
                {
                    try
                    {
                        List<string> str_output = new List<string>();

                        str_output = get_raschet_ventilation_systems();

                        /*
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(DataStatic.file_otchet_path + DataStatic.file_otchet_name + @".html");

                        foreach (string str in str_output)
                        {
                            sw.Write(str + Environment.NewLine);
                            sw.Flush();
                        }
                        */

                        using (System.IO.FileStream fs = new System.IO.FileStream((DataStatic.file_otchet_path + DataStatic.file_otchet_name + @".html"),
                            System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None))
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(fs);
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fs))
                            {
                                foreach (string str in str_output)
                                {
                                    sw.Write(str + Environment.NewLine);
                                    sw.Flush();
                                }
                            }
                        }

                        System.Diagnostics.ProcessStartInfo start_page_result = new System.Diagnostics.ProcessStartInfo(DataStatic.file_otchet_path + DataStatic.file_otchet_name + @".html");
                        System.Diagnostics.Process.Start(start_page_result);
                    }
                    catch
                    {
                        MessageBox.Show("Произошла непредвиденная ошибка. Расчёт не выполнен. Данные не сохранены.");
                    }
                }
                else
                {
                    if ((DataStatic.file_otchet_name == "") && (DataStatic.file_otchet_path != ""))
                    {
                        MessageBox.Show("Ошибка! Указанное имя файла имеет пустое значение. Расчёт не выполнен. Данные не сохранены.");
                    }
                    else if ((DataStatic.file_otchet_name != "") && (DataStatic.file_otchet_path == ""))
                    {
                        MessageBox.Show("Ошибка! Указанный путь к папке сохранения имеет пустое значение. Расчёт не выполнен. Данные не сохранены.");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка! Указанное имя файла имеет пустое значение. Указанный путь к папке сохранения имеет пустое значение. Расчёт не выполнен. Данные не сохранены.");
                    }
                }
            }
        }

        private void listBox_vent_systems_SelectedValueChanged(object sender, EventArgs e)
        {
            refresh_button_make_airodynamic_calculation();
        }

        private void button_save_data_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_data_dialog;

            save_data_dialog = new SaveFileDialog();
            save_data_dialog.Filter = "Файлы конфигурации набора вентиляционных систем в формате vnt|*.vnt";
            save_data_dialog.DefaultExt = "vnt";

            DialogResult dr_save_data_dialog = save_data_dialog.ShowDialog(this);

            if (dr_save_data_dialog == DialogResult.OK)
            {
                try
                {
                    System.IO.FileStream stream_save_data = System.IO.File.Create(save_data_dialog.FileName);

                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bformatter_save_data = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    bformatter_save_data.Serialize(stream_save_data, VentSysList);

                    stream_save_data.Close();

                    MessageBox.Show("Данные успешно сохранены.");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении данных. Данные не сохранены.");
                }
                
            }
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_data_dialog;

            open_data_dialog = new OpenFileDialog();
            open_data_dialog.Filter = "Файлы конфигурации набора вентиляционных систем в формате vnt|*.vnt";
            open_data_dialog.DefaultExt = "vnt";

            DialogResult dr_open_data_dialog = open_data_dialog.ShowDialog(this);

            if (dr_open_data_dialog == DialogResult.OK)
            {
                try
                {
                    System.IO.FileStream stream_open_data = System.IO.File.OpenRead(open_data_dialog.FileName);

                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bformatter_open_data = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    VentSysList = bformatter_open_data.Deserialize(stream_open_data) as List<Ventilation_system>;

                    refresh_listbox_vent_systems();
                    refresh_listbox_uchastki();
                    refresh_mestnie_soprotivlenia();
                    refresh_button_edit_vent_sys();
                    refresh_buttons_move_vent_system();
                    refresh_buttons_move_uchastki();
                    refresh_enable_buttons_move_mestnie_soprotivlenia();
                    refresh_button_make_airodynamic_calculation();

                    MessageBox.Show("Данные успешно загружены.");
                }
                catch
                {
                    MessageBox.Show("Ошибка при загрузке данных. Данные не загружены.");
                }
            }
        }

        private void button_clear_all_data_Click(object sender, EventArgs e)
        {
            DialogResult dr_clear_all_data = MessageBox.Show("Все данные об имеющихся системах вентиляции будут очищены. Восстановить их будет невозможно, если они не были сохранены в отдельный файл. Вы точно хотите очистить данные?", "Подтверждение очистки всех данных", MessageBoxButtons.YesNo);

            if (dr_clear_all_data == DialogResult.Yes)
            {
                VentSysList.Clear();

                listBox_vent_systems.Items.Clear();
                listBox_uchastki.Items.Clear();
                listBox_mestnie_soprotivlenia.Items.Clear();

                button1.Visible = false;

                button_delete_vent_sys.Enabled = false;

                button_create_uchastok.Enabled = false;
                button_edit_uchastok.Enabled = false;
                button_delete_uchastok.Enabled = false;

                button_create_mestnoe_soprotivlenie.Enabled = false;
                button_delete_mestnoe_soprotivlenie.Enabled = false;
                button_delete_mestnie_soprotivlenia_before.Enabled = false;
                button_delete_mestnie_soprotivlenia_after.Enabled = false;
                button_delete_mestnie_soprotivlenia_all.Enabled = false;

                refresh_button_edit_vent_sys();
                refresh_buttons_move_uchastki();

                refresh_button_make_airodynamic_calculation();

                MessageBox.Show("Данные очищены.");
            }
        }

        private void button_data_analizing_Click(object sender, EventArgs e)
        {
            DataStatic.vs_list = VentSysList;

            Form_data_analizing f_data_analizing = new Form_data_analizing();

            DialogResult dr_f_data_analizing = f_data_analizing.ShowDialog(this);

            if (dr_f_data_analizing == DialogResult.OK)
            {

            }
        }
    }
}
