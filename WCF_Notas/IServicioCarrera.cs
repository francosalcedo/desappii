using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCarrera" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCarrera
    {
        [OperationContract]
        List<Carrera> GetAllCarrera();
    }
    [DataContract]
    [Serializable]

    public class Carrera
    {
        private int _idCarrera;
        private string _nombre;
        [DataMember]
        public int IdCarrera { get => _idCarrera; set => _idCarrera = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
