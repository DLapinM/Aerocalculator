using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Troynik : Mestnoe_soprotivlenie
    {
        private bool _vitiajka_tru_pritok_false = true;

        private string _tip_troynika;

        public string Tip_troynika
        {
            get
            {
                return _tip_troynika;
            }
            set
            {
                switch(value)
                {
                    case "всасывание-проход":
                    _tip_troynika = "всасывание-проход";
                        break;
                    case "всасывание-ответвление":
                        _tip_troynika = "всасывание-ответвление";
                        break;
                    case "нагнетание-проход":
                        _tip_troynika = "нагнетание-проход";
                        break;
                    case "нагнетание-ответвление":
                        _tip_troynika = "нагнетание-ответвление";
                        break;
                    case "противоток":
                        _tip_troynika = "противоток";
                        break;
                    case "растекание":
                        _tip_troynika = "растекание";
                        break;
                    default:
                        _tip_troynika = "всасывание-проход";
                        break;
                }
            }
        }

        public string Stream_type
        {
            get
            {
                if (_vitiajka_tru_pritok_false) return "вытяжная";
                else return "приточная";
            }
            set
            {
                if (value == "приточная") _vitiajka_tru_pritok_false = false;
                else _vitiajka_tru_pritok_false = true;
            }
        }

        Uchastok uch2;

        public double Width_2_mm
        {
            get
            {
                return uch2.Width_mm;
            }
        }

        public double Height_2_mm
        {
            get
            {
                return uch2.Height_mm;
            }
        }

        public double Diameter_2_mm
        {
            get
            {
                return uch2.Diameter_mm;
            }
        }

        public string Forma_2
        {
            get
            {
                return uch2.Forma_sechenia;
            }
        }

        public double Ploschad_1
        {
            get
            {
                return this.Ploschad;
            }
        }

        public double Ploschad_2
        {
            get
            {
                if (uch2.Forma_sechenia == "circle")
                {
                    return (Math.PI * Math.Pow(uch2.Diameter_mm, 2.0) / 4.0);
                }
                else
                {
                    return (uch2.Width_mm * uch2.Height_mm);
                }
            }
        }

        double _width_3_mm;
        double _height_3_mm;
        double _diameter_3_mm;

        public double Rashod_1
        {
            get
            {
                return this.Rashod_m3_in_hour;
            }
        }

        public double Rashod_2
        {
            get
            {
                return uch2.Rashod_m3_in_hour;
            }
        }

        public double Rashod_3
        {
            get
            {
                return (Math.Max(Rashod_1, Rashod_2) - Math.Min(Rashod_1, Rashod_2));
            }
        }

        public double Ploschad_3
        {
            get
            {
                if (Math.Abs(_diameter_3_mm) == 0)
                {
                    return Math.Abs(_width_3_mm * _height_3_mm);
                }
                else return (Math.PI * Math.Pow(_diameter_3_mm, 2.0) / 4.0);
            }
        }

        public double Ls
        {
            get
            {
                return Math.Max(Rashod_1, Rashod_2);
            }
        }

        public double Lp
        {
            get
            {
                if ((Tip_troynika == "всасывание-проход") || (Tip_troynika == "нагнетание-проход"))
                {
                    return Math.Min(Rashod_1, Rashod_2);
                }
                else return Rashod_3;
            }
        }

        public double Lo
        {
            get
            {
                return (Ls - Lp);
            }
        }

        public double Fs
        {
            get
            {
                if (Rashod_1 > Rashod_2)
                {
                    return Ploschad_1;
                }
                else if (Rashod_2 > Rashod_1)
                {
                    return Ploschad_2;
                }
                else
                {
                    return Math.Max(Ploschad_1, Ploschad_2);
                }
            }
        }

        public double Fp
        {
            get
            {
                if ((Tip_troynika == "всасывание-проход") || (Tip_troynika == "нагнетание-проход"))
                {
                    if (Ploschad_1 < Ploschad_2)
                    {
                        return Ploschad_1;
                    }
                    else if (Ploschad_2 < Ploschad_1)
                    {
                        return Ploschad_2;
                    }
                    else
                    {
                        return Math.Min(Ploschad_1, Ploschad_2);
                    }
                }
                else return Ploschad_3;
            }
        }

        public double Fo
        {
            get
            {
                if ((Tip_troynika == "всасывание-проход") || (Tip_troynika == "нагнетание-проход"))
                {
                    return Ploschad_3;
                }
                else
                {
                    if (Ploschad_1 < Ploschad_2)
                    {
                        return Ploschad_1;
                    }
                    else if (Ploschad_2 < Ploschad_1)
                    {
                        return Ploschad_2;
                    }
                    else
                    {
                        return Math.Min(Ploschad_1, Ploschad_2);
                    }
                }
            }
        }

        public double Lo1
        {
            get
            {
                if (Ls == 0) return 0;
                else return (Lo / Ls);
            }
        }

        public double Fo1
        {
            get
            {
                if (Fs == 0) return 0;
                else return (Fo / Fs);
            }
        }

        public double Fp1
        {
            get
            {
                if (Fs == 0) return 0;
                else return (Fp / Fs);
            }
        }

        public string Razmer1
        {
            get
            {
                if ((_width_mm > 0) && (_height_mm > 0))
                {
                    return _width_mm.ToString() + "x" + _height_mm.ToString();
                }
                else
                {
                    return _diameter_mm.ToString();
                }
            }
        }

        public string Razmer2
        {
            get
            {
                if (uch2.Forma_sechenia == "rectangle")
                {
                    return uch2.Width_mm.ToString() + "x" + uch2.Height_mm.ToString();
                }
                else
                {
                    return uch2.Diameter_mm.ToString();
                }
            }
        }

        public string Razmer3
        {
            get
            {
                if ((_width_3_mm > 0) && (_height_3_mm > 0))
                {
                    return _width_3_mm.ToString() + "x" + _height_3_mm.ToString();
                }
                else
                {
                    return _diameter_3_mm.ToString();
                }
            }
        }

        protected override void Refresh_marka()
        {
            string razmer = "";
            string rashod = "";

            if (_tip_troynika == "всасывание-проход")
            {
                razmer = Razmer2 + "-" + Razmer3 + "-" + Razmer1;
                rashod = ", L: (" + Rashod_2.ToString() + "; " + Rashod_3.ToString() + "; " + Rashod_1.ToString() + ")";
            }

            else if (_tip_troynika == "нагнетание-проход")
            {
                razmer = Razmer1 + "-" + Razmer3 + "-" + Razmer2;
                rashod = ", L: (" + Rashod_1.ToString() + "; " + Rashod_3.ToString() + "; " + Rashod_2.ToString() + ")";
            }

            else if (_tip_troynika == "всасывание-ответвление")
            {
                razmer = Razmer2 + "-" + Razmer1 + "-" + Razmer3;
                rashod = ", L: (" + Rashod_2.ToString() + "; " + Rashod_1.ToString() + "; " + Rashod_3.ToString() + ")";
            }

            else if (_tip_troynika == "нагнетание-ответвление")
            {
                razmer = Razmer2 + "-" + Razmer1 + "-" + Razmer3;
                rashod = ", L: (" + Rashod_2.ToString() + "; " + Rashod_1.ToString() + "; " + Rashod_3.ToString() + ")";
            }

            else if (_tip_troynika == "растекание")
            {
                razmer = Razmer1 + "-" + Razmer2 + "-" + Razmer3;
                rashod = ", L: (" + Rashod_1.ToString() + "; " + Rashod_2.ToString() + "; " + Rashod_3.ToString() + ")";
            }

            else if (_tip_troynika == "противоток")
            {
                razmer = Razmer1 + "-" + Razmer2 + "-" + Razmer3;
                rashod = ", L: (" + Rashod_1.ToString() + "; " + Rashod_2.ToString() + "; " + Rashod_3.ToString() + ")";
            }

            else
            {
                razmer = Razmer2 + "-" + Razmer3 + "-" + Razmer1;
                rashod = ", L: (" + Rashod_2.ToString() + "; " + Rashod_3.ToString() + "; " + Rashod_1.ToString() + ")";
            }

            _marka = "Тройник (" + _tip_troynika + ") " + razmer + rashod;
        }
        private double Take_kms()
        {
            if (_tip_troynika == "нагнетание-проход")
            {
                return (0.41 + (Fp1 * (25.0 * Math.Pow((Lo1 - 0.2), 4.0)) - 0.25));
            }

            else if (_tip_troynika == "всасывание-проход")
            {
                if (Fo1 == 0) return 0;
                else return (0.2 + (1.7 * Fp1)) * (0.35 - (0.25 * Fo1) + 2.4 * Math.Pow((Lo1 - 0.2), 2.0) / Fo1);
            }

            else if (_tip_troynika == "нагнетание-ответвление")
            {
                return (0.225 * Fo1 + 0.17) * Math.Pow(Lo1, ((-1)*(2.41 * Fo1 + 0.32)));
            }

            else if (_tip_troynika == "всасывание-ответвление")
            {
                return (31.7 - 5.85 * Fo1) * (6.5 * Math.Pow(Lo1, 3.0) - 10.7 * Math.Pow(Lo1, 2.0) + 5.85 * Lo1 - 0.475 * Fo1 - 0.79);
            }

            else if (_tip_troynika == "растекание")
            {
                return (0.225 * Fo1 + 0.17) * Math.Pow(Lo1, ((-1) * (2.41 * Fo1 + 0.32)));
            }

            else if (_tip_troynika == "противоток")
            {
                return (31.7 - 5.85 * Fo1) * (6.5 * Math.Pow(Lo1, 3.0) - 10.7 * Math.Pow(Lo1, 2.0) + 5.85 * Lo1 - 0.475 * Fo1 - 0.79);
            }

            else
            {
                if (Fo1 == 0) return 0;
                else return (0.2 + (1.7 * Fp1)) * (0.35 - (0.25 * Fo1) + 2.4 * Math.Pow((Lo1 - 0.2), 2.0) / Fo1);
            }
        }

        public void SetMarka()
        {
            Refresh_marka();
        }

        public override string Name
        {
            get
            {
                Refresh_marka();
                return _marka;
            }
        }

        public override string ToString()
        {
            Refresh_marka();
            _kms = Take_kms();
            return _marka + " КМС = " + _kms + " Ls = " + Ls.ToString() + "; " + "Lo = " + Lo.ToString() + "; " + "Lp = " + Lp.ToString() + "; " + "Fs = " + Fs.ToString() + "; " + "Fo = " + Fo.ToString() + "; " + "Fp = " + Fp.ToString();
        }

        public Troynik(Uchastok first_uchastok, Uchastok second_uchastok, string tip, double other_width_3_mm, double other_height_3_mm) : base("Тройник", "", first_uchastok.Rashod_m3_in_hour, first_uchastok.Width_mm, first_uchastok.Height_mm, false, 0)
        {
            Tip_troynika = tip;

            if ((first_uchastok._stream_type == second_uchastok._stream_type) && (first_uchastok._stream_type != "вытяжная"))
            {
                _vitiajka_tru_pritok_false = false;
            }
            else
            {
                _vitiajka_tru_pritok_false = true;
            }

            _forma_sechenia = first_uchastok.Forma_sechenia;

            //_width_mm = first_uchastok.Width_mm;
            //_height_mm = first_uchastok.Height_mm;

            _diameter_mm = first_uchastok.Diameter_mm;

            //_rashod_m3_in_hour = first_uchastok.Rashod_m3_in_hour;

            //_rotated = false;

            //_short_name = "Переход";

            //_marka = "";

            uch2 = second_uchastok;

            _diameter_3_mm = 0;

            _width_3_mm = other_width_3_mm;
            _height_3_mm = other_height_3_mm;

            _short_name = "Тройник " + Tip_troynika;

            SetMarka();

            _kms = Take_kms();
        }
        public Troynik(bool circle_ohter_uchastok, Uchastok first_uchastok, Uchastok second_uchastok, string tip, double other_width_3_mm, double other_height_3_mm) : base("Тройник", "", first_uchastok.Rashod_m3_in_hour, first_uchastok.Width_mm, first_uchastok.Height_mm, false, 0)
        {
            Tip_troynika = tip;

            if ((first_uchastok._stream_type == second_uchastok._stream_type) && (first_uchastok._stream_type != "вытяжная"))
            {
                _vitiajka_tru_pritok_false = false;
            }
            else
            {
                _vitiajka_tru_pritok_false = true;
            }

            _forma_sechenia = first_uchastok.Forma_sechenia;

            //_width_mm = first_uchastok.Width_mm;
            //_height_mm = first_uchastok.Height_mm;

            _diameter_mm = first_uchastok.Diameter_mm;

            //_rashod_m3_in_hour = first_uchastok.Rashod_m3_in_hour;

            //_rotated = false;

            //_short_name = "Переход";

            //_marka = "";

            uch2 = second_uchastok;

            if (circle_ohter_uchastok)
            {
                _diameter_3_mm = (2.0 * other_width_3_mm * other_height_3_mm) / (other_width_3_mm + other_height_3_mm);
                _width_3_mm = 0;
                _height_3_mm = 0;
            }
            else
            {
                _diameter_3_mm = 0;

                _width_3_mm = other_width_3_mm;
                _height_3_mm = other_height_3_mm;
            }

            _short_name = "Тройник " + Tip_troynika;

            SetMarka();

            _kms = Take_kms();
        }
    }
}
