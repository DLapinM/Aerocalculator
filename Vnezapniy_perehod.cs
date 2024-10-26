using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Vnezapniy_perehod : Mestnoe_soprotivlenie
    {
        private bool _vitiajka_tru_pritok_false = true;

        private string _tip_perehoda;

        public string Tip_perehoda
        {
            get
            {
                return _tip_perehoda;
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
        private double Take_kms()
        {
            if ((Ploschad_1 == 0) || (Ploschad_2 == 0)) return 0;
            else if (Ploschad_2 > Ploschad_1)
            {
                return Math.Pow((1-(Ploschad_1/Ploschad_2)), 2.0);
            }
            else if (Ploschad_2 < Ploschad_1)
            {
                double k_f = (Ploschad_2 / Ploschad_1);

                if ((k_f >= 0) && (k_f <= 0.1))
                {
                    return ((-0.109) * k_f + (0.5));
                }
                else if ((k_f > 0.1) && (k_f <= 0.2))
                {
                    return ((-0.282) * k_f + (0.5173));
                }
                else if ((k_f > 0.2) && (k_f <= 0.3))
                {
                    return ((-0.389) * k_f + (0.5387));
                }
                else if ((k_f > 0.3) && (k_f <= 0.4))
                {
                    return ((-0.459) * k_f + (0.5597));
                }
                else if ((k_f > 0.4) && (k_f <= 0.5))
                {
                    return ((-0.536) * k_f + (0.5905));
                }
                else if ((k_f > 0.5) && (k_f <= 0.6))
                {
                    return ((-0.59) * k_f + (0.6175));
                }
                else if ((k_f > 0.6) && (k_f <= 0.7))
                {
                    return ((-0.638) * k_f + (0.6463));
                }
                else if ((k_f > 0.7) && (k_f <= 0.8))
                {
                    return ((-0.695) * k_f + (0.6862));
                }
                else if ((k_f > 0.8) && (k_f <= 0.9))
                {
                    return ((-0.718) * k_f + (0.7046));
                }
                else if ((k_f > 0.9) && (k_f <= 1.0))
                {
                    return ((-0.584) * k_f + (0.584));
                }
                else return 0;
            }
            else return 0;
        }

        public Vnezapniy_perehod(Uchastok first_uchastok, Uchastok second_uchastok) : base("Внезапный переход", "", first_uchastok.Rashod_m3_in_hour, first_uchastok.Width_mm, first_uchastok.Height_mm, false, 0)
        {
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

            if ((_diameter_mm > 0) && (second_uchastok.Diameter_mm > 0))
            {
                double f_01 = Math.PI * Math.Pow(_diameter_mm, 2.0) / 4.0;
                double f_02 = Math.PI * Math.Pow(second_uchastok.Diameter_mm, 2.0) / 4.0;

                if (f_02 > f_01) _tip_perehoda = "расширение";
                else _tip_perehoda = "сужение";
            }
            else
            {
                double a_01 = _width_mm;
                double a_02 = Width_2_mm;
                double b_01 = _height_mm;
                double b_02 = Height_2_mm;

                double f_01;
                double f_02;

                if (_diameter_mm > 0)
                {
                    f_01 = Math.PI * Math.Pow(_diameter_mm, 2.0) / 4.0;
                }
                else
                {
                    f_01 = a_01 * b_01;
                }

                if (second_uchastok.Diameter_mm > 0)
                {
                    f_02 = Math.PI * Math.Pow(second_uchastok.Diameter_mm, 2.0) / 4.0;
                }
                else
                {
                    f_02 = a_02 * b_02;
                }

                if (f_02 > f_01) _tip_perehoda = "внезапное расширение";
                else _tip_perehoda = "внезапное сужение";
            }

            _kms = Take_kms();
        }
    }
}
