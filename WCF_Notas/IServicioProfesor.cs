using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProfesor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProfesor
    {
        [OperationContract]
        List<Profesor> ConsultarProfesor(int dni_pro);
    }

    [DataContract]
    [Serializable]

    public class Profesor
    {
        private int _dniPro;
        private string _appPro;
        private string _apmPro;
        private string _nomPro;
        private string _direccion;
        private string _email;
        private int _idDistrito;

        [DataMember]
        public int DniPro { get => _dniPro; set => _dniPro = value; }
        [DataMember]
        public string AppPro { get => _appPro; set => _appPro = value; }
        [DataMember]
        public string ApmPro { get => _apmPro; set => _apmPro = value; }
        [DataMember]
        public string NomPro { get => _nomPro; set => _nomPro = value; }
        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember]
        public string Email { get => _email; set => _email = value; }
        [DataMember]
        public int IdDistrito { get => _idDistrito; set => _idDistrito = value; }

 

    }
}
