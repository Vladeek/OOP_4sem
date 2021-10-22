using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    [Serializable]
    class Discipline
    {
        public string name { get; set; }
        public int semestr { get; set; }
        public int course { get; set; }
        public int numlec { get; set; }
        public int numlab { get; set; }
        public string controll { get; set; }
        public string lector { get; set; }
    }

    class Lector
    {
        public string fio { get; set; }
        public string kafedra { get; set; }
        public int auditorium { get; set; }
    }
}
