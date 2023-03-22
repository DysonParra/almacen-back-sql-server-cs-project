/*
 * @fileoverview    {EstadosRemisiones}
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
 * TODO: Definición de {@code EstadosRemisiones}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class EstadosRemisiones {

        [Key]
        public Int64? IntIdEstadoRemision { get; set; }
        public String? StrDescripcionEstadoRemision { get; set; }
        public String? StrUsuario { get; set; }
        public DateTime? DtFecha { get; set; }

    }

}