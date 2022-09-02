using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Gavurdagi
{
    public class Domates : Malzeme
    {
        public override string Al()
        {
            throw new NotImplementedException();
        }

        public override string Dogra()
        {
            return "Domatesleri soy küçük küçük doğra";
        }

        public override string Koy()
        {
            throw new NotImplementedException();
        }

        public override string ServisEt()
        {
            throw new NotImplementedException();
        }

        public override string Yıka()
        {
            return "O salata kabına 3 adet domatesi yıka";
        }
    }
}
