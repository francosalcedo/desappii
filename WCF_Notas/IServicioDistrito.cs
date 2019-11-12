using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDistrito" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDistrito
    {
        [OperationContract]
        List<Distrito> GetAllDistrito();
        [OperationContract]
        List<Alumno> ConsultarAlumnosPorDistrito(int id_distrito);
        [OperationContract]
        List<Alumno> ConsultarAlumnosPorDistritoYCarrera(int id_distrito, int id_carrera);
    }
    [DataContract]
    [Serializable]

    public class Distrito
    {
        private int _idDistrito;
        private string _nombre;

        [DataMember]
        public int IdDistrito { get => _idDistrito; set => _idDistrito = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
