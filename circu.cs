using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circulo
{
    class circu
    {
        public double pi;
        public double raio;
        public string area => ((pi) * (raio)).ToString();
        public string perimetro => ((pi)+(pi) * (raio)).ToString();
        public string diagonal => ((raio)*2).ToString();
    }
}
