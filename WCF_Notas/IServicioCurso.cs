using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCurso" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCurso
    {
        [OperationContract]
        List<Curso> GetAllCurso();
    }
    [DataContract]
    [Serializable]

    public class Curso
    {
        private int _idCurso;
        private string _nombre;
        private string _credito;
        private int _idSede;
        [DataMember]
        public int IdCurso { get => _idCurso; set => _idCurso = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember]
        public string Credito { get => _credito; set => _credito = value; }
        [DataMember]
        public int IdSede { get => _idSede; set => _idSede = value; }
    }
}
