﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadoCuentaByID
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SIRecupera")]
	public partial class SIRecuperaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDeuda(Deuda instance);
    partial void UpdateDeuda(Deuda instance);
    partial void DeleteDeuda(Deuda instance);
    partial void InsertPagoFacturado(PagoFacturado instance);
    partial void UpdatePagoFacturado(PagoFacturado instance);
    partial void DeletePagoFacturado(PagoFacturado instance);
    #endregion
		
		public SIRecuperaDataContext() : 
				base(global::EstadoCuentaByID.Properties.Settings.Default.SIRecuperaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SIRecuperaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SIRecuperaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SIRecuperaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SIRecuperaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Deuda> Deuda
		{
			get
			{
				return this.GetTable<Deuda>();
			}
		}
		
		public System.Data.Linq.Table<PagoFacturado> PagoFacturado
		{
			get
			{
				return this.GetTable<PagoFacturado>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Deuda")]
	public partial class Deuda : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdDeuda;
		
		private System.Nullable<int> _IdFacturaciónMensual;
		
		private string _IdCiudadano;
		
		private string _IdConcepto;
		
		private System.Nullable<int> _IdPropiedad;
		
		private System.Nullable<System.DateTime> _FechaFacturación;
		
		private System.Nullable<System.DateTime> _FechaVencimiento;
		
		private System.Nullable<bool> _AplicaIPM;
		
		private System.Nullable<bool> _AplicaTIM;
		
		private System.Nullable<decimal> _Deuda1;
		
		private System.Nullable<decimal> _Pagado;
		
		private System.Nullable<decimal> _Saldo;
		
		private System.Nullable<bool> _Coactiva;
		
		private string _Estado;
		
		private string _IdUsuario;
		
		private System.Nullable<System.DateTime> _FechaCreación;
		
		private System.Nullable<System.DateTime> _FechaModificación;
		
		private string _Codicontri;
		
		private System.Nullable<decimal> _BaseImponible;
		
		private string _Detalle;
		
		private System.Nullable<int> _IdPredio;
		
		private System.Nullable<int> _IdPredioUr;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDeudaChanging(int value);
    partial void OnIdDeudaChanged();
    partial void OnIdFacturaciónMensualChanging(System.Nullable<int> value);
    partial void OnIdFacturaciónMensualChanged();
    partial void OnIdCiudadanoChanging(string value);
    partial void OnIdCiudadanoChanged();
    partial void OnIdConceptoChanging(string value);
    partial void OnIdConceptoChanged();
    partial void OnIdPropiedadChanging(System.Nullable<int> value);
    partial void OnIdPropiedadChanged();
    partial void OnFechaFacturaciónChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaFacturaciónChanged();
    partial void OnFechaVencimientoChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaVencimientoChanged();
    partial void OnAplicaIPMChanging(System.Nullable<bool> value);
    partial void OnAplicaIPMChanged();
    partial void OnAplicaTIMChanging(System.Nullable<bool> value);
    partial void OnAplicaTIMChanged();
    partial void OnDeuda1Changing(System.Nullable<decimal> value);
    partial void OnDeuda1Changed();
    partial void OnPagadoChanging(System.Nullable<decimal> value);
    partial void OnPagadoChanged();
    partial void OnSaldoChanging(System.Nullable<decimal> value);
    partial void OnSaldoChanged();
    partial void OnCoactivaChanging(System.Nullable<bool> value);
    partial void OnCoactivaChanged();
    partial void OnEstadoChanging(string value);
    partial void OnEstadoChanged();
    partial void OnIdUsuarioChanging(string value);
    partial void OnIdUsuarioChanged();
    partial void OnFechaCreaciónChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaCreaciónChanged();
    partial void OnFechaModificaciónChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaModificaciónChanged();
    partial void OnCodicontriChanging(string value);
    partial void OnCodicontriChanged();
    partial void OnBaseImponibleChanging(System.Nullable<decimal> value);
    partial void OnBaseImponibleChanged();
    partial void OnDetalleChanging(string value);
    partial void OnDetalleChanged();
    partial void OnIdPredioChanging(System.Nullable<int> value);
    partial void OnIdPredioChanged();
    partial void OnIdPredioUrChanging(System.Nullable<int> value);
    partial void OnIdPredioUrChanged();
    #endregion
		
		public Deuda()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDeuda", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdDeuda
		{
			get
			{
				return this._IdDeuda;
			}
			set
			{
				if ((this._IdDeuda != value))
				{
					this.OnIdDeudaChanging(value);
					this.SendPropertyChanging();
					this._IdDeuda = value;
					this.SendPropertyChanged("IdDeuda");
					this.OnIdDeudaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdFacturaciónMensual", DbType="Int")]
		public System.Nullable<int> IdFacturaciónMensual
		{
			get
			{
				return this._IdFacturaciónMensual;
			}
			set
			{
				if ((this._IdFacturaciónMensual != value))
				{
					this.OnIdFacturaciónMensualChanging(value);
					this.SendPropertyChanging();
					this._IdFacturaciónMensual = value;
					this.SendPropertyChanged("IdFacturaciónMensual");
					this.OnIdFacturaciónMensualChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCiudadano", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string IdCiudadano
		{
			get
			{
				return this._IdCiudadano;
			}
			set
			{
				if ((this._IdCiudadano != value))
				{
					this.OnIdCiudadanoChanging(value);
					this.SendPropertyChanging();
					this._IdCiudadano = value;
					this.SendPropertyChanged("IdCiudadano");
					this.OnIdCiudadanoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdConcepto", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string IdConcepto
		{
			get
			{
				return this._IdConcepto;
			}
			set
			{
				if ((this._IdConcepto != value))
				{
					this.OnIdConceptoChanging(value);
					this.SendPropertyChanging();
					this._IdConcepto = value;
					this.SendPropertyChanged("IdConcepto");
					this.OnIdConceptoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPropiedad", DbType="Int")]
		public System.Nullable<int> IdPropiedad
		{
			get
			{
				return this._IdPropiedad;
			}
			set
			{
				if ((this._IdPropiedad != value))
				{
					this.OnIdPropiedadChanging(value);
					this.SendPropertyChanging();
					this._IdPropiedad = value;
					this.SendPropertyChanged("IdPropiedad");
					this.OnIdPropiedadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaFacturación", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> FechaFacturación
		{
			get
			{
				return this._FechaFacturación;
			}
			set
			{
				if ((this._FechaFacturación != value))
				{
					this.OnFechaFacturaciónChanging(value);
					this.SendPropertyChanging();
					this._FechaFacturación = value;
					this.SendPropertyChanged("FechaFacturación");
					this.OnFechaFacturaciónChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaVencimiento", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> FechaVencimiento
		{
			get
			{
				return this._FechaVencimiento;
			}
			set
			{
				if ((this._FechaVencimiento != value))
				{
					this.OnFechaVencimientoChanging(value);
					this.SendPropertyChanging();
					this._FechaVencimiento = value;
					this.SendPropertyChanged("FechaVencimiento");
					this.OnFechaVencimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AplicaIPM", DbType="Bit")]
		public System.Nullable<bool> AplicaIPM
		{
			get
			{
				return this._AplicaIPM;
			}
			set
			{
				if ((this._AplicaIPM != value))
				{
					this.OnAplicaIPMChanging(value);
					this.SendPropertyChanging();
					this._AplicaIPM = value;
					this.SendPropertyChanged("AplicaIPM");
					this.OnAplicaIPMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AplicaTIM", DbType="Bit")]
		public System.Nullable<bool> AplicaTIM
		{
			get
			{
				return this._AplicaTIM;
			}
			set
			{
				if ((this._AplicaTIM != value))
				{
					this.OnAplicaTIMChanging(value);
					this.SendPropertyChanging();
					this._AplicaTIM = value;
					this.SendPropertyChanged("AplicaTIM");
					this.OnAplicaTIMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Deuda", Storage="_Deuda1", DbType="Money")]
		public System.Nullable<decimal> Deuda1
		{
			get
			{
				return this._Deuda1;
			}
			set
			{
				if ((this._Deuda1 != value))
				{
					this.OnDeuda1Changing(value);
					this.SendPropertyChanging();
					this._Deuda1 = value;
					this.SendPropertyChanged("Deuda1");
					this.OnDeuda1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pagado", DbType="Money")]
		public System.Nullable<decimal> Pagado
		{
			get
			{
				return this._Pagado;
			}
			set
			{
				if ((this._Pagado != value))
				{
					this.OnPagadoChanging(value);
					this.SendPropertyChanging();
					this._Pagado = value;
					this.SendPropertyChanged("Pagado");
					this.OnPagadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Saldo", DbType="Money")]
		public System.Nullable<decimal> Saldo
		{
			get
			{
				return this._Saldo;
			}
			set
			{
				if ((this._Saldo != value))
				{
					this.OnSaldoChanging(value);
					this.SendPropertyChanging();
					this._Saldo = value;
					this.SendPropertyChanged("Saldo");
					this.OnSaldoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coactiva", DbType="Bit")]
		public System.Nullable<bool> Coactiva
		{
			get
			{
				return this._Coactiva;
			}
			set
			{
				if ((this._Coactiva != value))
				{
					this.OnCoactivaChanging(value);
					this.SendPropertyChanging();
					this._Coactiva = value;
					this.SendPropertyChanged("Coactiva");
					this.OnCoactivaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this.OnIdUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IdUsuario = value;
					this.SendPropertyChanged("IdUsuario");
					this.OnIdUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreación", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> FechaCreación
		{
			get
			{
				return this._FechaCreación;
			}
			set
			{
				if ((this._FechaCreación != value))
				{
					this.OnFechaCreaciónChanging(value);
					this.SendPropertyChanging();
					this._FechaCreación = value;
					this.SendPropertyChanged("FechaCreación");
					this.OnFechaCreaciónChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaModificación", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> FechaModificación
		{
			get
			{
				return this._FechaModificación;
			}
			set
			{
				if ((this._FechaModificación != value))
				{
					this.OnFechaModificaciónChanging(value);
					this.SendPropertyChanging();
					this._FechaModificación = value;
					this.SendPropertyChanged("FechaModificación");
					this.OnFechaModificaciónChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codicontri", DbType="NVarChar(20)")]
		public string Codicontri
		{
			get
			{
				return this._Codicontri;
			}
			set
			{
				if ((this._Codicontri != value))
				{
					this.OnCodicontriChanging(value);
					this.SendPropertyChanging();
					this._Codicontri = value;
					this.SendPropertyChanged("Codicontri");
					this.OnCodicontriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BaseImponible", DbType="Money")]
		public System.Nullable<decimal> BaseImponible
		{
			get
			{
				return this._BaseImponible;
			}
			set
			{
				if ((this._BaseImponible != value))
				{
					this.OnBaseImponibleChanging(value);
					this.SendPropertyChanging();
					this._BaseImponible = value;
					this.SendPropertyChanged("BaseImponible");
					this.OnBaseImponibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Detalle", DbType="NVarChar(250)")]
		public string Detalle
		{
			get
			{
				return this._Detalle;
			}
			set
			{
				if ((this._Detalle != value))
				{
					this.OnDetalleChanging(value);
					this.SendPropertyChanging();
					this._Detalle = value;
					this.SendPropertyChanged("Detalle");
					this.OnDetalleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPredio", DbType="Int")]
		public System.Nullable<int> IdPredio
		{
			get
			{
				return this._IdPredio;
			}
			set
			{
				if ((this._IdPredio != value))
				{
					this.OnIdPredioChanging(value);
					this.SendPropertyChanging();
					this._IdPredio = value;
					this.SendPropertyChanged("IdPredio");
					this.OnIdPredioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPredioUr", DbType="Int")]
		public System.Nullable<int> IdPredioUr
		{
			get
			{
				return this._IdPredioUr;
			}
			set
			{
				if ((this._IdPredioUr != value))
				{
					this.OnIdPredioUrChanging(value);
					this.SendPropertyChanging();
					this._IdPredioUr = value;
					this.SendPropertyChanged("IdPredioUr");
					this.OnIdPredioUrChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PagoFacturado")]
	public partial class PagoFacturado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPago;
		
		private string _IdCiudadano;
		
		private System.Nullable<int> _IdDeuda;
		
		private string _IdConcepto;
		
		private string _ApellidosyNombres;
		
		private string _DomicilioFiscalyNumero;
		
		private string _ComprobanteDePago;
		
		private System.DateTime _FechaDeVencimiento;
		
		private System.Nullable<decimal> _BaseInponible;
		
		private decimal _MontoPagado;
		
		private System.Nullable<decimal> _Descuento;
		
		private string _NúmeroBarra;
		
		private string _Estado;
		
		private string _IdUsuario;
		
		private System.DateTime _FechaCreación;
		
		private System.Nullable<System.DateTime> _FechaModificación;
		
		private System.Nullable<decimal> _Facturado;
		
		private System.Nullable<decimal> _Pagado;
		
		private System.Nullable<decimal> _Saldo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPagoChanging(int value);
    partial void OnIdPagoChanged();
    partial void OnIdCiudadanoChanging(string value);
    partial void OnIdCiudadanoChanged();
    partial void OnIdDeudaChanging(System.Nullable<int> value);
    partial void OnIdDeudaChanged();
    partial void OnIdConceptoChanging(string value);
    partial void OnIdConceptoChanged();
    partial void OnApellidosyNombresChanging(string value);
    partial void OnApellidosyNombresChanged();
    partial void OnDomicilioFiscalyNumeroChanging(string value);
    partial void OnDomicilioFiscalyNumeroChanged();
    partial void OnComprobanteDePagoChanging(string value);
    partial void OnComprobanteDePagoChanged();
    partial void OnFechaDeVencimientoChanging(System.DateTime value);
    partial void OnFechaDeVencimientoChanged();
    partial void OnBaseInponibleChanging(System.Nullable<decimal> value);
    partial void OnBaseInponibleChanged();
    partial void OnMontoPagadoChanging(decimal value);
    partial void OnMontoPagadoChanged();
    partial void OnDescuentoChanging(System.Nullable<decimal> value);
    partial void OnDescuentoChanged();
    partial void OnNúmeroBarraChanging(string value);
    partial void OnNúmeroBarraChanged();
    partial void OnEstadoChanging(string value);
    partial void OnEstadoChanged();
    partial void OnIdUsuarioChanging(string value);
    partial void OnIdUsuarioChanged();
    partial void OnFechaCreaciónChanging(System.DateTime value);
    partial void OnFechaCreaciónChanged();
    partial void OnFechaModificaciónChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaModificaciónChanged();
    partial void OnFacturadoChanging(System.Nullable<decimal> value);
    partial void OnFacturadoChanged();
    partial void OnPagadoChanging(System.Nullable<decimal> value);
    partial void OnPagadoChanged();
    partial void OnSaldoChanging(System.Nullable<decimal> value);
    partial void OnSaldoChanged();
    #endregion
		
		public PagoFacturado()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPago", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdPago
		{
			get
			{
				return this._IdPago;
			}
			set
			{
				if ((this._IdPago != value))
				{
					this.OnIdPagoChanging(value);
					this.SendPropertyChanging();
					this._IdPago = value;
					this.SendPropertyChanged("IdPago");
					this.OnIdPagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCiudadano", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string IdCiudadano
		{
			get
			{
				return this._IdCiudadano;
			}
			set
			{
				if ((this._IdCiudadano != value))
				{
					this.OnIdCiudadanoChanging(value);
					this.SendPropertyChanging();
					this._IdCiudadano = value;
					this.SendPropertyChanged("IdCiudadano");
					this.OnIdCiudadanoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDeuda", DbType="Int")]
		public System.Nullable<int> IdDeuda
		{
			get
			{
				return this._IdDeuda;
			}
			set
			{
				if ((this._IdDeuda != value))
				{
					this.OnIdDeudaChanging(value);
					this.SendPropertyChanging();
					this._IdDeuda = value;
					this.SendPropertyChanged("IdDeuda");
					this.OnIdDeudaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdConcepto", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string IdConcepto
		{
			get
			{
				return this._IdConcepto;
			}
			set
			{
				if ((this._IdConcepto != value))
				{
					this.OnIdConceptoChanging(value);
					this.SendPropertyChanging();
					this._IdConcepto = value;
					this.SendPropertyChanged("IdConcepto");
					this.OnIdConceptoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidosyNombres", DbType="NVarChar(100)")]
		public string ApellidosyNombres
		{
			get
			{
				return this._ApellidosyNombres;
			}
			set
			{
				if ((this._ApellidosyNombres != value))
				{
					this.OnApellidosyNombresChanging(value);
					this.SendPropertyChanging();
					this._ApellidosyNombres = value;
					this.SendPropertyChanged("ApellidosyNombres");
					this.OnApellidosyNombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DomicilioFiscalyNumero", DbType="NVarChar(100)")]
		public string DomicilioFiscalyNumero
		{
			get
			{
				return this._DomicilioFiscalyNumero;
			}
			set
			{
				if ((this._DomicilioFiscalyNumero != value))
				{
					this.OnDomicilioFiscalyNumeroChanging(value);
					this.SendPropertyChanging();
					this._DomicilioFiscalyNumero = value;
					this.SendPropertyChanged("DomicilioFiscalyNumero");
					this.OnDomicilioFiscalyNumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ComprobanteDePago", DbType="NChar(10)")]
		public string ComprobanteDePago
		{
			get
			{
				return this._ComprobanteDePago;
			}
			set
			{
				if ((this._ComprobanteDePago != value))
				{
					this.OnComprobanteDePagoChanging(value);
					this.SendPropertyChanging();
					this._ComprobanteDePago = value;
					this.SendPropertyChanged("ComprobanteDePago");
					this.OnComprobanteDePagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaDeVencimiento", DbType="SmallDateTime NOT NULL")]
		public System.DateTime FechaDeVencimiento
		{
			get
			{
				return this._FechaDeVencimiento;
			}
			set
			{
				if ((this._FechaDeVencimiento != value))
				{
					this.OnFechaDeVencimientoChanging(value);
					this.SendPropertyChanging();
					this._FechaDeVencimiento = value;
					this.SendPropertyChanged("FechaDeVencimiento");
					this.OnFechaDeVencimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BaseInponible", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> BaseInponible
		{
			get
			{
				return this._BaseInponible;
			}
			set
			{
				if ((this._BaseInponible != value))
				{
					this.OnBaseInponibleChanging(value);
					this.SendPropertyChanging();
					this._BaseInponible = value;
					this.SendPropertyChanged("BaseInponible");
					this.OnBaseInponibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MontoPagado", DbType="Money NOT NULL")]
		public decimal MontoPagado
		{
			get
			{
				return this._MontoPagado;
			}
			set
			{
				if ((this._MontoPagado != value))
				{
					this.OnMontoPagadoChanging(value);
					this.SendPropertyChanging();
					this._MontoPagado = value;
					this.SendPropertyChanged("MontoPagado");
					this.OnMontoPagadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descuento", DbType="Money")]
		public System.Nullable<decimal> Descuento
		{
			get
			{
				return this._Descuento;
			}
			set
			{
				if ((this._Descuento != value))
				{
					this.OnDescuentoChanging(value);
					this.SendPropertyChanging();
					this._Descuento = value;
					this.SendPropertyChanged("Descuento");
					this.OnDescuentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NúmeroBarra", DbType="NVarChar(50)")]
		public string NúmeroBarra
		{
			get
			{
				return this._NúmeroBarra;
			}
			set
			{
				if ((this._NúmeroBarra != value))
				{
					this.OnNúmeroBarraChanging(value);
					this.SendPropertyChanging();
					this._NúmeroBarra = value;
					this.SendPropertyChanged("NúmeroBarra");
					this.OnNúmeroBarraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this.OnIdUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IdUsuario = value;
					this.SendPropertyChanged("IdUsuario");
					this.OnIdUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaCreación", DbType="SmallDateTime NOT NULL")]
		public System.DateTime FechaCreación
		{
			get
			{
				return this._FechaCreación;
			}
			set
			{
				if ((this._FechaCreación != value))
				{
					this.OnFechaCreaciónChanging(value);
					this.SendPropertyChanging();
					this._FechaCreación = value;
					this.SendPropertyChanged("FechaCreación");
					this.OnFechaCreaciónChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaModificación", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> FechaModificación
		{
			get
			{
				return this._FechaModificación;
			}
			set
			{
				if ((this._FechaModificación != value))
				{
					this.OnFechaModificaciónChanging(value);
					this.SendPropertyChanging();
					this._FechaModificación = value;
					this.SendPropertyChanged("FechaModificación");
					this.OnFechaModificaciónChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Facturado", DbType="Money")]
		public System.Nullable<decimal> Facturado
		{
			get
			{
				return this._Facturado;
			}
			set
			{
				if ((this._Facturado != value))
				{
					this.OnFacturadoChanging(value);
					this.SendPropertyChanging();
					this._Facturado = value;
					this.SendPropertyChanged("Facturado");
					this.OnFacturadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pagado", DbType="Money")]
		public System.Nullable<decimal> Pagado
		{
			get
			{
				return this._Pagado;
			}
			set
			{
				if ((this._Pagado != value))
				{
					this.OnPagadoChanging(value);
					this.SendPropertyChanging();
					this._Pagado = value;
					this.SendPropertyChanged("Pagado");
					this.OnPagadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Saldo", DbType="Money")]
		public System.Nullable<decimal> Saldo
		{
			get
			{
				return this._Saldo;
			}
			set
			{
				if ((this._Saldo != value))
				{
					this.OnSaldoChanging(value);
					this.SendPropertyChanging();
					this._Saldo = value;
					this.SendPropertyChanged("Saldo");
					this.OnSaldoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
