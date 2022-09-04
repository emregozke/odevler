using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public class Shipper:BaseClass<Shipper>
    {
        public string ShipperName { get; set; }
        public string ShipperPhone { get; set; }

        public string ShipperAdress { get; set; }

        public override string Create(Shipper model)
        {
            int id = 0;
            if (Container.shipperList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.shipperList.Count;
            }

            model.Id = id;
            Container.shipperList.Add(model);

            return "Nakliyeci eklendi!";
        }

        public override string Delete(int id)
        {
            Shipper deletedship = GetById(id);
            Container.shipperList.Remove(deletedship);
            return "Nakliyeci silindi!";
        }

        public override Shipper GetById(int id)
        {
            Shipper shipper = null;
            foreach (Shipper ship in Container.shipperList.ToList())
            {
                if (ship.Id == id)
                {
                    shipper = ship;
                    break;
                }
            }
            return shipper;
        }

        public override List<Shipper> GetList()
        {
           return Container.shipperList.ToList();
        }

        public override string Update(Shipper model)
        {
            Shipper updatedship = GetById(model.Id);
            updatedship.ShipperName = model.ShipperName;
            updatedship.ShipperPhone = model.ShipperPhone;
            updatedship.ShipperAdress = model.ShipperAdress;

            return "Nakliyeci güncellendi!";
        }
    }
}
