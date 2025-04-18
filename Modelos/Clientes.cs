﻿namespace TiendaHDProject.Modelos;

public class Cliente
{
    public int ClienteId { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int SegmentoMercadoId { get; set; }
    public double PorcentajeCoincidencias { get; set; }

    public SegmentoMercado SegmentoMercado { get; set; }
    public List<DetalleClienteGusto> DetallesGusto { get; set; }
    public List<DetalleClienteCoincidenciaSegmentoMercado> CoincidenciasSegmento { get; set; }
    public List<DetalleClienteCoincidenciaPropuestaValor> CoincidenciasPropuestaValor { get; set; }
    public List<DetalleClienteCoincidenciaCanalesDistribucion> CoincidenciasCanales { get; set; }
    public List<DetalleClienteCoincidenciaIngresosPrecio> CoincidenciasIngresos { get; set; }
    public List<DetalleClienteCoincidenciaActividadesValor> CoincidenciasActividades { get; set; }
    public List<DetalleClienteCoincidenciaRelacionClientes> CoincidenciasRelaciones { get; set; }
}
