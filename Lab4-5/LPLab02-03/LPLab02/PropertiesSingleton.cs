using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace LPLab02
{
    //Одиночка(Singleton, Синглтон) - порождающий паттерн, который гарантирует,
    //что для определенного класса будет создан только один объект, а также
    //предоставит к этому объекту точку доступа.
    public sealed class StudentFormPropertiesSingleton
    {
        private static readonly StudentFormPropertiesSingleton _instance 
            = new StudentFormPropertiesSingleton();

        // properties field

        public Color BackColor { get; set; }
        
        public Font FormFont { get; set; }

        public int FormWidth { get; set; }

        public int FormHeight { get; set; }

        // end field 
        
        static StudentFormPropertiesSingleton() { }
        
        private StudentFormPropertiesSingleton() { }
        
        public static StudentFormPropertiesSingleton getInstance()
        {
            return _instance;
        }
    }
}
