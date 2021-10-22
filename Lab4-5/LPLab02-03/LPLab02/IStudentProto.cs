using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab02
{
    //Паттерн Прототип(Prototype) позволяет создавать объекты на основе уже
    //ранее созданных объектов-прототипов.То есть по сути данный паттерн
    //предлагает технику клонирования объектов.
    public interface IStudentProto
    {
        Student clone();
    }
}
