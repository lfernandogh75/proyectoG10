using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;


namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico:IRepositorioMedico
    {
        private readonly AppContext _appContext;
        public RepositorioMedico(AppContext appContext)
        {
            _appContext=appContext;
        }


         public   Medico AddMedico(Medico medico)
         {
           var medicoAdicionado=_appContext.Medicos.Add(medico);
           _appContext.SaveChanges();
           return medicoAdicionado.Entity;
         }  
            
        public IEnumerable<Medico> GetAllMedico()
        {
            return _appContext.Medicos;
        }
       
        public Medico UpdateMedico(Medico medico)
        {
            var medicoEncontrado=_appContext.Medicos.FirstOrDefault(m => m.Id == medico.Id);
            if(medicoEncontrado!=null)
            {
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellidos=medico.Apellidos;
                medicoEncontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoEncontrado.Genero=medico.Genero;
                medicoEncontrado.Especialidad=medico.Especialidad;
                medicoEncontrado.Codigo=medico.Codigo;
                medicoEncontrado.RegistroRethus=medico.RegistroRethus;
                _appContext.SaveChanges();

            }
            return medicoEncontrado;
            
        }

        public void DeleteMedico(int idMedico)
        {
                var medicoEncontrado=_appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                 if(medicoEncontrado==null)
                         return;
                _appContext.Medicos.Remove(medicoEncontrado);
                _appContext.SaveChanges();
            
        }
       public  Medico GetMedico(int idMedico)
       {
           return _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
       }
       


    }
}
