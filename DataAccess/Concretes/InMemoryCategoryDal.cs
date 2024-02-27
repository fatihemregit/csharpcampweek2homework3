using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InMemoryCategoryDal : ICategoryDal
{
    List<Category> _categories;

    public InMemoryCategoryDal()
    {
        _categories = new List<Category>()
        {
            new Category{Id = 1,Name = "Programlama"},
            new Category{Id = 2,Name = "Video ve Fotoğraf Düzenleme"},
        };
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        //burada düzeltmeler yapılabilir
        _categories.RemoveAll(c => c.Id == category.Id && c.Name.ToLower() == category.Name.ToLower());
        //_categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.Where(category => category.Id == id).ToList()[0];
    }

    public void Update(Category category)
    {
        foreach (Category categoryfor in _categories)
        {
            if (category.Id == categoryfor.Id) {
                categoryfor.Name = category.Name;
                return;
            }
        }
    }
}
