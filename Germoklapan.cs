using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Germoklapan : Mestnoe_soprotivlenie
    {
        private string _tip_klapana;

        private bool _korozionnostoykiy_or_not;

        private double Get_d_nom()
        {
            double d_nom;

            if (_diameter_mm <= 219) d_nom = 200;
            else if ((_diameter_mm > 219) && (_diameter_mm <= 325)) d_nom = 300;
            else if ((_diameter_mm > 325) && (_diameter_mm <= 426)) d_nom = 400;
            else if ((_diameter_mm > 426) && (_diameter_mm <= 530)) d_nom = 500;
            else if ((_diameter_mm > 530) && (_diameter_mm <= 630)) d_nom = 600;
            else if ((_diameter_mm > 630) && (_diameter_mm <= 820)) d_nom = 800;
            else if ((_diameter_mm > 820) && (_diameter_mm <= 1020)) d_nom = 1000;
            else d_nom = 1200;

            return d_nom;
        }

        public override string Name
        {
            get
            {
                if (Forma_sechenia == "rectangle")
                {
                    return (_short_name + " " + Width_mm.ToString() + "x" + Height_mm.ToString());
                }

                else
                {
                    return (_short_name + " DN" + Get_d_nom().ToString());
                }
            }
        }
        protected override void Refresh_marka()
        {
            if (_forma_sechenia == "circle")
            {
                if (!_korozionnostoykiy_or_not)
                {
                    if (_tip_klapana == "общепромышленный") _marka = "КГ" + Get_d_nom().ToString() + ".1.3111.4";
                    else if (_tip_klapana == "взрывозащищённый") _marka = "КГ" + Get_d_nom().ToString() + ".2.3111.4";
                    else if (_tip_klapana == "жаропрочный") _marka = "КГ" + Get_d_nom().ToString() + ".4.3211.4";
                    else _marka = "КГ" + Get_d_nom().ToString() + ".1.3111.4";
                }
                else
                {
                    if (_tip_klapana == "общепромышленный") _marka = "КГ" + Get_d_nom().ToString() + ".1.3121.4";
                    else if (_tip_klapana == "взрывозащищённый") _marka = "КГ" + Get_d_nom().ToString() + ".2.3121.4";
                    else if (_tip_klapana == "жаропрочный") _marka = "КГ" + Get_d_nom().ToString() + ".4.3221.4";
                    else _marka = "КГ" + Get_d_nom().ToString() + ".1.3121.4";
                }
            }
            else
            {
                if (!_korozionnostoykiy_or_not)
                {
                    if (_tip_klapana == "общепромышленный") _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".1.3111.4";
                    else if (_tip_klapana == "взрывозащищённый") _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".2.3111.4";
                    else if (_tip_klapana == "жаропрочный") _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".4.3211.4";
                    else _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".1.3111.4";
                }
                else
                {
                    if (_tip_klapana == "общепромышленный") _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".1.3121.4";
                    else if (_tip_klapana == "взрывозащищённый") _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".2.3121.4";
                    else if (_tip_klapana == "жаропрочный") _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".4.3221.4";
                    else _marka = "КГ" + "(" + _width_mm.ToString() + "x" + _height_mm.ToString() + ")" + ".1.3121.4";
                }
            }
        }
        protected override void Refresh_kms()
        {
            if (_forma_sechenia == "circle")
            {
                double d_nom;

                if (_diameter_mm <= 219) d_nom = 200;
                else if ((_diameter_mm > 219) && (_diameter_mm <= 325)) d_nom = 300;
                else if ((_diameter_mm > 325) && (_diameter_mm <= 426)) d_nom = 400;
                else if ((_diameter_mm > 426) && (_diameter_mm <= 530)) d_nom = 500;
                else if ((_diameter_mm > 530) && (_diameter_mm <= 630)) d_nom = 600;
                else if ((_diameter_mm > 630) && (_diameter_mm <= 820)) d_nom = 800;
                else if ((_diameter_mm > 820) && (_diameter_mm <= 1020)) d_nom = 1000;
                else d_nom = 1200;

                if (_tip_klapana == "общепромышленный")
                {
                    if (d_nom == 200) _kms = 0.42;
                    else if (d_nom == 300) _kms = 0.42;
                    else if (d_nom == 400) _kms = 0.4;
                    else if (d_nom == 500) _kms = 0.4;
                    else if (d_nom == 600) _kms = 0.36;
                    else if (d_nom == 800) _kms = 0.34;
                    else if (d_nom == 1000) _kms = 0.3;
                    else if (d_nom == 1200) _kms = 0.28;
                    else _kms = 0.42;
                }
                else if (_tip_klapana == "взрывозащищённый")
                {
                    if (d_nom == 200) _kms = 0.42;
                    else if (d_nom == 300) _kms = 0.42;
                    else if (d_nom == 400) _kms = 0.4;
                    else if (d_nom == 500) _kms = 0.4;
                    else if (d_nom == 600) _kms = 0.36;
                    else if (d_nom == 800) _kms = 0.34;
                    else if (d_nom == 1000) _kms = 0.3;
                    else if (d_nom == 1200) _kms = 0.28;
                    else _kms = 0.42;
                }
                else
                {
                    if (d_nom == 200) _kms = 0.46;
                    else if (d_nom == 300) _kms = 0.42;
                    else if (d_nom == 400) _kms = 0.4;
                    else if (d_nom == 500) _kms = 0.38;
                    else if (d_nom == 600) _kms = 0.36;
                    else if (d_nom == 800) _kms = 0.36;
                    else if (d_nom == 1000) _kms = 0.3;
                    else if (d_nom == 1200) _kms = 0.28;
                    else _kms = 0.46;
                }
            }
            else
            {
                _kms = 0;
            }
        }

        public void Change_tip_klapana(string tip, bool korozionnostoykiy_or_not)
        {
            switch (tip)
            {
                case "общепромышленный":
                    _tip_klapana = tip;
                    break;
                case "взрывозащищённый":
                    _tip_klapana = tip;
                    break;
                case "взрывозащищенный":
                    _tip_klapana = "взрывозащищённый";
                    break;
                case "жаропрочный":
                    _tip_klapana = tip;
                    break;
                default:
                    _tip_klapana = "общепромышленный";
                    break;
            }

            _korozionnostoykiy_or_not = korozionnostoykiy_or_not;
        }
        public Germoklapan(double rashod_m3_in_hour, double diameter_mm, string tip_klapana, bool korozionnostoykiy_or_not)
            : base("Клапан герметический", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            Change_tip_klapana(tip_klapana, korozionnostoykiy_or_not);

            _short_name = "Клапан герметический, " + _tip_klapana + "," + (_korozionnostoykiy_or_not ? " коррозионностойкий," : "");

            Refresh_marka();

            Refresh_kms();
        }
        public Germoklapan(double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated, string tip_klapana, bool korozionnostoykiy_or_not)
            : base("Клапан герметический", "", rashod_m3_in_hour, width_mm, height_mm, rotated, 0)
        {
            Change_tip_klapana(tip_klapana, korozionnostoykiy_or_not);

            _short_name = "Клапан герметический, " + _tip_klapana + "," + (_korozionnostoykiy_or_not ? " коррозионностойкий," : "");

            Refresh_marka();

            Refresh_kms();
        }

    }
}
