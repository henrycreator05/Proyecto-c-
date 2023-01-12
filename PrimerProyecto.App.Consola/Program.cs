using System;
using PrimerProyecto.App.Dominio;
using PrimerProyecto.App.Persistencia;

namespace PrimerProyecto.App.Consola
{
    class Program
    {
        //private static IRepositorioAdministrador _repo=new RepositorioAdministrador(new PrimerProyecto.App.Persistencia.AppContext());
        private static IRepositorioTecnico _repo=new RepositorioTecnico(new PrimerProyecto.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("inicio prueba");
            Console.WriteLine("inicia inserción");
            Insertar();
            Console.WriteLine("fin de inserción");
            Console.WriteLine("inicio consulta");
           // Consultar();
            Console.WriteLine("fin de consulta");
            /*Console.WriteLine("inicio borrar");
            Borrar();
            Console.WriteLine("fin borrar");*/
            Console.WriteLine("fin de Pruebas");
        }

        private static void Insertar()
        {
            //var a=new Administrador
            var a=new Tecnico
            {
                Nombre="andres",
                Apellido="carvajal",
                Telefono=74567,
                TarjetaProfesional="rt22-134"
               // Password="GRTY56",
                //Roll="GERENTE"
            };
           // _repo.AddAdministrador(a);
           _repo.AddTecnico(a);
        }

       /* private static void Consultar()
        {
            var c =_repo.GetAdministradorxId(1);
            Console.WriteLine(""+c.Nombre+","+c.Apellido);
            
        }*/

       /* private static void Borrar()
        {
            _repo.DeleteAdministradorxId(3);
        }*/
    }
}