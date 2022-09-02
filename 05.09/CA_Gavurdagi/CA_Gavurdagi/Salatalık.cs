using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Gavurdagi
{
    public class Salatalık : Malzeme
    {
        public override string Al()
        {
            throw new NotImplementedException();
        }

        public override string Dogra()
        {
            return "2 tane salatalık ince doğra";
        }

        public override string Koy()
        {
            return "kaba koy";
        }

        public override string ServisEt()
        {
            throw new NotImplementedException();
        }

        public override string Yıka()
        {
            throw new NotImplementedException();
        }
    }
}
