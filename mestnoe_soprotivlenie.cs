using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    public class Mestnoe_soprotivlenie
    {
        protected bool _rotated;
        protected string _short_name;
        protected string _marka;
        protected string _forma_sechenia;
        protected double _diameter_mm;
        protected double _width_mm;
        protected double _height_mm;
        protected double _rashod_m3_in_hour;
        protected double _kms;

        protected double Ploschad_by_rectangle
        {
            get
            {
                return (double)(((double)_width_mm / (double)1000) * ((double)_height_mm / (double)1000));
            }
        }

        protected double Ploschad_by_circle
        {
            get
            {
                return (Math.PI * Math.Pow((_diameter_mm / 1000.0), 2.0)) / 4.0;
            }
        }

        protected double Ploschad
        {
            get
            {
                return Ploschad_by_circle;
            }
        }

        protected double V_by_rectangle
        {
            get
            {
                if (Ploschad_by_rectangle == 0) return 0;
                double rashod_m3_in_s = (_rashod_m3_in_hour / 3600.0);
                return rashod_m3_in_s / Ploschad_by_rectangle;
            }
        }

        protected double V_by_circle
        {
            get
            {
                if (Ploschad_by_circle == 0) return 0;
                double rashod_m3_in_s = (_rashod_m3_in_hour / 3600.0);
                return rashod_m3_in_s / Ploschad_by_circle;
            }
        }

        protected double V
        {
            get
            {
                if (Ploschad == 0) return 0;
                double rashod_m3_in_s = (_rashod_m3_in_hour / 3600.0);
                return rashod_m3_in_s / Ploschad;
            }
        }
        protected double V_by_rectangle_rounded
        {
            get
            {
                return ((Math.Round(V_by_rectangle * 10.0)) / 10.0);
            }
        }
        protected double V_by_circle_rounded
        {
            get
            {
                return ((Math.Round(V_by_circle * 10.0)) / 10.0);
            }
        }
        protected double V_rounded
        {
            get
            {
                return ((Math.Round(V * 10.0)) / 10.0);
            }
        }

        protected double KMS_from_poteri_davlenia (double poteri_davlenia_Pa)
        {
            double t_v_grad_celcia = 16;

            double t_v_kelvin = t_v_grad_celcia + 273.15;

            double plotnost = (double)((decimal)99500 * ((decimal)29 / (decimal)1000) / ((decimal)8.314463 * (decimal)t_v_kelvin));

            if ((V == 0) || (plotnost == 0)) return 0;

            return (poteri_davlenia_Pa / (plotnost * Math.Pow(V, 2.0) / 2.0));
        }

        public bool Rotated
        {
            get
            {
                return _rotated;
            }
        }
        public string Short_name
        {
            get
            {
                return _short_name;
            }
        }
        public virtual string Name
        {
            get
            {
                if (Forma_sechenia == "rectangle")
                {
                    return (_short_name + " " + Width_mm.ToString() + "x" + Height_mm.ToString());
                }

                else
                {
                    return (_short_name + " DN" + Diameter_mm.ToString());
                }
            }
        }

        public string Marka
        {
            get
            {
                return _marka;
            }
        }
        public string Forma_sechenia
        {
            get
            {
                return _forma_sechenia;
            }
        }
        public double Diameter_mm
        {
            get
            {
                return _diameter_mm;
            }
        }
        public double Width_mm
        {
            get
            {
                return _width_mm;
            }
        }
        public double Height_mm
        {
            get
            {
                return _height_mm;
            }
        }
        public double Rashod_m3_in_hour
        {
            get
            {
                return _rashod_m3_in_hour;
            }
        }
        public double KMS
        {
            get
            {
                return _kms;
            }

            set
            {
                _kms = value;
            }
        }

        public Mestnoe_soprotivlenie(string short_name, string marka, double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated, double kms)
        {
            _short_name = short_name;

            _marka = marka;

            _forma_sechenia = "rectangle";

            _rashod_m3_in_hour = rashod_m3_in_hour;

            _rotated = rotated;

            if (_rotated)
            {
                _width_mm = height_mm;
                _height_mm = width_mm;
            }
            else
            {
                _width_mm = width_mm;
                _height_mm = height_mm;
            }

            _diameter_mm = (((double)2) * _width_mm * _height_mm) / (_width_mm + _height_mm);

            _kms = kms;
        }

        public Mestnoe_soprotivlenie(string short_name, string marka, double rashod_m3_in_hour, double diameter_mm , double kms)
        {
            _short_name = short_name;

            _marka = marka;

            _forma_sechenia = "circle";

            _rashod_m3_in_hour = rashod_m3_in_hour;

            _width_mm = 0;

            _height_mm = 0;

            _diameter_mm = diameter_mm;

            _rotated = false;

            _kms = kms;
        }

        protected virtual void Refresh_marka()
        {
            _marka = "";
        }
        protected virtual void Refresh_kms()
        {
            _kms = 0;
        }
        public void ChangeParametersByUchastok(Uchastok uch)
        {
            _rashod_m3_in_hour = uch.Rashod_m3_in_hour;

            if (!_rotated)
            {
                _width_mm = uch.Width_mm;
                _height_mm = uch.Height_mm;
            }
            else
            {
                _width_mm = uch.Height_mm;
                _height_mm = uch.Width_mm;
            }
            
            _diameter_mm = uch.Diameter_mm;
            _forma_sechenia = uch.Forma_sechenia;

            Refresh_marka();

            Refresh_kms();
        }

        public override string ToString()
        {
            return Name + " " + _marka + " КМС = " + _kms;
        }
    }
}
