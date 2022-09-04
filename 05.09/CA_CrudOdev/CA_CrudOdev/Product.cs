using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public class Product:BaseClass<Product>
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Category Category { get; set; }

        public override string Create(Product model)
        {
            int id = 0;
            if (Container.productList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.productList.Count;
            }

            model.Id = id;
            Container.productList.Add(model);

            return "Ürün eklendi!";
        }

        public override string Delete(int id)
        {
            Product deletedpro = GetById(id);
            Container.productList.Remove(deletedpro);
            return "ürün silindi!";
        }

        public override Product GetById(int id)
        {
            Product product = null;
            foreach (Product pro in Container.productList.ToList())
            {
                if (pro.Id == id)
                {
                    product = pro;
                    break;
                }
            }
            return product;
        }

        public override List<Product> GetList()
        {
            return Container.productList.ToList();
        }

        public override string Update(Product model)
        {
            Product updatedpro = GetById(model.Id);
            updatedpro.ProductName = model.ProductName;
            updatedpro.UnitPrice = model.UnitPrice;
            
            return "Ürün güncellendi!";
        }
    }
}
