using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Diffuzor_stat_kamera : Mestnoe_soprotivlenie
    {
        protected override void Refresh_marka()
        {
            _marka = "";

            if (Forma_sechenia == "rectangle")
            {
                _marka = "4АПН " + Math.Abs(_width_mm).ToString() + "x" + Math.Abs(_height_mm).ToString();
            }
            else
            {
                _marka = "4АПН " + Math.Abs(_diameter_mm).ToString();
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
                if ((_width_mm <= 0) || (_height_mm <= 0)) return 0;

                if (_diameter_mm <= 0) return 0;
            }
            else
            {
                if (_diameter_mm <= 0) return 0;
            }

            if ((_diameter_mm > 0) && (_diameter_mm < 360))
            {
                return 555.5857277;
            }
            else if ((_diameter_mm >= 360) && (_diameter_mm < 400))
            {
                return 272.13042;
            }
            else if ((_diameter_mm >= 400) && (_diameter_mm < 450))
            {
                return 174.3366921;
            }
            else if ((_diameter_mm >= 450) && (_diameter_mm < 514))
            {
                return 146.8358298;
            }
            else if ((_diameter_mm >= 514) && (_diameter_mm < 600))
            {
                return 108.7422079;
            }
            else if (_diameter_mm >= 600)
            {
                return 86.3392993;
            }
            else
            {
                return 0;
            }
        }

        public Diffuzor_stat_kamera(double rashod_m3_in_hour, double width_mm, double height_mm) : base("Четырехсторонний диффузор с камерой статического давления", "", rashod_m3_in_hour, width_mm, height_mm, false, 0)
        {
            SetMarka();
            _kms = Take_kms();
        }

        public Diffuzor_stat_kamera(double rashod_m3_in_hour, double diameter_mm) : base("Четырехсторонний диффузор с камерой статического давления", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            SetMarka();
            _kms = Take_kms();
        }
    }
}
