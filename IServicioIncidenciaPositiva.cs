using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioIncidenciaPositiva" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioIncidenciaPositiva
    {
        [OperationContract]
        List<IncidenciaAlumnnoP> IncidenciasPositivas();
    }
    [DataContract]
    [Serializable]

    public class IncidenciaAlumnnoP
    {
        private int _id_incidencia;
        private string _impacto_desc;
        private int _dni_alu;

        [DataMember]
        public int id_incidencia
        {
            get { return this._id_incidencia; }
            set { this._id_incidencia = value; }
        }

        [DataMember]
        public string impacto_desc
        {
            get { return this._impacto_desc; }
            set { this._impacto_desc = value; }
        }

        [DataMember]
        public int dni_alu
        {
            get { return this._dni_alu; }
            set { this._dni_alu = value; }
        }
    }
}
