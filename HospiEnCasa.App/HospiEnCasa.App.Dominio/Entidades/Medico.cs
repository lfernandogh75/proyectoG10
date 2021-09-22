using System;
using System.ComponentModel.DataAnnotations;
namespace HospiEnCasa.App.Dominio
{
///<sumary> Class <c>Medico</c>
/// Modela una Medico en el sistema
///</sumary>
    public class Medico : Persona
    {
        ///Nombre de la Especialidad medica del Médico  
       [Required(ErrorMessage = "Digite la Especialidad medica del Médico")]
        public string Especialidad{get;set;} 
        /// código unico del médico 
        public string Codigo{get;set;}
        /// Registro Unico Nacional del talento Humano
        public string RegistroRethus{get;set;}
         
        

    }
   
}