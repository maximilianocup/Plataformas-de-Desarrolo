using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _20200922
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tareas> tareas = new List<Tareas>();

            tareas.Add(new Tareas("1", new DateTime(2020, 09, 22), 5, new Recursos(), false));
            tareas.Add(new Tareas("2", new DateTime(2020, 09, 23), 6, new Recursos(), false));
            tareas.Add(new Tareas("3", new DateTime(2020, 09, 24), 7, new Recursos(), false));
            tareas.Add(new Tareas("4", new DateTime(2020, 09, 25), 8, new Recursos(), false));
            tareas.Add(new Tareas("5", new DateTime(2020, 09, 26), 9, new Recursos(), false));

            foreach (Tareas i in tareas)
            {
                Console.WriteLine("{0}\t", i.ToString());
            }

                //NuevoUsuario("Maria", "12345");

                //ActualizarUsuario(1, "Julio");

                //BorrarUsuario(1);

                //ConsultaUsuarios();


                //InfoUsuario("Maria");

                //NuevoRecurso("r1", 3);

                //NuevaTarea("Tarea 1", DateTime.Now, 10, 1, false);

                //ActualizarTarea(1, "Cambiolaterea");

                //InfoTarea("Cambiolaterea");

                //NuevoRecurso("r1", 3);

                //ActualizarRecurso(1, "recurso cambio");

                //InfoRecurso("recurso cambio");

                //BorrarRecurso(1);



            }
            //**********Usuario************
            static void NuevoUsuario(string nombre, string Clave)
        {

            var ctx = new BaseDbContext();

            ctx.Set<Usuarios>().Add(new Usuarios
            {
                Usuario = nombre,
                Clave = Clave,

            });

            ctx.SaveChanges();
        }

        static void ActualizarUsuario(int id, string nuevoNombre)
        {
            var ctx = new BaseDbContext();

            var usuario = ctx.Set<Usuarios>().Where(i => i.id == id).FirstOrDefault();

            if(usuario != null)
            {
                usuario.Usuario = nuevoNombre;
            }
            else
            {
                Console.WriteLine("El usuario no existe.");
            }
            ctx.SaveChanges();
        }

        static void BorrarUsuario(int id)
        {
            var ctx = new BaseDbContext();

            var usuario = ctx.Set<Usuarios>().Where(i => i.id == id).Single();
            ctx.Set<Usuarios>().Remove(usuario);
            ctx.SaveChanges();
        }

        static void ConsultaUsuarios()
        {
            var ctx = new BaseDbContext();

            var lista = ctx.Set<Usuarios>().ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre del usuario: {item.Usuario}");
            }
        }

        static void InfoUsuario(string Buqueda)
        {
            var ctx = new BaseDbContext();

            var usuario = ctx.Set<Usuarios>().Where(i => i.Usuario == Buqueda).FirstOrDefault();

            if(usuario != null)
            {
                Console.WriteLine($"Nombre del usuario: {usuario.Usuario}");
            }
            else
            {
                Console.WriteLine("El usuario no existe");
            }
        }

                                                //*******Tarea**********

        static void NuevaTarea(string Titulo, DateTime Vencimiento, int Estimacion, int ResponsableId, bool Estado)
        {
            var ctx = new BaseDbContext();

            ctx.Set<Tareas>().Add(new Tareas
            {
            Titulo = Titulo,
            Vencimiento = Vencimiento,
            Estimacion = Estimacion,
            ResponsableId = ResponsableId,
            Estado = Estado,

        });

            ctx.SaveChanges();
            
        }

        static void ActualizarTarea(int id, string cambioTitulo)
        {
            var ctx = new BaseDbContext();
            var tarea = ctx.Set<Tareas>().Where(i => i.id == id).FirstOrDefault();

            if (tarea != null)
            {
                tarea.Titulo = cambioTitulo;
            }
            else
            {
                Console.WriteLine("La tarea no existe.");
            }
            ctx.SaveChanges();
        }

        static void BorrarTarea(int id)
        {
            var ctx = new BaseDbContext();

            var tarea = ctx.Set<Tareas>().Where(i => i.id == id).Single();
            ctx.Set<Tareas>().Remove(tarea);
            ctx.SaveChanges();
        }

        static void InfoTarea(string Buqueda)
        {
            var ctx = new BaseDbContext();

            var tarea = ctx.Set<Tareas>().Where(i => i.Titulo == Buqueda).FirstOrDefault();

            if (tarea != null)
            {
                Console.WriteLine($"Nombre de la tarea: {tarea.Titulo}" +
                    $"\nVencimiento: ({tarea.Vencimiento})" +
                    $"\nEstimacion: ({tarea.Estimacion})" +
                    $"\nResponsableId: ({tarea.ResponsableId})" +
                    $"\nEstado: ({tarea.Estado})");
            }
            else
            {
                Console.WriteLine("La tarea no existe");
            }
        }

        //                                            *********Recurso************

        static void NuevoRecurso(string Nombre, int UsuarioId)
        {

            var ctx = new BaseDbContext();

            ctx.Set<Recursos>().Add(new Recursos
            {
                Nombre = Nombre,
                UsuarioId = UsuarioId,

            });

            ctx.SaveChanges();
        }


        static void ActualizarRecurso(int id, string cambioRecurso)
        {
            var ctx = new BaseDbContext();
            var recurso = ctx.Set<Recursos>().Where(i => i.id == id).FirstOrDefault();

            if (recurso != null)
            {
                recurso.Nombre = cambioRecurso;
            }
            else
            {
                Console.WriteLine("El recurso no existe.");
            }
            ctx.SaveChanges();
        }


        static void BorrarRecurso(int id)
        {
            var ctx = new BaseDbContext();

            var recurso = ctx.Set<Recursos>().Where(i => i.id == id).Single();
            ctx.Set<Recursos>().Remove(recurso);
            ctx.SaveChanges();
        }


        static void InfoRecurso(string Buqueda)
        {
            var ctx = new BaseDbContext();

            var recurso = ctx.Set<Recursos>().Where(i => i.Nombre == Buqueda).FirstOrDefault();

            if (recurso != null)
            {
                Console.WriteLine($"Nombre de recurso: {recurso.Nombre}");
                    
            }
            else
            {
                Console.WriteLine("El recurso no existe");
            }
        }

















    }


    
}
