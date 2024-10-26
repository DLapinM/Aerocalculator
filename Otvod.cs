using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Otvod : Mestnoe_soprotivlenie
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
                else if (value <= 45) _ugol = 45;
                else if (value <= 60) _ugol = 60;
                else if (value <= 75) _ugol = 75;
                else if (value <= 90) _ugol = 90;
                else if (value <= 90) _ugol = 130;
                else _ugol = 130;
            }
        }
        private double Take_predv_kms(double shirina, double visota)
        {
            if ((shirina <= 0) || (visota <= 0) || (_ugol <= 0)) return 0;

            double a = shirina;
            double b = visota;
            /*
            if (!_rotated)
            {
                a = shirina;
                b = visota;
            }
            else
            {
                a = visota;
                b = shirina;
            }
            */
            double kms_0;

            if (_ugol <= 30) kms_0 = 0.09;
            else if (_ugol <= 45) kms_0 = 0.13;
            else if (_ugol <= 60) kms_0 = 0.16;
            else if (_ugol <= 90) kms_0 = 0.21;
            else kms_0 = 0.25;

            double b_na_a = ((Math.Round((b / a) * 4.0)) / 4.0);
            double c;

            if (b_na_a <= 0.25) c = 1.3;
            else
            {
                b_na_a = ((Math.Round((b / a) * 2.0)) / 2.0);

                if (b_na_a == 0.5) c = 1.17;
                else if (b_na_a == 1) c = 1;
                else if (b_na_a == 1.5) c = 0.9;
                else if (b_na_a == 2) c = 0.85;
                else c = 1;
            }

            kms_0 = (kms_0 * c);

            double Rad = (b/1000.0);

            double dl = (((Math.PI * (2.0 * Rad)) / 180.0) * _ugol);

            Uchastok u = null;

            if (_forma_sechenia == "rectangle") u = new Uchastok("вытяжная", 1, _rashod_m3_in_hour, dl, a, b);
            else u = new Uchastok("вытяжная", 1, _rashod_m3_in_hour, dl, _diameter_mm);

            double pot_dl = u.Poteri_davlenia_po_dline_Pa;
            double plotn = u.plotnost;

            u = null;

            double kms_1 = (pot_dl / (plotn * Math.Pow(V, 2.0) / 2.0));

            return (Math.Round((kms_0 + kms_1)*100.0)/100.0);
        }
        private double Take_kms()
        {
            return Take_predv_kms(_width_mm, _height_mm);
        }

        private double Take_kms_2()
        {
            return Take_predv_kms(_diameter_mm, _diameter_mm);
        }
        protected override void Refresh_marka()
        {
            _marka = "";

            if (_forma_sechenia == "rectangle")
            {
                _short_name = "Отвод прямоугольный (угол = " + _ugol.ToString() + ")";
            }
            else
            {
                _short_name = "Отвод круглый (угол = " + _ugol.ToString() + ")";
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
        public Otvod(double ugol, double rashod_m3_in_hour, double width_mm, double height_mm, bool povorot_vdol_visoti_false_vdol_shirini_true)
       : base("Отвод прямоугольный", "", rashod_m3_in_hour, width_mm, height_mm, povorot_vdol_visoti_false_vdol_shirini_true, 0)
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

        public Otvod(double ugol, double rashod_m3_in_hour, double diameter_mm)
            : base("Отвод круглый", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            Ugol = ugol;

            SetMarka();

            _kms = Take_kms_2();
        }
    }
}
