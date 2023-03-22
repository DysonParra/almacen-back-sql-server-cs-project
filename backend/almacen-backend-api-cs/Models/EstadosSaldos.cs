/*
 * @fileoverview    {EstadosSaldos}
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
 * TODO: Definición de {@code EstadosSaldos}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class EstadosSaldos {

        [Key]
        public Int64? IntIdEstadoSaldo { get; set; }
        public String? StrDescripcionEstadoSaldo { get; set; }
        public String? StrCodigoColor { get; set; }
        public Boolean? BitEstaEnReposicion { get; set; }
        public String? StrUsuario { get; set; }
        public DateTime? DtFecha { get; set; }

    }

}