using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public class Supplier:BaseClass<Supplier>
    {
        public string SupplierCompanyName { get; set; }
        public string SupplierAdress { get; set; }
        public string SupplierCountry { get; set; }

        public override string Create(Supplier model)
        {
            int id = 0;
            if (Container.supplierList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.supplierList.Count;
            }

            model.Id = id;
            Container.supplierList.Add(model);

            return "Tedarikçi eklendi!";
        }

        public override string Delete(int id)
        {
           Supplier deletedsup = GetById(id);
            Container.supplierList.Remove(deletedsup);
            return "Tedarikçi silindi!";
        }

        public override Supplier GetById(int id)
        {
            Supplier supplier = null;
            foreach (Supplier sup in Container.supplierList.ToList())
            {
                if (sup.Id == id)
                {
                    supplier = sup;
                    break;
                }
            }
            return supplier;
        }

        public override List<Supplier> GetList()
        {
            return Container.supplierList.ToList();
        }

        public override string Update(Supplier model)
        {
            Supplier updatedsup = GetById(model.Id);
            updatedsup.SupplierCompanyName = model.SupplierCompanyName;
            updatedsup.SupplierAdress = model.SupplierAdress;
            updatedsup.SupplierCountry = model.SupplierCountry;

            return "Tedarikçi güncellendi!";
        }
    }
}
