using System;
using System.Collections.Generic;

namespace CA_CrudOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("***************************");
            Console.WriteLine("*Northwind Database System!");
            Console.WriteLine("***************************");

            try
            {
                while (true)
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("Ürün İşlemleri: \n1.list - (listeleme)\n2.add - (ekle)\n3.update - (güncelle)\n4.remove - (sil)");
                    int selected = Convert.ToInt32(Console.ReadLine());
                    switch (selected)
                    {
                        case 1:
                            Console.WriteLine("Listelemek istediğiniz birimi seçiniz");
                            Console.WriteLine("1.Category  \n2.Customer  \n3.Employee \n4.Product \n5.Shipper \n6.Supplier");
                            int selectBirim = Convert.ToInt32(Console.ReadLine());
                            switch (selectBirim)
                            {
                                case 1:
                                    Category category = new Category();
                                    foreach (Category cat in category.GetList())
                                    {
                                        Console.WriteLine($"{cat.CategoryName}  {cat.CreatedDate}");
                                    }
                                    break;
                                case 2:
                                    Customer customer = new Customer();
                                    foreach (Customer cus in customer.GetList())
                                    {
                                        Console.WriteLine($"{cus.CustomerName}  {cus.CustomerSurname}  {cus.CustomerAdress}");
                                    }
                                    break;
                                case 3:
                                    Employee employee = new Employee();
                                    foreach (Employee emp in employee.GetList())
                                    {
                                        Console.WriteLine($"{emp.EmployeeName}  {emp.EmployeeSurname}  {emp.EmployeeAdress}  {emp.CreatedDate}");
                                    }
                                    break;
                                case 4:
                                    Product product = new Product();
                                    foreach (Product pro in product.GetList())
                                    {
                                        Console.WriteLine($"{pro.ProductName}  {pro.UnitPrice} {pro.Category.CategoryName}");
                                    }
                                    break;
                                case 5:
                                    Shipper shipper = new Shipper();
                                    foreach (Shipper ship in shipper.GetList())
                                    {
                                        Console.WriteLine($"{ship.ShipperName}  {ship.ShipperPhone}  {ship.ShipperAdress}");
                                    }
                                    break;
                                case 6:
                                    Supplier supplier = new Supplier();
                                    foreach (Supplier sup in supplier.GetList())
                                    {
                                        Console.WriteLine($"{sup.SupplierCompanyName}  {sup.SupplierAdress} {sup.SupplierCountry}");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Hatalı sayı girdiniz");
                                    break;


                            }
                            break;
                        case 2:
                            Console.WriteLine("Eklemek istediğiniz birimi seçiniz");
                            Console.WriteLine("1.Category  \n2.Customer  \n3.Employee \n4.Product \n5.Shipper \n6.Supplier");
                            int selectEkle = Convert.ToInt32(Console.ReadLine());
                            switch (selectEkle)
                            {
                                case 1:
                                    Category category = new Category();
                                    Category newCategory = new Category();
                                    Console.WriteLine("Kategori adı girin");
                                    newCategory.CategoryName = Console.ReadLine();

                                    Console.WriteLine("Açıklama girin");
                                    newCategory.Description = Console.ReadLine();

                                    Console.WriteLine(category.Create(newCategory));
                                    break;
                                case 2:
                                    Customer customer = new Customer();
                                    Customer newCustomer = new Customer();

                                    Console.WriteLine("Müşteri adı girin");
                                    newCustomer.CustomerName = Console.ReadLine();

                                    Console.WriteLine("Müşteri soyadı girin");
                                    newCustomer.CustomerName = Console.ReadLine();

                                    Console.WriteLine("Müşteri adresi girin");
                                    newCustomer.CustomerAdress = Console.ReadLine();

                                    Console.WriteLine(customer.Create(newCustomer));
                                    break;
                                case 3:
                                    Employee employee = new Employee();
                                    Employee newEmployee = new Employee();

                                    Console.WriteLine("Çalışan adı girin");
                                    newEmployee.EmployeeName = Console.ReadLine();

                                    Console.WriteLine("Çalışan soyadı girin");
                                    newEmployee.EmployeeSurname = Console.ReadLine();

                                    Console.WriteLine("Çalışan adresi girin");
                                    newEmployee.EmployeeAdress = Console.ReadLine();

                                    Console.WriteLine(employee.Create(newEmployee));
                                    break;
                                case 4:
                                    Product product = new Product();
                                    Product newProduct = new Product();

                                    Console.WriteLine("Ürün adı girin");
                                    newProduct.ProductName = Console.ReadLine();

                                    Console.WriteLine("Ürünfiyatı girin");
                                    newProduct.UnitPrice = int.Parse(Console.ReadLine());

                                    Console.WriteLine(product.Create(newProduct));
                                    break;
                                case 5:
                                    Shipper shipper = new Shipper();
                                    Shipper newshipper = new Shipper();

                                    Console.WriteLine("Nakliyeci adı girin");
                                    newshipper.ShipperName = Console.ReadLine();

                                    Console.WriteLine("Nakliyeci telefonu girin");
                                    newshipper.ShipperPhone = Console.ReadLine();

                                    Console.WriteLine("Nakliyeci adresi girin");
                                    newshipper.ShipperAdress = Console.ReadLine();

                                    Console.WriteLine(shipper.Create(newshipper));
                                    break;
                                case 6:
                                    Supplier supplier = new Supplier();
                                    Supplier newsupplier = new Supplier();

                                    Console.WriteLine("Tedarikçi ismi girin");
                                    newsupplier.SupplierCompanyName = Console.ReadLine();

                                    Console.WriteLine("Tedarikçi adresi girin");
                                    newsupplier.SupplierAdress = Console.ReadLine();

                                    Console.WriteLine("Tedarikçi ülkesi girin");
                                    newsupplier.SupplierCountry = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Hatalı sayı girdiniz");
                                    break;





                            }
                            break;
                        case 3:
                            Console.WriteLine("Güncellemek istediğiniz birimi seçiniz");
                            Console.WriteLine("1.Category  \n2.Customer  \n3.Employee \n4.Product \n5.Shipper \n6.Supplier");
                            int selectGuncel = Convert.ToInt32(Console.ReadLine());
                            switch (selectGuncel)
                            {
                                case 1:
                                    Category category = new Category();
                                    Console.WriteLine("Güncellemek istediğiniz kategorinin Id numarasını girin: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Category updated = category.GetById(id);

                                    Console.WriteLine("Yeni kategori adı:");
                                    updated.CategoryName = Console.ReadLine();
                                    Console.WriteLine("Yeni kategori açıklaması:");
                                    updated.Description = Console.ReadLine();

                                    Console.WriteLine(category.Update(updated));
                                    break;
                                case 2:
                                    Customer customer = new Customer();
                                    Console.WriteLine("Güncellemek istediğiniz müşterinin Id numarasını girin: ");
                                    id = int.Parse(Console.ReadLine());
                                    Customer updatedcus = customer.GetById(id);

                                    Console.WriteLine("Müşteri adı girin");
                                    updatedcus.CustomerName = Console.ReadLine();
                                    Console.WriteLine("Müşteri soyadı girin");
                                    updatedcus.CustomerSurname = Console.ReadLine();
                                    Console.WriteLine("Müşteri adres girin");
                                    updatedcus.CustomerAdress = Console.ReadLine();

                                    Console.WriteLine(customer.Update(updatedcus));
                                    break;
                                case 3:
                                    Employee employee = new Employee();
                                    Console.WriteLine("Güncellemek istediğiniz çalışanın Id numarasını girin: ");
                                    id = int.Parse(Console.ReadLine());
                                    Employee updateemp = employee.GetById(id);

                                    Console.WriteLine("Çalışan adı girin");
                                    updateemp.EmployeeName = Console.ReadLine();
                                    Console.WriteLine("Çalışan soyadı girin");
                                    updateemp.EmployeeSurname = Console.ReadLine();
                                    Console.WriteLine("Çalışan adres girin");
                                    updateemp.EmployeeAdress = Console.ReadLine();

                                    Console.WriteLine(employee.Update(updateemp));
                                    break;
                                case 4:
                                    Product product = new Product();
                                    Console.WriteLine("Güncellemek istediğiniz ürünün Id numarasını girin: ");
                                    id = int.Parse(Console.ReadLine());

                                    Product updatepro = product.GetById(id);

                                    Console.WriteLine("Ürün adı girin");
                                    updatepro.ProductName = Console.ReadLine();
                                    Console.WriteLine("Ürün fiyatı girin");
                                    updatepro.UnitPrice = int.Parse(Console.ReadLine());

                                    Console.WriteLine(product.Update(updatepro));
                                    break;
                                case 5:
                                    Shipper shipper = new Shipper();
                                    Console.WriteLine("Güncellemek istediğiniz nakliyecinin Id numarasını girin: ");
                                    id = int.Parse(Console.ReadLine());

                                    Shipper updatedship = shipper.GetById(id);

                                    Console.WriteLine("Nakliyeci adı girin");
                                    updatedship.ShipperName = Console.ReadLine();
                                    Console.WriteLine("Nakliyeci telefonu girin");
                                    updatedship.ShipperPhone = Console.ReadLine();
                                    Console.WriteLine("Nakliyeci adresi girin");
                                    updatedship.ShipperAdress = Console.ReadLine();

                                    Console.WriteLine(shipper.Update(updatedship));
                                    break;
                                case 6:
                                    Supplier supplier = new Supplier();
                                    Console.WriteLine("Güncellemek istediğiniz tedarikçinin Id numarasını girin: ");
                                    id = int.Parse(Console.ReadLine());
                                    Supplier updatedsup = supplier.GetById(id);

                                    Console.WriteLine("Tedarikçi şirket adı girin");
                                    updatedsup.SupplierCompanyName = Console.ReadLine();
                                    Console.WriteLine("Tedarikçi adresi girin");
                                    updatedsup.SupplierAdress = Console.ReadLine();
                                    Console.WriteLine("Tedarikçi ülkesi girin");
                                    updatedsup.SupplierCountry = Console.ReadLine();

                                    Console.WriteLine(supplier.Update(updatedsup));
                                    break;
                                default:
                                    Console.WriteLine("Hatalı sayı girdiniz");
                                    break;


                            }
                            break;
                        case 4:
                            Console.WriteLine("Listelemek istediğiniz birimi seçiniz");
                            Console.WriteLine("1.Category  \n2.Customer  \n3.Employee \n4.Product \n5.Shipper \n6.Supplier");
                            int selectdelete = Convert.ToInt32(Console.ReadLine());
                            switch (selectdelete)
                            {
                                case 1:
                                    Console.WriteLine("Lütfen silmek istediğiniz kategori id sini seçiniz");
                                    Category category = new Category();
                                    int id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(category.Delete(id));
                                    break;
                                case 2:
                                    Console.WriteLine("Lütfen silmek istediğiniz müşteri id sini seçiniz");
                                    Customer customer = new Customer();
                                    id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(customer.Delete(id));
                                    break;
                                case 3:
                                    Console.WriteLine("Lütfen silmek istediğiniz çalışan id sini seçiniz");
                                    Employee employee = new Employee();
                                    id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(employee.Delete(id));
                                    break;
                                case 4:
                                    Console.WriteLine("Lütfen silmek istediğiniz ürün id sini seçiniz");
                                    Product product = new Product();
                                    id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(product.Delete(id));
                                    break;
                                case 5:
                                    Console.WriteLine("Lütfen silmek istediğiniz nakliyeci id sini seçiniz");
                                    Shipper shipper = new Shipper();
                                    id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(shipper.Delete(id));
                                    break;
                                case 6:
                                    Console.WriteLine("Lütfen silmek istediğiniz tedarikçi id sini seçiniz");
                                    Supplier supplier = new Supplier();
                                    id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(supplier.Delete(id));
                                    break;
                                default:
                                    Console.WriteLine("Hatalı sayı girdiniz");
                                    break;


                            }
                            break;
                            default:
                            Console.WriteLine("Hatalı sayı girdiniz");
                                break;








                    }


                }
            }
            catch 
            {

                Console.WriteLine("Belirtilen aralıkta bir sayı giriniz");
            }
            
            
        }
    }
}
