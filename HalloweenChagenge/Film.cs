using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenChagenge
{
    class Film
    {
        public string title { get; set; }

        public string description { get; set; }

        public string rating { get; set; }

        public string length { get; set; }

        public string FullInfo
        {
            get
            {
                return ":\t" + title;
            }
        }
    }
}
