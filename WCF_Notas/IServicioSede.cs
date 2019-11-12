using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSede" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSede
    {
        [OperationContract]
        List<Sede> GetAllSede();
    }
    [DataContract]
    [Serializable]

    public class Sede
    {
        private int _idSede;
        private string _nombre;

        [DataMember]
        public int IdSede { get => _idSede; set => _idSede = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
