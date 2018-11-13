﻿using System;
using System.Collections.Generic;

namespace _06_CRUDPersonas_Entities {
    public class clsPersona
    {
        #region atributos Y Propiedades

        public int idPersona { get; set; }

        public String nombre { get; set; }

        public String apellidos { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public String direccion { get; set; }

        public String telefono { get; set; }

        public int idDepartamento { get; set; }


        #endregion


        #region constructores

        public clsPersona()
        {
            this.idPersona = 0;
            this.nombre = "";
            this.apellidos = "";
            this.fechaNacimiento = new DateTime();
            this.direccion = "";
            this.telefono = "";
            this.idDepartamento = 0;
        }

        public clsPersona(int idPersona, String nombre, String apellidos, DateTime fechaNacimiento, String direccion, String telefono, int idDepartamento) {

            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idDepartamento = idDepartamento;

        }

        public clsPersona(String nombre, String apellidos, DateTime fechaNacimiento, String direccion, String telefono, int idDepartamento) {
            
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idDepartamento = idDepartamento;

        }


        #endregion


    }
}