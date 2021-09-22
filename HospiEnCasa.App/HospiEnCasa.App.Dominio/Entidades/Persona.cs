using System;
namespace HospiEnCasa.App.Dominio
{
///<sumary> Class <c>Persona</c>
/// Modela una Persona en el sistema
///</sumary>
    public class Persona
    {
        ///Identificador único de cada Persona
        public int Id{get;set;}  
        public string Nombre{get;set;}  
        public string Apellidos{get;set;}
        public string NumeroTelefono{get;set;}
        ///Genero de la persona
        public Genero Genero{get;set;}
        

    }
   
}