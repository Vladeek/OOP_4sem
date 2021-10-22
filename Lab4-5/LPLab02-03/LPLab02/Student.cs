using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LPLab02
{
    public class RequiredIndexAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string temp = value.ToString();

            Regex reg = new Regex("[1-9][0-9]{5}");

            Match match = reg.Match(temp);

            if (match.Success && match.Value == temp)
                return true;
            else
            {
                this.ErrorMessage = "Индекс не соответствует шаблону!";
                return false;
            }
        }
    }

    public class Student : IStudentProto
    {
        public enum GENDER
        {
            Male,
            Female
        }
        public enum SPEC
        {
            POIT,
            ISIT,
            DESIGNER,
            MOBILE
        }

        [Required(ErrorMessage = "Требуется имя!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Поле возраста не может быть пустым!")]
        [Range(17, 99, ErrorMessage = "Выход за диапазон допустимых значений!")]
        public byte Age { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public SPEC Spec { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public byte Course { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public byte Group { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public double AverageMark { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public GENDER Gen { get; set; }

        [Required(ErrorMessage = "Требуется значение!")]
        public Address Addr { get; set; }

        public override string ToString()
        {
            return
                FullName + ", " + Age.ToString() + ", " + Spec.ToString() + ", " + Birthday.Date.ToString()
                + ", " + Course.ToString() + " курс, " + Group.ToString() + " группа," + " ср. балл - "
                + AverageMark.ToString() + ", " + Gen.ToString() + ". Адрес: " + Addr.ToString();
        }

        public Student clone()
        {
            Student ret = new Student();

            ret.FullName = this.FullName;
            ret.Age = this.Age;
            ret.Course = this.Course;
            ret.Birthday = this.Birthday;
            ret.AverageMark = this.AverageMark;
            ret.Gen = this.Gen;
            ret.Spec = this.Spec;
            ret.Addr = this.Addr;
            ret.Group = this.Group;

            return ret;
        }
    }

    public class Address
    {
        public Address() { }
        public Address(string city, int index, string street, byte hnumber, byte? fnumber = null)
        {
            City = city;
            Index = index;
            Street = street;
            HouseNumber = hnumber;
            FlatNumber = fnumber;
        }

        public string City { get; set; }
        [RequiredIndex]
        public int Index { get; set; }
        public string Street { get; set; }
        public byte HouseNumber { get; set; }
        public byte? FlatNumber { get; set; }

        public override string ToString()
        {
            string ret = City + ", " + "ул. " + Street + ", д. " + HouseNumber.ToString() + ", ";
            return FlatNumber == null ? ret += "кв. " + FlatNumber.ToString() + ", " + Index.ToString()
                : ret + Index.ToString();
        }
    }

    public class StudentDecorator : IStudentProto
    {
        protected readonly Student _student;

        public StudentDecorator(Student el)
        {
            _student = el;
        }

        public virtual Student clone()
        {
            Student ret = new Student();

            ret.FullName = _student.FullName;
            ret.Age = _student.Age;
            ret.Course = _student.Course;
            ret.Birthday = _student.Birthday;
            ret.AverageMark = _student.AverageMark;
            ret.Gen = _student.Gen;
            ret.Spec = _student.Spec;
            ret.Addr = _student.Addr;
            ret.Group = _student.Group;

            return ret;
        }
    }

    //Декоратор(Decorator) представляет структурный шаблон
    //проектирования, который позволяет динамически подключать
    //к объекту дополнительную функциональность.

    public class StudentModified : StudentDecorator
    {
        public StudentModified(Student el) : base(el) { }

        public override Student clone()
        {
            return _student;
        }
    }
}
