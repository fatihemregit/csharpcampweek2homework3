using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        //test edildi çalışıyor

        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        //test edildi çalışıyor

        _courseDal.Delete(course);
    }

    public List<Course> GetAll()
    {
        //test edildi çalışıyor
        return _courseDal.GetAll();
    }

    public List<Course> GetAllByCategory(int CategoryId)
    {
        //test edildi çalışıyor

        return _courseDal.GetAllByCategory(CategoryId);
    }

    public List<Course> GetAllByInstructor(int InstructorId)
    {
        //test edildi çalışıyor
        return _courseDal.GetAllByInstructor(InstructorId);
    }

    public Course GetById(int id)
    {
        //test edildi çalışıyor
        return _courseDal.GetById(id);
    }

    public void Update(Course course)
    {
        //test edildi çalışıyor

        _courseDal.Update(course);
    }
}
