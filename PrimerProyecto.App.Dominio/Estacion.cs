using System;

namespace PrimerProyecto.App.Dominio
{
    public class Estacion
    {
        public int Id{get;set;}
        public string Codigo{get;set;}
        public float Latitud{get;set;}
        public float Longitud{get;set;}
        public string Municipio{get;set;}
        public string Departamento{get;set;}
        public string FechaMontaje{get;set;}
        //relaciones de composicion
        public Tecnico TecnicoMantenimiento{get;set;}
        public Supervisor Supervisor{get;set;}
        public Reporte Reporte{get;set;}
        public DatoMeteorologico DatoMeteorologico{get;set;}
    }
}