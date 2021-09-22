using System;
namespace HospiEnCasa.App.Dominio
{
///<sumary> Class <c>SignoVital</c>
/// Modela una Persona en el sistema
///</sumary>
    public class SignoVital
    {
        ///Identificador único de cada Signo Vital
        public int Id{get;set;}  
        /// Fecha y hora en que se realizó la toma
        public DateTime FechaHora{get;set;} 
        /// valor numerico signo vital 
        public float Valor{get;set;}
        ///Tipo de signo vital 
        public TipoSigno Signo{get;set;}
        

    }
   
}