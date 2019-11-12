using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDistrito" en el código y en el archivo de configuración a la vez.
    public class ServicioDistrito : IServicioDistrito
    {
        public List<Alumno> ConsultarAlumnosPorDistrito(int id_distrito)
        {

            ISILNotasEntities sql = new ISILNotasEntities();
            List<Alumno> objListaAlumnos = new List<Alumno>();
            try
            {
                var query = sql.usp_ConsultarAlumnosPorDistrito(id_distrito);
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

                    objListaAlumnos.Add(objAlumno);
                }
                return objListaAlumnos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Alumno> ConsultarAlumnosPorDistritoYCarrera(int id_distrito, int id_carrera )
        {

            ISILNotasEntities sql = new ISILNotasEntities();
            List<Alumno> objListaAlumnos = new List<Alumno>();
            try
            {
                var query = sql.usp_ConsultarAlumnosPorDistritoYCarrera(id_distrito, id_carrera);
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

                    objListaAlumnos.Add(objAlumno);
                }
                return objListaAlumnos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Distrito> GetAllDistrito()
        {
            ISILNotasEntities MiDistrito = new ISILNotasEntities();
            List<Distrito> objListaDistrito = new List<Distrito>();
            try
            {
                var query = (from objDistrito in MiDistrito.DISTRITO
                             orderby objDistrito.id_distrito select objDistrito);
                foreach(var resultado in query)
                {
                    Distrito objDistrito = new Distrito();
                    objDistrito.IdDistrito = resultado.id_distrito;
                    objDistrito.Nombre = resultado.nombre;
                    objListaDistrito.Add(objDistrito);
                }
                return objListaDistrito;
            }
            catch(EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
