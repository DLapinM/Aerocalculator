using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Diffuzor : Mestnoe_soprotivlenie
    {
        private bool _vitiajka_tru_pritok_false = true;

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

        protected override void Refresh_marka()
        {
            _marka = "";

            if (Forma_sechenia == "rectangle")
            {
                if ((_diameter_mm > 0) && (_diameter_mm < 450))
                {
                    _marka = "4АПН (300x300)";
                }
                else if ((_diameter_mm >= 450) && (_diameter_mm < 600))
                {
                    _marka = "4АПН (450x450)";
                }
                else if (_diameter_mm >= 600)
                {
                    _marka = "4АПН (600x600)";
                }
            }
            else
            {
                if ((_diameter_mm > 0) && (_diameter_mm < 125))
                {
                    _marka = "ДПУ-М 100";
                }
                else if ((_diameter_mm >= 125) && (_diameter_mm < 160))
                {
                    _marka = "ДПУ-М 125";
                }
                else if ((_diameter_mm >= 160) && (_diameter_mm < 200))
                {
                    _marka = "ДПУ-М 160";
                }
                else if ((_diameter_mm >= 200) && (_diameter_mm < 250))
                {
                    _marka = "ДПУ-М 200";
                }
                else if (_diameter_mm >= 250)
                {
                    _marka = "ДПУ-М 250";
                }
            }
        }

        public void SetMarka()
        {
            Refresh_marka();
        }

        private double Take_kms()
        {
            if (Forma_sechenia == "rectangle")
            {
                if ( (_width_mm <= 0) || (_height_mm <= 0) ) return 0;

                if (_diameter_mm <= 0) return 0;

                if (_vitiajka_tru_pritok_false)
                {
                    if ( (_diameter_mm > 0) && (_diameter_mm < 450) )
                    {
                        return 30.33370353;
                    }
                    else if ( (_diameter_mm >= 450) && (_diameter_mm < 600) )
                    {
                        return 17.05616686;
                    }
                    else
                    {
                        return 19.96515188;
                    }
                }
                else
                {
                    if ((_diameter_mm > 0) && (_diameter_mm < 450))
                    {
                        return 33.60958883;
                    }
                    else if ((_diameter_mm >= 450) && (_diameter_mm < 600))
                    {
                        return 15.29824459;
                    }
                    else
                    {
                        return 14.6835543;
                    }
                }
            }
            else
            {
                if (_diameter_mm <= 0) return 0;

                if (_vitiajka_tru_pritok_false)
                {
                    if ( (_diameter_mm > 0) && (_diameter_mm < 125) )
                    {
                        return 13.32396594;
                    }
                    else if ( (_diameter_mm >= 125) && (_diameter_mm < 160) )
                    {
                        return 12.68639335;
                    }
                    else if ((_diameter_mm >= 160) && (_diameter_mm < 200))
                    {
                        return 12.08580529;
                    }
                    else if ((_diameter_mm >= 200) && (_diameter_mm < 250))
                    {
                        return 11.93827348;
                    }
                    else
                    {
                        return 11.4715268;
                    }
                }
                else
                {
                    if ((_diameter_mm > 0) && (_diameter_mm < 125))
                    {
                        return 15.19764865;
                    }
                    else if ((_diameter_mm >= 125) && (_diameter_mm < 160))
                    {
                        return 14.90922296;
                    }
                    else if ((_diameter_mm >= 160) && (_diameter_mm < 200))
                    {
                        return 14.97428778;
                    }
                    else if ((_diameter_mm >= 200) && (_diameter_mm < 250))
                    {
                        return 14.15671381;
                    }
                    else
                    {
                        return 13.66611938;
                    }
                }
            }
        }

        public Diffuzor(double rashod_m3_in_hour, double width_mm, double height_mm, string type_of_stream) : base("Потолочный диффузор", "", rashod_m3_in_hour, width_mm, height_mm, false, 0)
        {
            Stream_type = type_of_stream;
            SetMarka();
            _kms = Take_kms();
        }

        public Diffuzor(double rashod_m3_in_hour, double diameter_mm, string type_of_stream) : base("Потолочный диффузор", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            Stream_type = type_of_stream;
            SetMarka();
            _kms = Take_kms();
        }
    }
}
