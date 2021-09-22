using System;
namespace HospiEnCasa.App.Dominio
{
///<sumary> Class <c>Enfermera</c>
/// Modela una Enfermera en el sistema
///</sumary>
    public class Enfermera : Persona
    {
        ///Numero único de la terjeta profesional  
        public string TarjetaProfesional{get;set;} 
        /// Cantidad de horas laborales a la semana
        public int HorasLaborales{get;set;}
        
         
        

    }
   
}