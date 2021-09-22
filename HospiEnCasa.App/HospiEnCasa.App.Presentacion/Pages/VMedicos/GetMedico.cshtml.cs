using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Presentacion.Pages
{
    public class GetMedicoModel : PageModel
    {

         public List<Medico> ListaMedicos{get;set;}
        public IEnumerable<Medico> Medicos{get;set;}
        public Medico Medico{get;set;}

        public GetMedicoModel(){
         Medico M1 =new Medico{
            Id=1,
            Nombre="Martin",
            Apellidos="Gallego",
            NumeroTelefono="4544555",
            Genero=Genero.Masculino,
            Especialidad="Pediatra",
            Codigo="4355",
            RegistroRethus="44444"
        };
        Medico M2 =new Medico{
            Id=2,
            Nombre="Maria",
            Apellidos="Henao",
            NumeroTelefono="33999355",
            Genero=Genero.Femenino,
            Especialidad="Pediatra",
            Codigo="4355",
            RegistroRethus="44444"
        };

        
        Medicos = new  List<Medico>{M1,M2};
        Medico Medico=new Medico();


        }




        public void OnGet(int? id)
        {
            foreach(var medico in Medicos)
            {
                if(medico.Id==id)
                {
                    Medico=medico;
                }
            }
        }
    }
}
