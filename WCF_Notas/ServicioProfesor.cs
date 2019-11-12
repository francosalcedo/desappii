using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProfesor" en el código y en el archivo de configuración a la vez.
    public class ServicioProfesor : IServicioProfesor
    {
        public List<Profesor> ConsultarProfesor(int dni_pro)
        {
            ISILNotasEntities ListProfesor = new ISILNotasEntities();
            List<Profesor> objListaProfesor = new List<Profesor>();
            try
            {
                var query = ListProfesor.usp_ConsultarProfesor(dni_pro);
                foreach(var resultado in query)
                {
                    Profesor objProfesor = new Profesor();
                    objProfesor.DniPro = resultado.dni_pro;
                    objProfesor.AppPro = resultado.app_pro;
                    objProfesor.ApmPro = resultado.apm_pro;
                    objProfesor.NomPro = resultado.nom_pro;
                    objProfesor.Direccion = resultado.direccion;
                    objProfesor.Email = resultado.email;
                    //objProfesor.IdDistrito = resultado.id_distrito;
                    objListaProfesor.Add(objProfesor);
                }
                return objListaProfesor;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
