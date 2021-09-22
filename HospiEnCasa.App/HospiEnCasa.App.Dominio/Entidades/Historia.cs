using System;
 
namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Historia</c>
    /// Modela el historial de un  Paciente  en hospital en casa
    /// </summary>   
    public class Historia
    {
        public int Id { get; set; }
        ///Descripción detallada del diagnostico del paciente
        public string Diagnostico { get; set; }
        /// Descripción de la casa y habitación del paciente
        public string Entorno { get; set; }
        public System.Collections.Generic.List<SugerenciaCuidado> Sugerencias { get; set; }
    }
}