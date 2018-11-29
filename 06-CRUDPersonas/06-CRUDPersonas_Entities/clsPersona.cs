using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace _06_CRUDPersonas_Entities {
    public class clsPersona
    {
        #region atributosYPropiedades

        [HiddenInput(DisplayValue = false)]
        public int idPersona { get; set; }

        [Display(Name="Nombre")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public String nombre { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public String apellidos { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime fechaNacimiento { get; set; }

        public String direccion { get; set; }

        //[DisplayFormat(DataFormatString = "0;(+34|0034|34)?[6|7|9] [0-9]{8}")]
        [RegularExpression(@"(\+34|0034|34)?[6|7|9][0-9]{8}", ErrorMessage = "No eres tú, soy yo")]
        public String telefono { get; set; }

        public int idDepartamento { get; set; }


        #endregion


        #region constructores

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

        public clsPersona() {

            this.idPersona = 0;
            this.nombre = "";
            this.apellidos = "";
            this.fechaNacimiento = new DateTime();
            this.direccion = "";
            this.telefono = "";
            this.idDepartamento = 0;

        }

        #endregion


    }
}