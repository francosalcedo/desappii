using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core.Objects;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {
        public List<Alumno> ConsultarAlumno(int dni_alu)
        {
            ISILNotasEntities ListAlumno = new ISILNotasEntities();
            List<Alumno> objListaAlumno = new List<Alumno>();
            try
            {
                var query = ListAlumno.usp_ConsultarAlumno
                    (dni_alu);
                foreach(var resultado in query)
                {
                    Alumno objAlumno = new Alumno();
                    objAlumno.dniAlu = resultado.dni_alu;
                    objAlumno.appAlu = resultado.app_alu;
                    objAlumno.apmAlu = resultado.apm_alu;
                    objAlumno.nomAlu = resultado.nom_alu;
                    objAlumno.direccion = resultado.direccion;
                    objAlumno.telefono = resultado.telefono;
                    objAlumno.email = resultado.email;
                    objAlumno.nacionalidad = resultado.nacionalidad;
                    objListaAlumno.Add(objAlumno);
                }
                return objListaAlumno;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Alumno> ConsultarAlumnosMayorDeEdad()
        {
            ISILNotasEntities sql = new ISILNotasEntities();
            List<Alumno> objListaAlumno = new List<Alumno>();
            try
            {

                var query = (from objAlumnoSQL in sql.ALUMNO
                             where objAlumnoSQL.edad >= 18
                             select objAlumnoSQL);

                foreach (var resultado in query)
                {
                    Alumno objAlumno = new Alumno();

                    objAlumno.dniAlu = resultado.dni_alu;
                    objAlumno.apmAlu = resultado.apm_alu;
                    objAlumno.appAlu = resultado.app_alu;
                    objAlumno.nomAlu = resultado.nom_alu;
                    objAlumno.direccion = resultado.direccion;
                    objAlumno.telefono = resultado.telefono;
                    objAlumno.email = resultado.email;
                    objAlumno.edad = Convert.ToInt32(resultado.edad);
                    objAlumno.nacionalidad = resultado.nacionalidad;
                    objAlumno.idCarrera = Convert.ToInt32(resultado.id_carrera);
                    objAlumno.idDistrito = Convert.ToInt32(resultado.id_distrito);
                    
                    objListaAlumno.Add(objAlumno);
                }
                return objListaAlumno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Alumno> ConsultarAlumnosMenorDeEdad()
        {
            ISILNotasEntities sql = new ISILNotasEntities();
            List<Alumno> objListaAlumno = new List<Alumno>();
            try
            {

                var query = (from objAlumnoSQL in sql.ALUMNO
                             where objAlumnoSQL.edad < 18
                             select objAlumnoSQL);

                foreach (var resultado in query)
                {
                    Alumno objAlumno = new Alumno();

                    objAlumno.dniAlu = resultado.dni_alu;
                    objAlumno.apmAlu = resultado.apm_alu;
                    objAlumno.appAlu = resultado.app_alu;
                    objAlumno.nomAlu = resultado.nom_alu;
                    objAlumno.direccion = resultado.direccion;
                    objAlumno.telefono = resultado.telefono;
                    objAlumno.email = resultado.email;
                    objAlumno.edad = Convert.ToInt32(resultado.edad);
                    objAlumno.nacionalidad = resultado.nacionalidad;
                    objAlumno.idCarrera = Convert.ToInt32(resultado.id_carrera);
                    objAlumno.idDistrito = Convert.ToInt32(resultado.id_distrito);

                    objListaAlumno.Add(objAlumno);
                }
                return objListaAlumno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
