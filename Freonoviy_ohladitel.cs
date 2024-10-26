using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Freonoviy_ohladitel : Mestnoe_soprotivlenie
    {
        private double Take_kms()
        {
            double[][] table_delta_p =
            {
                new double[] { 0, 0 },
                new double[] { 0.1, 1.089460 },
                new double[] { 0.2, 2.187678 },
                new double[] { 0.3, 3.303412 },
                new double[] { 0.4, 4.445421 },
                new double[] { 0.5, 5.622463 },
                new double[] { 0.6, 6.843295 },
                new double[] { 0.7, 8.116677 },
                new double[] { 0.8, 9.451366 },
                new double[] { 0.9, 10.856121 },
                new double[] { 1, 12.339700 },
                new double[] { 1.1, 13.910583 },
                new double[] { 1.2, 15.573436 },
                new double[] { 1.3, 17.333369 },
                new double[] { 1.4, 19.195132 },
                new double[] { 1.5, 21.163476 },
                new double[] { 1.6, 23.243150 },
                new double[] { 1.7, 25.438905 },
                new double[] { 1.8, 27.755489 },
                new double[] { 1.9, 30.197655 },
                new double[] { 2, 32.770150 },
                new double[] { 2.1, 35.476622 },
                new double[] { 2.2, 38.317247 },
                new double[] { 2.3, 41.290836 },
                new double[] { 2.4, 44.396331 },
                new double[] { 2.5, 47.632675 },
                new double[] { 2.6, 50.998809 },
                new double[] { 2.7, 54.493674 },
                new double[] { 2.8, 58.116213 },
                new double[] { 2.9, 61.865368 },
                new double[] { 3, 65.740080 },
                new double[] { 3.1, 69.743646 },
                new double[] { 3.2, 73.885398 },
                new double[] { 3.3, 78.182061 },
                new double[] { 3.4, 82.648835 },
                new double[] { 3.5, 87.300925 },
                new double[] { 3.6, 92.153533 },
                new double[] { 3.7, 97.221861 },
                new double[] { 3.8, 102.521114 },
                new double[] { 3.9, 108.066492 },
                new double[] { 4, 113.873200 },
                new double[] { 4.1, 119.928005 },
                new double[] { 4.2, 126.252066 },
                new double[] { 4.3, 132.797328 },
                new double[] { 4.4, 139.536141 },
                new double[] { 4.5, 146.440850 },
                new double[] { 4.6, 153.483803 },
                new double[] { 4.7, 160.637348 },
                new double[] { 4.8, 167.873830 },
                new double[] { 4.9, 175.165599 },
                new double[] { 5, 182.485000 },
                new double[] { 5.1, 189.910000 },
                new double[] { 5.2, 197.310000 },
                new double[] { 5.3, 204.710000 },
                new double[] { 5.4, 212.110000 },
                new double[] { 5.5, 219.510000 },
                new double[] { 5.6, 226.910000 },
                new double[] { 5.7, 234.310000 },
                new double[] { 5.8, 241.710000 },
                new double[] { 5.9, 249.110000 },
                new double[] { 6, 256.510000 },
                new double[] { 6.1, 263.910000 },
                new double[] { 6.2, 271.310000 },
                new double[] { 6.3, 278.710000 },
                new double[] { 6.4, 286.110000 },
                new double[] { 6.5, 293.510000 },
                new double[] { 6.6, 300.910000 },
                new double[] { 6.7, 308.310000 },
                new double[] { 6.8, 315.710000 },
                new double[] { 6.9, 323.110000 },
                new double[] { 7, 330.510000 },
                new double[] { 7.1, 337.910000 },
                new double[] { 7.2, 345.310000 },
                new double[] { 7.3, 352.710000 },
                new double[] { 7.4, 360.110000 },
                new double[] { 7.5, 367.510000 },
                new double[] { 7.6, 374.910000 },
                new double[] { 7.7, 382.310000 },
                new double[] { 7.8, 389.710000 },
                new double[] { 7.9, 397.110000 },
                new double[] { 8, 404.510000 },
                new double[] { 8.1, 411.910000 },
                new double[] { 8.2, 419.310000 },
                new double[] { 8.3, 426.710000 },
                new double[] { 8.4, 434.110000 },
                new double[] { 8.5, 441.510000 },
                new double[] { 8.6, 448.910000 },
                new double[] { 8.7, 456.310000 },
                new double[] { 8.8, 463.710000 },
                new double[] { 8.9, 471.110000 },
                new double[] { 9, 478.510000 },
                new double[] { 9.1, 485.910000 },
                new double[] { 9.2, 493.310000 },
                new double[] { 9.3, 500.710000 },
                new double[] { 9.4, 508.110000 },
                new double[] { 9.5, 515.510000 },
                new double[] { 9.6, 522.910000 },
                new double[] { 9.7, 530.310000 },
                new double[] { 9.8, 537.710000 },
                new double[] { 9.9, 545.110000 },
                new double[] { 10, 552.510000 },
                new double[] { 10.1, 559.910000 },
                new double[] { 10.2, 567.310000 },
                new double[] { 10.3, 574.710000 },
                new double[] { 10.4, 582.110000 },
                new double[] { 10.5, 589.510000 },
                new double[] { 10.6, 596.910000 },
                new double[] { 10.7, 604.310000 },
                new double[] { 10.8, 611.710000 },
                new double[] { 10.9, 619.110000 },
                new double[] { 11, 626.510000 },
                new double[] { 11.1, 633.910000 },
                new double[] { 11.2, 641.310000 },
                new double[] { 11.3, 648.710000 },
                new double[] { 11.4, 656.110000 },
                new double[] { 11.5, 663.510000 },
                new double[] { 11.6, 670.910000 },
                new double[] { 11.7, 678.310000 },
                new double[] { 11.8, 685.710000 },
                new double[] { 11.9, 693.110000 },
                new double[] { 12, 700.510000 },
                new double[] { 12.1, 707.910000 },
                new double[] { 12.2, 715.310000 },
                new double[] { 12.3, 722.710000 },
                new double[] { 12.4, 730.110000 },
                new double[] { 12.5, 737.510000 },
                new double[] { 12.6, 744.910000 },
                new double[] { 12.7, 752.310000 },
                new double[] { 12.8, 759.710000 },
                new double[] { 12.9, 767.110000 },
                new double[] { 13, 774.510000 },
                new double[] { 13.1, 781.910000 },
                new double[] { 13.2, 789.310000 },
                new double[] { 13.3, 796.710000 },
                new double[] { 13.4, 804.110000 },
                new double[] { 13.5, 811.510000 },
                new double[] { 13.6, 818.910000 },
                new double[] { 13.7, 826.310000 },
                new double[] { 13.8, 833.710000 },
                new double[] { 13.9, 841.110000 },
                new double[] { 14, 848.510000 },
                new double[] { 14.1, 855.910000 },
                new double[] { 14.2, 863.310000 },
                new double[] { 14.3, 870.710000 },
                new double[] { 14.4, 878.110000 },
                new double[] { 14.5, 885.510000 },
                new double[] { 14.6, 892.910000 },
                new double[] { 14.7, 900.310000 },
                new double[] { 14.8, 907.710000 },
                new double[] { 14.9, 915.110000 },
                new double[] { 15, 922.510000 },
                new double[] { 15.1, 929.910000 },
                new double[] { 15.2, 937.310000 },
                new double[] { 15.3, 944.710000 },
                new double[] { 15.4, 952.110000 },
                new double[] { 15.5, 959.510000 },
                new double[] { 15.6, 966.910000 },
                new double[] { 15.7, 974.310000 },
                new double[] { 15.8, 981.710000 },
                new double[] { 15.9, 989.110000 },
                new double[] { 16, 996.510000 },
                new double[] { 16.1, 1003.910000 },
                new double[] { 16.2, 1011.310000 },
                new double[] { 16.3, 1018.710000 },
                new double[] { 16.4, 1026.110000 },
                new double[] { 16.5, 1033.510000 },
                new double[] { 16.6, 1040.910000 },
                new double[] { 16.7, 1048.310000 },
                new double[] { 16.8, 1055.710000 },
                new double[] { 16.9, 1063.110000 },
                new double[] { 17, 1070.510000 },
                new double[] { 17.1, 1077.910000 },
                new double[] { 17.2, 1085.310000 },
                new double[] { 17.3, 1092.710000 },
                new double[] { 17.4, 1100.110000 },
                new double[] { 17.5, 1107.510000 },
                new double[] { 17.6, 1114.910000 },
                new double[] { 17.7, 1122.310000 },
                new double[] { 17.8, 1129.710000 },
                new double[] { 17.9, 1137.110000 },
                new double[] { 18, 1144.510000 },
                new double[] { 18.1, 1151.910000 },
                new double[] { 18.2, 1159.310000 },
                new double[] { 18.3, 1166.710000 },
                new double[] { 18.4, 1174.110000 },
                new double[] { 18.5, 1181.510000 },
                new double[] { 18.6, 1188.910000 },
                new double[] { 18.7, 1196.310000 },
                new double[] { 18.8, 1203.710000 },
                new double[] { 18.9, 1211.110000 },
                new double[] { 19, 1218.510000 },
                new double[] { 19.1, 1225.910000 },
                new double[] { 19.2, 1233.310000 },
                new double[] { 19.3, 1240.710000 },
                new double[] { 19.4, 1248.110000 },
                new double[] { 19.5, 1255.510000 },
                new double[] { 19.6, 1262.910000 },
                new double[] { 19.7, 1270.310000 },
                new double[] { 19.8, 1277.710000 },
                new double[] { 19.9, 1285.110000 },
                new double[] { 20, 1292.510000 }
            };

            double v_rez = V_rounded;

            if (v_rez < 0) v_rez = 0;
            else if (v_rez > 20) v_rez = 20;

            double delta_p = 0;

            foreach (double[] str in table_delta_p)
            {
                if (str[0] == v_rez)
                {
                    delta_p = str[1];
                    break;
                }
            }

            return KMS_from_poteri_davlenia(delta_p);
        }

        protected override void Refresh_marka()
        {
            _marka = "";

            _short_name = "Воздухоохладитель фреоновый канальный";
        }
        public void SetMarka()
        {
            Refresh_marka();
        }

        protected override void Refresh_kms()
        {
            _kms = Take_kms();
        }

        public Freonoviy_ohladitel(double rashod_m3_in_hour, double width_mm, double height_mm)
       : base("Воздухоохладитель фреоновый канальный", "", rashod_m3_in_hour, Math.Max(width_mm, height_mm), Math.Min(width_mm, height_mm), false, 0)
        {
            SetMarka();
            _kms = Take_kms();
        }

        public Freonoviy_ohladitel(double rashod_m3_in_hour, double diameter_mm)
            : base("Воздухоохладитель фреоновый канальный", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            SetMarka();
            _kms = Take_kms();
        }
    }
}
