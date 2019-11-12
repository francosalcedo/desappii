using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCurso" en el código y en el archivo de configuración a la vez.
    public class ServicioCurso : IServicioCurso
    {
        public List<Curso> GetAllCurso()
        {
            ISILNotasEntities MiCurso = new ISILNotasEntities();
            List<Curso> objListaCurso = new List<Curso>();
            try
            {
                var query = (from objCurso in MiCurso.CURSO
                             orderby objCurso.id_curso select objCurso);
                foreach(var resultado in query)
                {
                    Curso objCurso = new Curso();
                    objCurso.IdCurso = resultado.id_curso;
                    objCurso.Nombre = resultado.nombre;
                    //objCurso.Credito = Convert.ToInt64(resultado.credito);

                    objListaCurso.Add(objCurso);
                }
                return objListaCurso;
            }
            catch(EntityException exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
