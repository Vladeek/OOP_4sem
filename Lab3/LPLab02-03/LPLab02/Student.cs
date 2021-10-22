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

    public class Student
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
}
