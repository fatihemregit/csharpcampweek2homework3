using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        //test edildi çalışıyor

        _instructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        //test edildi çalışıyor

        _instructorDal.Delete(instructor);
    }

    public List<Instructor> getAll()
    {
        //test edildi çalışıyor

        return _instructorDal.getAll();
    }

    public Instructor GetById(int id)
    {
        //test edildi çalışıyor
        return _instructorDal.GetById(id);
    }

    public void Update(Instructor instructor)
    {
        //test edildi çalışıyor
        _instructorDal.Update(instructor);
    }
}
