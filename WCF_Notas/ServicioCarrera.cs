using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCarrera" en el código y en el archivo de configuración a la vez.
    public class ServicioCarrera : IServicioCarrera
    {
        public List<Carrera> GetAllCarrera()
        {
            ISILNotasEntities MiCarrera = new ISILNotasEntities();
            List<Carrera> objListaCarrera = new List<Carrera>();
            try
            {
                var query = (from objCarrera in MiCarrera.CARRERA
                             orderby objCarrera.id_carrera
                             select objCarrera);
                foreach(var resultado in query)
                {
                    Carrera objCarrera = new Carrera();
                    objCarrera.IdCarrera = resultado.id_carrera;
                    objCarrera.Nombre = resultado.nombre;

                    objListaCarrera.Add(objCarrera);
                }
                return objListaCarrera;
               /* var query = ListCarrera.usp_ConsultarCarrera(nombre);
                foreach(var resultado in query)
                {
                    Carrera objCarrera = new Carrera();
                    objCarrera.IdCarrera = resultado.id_carrera;
                    objCarrera.Nombre = resultado.nombre;
                }
                return objListaCarrera;*/
            }
            catch(EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
