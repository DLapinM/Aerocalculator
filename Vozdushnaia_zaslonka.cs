using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerocalculator
{
    [Serializable]
    class Vozdushnaia_zaslonka : Mestnoe_soprotivlenie
    {
        private string _marka_before;
        public Vozdushnaia_zaslonka(string marka_before, double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated)
            : base("Воздушная заслонка", "", rashod_m3_in_hour, width_mm, height_mm, rotated, 0)
        {
            SetMarka(marka_before);

            if ((_diameter_mm > 510) && (_diameter_mm < 666))
            {
                _kms = 0.18;
            }
            else
            {
                _kms = 0.16;
            }
        }

        public Vozdushnaia_zaslonka(string marka_before, double rashod_m3_in_hour, double diameter_mm)
            : base("Воздушная заслонка", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            SetMarka(marka_before);

            if (_diameter_mm > 299)
            {
                _kms = 0.4;
            }
            else
            {
                _kms = 0.5;
            }
        }
        public Vozdushnaia_zaslonka(string marka_before, double rashod_m3_in_hour, double width_mm, double height_mm, bool rotated, bool nalichie_electroprivoda)
            : base("Воздушная заслонка", "", rashod_m3_in_hour, width_mm, height_mm, rotated, 0)
        {
            if (nalichie_electroprivoda) _short_name = "Воздушная заслонка c электроприводом";

            SetMarka(marka_before);

            if ((_diameter_mm > 510) && (_diameter_mm < 666))
            {
                _kms = 0.18;
            }
            else
            {
                _kms = 0.16;
            }
        }

        public Vozdushnaia_zaslonka(string marka_before, double rashod_m3_in_hour, double diameter_mm, bool nalichie_electroprivoda)
            : base("Воздушная заслонка", "", rashod_m3_in_hour, diameter_mm, 0)
        {
            if (nalichie_electroprivoda) _short_name = "Воздушная заслонка c электроприводом";

            SetMarka(marka_before);

            if (_diameter_mm > 299)
            {
                _kms = 0.4;
            }
            else
            {
                _kms = 0.5;
            }
        }

        public override string Name
        {
            get
            {
                Refresh_marka();

                if (_marka_before == "")
                {
                    if (_forma_sechenia == "rectangle")
                    {
                        return "Воздушная заслонка " + _width_mm.ToString() + "x" + _height_mm.ToString();
                    }
                    else
                    {
                        return "Воздушная заслонка DN" + _diameter_mm.ToString();
                    }
                }
                else
                {
                    return "Воздушная заслонка " + _marka;
                }
            }
        }
        protected override void Refresh_marka()
        {
            if (_forma_sechenia == "rectangle")
            {
                _marka = _marka_before + "-" + _width_mm.ToString() + "x" + _height_mm.ToString();
            }
            else
            {
                _marka = _marka_before + "-" + _diameter_mm.ToString();
            }
        }

        public void SetMarka(string marka_before_sechenie)
        {
            _marka_before = marka_before_sechenie;

            Refresh_marka();
        }
        protected override void Refresh_kms()
        {
            if (_forma_sechenia == "rectangle")
            {
                if ((_diameter_mm > 510) && (_diameter_mm < 666))
                {
                    _kms = 0.18;
                }
                else
                {
                    _kms = 0.16;
                }
            }
            else
            {
                if (_diameter_mm > 299)
                {
                    _kms = 0.4;
                }
                else
                {
                    _kms = 0.5;
                }
            }
        }
    }
}
