using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Klapan_izbitochnogo_davlenia : Mestnoe_soprotivlenie
    {
        public override string Name
        {
            get
            {
                string s_razmeri;

                if (_forma_sechenia == "rectangle")
                {
                    s_razmeri = _width_mm.ToString() + "x" + _height_mm.ToString();
                }
                else
                {
                    s_razmeri = "DN" + _diameter_mm.ToString();
                }

                Refresh_marka();

                return ("Клапан избыточного давления " + s_razmeri);
            }
        }
        private double Take_kms(double width, double height)
        {
            double[][] table_kms =
            {
                new double[] { 100, 100, 1.53 },
                new double[] { 150, 100, 1.18 },
                new double[] { 200, 100, 0.9 },
                new double[] { 300, 100, 0.69 },
                new double[] { 400, 100, 0.46 },
                new double[] { 500, 100, 0.31 },
                new double[] { 600, 100, 0.28 },
                new double[] { 700, 100, 0.19 },
                new double[] { 800, 100, 0.18 },
                new double[] { 900, 100, 0.09 },
                new double[] { 1000, 100, 0.07 },
                new double[] { 1100, 100, 0.07 },
                new double[] { 1200, 100, 0.6 },
                new double[] { 1300, 100, 0.05 },
                new double[] { 1400, 100, 0.05 },
                new double[] { 1500, 100, 0.04 },
                new double[] { 100, 150, 1.4 },
                new double[] { 150, 150, 1.11 },
                new double[] { 200, 150, 0.81 },
                new double[] { 300, 150, 0.61 },
                new double[] { 400, 150, 0.42 },
                new double[] { 500, 150, 0.29 },
                new double[] { 600, 150, 0.26 },
                new double[] { 700, 150, 0.18 },
                new double[] { 800, 150, 0.17 },
                new double[] { 900, 150, 0.09 },
                new double[] { 1000, 150, 0.07 },
                new double[] { 1100, 150, 0.07 },
                new double[] { 1200, 150, 0.6 },
                new double[] { 1300, 150, 0.05 },
                new double[] { 1400, 150, 0.05 },
                new double[] { 1500, 150, 0.04 },
                new double[] { 100, 200, 1.28 },
                new double[] { 150, 200, 0.94 },
                new double[] { 200, 200, 0.72 },
                new double[] { 300, 200, 0.53 },
                new double[] { 400, 200, 0.38 },
                new double[] { 500, 200, 0.27 },
                new double[] { 600, 200, 0.24 },
                new double[] { 700, 200, 0.17 },
                new double[] { 800, 200, 0.16 },
                new double[] { 900, 200, 0.09 },
                new double[] { 1000, 200, 0.07 },
                new double[] { 1100, 200, 0.07 },
                new double[] { 1200, 200, 0.6 },
                new double[] { 1300, 200, 0.05 },
                new double[] { 1400, 200, 0.05 },
                new double[] { 1500, 200, 0.04 },
                new double[] { 100, 300, 1.1 },
                new double[] { 150, 300, 0.81 },
                new double[] { 200, 300, 0.63 },
                new double[] { 300, 300, 0.45 },
                new double[] { 400, 300, 0.34 },
                new double[] { 500, 300, 0.25 },
                new double[] { 600, 300, 0.22 },
                new double[] { 700, 300, 0.16 },
                new double[] { 800, 300, 0.15 },
                new double[] { 900, 300, 0.09 },
                new double[] { 1000, 300, 0.07 },
                new double[] { 1100, 300, 0.07 },
                new double[] { 1200, 300, 0.6 },
                new double[] { 1300, 300, 0.05 },
                new double[] { 1400, 300, 0.05 },
                new double[] { 1500, 300, 0.04 },
                new double[] { 100, 400, 0.95 },
                new double[] { 150, 400, 0.71 },
                new double[] { 200, 400, 0.56 },
                new double[] { 300, 400, 0.37 },
                new double[] { 400, 400, 0.3 },
                new double[] { 500, 400, 0.23 },
                new double[] { 600, 400, 0.2 },
                new double[] { 700, 400, 0.15 },
                new double[] { 800, 400, 0.14 },
                new double[] { 900, 400, 0.08 },
                new double[] { 1000, 400, 0.07 },
                new double[] { 1100, 400, 0.07 },
                new double[] { 1200, 400, 0.6 },
                new double[] { 1300, 400, 0.05 },
                new double[] { 1400, 400, 0.05 },
                new double[] { 1500, 400, 0.04 },
                new double[] { 100, 500, 0.83 },
                new double[] { 150, 500, 0.63 },
                new double[] { 200, 500, 0.52 },
                new double[] { 300, 500, 0.33 },
                new double[] { 400, 500, 0.26 },
                new double[] { 500, 500, 0.21 },
                new double[] { 600, 500, 0.18 },
                new double[] { 700, 500, 0.14 },
                new double[] { 800, 500, 0.13 },
                new double[] { 900, 500, 0.08 },
                new double[] { 1000, 500, 0.07 },
                new double[] { 1100, 500, 0.07 },
                new double[] { 1200, 500, 0.6 },
                new double[] { 1300, 500, 0.05 },
                new double[] { 1400, 500, 0.05 },
                new double[] { 1500, 500, 0.04 },
                new double[] { 100, 600, 0.77 },
                new double[] { 150, 600, 0.6 },
                new double[] { 200, 600, 0.48 },
                new double[] { 300, 600, 0.32 },
                new double[] { 400, 600, 0.25 },
                new double[] { 500, 600, 0.19 },
                new double[] { 600, 600, 0.16 },
                new double[] { 700, 600, 0.13 },
                new double[] { 800, 600, 0.12 },
                new double[] { 900, 600, 0.08 },
                new double[] { 1000, 600, 0.07 },
                new double[] { 1100, 600, 0.07 },
                new double[] { 1200, 600, 0.6 },
                new double[] { 1300, 600, 0.05 },
                new double[] { 1400, 600, 0.05 },
                new double[] { 1500, 600, 0.04 },
                new double[] { 100, 700, 0.71 },
                new double[] { 150, 700, 0.54 },
                new double[] { 200, 700, 0.44 },
                new double[] { 300, 700, 0.31 },
                new double[] { 400, 700, 0.24 },
                new double[] { 500, 700, 0.19 },
                new double[] { 600, 700, 0.14 },
                new double[] { 700, 700, 0.12 },
                new double[] { 800, 700, 0.11 },
                new double[] { 900, 700, 0.08 },
                new double[] { 1000, 700, 0.07 },
                new double[] { 1100, 700, 0.07 },
                new double[] { 1200, 700, 0.6 },
                new double[] { 1300, 700, 0.05 },
                new double[] { 1400, 700, 0.05 },
                new double[] { 1500, 700, 0.04 },
                new double[] { 100, 800, 0.65 },
                new double[] { 150, 800, 0.48 },
                new double[] { 200, 800, 0.42 },
                new double[] { 300, 800, 0.3 },
                new double[] { 400, 800, 0.23 },
                new double[] { 500, 800, 0.18 },
                new double[] { 600, 800, 0.13 },
                new double[] { 700, 800, 0.11 },
                new double[] { 800, 800, 0.1 },
                new double[] { 900, 800, 0.08 },
                new double[] { 1000, 800, 0.07 },
                new double[] { 1100, 800, 0.07 },
                new double[] { 1200, 800, 0.6 },
                new double[] { 1300, 800, 0.05 },
                new double[] { 1400, 800, 0.05 },
                new double[] { 1500, 800, 0.04 },
                new double[] { 100, 900, 0.59 },
                new double[] { 150, 900, 0.44 },
                new double[] { 200, 900, 0.4 },
                new double[] { 300, 900, 0.29 },
                new double[] { 400, 900, 0.22 },
                new double[] { 500, 900, 0.17 },
                new double[] { 600, 900, 0.12 },
                new double[] { 700, 900, 0.1 },
                new double[] { 800, 900, 0.09 },
                new double[] { 900, 900, 0.08 },
                new double[] { 1000, 900, 0.07 },
                new double[] { 1100, 900, 0.07 },
                new double[] { 1200, 900, 0.6 },
                new double[] { 1300, 900, 0.05 },
                new double[] { 1400, 900, 0.05 },
                new double[] { 1500, 900, 0.04 },
                new double[] { 100, 1000, 0.53 },
                new double[] { 150, 1000, 0.42 },
                new double[] { 200, 1000, 0.38 },
                new double[] { 300, 1000, 0.29 },
                new double[] { 400, 1000, 0.22 },
                new double[] { 500, 1000, 0.17 },
                new double[] { 600, 1000, 0.11 },
                new double[] { 700, 1000, 0.09 },
                new double[] { 800, 1000, 0.08 },
                new double[] { 900, 1000, 0.07 },
                new double[] { 1000, 1000, 0.07 },
                new double[] { 1100, 1000, 0.07 },
                new double[] { 1200, 1000, 0.6 },
                new double[] { 1300, 1000, 0.05 },
                new double[] { 1400, 1000, 0.05 },
                new double[] { 1500, 1000, 0.04 },
                new double[] { 100, 1100, 0.47 },
                new double[] { 150, 1100, 0.41 },
                new double[] { 200, 1100, 0.37 },
                new double[] { 300, 1100, 0.28 },
                new double[] { 400, 1100, 0.21 },
                new double[] { 500, 1100, 0.16 },
                new double[] { 600, 1100, 0.11 },
                new double[] { 700, 1100, 0.09 },
                new double[] { 800, 1100, 0.08 },
                new double[] { 900, 1100, 0.07 },
                new double[] { 1000, 1100, 0.07 },
                new double[] { 1100, 1100, 0.07 },
                new double[] { 1200, 1100, 0.6 },
                new double[] { 1300, 1100, 0.05 },
                new double[] { 1400, 1100, 0.05 },
                new double[] { 1500, 1100, 0.04 },
                new double[] { 100, 1200, 0.41 },
                new double[] { 150, 1200, 0.4 },
                new double[] { 200, 1200, 0.36 },
                new double[] { 300, 1200, 0.27 },
                new double[] { 400, 1200, 0.2 },
                new double[] { 500, 1200, 0.15 },
                new double[] { 600, 1200, 0.1 },
                new double[] { 700, 1200, 0.08 },
                new double[] { 800, 1200, 0.08 },
                new double[] { 900, 1200, 0.07 },
                new double[] { 1000, 1200, 0.07 },
                new double[] { 1100, 1200, 0.07 },
                new double[] { 1200, 1200, 0.06 },
                new double[] { 1300, 1200, 0.05 },
                new double[] { 1400, 1200, 0.05 },
                new double[] { 1500, 1200, 0.04 },
                new double[] { 100, 1300, 0.35 },
                new double[] { 150, 1300, 0.39 },
                new double[] { 200, 1300, 0.34 },
                new double[] { 300, 1300, 0.26 },
                new double[] { 400, 1300, 0.19 },
                new double[] { 500, 1300, 0.14 },
                new double[] { 600, 1300, 0.1 },
                new double[] { 700, 1300, 0.09 },
                new double[] { 800, 1300, 0.08 },
                new double[] { 900, 1300, 0.07 },
                new double[] { 1000, 1300, 0.07 },
                new double[] { 1100, 1300, 0.06 },
                new double[] { 1200, 1300, 0.06 },
                new double[] { 1300, 1300, 0.05 },
                new double[] { 1400, 1300, 0.05 },
                new double[] { 1500, 1300, 0.04 },
                new double[] { 100, 1400, 0.29 },
                new double[] { 150, 1400, 0.38 },
                new double[] { 200, 1400, 0.33 },
                new double[] { 300, 1400, 0.25 },
                new double[] { 400, 1400, 0.18 },
                new double[] { 500, 1400, 0.13 },
                new double[] { 600, 1400, 0.1 },
                new double[] { 700, 1400, 0.09 },
                new double[] { 800, 1400, 0.08 },
                new double[] { 900, 1400, 0.07 },
                new double[] { 1000, 1400, 0.07 },
                new double[] { 1100, 1400, 0.06 },
                new double[] { 1200, 1400, 0.06 },
                new double[] { 1300, 1400, 0.05 },
                new double[] { 1400, 1400, 0.05 },
                new double[] { 1500, 1400, 0.04 },
                new double[] { 100, 1500, 0.23 },
                new double[] { 150, 1500, 0.38 },
                new double[] { 200, 1500, 0.33 },
                new double[] { 300, 1500, 0.25 },
                new double[] { 400, 1500, 0.18 },
                new double[] { 500, 1500, 0.13 },
                new double[] { 600, 1500, 0.07 },
                new double[] { 700, 1500, 0.09 },
                new double[] { 800, 1500, 0.08 },
                new double[] { 900, 1500, 0.07 },
                new double[] { 1000, 1500, 0.07 },
                new double[] { 1100, 1500, 0.06 },
                new double[] { 1200, 1500, 0.06 },
                new double[] { 1300, 1500, 0.05 },
                new double[] { 1400, 1500, 0.05 },
                new double[] { 1500, 1500, 0.04 }
            };

            double rez = 1.53;

            double a = (Math.Round(width / ((double)50))) * ((double)50);
            double b = (Math.Round(height / ((double)50))) * ((double)50);

            foreach (double[] str in table_kms)
            {
                if ( (str[0] == a) && (str[1] == b) ) rez = str[2];
            }

            return rez;
        }

        private double Take_kms_2(double diameter)
        {
            double rez = Take_kms(diameter, diameter);

            return rez;
        }

        protected override void Refresh_marka()
        {
            if (_forma_sechenia == "rectangle")
            {
                _marka = "ОКСИД" + "-" + _width_mm.ToString() + "x" + _height_mm.ToString() + "-" + "2*ф-Н-0-0";
            }
            else
            {
                _marka = "КИДМ" + "-" + _diameter_mm.ToString();
            }
        }
        public void SetMarka()
        {
            Refresh_marka();
        }

        public Klapan_izbitochnogo_davlenia(double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated)
       : base("Клапан избыточного давления", "", rashod_m3_in_hour, width_mm, height_mm, rotated, 0)
        {
            SetMarka();
            _kms = Take_kms(_width_mm, _height_mm);
        }

        public Klapan_izbitochnogo_davlenia(double rashod_m3_in_hour, double diameter_mm)
            : base("Клапан избыточного давления", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            SetMarka();
            _kms = Take_kms_2(_diameter_mm);
        }

        protected override void Refresh_kms()
        {
            if (_forma_sechenia == "rectangle")
            {
                _kms = Take_kms(_width_mm, _height_mm);
            }
            else
            {
                _kms = Take_kms_2(_diameter_mm);
            }
        }
    }
}
