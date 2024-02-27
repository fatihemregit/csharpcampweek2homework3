using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{

    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        //test edildi çalışıyor
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        //test edildi çalışıyor
        _categoryDal.Delete(category);
    }

    public List<Category> GetAll()
    {
        //test edildi çalışıyor
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        //test edildi çalışıyor
        return _categoryDal.GetById(id);
    }

    public void Update(Category category)
    {
        //test edildi çalışıyor
        _categoryDal.Update(category);
    }
}
