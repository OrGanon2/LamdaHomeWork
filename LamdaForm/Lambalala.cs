using System.Collections.Generic;

namespace LamdaForm
{
    

    public class Student
    {
        public Student(string id, string name, string lastName, int grade, int age, int cost, int paid)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Grade = grade;
            Age = age;
            Cost = cost;
            Paid = paid;
        }
        public override string ToString()
        {
            return Name + " " + LastName;
        }



        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public int Cost { get; set; }
        public int Paid { get; set; }

    }

    public class StudentManage
    {
        public static List<Student> StudentList { get; set; } = new List<Student>();

        public static void AddStudent(string id, string name, string lastName, int grade, int age, int cost, int paid)
        {
            StudentList.Add(new Student(id, name, lastName, grade, age, cost, paid));
        }
        public static bool RemoveStudent(string name, string lastname)
        {
            foreach (var student in StudentList)
            {
                if (student.Name == name && student.LastName == lastname)
                {
                    StudentList.Remove(student);
                    return true;
                }
            }
            return false;


        }
        public static List<Student> filter(DeleStudent filter)
        {
            List<Student> studentList = new List<Student>();
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (filter(studentList[i]))
                {
                    studentList.Add(StudentList[i]);
                }
            }
            return studentList;
        }
        public static bool contain(DeleStudent con)
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (con(StudentList[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static int Sum(DeleSum sum41)
        {
            int sum = 0;
            foreach (var Delsum in StudentList)
            {
                sum += sum41(Delsum);

            }
            return sum;
        }
        public static double avrage(DelAvrage avr)
        {
            int Count = 0;
            double sum = 0;
            foreach (var DeleAvarage in StudentList)
            {
                sum += avr(DeleAvarage);
                Count++;
            }
            return sum / Count;
        }
    }

}