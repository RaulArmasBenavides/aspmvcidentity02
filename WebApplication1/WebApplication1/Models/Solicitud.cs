using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    public class Solicitud
    {

        #region Campos

        [DataMember(Name = "NroEmpresa")]
        public string NroEmpresa { get; set; }

        [DataMember(Name = "NroSolicitud")]
        public string NroSolicitud { get; set; }

        [DataMember(Name = "NumSolicitud")]
        public string NumSolicitud { get; set; }

        [DataMember(Name = "CodSSCC")]
        public string CodSSCC { get; set; }

        [DataMember(Name = "NumActualiz")]
        public int NumActualiz { get; set; }

        [DataMember(Name = "NumValoSoli")]
        public string NumValoSoli { get; set; }

        [DataMember(Name = "TipSolicitud")]
        public string TipSolicitud { get; set; }

        [DataMember(Name = "StpSolicitud")]
        public string StpSolicitud { get; set; }

        [DataMember(Name = "TipGeneracion")]
        public string TipGeneracion { get; set; }

        [DataMember(Name = "UbiMedidor")]
        public string UbiMedidor { get; set; }

        [DataMember(Name = "CodIngreso")]
        public string CodIngreso { get; set; }

        [DataMember(Name = "FecIngresoLDS")]
        public string FecIngresoLDS { get; set; }

        [DataMember(Name = "NumExpedienteLDS")]
        public string NumExpedienteLDS { get; set; }

        [DataMember(Name = "FecIngresoPro")]
        public string FecIngresoPro { get; set; }

        [DataMember(Name = "NumExpedientePro")]
        public string NumExpedientePro { get; set; }

        [DataMember(Name = "EstadoSolicitud")]
        public string EstadoSolicitud { get; set; }

        [DataMember(Name = "EtapaProceso")]
        public string EtapaProceso { get; set; }

        [DataMember(Name = "EtapaObra")]
        public string EtapaObra { get; set; }

        [DataMember(Name = "EstadoObra")]
        public string EstadoObra { get; set; }

        [DataMember(Name = "Motivo")]
        public string Motivo { get; set; }

        [DataMember(Name = "Atencion")]
        public string Atencion { get; set; }

        [DataMember(Name = "PotenciaContratad")]
        public decimal PotenciaContratad { get; set; }

        [DataMember(Name = "CodTarifa")]
        public string CodTarifa { get; set; }

        [DataMember(Name = "CndRutina")]
        public string CndRutina { get; set; }

        [DataMember(Name = "Observaciones")]
        public string Observaciones { get; set; }

        [DataMember(Name = "NumCarta")]
        public string NumCarta { get; set; }

        [DataMember(Name = "IndPtoEntrega")]
        public string IndPtoEntrega { get; set; }

        [DataMember(Name = "TipPtoEntrega")]
        public string TipPtoEntrega { get; set; }

        [DataMember(Name = "NumPtoEntrega")]
        public string NumPtoEntrega { get; set; }

        [DataMember(Name = "NumLlave")]
        public string NumLlave { get; set; }

        [DataMember(Name = "CodSet")]
        public string CodSet { get; set; }

        [DataMember(Name = "NumAlmd")]
        public string NumAlmd { get; set; }

        [DataMember(Name = "CodTension")]
        public string CodTension { get; set; }

        [DataMember(Name = "TipDocumento")]
        public string TipDocumento { get; set; }

        [DataMember(Name = "NumDocumento")]
        public string NumDocumento { get; set; }

        [DataMember(Name = "NumPedido")]
        public string NumPedido { get; set; }

        [DataMember(Name = "NumResolucion")]
        public string NumResolucion { get; set; }

        [DataMember(Name = "TipResolucion")]
        public string TipResolucion { get; set; }

        [DataMember(Name = "FecResolucion")]
        public string FecResolucion { get; set; }

        [DataMember(Name = "CodTipoId")]
        public string CodTipoId { get; set; }

        [DataMember(Name = "NumeroId")]
        public string NumeroId { get; set; }

        [DataMember(Name = "EntreCalles")]
        public string EntreCalles { get; set; }

        [DataMember(Name = "NumServiciosSol")]
        public int NumServiciosSol { get; set; }

        [DataMember(Name = "RolEntCourier")]
        public string RolEntCourier { get; set; }

        [DataMember(Name = "FecEntCourier")]
        public string FecEntCourier { get; set; }

        [DataMember(Name = "CodCourier")]
        public string CodCourier { get; set; }

        [DataMember(Name = "NumDocCourier")]
        public string NumDocCourier { get; set; }

        [DataMember(Name = "TipoDerivacion")]
        public string TipoDerivacion { get; set; }

        [DataMember(Name = "CcssOrigResp")]
        public string CcssOrigResp { get; set; }

        [DataMember(Name = "RolOrigResp")]
        public string RolOrigResp { get; set; }

        [DataMember(Name = "MotRechazo")]
        public string MotRechazo { get; set; }

        [DataMember(Name = "NumTramo")]
        public string NumTramo { get; set; }

        [DataMember(Name = "NumAcometida")]
        public int NumAcometida { get; set; }

        [DataMember(Name = "EntregadoPor")]
        public string EntregadoPor { get; set; }

        [DataMember(Name = "ConstanciaRec")]
        public string ConstanciaRec { get; set; }

        [DataMember(Name = "VisitasRec")]
        public int VisitasRec { get; set; }

        [DataMember(Name = "ComentarioRec")]
        public string ComentarioRec { get; set; }

        [DataMember(Name = "FecAdmisible")]
        public string FecAdmisible { get; set; }

        [DataMember(Name = "TmpAtencionLds")]
        public int TmpAtencionLds { get; set; }

        [DataMember(Name = "TmpAtencionLegal")]
        public int TmpAtencionLegal { get; set; }

        [DataMember(Name = "NumeroSolicitud")]
        public int NumeroSolicitud { get; set; }

        [DataMember(Name = "MotNoAtencion")]
        public string MotNoAtencion { get; set; }

        [DataMember(Name = "CambioEquipo")]
        public string CambioEquipo { get; set; }

        [DataMember(Name = "DirPostal")]
        public string DirPostal { get; set; }

        [DataMember(Name = "CodDisPostal")]
        public int CodDisPostal { get; set; }

        [DataMember(Name = "CircuitoInt")]
        public string CircuitoInt { get; set; }

        [DataMember(Name = "TmpEjecucionLDS")]
        public int TmpEjecucionLDS { get; set; }

        [DataMember(Name = "TmpEjecucionLega")]
        public int TmpEjecucionLega { get; set; }

        [DataMember(Name = "IndTotaliz")]
        public string IndTotaliz { get; set; }

        [DataMember(Name = "EtapaAnterior")]
        public string EtapaAnterior { get; set; }

        [DataMember(Name = "NumeroTelefono2")]
        public string NumeroTelefono2 { get; set; }

        [DataMember(Name = "TasCambio")]
        public decimal TasCambio { get; set; }

        [DataMember(Name = "FecCambioSol")]
        public string FecCambioSol { get; set; }

        [DataMember(Name = "TasCambioSol")]
        public decimal TasCambioSol { get; set; }

        [DataMember(Name = "CodContratista")]
        public string CodContratista { get; set; }

        [DataMember(Name = "PrecioHh")]
        public decimal PrecioHh { get; set; }

        [DataMember(Name = "IndVersion")]
        public short IndVersion { get; set; }

        [DataMember(Name = "TipoSumin")]
        public string TipoSumin { get; set; }

        [DataMember(Name = "ObsComercial")]
        public string ObsComercial { get; set; }

        [DataMember(Name = "PgRegEnPostgres")]
        public string PgRegEnPostgres { get; set; }

        [DataMember(Name = "FecCumpleReq")]
        public string FecCumpleReq { get; set; }

        [DataMember(Name = "FechaPuser")]
        public string FechaPuser { get; set; }

        [DataMember(Name = "TmpoOfreCliente")]
        public int TmpoOfreCliente { get; set; }

        [DataMember(Name = "TmpoElabProyecto")]
        public int TmpoElabProyecto { get; set; }

        [DataMember(Name = "IdTramite")]
        public int IdTramite { get; set; }

        [DataMember(Name = "IdExpediente")]
        public int IdExpediente { get; set; }

        [DataMember(Name = "IdDireccionObra")]
        public int IdDireccionObra { get; set; }

        [DataMember(Name = "IdDireccionClien")]
        public int IdDireccionClien { get; set; }

        [DataMember(Name = "IdRefgeoSst")]
        public int IdRefgeoSst { get; set; }

        [DataMember(Name = "FecOfreCli")]
        public string FecOfreCli { get; set; }

        [DataMember(Name = "IndFocFonoluz")]
        public string IndFocFonoluz { get; set; }

        //Datos de Aditoria

        [DataMember(Name = "RolRegistrador")]
        public string RolRegistrador { get; set; }

        [DataMember(Name = "FecRegistrador")]
        public string FecRegistrador { get; set; }

        [DataMember(Name = "RolAsignador")]
        public string RolAsignador { get; set; }

        [DataMember(Name = "RolAsignado")]
        public string RolAsignado { get; set; }

        [DataMember(Name = "FecAsignado")]
        public string FecAsignado { get; set; }

        [DataMember(Name = "RolProcesador")]
        public string RolProcesador { get; set; }

        [DataMember(Name = "FecProcesador")]
        public string FecProcesador { get; set; }

        [DataMember(Name = "RolAprobador")]
        public string RolAprobador { get; set; }

        [DataMember(Name = "FecAprobador")]
        public string FecAprobador { get; set; }

        [DataMember(Name = "RolPagador")]
        public string RolPagador { get; set; }

        [DataMember(Name = "FecPagador")]
        public string FecPagador { get; set; }

        [DataMember(Name = "FecRecepcion")]
        public string FecRecepcion { get; set; }

        [DataMember(Name = "RolRecepcion")]
        public string RolRecepcion { get; set; }

        [DataMember(Name = "RolInterrupcion")]
        public string RolInterrupcion { get; set; }

        [DataMember(Name = "FecInterrupcion")]
        public string FecInterrupcion { get; set; }

        [DataMember(Name = "FecActivacion")]
        public string FecActivacion { get; set; }

        [DataMember(Name = "RolDerivacion")]
        public string RolDerivacion { get; set; }

        [DataMember(Name = "FecDerivacion")]
        public string FecDerivacion { get; set; }

        [DataMember(Name = "RolRechazo")]
        public string rolRechazo { get; set; }

        [DataMember(Name = "FecRechazo")]
        public string FecRechazo { get; set; }

        [DataMember(Name = "Rol")]
        public string Rol { get; set; }

        [DataMember(Name = "Date")]
        public string Date { get; set; }

        [DataMember(Name = "Hora")]
        public string Hora { get; set; }

        //Datos de Cliente

        [DataMember(Name = "NumExpCliente")]
        public string NumExpCliente { get; set; }

        [DataMember(Name = "NomCliente")]
        public string NomCliente { get; set; }

        [DataMember(Name = "NomClienteRedes")]
        public string NomClienteRedes { get; set; }

        [DataMember(Name = "DirCliente")]
        public string DirCliente { get; set; }


        //Datos de Suministro

        [DataMember(Name = "NumSuministro")]
        public string NumSuministro { get; set; }

        [DataMember(Name = "NumSuministroAnt")]
        public string NumSuministroAnt { get; set; }

        [DataMember(Name = "NumSuministroPos")]
        public string NumSuministroPos { get; set; }

        [DataMember(Name = "NumSuminisAnt")]
        public string NumSuminisAnt { get; set; }

        //Datos de TD
        [DataMember(Name = "NumValoTD")]
        public string NumValoTD { get; set; }

        [DataMember(Name = "IndTD")]
        public string IndTD { get; set; }

        [DataMember(Name = "EtapaTD")]
        public string EtapaTD { get; set; }

        [DataMember(Name = "FecRegistradorTD")]
        public string FecRegistradorTD { get; set; }

        [DataMember(Name = "RolRegistradorTD")]
        public string RolRegistradorTD { get; set; }

        [DataMember(Name = "RolAsignadoTD")]
        public string RolAsignadoTD { get; set; }

        [DataMember(Name = "FecAsignadoTD")]
        public string FecAsignadoTD { get; set; }

        [DataMember(Name = "RolAsignadorTD")]
        public string RolAsignadorTD { get; set; }

        [DataMember(Name = "FecProcesadorTD")]
        public string FecProcesadorTD { get; set; }

        [DataMember(Name = "RolProcesadorTD")]
        public string RolProcesadorTD { get; set; }

        [DataMember(Name = "FecAprobadorTD")]
        public string FecAprobadorTD { get; set; }

        //[DataMember(Name = "RolAprobadorTD")]
        public string RolAprobadorTD { get; set; }

        [DataMember(Name = "EtapaAnteriorTD")]
        public string EtapaAnteriorTD { get; set; }

        [DataMember(Name = "FecCambioTD")]
        public string FecCambioTD { get; set; }

        [DataMember(Name = "TasCambioTD")]
        public decimal TasCambioTD { get; set; }

        [DataMember(Name = "NumeroTD")]
        public string NumeroTD { get; set; }

        [DataMember(Name = "DescripcionTrabajo")]               //descripcion de la pr_orden_obra
        public string DescripcionTrabajo { get; set; }

        [DataMember(Name = "ObservacionesTrabajo")]             //observaciones de la pr_orden_obra
        public string ObservacionesTrabajo { get; set; }

        [DataMember(Name = "MensajeRetorno")]
        public string MensajeRetorno { get; set; }

        [DataMember(Name = "FechaProgramacionInicio")]
        public string FechaProgramacionInicio { get; set; }

        [DataMember(Name = "FechaProgramacionFin")]
        public string FechaProgramacionFin { get; set; }

        [DataMember(Name = "RolAsignadoSolicitud")]
        public string RolAsignadoSolicitud { get; set; }

        [DataMember(Name = "FechaOriReq")]
        public string FechaOriReq { get; set; }

        [DataMember(Name = "FechaCumpleReqSuminSolic")]
        public string FechaCumpleReqSuminSolic { get; set; }

        [DataMember(Name = "FechaOri")]
        public string FechaOri { get; set; }

        [DataMember(Name = "FechaLeyInicio")]
        public string FechaLeyInicio { get; set; }

        [DataMember(Name = "FechaLeyFin")]
        public string FechaLeyFin { get; set; }

   
        #endregion
    }
}