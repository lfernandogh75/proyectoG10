using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {


private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
private static IRepositorioMedico _repoMedico=new RepositorioMedico(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
           // GetAllPaciente();
          // GetPaciente(2);
           //DeletePaciente(1);
          // GetAllPaciente();
          //AddMedico();
          AsignarMedico();
            
            
        }
        private static void AddPaciente()
        {
                var paciente=new Paciente{

                        Nombre ="carlos",
                        Apellidos ="gallego",
                        NumeroTelefono="677777",
                        Genero=Genero.Masculino,
                        Direccion="calle 3 ",
                        Longitud=5.07062F,
                        Latitud=-75.54567F,
                        Ciudad="Manizales",
                        FechaNacimiento=new DateTime(1990,04,12)

                };

                _repoPaciente.AddPaciente(paciente);

        }
        private static void GetAllPaciente()
        {
            var pacientes=_repoPaciente.GetAllPaciente();
            foreach(var paciente in pacientes)
            {
                Console.WriteLine("paciente :"+paciente.Nombre+" "+paciente.Apellidos);
            }




        }
        private static void GetPaciente(int idPaciente)
        {
            var paciente=_repoPaciente.GetPaciente(idPaciente);
           
                Console.WriteLine("paciente :"+paciente.Nombre+" "+paciente.Apellidos);
                paciente.Apellidos="Gallego Henao";
                UpdatePaciente(paciente);

        }
        private static void DeletePaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
           
        }
         private static void UpdatePaciente(Paciente paciente)
        {
            var pacienteE=_repoPaciente.UpdatePaciente(paciente);
           
                Console.WriteLine("paciente :"+pacienteE.Nombre+" "+pacienteE.Apellidos);
            

        }

         private static void AddMedico()
        {
                var medico=new Medico{

                        Nombre ="Maria",
                        Apellidos ="gallego",
                        NumeroTelefono="677777",
                        Genero=Genero.Femenino,
                         Especialidad="Pediatra",
                         Codigo="45566",
                         RegistroRethus="77777"

                };

                _repoMedico.AddMedico(medico);

        }


private static void AsignarMedico()
{
 var medico = _repoPaciente.AsignarMedico(2,3);
 Console.WriteLine(medico.Nombre+" "+medico.Apellidos);
}

    }
}
