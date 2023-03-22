/*
 * @fileoverview    {Cotizacion}
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
 * TODO: Definición de {@code Cotizacion}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Cotizacion {

        [Key]
        public Int32? IntIdCotizacion { get; set; }
        public Int32? IntCabecera { get; set; }
        public int? IntIdProveedor { get; set; }
        public String? StrEstado { get; set; }
        public Int64? IntCodigoMaterial { get; set; }
        public String? StrDescripcionMaterial { get; set; }
        public String? StrNombreProveedor { get; set; }
        public String? StrBuzonProveedor { get; set; }
        public double? DblCantidadRequerida { get; set; }
        public double? DblCantidadCotizada { get; set; }
        public Double? DblValorCotizado { get; set; }
        public Double? DblDescuento { get; set; }
        public DateTime? DtFechaNecesaria { get; set; }
        public DateTime? DtFechaEntrega { get; set; }
        public DateTime? DtFechaCreacion { get; set; }
        public Int64? IntIdPlanCompra { get; set; }

    }

}