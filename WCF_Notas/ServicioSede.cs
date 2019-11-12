using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSede" en el código y en el archivo de configuración a la vez.
    public class ServicioSede : IServicioSede
    {
        public List<Sede> GetAllSede()
        {
            ISILNotasEntities MiSede = new ISILNotasEntities();
            List<Sede> objListaSede = new List<Sede>();
            try
            {
                var query = (from objSede in MiSede.SEDE
                             orderby objSede.id_sede select objSede);
                foreach(var resultado in query)
                {
                    Sede objSede = new Sede();
                    objSede.IdSede = resultado.id_sede;
                    objSede.Nombre = resultado.nombre;

                    objListaSede.Add(objSede);
                }
                return objListaSede;
            }
            catch(EntityException exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
