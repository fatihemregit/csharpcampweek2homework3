using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Instructor:IEntity
{
    public int InstructorId { get; set; }
    public string InstructorFirstName { get; set;}

    public string InstructorLastName { get; set; }


}
