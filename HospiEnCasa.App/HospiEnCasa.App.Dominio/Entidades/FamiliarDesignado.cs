using System;
namespace HospiEnCasa.App.Dominio
{
///<sumary> Class <c>FamiliarDesignado</c>
/// Modela una familiar designado en el sistema
///</sumary>
    public class FamiliarDesignado : Persona
    {
        /// parentesco con el enfermo 
        public string Parentesco{get;set;} 
        /// Dirección de correo electrónico
        public string Correo{get;set;}
    }
   
}