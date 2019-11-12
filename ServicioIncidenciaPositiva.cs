using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioIncidenciaPositiva" en el código y en el archivo de configuración a la vez.
    public class ServicioIncidenciaPositiva : IServicioIncidenciaPositiva
    {
        public List<IncidenciaAlumnnoP> IncidenciasPositivas()
        {
            ISILNotasEntities ListPositiva = new ISILNotasEntities();
            List<IncidenciaAlumnnoP> objListaPositiva = new List<IncidenciaAlumnnoP>();
            try
            {
                var query = ListPositiva.usp_IncidenciasPositivas;
                foreach (var resultado in query)
                {
                    IncidenciaAlumnnoP objIncidenciaPositiva = new IncidenciaAlumnnoP();
                    objIncidenciaPositiva.id_incidencia = resultado.id_incidencia;
                    objIncidenciaPositiva.impacto_desc = resultado.impacto_desc;
                    objIncidenciaPositiva.dni_alu = resultado.dni_alu;

                    objListaPositiva.Add(objIncidenciaPositiva);
                }
                return objListaPositiva;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
