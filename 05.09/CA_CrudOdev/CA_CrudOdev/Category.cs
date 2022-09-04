using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CrudOdev
{
    public class Category:BaseClass<Category>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string Create(Category model)
        {
            int id = 0;
            if (Container.categoryList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.categoryList.Count;
            }

            model.Id = id;
            Container.categoryList.Add(model);

            return "kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Category deleted = GetById(id);
            Container.categoryList.Remove(deleted);
            return "kategori silindi!";
        }

        public override Category GetById(int id)
        {
            Category category = null;
            foreach (Category cat in Container.categoryList.ToList())
            {
                if (cat.Id == id)
                {
                    category = cat;
                    break;
                }
            }
            return category;
        }

        public override List<Category> GetList()
        {
            return Container.categoryList.ToList();
            
        }

        public override string Update(Category model)
        {
            Category updated = GetById(model.Id);
            updated.CategoryName = model.CategoryName;
            updated.Description = model.Description;
            return "kategori güncellendi!";
        }
    }
}
