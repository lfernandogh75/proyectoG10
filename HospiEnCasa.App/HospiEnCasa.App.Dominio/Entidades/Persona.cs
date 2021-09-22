using System;
using System.ComponentModel.DataAnnotations;
namespace HospiEnCasa.App.Dominio
{
///<sumary> Class <c>Persona</c>
/// Modela una Persona en el sistema
///</sumary>
    public class Persona
    {
        ///Identificador único de cada Persona
        public int Id{get;set;}  
        [Required(ErrorMessage = "Digite el nombre  del Médico(a)")]
        public string Nombre{get;set;}  
        public string Apellidos{get;set;}
        public string NumeroTelefono{get;set;}
        ///Genero de la persona
        public Genero Genero{get;set;}
        

    }
   
}