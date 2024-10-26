using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Perehod : Mestnoe_soprotivlenie
    {
        private bool _vitiajka_tru_pritok_false = true;

        protected double _dlina;

        private string _tip_perehoda;

        private bool _perehod_v_konce_potoka_true_v_nachale_false = true;

        public string Tip_perehoda
        {
            get
            {
                return _tip_perehoda;
            }
        }

        public double Dlina
        {
            get
            {
                return _dlina;
            }
            set
            {
                _dlina = Math.Abs(value);
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

        private double KMS_for_vnezapniy_perehod(double square_1, double square_2)
        {
            double Ploschad_1 = square_1;
            double Ploschad_2 = square_2;

            if ((Ploschad_1 == 0) || (Ploschad_2 == 0)) return 0;
            else if (Ploschad_2 > Ploschad_1)
            {
                return Math.Pow((1 - (Ploschad_1 / Ploschad_2)), 2.0);
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
        private double Take_kms_rectangle_to_rectangle(double shirina_1, double visota_1, double shirina_2, double visota_2, double dlina_perehoda)
        {
            if (shirina_1 <= 0)
            {
                return 0;
            }

            if (visota_1 <= 0)
            {
                return 0;
            }

            if (shirina_2 <= 0)
            {
                return 0;
            }

            if (visota_2 <= 0)
            {
                return 0;
            }

            if (dlina_perehoda < 0)
            {
                return 0;
            }

            double a1;
            double b1;
            double a2;
            double b2;

            double alfa;

            if (_vitiajka_tru_pritok_false)
            {
                a1 = shirina_1;
                b1 = visota_1;
                a2 = shirina_2;
                b2 = visota_2;
            }
            else
            {
                a1 = shirina_2;
                b1 = visota_2;
                a2 = shirina_1;
                b2 = visota_1;
            }

            if (dlina_perehoda == 0)
            {
                return KMS_for_vnezapniy_perehod((a1 * b1), (a2 * b2));
            }

            double d_ekv_1 = ((2.0 * a1 * b1) / (a1 + b1));
            double d_ekv_2 = ((2.0 * a2 * b2) / (a2 + b2));

            double d_ekv_min = Math.Min(d_ekv_1, d_ekv_2);

            double dlina_k_d_ekv_min = (dlina_perehoda / d_ekv_min);
            dlina_k_d_ekv_min = (Math.Round(dlina_k_d_ekv_min * 100.0)) / 100.0;

            double f1 = a1 * b1;
            double f2 = a2 * b2;

            double f_min = Math.Min(f1, f2);
            double f_max = Math.Max(f1, f2);

            double k_ploschadi;

            if (f_min > 0)
            {
                k_ploschadi = (f_max / f_min);
                k_ploschadi = (Math.Round(k_ploschadi * 100.0) / 100.0);
            }
            else
            {
                k_ploschadi = 0;
            }

            double k_ploschadi_privedenniy = 0.2;

            if (k_ploschadi >= 0.6) k_ploschadi_privedenniy = 0.6;

            double[][] table_k_ploschadi_privedenniy =
            {
                new double[] {0, 0.2},
                new double[] {0.01, 0.2},
                new double[] {0.02, 0.2},
                new double[] {0.03, 0.2},
                new double[] {0.04, 0.2},
                new double[] {0.05, 0.2},
                new double[] {0.06, 0.2},
                new double[] {0.07, 0.2},
                new double[] {0.08, 0.2},
                new double[] {0.09, 0.2},
                new double[] {0.1, 0.2},
                new double[] {0.11, 0.2},
                new double[] {0.12, 0.2},
                new double[] {0.13, 0.2},
                new double[] {0.14, 0.2},
                new double[] {0.15, 0.2},
                new double[] {0.16, 0.2},
                new double[] {0.17, 0.2},
                new double[] {0.18, 0.2},
                new double[] {0.19, 0.2},
                new double[] {0.2, 0.2},
                new double[] {0.21, 0.2},
                new double[] {0.22, 0.2},
                new double[] {0.23, 0.2},
                new double[] {0.24, 0.2},
                new double[] {0.25, 0.25},
                new double[] {0.26, 0.25},
                new double[] {0.27, 0.25},
                new double[] {0.28, 0.25},
                new double[] {0.29, 0.25},
                new double[] {0.3, 0.3},
                new double[] {0.31, 0.3},
                new double[] {0.32, 0.3},
                new double[] {0.33, 0.3},
                new double[] {0.34, 0.3},
                new double[] {0.35, 0.3},
                new double[] {0.36, 0.3},
                new double[] {0.37, 0.3},
                new double[] {0.38, 0.3},
                new double[] {0.39, 0.3},
                new double[] {0.4, 0.4},
                new double[] {0.41, 0.4},
                new double[] {0.42, 0.4},
                new double[] {0.43, 0.4},
                new double[] {0.44, 0.4},
                new double[] {0.45, 0.4},
                new double[] {0.46, 0.4},
                new double[] {0.47, 0.4},
                new double[] {0.48, 0.4},
                new double[] {0.49, 0.4},
                new double[] {0.5, 0.5},
                new double[] {0.51, 0.5},
                new double[] {0.52, 0.5},
                new double[] {0.53, 0.5},
                new double[] {0.54, 0.5},
                new double[] {0.55, 0.5},
                new double[] {0.56, 0.5},
                new double[] {0.57, 0.5},
                new double[] {0.58, 0.5},
                new double[] {0.59, 0.5},
                new double[] {0.6, 0.6}
            };

            foreach (double[] str in table_k_ploschadi_privedenniy)
            {
                if (k_ploschadi == str[0])
                {
                    k_ploschadi_privedenniy = str[1];
                    break;
                }
            }

            double alfa1;
            double alfa2;

            double alfa_new;

            if ( ( (a1 == a2) && (b1 == b2) ) || dlina_perehoda == 0 )
            {
                alfa1 = 0;
                alfa2 = 0;
            }
            else
            {
                alfa1 = 2.0 * (90.0 - (180.0 / Math.PI) * (Math.Atan(dlina_perehoda / Math.Abs(a1 * 0.5 - a2 * 0.5))));
                alfa2 = 2.0 * (90.0 - (180.0 / Math.PI) * (Math.Atan(dlina_perehoda / Math.Abs(b1 * 0.5 - b2 * 0.5))));
            }

            if (f1 <= f2)
            {
                alfa = Math.Max(alfa1, alfa2);
                alfa = Math.Round(alfa);

                alfa_new = 180;

                double[][] table_alfa_new_rectangle_to_rectangle_rasshirenie =
                {
                    new double[] {0, 10},
                    new double[] {1, 10},
                    new double[] {2, 10},
                    new double[] {3, 10},
                    new double[] {4, 10},
                    new double[] {5, 10},
                    new double[] {6, 10},
                    new double[] {7, 10},
                    new double[] {8, 10},
                    new double[] {9, 10},
                    new double[] {10, 10},
                    new double[] {11, 12},
                    new double[] {12, 12},
                    new double[] {13, 14},
                    new double[] {14, 14},
                    new double[] {15, 16},
                    new double[] {16, 16},
                    new double[] {17, 18},
                    new double[] {18, 18},
                    new double[] {19, 20},
                    new double[] {20, 20},
                    new double[] {21, 24},
                    new double[] {22, 24},
                    new double[] {23, 24},
                    new double[] {24, 24},
                    new double[] {25, 28},
                    new double[] {26, 28},
                    new double[] {27, 28},
                    new double[] {28, 28},
                    new double[] {29, 30},
                    new double[] {30, 30},
                    new double[] {31, 32},
                    new double[] {32, 32},
                    new double[] {33, 40},
                    new double[] {34, 40},
                    new double[] {35, 40},
                    new double[] {36, 40},
                    new double[] {37, 40},
                    new double[] {38, 40},
                    new double[] {39, 40},
                    new double[] {40, 40},
                    new double[] {41, 41},
                    new double[] {42, 42},
                    new double[] {43, 43},
                    new double[] {44, 44},
                    new double[] {45, 45},
                    new double[] {46, 46},
                    new double[] {47, 47},
                    new double[] {48, 48},
                    new double[] {49, 49},
                    new double[] {50, 50},
                    new double[] {51, 51},
                    new double[] {52, 52},
                    new double[] {53, 53},
                    new double[] {54, 54},
                    new double[] {55, 55},
                    new double[] {56, 56},
                    new double[] {57, 57},
                    new double[] {58, 58},
                    new double[] {59, 59},
                    new double[] {60, 60},
                    new double[] {61, 61},
                    new double[] {62, 62},
                    new double[] {63, 63},
                    new double[] {64, 64},
                    new double[] {65, 65},
                    new double[] {66, 66},
                    new double[] {67, 67},
                    new double[] {68, 68},
                    new double[] {69, 69},
                    new double[] {70, 70},
                    new double[] {71, 71},
                    new double[] {72, 72},
                    new double[] {73, 73},
                    new double[] {74, 74},
                    new double[] {75, 75},
                    new double[] {76, 76},
                    new double[] {77, 77},
                    new double[] {78, 78},
                    new double[] {79, 79},
                    new double[] {80, 80},
                    new double[] {81, 81},
                    new double[] {82, 82},
                    new double[] {83, 83},
                    new double[] {84, 84},
                    new double[] {85, 85},
                    new double[] {86, 86},
                    new double[] {87, 87},
                    new double[] {88, 88},
                    new double[] {89, 89},
                    new double[] {90, 90},
                    new double[] {91, 91},
                    new double[] {92, 92},
                    new double[] {93, 93},
                    new double[] {94, 94},
                    new double[] {95, 95},
                    new double[] {96, 96},
                    new double[] {97, 97},
                    new double[] {98, 98},
                    new double[] {99, 99},
                    new double[] {100, 100},
                    new double[] {101, 101},
                    new double[] {102, 102},
                    new double[] {103, 103},
                    new double[] {104, 104},
                    new double[] {105, 105},
                    new double[] {106, 106},
                    new double[] {107, 107},
                    new double[] {108, 108},
                    new double[] {109, 109},
                    new double[] {110, 110},
                    new double[] {111, 111},
                    new double[] {112, 112},
                    new double[] {113, 113},
                    new double[] {114, 114},
                    new double[] {115, 115},
                    new double[] {116, 116},
                    new double[] {117, 117},
                    new double[] {118, 118},
                    new double[] {119, 119},
                    new double[] {120, 120},
                    new double[] {121, 121},
                    new double[] {122, 122},
                    new double[] {123, 123},
                    new double[] {124, 124},
                    new double[] {125, 125},
                    new double[] {126, 126},
                    new double[] {127, 127},
                    new double[] {128, 128},
                    new double[] {129, 129},
                    new double[] {130, 130},
                    new double[] {131, 131},
                    new double[] {132, 132},
                    new double[] {133, 133},
                    new double[] {134, 134},
                    new double[] {135, 135},
                    new double[] {136, 136},
                    new double[] {137, 137},
                    new double[] {138, 138},
                    new double[] {139, 139},
                    new double[] {140, 140},
                    new double[] {141, 141},
                    new double[] {142, 142},
                    new double[] {143, 143},
                    new double[] {144, 144},
                    new double[] {145, 145},
                    new double[] {146, 146},
                    new double[] {147, 147},
                    new double[] {148, 148},
                    new double[] {149, 149},
                    new double[] {150, 150},
                    new double[] {151, 151},
                    new double[] {152, 152},
                    new double[] {153, 153},
                    new double[] {154, 154},
                    new double[] {155, 155},
                    new double[] {156, 156},
                    new double[] {157, 157},
                    new double[] {158, 158},
                    new double[] {159, 159},
                    new double[] {160, 160},
                    new double[] {161, 161},
                    new double[] {162, 162},
                    new double[] {163, 163},
                    new double[] {164, 164},
                    new double[] {165, 165},
                    new double[] {166, 166},
                    new double[] {167, 167},
                    new double[] {168, 168},
                    new double[] {169, 169},
                    new double[] {170, 170},
                    new double[] {171, 171},
                    new double[] {172, 172},
                    new double[] {173, 173},
                    new double[] {174, 174},
                    new double[] {175, 175},
                    new double[] {176, 176},
                    new double[] {177, 177},
                    new double[] {178, 178},
                    new double[] {179, 179},
                    new double[] {180, 180}
                };

                foreach (double[] str in table_alfa_new_rectangle_to_rectangle_rasshirenie)
                {
                    if (alfa == str[0])
                    {
                        alfa_new = str[1];
                        break;
                    }
                }

                double[][] table_kms_rectangle_to_rectangle_rasshirenie =
                {
                    new double[] {10, 0.2, 0.14},
                    new double[] {10, 0.25, 0.13},
                    new double[] {10, 0.3, 0.11},
                    new double[] {10, 0.4, 0.09},
                    new double[] {10, 0.5, 0.07},
                    new double[] {10, 0.6, 0.05},
                    new double[] {12, 0.2, 0.17},
                    new double[] {12, 0.25, 0.16},
                    new double[] {12, 0.3, 0.13},
                    new double[] {12, 0.4, 0.1},
                    new double[] {12, 0.5, 0.08},
                    new double[] {12, 0.6, 0.06},
                    new double[] {14, 0.2, 0.2},
                    new double[] {14, 0.25, 0.18},
                    new double[] {14, 0.3, 0.16},
                    new double[] {14, 0.4, 0.12},
                    new double[] {14, 0.5, 0.09},
                    new double[] {14, 0.6, 0.07},
                    new double[] {16, 0.2, 0.24},
                    new double[] {16, 0.25, 0.21},
                    new double[] {16, 0.3, 0.19},
                    new double[] {16, 0.4, 0.14},
                    new double[] {16, 0.5, 0.1},
                    new double[] {16, 0.6, 0.07},
                    new double[] {18, 0.2, 0.28},
                    new double[] {18, 0.25, 0.24},
                    new double[] {18, 0.3, 0.22},
                    new double[] {18, 0.4, 0.16},
                    new double[] {18, 0.5, 0.12},
                    new double[] {18, 0.6, 0.08},
                    new double[] {20, 0.2, 0.31},
                    new double[] {20, 0.25, 0.27},
                    new double[] {20, 0.3, 0.24},
                    new double[] {20, 0.4, 0.18},
                    new double[] {20, 0.5, 0.13},
                    new double[] {20, 0.6, 0.09},
                    new double[] {24, 0.2, 0.4},
                    new double[] {24, 0.25, 0.35},
                    new double[] {24, 0.3, 0.31},
                    new double[] {24, 0.4, 0.23},
                    new double[] {24, 0.5, 0.17},
                    new double[] {24, 0.6, 0.11},
                    new double[] {28, 0.2, 0.49},
                    new double[] {28, 0.25, 0.43},
                    new double[] {28, 0.3, 0.38},
                    new double[] {28, 0.4, 0.28},
                    new double[] {28, 0.5, 0.2},
                    new double[] {28, 0.6, 0.14},
                    new double[] {30, 0.2, 0.54},
                    new double[] {30, 0.25, 0.475},
                    new double[] {30, 0.3, 0.42},
                    new double[] {30, 0.4, 0.31},
                    new double[] {30, 0.5, 0.22},
                    new double[] {30, 0.6, 0.15},
                    new double[] {32, 0.2, 0.59},
                    new double[] {32, 0.25, 0.52},
                    new double[] {32, 0.3, 0.46},
                    new double[] {32, 0.4, 0.34},
                    new double[] {32, 0.5, 0.24},
                    new double[] {32, 0.6, 0.16},
                    new double[] {40, 0.2, 0.69},
                    new double[] {40, 0.25, 0.61},
                    new double[] {40, 0.3, 0.53},
                    new double[] {40, 0.4, 0.4},
                    new double[] {40, 0.5, 0.28},
                    new double[] {40, 0.6, 0.19},
                    new double[] {41, 0.2, 0.7},
                    new double[] {41, 0.25, 0.62},
                    new double[] {41, 0.3, 0.54},
                    new double[] {41, 0.4, 0.41},
                    new double[] {41, 0.5, 0.29},
                    new double[] {41, 0.6, 0.19},
                    new double[] {42, 0.2, 0.72},
                    new double[] {42, 0.25, 0.63},
                    new double[] {42, 0.3, 0.55},
                    new double[] {42, 0.4, 0.42},
                    new double[] {42, 0.5, 0.29},
                    new double[] {42, 0.6, 0.2},
                    new double[] {43, 0.2, 0.73},
                    new double[] {43, 0.25, 0.64},
                    new double[] {43, 0.3, 0.56},
                    new double[] {43, 0.4, 0.42},
                    new double[] {43, 0.5, 0.3},
                    new double[] {43, 0.6, 0.2},
                    new double[] {44, 0.2, 0.74},
                    new double[] {44, 0.25, 0.66},
                    new double[] {44, 0.3, 0.57},
                    new double[] {44, 0.4, 0.43},
                    new double[] {44, 0.5, 0.3},
                    new double[] {44, 0.6, 0.21},
                    new double[] {45, 0.2, 0.75},
                    new double[] {45, 0.25, 0.67},
                    new double[] {45, 0.3, 0.57},
                    new double[] {45, 0.4, 0.44},
                    new double[] {45, 0.5, 0.31},
                    new double[] {45, 0.6, 0.21},
                    new double[] {46, 0.2, 0.77},
                    new double[] {46, 0.25, 0.68},
                    new double[] {46, 0.3, 0.58},
                    new double[] {46, 0.4, 0.45},
                    new double[] {46, 0.5, 0.31},
                    new double[] {46, 0.6, 0.21},
                    new double[] {47, 0.2, 0.78},
                    new double[] {47, 0.25, 0.69},
                    new double[] {47, 0.3, 0.59},
                    new double[] {47, 0.4, 0.45},
                    new double[] {47, 0.5, 0.32},
                    new double[] {47, 0.6, 0.22},
                    new double[] {48, 0.2, 0.79},
                    new double[] {48, 0.25, 0.7},
                    new double[] {48, 0.3, 0.6},
                    new double[] {48, 0.4, 0.46},
                    new double[] {48, 0.5, 0.32},
                    new double[] {48, 0.6, 0.22},
                    new double[] {49, 0.2, 0.8},
                    new double[] {49, 0.25, 0.71},
                    new double[] {49, 0.3, 0.61},
                    new double[] {49, 0.4, 0.47},
                    new double[] {49, 0.5, 0.33},
                    new double[] {49, 0.6, 0.22},
                    new double[] {50, 0.2, 0.82},
                    new double[] {50, 0.25, 0.72},
                    new double[] {50, 0.3, 0.62},
                    new double[] {50, 0.4, 0.48},
                    new double[] {50, 0.5, 0.33},
                    new double[] {50, 0.6, 0.23},
                    new double[] {51, 0.2, 0.83},
                    new double[] {51, 0.25, 0.73},
                    new double[] {51, 0.3, 0.63},
                    new double[] {51, 0.4, 0.48},
                    new double[] {51, 0.5, 0.34},
                    new double[] {51, 0.6, 0.23},
                    new double[] {52, 0.2, 0.84},
                    new double[] {52, 0.25, 0.75},
                    new double[] {52, 0.3, 0.64},
                    new double[] {52, 0.4, 0.49},
                    new double[] {52, 0.5, 0.34},
                    new double[] {52, 0.6, 0.24},
                    new double[] {53, 0.2, 0.85},
                    new double[] {53, 0.25, 0.76},
                    new double[] {53, 0.3, 0.64},
                    new double[] {53, 0.4, 0.5},
                    new double[] {53, 0.5, 0.35},
                    new double[] {53, 0.6, 0.24},
                    new double[] {54, 0.2, 0.87},
                    new double[] {54, 0.25, 0.77},
                    new double[] {54, 0.3, 0.65},
                    new double[] {54, 0.4, 0.51},
                    new double[] {54, 0.5, 0.35},
                    new double[] {54, 0.6, 0.24},
                    new double[] {55, 0.2, 0.88},
                    new double[] {55, 0.25, 0.78},
                    new double[] {55, 0.3, 0.66},
                    new double[] {55, 0.4, 0.51},
                    new double[] {55, 0.5, 0.36},
                    new double[] {55, 0.6, 0.25},
                    new double[] {56, 0.2, 0.89},
                    new double[] {56, 0.25, 0.79},
                    new double[] {56, 0.3, 0.67},
                    new double[] {56, 0.4, 0.52},
                    new double[] {56, 0.5, 0.36},
                    new double[] {56, 0.6, 0.25},
                    new double[] {57, 0.2, 0.9},
                    new double[] {57, 0.25, 0.8},
                    new double[] {57, 0.3, 0.68},
                    new double[] {57, 0.4, 0.53},
                    new double[] {57, 0.5, 0.37},
                    new double[] {57, 0.6, 0.25},
                    new double[] {58, 0.2, 0.92},
                    new double[] {58, 0.25, 0.81},
                    new double[] {58, 0.3, 0.69},
                    new double[] {58, 0.4, 0.54},
                    new double[] {58, 0.5, 0.37},
                    new double[] {58, 0.6, 0.26},
                    new double[] {59, 0.2, 0.93},
                    new double[] {59, 0.25, 0.82},
                    new double[] {59, 0.3, 0.7},
                    new double[] {59, 0.4, 0.54},
                    new double[] {59, 0.5, 0.38},
                    new double[] {59, 0.6, 0.26},
                    new double[] {60, 0.2, 0.94},
                    new double[] {60, 0.25, 0.84},
                    new double[] {60, 0.3, 0.71},
                    new double[] {60, 0.4, 0.55},
                    new double[] {60, 0.5, 0.38},
                    new double[] {60, 0.6, 0.27},
                    new double[] {61, 0.2, 0.95},
                    new double[] {61, 0.25, 0.85},
                    new double[] {61, 0.3, 0.71},
                    new double[] {61, 0.4, 0.56},
                    new double[] {61, 0.5, 0.39},
                    new double[] {61, 0.6, 0.27},
                    new double[] {62, 0.2, 0.97},
                    new double[] {62, 0.25, 0.86},
                    new double[] {62, 0.3, 0.72},
                    new double[] {62, 0.4, 0.57},
                    new double[] {62, 0.5, 0.39},
                    new double[] {62, 0.6, 0.27},
                    new double[] {63, 0.2, 0.98},
                    new double[] {63, 0.25, 0.87},
                    new double[] {63, 0.3, 0.73},
                    new double[] {63, 0.4, 0.57},
                    new double[] {63, 0.5, 0.4},
                    new double[] {63, 0.6, 0.28},
                    new double[] {64, 0.2, 0.99},
                    new double[] {64, 0.25, 0.88},
                    new double[] {64, 0.3, 0.74},
                    new double[] {64, 0.4, 0.58},
                    new double[] {64, 0.5, 0.4},
                    new double[] {64, 0.6, 0.28},
                    new double[] {65, 0.2, 1},
                    new double[] {65, 0.25, 0.89},
                    new double[] {65, 0.3, 0.75},
                    new double[] {65, 0.4, 0.59},
                    new double[] {65, 0.5, 0.41},
                    new double[] {65, 0.6, 0.28},
                    new double[] {66, 0.2, 1.02},
                    new double[] {66, 0.25, 0.9},
                    new double[] {66, 0.3, 0.76},
                    new double[] {66, 0.4, 0.6},
                    new double[] {66, 0.5, 0.41},
                    new double[] {66, 0.6, 0.29},
                    new double[] {67, 0.2, 1.03},
                    new double[] {67, 0.25, 0.91},
                    new double[] {67, 0.3, 0.77},
                    new double[] {67, 0.4, 0.6},
                    new double[] {67, 0.5, 0.42},
                    new double[] {67, 0.6, 0.29},
                    new double[] {68, 0.2, 1.04},
                    new double[] {68, 0.25, 0.93},
                    new double[] {68, 0.3, 0.78},
                    new double[] {68, 0.4, 0.61},
                    new double[] {68, 0.5, 0.42},
                    new double[] {68, 0.6, 0.3},
                    new double[] {69, 0.2, 1.05},
                    new double[] {69, 0.25, 0.94},
                    new double[] {69, 0.3, 0.78},
                    new double[] {69, 0.4, 0.62},
                    new double[] {69, 0.5, 0.43},
                    new double[] {69, 0.6, 0.3},
                    new double[] {70, 0.2, 1.07},
                    new double[] {70, 0.25, 0.95},
                    new double[] {70, 0.3, 0.79},
                    new double[] {70, 0.4, 0.63},
                    new double[] {70, 0.5, 0.43},
                    new double[] {70, 0.6, 0.3},
                    new double[] {71, 0.2, 1.08},
                    new double[] {71, 0.25, 0.96},
                    new double[] {71, 0.3, 0.8},
                    new double[] {71, 0.4, 0.63},
                    new double[] {71, 0.5, 0.44},
                    new double[] {71, 0.6, 0.31},
                    new double[] {72, 0.2, 1.09},
                    new double[] {72, 0.25, 0.97},
                    new double[] {72, 0.3, 0.81},
                    new double[] {72, 0.4, 0.64},
                    new double[] {72, 0.5, 0.44},
                    new double[] {72, 0.6, 0.31},
                    new double[] {73, 0.2, 1.1},
                    new double[] {73, 0.25, 0.98},
                    new double[] {73, 0.3, 0.82},
                    new double[] {73, 0.4, 0.65},
                    new double[] {73, 0.5, 0.45},
                    new double[] {73, 0.6, 0.31},
                    new double[] {74, 0.2, 1.12},
                    new double[] {74, 0.25, 0.99},
                    new double[] {74, 0.3, 0.83},
                    new double[] {74, 0.4, 0.66},
                    new double[] {74, 0.5, 0.45},
                    new double[] {74, 0.6, 0.32},
                    new double[] {75, 0.2, 1.13},
                    new double[] {75, 0.25, 1},
                    new double[] {75, 0.3, 0.84},
                    new double[] {75, 0.4, 0.66},
                    new double[] {75, 0.5, 0.46},
                    new double[] {75, 0.6, 0.32},
                    new double[] {76, 0.2, 1.14},
                    new double[] {76, 0.25, 1.02},
                    new double[] {76, 0.3, 0.85},
                    new double[] {76, 0.4, 0.67},
                    new double[] {76, 0.5, 0.46},
                    new double[] {76, 0.6, 0.33},
                    new double[] {77, 0.2, 1.15},
                    new double[] {77, 0.25, 1.03},
                    new double[] {77, 0.3, 0.85},
                    new double[] {77, 0.4, 0.68},
                    new double[] {77, 0.5, 0.47},
                    new double[] {77, 0.6, 0.33},
                    new double[] {78, 0.2, 1.17},
                    new double[] {78, 0.25, 1.04},
                    new double[] {78, 0.3, 0.86},
                    new double[] {78, 0.4, 0.69},
                    new double[] {78, 0.5, 0.47},
                    new double[] {78, 0.6, 0.33},
                    new double[] {79, 0.2, 1.18},
                    new double[] {79, 0.25, 1.05},
                    new double[] {79, 0.3, 0.87},
                    new double[] {79, 0.4, 0.69},
                    new double[] {79, 0.5, 0.48},
                    new double[] {79, 0.6, 0.34},
                    new double[] {80, 0.2, 1.19},
                    new double[] {80, 0.25, 1.06},
                    new double[] {80, 0.3, 0.88},
                    new double[] {80, 0.4, 0.7},
                    new double[] {80, 0.5, 0.48},
                    new double[] {80, 0.6, 0.34},
                    new double[] {81, 0.2, 1.2},
                    new double[] {81, 0.25, 1.07},
                    new double[] {81, 0.3, 0.89},
                    new double[] {81, 0.4, 0.71},
                    new double[] {81, 0.5, 0.49},
                    new double[] {81, 0.6, 0.34},
                    new double[] {82, 0.2, 1.22},
                    new double[] {82, 0.25, 1.08},
                    new double[] {82, 0.3, 0.9},
                    new double[] {82, 0.4, 0.72},
                    new double[] {82, 0.5, 0.49},
                    new double[] {82, 0.6, 0.35},
                    new double[] {83, 0.2, 1.23},
                    new double[] {83, 0.25, 1.09},
                    new double[] {83, 0.3, 0.91},
                    new double[] {83, 0.4, 0.72},
                    new double[] {83, 0.5, 0.5},
                    new double[] {83, 0.6, 0.35},
                    new double[] {84, 0.2, 1.24},
                    new double[] {84, 0.25, 1.11},
                    new double[] {84, 0.3, 0.92},
                    new double[] {84, 0.4, 0.73},
                    new double[] {84, 0.5, 0.5},
                    new double[] {84, 0.6, 0.36},
                    new double[] {85, 0.2, 1.25},
                    new double[] {85, 0.25, 1.12},
                    new double[] {85, 0.3, 0.92},
                    new double[] {85, 0.4, 0.74},
                    new double[] {85, 0.5, 0.51},
                    new double[] {85, 0.6, 0.36},
                    new double[] {86, 0.2, 1.27},
                    new double[] {86, 0.25, 1.13},
                    new double[] {86, 0.3, 0.93},
                    new double[] {86, 0.4, 0.75},
                    new double[] {86, 0.5, 0.51},
                    new double[] {86, 0.6, 0.36},
                    new double[] {87, 0.2, 1.28},
                    new double[] {87, 0.25, 1.14},
                    new double[] {87, 0.3, 0.94},
                    new double[] {87, 0.4, 0.75},
                    new double[] {87, 0.5, 0.52},
                    new double[] {87, 0.6, 0.37},
                    new double[] {88, 0.2, 1.29},
                    new double[] {88, 0.25, 1.15},
                    new double[] {88, 0.3, 0.95},
                    new double[] {88, 0.4, 0.76},
                    new double[] {88, 0.5, 0.52},
                    new double[] {88, 0.6, 0.37},
                    new double[] {89, 0.2, 1.3},
                    new double[] {89, 0.25, 1.16},
                    new double[] {89, 0.3, 0.96},
                    new double[] {89, 0.4, 0.77},
                    new double[] {89, 0.5, 0.53},
                    new double[] {89, 0.6, 0.37},
                    new double[] {90, 0.2, 1.32},
                    new double[] {90, 0.25, 1.17},
                    new double[] {90, 0.3, 0.97},
                    new double[] {90, 0.4, 0.78},
                    new double[] {90, 0.5, 0.53},
                    new double[] {90, 0.6, 0.38},
                    new double[] {91, 0.2, 1.33},
                    new double[] {91, 0.25, 1.18},
                    new double[] {91, 0.3, 0.98},
                    new double[] {91, 0.4, 0.78},
                    new double[] {91, 0.5, 0.54},
                    new double[] {91, 0.6, 0.38},
                    new double[] {92, 0.2, 1.34},
                    new double[] {92, 0.25, 1.2},
                    new double[] {92, 0.3, 0.99},
                    new double[] {92, 0.4, 0.79},
                    new double[] {92, 0.5, 0.54},
                    new double[] {92, 0.6, 0.39},
                    new double[] {93, 0.2, 1.35},
                    new double[] {93, 0.25, 1.21},
                    new double[] {93, 0.3, 0.99},
                    new double[] {93, 0.4, 0.8},
                    new double[] {93, 0.5, 0.55},
                    new double[] {93, 0.6, 0.39},
                    new double[] {94, 0.2, 1.37},
                    new double[] {94, 0.25, 1.22},
                    new double[] {94, 0.3, 1},
                    new double[] {94, 0.4, 0.81},
                    new double[] {94, 0.5, 0.55},
                    new double[] {94, 0.6, 0.39},
                    new double[] {95, 0.2, 1.38},
                    new double[] {95, 0.25, 1.23},
                    new double[] {95, 0.3, 1.01},
                    new double[] {95, 0.4, 0.81},
                    new double[] {95, 0.5, 0.56},
                    new double[] {95, 0.6, 0.4},
                    new double[] {96, 0.2, 1.39},
                    new double[] {96, 0.25, 1.24},
                    new double[] {96, 0.3, 1.02},
                    new double[] {96, 0.4, 0.82},
                    new double[] {96, 0.5, 0.56},
                    new double[] {96, 0.6, 0.4},
                    new double[] {97, 0.2, 1.4},
                    new double[] {97, 0.25, 1.25},
                    new double[] {97, 0.3, 1.03},
                    new double[] {97, 0.4, 0.83},
                    new double[] {97, 0.5, 0.57},
                    new double[] {97, 0.6, 0.4},
                    new double[] {98, 0.2, 1.42},
                    new double[] {98, 0.25, 1.26},
                    new double[] {98, 0.3, 1.04},
                    new double[] {98, 0.4, 0.84},
                    new double[] {98, 0.5, 0.57},
                    new double[] {98, 0.6, 0.41},
                    new double[] {99, 0.2, 1.43},
                    new double[] {99, 0.25, 1.27},
                    new double[] {99, 0.3, 1.05},
                    new double[] {99, 0.4, 0.84},
                    new double[] {99, 0.5, 0.58},
                    new double[] {99, 0.6, 0.41},
                    new double[] {100, 0.2, 1.44},
                    new double[] {100, 0.25, 1.29},
                    new double[] {100, 0.3, 1.06},
                    new double[] {100, 0.4, 0.85},
                    new double[] {100, 0.5, 0.58},
                    new double[] {100, 0.6, 0.42},
                    new double[] {101, 0.2, 1.45},
                    new double[] {101, 0.25, 1.3},
                    new double[] {101, 0.3, 1.06},
                    new double[] {101, 0.4, 0.86},
                    new double[] {101, 0.5, 0.59},
                    new double[] {101, 0.6, 0.42},
                    new double[] {102, 0.2, 1.47},
                    new double[] {102, 0.25, 1.31},
                    new double[] {102, 0.3, 1.07},
                    new double[] {102, 0.4, 0.87},
                    new double[] {102, 0.5, 0.59},
                    new double[] {102, 0.6, 0.42},
                    new double[] {103, 0.2, 1.48},
                    new double[] {103, 0.25, 1.32},
                    new double[] {103, 0.3, 1.08},
                    new double[] {103, 0.4, 0.87},
                    new double[] {103, 0.5, 0.6},
                    new double[] {103, 0.6, 0.43},
                    new double[] {104, 0.2, 1.49},
                    new double[] {104, 0.25, 1.33},
                    new double[] {104, 0.3, 1.09},
                    new double[] {104, 0.4, 0.88},
                    new double[] {104, 0.5, 0.6},
                    new double[] {104, 0.6, 0.43},
                    new double[] {105, 0.2, 1.5},
                    new double[] {105, 0.25, 1.34},
                    new double[] {105, 0.3, 1.1},
                    new double[] {105, 0.4, 0.89},
                    new double[] {105, 0.5, 0.61},
                    new double[] {105, 0.6, 0.43},
                    new double[] {106, 0.2, 1.52},
                    new double[] {106, 0.25, 1.35},
                    new double[] {106, 0.3, 1.11},
                    new double[] {106, 0.4, 0.9},
                    new double[] {106, 0.5, 0.61},
                    new double[] {106, 0.6, 0.44},
                    new double[] {107, 0.2, 1.53},
                    new double[] {107, 0.25, 1.36},
                    new double[] {107, 0.3, 1.12},
                    new double[] {107, 0.4, 0.9},
                    new double[] {107, 0.5, 0.62},
                    new double[] {107, 0.6, 0.44},
                    new double[] {108, 0.2, 1.54},
                    new double[] {108, 0.25, 1.38},
                    new double[] {108, 0.3, 1.13},
                    new double[] {108, 0.4, 0.91},
                    new double[] {108, 0.5, 0.62},
                    new double[] {108, 0.6, 0.45},
                    new double[] {109, 0.2, 1.55},
                    new double[] {109, 0.25, 1.39},
                    new double[] {109, 0.3, 1.13},
                    new double[] {109, 0.4, 0.92},
                    new double[] {109, 0.5, 0.63},
                    new double[] {109, 0.6, 0.45},
                    new double[] {110, 0.2, 1.57},
                    new double[] {110, 0.25, 1.4},
                    new double[] {110, 0.3, 1.14},
                    new double[] {110, 0.4, 0.93},
                    new double[] {110, 0.5, 0.63},
                    new double[] {110, 0.6, 0.45},
                    new double[] {111, 0.2, 1.58},
                    new double[] {111, 0.25, 1.41},
                    new double[] {111, 0.3, 1.15},
                    new double[] {111, 0.4, 0.93},
                    new double[] {111, 0.5, 0.64},
                    new double[] {111, 0.6, 0.46},
                    new double[] {112, 0.2, 1.59},
                    new double[] {112, 0.25, 1.42},
                    new double[] {112, 0.3, 1.16},
                    new double[] {112, 0.4, 0.94},
                    new double[] {112, 0.5, 0.64},
                    new double[] {112, 0.6, 0.46},
                    new double[] {113, 0.2, 1.6},
                    new double[] {113, 0.25, 1.43},
                    new double[] {113, 0.3, 1.17},
                    new double[] {113, 0.4, 0.95},
                    new double[] {113, 0.5, 0.65},
                    new double[] {113, 0.6, 0.46},
                    new double[] {114, 0.2, 1.62},
                    new double[] {114, 0.25, 1.44},
                    new double[] {114, 0.3, 1.18},
                    new double[] {114, 0.4, 0.96},
                    new double[] {114, 0.5, 0.65},
                    new double[] {114, 0.6, 0.47},
                    new double[] {115, 0.2, 1.63},
                    new double[] {115, 0.25, 1.45},
                    new double[] {115, 0.3, 1.19},
                    new double[] {115, 0.4, 0.96},
                    new double[] {115, 0.5, 0.66},
                    new double[] {115, 0.6, 0.47},
                    new double[] {116, 0.2, 1.64},
                    new double[] {116, 0.25, 1.47},
                    new double[] {116, 0.3, 1.2},
                    new double[] {116, 0.4, 0.97},
                    new double[] {116, 0.5, 0.66},
                    new double[] {116, 0.6, 0.48},
                    new double[] {117, 0.2, 1.65},
                    new double[] {117, 0.25, 1.48},
                    new double[] {117, 0.3, 1.2},
                    new double[] {117, 0.4, 0.98},
                    new double[] {117, 0.5, 0.67},
                    new double[] {117, 0.6, 0.48},
                    new double[] {118, 0.2, 1.67},
                    new double[] {118, 0.25, 1.49},
                    new double[] {118, 0.3, 1.21},
                    new double[] {118, 0.4, 0.99},
                    new double[] {118, 0.5, 0.67},
                    new double[] {118, 0.6, 0.48},
                    new double[] {119, 0.2, 1.68},
                    new double[] {119, 0.25, 1.5},
                    new double[] {119, 0.3, 1.22},
                    new double[] {119, 0.4, 0.99},
                    new double[] {119, 0.5, 0.68},
                    new double[] {119, 0.6, 0.49},
                    new double[] {120, 0.2, 1.69},
                    new double[] {120, 0.25, 1.51},
                    new double[] {120, 0.3, 1.23},
                    new double[] {120, 0.4, 1},
                    new double[] {120, 0.5, 0.68},
                    new double[] {120, 0.6, 0.49},
                    new double[] {121, 0.2, 1.7},
                    new double[] {121, 0.25, 1.52},
                    new double[] {121, 0.3, 1.24},
                    new double[] {121, 0.4, 1.01},
                    new double[] {121, 0.5, 0.69},
                    new double[] {121, 0.6, 0.49},
                    new double[] {122, 0.2, 1.72},
                    new double[] {122, 0.25, 1.53},
                    new double[] {122, 0.3, 1.25},
                    new double[] {122, 0.4, 1.02},
                    new double[] {122, 0.5, 0.69},
                    new double[] {122, 0.6, 0.5},
                    new double[] {123, 0.2, 1.73},
                    new double[] {123, 0.25, 1.54},
                    new double[] {123, 0.3, 1.26},
                    new double[] {123, 0.4, 1.02},
                    new double[] {123, 0.5, 0.7},
                    new double[] {123, 0.6, 0.5},
                    new double[] {124, 0.2, 1.74},
                    new double[] {124, 0.25, 1.56},
                    new double[] {124, 0.3, 1.27},
                    new double[] {124, 0.4, 1.03},
                    new double[] {124, 0.5, 0.7},
                    new double[] {124, 0.6, 0.51},
                    new double[] {125, 0.2, 1.75},
                    new double[] {125, 0.25, 1.57},
                    new double[] {125, 0.3, 1.27},
                    new double[] {125, 0.4, 1.04},
                    new double[] {125, 0.5, 0.71},
                    new double[] {125, 0.6, 0.51},
                    new double[] {126, 0.2, 1.77},
                    new double[] {126, 0.25, 1.58},
                    new double[] {126, 0.3, 1.28},
                    new double[] {126, 0.4, 1.05},
                    new double[] {126, 0.5, 0.71},
                    new double[] {126, 0.6, 0.51},
                    new double[] {127, 0.2, 1.78},
                    new double[] {127, 0.25, 1.59},
                    new double[] {127, 0.3, 1.29},
                    new double[] {127, 0.4, 1.05},
                    new double[] {127, 0.5, 0.72},
                    new double[] {127, 0.6, 0.52},
                    new double[] {128, 0.2, 1.79},
                    new double[] {128, 0.25, 1.6},
                    new double[] {128, 0.3, 1.3},
                    new double[] {128, 0.4, 1.06},
                    new double[] {128, 0.5, 0.72},
                    new double[] {128, 0.6, 0.52},
                    new double[] {129, 0.2, 1.8},
                    new double[] {129, 0.25, 1.61},
                    new double[] {129, 0.3, 1.31},
                    new double[] {129, 0.4, 1.07},
                    new double[] {129, 0.5, 0.73},
                    new double[] {129, 0.6, 0.52},
                    new double[] {130, 0.2, 1.82},
                    new double[] {130, 0.25, 1.62},
                    new double[] {130, 0.3, 1.32},
                    new double[] {130, 0.4, 1.08},
                    new double[] {130, 0.5, 0.73},
                    new double[] {130, 0.6, 0.53},
                    new double[] {131, 0.2, 1.83},
                    new double[] {131, 0.25, 1.63},
                    new double[] {131, 0.3, 1.33},
                    new double[] {131, 0.4, 1.08},
                    new double[] {131, 0.5, 0.74},
                    new double[] {131, 0.6, 0.53},
                    new double[] {132, 0.2, 1.84},
                    new double[] {132, 0.25, 1.65},
                    new double[] {132, 0.3, 1.34},
                    new double[] {132, 0.4, 1.09},
                    new double[] {132, 0.5, 0.74},
                    new double[] {132, 0.6, 0.54},
                    new double[] {133, 0.2, 1.85},
                    new double[] {133, 0.25, 1.66},
                    new double[] {133, 0.3, 1.34},
                    new double[] {133, 0.4, 1.1},
                    new double[] {133, 0.5, 0.75},
                    new double[] {133, 0.6, 0.54},
                    new double[] {134, 0.2, 1.87},
                    new double[] {134, 0.25, 1.67},
                    new double[] {134, 0.3, 1.35},
                    new double[] {134, 0.4, 1.11},
                    new double[] {134, 0.5, 0.75},
                    new double[] {134, 0.6, 0.54},
                    new double[] {135, 0.2, 1.88},
                    new double[] {135, 0.25, 1.68},
                    new double[] {135, 0.3, 1.36},
                    new double[] {135, 0.4, 1.11},
                    new double[] {135, 0.5, 0.76},
                    new double[] {135, 0.6, 0.55},
                    new double[] {136, 0.2, 1.89},
                    new double[] {136, 0.25, 1.69},
                    new double[] {136, 0.3, 1.37},
                    new double[] {136, 0.4, 1.12},
                    new double[] {136, 0.5, 0.76},
                    new double[] {136, 0.6, 0.55},
                    new double[] {137, 0.2, 1.9},
                    new double[] {137, 0.25, 1.7},
                    new double[] {137, 0.3, 1.38},
                    new double[] {137, 0.4, 1.13},
                    new double[] {137, 0.5, 0.77},
                    new double[] {137, 0.6, 0.55},
                    new double[] {138, 0.2, 1.92},
                    new double[] {138, 0.25, 1.71},
                    new double[] {138, 0.3, 1.39},
                    new double[] {138, 0.4, 1.14},
                    new double[] {138, 0.5, 0.77},
                    new double[] {138, 0.6, 0.56},
                    new double[] {139, 0.2, 1.93},
                    new double[] {139, 0.25, 1.72},
                    new double[] {139, 0.3, 1.4},
                    new double[] {139, 0.4, 1.14},
                    new double[] {139, 0.5, 0.78},
                    new double[] {139, 0.6, 0.56},
                    new double[] {140, 0.2, 1.94},
                    new double[] {140, 0.25, 1.74},
                    new double[] {140, 0.3, 1.41},
                    new double[] {140, 0.4, 1.15},
                    new double[] {140, 0.5, 0.78},
                    new double[] {140, 0.6, 0.57},
                    new double[] {141, 0.2, 1.95},
                    new double[] {141, 0.25, 1.75},
                    new double[] {141, 0.3, 1.41},
                    new double[] {141, 0.4, 1.16},
                    new double[] {141, 0.5, 0.79},
                    new double[] {141, 0.6, 0.57},
                    new double[] {142, 0.2, 1.97},
                    new double[] {142, 0.25, 1.76},
                    new double[] {142, 0.3, 1.42},
                    new double[] {142, 0.4, 1.17},
                    new double[] {142, 0.5, 0.79},
                    new double[] {142, 0.6, 0.57},
                    new double[] {143, 0.2, 1.98},
                    new double[] {143, 0.25, 1.77},
                    new double[] {143, 0.3, 1.43},
                    new double[] {143, 0.4, 1.17},
                    new double[] {143, 0.5, 0.8},
                    new double[] {143, 0.6, 0.58},
                    new double[] {144, 0.2, 1.99},
                    new double[] {144, 0.25, 1.78},
                    new double[] {144, 0.3, 1.44},
                    new double[] {144, 0.4, 1.18},
                    new double[] {144, 0.5, 0.8},
                    new double[] {144, 0.6, 0.58},
                    new double[] {145, 0.2, 2},
                    new double[] {145, 0.25, 1.79},
                    new double[] {145, 0.3, 1.45},
                    new double[] {145, 0.4, 1.19},
                    new double[] {145, 0.5, 0.81},
                    new double[] {145, 0.6, 0.58},
                    new double[] {146, 0.2, 2.02},
                    new double[] {146, 0.25, 1.8},
                    new double[] {146, 0.3, 1.46},
                    new double[] {146, 0.4, 1.2},
                    new double[] {146, 0.5, 0.81},
                    new double[] {146, 0.6, 0.59},
                    new double[] {147, 0.2, 2.03},
                    new double[] {147, 0.25, 1.81},
                    new double[] {147, 0.3, 1.47},
                    new double[] {147, 0.4, 1.2},
                    new double[] {147, 0.5, 0.82},
                    new double[] {147, 0.6, 0.59},
                    new double[] {148, 0.2, 2.04},
                    new double[] {148, 0.25, 1.83},
                    new double[] {148, 0.3, 1.48},
                    new double[] {148, 0.4, 1.21},
                    new double[] {148, 0.5, 0.82},
                    new double[] {148, 0.6, 0.6},
                    new double[] {149, 0.2, 2.05},
                    new double[] {149, 0.25, 1.84},
                    new double[] {149, 0.3, 1.48},
                    new double[] {149, 0.4, 1.22},
                    new double[] {149, 0.5, 0.83},
                    new double[] {149, 0.6, 0.6},
                    new double[] {150, 0.2, 2.07},
                    new double[] {150, 0.25, 1.85},
                    new double[] {150, 0.3, 1.49},
                    new double[] {150, 0.4, 1.23},
                    new double[] {150, 0.5, 0.83},
                    new double[] {150, 0.6, 0.6},
                    new double[] {151, 0.2, 2.08},
                    new double[] {151, 0.25, 1.86},
                    new double[] {151, 0.3, 1.5},
                    new double[] {151, 0.4, 1.23},
                    new double[] {151, 0.5, 0.84},
                    new double[] {151, 0.6, 0.61},
                    new double[] {152, 0.2, 2.09},
                    new double[] {152, 0.25, 1.87},
                    new double[] {152, 0.3, 1.51},
                    new double[] {152, 0.4, 1.24},
                    new double[] {152, 0.5, 0.84},
                    new double[] {152, 0.6, 0.61},
                    new double[] {153, 0.2, 2.1},
                    new double[] {153, 0.25, 1.88},
                    new double[] {153, 0.3, 1.52},
                    new double[] {153, 0.4, 1.25},
                    new double[] {153, 0.5, 0.85},
                    new double[] {153, 0.6, 0.61},
                    new double[] {154, 0.2, 2.12},
                    new double[] {154, 0.25, 1.89},
                    new double[] {154, 0.3, 1.53},
                    new double[] {154, 0.4, 1.26},
                    new double[] {154, 0.5, 0.85},
                    new double[] {154, 0.6, 0.62},
                    new double[] {155, 0.2, 2.13},
                    new double[] {155, 0.25, 1.9},
                    new double[] {155, 0.3, 1.54},
                    new double[] {155, 0.4, 1.26},
                    new double[] {155, 0.5, 0.86},
                    new double[] {155, 0.6, 0.62},
                    new double[] {156, 0.2, 2.14},
                    new double[] {156, 0.25, 1.92},
                    new double[] {156, 0.3, 1.55},
                    new double[] {156, 0.4, 1.27},
                    new double[] {156, 0.5, 0.86},
                    new double[] {156, 0.6, 0.63},
                    new double[] {157, 0.2, 2.15},
                    new double[] {157, 0.25, 1.93},
                    new double[] {157, 0.3, 1.55},
                    new double[] {157, 0.4, 1.28},
                    new double[] {157, 0.5, 0.87},
                    new double[] {157, 0.6, 0.63},
                    new double[] {158, 0.2, 2.17},
                    new double[] {158, 0.25, 1.94},
                    new double[] {158, 0.3, 1.56},
                    new double[] {158, 0.4, 1.29},
                    new double[] {158, 0.5, 0.87},
                    new double[] {158, 0.6, 0.63},
                    new double[] {159, 0.2, 2.18},
                    new double[] {159, 0.25, 1.95},
                    new double[] {159, 0.3, 1.57},
                    new double[] {159, 0.4, 1.29},
                    new double[] {159, 0.5, 0.88},
                    new double[] {159, 0.6, 0.64},
                    new double[] {160, 0.2, 2.19},
                    new double[] {160, 0.25, 1.96},
                    new double[] {160, 0.3, 1.58},
                    new double[] {160, 0.4, 1.3},
                    new double[] {160, 0.5, 0.88},
                    new double[] {160, 0.6, 0.64},
                    new double[] {161, 0.2, 2.2},
                    new double[] {161, 0.25, 1.97},
                    new double[] {161, 0.3, 1.59},
                    new double[] {161, 0.4, 1.31},
                    new double[] {161, 0.5, 0.89},
                    new double[] {161, 0.6, 0.64},
                    new double[] {162, 0.2, 2.22},
                    new double[] {162, 0.25, 1.98},
                    new double[] {162, 0.3, 1.6},
                    new double[] {162, 0.4, 1.32},
                    new double[] {162, 0.5, 0.89},
                    new double[] {162, 0.6, 0.65},
                    new double[] {163, 0.2, 2.23},
                    new double[] {163, 0.25, 1.99},
                    new double[] {163, 0.3, 1.61},
                    new double[] {163, 0.4, 1.32},
                    new double[] {163, 0.5, 0.9},
                    new double[] {163, 0.6, 0.65},
                    new double[] {164, 0.2, 2.24},
                    new double[] {164, 0.25, 2.01},
                    new double[] {164, 0.3, 1.62},
                    new double[] {164, 0.4, 1.33},
                    new double[] {164, 0.5, 0.9},
                    new double[] {164, 0.6, 0.66},
                    new double[] {165, 0.2, 2.25},
                    new double[] {165, 0.25, 2.02},
                    new double[] {165, 0.3, 1.62},
                    new double[] {165, 0.4, 1.34},
                    new double[] {165, 0.5, 0.91},
                    new double[] {165, 0.6, 0.66},
                    new double[] {166, 0.2, 2.27},
                    new double[] {166, 0.25, 2.03},
                    new double[] {166, 0.3, 1.63},
                    new double[] {166, 0.4, 1.35},
                    new double[] {166, 0.5, 0.91},
                    new double[] {166, 0.6, 0.66},
                    new double[] {167, 0.2, 2.28},
                    new double[] {167, 0.25, 2.04},
                    new double[] {167, 0.3, 1.64},
                    new double[] {167, 0.4, 1.35},
                    new double[] {167, 0.5, 0.92},
                    new double[] {167, 0.6, 0.67},
                    new double[] {168, 0.2, 2.29},
                    new double[] {168, 0.25, 2.05},
                    new double[] {168, 0.3, 1.65},
                    new double[] {168, 0.4, 1.36},
                    new double[] {168, 0.5, 0.92},
                    new double[] {168, 0.6, 0.67},
                    new double[] {169, 0.2, 2.3},
                    new double[] {169, 0.25, 2.06},
                    new double[] {169, 0.3, 1.66},
                    new double[] {169, 0.4, 1.37},
                    new double[] {169, 0.5, 0.93},
                    new double[] {169, 0.6, 0.67},
                    new double[] {170, 0.2, 2.32},
                    new double[] {170, 0.25, 2.07},
                    new double[] {170, 0.3, 1.67},
                    new double[] {170, 0.4, 1.38},
                    new double[] {170, 0.5, 0.93},
                    new double[] {170, 0.6, 0.68},
                    new double[] {171, 0.2, 2.33},
                    new double[] {171, 0.25, 2.08},
                    new double[] {171, 0.3, 1.68},
                    new double[] {171, 0.4, 1.38},
                    new double[] {171, 0.5, 0.94},
                    new double[] {171, 0.6, 0.68},
                    new double[] {172, 0.2, 2.34},
                    new double[] {172, 0.25, 2.1},
                    new double[] {172, 0.3, 1.69},
                    new double[] {172, 0.4, 1.39},
                    new double[] {172, 0.5, 0.94},
                    new double[] {172, 0.6, 0.69},
                    new double[] {173, 0.2, 2.35},
                    new double[] {173, 0.25, 2.11},
                    new double[] {173, 0.3, 1.69},
                    new double[] {173, 0.4, 1.4},
                    new double[] {173, 0.5, 0.95},
                    new double[] {173, 0.6, 0.69},
                    new double[] {174, 0.2, 2.37},
                    new double[] {174, 0.25, 2.12},
                    new double[] {174, 0.3, 1.7},
                    new double[] {174, 0.4, 1.41},
                    new double[] {174, 0.5, 0.95},
                    new double[] {174, 0.6, 0.69},
                    new double[] {175, 0.2, 2.38},
                    new double[] {175, 0.25, 2.13},
                    new double[] {175, 0.3, 1.71},
                    new double[] {175, 0.4, 1.41},
                    new double[] {175, 0.5, 0.96},
                    new double[] {175, 0.6, 0.7},
                    new double[] {176, 0.2, 2.39},
                    new double[] {176, 0.25, 2.14},
                    new double[] {176, 0.3, 1.72},
                    new double[] {176, 0.4, 1.42},
                    new double[] {176, 0.5, 0.96},
                    new double[] {176, 0.6, 0.7},
                    new double[] {177, 0.2, 2.4},
                    new double[] {177, 0.25, 2.15},
                    new double[] {177, 0.3, 1.73},
                    new double[] {177, 0.4, 1.43},
                    new double[] {177, 0.5, 0.97},
                    new double[] {177, 0.6, 0.7},
                    new double[] {178, 0.2, 2.42},
                    new double[] {178, 0.25, 2.16},
                    new double[] {178, 0.3, 1.74},
                    new double[] {178, 0.4, 1.44},
                    new double[] {178, 0.5, 0.97},
                    new double[] {178, 0.6, 0.71},
                    new double[] {179, 0.2, 2.43},
                    new double[] {179, 0.25, 2.17},
                    new double[] {179, 0.3, 1.75},
                    new double[] {179, 0.4, 1.44},
                    new double[] {179, 0.5, 0.98},
                    new double[] {179, 0.6, 0.71},
                    new double[] {180, 0.2, 2.44},
                    new double[] {180, 0.25, 2.19},
                    new double[] {180, 0.3, 1.76},
                    new double[] {180, 0.4, 1.45},
                    new double[] {180, 0.5, 0.98},
                    new double[] {180, 0.6, 0.72}
                };

                foreach (double[] str in table_kms_rectangle_to_rectangle_rasshirenie)
                {
                    if ((alfa_new == str[0]) && (k_ploschadi_privedenniy == str[1])) return str[2];
                }

                return 2.4;
            }

            else
            {
                alfa = Math.Min(alfa1, alfa2);
                alfa = Math.Round(alfa);

                alfa_new = 40;

                double[][] table_alfa_new_rectangle_to_rectangle_sujenie =
                {
                    new double[] {0, 10},
                    new double[] {1, 10},
                    new double[] {2, 10},
                    new double[] {3, 10},
                    new double[] {4, 10},
                    new double[] {5, 10},
                    new double[] {6, 10},
                    new double[] {7, 10},
                    new double[] {8, 10},
                    new double[] {9, 10},
                    new double[] {10, 10},
                    new double[] {11, 10},
                    new double[] {12, 10},
                    new double[] {13, 10},
                    new double[] {14, 10},
                    new double[] {15, 10},
                    new double[] {16, 10},
                    new double[] {17, 10},
                    new double[] {18, 10},
                    new double[] {19, 10},
                    new double[] {20, 20},
                    new double[] {21, 20},
                    new double[] {22, 20},
                    new double[] {23, 20},
                    new double[] {24, 20},
                    new double[] {25, 20},
                    new double[] {26, 20},
                    new double[] {27, 20},
                    new double[] {28, 20},
                    new double[] {29, 20},
                    new double[] {30, 30},
                    new double[] {31, 30},
                    new double[] {32, 30},
                    new double[] {33, 30},
                    new double[] {34, 30},
                    new double[] {35, 30},
                    new double[] {36, 30},
                    new double[] {37, 30},
                    new double[] {38, 30},
                    new double[] {39, 30},
                    new double[] {40, 40}
                };

                foreach (double[] str in table_alfa_new_rectangle_to_rectangle_sujenie)
                {
                    if (alfa == str[0])
                    {
                        alfa_new = str[1];
                        break;
                    }
                }

                double dlina_k_d_ekv_min_new = dlina_k_d_ekv_min;

                double[][] table_dlina_k_d_ekv_min_new =
                {
                    new double[] {0, 0.1},
                    new double[] {0.01, 0.1},
                    new double[] {0.02, 0.1},
                    new double[] {0.03, 0.1},
                    new double[] {0.04, 0.1},
                    new double[] {0.05, 0.1},
                    new double[] {0.06, 0.1},
                    new double[] {0.07, 0.1},
                    new double[] {0.08, 0.1},
                    new double[] {0.09, 0.1},
                    new double[] {0.1, 0.1},
                    new double[] {0.11, 0.1},
                    new double[] {0.12, 0.1},
                    new double[] {0.13, 0.1},
                    new double[] {0.14, 0.1},
                    new double[] {0.15, 0.15},
                    new double[] {0.16, 0.15},
                    new double[] {0.17, 0.15},
                    new double[] {0.18, 0.15},
                    new double[] {0.19, 0.15},
                    new double[] {0.2, 0.15},
                    new double[] {0.21, 0.15},
                    new double[] {0.22, 0.15},
                    new double[] {0.23, 0.15},
                    new double[] {0.24, 0.15},
                    new double[] {0.25, 0.15},
                    new double[] {0.26, 0.15},
                    new double[] {0.27, 0.15},
                    new double[] {0.28, 0.15},
                    new double[] {0.29, 0.15},
                    new double[] {0.3, 0.15},
                    new double[] {0.31, 0.15},
                    new double[] {0.32, 0.15},
                    new double[] {0.33, 0.15},
                    new double[] {0.34, 0.15},
                    new double[] {0.35, 0.15},
                    new double[] {0.36, 0.15},
                    new double[] {0.37, 0.15},
                    new double[] {0.38, 0.15},
                    new double[] {0.39, 0.15},
                    new double[] {0.4, 0.15},
                    new double[] {0.41, 0.15},
                    new double[] {0.42, 0.15},
                    new double[] {0.43, 0.15},
                    new double[] {0.44, 0.15},
                    new double[] {0.45, 0.15},
                    new double[] {0.46, 0.15},
                    new double[] {0.47, 0.15},
                    new double[] {0.48, 0.15},
                    new double[] {0.49, 0.15},
                    new double[] {0.5, 0.15},
                    new double[] {0.51, 0.15},
                    new double[] {0.52, 0.15},
                    new double[] {0.53, 0.15},
                    new double[] {0.54, 0.15},
                    new double[] {0.55, 0.15},
                    new double[] {0.56, 0.15},
                    new double[] {0.57, 0.15},
                    new double[] {0.58, 0.15},
                    new double[] {0.59, 0.15},
                    new double[] {0.6, 0.6}
                };

                foreach (double[] str in table_dlina_k_d_ekv_min_new)
                {
                    if (dlina_k_d_ekv_min == str[0])
                    {
                        dlina_k_d_ekv_min_new = str[1];
                        break;
                    }
                }

                if (dlina_k_d_ekv_min_new > 0.6)
                {
                    return 0.1;
                }
                else
                {
                    double[][] table_kms_rectangle_to_rectangle_sujenie =
                    {
                        new double[] {10, 0.1, 0.41},
                        new double[] {10, 0.15, 0.39},
                        new double[] {10, 0.6, 0.29},
                        new double[] {20, 0.1, 0.34},
                        new double[] {20, 0.15, 0.29},
                        new double[] {20, 0.6, 0.2},
                        new double[] {30, 0.1, 0.27},
                        new double[] {30, 0.15, 0.22},
                        new double[] {30, 0.6, 0.15},
                        new double[] {40, 0.1, 0.24},
                        new double[] {40, 0.15, 0.18},
                        new double[] {40, 0.6, 0.13}
                    };

                    foreach (double[] str in table_alfa_new_rectangle_to_rectangle_sujenie)
                    {
                        if ( (alfa_new == str[0]) && (dlina_k_d_ekv_min_new == str[1]) )
                        {
                            return str[2];
                        }
                    }

                    return 0.4;
                }
            }
        }

        private double Take_kms_circle_to_circle(double diam_1, double diam_2, double dlina_perehoda)
        {
            if (diam_1 <= 0)
            {
                return 0;
            }

            if (diam_2 <= 0)
            {
                return 0;
            }

            if (dlina_perehoda < 0)
            {
                return 0;
            }

            double d1;
            double d2;

            double alfa;

            if (_vitiajka_tru_pritok_false)
            {
                d1 = diam_1;
                d2 = diam_2;
            }
            else
            {
                d1 = diam_2;
                d2 = diam_1;
            }

            if (dlina_perehoda == 0)
            {
                double Ploschad_1 = (Math.PI * (Math.Pow(d1, 2.0))) / 4.0;
                double Ploschad_2 = (Math.PI * (Math.Pow(d2, 2.0))) / 4.0;

                if ((Ploschad_1 == 0) || (Ploschad_2 == 0)) return 0;
                else if (Ploschad_2 > Ploschad_1)
                {
                    return Math.Pow((1 - (Ploschad_1 / Ploschad_2)), 2.0);
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

            double r1 = (d1 / 2.0);
            double r2 = (d2 / 2.0);

            double r_max = Math.Max(r1, r2);
            double r_min = Math.Min(r1, r2);

            double f1 = ((Math.PI * Math.Pow(d1, 2.0)) / 4.0);
            double f2 = ((Math.PI * Math.Pow(d2, 2.0)) / 4.0);

            double f_max = Math.Max(f1, f2);
            double f_min = Math.Min(f1, f2);

            double f_max_na_f_min = (f_max / f_min);
            f_max_na_f_min = ((Math.Round(f_max_na_f_min * 100.0)) / 100.0);

            double f_min_na_f_max = (f_min / f_max);
            f_min_na_f_max = ((Math.Round(f_min_na_f_max * 100.0)) / 100.0);

            alfa = Math.Round(2.0 * (90.0 - (180.0 / Math.PI)*Math.Atan(dlina_perehoda/(r_max - r_min)) ) );

            double alfa_rasshirenie = 40;

            double[][] table_alfa_rasshirenie =
            {
                new double[] {0, 10},
                new double[] {1, 10},
                new double[] {2, 10},
                new double[] {3, 10},
                new double[] {4, 10},
                new double[] {5, 10},
                new double[] {6, 10},
                new double[] {7, 10},
                new double[] {8, 10},
                new double[] {9, 10},
                new double[] {10, 10},
                new double[] {11, 12},
                new double[] {12, 12},
                new double[] {13, 14},
                new double[] {14, 14},
                new double[] {15, 16},
                new double[] {16, 16},
                new double[] {17, 18},
                new double[] {18, 18},
                new double[] {19, 20},
                new double[] {20, 20},
                new double[] {21, 24},
                new double[] {22, 24},
                new double[] {23, 24},
                new double[] {24, 24},
                new double[] {25, 28},
                new double[] {26, 28},
                new double[] {27, 28},
                new double[] {28, 28},
                new double[] {29, 30},
                new double[] {30, 30},
                new double[] {31, 32},
                new double[] {32, 32},
                new double[] {33, 40},
                new double[] {34, 40},
                new double[] {35, 40},
                new double[] {36, 40},
                new double[] {37, 40},
                new double[] {38, 40},
                new double[] {39, 40},
                new double[] {40, 40},
                new double[] {41, 41},
                new double[] {42, 42},
                new double[] {43, 43},
                new double[] {44, 44},
                new double[] {45, 45},
                new double[] {46, 46},
                new double[] {47, 47},
                new double[] {48, 48},
                new double[] {49, 49},
                new double[] {50, 50},
                new double[] {51, 51},
                new double[] {52, 52},
                new double[] {53, 53},
                new double[] {54, 54},
                new double[] {55, 55},
                new double[] {56, 56},
                new double[] {57, 57},
                new double[] {58, 58},
                new double[] {59, 59},
                new double[] {60, 60},
                new double[] {61, 61},
                new double[] {62, 62},
                new double[] {63, 63},
                new double[] {64, 64},
                new double[] {65, 65},
                new double[] {66, 66},
                new double[] {67, 67},
                new double[] {68, 68},
                new double[] {69, 69},
                new double[] {70, 70},
                new double[] {71, 71},
                new double[] {72, 72},
                new double[] {73, 73},
                new double[] {74, 74},
                new double[] {75, 75},
                new double[] {76, 76},
                new double[] {77, 77},
                new double[] {78, 78},
                new double[] {79, 79},
                new double[] {80, 80},
                new double[] {81, 81},
                new double[] {82, 82},
                new double[] {83, 83},
                new double[] {84, 84},
                new double[] {85, 85},
                new double[] {86, 86},
                new double[] {87, 87},
                new double[] {88, 88},
                new double[] {89, 89},
                new double[] {90, 90},
                new double[] {91, 91},
                new double[] {92, 92},
                new double[] {93, 93},
                new double[] {94, 94},
                new double[] {95, 95},
                new double[] {96, 96},
                new double[] {97, 97},
                new double[] {98, 98},
                new double[] {99, 99},
                new double[] {100, 100},
                new double[] {101, 101},
                new double[] {102, 102},
                new double[] {103, 103},
                new double[] {104, 104},
                new double[] {105, 105},
                new double[] {106, 106},
                new double[] {107, 107},
                new double[] {108, 108},
                new double[] {109, 109},
                new double[] {110, 110},
                new double[] {111, 111},
                new double[] {112, 112},
                new double[] {113, 113},
                new double[] {114, 114},
                new double[] {115, 115},
                new double[] {116, 116},
                new double[] {117, 117},
                new double[] {118, 118},
                new double[] {119, 119},
                new double[] {120, 120},
                new double[] {121, 121},
                new double[] {122, 122},
                new double[] {123, 123},
                new double[] {124, 124},
                new double[] {125, 125},
                new double[] {126, 126},
                new double[] {127, 127},
                new double[] {128, 128},
                new double[] {129, 129},
                new double[] {130, 130},
                new double[] {131, 131},
                new double[] {132, 132},
                new double[] {133, 133},
                new double[] {134, 134},
                new double[] {135, 135},
                new double[] {136, 136},
                new double[] {137, 137},
                new double[] {138, 138},
                new double[] {139, 139},
                new double[] {140, 140},
                new double[] {141, 141},
                new double[] {142, 142},
                new double[] {143, 143},
                new double[] {144, 144},
                new double[] {145, 145},
                new double[] {146, 146},
                new double[] {147, 147},
                new double[] {148, 148},
                new double[] {149, 149},
                new double[] {150, 150},
                new double[] {151, 151},
                new double[] {152, 152},
                new double[] {153, 153},
                new double[] {154, 154},
                new double[] {155, 155},
                new double[] {156, 156},
                new double[] {157, 157},
                new double[] {158, 158},
                new double[] {159, 159},
                new double[] {160, 160},
                new double[] {161, 161},
                new double[] {162, 162},
                new double[] {163, 163},
                new double[] {164, 164},
                new double[] {165, 165},
                new double[] {166, 166},
                new double[] {167, 167},
                new double[] {168, 168},
                new double[] {169, 169},
                new double[] {170, 170},
                new double[] {171, 171},
                new double[] {172, 172},
                new double[] {173, 173},
                new double[] {174, 174},
                new double[] {175, 175},
                new double[] {176, 176},
                new double[] {177, 177},
                new double[] {178, 178},
                new double[] {179, 179},
                new double[] {180, 180}
            };

            foreach (double[] str in table_alfa_rasshirenie)
            {
                if (alfa == str[0])
                {
                    alfa_rasshirenie = str[1];
                    break;
                }
            }

            double f_min_k_f_max_rasshirenie = 0.2;

            double[][] table_f_min_k_f_max_rasshirenie =
            {
                new double[] {0, 0.2},
                new double[] {0.01, 0.2},
                new double[] {0.02, 0.2},
                new double[] {0.03, 0.2},
                new double[] {0.04, 0.2},
                new double[] {0.05, 0.2},
                new double[] {0.06, 0.2},
                new double[] {0.07, 0.2},
                new double[] {0.08, 0.2},
                new double[] {0.09, 0.2},
                new double[] {0.1, 0.2},
                new double[] {0.11, 0.2},
                new double[] {0.12, 0.2},
                new double[] {0.13, 0.2},
                new double[] {0.14, 0.2},
                new double[] {0.15, 0.2},
                new double[] {0.16, 0.2},
                new double[] {0.17, 0.2},
                new double[] {0.18, 0.2},
                new double[] {0.19, 0.2},
                new double[] {0.2, 0.2},
                new double[] {0.21, 0.2},
                new double[] {0.22, 0.2},
                new double[] {0.23, 0.2},
                new double[] {0.24, 0.2},
                new double[] {0.25, 0.25},
                new double[] {0.26, 0.25},
                new double[] {0.27, 0.25},
                new double[] {0.28, 0.25},
                new double[] {0.29, 0.25},
                new double[] {0.3, 0.3},
                new double[] {0.31, 0.3},
                new double[] {0.32, 0.3},
                new double[] {0.33, 0.3},
                new double[] {0.34, 0.3},
                new double[] {0.35, 0.3},
                new double[] {0.36, 0.3},
                new double[] {0.37, 0.3},
                new double[] {0.38, 0.3},
                new double[] {0.39, 0.3},
                new double[] {0.4, 0.4},
                new double[] {0.41, 0.4},
                new double[] {0.42, 0.4},
                new double[] {0.43, 0.4},
                new double[] {0.44, 0.4},
                new double[] {0.45, 0.4},
                new double[] {0.46, 0.4},
                new double[] {0.47, 0.4},
                new double[] {0.48, 0.4},
                new double[] {0.49, 0.4},
                new double[] {0.5, 0.5},
                new double[] {0.51, 0.5},
                new double[] {0.52, 0.5},
                new double[] {0.53, 0.5},
                new double[] {0.54, 0.5},
                new double[] {0.55, 0.5},
                new double[] {0.56, 0.5},
                new double[] {0.57, 0.5},
                new double[] {0.58, 0.5},
                new double[] {0.59, 0.5},
                new double[] {0.6, 0.6}
            };

            foreach (double[] str in table_f_min_k_f_max_rasshirenie)
            {
                if (f_min_na_f_max == str[0])
                {
                    f_min_k_f_max_rasshirenie = str[1];
                    break;
                }
            }

            double alfa_sujenie = 40;

            double[][] table_alfa_sujenie =
            {
                new double[] {0, 10},
                new double[] {1, 10},
                new double[] {2, 10},
                new double[] {3, 10},
                new double[] {4, 10},
                new double[] {5, 10},
                new double[] {6, 10},
                new double[] {7, 10},
                new double[] {8, 10},
                new double[] {9, 10},
                new double[] {10, 10},
                new double[] {11, 10},
                new double[] {12, 10},
                new double[] {13, 10},
                new double[] {14, 10},
                new double[] {15, 10},
                new double[] {16, 10},
                new double[] {17, 10},
                new double[] {18, 10},
                new double[] {19, 10},
                new double[] {20, 20},
                new double[] {21, 20},
                new double[] {22, 20},
                new double[] {23, 20},
                new double[] {24, 20},
                new double[] {25, 20},
                new double[] {26, 20},
                new double[] {27, 20},
                new double[] {28, 20},
                new double[] {29, 20},
                new double[] {30, 30},
                new double[] {31, 30},
                new double[] {32, 30},
                new double[] {33, 30},
                new double[] {34, 30},
                new double[] {35, 30},
                new double[] {36, 30},
                new double[] {37, 30},
                new double[] {38, 30},
                new double[] {39, 30},
                new double[] {40, 40}
            };

            foreach (double[] str in table_alfa_sujenie)
            {
                if (alfa == str[0])
                {
                    alfa_sujenie = str[1];
                    break;
                }
            }

            double dlina_k_d_min = ((Math.Round((dlina_perehoda / (r_min * 2.0)) * 100.0)) / 100.0);

            double dlina_k_d_min_sujenie = 0.1;

            double[][] table_dlina_k_d_min_sujenie =
            {
                new double[] {0, 0.1},
                new double[] {0.01, 0.1},
                new double[] {0.02, 0.1},
                new double[] {0.03, 0.1},
                new double[] {0.04, 0.1},
                new double[] {0.05, 0.1},
                new double[] {0.06, 0.1},
                new double[] {0.07, 0.1},
                new double[] {0.08, 0.1},
                new double[] {0.09, 0.1},
                new double[] {0.1, 0.1},
                new double[] {0.11, 0.1},
                new double[] {0.12, 0.1},
                new double[] {0.13, 0.1},
                new double[] {0.14, 0.1},
                new double[] {0.15, 0.15},
                new double[] {0.16, 0.15},
                new double[] {0.17, 0.15},
                new double[] {0.18, 0.15},
                new double[] {0.19, 0.15},
                new double[] {0.2, 0.15},
                new double[] {0.21, 0.15},
                new double[] {0.22, 0.15},
                new double[] {0.23, 0.15},
                new double[] {0.24, 0.15},
                new double[] {0.25, 0.15},
                new double[] {0.26, 0.15},
                new double[] {0.27, 0.15},
                new double[] {0.28, 0.15},
                new double[] {0.29, 0.15},
                new double[] {0.3, 0.15},
                new double[] {0.31, 0.15},
                new double[] {0.32, 0.15},
                new double[] {0.33, 0.15},
                new double[] {0.34, 0.15},
                new double[] {0.35, 0.15},
                new double[] {0.36, 0.15},
                new double[] {0.37, 0.15},
                new double[] {0.38, 0.15},
                new double[] {0.39, 0.15},
                new double[] {0.4, 0.15},
                new double[] {0.41, 0.15},
                new double[] {0.42, 0.15},
                new double[] {0.43, 0.15},
                new double[] {0.44, 0.15},
                new double[] {0.45, 0.15},
                new double[] {0.46, 0.15},
                new double[] {0.47, 0.15},
                new double[] {0.48, 0.15},
                new double[] {0.49, 0.15},
                new double[] {0.5, 0.15},
                new double[] {0.51, 0.15},
                new double[] {0.52, 0.15},
                new double[] {0.53, 0.15},
                new double[] {0.54, 0.15},
                new double[] {0.55, 0.15},
                new double[] {0.56, 0.15},
                new double[] {0.57, 0.15},
                new double[] {0.58, 0.15},
                new double[] {0.59, 0.15},
                new double[] {0.6, 0.6}
            };

            foreach (double[] str in table_dlina_k_d_min_sujenie)
            {
                if (dlina_k_d_min == str[0])
                {
                    dlina_k_d_min_sujenie = str[1];
                    break;
                }
            }

            double kms_circle_rasshirenie = 3.1;

            double[][] table_kms_circle_rasshirenie =
            {
                new double[] {10, 0.2, 0.12},
                new double[] {12, 0.2, 0.14},
                new double[] {14, 0.2, 0.17},
                new double[] {16, 0.2, 0.19},
                new double[] {18, 0.2, 0.22},
                new double[] {20, 0.2, 0.25},
                new double[] {24, 0.2, 0.32},
                new double[] {28, 0.2, 0.39},
                new double[] {30, 0.2, 0.43},
                new double[] {32, 0.2, 0.47},
                new double[] {40, 0.2, 0.61},
                new double[] {41, 0.2, 0.63},
                new double[] {42, 0.2, 0.65},
                new double[] {43, 0.2, 0.66},
                new double[] {44, 0.2, 0.68},
                new double[] {45, 0.2, 0.7},
                new double[] {46, 0.2, 0.72},
                new double[] {47, 0.2, 0.73},
                new double[] {48, 0.2, 0.75},
                new double[] {49, 0.2, 0.77},
                new double[] {50, 0.2, 0.79},
                new double[] {51, 0.2, 0.8},
                new double[] {52, 0.2, 0.82},
                new double[] {53, 0.2, 0.84},
                new double[] {54, 0.2, 0.86},
                new double[] {55, 0.2, 0.87},
                new double[] {56, 0.2, 0.89},
                new double[] {57, 0.2, 0.91},
                new double[] {58, 0.2, 0.93},
                new double[] {59, 0.2, 0.94},
                new double[] {60, 0.2, 0.96},
                new double[] {61, 0.2, 0.98},
                new double[] {62, 0.2, 1},
                new double[] {63, 0.2, 1.01},
                new double[] {64, 0.2, 1.03},
                new double[] {65, 0.2, 1.05},
                new double[] {66, 0.2, 1.07},
                new double[] {67, 0.2, 1.08},
                new double[] {68, 0.2, 1.1},
                new double[] {69, 0.2, 1.12},
                new double[] {70, 0.2, 1.14},
                new double[] {71, 0.2, 1.15},
                new double[] {72, 0.2, 1.17},
                new double[] {73, 0.2, 1.19},
                new double[] {74, 0.2, 1.21},
                new double[] {75, 0.2, 1.22},
                new double[] {76, 0.2, 1.24},
                new double[] {77, 0.2, 1.26},
                new double[] {78, 0.2, 1.28},
                new double[] {79, 0.2, 1.29},
                new double[] {80, 0.2, 1.31},
                new double[] {81, 0.2, 1.33},
                new double[] {82, 0.2, 1.35},
                new double[] {83, 0.2, 1.36},
                new double[] {84, 0.2, 1.38},
                new double[] {85, 0.2, 1.4},
                new double[] {86, 0.2, 1.42},
                new double[] {87, 0.2, 1.43},
                new double[] {88, 0.2, 1.45},
                new double[] {89, 0.2, 1.47},
                new double[] {90, 0.2, 1.49},
                new double[] {91, 0.2, 1.5},
                new double[] {92, 0.2, 1.52},
                new double[] {93, 0.2, 1.54},
                new double[] {94, 0.2, 1.56},
                new double[] {95, 0.2, 1.57},
                new double[] {96, 0.2, 1.59},
                new double[] {97, 0.2, 1.61},
                new double[] {98, 0.2, 1.63},
                new double[] {99, 0.2, 1.64},
                new double[] {100, 0.2, 1.66},
                new double[] {101, 0.2, 1.68},
                new double[] {102, 0.2, 1.7},
                new double[] {103, 0.2, 1.71},
                new double[] {104, 0.2, 1.73},
                new double[] {105, 0.2, 1.75},
                new double[] {106, 0.2, 1.77},
                new double[] {107, 0.2, 1.78},
                new double[] {108, 0.2, 1.8},
                new double[] {109, 0.2, 1.82},
                new double[] {110, 0.2, 1.84},
                new double[] {111, 0.2, 1.85},
                new double[] {112, 0.2, 1.87},
                new double[] {113, 0.2, 1.89},
                new double[] {114, 0.2, 1.91},
                new double[] {115, 0.2, 1.92},
                new double[] {116, 0.2, 1.94},
                new double[] {117, 0.2, 1.96},
                new double[] {118, 0.2, 1.98},
                new double[] {119, 0.2, 1.99},
                new double[] {120, 0.2, 2.01},
                new double[] {121, 0.2, 2.03},
                new double[] {122, 0.2, 2.05},
                new double[] {123, 0.2, 2.06},
                new double[] {124, 0.2, 2.08},
                new double[] {125, 0.2, 2.1},
                new double[] {126, 0.2, 2.12},
                new double[] {127, 0.2, 2.13},
                new double[] {128, 0.2, 2.15},
                new double[] {129, 0.2, 2.17},
                new double[] {130, 0.2, 2.19},
                new double[] {131, 0.2, 2.2},
                new double[] {132, 0.2, 2.22},
                new double[] {133, 0.2, 2.24},
                new double[] {134, 0.2, 2.26},
                new double[] {135, 0.2, 2.27},
                new double[] {136, 0.2, 2.29},
                new double[] {137, 0.2, 2.31},
                new double[] {138, 0.2, 2.33},
                new double[] {139, 0.2, 2.34},
                new double[] {140, 0.2, 2.36},
                new double[] {141, 0.2, 2.38},
                new double[] {142, 0.2, 2.4},
                new double[] {143, 0.2, 2.41},
                new double[] {144, 0.2, 2.43},
                new double[] {145, 0.2, 2.45},
                new double[] {146, 0.2, 2.47},
                new double[] {147, 0.2, 2.48},
                new double[] {148, 0.2, 2.5},
                new double[] {149, 0.2, 2.52},
                new double[] {150, 0.2, 2.54},
                new double[] {151, 0.2, 2.55},
                new double[] {152, 0.2, 2.57},
                new double[] {153, 0.2, 2.59},
                new double[] {154, 0.2, 2.61},
                new double[] {155, 0.2, 2.62},
                new double[] {156, 0.2, 2.64},
                new double[] {157, 0.2, 2.66},
                new double[] {158, 0.2, 2.68},
                new double[] {159, 0.2, 2.69},
                new double[] {160, 0.2, 2.71},
                new double[] {161, 0.2, 2.73},
                new double[] {162, 0.2, 2.75},
                new double[] {163, 0.2, 2.76},
                new double[] {164, 0.2, 2.78},
                new double[] {165, 0.2, 2.8},
                new double[] {166, 0.2, 2.82},
                new double[] {167, 0.2, 2.83},
                new double[] {168, 0.2, 2.85},
                new double[] {169, 0.2, 2.87},
                new double[] {170, 0.2, 2.89},
                new double[] {171, 0.2, 2.9},
                new double[] {172, 0.2, 2.92},
                new double[] {173, 0.2, 2.94},
                new double[] {174, 0.2, 2.96},
                new double[] {175, 0.2, 2.97},
                new double[] {176, 0.2, 2.99},
                new double[] {177, 0.2, 3.01},
                new double[] {178, 0.2, 3.03},
                new double[] {179, 0.2, 3.04},
                new double[] {180, 0.2, 3.06},
                new double[] {10, 0.25, 0.1},
                new double[] {12, 0.25, 0.12},
                new double[] {14, 0.25, 0.15},
                new double[] {16, 0.25, 0.17},
                new double[] {18, 0.25, 0.2},
                new double[] {20, 0.25, 0.22},
                new double[] {24, 0.25, 0.28},
                new double[] {28, 0.25, 0.34},
                new double[] {30, 0.25, 0.37},
                new double[] {32, 0.25, 0.39},
                new double[] {40, 0.25, 0.49},
                new double[] {41, 0.25, 0.5},
                new double[] {42, 0.25, 0.52},
                new double[] {43, 0.25, 0.53},
                new double[] {44, 0.25, 0.54},
                new double[] {45, 0.25, 0.55},
                new double[] {46, 0.25, 0.57},
                new double[] {47, 0.25, 0.58},
                new double[] {48, 0.25, 0.59},
                new double[] {49, 0.25, 0.6},
                new double[] {50, 0.25, 0.62},
                new double[] {51, 0.25, 0.63},
                new double[] {52, 0.25, 0.64},
                new double[] {53, 0.25, 0.65},
                new double[] {54, 0.25, 0.67},
                new double[] {55, 0.25, 0.68},
                new double[] {56, 0.25, 0.69},
                new double[] {57, 0.25, 0.7},
                new double[] {58, 0.25, 0.72},
                new double[] {59, 0.25, 0.73},
                new double[] {60, 0.25, 0.74},
                new double[] {61, 0.25, 0.75},
                new double[] {62, 0.25, 0.77},
                new double[] {63, 0.25, 0.78},
                new double[] {64, 0.25, 0.79},
                new double[] {65, 0.25, 0.8},
                new double[] {66, 0.25, 0.82},
                new double[] {67, 0.25, 0.83},
                new double[] {68, 0.25, 0.84},
                new double[] {69, 0.25, 0.85},
                new double[] {70, 0.25, 0.87},
                new double[] {71, 0.25, 0.88},
                new double[] {72, 0.25, 0.89},
                new double[] {73, 0.25, 0.9},
                new double[] {74, 0.25, 0.92},
                new double[] {75, 0.25, 0.93},
                new double[] {76, 0.25, 0.94},
                new double[] {77, 0.25, 0.95},
                new double[] {78, 0.25, 0.97},
                new double[] {79, 0.25, 0.98},
                new double[] {80, 0.25, 0.99},
                new double[] {81, 0.25, 1},
                new double[] {82, 0.25, 1.02},
                new double[] {83, 0.25, 1.03},
                new double[] {84, 0.25, 1.04},
                new double[] {85, 0.25, 1.05},
                new double[] {86, 0.25, 1.07},
                new double[] {87, 0.25, 1.08},
                new double[] {88, 0.25, 1.09},
                new double[] {89, 0.25, 1.1},
                new double[] {90, 0.25, 1.12},
                new double[] {91, 0.25, 1.13},
                new double[] {92, 0.25, 1.14},
                new double[] {93, 0.25, 1.15},
                new double[] {94, 0.25, 1.17},
                new double[] {95, 0.25, 1.18},
                new double[] {96, 0.25, 1.19},
                new double[] {97, 0.25, 1.2},
                new double[] {98, 0.25, 1.22},
                new double[] {99, 0.25, 1.23},
                new double[] {100, 0.25, 1.24},
                new double[] {101, 0.25, 1.25},
                new double[] {102, 0.25, 1.27},
                new double[] {103, 0.25, 1.28},
                new double[] {104, 0.25, 1.29},
                new double[] {105, 0.25, 1.3},
                new double[] {106, 0.25, 1.32},
                new double[] {107, 0.25, 1.33},
                new double[] {108, 0.25, 1.34},
                new double[] {109, 0.25, 1.35},
                new double[] {110, 0.25, 1.37},
                new double[] {111, 0.25, 1.38},
                new double[] {112, 0.25, 1.39},
                new double[] {113, 0.25, 1.4},
                new double[] {114, 0.25, 1.42},
                new double[] {115, 0.25, 1.43},
                new double[] {116, 0.25, 1.44},
                new double[] {117, 0.25, 1.45},
                new double[] {118, 0.25, 1.47},
                new double[] {119, 0.25, 1.48},
                new double[] {120, 0.25, 1.49},
                new double[] {121, 0.25, 1.5},
                new double[] {122, 0.25, 1.52},
                new double[] {123, 0.25, 1.53},
                new double[] {124, 0.25, 1.54},
                new double[] {125, 0.25, 1.55},
                new double[] {126, 0.25, 1.57},
                new double[] {127, 0.25, 1.58},
                new double[] {128, 0.25, 1.59},
                new double[] {129, 0.25, 1.6},
                new double[] {130, 0.25, 1.62},
                new double[] {131, 0.25, 1.63},
                new double[] {132, 0.25, 1.64},
                new double[] {133, 0.25, 1.65},
                new double[] {134, 0.25, 1.67},
                new double[] {135, 0.25, 1.68},
                new double[] {136, 0.25, 1.69},
                new double[] {137, 0.25, 1.7},
                new double[] {138, 0.25, 1.72},
                new double[] {139, 0.25, 1.73},
                new double[] {140, 0.25, 1.74},
                new double[] {141, 0.25, 1.75},
                new double[] {142, 0.25, 1.77},
                new double[] {143, 0.25, 1.78},
                new double[] {144, 0.25, 1.79},
                new double[] {145, 0.25, 1.8},
                new double[] {146, 0.25, 1.82},
                new double[] {147, 0.25, 1.83},
                new double[] {148, 0.25, 1.84},
                new double[] {149, 0.25, 1.85},
                new double[] {150, 0.25, 1.87},
                new double[] {151, 0.25, 1.88},
                new double[] {152, 0.25, 1.89},
                new double[] {153, 0.25, 1.9},
                new double[] {154, 0.25, 1.92},
                new double[] {155, 0.25, 1.93},
                new double[] {156, 0.25, 1.94},
                new double[] {157, 0.25, 1.95},
                new double[] {158, 0.25, 1.97},
                new double[] {159, 0.25, 1.98},
                new double[] {160, 0.25, 1.99},
                new double[] {161, 0.25, 2},
                new double[] {162, 0.25, 2.02},
                new double[] {163, 0.25, 2.03},
                new double[] {164, 0.25, 2.04},
                new double[] {165, 0.25, 2.05},
                new double[] {166, 0.25, 2.07},
                new double[] {167, 0.25, 2.08},
                new double[] {168, 0.25, 2.09},
                new double[] {169, 0.25, 2.1},
                new double[] {170, 0.25, 2.12},
                new double[] {171, 0.25, 2.13},
                new double[] {172, 0.25, 2.14},
                new double[] {173, 0.25, 2.15},
                new double[] {174, 0.25, 2.17},
                new double[] {175, 0.25, 2.18},
                new double[] {176, 0.25, 2.19},
                new double[] {177, 0.25, 2.2},
                new double[] {178, 0.25, 2.22},
                new double[] {179, 0.25, 2.23},
                new double[] {180, 0.25, 2.24},
                new double[] {10, 0.3, 0.09},
                new double[] {12, 0.3, 0.11},
                new double[] {14, 0.3, 0.13},
                new double[] {16, 0.3, 0.15},
                new double[] {18, 0.3, 0.18},
                new double[] {20, 0.3, 0.2},
                new double[] {24, 0.3, 0.25},
                new double[] {28, 0.3, 0.3},
                new double[] {30, 0.3, 0.33},
                new double[] {32, 0.3, 0.35},
                new double[] {40, 0.3, 0.42},
                new double[] {41, 0.3, 0.43},
                new double[] {42, 0.3, 0.44},
                new double[] {43, 0.3, 0.45},
                new double[] {44, 0.3, 0.46},
                new double[] {45, 0.3, 0.46},
                new double[] {46, 0.3, 0.47},
                new double[] {47, 0.3, 0.48},
                new double[] {48, 0.3, 0.49},
                new double[] {49, 0.3, 0.5},
                new double[] {50, 0.3, 0.51},
                new double[] {51, 0.3, 0.52},
                new double[] {52, 0.3, 0.53},
                new double[] {53, 0.3, 0.53},
                new double[] {54, 0.3, 0.54},
                new double[] {55, 0.3, 0.55},
                new double[] {56, 0.3, 0.56},
                new double[] {57, 0.3, 0.57},
                new double[] {58, 0.3, 0.58},
                new double[] {59, 0.3, 0.59},
                new double[] {60, 0.3, 0.6},
                new double[] {61, 0.3, 0.6},
                new double[] {62, 0.3, 0.61},
                new double[] {63, 0.3, 0.62},
                new double[] {64, 0.3, 0.63},
                new double[] {65, 0.3, 0.64},
                new double[] {66, 0.3, 0.65},
                new double[] {67, 0.3, 0.66},
                new double[] {68, 0.3, 0.67},
                new double[] {69, 0.3, 0.67},
                new double[] {70, 0.3, 0.68},
                new double[] {71, 0.3, 0.69},
                new double[] {72, 0.3, 0.7},
                new double[] {73, 0.3, 0.71},
                new double[] {74, 0.3, 0.72},
                new double[] {75, 0.3, 0.73},
                new double[] {76, 0.3, 0.74},
                new double[] {77, 0.3, 0.74},
                new double[] {78, 0.3, 0.75},
                new double[] {79, 0.3, 0.76},
                new double[] {80, 0.3, 0.77},
                new double[] {81, 0.3, 0.78},
                new double[] {82, 0.3, 0.79},
                new double[] {83, 0.3, 0.8},
                new double[] {84, 0.3, 0.81},
                new double[] {85, 0.3, 0.81},
                new double[] {86, 0.3, 0.82},
                new double[] {87, 0.3, 0.83},
                new double[] {88, 0.3, 0.84},
                new double[] {89, 0.3, 0.85},
                new double[] {90, 0.3, 0.86},
                new double[] {91, 0.3, 0.87},
                new double[] {92, 0.3, 0.88},
                new double[] {93, 0.3, 0.88},
                new double[] {94, 0.3, 0.89},
                new double[] {95, 0.3, 0.9},
                new double[] {96, 0.3, 0.91},
                new double[] {97, 0.3, 0.92},
                new double[] {98, 0.3, 0.93},
                new double[] {99, 0.3, 0.94},
                new double[] {100, 0.3, 0.95},
                new double[] {101, 0.3, 0.95},
                new double[] {102, 0.3, 0.96},
                new double[] {103, 0.3, 0.97},
                new double[] {104, 0.3, 0.98},
                new double[] {105, 0.3, 0.99},
                new double[] {106, 0.3, 1},
                new double[] {107, 0.3, 1.01},
                new double[] {108, 0.3, 1.02},
                new double[] {109, 0.3, 1.02},
                new double[] {110, 0.3, 1.03},
                new double[] {111, 0.3, 1.04},
                new double[] {112, 0.3, 1.05},
                new double[] {113, 0.3, 1.06},
                new double[] {114, 0.3, 1.07},
                new double[] {115, 0.3, 1.08},
                new double[] {116, 0.3, 1.09},
                new double[] {117, 0.3, 1.09},
                new double[] {118, 0.3, 1.1},
                new double[] {119, 0.3, 1.11},
                new double[] {120, 0.3, 1.12},
                new double[] {121, 0.3, 1.13},
                new double[] {122, 0.3, 1.14},
                new double[] {123, 0.3, 1.15},
                new double[] {124, 0.3, 1.16},
                new double[] {125, 0.3, 1.16},
                new double[] {126, 0.3, 1.17},
                new double[] {127, 0.3, 1.18},
                new double[] {128, 0.3, 1.19},
                new double[] {129, 0.3, 1.2},
                new double[] {130, 0.3, 1.21},
                new double[] {131, 0.3, 1.22},
                new double[] {132, 0.3, 1.23},
                new double[] {133, 0.3, 1.23},
                new double[] {134, 0.3, 1.24},
                new double[] {135, 0.3, 1.25},
                new double[] {136, 0.3, 1.26},
                new double[] {137, 0.3, 1.27},
                new double[] {138, 0.3, 1.28},
                new double[] {139, 0.3, 1.29},
                new double[] {140, 0.3, 1.3},
                new double[] {141, 0.3, 1.3},
                new double[] {142, 0.3, 1.31},
                new double[] {143, 0.3, 1.32},
                new double[] {144, 0.3, 1.33},
                new double[] {145, 0.3, 1.34},
                new double[] {146, 0.3, 1.35},
                new double[] {147, 0.3, 1.36},
                new double[] {148, 0.3, 1.37},
                new double[] {149, 0.3, 1.37},
                new double[] {150, 0.3, 1.38},
                new double[] {151, 0.3, 1.39},
                new double[] {152, 0.3, 1.4},
                new double[] {153, 0.3, 1.41},
                new double[] {154, 0.3, 1.42},
                new double[] {155, 0.3, 1.43},
                new double[] {156, 0.3, 1.44},
                new double[] {157, 0.3, 1.44},
                new double[] {158, 0.3, 1.45},
                new double[] {159, 0.3, 1.46},
                new double[] {160, 0.3, 1.47},
                new double[] {161, 0.3, 1.48},
                new double[] {162, 0.3, 1.49},
                new double[] {163, 0.3, 1.5},
                new double[] {164, 0.3, 1.51},
                new double[] {165, 0.3, 1.51},
                new double[] {166, 0.3, 1.52},
                new double[] {167, 0.3, 1.53},
                new double[] {168, 0.3, 1.54},
                new double[] {169, 0.3, 1.55},
                new double[] {170, 0.3, 1.56},
                new double[] {171, 0.3, 1.57},
                new double[] {172, 0.3, 1.58},
                new double[] {173, 0.3, 1.58},
                new double[] {174, 0.3, 1.59},
                new double[] {175, 0.3, 1.6},
                new double[] {176, 0.3, 1.61},
                new double[] {177, 0.3, 1.62},
                new double[] {178, 0.3, 1.63},
                new double[] {179, 0.3, 1.64},
                new double[] {180, 0.3, 1.65},
                new double[] {10, 0.4, 0.08},
                new double[] {12, 0.4, 0.09},
                new double[] {14, 0.4, 0.1},
                new double[] {16, 0.4, 0.12},
                new double[] {18, 0.4, 0.14},
                new double[] {20, 0.4, 0.15},
                new double[] {24, 0.4, 0.19},
                new double[] {28, 0.4, 0.23},
                new double[] {30, 0.4, 0.25},
                new double[] {32, 0.4, 0.27},
                new double[] {40, 0.4, 0.35},
                new double[] {41, 0.4, 0.36},
                new double[] {42, 0.4, 0.37},
                new double[] {43, 0.4, 0.38},
                new double[] {44, 0.4, 0.39},
                new double[] {45, 0.4, 0.4},
                new double[] {46, 0.4, 0.41},
                new double[] {47, 0.4, 0.42},
                new double[] {48, 0.4, 0.43},
                new double[] {49, 0.4, 0.44},
                new double[] {50, 0.4, 0.45},
                new double[] {51, 0.4, 0.46},
                new double[] {52, 0.4, 0.47},
                new double[] {53, 0.4, 0.48},
                new double[] {54, 0.4, 0.49},
                new double[] {55, 0.4, 0.5},
                new double[] {56, 0.4, 0.51},
                new double[] {57, 0.4, 0.52},
                new double[] {58, 0.4, 0.53},
                new double[] {59, 0.4, 0.54},
                new double[] {60, 0.4, 0.55},
                new double[] {61, 0.4, 0.56},
                new double[] {62, 0.4, 0.57},
                new double[] {63, 0.4, 0.58},
                new double[] {64, 0.4, 0.59},
                new double[] {65, 0.4, 0.6},
                new double[] {66, 0.4, 0.61},
                new double[] {67, 0.4, 0.62},
                new double[] {68, 0.4, 0.63},
                new double[] {69, 0.4, 0.64},
                new double[] {70, 0.4, 0.65},
                new double[] {71, 0.4, 0.66},
                new double[] {72, 0.4, 0.67},
                new double[] {73, 0.4, 0.68},
                new double[] {74, 0.4, 0.69},
                new double[] {75, 0.4, 0.7},
                new double[] {76, 0.4, 0.71},
                new double[] {77, 0.4, 0.72},
                new double[] {78, 0.4, 0.73},
                new double[] {79, 0.4, 0.74},
                new double[] {80, 0.4, 0.75},
                new double[] {81, 0.4, 0.76},
                new double[] {82, 0.4, 0.77},
                new double[] {83, 0.4, 0.78},
                new double[] {84, 0.4, 0.79},
                new double[] {85, 0.4, 0.8},
                new double[] {86, 0.4, 0.81},
                new double[] {87, 0.4, 0.82},
                new double[] {88, 0.4, 0.83},
                new double[] {89, 0.4, 0.84},
                new double[] {90, 0.4, 0.85},
                new double[] {91, 0.4, 0.86},
                new double[] {92, 0.4, 0.87},
                new double[] {93, 0.4, 0.88},
                new double[] {94, 0.4, 0.89},
                new double[] {95, 0.4, 0.9},
                new double[] {96, 0.4, 0.91},
                new double[] {97, 0.4, 0.92},
                new double[] {98, 0.4, 0.93},
                new double[] {99, 0.4, 0.94},
                new double[] {100, 0.4, 0.95},
                new double[] {101, 0.4, 0.96},
                new double[] {102, 0.4, 0.97},
                new double[] {103, 0.4, 0.98},
                new double[] {104, 0.4, 0.99},
                new double[] {105, 0.4, 1},
                new double[] {106, 0.4, 1.01},
                new double[] {107, 0.4, 1.02},
                new double[] {108, 0.4, 1.03},
                new double[] {109, 0.4, 1.04},
                new double[] {110, 0.4, 1.05},
                new double[] {111, 0.4, 1.06},
                new double[] {112, 0.4, 1.07},
                new double[] {113, 0.4, 1.08},
                new double[] {114, 0.4, 1.09},
                new double[] {115, 0.4, 1.1},
                new double[] {116, 0.4, 1.11},
                new double[] {117, 0.4, 1.12},
                new double[] {118, 0.4, 1.13},
                new double[] {119, 0.4, 1.14},
                new double[] {120, 0.4, 1.15},
                new double[] {121, 0.4, 1.16},
                new double[] {122, 0.4, 1.17},
                new double[] {123, 0.4, 1.18},
                new double[] {124, 0.4, 1.19},
                new double[] {125, 0.4, 1.2},
                new double[] {126, 0.4, 1.21},
                new double[] {127, 0.4, 1.22},
                new double[] {128, 0.4, 1.23},
                new double[] {129, 0.4, 1.24},
                new double[] {130, 0.4, 1.25},
                new double[] {131, 0.4, 1.26},
                new double[] {132, 0.4, 1.27},
                new double[] {133, 0.4, 1.28},
                new double[] {134, 0.4, 1.29},
                new double[] {135, 0.4, 1.3},
                new double[] {136, 0.4, 1.31},
                new double[] {137, 0.4, 1.32},
                new double[] {138, 0.4, 1.33},
                new double[] {139, 0.4, 1.34},
                new double[] {140, 0.4, 1.35},
                new double[] {141, 0.4, 1.36},
                new double[] {142, 0.4, 1.37},
                new double[] {143, 0.4, 1.38},
                new double[] {144, 0.4, 1.39},
                new double[] {145, 0.4, 1.4},
                new double[] {146, 0.4, 1.41},
                new double[] {147, 0.4, 1.42},
                new double[] {148, 0.4, 1.43},
                new double[] {149, 0.4, 1.44},
                new double[] {150, 0.4, 1.45},
                new double[] {151, 0.4, 1.46},
                new double[] {152, 0.4, 1.47},
                new double[] {153, 0.4, 1.48},
                new double[] {154, 0.4, 1.49},
                new double[] {155, 0.4, 1.5},
                new double[] {156, 0.4, 1.51},
                new double[] {157, 0.4, 1.52},
                new double[] {158, 0.4, 1.53},
                new double[] {159, 0.4, 1.54},
                new double[] {160, 0.4, 1.55},
                new double[] {161, 0.4, 1.56},
                new double[] {162, 0.4, 1.57},
                new double[] {163, 0.4, 1.58},
                new double[] {164, 0.4, 1.59},
                new double[] {165, 0.4, 1.6},
                new double[] {166, 0.4, 1.61},
                new double[] {167, 0.4, 1.62},
                new double[] {168, 0.4, 1.63},
                new double[] {169, 0.4, 1.64},
                new double[] {170, 0.4, 1.65},
                new double[] {171, 0.4, 1.66},
                new double[] {172, 0.4, 1.67},
                new double[] {173, 0.4, 1.68},
                new double[] {174, 0.4, 1.69},
                new double[] {175, 0.4, 1.7},
                new double[] {176, 0.4, 1.71},
                new double[] {177, 0.4, 1.72},
                new double[] {178, 0.4, 1.73},
                new double[] {179, 0.4, 1.74},
                new double[] {180, 0.4, 1.75},
                new double[] {10, 0.5, 0.06},
                new double[] {12, 0.5, 0.07},
                new double[] {14, 0.5, 0.08},
                new double[] {16, 0.5, 0.09},
                new double[] {18, 0.5, 0.1},
                new double[] {20, 0.5, 0.11},
                new double[] {24, 0.5, 0.14},
                new double[] {28, 0.5, 0.17},
                new double[] {30, 0.5, 0.18},
                new double[] {32, 0.5, 0.19},
                new double[] {40, 0.5, 0.25},
                new double[] {41, 0.5, 0.26},
                new double[] {42, 0.5, 0.27},
                new double[] {43, 0.5, 0.27},
                new double[] {44, 0.5, 0.28},
                new double[] {45, 0.5, 0.29},
                new double[] {46, 0.5, 0.3},
                new double[] {47, 0.5, 0.3},
                new double[] {48, 0.5, 0.31},
                new double[] {49, 0.5, 0.32},
                new double[] {50, 0.5, 0.33},
                new double[] {51, 0.5, 0.33},
                new double[] {52, 0.5, 0.34},
                new double[] {53, 0.5, 0.35},
                new double[] {54, 0.5, 0.36},
                new double[] {55, 0.5, 0.36},
                new double[] {56, 0.5, 0.37},
                new double[] {57, 0.5, 0.38},
                new double[] {58, 0.5, 0.39},
                new double[] {59, 0.5, 0.39},
                new double[] {60, 0.5, 0.4},
                new double[] {61, 0.5, 0.41},
                new double[] {62, 0.5, 0.42},
                new double[] {63, 0.5, 0.42},
                new double[] {64, 0.5, 0.43},
                new double[] {65, 0.5, 0.44},
                new double[] {66, 0.5, 0.45},
                new double[] {67, 0.5, 0.45},
                new double[] {68, 0.5, 0.46},
                new double[] {69, 0.5, 0.47},
                new double[] {70, 0.5, 0.48},
                new double[] {71, 0.5, 0.48},
                new double[] {72, 0.5, 0.49},
                new double[] {73, 0.5, 0.5},
                new double[] {74, 0.5, 0.51},
                new double[] {75, 0.5, 0.51},
                new double[] {76, 0.5, 0.52},
                new double[] {77, 0.5, 0.53},
                new double[] {78, 0.5, 0.54},
                new double[] {79, 0.5, 0.54},
                new double[] {80, 0.5, 0.55},
                new double[] {81, 0.5, 0.56},
                new double[] {82, 0.5, 0.57},
                new double[] {83, 0.5, 0.57},
                new double[] {84, 0.5, 0.58},
                new double[] {85, 0.5, 0.59},
                new double[] {86, 0.5, 0.6},
                new double[] {87, 0.5, 0.6},
                new double[] {88, 0.5, 0.61},
                new double[] {89, 0.5, 0.62},
                new double[] {90, 0.5, 0.63},
                new double[] {91, 0.5, 0.63},
                new double[] {92, 0.5, 0.64},
                new double[] {93, 0.5, 0.65},
                new double[] {94, 0.5, 0.66},
                new double[] {95, 0.5, 0.66},
                new double[] {96, 0.5, 0.67},
                new double[] {97, 0.5, 0.68},
                new double[] {98, 0.5, 0.69},
                new double[] {99, 0.5, 0.69},
                new double[] {100, 0.5, 0.7},
                new double[] {101, 0.5, 0.71},
                new double[] {102, 0.5, 0.72},
                new double[] {103, 0.5, 0.72},
                new double[] {104, 0.5, 0.73},
                new double[] {105, 0.5, 0.74},
                new double[] {106, 0.5, 0.75},
                new double[] {107, 0.5, 0.75},
                new double[] {108, 0.5, 0.76},
                new double[] {109, 0.5, 0.77},
                new double[] {110, 0.5, 0.78},
                new double[] {111, 0.5, 0.78},
                new double[] {112, 0.5, 0.79},
                new double[] {113, 0.5, 0.8},
                new double[] {114, 0.5, 0.81},
                new double[] {115, 0.5, 0.81},
                new double[] {116, 0.5, 0.82},
                new double[] {117, 0.5, 0.83},
                new double[] {118, 0.5, 0.84},
                new double[] {119, 0.5, 0.84},
                new double[] {120, 0.5, 0.85},
                new double[] {121, 0.5, 0.86},
                new double[] {122, 0.5, 0.87},
                new double[] {123, 0.5, 0.87},
                new double[] {124, 0.5, 0.88},
                new double[] {125, 0.5, 0.89},
                new double[] {126, 0.5, 0.9},
                new double[] {127, 0.5, 0.9},
                new double[] {128, 0.5, 0.91},
                new double[] {129, 0.5, 0.92},
                new double[] {130, 0.5, 0.93},
                new double[] {131, 0.5, 0.93},
                new double[] {132, 0.5, 0.94},
                new double[] {133, 0.5, 0.95},
                new double[] {134, 0.5, 0.96},
                new double[] {135, 0.5, 0.96},
                new double[] {136, 0.5, 0.97},
                new double[] {137, 0.5, 0.98},
                new double[] {138, 0.5, 0.99},
                new double[] {139, 0.5, 0.99},
                new double[] {140, 0.5, 1},
                new double[] {141, 0.5, 1.01},
                new double[] {142, 0.5, 1.02},
                new double[] {143, 0.5, 1.02},
                new double[] {144, 0.5, 1.03},
                new double[] {145, 0.5, 1.04},
                new double[] {146, 0.5, 1.05},
                new double[] {147, 0.5, 1.05},
                new double[] {148, 0.5, 1.06},
                new double[] {149, 0.5, 1.07},
                new double[] {150, 0.5, 1.08},
                new double[] {151, 0.5, 1.08},
                new double[] {152, 0.5, 1.09},
                new double[] {153, 0.5, 1.1},
                new double[] {154, 0.5, 1.11},
                new double[] {155, 0.5, 1.11},
                new double[] {156, 0.5, 1.12},
                new double[] {157, 0.5, 1.13},
                new double[] {158, 0.5, 1.14},
                new double[] {159, 0.5, 1.14},
                new double[] {160, 0.5, 1.15},
                new double[] {161, 0.5, 1.16},
                new double[] {162, 0.5, 1.17},
                new double[] {163, 0.5, 1.17},
                new double[] {164, 0.5, 1.18},
                new double[] {165, 0.5, 1.19},
                new double[] {166, 0.5, 1.2},
                new double[] {167, 0.5, 1.2},
                new double[] {168, 0.5, 1.21},
                new double[] {169, 0.5, 1.22},
                new double[] {170, 0.5, 1.23},
                new double[] {171, 0.5, 1.23},
                new double[] {172, 0.5, 1.24},
                new double[] {173, 0.5, 1.25},
                new double[] {174, 0.5, 1.26},
                new double[] {175, 0.5, 1.26},
                new double[] {176, 0.5, 1.27},
                new double[] {177, 0.5, 1.28},
                new double[] {178, 0.5, 1.29},
                new double[] {179, 0.5, 1.29},
                new double[] {180, 0.5, 1.3},
                new double[] {10, 0.6, 0.05},
                new double[] {12, 0.6, 0.05},
                new double[] {14, 0.6, 0.06},
                new double[] {16, 0.6, 0.07},
                new double[] {18, 0.6, 0.08},
                new double[] {20, 0.6, 0.08},
                new double[] {24, 0.6, 0.1},
                new double[] {28, 0.6, 0.11},
                new double[] {30, 0.6, 0.12},
                new double[] {32, 0.6, 0.13},
                new double[] {40, 0.6, 0.17},
                new double[] {41, 0.6, 0.18},
                new double[] {42, 0.6, 0.18},
                new double[] {43, 0.6, 0.19},
                new double[] {44, 0.6, 0.19},
                new double[] {45, 0.6, 0.2},
                new double[] {46, 0.6, 0.2},
                new double[] {47, 0.6, 0.21},
                new double[] {48, 0.6, 0.21},
                new double[] {49, 0.6, 0.22},
                new double[] {50, 0.6, 0.22},
                new double[] {51, 0.6, 0.23},
                new double[] {52, 0.6, 0.23},
                new double[] {53, 0.6, 0.24},
                new double[] {54, 0.6, 0.24},
                new double[] {55, 0.6, 0.25},
                new double[] {56, 0.6, 0.25},
                new double[] {57, 0.6, 0.26},
                new double[] {58, 0.6, 0.26},
                new double[] {59, 0.6, 0.27},
                new double[] {60, 0.6, 0.27},
                new double[] {61, 0.6, 0.28},
                new double[] {62, 0.6, 0.28},
                new double[] {63, 0.6, 0.29},
                new double[] {64, 0.6, 0.29},
                new double[] {65, 0.6, 0.3},
                new double[] {66, 0.6, 0.3},
                new double[] {67, 0.6, 0.31},
                new double[] {68, 0.6, 0.31},
                new double[] {69, 0.6, 0.32},
                new double[] {70, 0.6, 0.32},
                new double[] {71, 0.6, 0.33},
                new double[] {72, 0.6, 0.33},
                new double[] {73, 0.6, 0.34},
                new double[] {74, 0.6, 0.34},
                new double[] {75, 0.6, 0.35},
                new double[] {76, 0.6, 0.35},
                new double[] {77, 0.6, 0.36},
                new double[] {78, 0.6, 0.36},
                new double[] {79, 0.6, 0.37},
                new double[] {80, 0.6, 0.37},
                new double[] {81, 0.6, 0.38},
                new double[] {82, 0.6, 0.38},
                new double[] {83, 0.6, 0.39},
                new double[] {84, 0.6, 0.39},
                new double[] {85, 0.6, 0.4},
                new double[] {86, 0.6, 0.4},
                new double[] {87, 0.6, 0.41},
                new double[] {88, 0.6, 0.41},
                new double[] {89, 0.6, 0.42},
                new double[] {90, 0.6, 0.42},
                new double[] {91, 0.6, 0.43},
                new double[] {92, 0.6, 0.43},
                new double[] {93, 0.6, 0.44},
                new double[] {94, 0.6, 0.44},
                new double[] {95, 0.6, 0.45},
                new double[] {96, 0.6, 0.45},
                new double[] {97, 0.6, 0.46},
                new double[] {98, 0.6, 0.46},
                new double[] {99, 0.6, 0.47},
                new double[] {100, 0.6, 0.47},
                new double[] {101, 0.6, 0.48},
                new double[] {102, 0.6, 0.48},
                new double[] {103, 0.6, 0.49},
                new double[] {104, 0.6, 0.49},
                new double[] {105, 0.6, 0.5},
                new double[] {106, 0.6, 0.5},
                new double[] {107, 0.6, 0.51},
                new double[] {108, 0.6, 0.51},
                new double[] {109, 0.6, 0.52},
                new double[] {110, 0.6, 0.52},
                new double[] {111, 0.6, 0.53},
                new double[] {112, 0.6, 0.53},
                new double[] {113, 0.6, 0.54},
                new double[] {114, 0.6, 0.54},
                new double[] {115, 0.6, 0.55},
                new double[] {116, 0.6, 0.55},
                new double[] {117, 0.6, 0.56},
                new double[] {118, 0.6, 0.56},
                new double[] {119, 0.6, 0.57},
                new double[] {120, 0.6, 0.57},
                new double[] {121, 0.6, 0.58},
                new double[] {122, 0.6, 0.58},
                new double[] {123, 0.6, 0.59},
                new double[] {124, 0.6, 0.59},
                new double[] {125, 0.6, 0.6},
                new double[] {126, 0.6, 0.6},
                new double[] {127, 0.6, 0.61},
                new double[] {128, 0.6, 0.61},
                new double[] {129, 0.6, 0.62},
                new double[] {130, 0.6, 0.62},
                new double[] {131, 0.6, 0.63},
                new double[] {132, 0.6, 0.63},
                new double[] {133, 0.6, 0.64},
                new double[] {134, 0.6, 0.64},
                new double[] {135, 0.6, 0.65},
                new double[] {136, 0.6, 0.65},
                new double[] {137, 0.6, 0.66},
                new double[] {138, 0.6, 0.66},
                new double[] {139, 0.6, 0.67},
                new double[] {140, 0.6, 0.67},
                new double[] {141, 0.6, 0.68},
                new double[] {142, 0.6, 0.68},
                new double[] {143, 0.6, 0.69},
                new double[] {144, 0.6, 0.69},
                new double[] {145, 0.6, 0.7},
                new double[] {146, 0.6, 0.7},
                new double[] {147, 0.6, 0.71},
                new double[] {148, 0.6, 0.71},
                new double[] {149, 0.6, 0.72},
                new double[] {150, 0.6, 0.72},
                new double[] {151, 0.6, 0.73},
                new double[] {152, 0.6, 0.73},
                new double[] {153, 0.6, 0.74},
                new double[] {154, 0.6, 0.74},
                new double[] {155, 0.6, 0.75},
                new double[] {156, 0.6, 0.75},
                new double[] {157, 0.6, 0.76},
                new double[] {158, 0.6, 0.76},
                new double[] {159, 0.6, 0.77},
                new double[] {160, 0.6, 0.77},
                new double[] {161, 0.6, 0.78},
                new double[] {162, 0.6, 0.78},
                new double[] {163, 0.6, 0.79},
                new double[] {164, 0.6, 0.79},
                new double[] {165, 0.6, 0.8},
                new double[] {166, 0.6, 0.8},
                new double[] {167, 0.6, 0.81},
                new double[] {168, 0.6, 0.81},
                new double[] {169, 0.6, 0.82},
                new double[] {170, 0.6, 0.82},
                new double[] {171, 0.6, 0.83},
                new double[] {172, 0.6, 0.83},
                new double[] {173, 0.6, 0.84},
                new double[] {174, 0.6, 0.84},
                new double[] {175, 0.6, 0.85},
                new double[] {176, 0.6, 0.85},
                new double[] {177, 0.6, 0.86},
                new double[] {178, 0.6, 0.86},
                new double[] {179, 0.6, 0.87},
                new double[] {180, 0.6, 0.87}
            };

            foreach (double[] str in table_kms_circle_rasshirenie)
            {
                if ( (alfa_rasshirenie == str[0]) && (f_min_k_f_max_rasshirenie == str[1]) )
                {
                    kms_circle_rasshirenie = str[2];
                    break;
                }
            }

            double kms_circle_sujenie = 0.1;

            double[][] table_kms_circle_sujenie =
            {
                new double[] {10, 0.1, 0.41},
                new double[] {10, 0.15, 0.39},
                new double[] {10, 0.6, 0.29},
                new double[] {20, 0.1, 0.34},
                new double[] {20, 0.15, 0.29},
                new double[] {20, 0.6, 0.2},
                new double[] {30, 0.1, 0.27},
                new double[] {30, 0.15, 0.22},
                new double[] {30, 0.6, 0.15},
                new double[] {40, 0.1, 0.24},
                new double[] {40, 0.15, 0.18},
                new double[] {40, 0.6, 0.13}
            };

            foreach (double[] str in table_kms_circle_sujenie)
            {
                if ((alfa_sujenie == str[0]) && (dlina_k_d_min_sujenie == str[1]))
                {
                    kms_circle_sujenie = str[2];
                }
            }

            if (f1 < f2)
            {
                return kms_circle_rasshirenie;
            }
            else
            {
                return kms_circle_sujenie;
            }
        }

        private double Take_kms()
        {
            Refresh_tip_perehoda();

            if (_tip_perehoda == "равновеликий")
            {
                if (_dlina <= 0) return 0;
                else return 0.1;
            }

            double w1;
            double w2;
            double h1;
            double h2;
            double di1;
            double di2;

            string form1;
            string form2;

            if (((!_perehod_v_konce_potoka_true_v_nachale_false) && _vitiajka_tru_pritok_false) || (_perehod_v_konce_potoka_true_v_nachale_false && (!_vitiajka_tru_pritok_false)))
            {
                w1 = _width_mm;
                w2 = Width_2_mm;
                h1 = _height_mm;
                h2 = Height_2_mm;
                di1 = _diameter_mm;
                di2 = Diameter_2_mm;

                form1 = _forma_sechenia;
                form2 = Forma_2;
            }
            else
            {
                w2 = _width_mm;
                w1 = Width_2_mm;
                h2 = _height_mm;
                h1 = Height_2_mm;
                di2 = _diameter_mm;
                di1 = Diameter_2_mm;

                form2 = _forma_sechenia;
                form1 = Forma_2;
            }

            double kms_rezult;

            if ((form1 == "rectangle") && (form2 == "rectangle"))
            {
                kms_rezult = Take_kms_rectangle_to_rectangle(w1, h1, w2, h2, _dlina);
            }
            else if ((form1 == "circle") && (form2 == "circle"))
            {
                kms_rezult = Take_kms_circle_to_circle(di1, di2, _dlina);
            }
            else if ((form1 == "rectangle") && (form2 == "circle"))
            {
                double d2 = Math.Pow(((Math.PI * Math.Pow(di2, 2.0)) / 4.0), 0.5);
                kms_rezult = Take_kms_rectangle_to_rectangle(w1, h1, d2, d2, _dlina);
            }
            else //((form1 == "circle") && (form2 == "rectangle"))
            {
                double d1 = Math.Pow(((Math.PI * Math.Pow(di1, 2.0)) / 4.0), 0.5);
                kms_rezult = Take_kms_rectangle_to_rectangle(d1, d1, w2, h2, _dlina);
            }

            return kms_rezult;
        }

        protected override void Refresh_marka()
        {
            string m_str_1 = "";

            string m_str_2 = "";

            string m_str = "";

            if (_width_mm > 0 && _height_mm > 0)
            {
                m_str_1 = _width_mm.ToString() + "x" + _height_mm.ToString();
            }
            else
            {
                m_str_1 = _diameter_mm.ToString();
            }

            if (Width_2_mm > 0 && Height_2_mm > 0)
            {
                m_str_2 = Width_2_mm.ToString() + "x" + Height_2_mm.ToString();
            }
            else
            {
                m_str_2 = Diameter_2_mm.ToString();
            }

            if (((!_perehod_v_konce_potoka_true_v_nachale_false) && _vitiajka_tru_pritok_false) || (_perehod_v_konce_potoka_true_v_nachale_false && (!_vitiajka_tru_pritok_false)))
            {
                string t = m_str_1;
                m_str_1 = m_str_2;
                m_str_2 = t;
            }
            
            if (_vitiajka_tru_pritok_false)
            {
                m_str = m_str_1 + "-" + m_str_2;
            }
            else
            {
                m_str = m_str_2 + "-" + m_str_1;
            }

            if (_dlina == 0) _marka = m_str;
            else _marka = m_str + ", Дл = " + _dlina.ToString() + " мм";
        }

        public override string Name
        {
            get
            {
                Refresh_tip_perehoda();
                if (_dlina == 0)
                {
                    if (_perehod_v_konce_potoka_true_v_nachale_false)
                    {
                        return "Внезапный переход в конце потока" + " (" + _tip_perehoda + ")" + _marka;
                    }
                    else
                    {
                        return "Внезапный переход в начале потока" + " (" + _tip_perehoda + ")" + _marka;
                    }
                }
                else
                {
                    if (_perehod_v_konce_potoka_true_v_nachale_false)
                    {
                        return "Переход в конце потока" + " (" + _tip_perehoda + ")" + _marka;
                    }
                    else
                    {
                        return "Переход в начале потока" + " (" + _tip_perehoda + ")" + _marka;
                    }
                }
                
            }
        }
        public void Refresh_tip_perehoda()
        {
            double f_01 = 0;
            double f_02 = 0;

            if (!(_width_mm > 0 && _height_mm > 0))
            {
                f_01 = Math.PI* Math.Pow(_diameter_mm, 2.0) / 4.0;
            }
            else
            {
                f_01 = (_width_mm * _height_mm);
            }

            if (!(uch2.Width_mm > 0 && uch2.Height_mm > 0))
            {
                f_02 = Math.PI * Math.Pow(uch2.Diameter_mm, 2.0) / 4.0;
            }
            else
            {
                f_02 = (uch2.Width_mm * uch2.Height_mm);
            }

            if (_vitiajka_tru_pritok_false)
            {
                if (f_02 > f_01) _tip_perehoda = "расширение";
                else if (f_02 < f_01) _tip_perehoda = "сужение";
                else _tip_perehoda = "равновеликий";
            }
            else
            {
                if (f_02 > f_01) _tip_perehoda = "сужение";
                else if (f_02 < f_01) _tip_perehoda = "расширение";
                else _tip_perehoda = "равновеликий";
            }

            if (((!_perehod_v_konce_potoka_true_v_nachale_false) && _vitiajka_tru_pritok_false) || (_perehod_v_konce_potoka_true_v_nachale_false && (!_vitiajka_tru_pritok_false)))
            {
                if (_tip_perehoda == "сужение") _tip_perehoda = "расширение";
                else if (_tip_perehoda == "расширение") _tip_perehoda = "сужение";
            }
            
        }
        public override string ToString()
        {
            Refresh_marka();
            _kms = Take_kms();
            return Name + " " + " КМС = " + _kms;
        }
        public void SetMarka()
        {
            Refresh_marka();
        }

        public Perehod (bool perehod_in_the_end, Uchastok first_uchastok, Uchastok second_uchastok, double dlina):base("Переход", "", first_uchastok.Rashod_m3_in_hour, first_uchastok.Width_mm, first_uchastok.Height_mm, false, 0)
        {
            if (dlina == 0) _short_name = "Внезапный переход";

            _perehod_v_konce_potoka_true_v_nachale_false = perehod_in_the_end;

            if((first_uchastok._stream_type == second_uchastok._stream_type) && (first_uchastok._stream_type != "вытяжная"))
            {
                _vitiajka_tru_pritok_false = false;
            }
            else
            {
                _vitiajka_tru_pritok_false = true;
            }

            Uchastok uchastok_1 = first_uchastok;
            Uchastok uchastok_2 = second_uchastok;

            /* Не трогать
            if (_vitiajka_tru_pritok_false)
            {
                uchastok_1 = first_uchastok;
                uchastok_2 = second_uchastok;
                _forma_sechenia = uchastok_1.Forma_sechenia;
            }
            else
            {
                uchastok_1 = second_uchastok;
                uchastok_2 = first_uchastok;
                _forma_sechenia = uchastok_2.Forma_sechenia;
            }
            */

            _forma_sechenia = uchastok_1.Forma_sechenia;

            _diameter_mm = uchastok_1.Diameter_mm;

            uch2 = uchastok_2;

            _dlina = Math.Abs(dlina);

            double f_01 = 0;
            double f_02 = 0;
            
            if (!(uchastok_1.Width_mm > 0 && uchastok_1.Height_mm > 0))
            {
                f_01 = Math.PI * Math.Pow(uchastok_1.Diameter_mm, 2.0) / 4.0;
            }
            else
            {
                f_01 = (uchastok_1.Width_mm * uchastok_1.Height_mm);
            }

            if (!(uchastok_2.Width_mm > 0 && uchastok_2.Height_mm > 0))
            {
                f_02 = Math.PI * Math.Pow(uchastok_2.Diameter_mm, 2.0) / 4.0;
            }
            else
            {
                f_02 = (uchastok_2.Width_mm * uchastok_2.Height_mm);
            }

            if (_vitiajka_tru_pritok_false)
            {
                if (f_02 > f_01) _tip_perehoda = "расширение";
                else if (f_02 < f_01) _tip_perehoda = "сужение";
                else _tip_perehoda = "равновеликий";
            }
            else
            {
                if (f_02 > f_01) _tip_perehoda = "сужение";
                else if (f_02 < f_01) _tip_perehoda = "расширение";
                else _tip_perehoda = "равновеликий";
            }
            
            if (((!_perehod_v_konce_potoka_true_v_nachale_false) && _vitiajka_tru_pritok_false) || (_perehod_v_konce_potoka_true_v_nachale_false && (!_vitiajka_tru_pritok_false)))
            {
                if (_tip_perehoda == "сужение") _tip_perehoda = "расширение";
                else if (_tip_perehoda == "расширение") _tip_perehoda = "сужение";
            }
            
            SetMarka();

            _kms = Take_kms(); 
        }
    }
}
