using System;
using System.Collections.Generic;
using System.Linq;

namespace Buffteks3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Laith",
                                LastName = "Alfaloujeh",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Mekkala",
                                LastName = "Bourapa",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Charles",
                                LastName = "Coufal",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },    
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Cunningham",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Hayes",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Aaron",
                                LastName = "Hebert",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },  
                            new Student()
                            {
                                FirstName = "Yi Fu",
                                LastName = "Ji",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Todd",
                                LastName = "Kile",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Mara",
                                LastName = "Kinoff",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },  
                            new Student()
                            {
                                FirstName = "Cesareo",
                                LastName = "Lona",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Matthews",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Mason",
                                LastName = "McCollum",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },  
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "McDonald",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Phelps",
                                LastName = "Merrell",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Quan",
                                LastName = "Nguyen",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },  
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "Roder",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Saysouriyosack",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Claudia",
                                LastName = "Silva",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },                  
                            new Student()
                            {
                                FirstName = "Gabriela",
                                LastName = "Valenzuela",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Kayla",
                                LastName = "Washington",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Matthew",
                                LastName = "Webb",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },  new Student()
                            {
                                FirstName = "Cory",
                                LastName = "Williams",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior"
                            },      
                        };

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        var filteredResult = db.Students.Where(s => s.Role != "Senior");//.Select(s => s.FirstName);
                        var Mdecending = db.Students.Where(s => s.FirstName == "M%");
                        /* select * From Student
                            Where FirstName Like 'M%'
                        */
                        foreach(Student s in students)
                        {
                            Console.WriteLine(filteredResult);
                            //prints: Microsoft.EntityFrameworkCore.Query.Internal.EntityQueryable`1[Buffteks3.Student]
                            Console.WriteLine("This is the break line");
                            Console.WriteLine(Mdecending);
                            //Console.WriteLine(s);
                        }
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}

