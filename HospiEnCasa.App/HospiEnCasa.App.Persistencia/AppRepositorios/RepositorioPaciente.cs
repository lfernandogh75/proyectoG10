using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente:IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext appContext)
        {
            _appContext=appContext;
        }


         public   Paciente AddPaciente(Paciente paciente)
         {
           var pacienteAdicionado=_appContext.pacientes.Add(paciente);
           _appContext.SaveChanges();
           return pacienteAdicionado.Entity;
         }  
            
        public IEnumerable<Paciente> GetAllPaciente()
        {
            return _appContext.pacientes;
        }
       
        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado=_appContext.pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if(pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono=paciente.NumeroTelefono;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Direccion=paciente.Direccion;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                pacienteEncontrado.Familiar=paciente.Familiar;
                pacienteEncontrado.Enfermera=paciente.Enfermera;
                pacienteEncontrado.Medico=paciente.Medico;
                pacienteEncontrado.Historia=paciente.Historia;
                _appContext.SaveChanges();

            }
            return pacienteEncontrado;
            
        }

        public void DeletePaciente(int idPaciente)
        {
                var pacienteEncontrado=_appContext.pacientes.FirstOrDefault(p => p.Id == idPaciente);
                 if(pacienteEncontrado==null)
                         return;
                _appContext.pacientes.Remove(pacienteEncontrado);
                _appContext.SaveChanges();
            
        }
       public  Paciente GetPaciente(int idPaciente)
       {
           return _appContext.pacientes.FirstOrDefault(p => p.Id == idPaciente);
       }
       


Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
 { var pacienteEncontrado = _appContext.pacientes.FirstOrDefault(p => p.Id == idPaciente);
 if (pacienteEncontrado != null)
 { var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
 if (medicoEncontrado != null)
 { pacienteEncontrado.Medico = medicoEncontrado;
 _appContext.SaveChanges();
 }
 return medicoEncontrado;
 }
 return null;

 }



    }
}
