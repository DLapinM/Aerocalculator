using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    public class Ventilation_system
    {
        public string Name_of_sys { get; private set; }
        public string Vent_sys_type { get; private set; }
        public double Napor_ventiliatora_m3_in_hour { get; set; }

        public string Stream_type { get; private set; }

        public string Number_of_system_string
        {
            get
            {
                int q = Vent_sys_type.Count();
                int q_name = Name_of_sys.Count();

                char[] name_in_chars = Name_of_sys.ToCharArray();

                if (q > 0)
                {
                    string rez = "";
                    
                    while (q < q_name)
                    {
                        rez += name_in_chars[q];
                        q++;
                    }

                    return rez;
                }
                else
                {
                    return "";
                }
            }
        }

        public List<Uchastok> Spisok_uchastkov { get; private set; }

        public void Change_number_of_system(string number_of_system_new)
        {
            Name_of_sys = (this.Vent_sys_type + number_of_system_new);
        }

        public Ventilation_system(string vent_sys_type, string number_of_sys)
        {
            switch (vent_sys_type)
            {
                case "П":
                    this.Vent_sys_type = "П";
                    break;
                case "В":
                    this.Vent_sys_type = "В";
                    break;
                case "ДП":
                    this.Vent_sys_type = "ДП";
                    break;
                case "ДВ":
                    this.Vent_sys_type = "ДВ";
                    break;
                case "У":
                    this.Vent_sys_type = "У";
                    break;
                case "ПЕ":
                    this.Vent_sys_type = "ПЕ";
                    break;
                case "ВЕ":
                    this.Vent_sys_type = "ВЕ";
                    break;
                default:
                    this.Vent_sys_type = "В";
                    break;
            }

            Name_of_sys = vent_sys_type + number_of_sys;

            switch (vent_sys_type)
            {
                case "П":
                    Stream_type = "приточная";
                    break;
                case "В":
                    Stream_type = "вытяжная";
                    break;
                case "ДП":
                    Stream_type = "приточная";
                    break;
                case "ДВ":
                    Stream_type = "вытяжная";
                    break;
                case "У":
                    Stream_type = "приточная";
                    break;
                case "ПЕ":
                    Stream_type = "приточная";
                    break;
                case "ВЕ":
                    Stream_type = "вытяжная";
                    break;
                default:
                    Stream_type = "вытяжная";
                    break;
            }

            Napor_ventiliatora_m3_in_hour = 0;

            Spisok_uchastkov = new List<Uchastok>();
        }

        public Ventilation_system(string vent_sys_type, string number_of_sys, double napor_ventiliatora)
        {
            switch (vent_sys_type)
            {
                case "П":
                    this.Vent_sys_type = "П";
                    break;
                case "В":
                    this.Vent_sys_type = "В";
                    break;
                case "ДП":
                    this.Vent_sys_type = "ДП";
                    break;
                case "ДВ":
                    this.Vent_sys_type = "ДВ";
                    break;
                case "У":
                    this.Vent_sys_type = "У";
                    break;
                case "ПЕ":
                    this.Vent_sys_type = "ПЕ";
                    break;
                case "ВЕ":
                    this.Vent_sys_type = "ВЕ";
                    break;
                default:
                    this.Vent_sys_type = "В";
                    break;
            }

            Name_of_sys = vent_sys_type + number_of_sys;

            switch (vent_sys_type)
            {
                case "П":
                    Stream_type = "приточная";
                    break;
                case "В":
                    Stream_type = "вытяжная";
                    break;
                case "ДП":
                    Stream_type = "приточная";
                    break;
                case "ДВ":
                    Stream_type = "вытяжная";
                    break;
                case "У":
                    Stream_type = "приточная";
                    break;
                case "ПЕ":
                    Stream_type = "приточная";
                    break;
                case "ВЕ":
                    Stream_type = "вытяжная";
                    break;
                default:
                    Stream_type = "вытяжная";
                    break;
            }

            Napor_ventiliatora_m3_in_hour = napor_ventiliatora;

            Spisok_uchastkov = new List<Uchastok>();
        }

        public double Poteri_davlenia_v_sisteme_polnie
        {
            get
            {
                double poteri_rez = 0;

                foreach (Uchastok uch in this.Spisok_uchastkov)
                {
                    poteri_rez += uch.Poteri_davlenia_polnie_Pa;
                }

                return poteri_rez;
            }
        }
        public void Add_Circle_Uchastok(double rashod_m3_in_hour, double length_m, double diameter_mm, string material)
        {
            int n = Spisok_uchastkov.Count + 1;

            Uchastok uch = new Uchastok(this.Stream_type, n, rashod_m3_in_hour, length_m, diameter_mm, material);
            uch._stream_type = this.Stream_type;

            Spisok_uchastkov.Add(uch);
        }

        public void Add_Rectangle_Uchastok(double rashod_m3_in_hour, double length_m, double width_mm, double height_mm, string material)
        {
            int n = Spisok_uchastkov.Count + 1;

            Uchastok uch = new Uchastok(this.Stream_type, n, rashod_m3_in_hour, length_m, width_mm, height_mm, material);
            uch._stream_type = this.Stream_type;

            Spisok_uchastkov.Add(uch);
        }

        public void Insert_Circle_Uchastok_After(int number_uchastka, double rashod_m3_in_hour, double length_m, double diameter_mm, string material)
        {
            if ( (number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count) )
            {
                Uchastok uch = new Uchastok(this.Stream_type, (number_uchastka + 1), rashod_m3_in_hour, length_m, diameter_mm, material);
                uch._stream_type = this.Stream_type;

                Spisok_uchastkov.Insert(number_uchastka, uch);

                int i = 0;

                foreach (Uchastok u in Spisok_uchastkov)
                {
                    u.Number = (i + 1);

                    i++;
                }
            }
        }

        public void Insert_Rectangle_Uchastok_After(int number_uchastka, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm, string material)
        {
            if ( (number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count) )
            {
                Uchastok uch = new Uchastok(this.Stream_type, (number_uchastka + 1), rashod_m3_in_hour, length_m, width_mm, height_mm, material);
                uch._stream_type = this.Stream_type;

                Spisok_uchastkov.Insert(number_uchastka, uch);

                int i = 0;

                foreach (Uchastok u in Spisok_uchastkov)
                {
                    u.Number = (i + 1);

                    i++;
                }
            }
        }

        public void Insert_Circle_Uchastok_Before(int number_uchastka, double rashod_m3_in_hour, double length_m, double diameter_mm, string material)
        {
            if ( (number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count) )
            {
                Uchastok uch = new Uchastok(this.Stream_type, (number_uchastka - 1), rashod_m3_in_hour, length_m, diameter_mm, material);
                uch._stream_type = this.Stream_type;

                Spisok_uchastkov.Insert( (number_uchastka - 1), uch);

                int i = 0;

                foreach (Uchastok u in Spisok_uchastkov)
                {
                    u.Number = (i + 1);

                    i++;
                }
            }
        }

        public void Insert_Rectangle_Uchastok_Before(int number_uchastka, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm, string material)
        {
            if ((number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count))
            {
                Uchastok uch = new Uchastok(this.Stream_type, (number_uchastka - 1), rashod_m3_in_hour, length_m, width_mm, height_mm, material);
                uch._stream_type = this.Stream_type;

                Spisok_uchastkov.Insert((number_uchastka - 1), uch);

                int i = 0;

                foreach (Uchastok u in Spisok_uchastkov)
                {
                    u.Number = (i + 1);

                    i++;
                }
            }
        }

        public void Remove_Uchastok(int number_uchastka)
        {
            if ((number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count))
            {
                Spisok_uchastkov.RemoveAt(number_uchastka - 1);

                int i = 0;

                foreach (Uchastok u in Spisok_uchastkov)
                {
                    u.Number = (i + 1);

                    i++;
                }
            }
        }

        public void Change_Uchastok_by_Circle(int number_uchastka, double rashod_m3_in_hour, double length_m, double diameter_mm, string material)
        {
            if ((number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count))
            {
                Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).ChangeUchastok_as_cirlce(this.Stream_type, number_uchastka, rashod_m3_in_hour, length_m, diameter_mm);

                Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).SetMaterial(material);

                Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Refresh_Spisok_soprotivleniy();
            }
        }

        public void Change_Uchastok_by_Rectangle(int number_uchastka, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm, string material)
        {
            if ((number_uchastka > 0) && (number_uchastka <= Spisok_uchastkov.Count))
            {
                Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).ChangeUchastok_as_rectangle(this.Stream_type, number_uchastka, rashod_m3_in_hour, length_m, width_mm, height_mm);

                Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).SetMaterial(material);

                Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Refresh_Spisok_soprotivleniy();
            }
        }

        public bool Check_Uchastok_Exist_By_Number(int number_uchastok)
        {
            foreach(Uchastok u in this.Spisok_uchastkov)
            {
                if (u.Number == number_uchastok) return true;
            }

            return false;
        }

        public Uchastok Get_Uchastok_By_Number(int uch_num)
        {
            foreach (Uchastok u in this.Spisok_uchastkov)
            {
                if (u.Number == uch_num)
                {
                    return u;
                }
            }
            
            return null;
        }

        public void Clear_spisok_uchastkov()
        {
            Spisok_uchastkov.Clear();
        }

        public void ReNumber_sytem(string number_of_s)
        {
            Name_of_sys = Vent_sys_type + number_of_s;
        }

        public void Add_Vozdushnaia_zaslonka(int number_uchatka, bool Rotated_Or_Not, string marka_before)
        {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchatka - 1).Add_Vozdushnaia_zaslonka(Rotated_Or_Not, marka_before);
        }
        public void Add_Vozdushnaia_zaslonka(int number_uchatka, bool Rotated_Or_Not, string marka_before, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchatka - 1).Add_Vozdushnaia_zaslonka(Rotated_Or_Not, marka_before);
            }
        }

        public void Add_Vozdushnaia_zaslonka_s_electroprivodom(int number_uchatka, bool Rotated_Or_Not, string marka_before)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchatka - 1).Add_Vozdushnaia_zaslonka_s_elktroprivodom(Rotated_Or_Not, marka_before);
        }
        public void Add_Vozdushnaia_zaslonka_s_electroprivodom(int number_uchatka, bool Rotated_Or_Not, string marka_before, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchatka - 1).Add_Vozdushnaia_zaslonka_s_elktroprivodom(Rotated_Or_Not, marka_before);
            }
        }

        public void Add_Protivopojarniy_klapan(int number_uchastka, bool Rotated_Or_Not, string marka_before_sechenie, string marka_after_sechenie)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Protivopojarniy_klapan(marka_before_sechenie, marka_after_sechenie, Rotated_Or_Not);
        }
        public void Add_Protivopojarniy_klapan(int number_uchastka, bool Rotated_Or_Not, string marka_before_sechenie, string marka_after_sechenie, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Protivopojarniy_klapan(marka_before_sechenie, marka_after_sechenie, Rotated_Or_Not);
            }
        }

        public void Add_Klapan_protivopojarniy_dimoudalenia(int number_uchastka, bool Rotated_Or_Not)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Klapan_protivopojarniy_dimoudalenia(Rotated_Or_Not);
        }
        public void Add_Klapan_protivopojarniy_dimoudalenia(int number_uchastka, bool Rotated_Or_Not, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Klapan_protivopojarniy_dimoudalenia(Rotated_Or_Not);
            }
        }

        public void Add_Germoklapan(int number_uchastka, string tip_klapana, bool korrozionnostoykiy_or_not)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Germoklapan(tip_klapana, korrozionnostoykiy_or_not);
        }
        public void Add_Germoklapan(int number_uchastka, string tip_klapana, bool korrozionnostoykiy_or_not, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Germoklapan(tip_klapana, korrozionnostoykiy_or_not);
            }
        }

        public void Add_Dimovoy_klapan(int number_uchastka, bool kanalniy_true_stenovoy_false, bool rotated_or_not)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Dimovoy_klapan(kanalniy_true_stenovoy_false, rotated_or_not);
        }
        public void Add_Dimovoy_klapan(int number_uchastka, bool kanalniy_true_stenovoy_false, bool rotated_or_not, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Dimovoy_klapan(kanalniy_true_stenovoy_false, rotated_or_not);
            }
        }

        public void Add_Klapan_izbitochnogo_davlenia(int number_uchastka, bool rotated_or_not)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Klapan_izbitochnogo_davlenia(rotated_or_not);
        }
        public void Add_Klapan_izbitochnogo_davlenia(int number_uchastka, bool rotated_or_not, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Klapan_izbitochnogo_davlenia(rotated_or_not);
            }
        }

        public void Add_Obratniy_klapan(int number_uchastka, int polojenie_1_gor_2_ver, bool rotated_or_not)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Obratniy_klapan(polojenie_1_gor_2_ver, rotated_or_not);
        }
        public void Add_Obratniy_klapan(int number_uchastka, int polojenie_1_gor_2_ver, bool rotated_or_not, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Obratniy_klapan(polojenie_1_gor_2_ver, rotated_or_not);
            }
        }

        public void Add_Obratniy_klapan_s_elektroprivodom(int number_uchastka, bool rotated_or_not)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Obratniy_klapan_s_elektroprivodom(rotated_or_not);
        }
        public void Add_Obratniy_klapan_s_elektroprivodom(int number_uchastka, bool rotated_or_not, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Obratniy_klapan_s_elektroprivodom(rotated_or_not);
            }
        }

        public void Add_ElektroNagrevatel(int number_uchastka, double nominalnaia_moshnost_kvt)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_ElektroNagrevatel(nominalnaia_moshnost_kvt);
        }
        public void Add_ElektroNagrevatel(int number_uchastka, double nominalnaia_moshnost_kvt, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_ElektroNagrevatel(nominalnaia_moshnost_kvt);
            }
        }

        public void Add_Freonoviy_ohladitel(int number_uchastka)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Freonoviy_ohladitel();
        }
        public void Add_Freonoviy_ohladitel(int number_uchastka, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Freonoviy_ohladitel();
            }
        }

        public void Add_Filtr(int number_uchastka, string proizvoditel_oborudovania, string klass_vozdushnogo_filtra)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Filtr(proizvoditel_oborudovania, klass_vozdushnogo_filtra);
        }
        public void Add_Filtr(int number_uchastka, string proizvoditel_oborudovania, string klass_vozdushnogo_filtra, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Filtr(proizvoditel_oborudovania, klass_vozdushnogo_filtra);
            }
        }

        public void Add_Shumoglushitel(int number_uchastka, string proizvoditel_oborudovania, double dlina)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Shumoglushitel(proizvoditel_oborudovania, dlina);
        }
        public void Add_Shumoglushitel(int number_uchastka, string proizvoditel_oborudovania, double dlina, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Shumoglushitel(proizvoditel_oborudovania, dlina);
            }
        }

        public void Add_Gibkaia_vstavka(int number_uchastka, string proizvoditel_oborudovania)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Gibkaia_vstavka(proizvoditel_oborudovania);
        }
        public void Add_Gibkaia_vstavka(int number_uchastka, string proizvoditel_oborudovania, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Gibkaia_vstavka(proizvoditel_oborudovania);
            }
        }

        public void Add_Otvod(int number_uchastka, double ugol_povorota, bool povorot_vdol_visoti_false_vdol_shirini_true)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Otvod(ugol_povorota, povorot_vdol_visoti_false_vdol_shirini_true);
        }
        public void Add_Otvod(int number_uchastka, double ugol_povorota, bool povorot_vdol_visoti_false_vdol_shirini_true, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Otvod(ugol_povorota, povorot_vdol_visoti_false_vdol_shirini_true);
            }
        }

        public void Add_Otvod_s_ostrimi_kromkami(int number_uchastka, double ugol_povorota, bool povorot_vdol_visoti_false_vdol_shirini_true)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Otvod_s_ostrimi_kromkami(ugol_povorota, povorot_vdol_visoti_false_vdol_shirini_true);
        }
        public void Add_Otvod_s_ostrimi_kromkami(int number_uchastka, double ugol_povorota, bool povorot_vdol_visoti_false_vdol_shirini_true, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Otvod_s_ostrimi_kromkami(ugol_povorota, povorot_vdol_visoti_false_vdol_shirini_true);
            }
        }

        public void Add_Perehod_To_End_Of_Stream(int number_uchastka, double uchastok_2_width, double uchastok_2_height, double dlina)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Perehod(true, uchastok_2_width, uchastok_2_height, dlina);
        }
        public void Add_Perehod_To_End_Of_Stream(int number_uchastka, double uchastok_2_diameter, double dlina)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Perehod(true, uchastok_2_diameter, dlina);
        }
        public void Add_Perehod_To_Begin_Of_Stream(int number_uchastka, double uchastok_2_width, double uchastok_2_height, double dlina)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Perehod(false, uchastok_2_width, uchastok_2_height, dlina);
        }
        public void Add_Perehod_To_Begin_Of_Stream(int number_uchastka, double uchastok_2_diameter, double dlina)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Perehod(false, uchastok_2_diameter, dlina);
        }

        public void Add_Perehod_Between(int number_uchastok_1, int number_uchastok_2, double dlina)
        {
            if ((number_uchastok_1 > 0) && ((number_uchastok_2 - number_uchastok_1) == 1))
            {
                if (Check_Uchastok_Exist_By_Number(number_uchastok_1) && Check_Uchastok_Exist_By_Number(number_uchastok_2))
                {
                    Uchastok uchast_1 = Get_Uchastok_By_Number(number_uchastok_1);
                    Uchastok uchast_2 = Get_Uchastok_By_Number(number_uchastok_2);

                    if (Stream_type == "вытяжная")
                    {
                        if(uchast_1.Real_Square <= uchast_2.Real_Square)
                        {
                            if (uchast_2.Forma_sechenia == "rectangle")
                            {
                                this.Add_Perehod_To_End_Of_Stream(number_uchastok_1, uchast_2.Width_mm, uchast_2.Height_mm, dlina);
                            }
                            else
                            {
                                this.Add_Perehod_To_End_Of_Stream(number_uchastok_1, uchast_2.Diameter_mm, dlina);
                            }
                        }
                        else
                        {
                            if (uchast_1.Forma_sechenia == "rectangle")
                            {
                                this.Add_Perehod_To_Begin_Of_Stream(number_uchastok_2, uchast_1.Width_mm, uchast_1.Height_mm, dlina);
                            }
                            else
                            {
                                this.Add_Perehod_To_Begin_Of_Stream(number_uchastok_2, uchast_1.Diameter_mm, dlina);
                            }
                        }
                    }
                    else
                    {
                        if (uchast_1.Real_Square <= uchast_2.Real_Square)
                        {
                            if (uchast_2.Forma_sechenia == "rectangle")
                            {
                                this.Add_Perehod_To_Begin_Of_Stream(number_uchastok_1, uchast_2.Width_mm, uchast_2.Height_mm, dlina);
                            }
                            else
                            {
                                this.Add_Perehod_To_Begin_Of_Stream(number_uchastok_1, uchast_2.Diameter_mm, dlina);
                            }
                        }
                        else
                        {
                            if (uchast_1.Forma_sechenia == "rectangle")
                            {
                                this.Add_Perehod_To_End_Of_Stream(number_uchastok_2, uchast_1.Width_mm, uchast_1.Height_mm, dlina);
                            }
                            else
                            {
                                this.Add_Perehod_To_End_Of_Stream(number_uchastok_2, uchast_1.Diameter_mm, dlina);
                            }
                        }
                    }
                }
            }
        }

        public void Add_Troynik(int number_uchastka, string type_of_troynik, double uchastok_other_width, double uchastok_other_height, double uchastok_other_diameter)
        {
            if ((this.Spisok_uchastkov.Count > 1) && (this.Spisok_uchastkov.Count >= number_uchastka))
            {
                int first_number;
                int second_number;

                if (number_uchastka <= 1)
                {
                    first_number = 1;
                    second_number = (first_number + 1);
                }
                else if (number_uchastka == this.Spisok_uchastkov.Count)
                {
                    first_number = number_uchastka;
                    second_number = (first_number - 1);
                }
                else
                {
                    double L_1 = this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Rashod_m3_in_hour;
                    double L_2 = this.Spisok_uchastkov.ElementAt<Uchastok>((number_uchastka - 1) + 1).Rashod_m3_in_hour;

                    if (L_1 <= L_2)
                    {
                        first_number = number_uchastka;
                        second_number = (first_number + 1);
                    }
                    else
                    {
                        first_number = number_uchastka;
                        second_number = (first_number - 1);
                    }
                }

                Uchastok u2 = this.Spisok_uchastkov.ElementAt<Uchastok>(second_number - 1);

                if ((uchastok_other_width > 0) && (uchastok_other_height > 0))
                {
                    this.Spisok_uchastkov.ElementAt<Uchastok>(first_number - 1).Add_Troynik_Rectangle(false, type_of_troynik, u2.Width_mm, u2.Height_mm, u2.Rashod_m3_in_hour,
                    uchastok_other_width, uchastok_other_height, 0);
                }
                else
                {
                    this.Spisok_uchastkov.ElementAt<Uchastok>(first_number - 1).Add_Troynik_Rectangle(true, type_of_troynik, u2.Width_mm, u2.Height_mm, u2.Rashod_m3_in_hour,
                    0, 0, uchastok_other_diameter);
                }
            }
        }

        public void Add_Troynik_Between(int number_uchastka_1, int number_uchastka_2, string type_of_troynik, double uchastok_other_width, double uchastok_other_height, double uchastok_other_diameter)
        {
            if ((this.Spisok_uchastkov.Count > 1) && (this.Spisok_uchastkov.Count >= number_uchastka_1)  && (this.Spisok_uchastkov.Count >= number_uchastka_2)
                && (number_uchastka_1 > 0) && (number_uchastka_2 > 0) && (Math.Abs(number_uchastka_2 - number_uchastka_1) == 1))
            {
                Uchastok u1 = this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka_1 - 1);
                Uchastok u2 = this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka_2 - 1);

                double uch1_rashod = u1.Rashod_m3_in_hour;
                double uch2_rashod = u2.Rashod_m3_in_hour;

                int number_first;
                double width_second;
                double height_second;
                double diameter_second;
                double rashod_second;
                bool rectangle_or_not;

                if (uch1_rashod <= uch2_rashod)
                {
                    number_first = number_uchastka_1;
                    width_second = u2.Width_mm;
                    height_second = u2.Height_mm;
                    diameter_second = u2.Diameter_mm;
                    rashod_second = u2.Rashod_m3_in_hour;

                    if (u2.Width_mm > 0 && u2.Height_mm > 0) rectangle_or_not = true;
                    else rectangle_or_not = false;
                }
                else
                {
                    number_first = number_uchastka_2;
                    width_second = u1.Width_mm;
                    height_second = u1.Height_mm;
                    diameter_second = u1.Diameter_mm;
                    rashod_second = u1.Rashod_m3_in_hour;
                    if (u1.Width_mm > 0 && u1.Height_mm > 0) rectangle_or_not = true;
                    else rectangle_or_not = false;
                }

                if (rectangle_or_not)
                {
                    if ((uchastok_other_width > 0) && (uchastok_other_height > 0))
                    {
                        this.Spisok_uchastkov.ElementAt<Uchastok>(number_first - 1).Add_Troynik_Rectangle(false, type_of_troynik, width_second, height_second, rashod_second, uchastok_other_width, uchastok_other_height, 0);
                    }
                    else
                    {
                        this.Spisok_uchastkov.ElementAt<Uchastok>(number_first - 1).Add_Troynik_Rectangle(true, type_of_troynik, width_second, height_second, rashod_second, 0, 0, uchastok_other_diameter);
                    }
                }
                else
                {
                    if ((uchastok_other_width > 0) && (uchastok_other_height > 0))
                    {
                        this.Spisok_uchastkov.ElementAt<Uchastok>(number_first - 1).Add_Troynik_Circle(false, type_of_troynik, diameter_second, rashod_second, uchastok_other_width, uchastok_other_height, 0);
                    }
                    else
                    {
                        this.Spisok_uchastkov.ElementAt<Uchastok>(number_first - 1).Add_Troynik_Circle(true, type_of_troynik, diameter_second, rashod_second, 0, 0, uchastok_other_diameter);
                    }
                }
            }
        }

        public void Add_Reshetka(int number_uchastka)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Reshetka();
        }
        public void Add_Reshetka(int number_uchastka, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Reshetka();
            }
        }

        public void Add_Setka(int number_uchastka)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Setka();
        }
        public void Add_Setka(int number_uchastka, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Setka();
            }
        }

        public void Add_Diffuzor(int number_uchastka)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Diffuzor();
        }
        public void Add_Diffuzor(int number_uchastka, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Diffuzor();
            }
        }

        public void Add_Diffuzor_stat_kamera(int number_uchastka)
        {
            this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Diffuzor_stat_kamera();
        }

        public void Add_Diffuzor_stat_kamera(int number_uchastka, int kolichestvo)
        {
            for (int i = 0; i < kolichestvo; i++)
            {
                this.Spisok_uchastkov.ElementAt<Uchastok>(number_uchastka - 1).Add_Diffuzor_stat_kamera();
            }
        }

        public List<string> get_Uchastki_List_String()
        {
            List<string> list_str_rez = new List<string>();

            string n_str;

            foreach (Uchastok u in Spisok_uchastkov)
            {
                if (u.Forma_sechenia == "rectangle")
                {
                    n_str = u.Number.ToString() + ":   L = " + u.Rashod_m3_in_hour.ToString() + "; Дл = " + u.Length_m.ToString() + "; A = " + u.Width_mm.ToString() +
                        "; B = " + u.Height_mm.ToString() + "; dэкв = " + Math.Round(u.Diameter_mm, 2).ToString() + "; t = " + u.t.ToString() + " °C; " + u.Material + "; 𝓋экв = " + Math.Round(u.v, 2).ToString() + " м/с";
                }
                else
                {
                    n_str = u.Number.ToString() + ":   L = " + u.Rashod_m3_in_hour.ToString() + "; Дл = " + u.Length_m.ToString() + "; d = " + u.Diameter_mm.ToString() +
                        "; t = " + u.t.ToString() + " °C; " + u.Material + "; 𝓋 = " + Math.Round(u.v, 2).ToString() + " м/с";
                }

                list_str_rez.Add(n_str);
            }

            return list_str_rez;
        }
    }
}
