using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public class Customer:BaseClass<Customer>
    {
        public String CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAdress { get; set; }

        public override string Create(Customer model)
        {
            int id = 0;
            if (Container.customerList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.customerList.Count;
            }

            model.Id = id;
            Container.customerList.Add(model);

            return "Müşteri eklendi!";
        }

        public override string Delete(int id)
        {
            Customer deleted = GetById(id);
            Container.customerList.Remove(deleted);
            return "Müşteri silindi!";
        }

        public override Customer GetById(int id)
        {
            Customer customer = null;
            foreach (Customer cus in Container.customerList.ToList())
            {
                if (cus.Id == id)
                {
                    customer = cus;
                    break;
                }
            }
            return customer;
        }

        public override List<Customer> GetList()
        {
            return Container.customerList.ToList();
        }

        public override string Update(Customer model)
        {
            Customer updatedcus = GetById(model.Id);
            updatedcus.CustomerName = model.CustomerName;
            updatedcus.CustomerSurname = model.CustomerSurname;
            updatedcus.CustomerAdress=model.CustomerAdress;
            return "Müşteri güncellendi!";
        }
    }
}
