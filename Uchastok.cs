using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    public class Uchastok
    {
        public int Number { get; set; }
        public string Forma_sechenia { get; private set; }
        public double Diameter_mm { get; private set; }
        public double Width_mm { get; private set; }
        public double Height_mm { get; private set; }
        public double Length_m { get; private set; }
        public double Rashod_m3_in_hour { get; private set; }
        public string Material { get; private set; }
        public double K_ekv { get; private set; }

        public string _stream_type = "вытяжная";

        public double Real_Square
        {
            get
            {
                if (Width_mm > 0 && Height_mm > 0)
                {
                    return (Width_mm * Height_mm);
                }
                else
                {
                    return ((Math.PI * Math.Pow(Diameter_mm, 2.0)) / 4.0);
                }
            }
        }

        private Mestnoe_soprotivlenie _connector_before = null;

        private Mestnoe_soprotivlenie _connector_after = null;

        public Mestnoe_soprotivlenie Connector_before
        {
            get
            {
                return _connector_before;
            }
            set
            {
                if (value is Perehod) _connector_before = value;
                else if (value is Vnezapniy_perehod) _connector_before = value;
                else if (value is Troynik) _connector_before = value;
                else _connector_before = null;
            }
        }

        public Mestnoe_soprotivlenie Connector_after
        {
            get
            {
                return _connector_after;
            }
            set
            {
                if (value is Perehod) _connector_after = value;
                else if (value is Vnezapniy_perehod) _connector_after = value;
                else if (value is Troynik) _connector_after = value;
                else _connector_after = null;
            }
        }

        public List<Mestnoe_soprotivlenie> Spisok_soprotivleniy { get; private set; }

        // Площадь по эквивалентному диаметру в м2:
        public double f
        {
            get
            {
                //System.Windows.Forms.MessageBox.Show(Diameter_mm.ToString());
                return (Math.PI * Math.Pow((Diameter_mm / 1000), 2) / 4);
            }
        }

        // Скорость по эквивалентному диаметру в м/с:
        public double v
        {
            get
            {
                //System.Windows.Forms.MessageBox.Show(f.ToString() + "   " + Rashod_m3_in_hour.ToString());
                return ((Rashod_m3_in_hour / 3600) / f);
            }
        }

        private double t_start;
        public double t
        {
            get
            {
                return t_start;
            }
            set
            {
                t_start = (value >= -273.15) ? value : -273.15;
            }
        }

        public double _T
        {
            get { return (t + 273.15); }
        }
        public decimal viazkost_din
        {
            get { return ((decimal)18.27 / (decimal)1000000) * (((decimal)291.15 + (decimal)120) / ((decimal)_T + (decimal)120)) * (decimal)Math.Pow((_T / 291.15), (3 / 2)); }
        }

        // Плотность воздуха в кг/м3 при температуре 16 оС;
        public double plotnost
        {
            get
            {
                return (double)((decimal)99500 * ((decimal)29 / (decimal)1000) / ((decimal)8.314463 * (decimal)_T));
            }
        }
        public decimal viazkost_kin
        {
            get { return (viazkost_din / (decimal)plotnost); }
        }

        public double Re
        {
            get
            {
                //System.Windows.Forms.MessageBox.Show(v.ToString());
                decimal v_dec = (decimal)v;
                decimal d_dec = (decimal)(Diameter_mm / (double)1000);

                decimal Re_dec = (v_dec * d_dec) / viazkost_kin;

                return (double)Re_dec;
            }
        }

        public double Liambda
        {
            get
            {
                if (Diameter_mm <= 0) return 0;
                else
                {
                    if ((Re > 0) && (Re <= 2320)) return 64 / Re;
                    else if ((Re > 2320) && (Re <= (20 * Diameter_mm / K_ekv))) return 0.3164 / Math.Pow(Re, 0.25);
                    else if ((Re > (20 * Diameter_mm / K_ekv)) && (Re <= (500 * Diameter_mm / K_ekv))) return 0.11 * Math.Pow(((K_ekv / Diameter_mm) + (68 / Re)), 0.25);
                    else return 0.11 * Math.Pow((K_ekv / Diameter_mm), 0.25);
                }
            }

        }

        public double Poteri_davlenia_po_dline_Pa
        {
            get
            {
                if ((Diameter_mm / 1000) > 0) return Liambda * (Length_m / (Diameter_mm / 1000)) * plotnost * (Math.Pow(v, 2)) / 2;
                else return 0;
            }

        }

        public double Poteri_davlenia_na_mestnie_soprotivlenia_Pa
        {
            get
            {
                if (Spisok_soprotivleniy.Count > 0)
                {
                    double p_rez = 0;
                    double p_mest_s;
                    foreach (Mestnoe_soprotivlenie mest_s in Spisok_soprotivleniy)
                    {
                        p_mest_s = (double)mest_s.KMS * (double)plotnost * Math.Pow((double)v, (double)2) / (double)2;
                        p_rez = p_rez + p_mest_s;
                    }
                    return p_rez;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double Poteri_davlenia_polnie_Pa
        {
            get
            {
                return (Poteri_davlenia_po_dline_Pa + Poteri_davlenia_na_mestnie_soprotivlenia_Pa);
            }
        }

        public double Sum_of_kms
        {
            get
            {
                double sum_kms_rez = 0;

                foreach (Mestnoe_soprotivlenie msop in this.Spisok_soprotivleniy)
                {
                    sum_kms_rez += msop.KMS;
                }

                return sum_kms_rez;
            }
        }
        public void SetMaterial(string material)
        {
            switch (material)
            {
                case "листовая сталь":
                    this.Material = material;
                    K_ekv = 0.1;
                    break;
                case "винипласт":
                    this.Material = material;
                    K_ekv = 0.1;
                    break;
                case "асбест":
                    this.Material = material;
                    K_ekv = 0.11;
                    break;
                case "фанера":
                    this.Material = material;
                    K_ekv = 0.12;
                    break;
                case "шлакоалебастровые плиты":
                    this.Material = material;
                    K_ekv = 1;
                    break;
                case "кирпич":
                    this.Material = material;
                    K_ekv = 4;
                    break;
                case "штукатурка":
                    this.Material = material;
                    K_ekv = 10;
                    break;
                case "бетон":
                    this.Material = material;
                    K_ekv = 5.5;
                    break;
                default:
                    this.Material = "листовая сталь";
                    K_ekv = 0.1;
                    break;
            }
        }

        public Uchastok(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double diameter_mm)
        {
            Forma_sechenia = "circle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Diameter_mm = diameter_mm;
            this.Length_m = length_m;

            Width_mm = 0;
            Height_mm = 0;

            SetMaterial("листовая сталь");

            t = 16;

            Spisok_soprotivleniy = new List<Mestnoe_soprotivlenie>();
        }
        public Uchastok(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double diameter_mm, string material)
        {
            Forma_sechenia = "circle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Diameter_mm = diameter_mm;
            this.Length_m = length_m;

            Width_mm = 0;
            Height_mm = 0;

            SetMaterial(material);

            t = 16;

            Spisok_soprotivleniy = new List<Mestnoe_soprotivlenie>();
        }

        public Uchastok(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm)
        {
            Forma_sechenia = "rectangle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Width_mm = width_mm;
            this.Height_mm = height_mm;
            this.Length_m = length_m;

            Diameter_mm = (2 * width_mm * height_mm) / (width_mm + height_mm);

            SetMaterial("листовая сталь");

            t = 16;

            Spisok_soprotivleniy = new List<Mestnoe_soprotivlenie>();
        }

        public Uchastok(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm, string material)
        {
            Forma_sechenia = "rectangle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Width_mm = width_mm;
            this.Height_mm = height_mm;
            this.Length_m = length_m;

            Diameter_mm = (2 * width_mm * height_mm) / (width_mm + height_mm);

            SetMaterial(material);

            t = 16;

            Spisok_soprotivleniy = new List<Mestnoe_soprotivlenie>();
        }

        public void Refresh_Spisok_soprotivleniy()
        {
            if (!(Spisok_soprotivleniy is null))
            {
                if (Spisok_soprotivleniy.Count > 0)
                {
                    List<Mestnoe_soprotivlenie> Spisok_soprotivleniy_2 = new List<Mestnoe_soprotivlenie>();
                    foreach (Mestnoe_soprotivlenie mo in Spisok_soprotivleniy)
                    {
                        Vozdushnaia_zaslonka vs = null;
                        Protivopojarniy_klapan pk = null;
                        Germoklapan gk = null;
                        Dimovoy_klapan dk = null;
                        Klapan_izbitochnogo_davlenia kid = null;
                        Obratniy_klapan ok = null;
                        Obratniy_klapan_s_elektroprivodom ok_ep = null;
                        ElektroNagrevatel en = null;
                        Freonoviy_ohladitel fo = null;
                        Filtr fi = null;
                        Shumoglushitel sg = null;
                        Gibkaia_vstavka gv = null;
                        Otvod otv = null;
                        Perehod per = null;
                        Vnezapniy_perehod vnezper = null;
                        Troynik troyn = null;
                        Otvod_s_ostrimi_kromkami otv_ostr = null;
                        Reshetka resh = null;
                        Setka setk = null;
                        Diffuzor dif = null;
                        Diffuzor_stat_kamera dif_st_k = null;
                        if (mo is Vozdushnaia_zaslonka)
                        {
                            vs = mo as Vozdushnaia_zaslonka;
                            vs.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = vs;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Protivopojarniy_klapan)
                        {
                            pk = mo as Protivopojarniy_klapan;
                            pk.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = pk;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Germoklapan)
                        {
                            gk = mo as Germoklapan;
                            gk.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = gk;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Dimovoy_klapan)
                        {
                            dk = mo as Dimovoy_klapan;
                            dk.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = dk;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Klapan_izbitochnogo_davlenia)
                        {
                            kid = mo as Klapan_izbitochnogo_davlenia;
                            kid.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = kid;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Obratniy_klapan)
                        {
                            ok = mo as Obratniy_klapan;
                            ok.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = ok;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Obratniy_klapan_s_elektroprivodom)
                        {
                            ok_ep = mo as Obratniy_klapan_s_elektroprivodom;
                            ok_ep.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = ok_ep;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is ElektroNagrevatel)
                        {
                            en = mo as ElektroNagrevatel;
                            en.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = en;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Freonoviy_ohladitel)
                        {
                            fo = mo as Freonoviy_ohladitel;
                            fo.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = fo;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Filtr)
                        {
                            fi = mo as Filtr;
                            fi.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = fi;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Shumoglushitel)
                        {
                            sg = mo as Shumoglushitel;
                            sg.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = sg;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Gibkaia_vstavka)
                        {
                            gv = mo as Gibkaia_vstavka;
                            gv.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = gv;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Otvod)
                        {
                            otv = mo as Otvod;
                            otv.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = otv;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Otvod_s_ostrimi_kromkami)
                        {
                            otv_ostr = mo as Otvod_s_ostrimi_kromkami;
                            otv_ostr.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = otv_ostr;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Perehod)
                        {
                            per = mo as Perehod;
                            per.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = per;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Vnezapniy_perehod)
                        {
                            vnezper = mo as Vnezapniy_perehod;
                            vnezper.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = vnezper;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Troynik)
                        {
                            troyn = mo as Troynik;
                            troyn.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = troyn;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Reshetka)
                        {
                            resh = mo as Reshetka;
                            resh.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = resh;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Setka)
                        {
                            setk = mo as Setka;
                            setk.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = setk;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Diffuzor)
                        {
                            dif = mo as Diffuzor;
                            dif.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = dif;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else if (mo is Diffuzor_stat_kamera)
                        {
                            dif_st_k = mo as Diffuzor_stat_kamera;
                            dif_st_k.ChangeParametersByUchastok(this);
                            Mestnoe_soprotivlenie mo2 = dif;
                            Spisok_soprotivleniy_2.Add(mo2);
                        }
                        else
                        {
                            Spisok_soprotivleniy_2.Add(mo);
                        }
                    }
                    Spisok_soprotivleniy = Spisok_soprotivleniy_2;
                }
            }
        }
        public void ChangeUchastok_as_cirlce(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double diameter_mm)
        {
            Forma_sechenia = "circle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Diameter_mm = diameter_mm;
            this.Length_m = length_m;

            Width_mm = 0;
            Height_mm = 0;

            SetMaterial("листовая сталь");

            Refresh_Spisok_soprotivleniy();
        }

        public void ChangeUchastok_as_cirlce(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double diameter_mm, string material)
        {
            Forma_sechenia = "circle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Diameter_mm = diameter_mm;
            this.Length_m = length_m;

            Width_mm = 0;
            Height_mm = 0;

            SetMaterial(material);

            Refresh_Spisok_soprotivleniy();
        }

        public void ChangeUchastok_as_rectangle(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm)
        {
            Forma_sechenia = "rectangle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Width_mm = width_mm;
            this.Height_mm = height_mm;
            this.Length_m = length_m;

            Diameter_mm = ((double)2) * Width_mm * Height_mm / (Width_mm + Height_mm);

            SetMaterial("листовая сталь");

            Refresh_Spisok_soprotivleniy();
        }

        public void ChangeUchastok_as_rectangle(string type_of_stream, int number, double rashod_m3_in_hour, double length_m, double width_mm, double height_mm, string material)
        {
            Forma_sechenia = "rectangle";

            this._stream_type = type_of_stream;
            this.Number = number;
            this.Rashod_m3_in_hour = rashod_m3_in_hour;
            this.Width_mm = width_mm;
            this.Height_mm = height_mm;
            this.Length_m = length_m;

            Diameter_mm = ((double)2) * Width_mm * Height_mm / (Width_mm + Height_mm);

            SetMaterial(material);

            Refresh_Spisok_soprotivleniy();
        }

        public void Add_Vozdushnaia_zaslonka(bool rotated_or_not, string marka_before)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Vozdushnaia_zaslonka n_vs = null;

            if (this.Forma_sechenia == "rectangle")
            {
                n_vs = new Vozdushnaia_zaslonka(marka_before, rashod, a, b, rotated_or_not);
            }
            else
            {
                n_vs = new Vozdushnaia_zaslonka(marka_before, rashod, d);
            }

            Mestnoe_soprotivlenie mest_s = n_vs;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Vozdushnaia_zaslonka_s_elktroprivodom(bool rotated_or_not, string marka_before)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Vozdushnaia_zaslonka n_vs = null;

            if (this.Forma_sechenia == "rectangle")
            {
                n_vs = new Vozdushnaia_zaslonka(marka_before, rashod, a, b, rotated_or_not, true);
            }
            else
            {
                n_vs = new Vozdushnaia_zaslonka(marka_before, rashod, d, true);
            }

            Mestnoe_soprotivlenie mest_s = n_vs;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Protivopojarniy_klapan(string marka_before, string marka_after, bool rotated_or_not)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Protivopojarniy_klapan n_pk = null;

            if (this.Forma_sechenia == "rectangle") n_pk = new Protivopojarniy_klapan(marka_before, marka_after, rashod, a, b, rotated_or_not);
            else n_pk = new Protivopojarniy_klapan(marka_before, marka_after, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_pk;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Klapan_protivopojarniy_dimoudalenia(bool rotated_or_not)
        {
            Add_Protivopojarniy_klapan("КПУ-3-ДД-Р-В", "2*ф-ЭПВ220-СН-КК-0-К-0-0-0", rotated_or_not);
        }

        public void Add_Germoklapan(string tip_klapana, bool korrozionnostoykiy_or_not)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Germoklapan n_gk = null;

            if (this.Forma_sechenia == "rectangle") n_gk = new Germoklapan(rashod, a, b, false, tip_klapana, korrozionnostoykiy_or_not);
            else n_gk = new Germoklapan(rashod, d, tip_klapana, korrozionnostoykiy_or_not);

            Mestnoe_soprotivlenie mest_s = n_gk;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Dimovoy_klapan(bool kanalniy_true_stenovoy_false, bool rotated_or_not)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Dimovoy_klapan n_dk = null;

            if (this.Forma_sechenia == "rectangle") n_dk = new Dimovoy_klapan(kanalniy_true_stenovoy_false, rashod, a, b, rotated_or_not);
            else n_dk = new Dimovoy_klapan(kanalniy_true_stenovoy_false, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_dk;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Klapan_izbitochnogo_davlenia(bool rotated_or_not)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Klapan_izbitochnogo_davlenia n_kid = null;

            if (this.Forma_sechenia == "rectangle") n_kid = new Klapan_izbitochnogo_davlenia(rashod, a, b, rotated_or_not);
            else n_kid = new Klapan_izbitochnogo_davlenia(rashod, d);

            Mestnoe_soprotivlenie mest_s = n_kid;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Obratniy_klapan(int polojenie_1_gor_2_ver, bool rotated_or_not)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Obratniy_klapan n_ok = null;

            if (this.Forma_sechenia == "rectangle") n_ok = new Obratniy_klapan(polojenie_1_gor_2_ver, rashod, a, b, rotated_or_not);
            else n_ok = new Obratniy_klapan(polojenie_1_gor_2_ver, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_ok;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Obratniy_klapan_s_elektroprivodom(bool rotated_or_not)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Obratniy_klapan_s_elektroprivodom n_ok_ep = null;

            if (this.Forma_sechenia == "rectangle") n_ok_ep = new Obratniy_klapan_s_elektroprivodom(rashod, a, b, rotated_or_not);
            else n_ok_ep = new Obratniy_klapan_s_elektroprivodom(rashod, d);

            Mestnoe_soprotivlenie mest_s = n_ok_ep;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_ElektroNagrevatel(double nominalnaia_moshnost_kvt)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            ElektroNagrevatel n_en = null;

            if (this.Forma_sechenia == "rectangle") n_en = new ElektroNagrevatel(nominalnaia_moshnost_kvt, rashod, a, b);
            else n_en = new ElektroNagrevatel(nominalnaia_moshnost_kvt, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_en;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Freonoviy_ohladitel()
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Freonoviy_ohladitel n_fo = null;

            if (this.Forma_sechenia == "rectangle") n_fo = new Freonoviy_ohladitel(rashod, a, b);
            else n_fo = new Freonoviy_ohladitel(rashod, d);

            Mestnoe_soprotivlenie mest_s = n_fo;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Filtr(string proizvoditel_oborudovania, string klass_vozdushnogo_filtra)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Filtr n_fi = null;

            if (this.Forma_sechenia == "rectangle") n_fi = new Filtr(proizvoditel_oborudovania, klass_vozdushnogo_filtra, rashod, a, b);
            else n_fi = new Filtr(proizvoditel_oborudovania, klass_vozdushnogo_filtra, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_fi;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Shumoglushitel(string proizvoditel_oborudovania, double dlina)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Shumoglushitel n_sg = null;

            if (this.Forma_sechenia == "rectangle") n_sg = new Shumoglushitel(proizvoditel_oborudovania, rashod, a, b);
            else n_sg = new Shumoglushitel(rashod, d, dlina, proizvoditel_oborudovania);

            Mestnoe_soprotivlenie mest_s = n_sg;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Gibkaia_vstavka(string proizvoditel_oborudovania)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Gibkaia_vstavka n_gv = null;

            if (this.Forma_sechenia == "rectangle") n_gv = new Gibkaia_vstavka(proizvoditel_oborudovania, rashod, a, b);
            else n_gv = new Gibkaia_vstavka(proizvoditel_oborudovania, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_gv;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Otvod(double ugol_povorota, bool povorot_vdol_visoti_false_vdol_shirini_true)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Otvod n_otv = null;

            if (this.Forma_sechenia == "rectangle") n_otv = new Otvod(ugol_povorota, rashod, a, b, povorot_vdol_visoti_false_vdol_shirini_true);
            else n_otv = new Otvod(ugol_povorota, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_otv;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Otvod_s_ostrimi_kromkami(double ugol_povorota, bool povorot_vdol_visoti_false_vdol_shirini_true)
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Otvod_s_ostrimi_kromkami n_otv_ostr = null;

            if (this.Forma_sechenia == "rectangle") n_otv_ostr = new Otvod_s_ostrimi_kromkami(ugol_povorota, rashod, a, b, povorot_vdol_visoti_false_vdol_shirini_true);
            else n_otv_ostr = new Otvod_s_ostrimi_kromkami(ugol_povorota, rashod, d);

            Mestnoe_soprotivlenie mest_s = n_otv_ostr;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Perehod(bool perehod_in_the_end, double second_uchastok_width, double second_uchastok_height, double dlina_perehoda)
        {
            Uchastok uchastok_2 = new Uchastok(this._stream_type, 999999, this.Rashod_m3_in_hour, 1, second_uchastok_width, second_uchastok_height);

            Perehod n_per = new Perehod(perehod_in_the_end, this, uchastok_2, dlina_perehoda);

            Mestnoe_soprotivlenie mest_s = n_per;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Perehod(bool perehod_in_the_end, double second_uchastok_diameter, double dlina_perehoda)
        {
            Uchastok uchastok_2 = new Uchastok(this._stream_type, 999999, this.Rashod_m3_in_hour, 1, second_uchastok_diameter);

            Perehod n_per = new Perehod(perehod_in_the_end, this, uchastok_2, dlina_perehoda);

            Mestnoe_soprotivlenie mest_s = n_per;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Vnezapniy_perehod(double second_uchastok_width, double second_uchastok_height)
        {
            Uchastok uchastok_2 = new Uchastok(this._stream_type, 999999, this.Rashod_m3_in_hour, 1, second_uchastok_width, second_uchastok_height);

            Vnezapniy_perehod n_vnezper = new Vnezapniy_perehod(this, uchastok_2);

            Mestnoe_soprotivlenie mest_s = n_vnezper;

            Spisok_soprotivleniy.Add(mest_s);
        }
        public void Add_Vnezapniy_perehod(double second_uchastok_diameter)
        {
            Uchastok uchastok_2 = new Uchastok(this._stream_type, 999999, this.Rashod_m3_in_hour, 1, second_uchastok_diameter);

            Vnezapniy_perehod n_vnezper = new Vnezapniy_perehod(this, uchastok_2);

            Mestnoe_soprotivlenie mest_s = n_vnezper;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Troynik_Rectangle(bool circle_other_uchastok, string type_of_troynik, double second_uchastok_width, double second_uchastok_height, double second_uchastok_rashod,
            double other_uchastok_width, double other_uchastok_height, double other_uchastok_diameter)
        {
            Uchastok uchastok_2 = new Uchastok(this._stream_type, 999999, second_uchastok_rashod, 1, second_uchastok_width, second_uchastok_height);

            Troynik n_troyn = null;

            if (circle_other_uchastok)
            {
                n_troyn = new Troynik(true, this, uchastok_2, type_of_troynik, other_uchastok_diameter, other_uchastok_diameter);
            }
            else
            {
                n_troyn = new Troynik(false, this, uchastok_2, type_of_troynik, other_uchastok_width, other_uchastok_height);
            }

            Mestnoe_soprotivlenie mest_s = n_troyn;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Troynik_Circle(bool circle_other_uchastok, string type_of_troynik, double second_uchastok_diameter, double second_uchastok_rashod,
            double other_uchastok_width, double other_uchastok_height, double other_uchastok_diameter)
        {
            Uchastok uchastok_2 = new Uchastok(this._stream_type, 999999, second_uchastok_rashod, 1, second_uchastok_diameter);

            Troynik n_troyn = null;

            if (circle_other_uchastok)
            {
                n_troyn = new Troynik(true, this, uchastok_2, type_of_troynik, other_uchastok_diameter, other_uchastok_diameter);
            }
            else
            {
                n_troyn = new Troynik(false, this, uchastok_2, type_of_troynik, other_uchastok_width, other_uchastok_height);
            }

            Mestnoe_soprotivlenie mest_s = n_troyn;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Reshetka()
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Reshetka n_resh = null;

            if (this.Forma_sechenia == "rectangle") n_resh = new Reshetka(rashod, a, b);
            else n_resh = new Reshetka(rashod, d);

            Mestnoe_soprotivlenie mest_s = n_resh;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Setka()
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Setka n_set = null;

            if (this.Forma_sechenia == "rectangle") n_set = new Setka(rashod, a, b);
            else n_set = new Setka(rashod, d);

            Mestnoe_soprotivlenie mest_s = n_set;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Diffuzor()
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            string str_type = this._stream_type;

            Diffuzor n_dif = null;

            if (this.Forma_sechenia == "rectangle") n_dif = new Diffuzor(rashod, a, b, str_type);
            else n_dif = new Diffuzor(rashod, d, str_type);

            Mestnoe_soprotivlenie mest_s = n_dif;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public void Add_Diffuzor_stat_kamera()
        {
            double a = this.Width_mm;
            double b = this.Height_mm;

            double d = this.Diameter_mm;

            double rashod = this.Rashod_m3_in_hour;

            Diffuzor_stat_kamera n_dif_st_k = null;

            if (this.Forma_sechenia == "rectangle") n_dif_st_k = new Diffuzor_stat_kamera(rashod, a, b);
            else n_dif_st_k = new Diffuzor_stat_kamera(rashod, d);

            Mestnoe_soprotivlenie mest_s = n_dif_st_k;

            Spisok_soprotivleniy.Add(mest_s);
        }

        public override string ToString()
        {
            return "Номер = " + Number.ToString() + "; " + Forma_sechenia + "; L = " + Rashod_m3_in_hour.ToString() + " м3/ч; длина = " + Length_m.ToString() + " м; ширина = " + Width_mm.ToString() + " мм; высота = " + Height_mm.ToString() + " мм; диаметр = " + Diameter_mm.ToString() + " мм; " + Material + "; v = " + v.ToString() + " м/с; Re = " + Re.ToString() + "; delta P = " + Poteri_davlenia_po_dline_Pa.ToString() + " Па; T = " + _T.ToString() + " K; Плотность = " + plotnost.ToString() + "кг/м3";
        }

        public List<string> get_Mestnie_Soprotivlenia_List_String()
        {
            List<string> rez_list = new List<string>();
            string str_new;

            foreach (Mestnoe_soprotivlenie ms_new in Spisok_soprotivleniy)
            {
                str_new = ms_new.Name;
                rez_list.Add(str_new);
            }

            return rez_list;
        }
    }
}
