using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioIncidenciaNegativa" en el código y en el archivo de configuración a la vez.
    public class ServicioIncidenciaNegativa : IServicioIncidenciaNegativa
    {
        public List<IncidenciaAlumnnoN> IncidenciasNegativas()
        {
            ISILNotasEntities ListNegativa = new ISILNotasEntities();
            List<IncidenciaAlumnnoN> objListaNegativa = new List<IncidenciaAlumnnoN>();
            try
            {
                var query = ListNegativa.usp_IncidenciasNegativas;
                foreach (var resultado in query)
                {
                    IncidenciaAlumnnoN objIncidenciaNegativa = new IncidenciaAlumnnoN();
                    objIncidenciaNegativa.id_incidencia = resultado.id_incidencia;
                    objIncidenciaNegativa.impacto_desc = resultado.impacto_desc;
                    objIncidenciaNegativa.dni_alu = resultado.dni_alu;

                    objListaNegativa.Add(objIncidenciaNegativa);
                }
                return objListaNegativa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
