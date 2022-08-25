using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_product
{
    public class Product
    {
        ArrayList productbox = new ArrayList();

        public int Id;
		public string ProductName;
		public int UnitsInStock;
		public decimal UnitPrice;
		public string CategoryName;
		public string SupplierName;

        public void Kaydet()
        {

            Product product1 = new Product();

            Console.WriteLine("id no girin");
            product1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ürün adı girin");
            product1.ProductName = Console.ReadLine();
            Console.WriteLine("Stoktaki ürün miktarını girin");
            product1.UnitsInStock = int.Parse(Console.ReadLine());
            Console.WriteLine("Ürün fiyatını girin");
            product1.UnitPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ürün kategorisini girin");
            product1.CategoryName = Console.ReadLine();
            Console.WriteLine("Tedarikçi adı girin");
            product1.SupplierName = Console.ReadLine();

            productbox.Add(product1);
        }
        public void Listele()
        {
            foreach (object item in productbox)
            {
                //if (item is Product)
                //{
                    Product gelenproduct = (Product)item;
                    string ozet = $"Id no: {gelenproduct.Id} ProductName: {gelenproduct.ProductName} UnitsInStock: {gelenproduct.UnitsInStock} UnitPrice: {gelenproduct.UnitPrice} CategoryName: {gelenproduct.CategoryName} SupplierName: {gelenproduct.SupplierName}";

                    Console.WriteLine(ozet);
                //}
            }
        }

    }

}
