using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Obratniy_klapan_s_elektroprivodom : Mestnoe_soprotivlenie
    {
        public override string Name
        {
            get
            {
                System.Windows.Forms.MessageBox.Show(_forma_sechenia);

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

                return ("Обратный клапан (Сигмавент) с электроприводом " + s_razmeri);
            }
        }
        private double Take_kms()
        {
            if ((_width_mm <= 0) || (_height_mm <= 0)) return 0;

            double[][] table_kms =
            {
                new double[] { 150, 150, 7.43 },
                new double[] { 150, 200, 4.29 },
                new double[] { 150, 250, 3.13 },
                new double[] { 150, 300, 2.54 },
                new double[] { 150, 350, 1.82 },
                new double[] { 150, 400, 1.62 },
                new double[] { 150, 450, 1.26 },
                new double[] { 150, 500, 1.16 },
                new double[] { 150, 550, 0.92 },
                new double[] { 150, 600, 0.88 },
                new double[] { 150, 650, 0.72 },
                new double[] { 150, 700, 0.74 },
                new double[] { 150, 750, 0.57 },
                new double[] { 150, 800, 0.55 },
                new double[] { 150, 850, 0.47 },
                new double[] { 150, 900, 0.52 },
                new double[] { 150, 950, 0.44 },
                new double[] { 150, 1000, 0.43 },
                new double[] { 200, 150, 5.7 },
                new double[] { 200, 200, 3.18 },
                new double[] { 200, 250, 2.26 },
                new double[] { 200, 300, 1.8 },
                new double[] { 200, 350, 1.52 },
                new double[] { 200, 400, 1.34 },
                new double[] { 200, 450, 1.11 },
                new double[] { 200, 500, 1.02 },
                new double[] { 200, 550, 0.84 },
                new double[] { 200, 600, 0.8 },
                new double[] { 200, 650, 0.67 },
                new double[] { 200, 700, 0.68 },
                new double[] { 200, 750, 0.54 },
                new double[] { 200, 800, 0.52 },
                new double[] { 200, 850, 0.45 },
                new double[] { 200, 900, 0.49 },
                new double[] { 200, 950, 0.42 },
                new double[] { 200, 1000, 0.41 },
                new double[] { 250, 150, 4.88 },
                new double[] { 250, 200, 2.66 },
                new double[] { 250, 250, 1.86 },
                new double[] { 250, 300, 1.46 },
                new double[] { 250, 350, 1.22 },
                new double[] { 250, 400, 1.06 },
                new double[] { 250, 450, 0.96 },
                new double[] { 250, 500, 0.88 },
                new double[] { 250, 550, 0.76 },
                new double[] { 250, 600, 0.72 },
                new double[] { 250, 650, 0.62 },
                new double[] { 250, 700, 0.62 },
                new double[] { 250, 750, 0.51 },
                new double[] { 250, 800, 0.49 },
                new double[] { 250, 850, 0.43 },
                new double[] { 250, 900, 0.46 },
                new double[] { 250, 950, 0.4 },
                new double[] { 250, 1000, 0.39 },
                new double[] { 300, 150, 4.41 },
                new double[] { 300, 200, 2.37 },
                new double[] { 300, 250, 1.63 },
                new double[] { 300, 300, 1.26 },
                new double[] { 300, 350, 1.05 },
                new double[] { 300, 400, 0.91 },
                new double[] { 300, 450, 0.81 },
                new double[] { 300, 500, 0.74 },
                new double[] { 300, 550, 0.68 },
                new double[] { 300, 600, 0.64 },
                new double[] { 300, 650, 0.57 },
                new double[] { 300, 700, 0.56 },
                new double[] { 300, 750, 0.48 },
                new double[] { 300, 800, 0.46 },
                new double[] { 300, 850, 0.41 },
                new double[] { 300, 900, 0.43 },
                new double[] { 300, 950, 0.38 },
                new double[] { 300, 1000, 0.37 },
                new double[] { 350, 150, 4.1 },
                new double[] { 350, 200, 2.17 },
                new double[] { 350, 250, 1.48 },
                new double[] { 350, 300, 1.14 },
                new double[] { 350, 350, 0.94 },
                new double[] { 350, 400, 0.81 },
                new double[] { 350, 450, 0.72 },
                new double[] { 350, 500, 0.65 },
                new double[] { 350, 550, 0.6 },
                new double[] { 350, 600, 0.56 },
                new double[] { 350, 650, 0.52 },
                new double[] { 350, 700, 0.5 },
                new double[] { 350, 750, 0.45 },
                new double[] { 350, 800, 0.43 },
                new double[] { 350, 850, 0.39 },
                new double[] { 350, 900, 0.4 },
                new double[] { 350, 950, 0.36 },
                new double[] { 350, 1000, 0.35 },
                new double[] { 400, 150, 3.88 },
                new double[] { 400, 200, 2.04 },
                new double[] { 400, 250, 1.38 },
                new double[] { 400, 300, 1.05 },
                new double[] { 400, 350, 0.86 },
                new double[] { 400, 400, 0.74 },
                new double[] { 400, 450, 0.65 },
                new double[] { 400, 500, 0.59 },
                new double[] { 400, 550, 0.54 },
                new double[] { 400, 600, 0.5 },
                new double[] { 400, 650, 0.47 },
                new double[] { 400, 700, 0.44 },
                new double[] { 400, 750, 0.42 },
                new double[] { 400, 800, 0.4 },
                new double[] { 400, 850, 0.37 },
                new double[] { 400, 900, 0.37 },
                new double[] { 400, 950, 0.34 },
                new double[] { 400, 1000, 0.33 },
                new double[] { 450, 150, 3.72 },
                new double[] { 450, 200, 1.94 },
                new double[] { 450, 250, 1.3 },
                new double[] { 450, 300, 0.99 },
                new double[] { 450, 350, 0.81 },
                new double[] { 450, 400, 0.69 },
                new double[] { 450, 450, 0.6 },
                new double[] { 450, 500, 0.54 },
                new double[] { 450, 550, 0.5 },
                new double[] { 450, 600, 0.46 },
                new double[] { 450, 650, 0.43 },
                new double[] { 450, 700, 0.41 },
                new double[] { 450, 750, 0.39 },
                new double[] { 450, 800, 0.37 },
                new double[] { 450, 850, 0.35 },
                new double[] { 450, 900, 0.34 },
                new double[] { 450, 950, 0.32 },
                new double[] { 450, 1000, 0.31 },
                new double[] { 500, 150, 3.6 },
                new double[] { 500, 200, 1.87 },
                new double[] { 500, 250, 1.25 },
                new double[] { 500, 300, 0.94 },
                new double[] { 500, 350, 0.76 },
                new double[] { 500, 400, 0.65 },
                new double[] { 500, 450, 0.57 },
                new double[] { 500, 500, 0.51 },
                new double[] { 500, 550, 0.46 },
                new double[] { 500, 600, 0.43 },
                new double[] { 500, 650, 0.4 },
                new double[] { 500, 700, 0.38 },
                new double[] { 500, 750, 0.36 },
                new double[] { 500, 800, 0.34 },
                new double[] { 500, 850, 0.33 },
                new double[] { 500, 900, 0.31 },
                new double[] { 500, 950, 0.3 },
                new double[] { 500, 1000, 0.29 },
                new double[] { 550, 150, 3.5 },
                new double[] { 550, 200, 1.81 },
                new double[] { 550, 250, 1.2 },
                new double[] { 550, 300, 0.9 },
                new double[] { 550, 350, 0.73 },
                new double[] { 550, 400, 0.62 },
                new double[] { 550, 450, 0.54 },
                new double[] { 550, 500, 0.48 },
                new double[] { 550, 550, 0.44 },
                new double[] { 550, 600, 0.4 },
                new double[] { 550, 650, 0.38 },
                new double[] { 550, 700, 0.35 },
                new double[] { 550, 750, 0.33 },
                new double[] { 550, 800, 0.32 },
                new double[] { 550, 850, 0.3 },
                new double[] { 550, 900, 0.29 },
                new double[] { 550, 950, 0.28 },
                new double[] { 550, 1000, 0.27 },
                new double[] { 600, 150, 3.43 },
                new double[] { 600, 200, 1.76 },
                new double[] { 600, 250, 1.16 },
                new double[] { 600, 300, 0.87 },
                new double[] { 600, 350, 0.7 },
                new double[] { 600, 400, 0.59 },
                new double[] { 600, 450, 0.52 },
                new double[] { 600, 500, 0.46 },
                new double[] { 600, 550, 0.42 },
                new double[] { 600, 600, 0.38 },
                new double[] { 600, 650, 0.36 },
                new double[] { 600, 700, 0.34 },
                new double[] { 600, 750, 0.32 },
                new double[] { 600, 800, 0.3 },
                new double[] { 600, 850, 0.29 },
                new double[] { 600, 900, 0.28 },
                new double[] { 600, 950, 0.27 },
                new double[] { 600, 1000, 0.26 },
                new double[] { 650, 150, 3.36 },
                new double[] { 650, 200, 1.72 },
                new double[] { 650, 250, 1.13 },
                new double[] { 650, 300, 0.85 },
                new double[] { 650, 350, 0.68 },
                new double[] { 650, 400, 0.57 },
                new double[] { 650, 450, 0.5 },
                new double[] { 650, 500, 0.44 },
                new double[] { 650, 550, 0.4 },
                new double[] { 650, 600, 0.37 },
                new double[] { 650, 650, 0.34 },
                new double[] { 650, 700, 0.32 },
                new double[] { 650, 750, 0.3 },
                new double[] { 650, 800, 0.29 },
                new double[] { 650, 850, 0.27 },
                new double[] { 650, 900, 0.26 },
                new double[] { 650, 950, 0.25 },
                new double[] { 650, 1000, 0.24 },
                new double[] { 700, 150, 3.31 },
                new double[] { 700, 200, 1.68 },
                new double[] { 700, 250, 1.11 },
                new double[] { 700, 300, 0.83 },
                new double[] { 700, 350, 0.66 },
                new double[] { 700, 400, 0.56 },
                new double[] { 700, 450, 0.48 },
                new double[] { 700, 500, 0.43 },
                new double[] { 700, 550, 0.39 },
                new double[] { 700, 600, 0.36 },
                new double[] { 700, 650, 0.33 },
                new double[] { 700, 700, 0.31 },
                new double[] { 700, 750, 0.29 },
                new double[] { 700, 800, 0.28 },
                new double[] { 700, 850, 0.26 },
                new double[] { 700, 900, 0.25 },
                new double[] { 700, 950, 0.24 },
                new double[] { 700, 1000, 0.23 },
                new double[] { 750, 150, 3.26 },
                new double[] { 750, 200, 1.66 },
                new double[] { 750, 250, 1.09 },
                new double[] { 750, 300, 0.81 },
                new double[] { 750, 350, 0.65 },
                new double[] { 750, 400, 0.54 },
                new double[] { 750, 450, 0.47 },
                new double[] { 750, 500, 0.42 },
                new double[] { 750, 550, 0.38 },
                new double[] { 750, 600, 0.34 },
                new double[] { 750, 650, 0.32 },
                new double[] { 750, 700, 0.3 },
                new double[] { 750, 750, 0.28 },
                new double[] { 750, 800, 0.27 },
                new double[] { 750, 850, 0.25 },
                new double[] { 750, 900, 0.24 },
                new double[] { 750, 950, 0.23 },
                new double[] { 750, 1000, 0.22 },
                new double[] { 800, 150, 3.22 },
                new double[] { 800, 200, 1.63 },
                new double[] { 800, 250, 1.07 },
                new double[] { 800, 300, 0.79 },
                new double[] { 800, 350, 0.63 },
                new double[] { 800, 400, 0.53 },
                new double[] { 800, 450, 0.46 },
                new double[] { 800, 500, 0.41 },
                new double[] { 800, 550, 0.37 },
                new double[] { 800, 600, 0.33 },
                new double[] { 800, 650, 0.31 },
                new double[] { 800, 700, 0.29 },
                new double[] { 800, 750, 0.27 },
                new double[] { 800, 800, 0.26 },
                new double[] { 800, 850, 0.24 },
                new double[] { 800, 900, 0.23 },
                new double[] { 800, 950, 0.22 },
                new double[] { 800, 1000, 0.22 },
                new double[] { 850, 150, 3.18 },
                new double[] { 850, 200, 1.61 },
                new double[] { 850, 250, 1.05 },
                new double[] { 850, 300, 0.78 },
                new double[] { 850, 350, 0.62 },
                new double[] { 850, 400, 0.52 },
                new double[] { 850, 450, 0.45 },
                new double[] { 850, 500, 0.4 },
                new double[] { 850, 550, 0.36 },
                new double[] { 850, 600, 0.33 },
                new double[] { 850, 650, 0.3 },
                new double[] { 850, 700, 0.28 },
                new double[] { 850, 750, 0.26 },
                new double[] { 850, 800, 0.25 },
                new double[] { 850, 850, 0.24 },
                new double[] { 850, 900, 0.23 },
                new double[] { 850, 950, 0.22 },
                new double[] { 850, 1000, 0.21 },
                new double[] { 900, 150, 3.15 },
                new double[] { 900, 200, 1.59 },
                new double[] { 900, 250, 1.04 },
                new double[] { 900, 300, 0.77 },
                new double[] { 900, 350, 0.61 },
                new double[] { 900, 400, 0.51 },
                new double[] { 900, 450, 0.44 },
                new double[] { 900, 500, 0.39 },
                new double[] { 900, 550, 0.35 },
                new double[] { 900, 600, 0.32 },
                new double[] { 900, 650, 0.29 },
                new double[] { 900, 700, 0.27 },
                new double[] { 900, 750, 0.26 },
                new double[] { 900, 800, 0.24 },
                new double[] { 900, 850, 0.23 },
                new double[] { 900, 900, 0.22 },
                new double[] { 900, 950, 0.21 },
                new double[] { 900, 1000, 0.2 },
                new double[] { 950, 150, 3.12 },
                new double[] { 950, 200, 1.57 },
                new double[] { 950, 250, 1.02 },
                new double[] { 950, 300, 0.76 },
                new double[] { 950, 350, 0.6 },
                new double[] { 950, 400, 0.5 },
                new double[] { 950, 450, 0.43 },
                new double[] { 950, 500, 0.38 },
                new double[] { 950, 550, 0.34 },
                new double[] { 950, 600, 0.31 },
                new double[] { 950, 650, 0.29 },
                new double[] { 950, 700, 0.27 },
                new double[] { 950, 750, 0.25 },
                new double[] { 950, 800, 0.24 },
                new double[] { 950, 850, 0.22 },
                new double[] { 950, 900, 0.21 },
                new double[] { 950, 950, 0.2 },
                new double[] { 950, 1000, 0.2 },
                new double[] { 1000, 150, 3.1 },
                new double[] { 1000, 200, 1.56 },
                new double[] { 1000, 250, 1.01 },
                new double[] { 1000, 300, 0.75 },
                new double[] { 1000, 350, 0.59 },
                new double[] { 1000, 400, 0.49 },
                new double[] { 1000, 450, 0.42 },
                new double[] { 1000, 500, 0.37 },
                new double[] { 1000, 550, 0.34 },
                new double[] { 1000, 600, 0.31 },
                new double[] { 1000, 650, 0.28 },
                new double[] { 1000, 700, 0.26 },
                new double[] { 1000, 750, 0.25 },
                new double[] { 1000, 800, 0.23 },
                new double[] { 1000, 850, 0.22 },
                new double[] { 1000, 900, 0.21 },
                new double[] { 1000, 950, 0.2 },
                new double[] { 1000, 1000, 0.19 },
                new double[] { 1050, 150, 3.08 },
                new double[] { 1050, 200, 1.54 },
                new double[] { 1050, 250, 1 },
                new double[] { 1050, 300, 0.74 },
                new double[] { 1050, 350, 0.59 },
                new double[] { 1050, 400, 0.49 },
                new double[] { 1050, 450, 0.42 },
                new double[] { 1050, 500, 0.37 },
                new double[] { 1050, 550, 0.33 },
                new double[] { 1050, 600, 0.3 },
                new double[] { 1050, 650, 0.28 },
                new double[] { 1050, 700, 0.26 },
                new double[] { 1050, 750, 0.24 },
                new double[] { 1050, 800, 0.23 },
                new double[] { 1050, 850, 0.21 },
                new double[] { 1050, 900, 0.2 },
                new double[] { 1050, 950, 0.2 },
                new double[] { 1050, 1000, 0.2 },
                new double[] { 1100, 150, 3.06 },
                new double[] { 1100, 200, 1.53 },
                new double[] { 1100, 250, 0.99 },
                new double[] { 1100, 300, 0.73 },
                new double[] { 1100, 350, 0.58 },
                new double[] { 1100, 400, 0.48 },
                new double[] { 1100, 450, 0.41 },
                new double[] { 1100, 500, 0.36 },
                new double[] { 1100, 550, 0.33 },
                new double[] { 1100, 600, 0.3 },
                new double[] { 1100, 650, 0.27 },
                new double[] { 1100, 700, 0.25 },
                new double[] { 1100, 750, 0.24 },
                new double[] { 1100, 800, 0.22 },
                new double[] { 1100, 850, 0.21 },
                new double[] { 1100, 900, 0.2 },
                new double[] { 1100, 950, 0.2 },
                new double[] { 1100, 1000, 0.2 }
            };

            double a = (Math.Round(_width_mm / ((double)50))) * ((double)50);
            double b = (Math.Round(_height_mm / ((double)50))) * ((double)50);

            if (a < 150) a = 150;

            if (b < 150) b = 150;

            if (a > 1100) a = 1100;

            if (b > 1000) b = 1000;

            double rez = 7.43;

            foreach (double[] str in table_kms)
            {
                if ((str[0] == a) && (str[1] == b)) rez = str[2];
            }

            return rez;
        }

        private double Take_kms_2()
        {
            if (_diameter_mm <= 0) return 0;

            double[][] table_kms =
            {
                new double[] { 100, 1.2 },
                new double[] { 125, 1.2 },
                new double[] { 140, 1.2 },
                new double[] { 160, 1.2 },
                new double[] { 180, 1.2 },
                new double[] { 200, 1.2 },
                new double[] { 219, 1.2 },
                new double[] { 250, 1.2 },
                new double[] { 315, 1.2 },
                new double[] { 325, 1.2 },
                new double[] { 355, 1.2 },
                new double[] { 400, 1.23 },
                new double[] { 426, 1.26 },
                new double[] { 450, 1.26 },
                new double[] { 500, 1.28 },
                new double[] { 530, 1.31 },
                new double[] { 560, 1.31 },
                new double[] { 630, 1.33 },
                new double[] { 710, 1.35 },
                new double[] { 800, 1.37 },
                new double[] { 820, 1.38 },
                new double[] { 900, 1.38 },
                new double[] { 1000, 1.39 },
                new double[] { 1020, 1.392 },
                new double[] { 1120, 1.402 },
                new double[] { 1220, 1.412 },
                new double[] { 1250, 1.415 },
                new double[] { 1400, 1.43 },
                new double[] { 1420, 1.432 },
                new double[] { 1600, 1.45 },
                new double[] { 1620, 1.452 },
                new double[] { 1800, 1.47 },
                new double[] { 2000, 1.49 }
            };

            double d = _diameter_mm;

            double rez = 1.49;

            foreach (double[] str in table_kms)
            {
                if (d <= str[0])
                {
                    return str[1];
                }

                rez = str[1];
            }

            return rez;
        }
        protected override void Refresh_marka()
        {
            if (_forma_sechenia == "rectangle")
            {
                _marka = "Сигмавент-120-НЗ(КОМ)" + "-" + _width_mm.ToString() + "x" + _height_mm.ToString() + "-" + "ВЕ(220)-2";
            }
            else
            {
                _marka = "Сигмавент-120-НЗ(КОМ)" + "-" + _diameter_mm.ToString() + "-" + "ВЕ(220)-2";
            }
        }
        public void SetMarka()
        {
            Refresh_marka();
        }

        public Obratniy_klapan_s_elektroprivodom(double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated)
       : base("Клапан обратный с электроприводом", "", rashod_m3_in_hour, width_mm, height_mm, rotated, 0)
        {
            SetMarka();
            _kms = Take_kms();
        }

        public Obratniy_klapan_s_elektroprivodom(double rashod_m3_in_hour, double diameter_mm)
            : base("Клапан обратный с электроприводом", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            SetMarka();
            _kms = Take_kms_2();
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
    }
}
