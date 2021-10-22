using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab02
{
    //Строитель(Builder) - шаблон проектирования, который
    //инкапсулирует создание объекта и позволяет разделить
    //его на различные этапы.
    public interface IStudentBuilder
    {
        IStudentBuilder setFullName(string fullname);
        IStudentBuilder setAge(byte age);
        IStudentBuilder setSpec(Student.SPEC spec);
        IStudentBuilder setBirthday(DateTime birth);
        IStudentBuilder setCourse(byte course);
        IStudentBuilder setGroup(byte group);
        IStudentBuilder setAverageMark(double avgmark);
        IStudentBuilder setGender(Student.GENDER gend);
        IStudentBuilder setAddress(Address address);
        Student         getResult();
    }
    public class StudentBuilder : IStudentBuilder
    {
        private Student _stud = new Student();

        public Student getResult()
        {
            return _stud;
        }

        public IStudentBuilder setAddress(Address address)
        {
            _stud.Addr = address;
            return this;
        }

        public IStudentBuilder setAverageMark(double avgmark)
        {
            _stud.AverageMark = avgmark;
            return this;
        }

        public IStudentBuilder setBirthday(DateTime birth)
        {
            _stud.Birthday = birth;
            return this;
        }

        public IStudentBuilder setCourse(byte course)
        {
            _stud.Course = course;
            return this;
        }

        public IStudentBuilder setFullName(string fullname)
        {
            _stud.FullName = fullname;
            return this;
        }

        public IStudentBuilder setAge(byte age)
        {
            _stud.Age = age;
            return this;
        }

        public IStudentBuilder setGender(Student.GENDER gend)
        {
            _stud.Gen = gend;
            return this;
        }

        public IStudentBuilder setGroup(byte group)
        {
            _stud.Group = group;
            return this;
        }

        public IStudentBuilder setSpec(Student.SPEC spec)
        {
            _stud.Spec = spec;
            return this;
        }
    }
}
