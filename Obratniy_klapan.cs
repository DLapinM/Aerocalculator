using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Obratniy_klapan : Mestnoe_soprotivlenie
    {
        private int _polojenie_1_gor_2_ver;

        public void Set_polojenie(int polojenie_1_gor_2_ver)
        {
            if (polojenie_1_gor_2_ver == 1) _polojenie_1_gor_2_ver = polojenie_1_gor_2_ver;
            else _polojenie_1_gor_2_ver = 2;
        }

        public override string Name
        {
            get
            {
                string s_polojenie;
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

                if (_polojenie_1_gor_2_ver == 2)
                {
                    s_polojenie = "на вертикальном участке";
                }
                else
                {
                    s_polojenie = "на горизонтальном участке";
                }

                return ("Обратный клапан " + s_polojenie + " " + s_razmeri);
            }
        }
        private double Take_kms()
        {
            double[][] table_kms =
            {
                new double[] { 1, 0, 20.42 },
                new double[] { 1, 0.1, 20.42 },
                new double[] { 1, 0.2, 20.42 },
                new double[] { 1, 0.3, 20.42 },
                new double[] { 1, 0.4, 20.42 },
                new double[] { 1, 0.5, 20.42 },
                new double[] { 1, 0.6, 20.42 },
                new double[] { 1, 0.7, 20.42 },
                new double[] { 1, 0.8, 20.42 },
                new double[] { 1, 0.9, 20.42 },
                new double[] { 1, 1, 20.42 },
                new double[] { 1, 1.1, 20.42 },
                new double[] { 1, 1.2, 20.42 },
                new double[] { 1, 1.3, 20.42 },
                new double[] { 1, 1.4, 20.42 },
                new double[] { 1, 1.5, 20.42 },
                new double[] { 1, 1.6, 20.42 },
                new double[] { 1, 1.7, 20.42 },
                new double[] { 1, 1.8, 20.42 },
                new double[] { 1, 1.9, 20.42 },
                new double[] { 1, 2, 20.42 },
                new double[] { 1, 2.1, 18.97 },
                new double[] { 1, 2.2, 17.7 },
                new double[] { 1, 2.3, 16.57 },
                new double[] { 1, 2.4, 15.57 },
                new double[] { 1, 2.5, 14.67 },
                new double[] { 1, 2.6, 13.86 },
                new double[] { 1, 2.7, 13.12 },
                new double[] { 1, 2.8, 12.46 },
                new double[] { 1, 2.9, 11.85 },
                new double[] { 1, 3, 11.3 },
                new double[] { 1, 3.1, 10.7 },
                new double[] { 1, 3.2, 10.16 },
                new double[] { 1, 3.3, 9.66 },
                new double[] { 1, 3.4, 9.2 },
                new double[] { 1, 3.5, 8.78 },
                new double[] { 1, 3.6, 8.38 },
                new double[] { 1, 3.7, 8.02 },
                new double[] { 1, 3.8, 7.69 },
                new double[] { 1, 3.9, 7.37 },
                new double[] { 1, 4, 7.08 },
                new double[] { 1, 4.1, 6.8 },
                new double[] { 1, 4.2, 6.54 },
                new double[] { 1, 4.3, 6.29 },
                new double[] { 1, 4.4, 6.06 },
                new double[] { 1, 4.5, 5.84 },
                new double[] { 1, 4.6, 5.64 },
                new double[] { 1, 4.7, 5.45 },
                new double[] { 1, 4.8, 5.27 },
                new double[] { 1, 4.9, 5.1 },
                new double[] { 1, 5, 4.93 },
                new double[] { 1, 5.1, 4.77 },
                new double[] { 1, 5.2, 4.62 },
                new double[] { 1, 5.3, 4.48 },
                new double[] { 1, 5.4, 4.34 },
                new double[] { 1, 5.5, 4.21 },
                new double[] { 1, 5.6, 4.09 },
                new double[] { 1, 5.7, 3.98 },
                new double[] { 1, 5.8, 3.86 },
                new double[] { 1, 5.9, 3.76 },
                new double[] { 1, 6, 3.66 },
                new double[] { 1, 6.1, 3.56 },
                new double[] { 1, 6.2, 3.46 },
                new double[] { 1, 6.3, 3.37 },
                new double[] { 1, 6.4, 3.28 },
                new double[] { 1, 6.5, 3.2 },
                new double[] { 1, 6.6, 3.11 },
                new double[] { 1, 6.7, 3.04 },
                new double[] { 1, 6.8, 2.96 },
                new double[] { 1, 6.9, 2.89 },
                new double[] { 1, 7, 2.82 },
                new double[] { 1, 7.1, 2.76 },
                new double[] { 1, 7.2, 2.69 },
                new double[] { 1, 7.3, 2.63 },
                new double[] { 1, 7.4, 2.57 },
                new double[] { 1, 7.5, 2.52 },
                new double[] { 1, 7.6, 2.46 },
                new double[] { 1, 7.7, 2.41 },
                new double[] { 1, 7.8, 2.36 },
                new double[] { 1, 7.9, 2.31 },
                new double[] { 1, 8, 2.27 },
                new double[] { 1, 8.1, 2.22 },
                new double[] { 1, 8.2, 2.17 },
                new double[] { 1, 8.3, 2.12 },
                new double[] { 1, 8.4, 2.07 },
                new double[] { 1, 8.5, 2.03 },
                new double[] { 1, 8.6, 1.99 },
                new double[] { 1, 8.7, 1.95 },
                new double[] { 1, 8.8, 1.91 },
                new double[] { 1, 8.9, 1.87 },
                new double[] { 1, 9, 1.83 },
                new double[] { 1, 9.1, 1.8 },
                new double[] { 1, 9.2, 1.76 },
                new double[] { 1, 9.3, 1.73 },
                new double[] { 1, 9.4, 1.69 },
                new double[] { 1, 9.5, 1.66 },
                new double[] { 1, 9.6, 1.63 },
                new double[] { 1, 9.7, 1.6 },
                new double[] { 1, 9.8, 1.57 },
                new double[] { 1, 9.9, 1.54 },
                new double[] { 1, 10, 1.52 },
                new double[] { 1, 10.1, 1.49 },
                new double[] { 1, 10.2, 1.46 },
                new double[] { 1, 10.3, 1.44 },
                new double[] { 1, 10.4, 1.41 },
                new double[] { 1, 10.5, 1.39 },
                new double[] { 1, 10.6, 1.37 },
                new double[] { 1, 10.7, 1.35 },
                new double[] { 1, 10.8, 1.32 },
                new double[] { 1, 10.9, 1.3 },
                new double[] { 1, 11, 1.28 },
                new double[] { 1, 11.1, 1.26 },
                new double[] { 1, 11.2, 1.24 },
                new double[] { 1, 11.3, 1.22 },
                new double[] { 1, 11.4, 1.2 },
                new double[] { 1, 11.5, 1.18 },
                new double[] { 1, 11.6, 1.16 },
                new double[] { 1, 11.7, 1.14 },
                new double[] { 1, 11.8, 1.12 },
                new double[] { 1, 11.9, 1.11 },
                new double[] { 1, 12, 1.09 },
                new double[] { 2, 0, 43.75 },
                new double[] { 2, 0.1, 43.75 },
                new double[] { 2, 0.2, 43.75 },
                new double[] { 2, 0.3, 43.75 },
                new double[] { 2, 0.4, 43.75 },
                new double[] { 2, 0.5, 43.75 },
                new double[] { 2, 0.6, 43.75 },
                new double[] { 2, 0.7, 43.75 },
                new double[] { 2, 0.8, 43.75 },
                new double[] { 2, 0.9, 43.75 },
                new double[] { 2, 1, 43.75 },
                new double[] { 2, 1.1, 43.75 },
                new double[] { 2, 1.2, 43.75 },
                new double[] { 2, 1.3, 43.75 },
                new double[] { 2, 1.4, 43.75 },
                new double[] { 2, 1.5, 43.75 },
                new double[] { 2, 1.6, 43.75 },
                new double[] { 2, 1.7, 43.75 },
                new double[] { 2, 1.8, 43.75 },
                new double[] { 2, 1.9, 43.75 },
                new double[] { 2, 2, 43.75 },
                new double[] { 2, 2.1, 40.02 },
                new double[] { 2, 2.2, 36.78 },
                new double[] { 2, 2.3, 33.93 },
                new double[] { 2, 2.4, 31.42 },
                new double[] { 2, 2.5, 29.2 },
                new double[] { 2, 2.6, 27.22 },
                new double[] { 2, 2.7, 25.45 },
                new double[] { 2, 2.8, 23.85 },
                new double[] { 2, 2.9, 22.41 },
                new double[] { 2, 3, 21.11 },
                new double[] { 2, 3.1, 19.84 },
                new double[] { 2, 3.2, 18.68 },
                new double[] { 2, 3.3, 17.63 },
                new double[] { 2, 3.4, 16.67 },
                new double[] { 2, 3.5, 15.78 },
                new double[] { 2, 3.6, 14.97 },
                new double[] { 2, 3.7, 14.22 },
                new double[] { 2, 3.8, 13.53 },
                new double[] { 2, 3.9, 12.89 },
                new double[] { 2, 4, 12.29 },
                new double[] { 2, 4.1, 11.6 },
                new double[] { 2, 4.2, 10.96 },
                new double[] { 2, 4.3, 10.37 },
                new double[] { 2, 4.4, 9.81 },
                new double[] { 2, 4.5, 9.3 },
                new double[] { 2, 4.6, 8.82 },
                new double[] { 2, 4.7, 8.37 },
                new double[] { 2, 4.8, 7.96 },
                new double[] { 2, 4.9, 7.57 },
                new double[] { 2, 5, 7.2 },
                new double[] { 2, 5.1, 6.83 },
                new double[] { 2, 5.2, 6.48 },
                new double[] { 2, 5.3, 6.16 },
                new double[] { 2, 5.4, 5.85 },
                new double[] { 2, 5.5, 5.56 },
                new double[] { 2, 5.6, 5.29 },
                new double[] { 2, 5.7, 5.04 },
                new double[] { 2, 5.8, 4.8 },
                new double[] { 2, 5.9, 4.57 },
                new double[] { 2, 6, 4.35 },
                new double[] { 2, 6.1, 4.14 },
                new double[] { 2, 6.2, 3.94 },
                new double[] { 2, 6.3, 3.75 },
                new double[] { 2, 6.4, 3.56 },
                new double[] { 2, 6.5, 3.39 },
                new double[] { 2, 6.6, 3.23 },
                new double[] { 2, 6.7, 3.07 },
                new double[] { 2, 6.8, 2.93 },
                new double[] { 2, 6.9, 2.79 },
                new double[] { 2, 7, 2.65 },
                new double[] { 2, 7.1, 2.52 },
                new double[] { 2, 7.2, 2.39 },
                new double[] { 2, 7.3, 2.27 },
                new double[] { 2, 7.4, 2.15 },
                new double[] { 2, 7.5, 2.04 },
                new double[] { 2, 7.6, 1.94 },
                new double[] { 2, 7.7, 1.84 },
                new double[] { 2, 7.8, 1.74 },
                new double[] { 2, 7.9, 1.65 },
                new double[] { 2, 8, 1.56 },
                new double[] { 2, 8.1, 1.5 },
                new double[] { 2, 8.2, 1.43 },
                new double[] { 2, 8.3, 1.37 },
                new double[] { 2, 8.4, 1.31 },
                new double[] { 2, 8.5, 1.26 },
                new double[] { 2, 8.6, 1.2 },
                new double[] { 2, 8.7, 1.15 },
                new double[] { 2, 8.8, 1.1 },
                new double[] { 2, 8.9, 1.05 },
                new double[] { 2, 9, 1.01 },
                new double[] { 2, 9.1, 0.98 },
                new double[] { 2, 9.2, 0.96 },
                new double[] { 2, 9.3, 0.93 },
                new double[] { 2, 9.4, 0.91 },
                new double[] { 2, 9.5, 0.89 },
                new double[] { 2, 9.6, 0.86 },
                new double[] { 2, 9.7, 0.84 },
                new double[] { 2, 9.8, 0.82 },
                new double[] { 2, 9.9, 0.8 },
                new double[] { 2, 10, 0.78 },
                new double[] { 2, 10.1, 0.78 },
                new double[] { 2, 10.2, 0.77 },
                new double[] { 2, 10.3, 0.77 },
                new double[] { 2, 10.4, 0.76 },
                new double[] { 2, 10.5, 0.76 },
                new double[] { 2, 10.6, 0.75 },
                new double[] { 2, 10.7, 0.75 },
                new double[] { 2, 10.8, 0.74 },
                new double[] { 2, 10.9, 0.74 },
                new double[] { 2, 11, 0.73 },
                new double[] { 2, 11.1, 0.74 },
                new double[] { 2, 11.2, 0.74 },
                new double[] { 2, 11.3, 0.75 },
                new double[] { 2, 11.4, 0.75 },
                new double[] { 2, 11.5, 0.76 },
                new double[] { 2, 11.6, 0.76 },
                new double[] { 2, 11.7, 0.76 },
                new double[] { 2, 11.8, 0.77 },
                new double[] { 2, 11.9, 0.77 },
                new double[] { 2, 12, 0.78 }
            };

            double rez = 0.78;

            double i = (double)_polojenie_1_gor_2_ver;

            if (i != 2) i = 1;

            double f = Math.PI * Math.Pow((_diameter_mm / 1000), 2) / 4;

            double v1 = (_rashod_m3_in_hour / 3600)/(f);

            double skorost = (Math.Round(v1 * (double)10)) / (double)10;

            foreach (double[] str in table_kms)
            {
                if ((str[0] == i) && (str[1] == skorost)) rez = str[2];
            }

            return rez;
        }

        private double Take_kms_2()
        {
            double[][] table_kms_2 =
            {
                new double[] { 1, 0, 20.42 },
                new double[] { 1, 0.1, 20.42 },
                new double[] { 1, 0.2, 20.42 },
                new double[] { 1, 0.3, 20.42 },
                new double[] { 1, 0.4, 20.42 },
                new double[] { 1, 0.5, 20.42 },
                new double[] { 1, 0.6, 20.42 },
                new double[] { 1, 0.7, 20.42 },
                new double[] { 1, 0.8, 20.42 },
                new double[] { 1, 0.9, 20.42 },
                new double[] { 1, 1, 20.42 },
                new double[] { 1, 1.1, 20.42 },
                new double[] { 1, 1.2, 20.42 },
                new double[] { 1, 1.3, 20.42 },
                new double[] { 1, 1.4, 20.42 },
                new double[] { 1, 1.5, 20.42 },
                new double[] { 1, 1.6, 20.42 },
                new double[] { 1, 1.7, 20.42 },
                new double[] { 1, 1.8, 20.42 },
                new double[] { 1, 1.9, 20.42 },
                new double[] { 1, 2, 20.42 },
                new double[] { 1, 2.1, 19.05 },
                new double[] { 1, 2.2, 17.84 },
                new double[] { 1, 2.3, 16.76 },
                new double[] { 1, 2.4, 15.8 },
                new double[] { 1, 2.5, 14.93 },
                new double[] { 1, 2.6, 14.15 },
                new double[] { 1, 2.7, 13.44 },
                new double[] { 1, 2.8, 12.8 },
                new double[] { 1, 2.9, 12.21 },
                new double[] { 1, 3, 11.67 },
                new double[] { 1, 3.1, 11.12 },
                new double[] { 1, 3.2, 10.61 },
                new double[] { 1, 3.3, 10.15 },
                new double[] { 1, 3.4, 9.72 },
                new double[] { 1, 3.5, 9.32 },
                new double[] { 1, 3.6, 8.95 },
                new double[] { 1, 3.7, 8.61 },
                new double[] { 1, 3.8, 8.29 },
                new double[] { 1, 3.9, 7.99 },
                new double[] { 1, 4, 7.71 },
                new double[] { 1, 4.1, 7.42 },
                new double[] { 1, 4.2, 7.14 },
                new double[] { 1, 4.3, 6.89 },
                new double[] { 1, 4.4, 6.65 },
                new double[] { 1, 4.5, 6.42 },
                new double[] { 1, 4.6, 6.21 },
                new double[] { 1, 4.7, 6.01 },
                new double[] { 1, 4.8, 5.82 },
                new double[] { 1, 4.9, 5.64 },
                new double[] { 1, 5, 5.47 },
                new double[] { 1, 5.1, 5.29 },
                new double[] { 1, 5.2, 5.12 },
                new double[] { 1, 5.3, 4.95 },
                new double[] { 1, 5.4, 4.8 },
                new double[] { 1, 5.5, 4.66 },
                new double[] { 1, 5.6, 4.52 },
                new double[] { 1, 5.7, 4.39 },
                new double[] { 1, 5.8, 4.26 },
                new double[] { 1, 5.9, 4.14 },
                new double[] { 1, 6, 4.03 },
                new double[] { 1, 6.1, 3.91 },
                new double[] { 1, 6.2, 3.79 },
                new double[] { 1, 6.3, 3.68 },
                new double[] { 1, 6.4, 3.57 },
                new double[] { 1, 6.5, 3.47 },
                new double[] { 1, 6.6, 3.37 },
                new double[] { 1, 6.7, 3.28 },
                new double[] { 1, 6.8, 3.19 },
                new double[] { 1, 6.9, 3.11 },
                new double[] { 1, 7, 3.03 },
                new double[] { 1, 7.1, 2.95 },
                new double[] { 1, 7.2, 2.88 },
                new double[] { 1, 7.3, 2.81 },
                new double[] { 1, 7.4, 2.75 },
                new double[] { 1, 7.5, 2.68 },
                new double[] { 1, 7.6, 2.62 },
                new double[] { 1, 7.7, 2.56 },
                new double[] { 1, 7.8, 2.5 },
                new double[] { 1, 7.9, 2.45 },
                new double[] { 1, 8, 2.4 },
                new double[] { 1, 8.1, 2.34 },
                new double[] { 1, 8.2, 2.29 },
                new double[] { 1, 8.3, 2.23 },
                new double[] { 1, 8.4, 2.18 },
                new double[] { 1, 8.5, 2.13 },
                new double[] { 1, 8.6, 2.09 },
                new double[] { 1, 8.7, 2.04 },
                new double[] { 1, 8.8, 2 },
                new double[] { 1, 8.9, 1.95 },
                new double[] { 1, 9, 1.91 },
                new double[] { 1, 9.1, 1.87 },
                new double[] { 1, 9.2, 1.84 },
                new double[] { 1, 9.3, 1.8 },
                new double[] { 1, 9.4, 1.76 },
                new double[] { 1, 9.5, 1.73 },
                new double[] { 1, 9.6, 1.69 },
                new double[] { 1, 9.7, 1.66 },
                new double[] { 1, 9.8, 1.63 },
                new double[] { 1, 9.9, 1.6 },
                new double[] { 1, 10, 1.57 },
                new double[] { 1, 10.1, 1.54 },
                new double[] { 1, 10.2, 1.51 },
                new double[] { 1, 10.3, 1.48 },
                new double[] { 1, 10.4, 1.45 },
                new double[] { 1, 10.5, 1.42 },
                new double[] { 1, 10.6, 1.39 },
                new double[] { 1, 10.7, 1.37 },
                new double[] { 1, 10.8, 1.34 },
                new double[] { 1, 10.9, 1.32 },
                new double[] { 1, 11, 1.29 },
                new double[] { 1, 11.1, 1.27 },
                new double[] { 1, 11.2, 1.25 },
                new double[] { 1, 11.3, 1.22 },
                new double[] { 1, 11.4, 1.2 },
                new double[] { 1, 11.5, 1.18 },
                new double[] { 1, 11.6, 1.16 },
                new double[] { 1, 11.7, 1.14 },
                new double[] { 1, 11.8, 1.12 },
                new double[] { 1, 11.9, 1.1 },
                new double[] { 1, 12, 1.08 },
                new double[] { 2, 0, 43.75 },
                new double[] { 2, 0.1, 43.75 },
                new double[] { 2, 0.2, 43.75 },
                new double[] { 2, 0.3, 43.75 },
                new double[] { 2, 0.4, 43.75 },
                new double[] { 2, 0.5, 43.75 },
                new double[] { 2, 0.6, 43.75 },
                new double[] { 2, 0.7, 43.75 },
                new double[] { 2, 0.8, 43.75 },
                new double[] { 2, 0.9, 43.75 },
                new double[] { 2, 1, 43.75 },
                new double[] { 2, 1.1, 43.75 },
                new double[] { 2, 1.2, 43.75 },
                new double[] { 2, 1.3, 43.75 },
                new double[] { 2, 1.4, 43.75 },
                new double[] { 2, 1.5, 43.75 },
                new double[] { 2, 1.6, 43.75 },
                new double[] { 2, 1.7, 43.75 },
                new double[] { 2, 1.8, 43.75 },
                new double[] { 2, 1.9, 43.75 },
                new double[] { 2, 2, 43.75 },
                new double[] { 2, 2.1, 40.14 },
                new double[] { 2, 2.2, 36.98 },
                new double[] { 2, 2.3, 34.22 },
                new double[] { 2, 2.4, 31.77 },
                new double[] { 2, 2.5, 29.6 },
                new double[] { 2, 2.6, 27.66 },
                new double[] { 2, 2.7, 25.93 },
                new double[] { 2, 2.8, 24.36 },
                new double[] { 2, 2.9, 22.95 },
                new double[] { 2, 3, 21.67 },
                new double[] { 2, 3.1, 20.36 },
                new double[] { 2, 3.2, 19.17 },
                new double[] { 2, 3.3, 18.09 },
                new double[] { 2, 3.4, 17.1 },
                new double[] { 2, 3.5, 16.19 },
                new double[] { 2, 3.6, 15.35 },
                new double[] { 2, 3.7, 14.58 },
                new double[] { 2, 3.8, 13.87 },
                new double[] { 2, 3.9, 13.21 },
                new double[] { 2, 4, 12.6 },
                new double[] { 2, 4.1, 11.97 },
                new double[] { 2, 4.2, 11.38 },
                new double[] { 2, 4.3, 10.83 },
                new double[] { 2, 4.4, 10.31 },
                new double[] { 2, 4.5, 9.84 },
                new double[] { 2, 4.6, 9.39 },
                new double[] { 2, 4.7, 8.97 },
                new double[] { 2, 4.8, 8.58 },
                new double[] { 2, 4.9, 8.21 },
                new double[] { 2, 5, 7.87 },
                new double[] { 2, 5.1, 7.53 },
                new double[] { 2, 5.2, 7.21 },
                new double[] { 2, 5.3, 6.91 },
                new double[] { 2, 5.4, 6.63 },
                new double[] { 2, 5.5, 6.36 },
                new double[] { 2, 5.6, 6.11 },
                new double[] { 2, 5.7, 5.87 },
                new double[] { 2, 5.8, 5.65 },
                new double[] { 2, 5.9, 5.43 },
                new double[] { 2, 6, 5.23 },
                new double[] { 2, 6.1, 4.94 },
                new double[] { 2, 6.2, 4.66 },
                new double[] { 2, 6.3, 4.39 },
                new double[] { 2, 6.4, 4.14 },
                new double[] { 2, 6.5, 3.91 },
                new double[] { 2, 6.6, 3.68 },
                new double[] { 2, 6.7, 3.47 },
                new double[] { 2, 6.8, 3.27 },
                new double[] { 2, 6.9, 3.07 },
                new double[] { 2, 7, 2.89 },
                new double[] { 2, 7.1, 2.76 },
                new double[] { 2, 7.2, 2.63 },
                new double[] { 2, 7.3, 2.51 },
                new double[] { 2, 7.4, 2.39 },
                new double[] { 2, 7.5, 2.28 },
                new double[] { 2, 7.6, 2.18 },
                new double[] { 2, 7.7, 2.07 },
                new double[] { 2, 7.8, 1.98 },
                new double[] { 2, 7.9, 1.89 },
                new double[] { 2, 8, 1.8 },
                new double[] { 2, 8.1, 1.72 },
                new double[] { 2, 8.2, 1.66 },
                new double[] { 2, 8.3, 1.59 },
                new double[] { 2, 8.4, 1.53 },
                new double[] { 2, 8.5, 1.46 },
                new double[] { 2, 8.6, 1.41 },
                new double[] { 2, 8.7, 1.35 },
                new double[] { 2, 8.8, 1.3 },
                new double[] { 2, 8.9, 1.24 },
                new double[] { 2, 9, 1.19 },
                new double[] { 2, 9.1, 1.15 },
                new double[] { 2, 9.2, 1.11 },
                new double[] { 2, 9.3, 1.08 },
                new double[] { 2, 9.4, 1.04 },
                new double[] { 2, 9.5, 1.01 },
                new double[] { 2, 9.6, 0.97 },
                new double[] { 2, 9.7, 0.94 },
                new double[] { 2, 9.8, 0.91 },
                new double[] { 2, 9.9, 0.88 },
                new double[] { 2, 10, 0.85 },
                new double[] { 2, 10.1, 0.84 },
                new double[] { 2, 10.2, 0.84 },
                new double[] { 2, 10.3, 0.83 },
                new double[] { 2, 10.4, 0.82 },
                new double[] { 2, 10.5, 0.82 },
                new double[] { 2, 10.6, 0.81 },
                new double[] { 2, 10.7, 0.8 },
                new double[] { 2, 10.8, 0.8 },
                new double[] { 2, 10.9, 0.79 },
                new double[] { 2, 11, 0.79 },
                new double[] { 2, 11.1, 0.79 },
                new double[] { 2, 11.2, 0.79 },
                new double[] { 2, 11.3, 0.8 },
                new double[] { 2, 11.4, 0.8 },
                new double[] { 2, 11.5, 0.81 },
                new double[] { 2, 11.6, 0.81 },
                new double[] { 2, 11.7, 0.81 },
                new double[] { 2, 11.8, 0.82 },
                new double[] { 2, 11.9, 0.82 },
                new double[] { 2, 12, 0.82 }
            };

            double rez = 0.82;

            double i = (double)_polojenie_1_gor_2_ver;

            if (i != 2) i = 1;

            double f = Math.PI * Math.Pow((_diameter_mm / 1000), 2) / 4;

            double v1 = (_rashod_m3_in_hour / 3600) / (f);

            double skorost = (Math.Round(v1 * (double)10)) / (double)10;

            foreach (double[] str in table_kms_2)
            {
                if ((str[0] == i) && (str[1] == skorost)) rez = str[2];
            }

            return rez;
        }

        protected override void Refresh_marka()
        {
            if (_forma_sechenia == "rectangle")
            {
                _marka = "КЛАРА" + "-" + _width_mm.ToString() + "x" + _height_mm.ToString() + "-" + "Н";
            }
            else
            {
                _marka = "КЛАРА" + "-" + _diameter_mm.ToString() + "-" + "Н";
            }
        }
        public void SetMarka()
        {
            Refresh_marka();
        }

        public Obratniy_klapan(int polojenie_1_gor_2_ver, double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated)
       : base("Клапан обратный", "", rashod_m3_in_hour, width_mm, height_mm, rotated, 0)
        {
            Set_polojenie(polojenie_1_gor_2_ver);
            SetMarka();
            _kms = Take_kms();
        }

        public Obratniy_klapan(int polojenie_1_gor_2_ver, double rashod_m3_in_hour, double diameter_mm)
            : base("Клапан обратный", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            Set_polojenie(polojenie_1_gor_2_ver);
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
