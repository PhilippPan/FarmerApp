using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFermer.AppData
{
    public partial class Fermer
    {
        public string Info
        {
            get
            {
                return String.Format($"{Familia} {Imya} {Otchestvo} - (id{Id})");
            }
        }

        public string PersonalInfo {
            get {
                return String.Format($"{Familia} {Imya} {Otchestvo}");
            }
        }
    }
}
