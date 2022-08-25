using System;
using System.Collections;

namespace CA_product
{
    public class Program
       
    {
        
        static void Main(string[] args)
        {
            ArrayList productBox = new ArrayList();
            
            Product product1 = new Product();
            product1.Kaydet();
                       
            productBox.Add(product1);   

            Product product2 = new Product();
            product2.Kaydet();
            
            productBox.Add(product2);

            product1.Listele();
            product2.Listele();
        }
    }
}
