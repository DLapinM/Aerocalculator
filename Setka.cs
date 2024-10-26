using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Setka : Mestnoe_soprotivlenie
    {
        private double Take_kms()
        {
            return 1.8;
        }

        public Setka(double rashod_m3_in_hour, double width_mm, double height_mm) : base("Воздухораспределительная сетка", "", rashod_m3_in_hour, width_mm, height_mm, false, 0)
        {
            _kms = Take_kms();
        }

        public Setka(double rashod_m3_in_hour, double diameter_mm) : base("Воздухораспределительная сетка", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            _kms = Take_kms();
        }
    }
}
