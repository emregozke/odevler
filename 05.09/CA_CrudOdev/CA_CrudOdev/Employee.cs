using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public class Employee:BaseClass<Employee>
    {
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeAdress { get; set; }

        public override string Create(Employee model)
        {
            int id = 0;
            if (Container.employeeList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.employeeList.Count;
            }

            model.Id = id;
            Container.employeeList.Add(model);

            return "Çalışan eklendi!";
        }

        public override string Delete(int id)
        {
            Employee deletedemp = GetById(id);
            Container.employeeList.Remove(deletedemp);
            return "Çalışan silindi!";
        }

        public override Employee GetById(int id)
        {
            Employee employee = null;
            foreach (Employee emp in Container.employeeList.ToList())
            {
                if (emp.Id == id)
                {
                    employee = emp;
                    break;
                }
            }
            return employee;
        }

        public override List<Employee> GetList()
        {
            return Container.employeeList.ToList();
        }

        public override string Update(Employee model)
        {
            Employee updatedemp = GetById(model.Id);
            updatedemp.EmployeeName = model.EmployeeName;
            updatedemp.EmployeeSurname = model.EmployeeSurname;
            updatedemp.EmployeeAdress = model.EmployeeAdress;
            return "Çalışan güncellendi!";
        }
    }
}
