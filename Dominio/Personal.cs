using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_RCTAN1.Dominio
{
    internal class Personal
    {
        private int dni, sexo, estadoCivil, grado, seccion, arma, ciudad;
        private long telefono;
        private string nombre, apellido, direccion, rolCombate, rolAdministrativo;
        private DateTime fechaNacimiento;

        public Personal() 
        { 
            dni = 0;
            telefono = 0;
            
            sexo = 0;
            estadoCivil = 0;
            grado = 0;
            seccion = 0;
            arma = 0;
            ciudad = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            direccion = string.Empty;
            rolCombate = string.Empty;
            rolAdministrativo = string.Empty;
            fechaNacimiento = DateTime.Today;
        
        
        }   
        public Personal(int dni, long telefono, int sexo, int estadoCivil, int grado, int seccion, int arma, int ciudad, string nombre, string apellido, string direccion, string rolCombate, string rolAdministrativo, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.telefono = telefono;
            
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;
            this.grado = grado;
            this.seccion = seccion;
            this.arma = arma;
            this.ciudad = ciudad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.rolCombate = rolCombate;
            this.rolAdministrativo = rolAdministrativo;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Dni { get => dni; set => dni = value; }
        public long Telefono { get => telefono; set => telefono = value; }
       
        public int Sexo { get => sexo; set => sexo = value; }
        public int EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public int Grado { get => grado; set => grado = value; }
        public int Seccion { get => seccion; set => seccion = value; }
        public int Arma { get => arma; set => arma = value; }
        public int Ciudad { get => ciudad; set => ciudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string RolCombate { get => rolCombate; set => rolCombate = value; }
        public string RolAdministrativo { get => rolAdministrativo; set => rolAdministrativo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
