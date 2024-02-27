using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class InMemoryInstructorDal : IInstructorDal
{
    List<Instructor> _instructors;

    public InMemoryInstructorDal()
    {
        _instructors = new List<Instructor>()
        {
            new Instructor{InstructorId = 1,InstructorFirstName="Fatih",InstructorLastName = "KILINÇ"},
            new Instructor{InstructorId = 2,InstructorFirstName="Samet",InstructorLastName = "DEDEOĞLU"},
        };
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructors.RemoveAll(
            instructorloop => instructorloop.InstructorId == instructor.InstructorId 
            && 
            instructorloop.InstructorFirstName.ToLower() == instructor.InstructorFirstName.ToLower() 
            && 
            instructorloop.InstructorLastName.ToLower() == instructor.InstructorLastName.ToLower()
            );
        //_instructors.Remove(instructor);
    }

    public List<Instructor> getAll()
    {
        return _instructors;
    }

    public Instructor GetById(int id)
    {
        return _instructors.Where(instructor => instructor.InstructorId == id).ToList()[0];
    }

    public void Update(Instructor instructor)
    {
        //diğer arkadaşlarımın koduna baktığımda nasıl çözdüklerini anlamadım bende klasik bir yöntem ile çözüyorum
        foreach (Instructor instructorfor in _instructors) {
            if (instructor.InstructorId == instructorfor.InstructorId) {
                instructorfor.InstructorFirstName = instructor.InstructorFirstName;
                instructorfor.InstructorLastName = instructor.InstructorLastName;
                return;
            }
        }
    }
}
