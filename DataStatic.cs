using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    public static class DataStatic
    {
        public static string vent_sys_new_type;
        public static string vent_sys_new_number;
        public static string vent_sys_new_name;
        public static double vent_sys_napor_ventiliatora;

        public static bool uchastok_rectangle_or_not;
        public static string uchastok_material;
        public static double uchastok_temperatura;
        public static double uchastok_rashod_m3_in_hour;
        public static double uchastok_dlina_m;
        public static double uchastok_diameter_mm;
        public static double uchastok_shirina_mm;
        public static double uchastok_visota_mm;

        public static string getMaterial(string material)
        {
            if (material == "листовая сталь") return "листовая сталь";
            else if (material == "винипласт") return "винипласт";
            else if (material == "асбест") return "асбест";
            else if (material == "фанера") return "фанера";
            else if (material == "шлакоалебастровые плиты") return "шлакоалебастровые плиты";
            else if (material == "кирпич") return "кирпич";
            else if (material == "штукатурка") return "штукатурка";
            else if (material == "бетон") return "бетон";
            else return "листовая сталь";
        }

        public static string tip_mestnogo_soprotivlenia;
        public static string forma_mestnogo_soprotivlenia;
        public static int kolichestvo_elementov_mestnogo_soprotivlenia;

        public static double ugol_povorota_otvoda;
        public static bool povorot_vdol_shirini_true_vdol_visoti_false;

        public static bool rotated_or_not;
        public static string marka_before_razmeri;
        public static string marka_after_razmeri;

        public static double width;
        public static double height;
        public static double diameter;

        public static bool klapan_kanalniy_true_stenovoy_false;

        public static int klapan_na_gorizontali_1_na_vertikali_2;

        public static string tip_germoklapana;
        public static bool germoklapan_kor_or_not;

        public static string filtr_proizvoditel;
        public static string filtr_klass;

        public static double moschnost_nagrevatelia;

        public static string shumoglushitel_proizvoditel;
        public static double shumoglushitel_dlina;

        public static string gibkaia_vstavka_proizvoditel;

        public static int number_uchastok_current;
        public static int number_uchastok_before;
        public static int number_uchastok_after;
        public static int kolichestvo_uchastkov;

        public static int first_uchastok_number;
        public static int second_uchastok_number;

        public static double perehod_dlina;
        public static bool vnezapniy_perehod;

        public static string vent_sys_type;

        public static double other_uchastok_width;
        public static double other_uchastok_height;
        public static double other_uchastok_diameter;

        public static string troynik_type;

        public static string file_otchet_name;
        public static string file_otchet_path;

        public static List<Ventilation_system> vs_list;
    }
}
