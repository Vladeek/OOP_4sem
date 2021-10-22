using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab02
{
    //(Abstract Factory) предоставляет интерфейс для создания семейств
    // взаимосвязанных объектов с определенными интерфейсами без указания
    // конкретных типов данных объектов.
    public interface IStudent
    {
        Student.SPEC certainSpec { get; }
        string ToString();
    }

    public class PoitStudent : Student, IStudent
    {
        public SPEC certainSpec => SPEC.POIT;
    }
    public class DesignStudent : Student, IStudent
    {
        public SPEC certainSpec => SPEC.DESIGNER;
    }
    public class MobileStudent : Student, IStudent
    {
        public SPEC certainSpec => SPEC.MOBILE;
    }
    public class IsitStudent : Student, IStudent
    {
        public SPEC certainSpec => SPEC.ISIT;
    }

    public interface IStudentFactory
    {
        IStudent CreateStudent();
    }

    public class PoitFactory : IStudentFactory
    {
        public IStudent CreateStudent()
        {
            return new PoitStudent();
        }
    }

    public class DesignFactory : IStudentFactory
    {
        public IStudent CreateStudent()
        {
            return new DesignStudent();
        }
    }

    public class MobileFactory : IStudentFactory
    {
        public IStudent CreateStudent()
        {
            return new MobileStudent();
        }
    }

    public class IsitFactory : IStudentFactory
    {
        public IStudent CreateStudent()
        {
            return new IsitStudent();
        }
    }
}
