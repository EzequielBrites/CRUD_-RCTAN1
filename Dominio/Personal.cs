using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_RCTAN1.Dominio
{
    internal class Personal
    {
        private int sexo, grado, seccion, arma,subunidad;
        private int dni;

        private string nombre, apellido, rolCombate, rolAdministrativo;
        private DateTime fechaNacimiento;

        public Personal() 
        { 
            dni = 0;
            sexo = 0; 
            grado = 0;
            seccion = 0;
            arma = 0;
            subunidad = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            rolCombate = string.Empty;
            rolAdministrativo = string.Empty;
            fechaNacimiento = DateTime.Today;
        
        
        }   
        public Personal(int dni,int sexo, int grado, int seccion, int arma,int subunidad, string nombre, string apellido, string rolCombate, string rolAdministrativo, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.sexo = sexo;
            this.grado = grado;
            this.seccion = seccion;
            this.arma = arma;
            this.subunidad = subunidad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.rolCombate = rolCombate;
            this.rolAdministrativo = rolAdministrativo;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Dni { get => dni; set => dni = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public int Grado { get => grado; set => grado = value; }
        public int Seccion { get => seccion; set => seccion = value; }
        public int Arma { get => arma; set => arma = value; }

        public int SubUnidad { get => subunidad ; set => subunidad = value; }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        
        public string RolCombate { get => rolCombate; set => rolCombate = value; }
        public string RolAdministrativo { get => rolAdministrativo; set => rolAdministrativo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
