using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Notas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlumno
    {
        /* [OperationContract]
         List<Alumno> ListarAlumno();*/

        [OperationContract]
        List<Alumno> ConsultarAlumno(int dni_alu);

        [OperationContract]
        List<Alumno> ConsultarAlumnosMayorDeEdad();

        [OperationContract]
        List<Alumno> ConsultarAlumnosMenorDeEdad();

        [OperationContract]
        List<Alumno> ConsultarAlumnosPorCiclo(int id_ciclo);
    }

    [DataContract]
    [Serializable]

    public class Alumno
    {
        private int _dniAlu;
        private string _appAlu;
        private string _apmAlu;
        private string _nomAlu;
        private string _direccion;
        private string _telefono;
        private string _email;
        private int _edad;
        private string _nacionalidad;
        private int _idCarrera;
        private int _idDistrito;
        private int _idMatricula;
        private int _idCiclo;

        [DataMember]
        public int dniAlu
        {
            get { return this._dniAlu; }
            set { this._dniAlu = value; }
        }

        [DataMember]
        public string appAlu
        {
            get { return this._appAlu; }
            set { this._appAlu = value; }
        }

        [DataMember]
        public string apmAlu
        {
            get { return this._apmAlu; }
            set { this._apmAlu = value; }
        }

        [DataMember]
        public string nomAlu
        {
            get { return this._nomAlu; }
            set { this._nomAlu = value; }
        }

        [DataMember]
        public string direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        [DataMember]
        public string telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }

        [DataMember]
        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        [DataMember]
        public int edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        [DataMember]
        public string nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        [DataMember]
        public int idCarrera
        {
            get { return this._idCarrera; }
            set { this._idCarrera = value; }
        }

        [DataMember]
        public int idDistrito
        {
            get { return this._idDistrito; }
            set { this._idDistrito = value; }
        }

        [DataMember]
        public int idMatricula
        {
            get { return this._idMatricula; }
            set { this._idMatricula = value; }
        }

        [DataMember]
        public int idCiclo
        {
            get { return this._idCiclo; }
            set { this._idCiclo = value; }
        }

    }
}
