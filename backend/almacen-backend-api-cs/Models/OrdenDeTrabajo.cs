/*
 * @fileoverview    {OrdenDeTrabajo}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementación realizada.
 * @version 2.0     Documentación agregada.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Definición de {@code OrdenDeTrabajo}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class OrdenDeTrabajo {

        [Key]
        public Int64? IntIdOrdenTrabajo { get; set; }
        public Int64? IntIdOperacion { get; set; }
        public Int64? IntIdEstadoOT { get; set; }
        public Int64? IntIdCentroTrabajo { get; set; }
        public String? StrNumeroOrden { get; set; }

    }

}