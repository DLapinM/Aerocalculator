using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Gibkaia_vstavka : Mestnoe_soprotivlenie
    {
        private string _proizvoditel;
        public string Proizvoditel
        {
            get
            {
                return _proizvoditel;
            }
            private set
            {
                switch (value.ToUpper())
                {
                    case "ВЕЗА":
                        _proizvoditel = "Веза";
                        break;
                    case "АРКТИКА":
                        _proizvoditel = "Арктика";
                        break;
                    case "":
                        _proizvoditel = "";
                        break;
                    default:
                        _proizvoditel = "";
                        break;
                }
            }
        }
        private double Take_kms()
        {
            return 0.05;
        }

        private double Take_kms_2()
        {
            return 0.05;
        }

        public override string Name
        {
            get
            {
                Refresh_marka();
                return (_short_name + " " + _marka);
            }
        }
        protected override void Refresh_marka()
        {
            if (_proizvoditel == "") _marka = "";
            else if (_proizvoditel == "Веза")
            {
                if (_forma_sechenia == "rectangle")
                {
                    _marka = "Канал-ГКВ-" + Math.Round(Math.Max((_width_mm / 10.0), (_height_mm / 10.0))).ToString() + "-" + Math.Round(Math.Min((_width_mm / 10.0), (_height_mm / 10.0))).ToString();
                    _short_name = "Гибкая вставка прямоугольная";
                }
                else
                {
                    _marka = "Канал-ГКВ-" + Math.Round(_diameter_mm).ToString();
                    _short_name = "Гибкая вставка круглая";
                }
            }
            else if (_proizvoditel == "Арктика")
            {
                if (_forma_sechenia == "rectangle")
                {
                    _marka = "DS " + Math.Round(Math.Max(_width_mm, _height_mm)).ToString() + "x" + Math.Round(Math.Min(_width_mm, _height_mm)).ToString();
                    _short_name = "Гибкая вставка прямоугольная";
                }
                else
                {
                    _marka = "DS " + Math.Round(_diameter_mm).ToString();
                    _short_name = "Гибкая вставка круглая";
                }
            }
            else
            {
                _marka = "";
                if (_forma_sechenia == "rectangle") _short_name = "Гибкая вставка прямоугольная";
                else _short_name = "Гибкая вставка круглая";
            }
        }

        public void SetMarka(string proizvoditel_oborudovania)
        {
            Proizvoditel = proizvoditel_oborudovania;

            Refresh_marka();
        }

        protected override void Refresh_kms()
        {
            if (_forma_sechenia == "rectangle")
            {
                _kms = Take_kms();
            }
            else
            {
                _kms = Take_kms_2();
            }
        }

        public Gibkaia_vstavka(string proizvoditel_oborudovania, double rashod_m3_in_hour, double width_mm, double height_mm)
        : base("Гибкая вставка прямоугольная", "", rashod_m3_in_hour, Math.Max(width_mm, height_mm), Math.Min(width_mm, height_mm), false, 0)
        {
            SetMarka(proizvoditel_oborudovania);
            _kms = Take_kms();
        }
        public Gibkaia_vstavka(string proizvoditel_oborudovania, double rashod_m3_in_hour, double diameter_mm)
           : base("Шумоглушитель канальный круглый", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            SetMarka(proizvoditel_oborudovania);
            _kms = Take_kms_2();
        }
    }
}
