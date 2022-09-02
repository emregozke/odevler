using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Gavurdagi
{
    public class AlServisET : Malzeme
    {
        public override string Al()
        {
            return "Mutfaktaki sağ üst dolaptaki raftan 2 lt lik salata kabını al";
        }

        public override string Dogra()
        {
            throw new NotImplementedException();
        }

        public override string Koy()
        {
            throw new NotImplementedException();
        }

        public override string ServisEt()
        {
            return "Hepsini salata kabının içinde 1 dk karıştır servis et.";
        }

        public override string Yıka()
        {
            throw new NotImplementedException();
        }
    }
}
