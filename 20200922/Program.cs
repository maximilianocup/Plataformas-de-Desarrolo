using System;
using System.Collections.Generic;

namespace _20200922
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tareas> tareas = new List<Tareas>();

            tareas.Add("1", new DateTime(2020, 09, 22), 5, new Recursos(), false);
            tareas.Add("2", new DateTime(2020, 09, 23), 6, new Recursos(), false);
            tareas.Add("3", new DateTime(2020, 09, 24), 7, new Recursos(), false);
            tareas.Add("4", new DateTime(2020, 09, 25), 8, new Recursos(), false);
            tareas.Add("5", new DateTime(2020, 09, 26), 9, new Recursos(), false);
        }
    }
}
