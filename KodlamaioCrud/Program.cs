using Business.Concretes;
using DataAccess.Concretes;
using Entities.Concretes;


namespace KodlamaioCrud
{



    internal class Program
    {
        static void Main(string[] args)
        {
            //kategori ile alakalı işlemler
            //CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());

            ////kategori listeleme
            ////çalışıyor
            //Console.WriteLine("================İlk Ekleme Testi================");
            //KategoriListele(categoryManager);



            ////yeni kategori ekleyip ardından tekrar sıralama
            ////çalışıyor
            //Console.WriteLine("================Ekleme Testi================");
            //categoryManager.Add(new Category { Id = 3, Name = "Kişisel Gelişim" });
            //KategoriListele(categoryManager);




            ////kategori silip ardından tekrar sıralama
            ////çalışMIyor
            //Console.WriteLine("================Silme Testi================");
            //categoryManager.Delete(new Category { Id = 3, Name = "Kişisel Gelişim" });
            //KategoriListele(categoryManager);





            ////kategori id ye göre getirme
            //Console.WriteLine("================Get by id Testi================");
            //Category category = categoryManager.GetById(1);
            //Console.WriteLine($"id : {category.Id} | kategori : {category.Name}");
            ////kategori bilgisini güncelleyip ardından tekrar sıralama
            ////çalışıyor
            //Console.WriteLine("================Güncelleme Testi================");

            //categoryManager.Update(new Category { Id = 2, Name = "Video ve Fotoğraf Düzenleme işlemleri" });
            //KategoriListele(categoryManager);


            //instructor ile alakalı işlemler
            //InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());
            //// instructor listeleme
            //Console.WriteLine("================Listeleme Testi================");
            //InstructorListele(instructorManager);


            ////instructor ekleme ve ardından listeleme
            //Console.WriteLine("================Ekleme Testi================");
            //instructorManager.Add(new Instructor { InstructorId = 3,InstructorFirstName = "Engin",InstructorLastName = "Demiroğ"});
            //InstructorListele(instructorManager);

            ////instructor silme ve ardından listeleme
            //Console.WriteLine("================Silme Testi================");
            //instructorManager.Delete(new Instructor { InstructorId = 3, InstructorFirstName = "Engin", InstructorLastName = "Demiroğ" });
            //InstructorListele(instructorManager);

            ////instructor id ye göre getirme 
            //Console.WriteLine("================Get By id Testi================");
            //Instructor instructor = instructorManager.GetById(2);
            //Console.WriteLine($"instructorId : {instructor.InstructorId} | instructorFirstName : {instructor.InstructorFirstName}| instructorLastName : {instructor.InstructorLastName}");

            ////instructor güncelleme ve ardından listeleme
            //Console.WriteLine("================Güncelleme Testi================");
            //instructorManager.Update(new Instructor { InstructorId = 1, InstructorFirstName = "Fatih Emre", InstructorLastName = "KILINÇ" });
            //InstructorListele(instructorManager);


            // course ile ilgili İşlemler
            //CourseManager courseManager = new CourseManager( new InMemoryCourseDal());
            ////course listeleme
            //Console.WriteLine("================================================Listeleme Testi================================================");
            //CourseListele(courseManager);
            
            
            ////course ekleme ve ardından listeleme
            //Console.WriteLine("================================================Ekleme Testi================================================");
            //courseManager.Add(new Course { CourseId = 6, CategoryId = 3, InstructorId = 3, CourseName = " ingilizce a1-a2 kursu", CourseDescription = "ingilizce öğreniyoruz" });
            //CourseListele(courseManager);
            ////course silme ve ardından listeleme
            //Console.WriteLine("================================================Silme Testi================================================");
            //courseManager.Delete(new Course { CourseId = 6, CategoryId = 3, InstructorId = 3, CourseName = " ingilizce a1-a2 kursu", CourseDescription = "ingilizce öğreniyoruz" });
            //CourseListele(courseManager);
            

            ////course id ye göre getirme
            //Console.WriteLine("================================================Get by id Testi================================================");
            //Course course = courseManager.GetById(3);
            //Console.WriteLine($" courseId : {course.CourseId} | categoryId : {course.CategoryId} | instructorId : {course.InstructorId} | courseName : {course.CourseName} | courseDescription : {course.CourseDescription}");
            
            
            ////Güncelleme Testi
            //Console.WriteLine("================================================Güncelleme Testi================================================");
            //courseManager.Update(new Course { CourseId = 3, CategoryId = 2, InstructorId = 1, CourseName = "photoshop kursu", CourseDescription = "photoshop ileri seviye de öğreniyoruz" });
            //CourseListele(courseManager);
            ////course ları CategoryId ye göre listeleme
            //Console.WriteLine("================================================course ları CategoryId göre listeleme================================================");
            //CourseForEach(courseManager.GetAllByCategory(2));
            ////course ları InstructorId ye göre listeleme
            //Console.WriteLine("================================================course ları InstructorId göre listeleme================================================");
            //CourseForEach(courseManager.GetAllByInstructor(2));



            Console.ReadLine();

        }


        static public void KategoriListele(CategoryManager categoryManager)
        {
            foreach (Category category in categoryManager.GetAll())
            {
                Console.WriteLine($"id : {category.Id} | kategori : {category.Name}");
            }
        }
        static public void InstructorListele(InstructorManager instructorManager) {
            foreach (Instructor instructor in instructorManager.getAll())
            {
                Console.WriteLine($"instructorId : {instructor.InstructorId} | instructorFirstName : {instructor.InstructorFirstName}| instructorLastName : {instructor.InstructorLastName}");

            }
        }

        static public void CourseForEach(List<Course> courseList)
        {
            foreach (Course course in courseList)
            {
                Console.WriteLine($" courseId : {course.CourseId} | categoryId : {course.CategoryId} | instructorId : {course.InstructorId} | courseName : {course.CourseName} | courseDescription : {course.CourseDescription}");
            }
        }

        static public void CourseListele(CourseManager courseManager)
        {
            CourseForEach(courseManager.GetAll());
        }
        



    }
}
