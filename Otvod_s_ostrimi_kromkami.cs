using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Otvod_s_ostrimi_kromkami : Mestnoe_soprotivlenie
    {
        private double _ugol;

        public double Ugol
        {
            get
            {
                return _ugol;
            }
            set
            {
                if (value <= 0) _ugol = 0;
                else if (value <= 30) _ugol = 30;
                else if (value <= 60) _ugol = 60;
                else if (value <= 90) _ugol = 90;
                else if (value <= 120) _ugol = 120;
                else if (value <= 180) _ugol = 180;
                else _ugol = 90;
            }
        }

        private double Take_kms()
        {
            if ((_width_mm == 0) || (_height_mm == 0)) return 0;
            else if (_ugol == 0) return 0;
            else if (_ugol == 30) return 0.6;
            else if (_ugol == 60) return 1;
            else if (_ugol == 90) return 1.2;
            else if (_ugol == 120) return 1.4;
            else if (_ugol == 180) return 1.7;
            else return 1.2;
        }

        private double Take_kms_2()
        {
            if ((_width_mm == 0) || (_height_mm == 0)) return 0;
            else if (_ugol == 0) return 0;
            else if (_ugol == 30) return 0.6;
            else if (_ugol == 60) return 1;
            else if (_ugol == 90) return 1.2;
            else if (_ugol == 120) return 1.4;
            else if (_ugol == 180) return 1.7;
            else return 1.2;
        }

        protected override void Refresh_marka()
        {
            _marka = "";

            if (_forma_sechenia == "rectangle")
            {
                _short_name = "Отвод с острыми кромками прямоугольный (угол = " + _ugol.ToString() + ")";
            }
            else
            {
                _short_name = "Отвод с острыми кромками круглый (угол = " + _ugol.ToString() + ")";
            }
        }
        public void SetMarka()
        {
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

        public Otvod_s_ostrimi_kromkami(double ugol, double rashod_m3_in_hour, double width_mm, double height_mm, bool povorot_vdol_visoti_false_vdol_shirini_true)
       : base("Отвод с острыми кромками прямоугольный", "", rashod_m3_in_hour, width_mm, height_mm, povorot_vdol_visoti_false_vdol_shirini_true, 0)
        {
            if (povorot_vdol_visoti_false_vdol_shirini_true)
            {
                _width_mm = height_mm;
                _height_mm = width_mm;
            }

            Ugol = ugol;

            SetMarka();

            _kms = Take_kms();
        }

        public Otvod_s_ostrimi_kromkami(double ugol, double rashod_m3_in_hour, double diameter_mm)
            : base("Отвод с острыми кромками круглый", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            Ugol = ugol;

            SetMarka();

            _kms = Take_kms_2();
        }
    }
}
