using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business

    //Three layer denilen 3 ana katman (business, dataAccess ve Presentation) BİRBİRLERİNİ NEW'LEYEMEZ
{
    public class CourseManager
    {
        //dependency injection
         ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)  
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            // business rules
            CourseDal courseDal = new CourseDal();

            return courseDal.GetAll();
        }
    }
}
