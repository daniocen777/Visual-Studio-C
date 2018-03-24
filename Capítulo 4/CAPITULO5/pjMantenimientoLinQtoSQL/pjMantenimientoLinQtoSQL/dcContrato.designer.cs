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

namespace pjMantenimientoLinQtoSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CONTRATO")]
	public partial class dcContratoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertEQUIPO(EQUIPO instance);
    partial void UpdateEQUIPO(EQUIPO instance);
    partial void DeleteEQUIPO(EQUIPO instance);
    partial void InsertTIPO_EQUIPO(TIPO_EQUIPO instance);
    partial void UpdateTIPO_EQUIPO(TIPO_EQUIPO instance);
    partial void DeleteTIPO_EQUIPO(TIPO_EQUIPO instance);
    partial void InsertESTADO_EQUIPO(ESTADO_EQUIPO instance);
    partial void UpdateESTADO_EQUIPO(ESTADO_EQUIPO instance);
    partial void DeleteESTADO_EQUIPO(ESTADO_EQUIPO instance);
    #endregion
		
		public dcContratoDataContext() : 
				base(global::pjMantenimientoLinQtoSQL.Properties.Settings.Default.CONTRATOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcContratoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcContratoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcContratoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcContratoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EQUIPO> EQUIPO
		{
			get
			{
				return this.GetTable<EQUIPO>();
			}
		}
		
		public System.Data.Linq.Table<TIPO_EQUIPO> TIPO_EQUIPO
		{
			get
			{
				return this.GetTable<TIPO_EQUIPO>();
			}
		}
		
		public System.Data.Linq.Table<ESTADO_EQUIPO> ESTADO_EQUIPO
		{
			get
			{
				return this.GetTable<ESTADO_EQUIPO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EQUIPO")]
	public partial class EQUIPO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDE_EQU;
		
		private string _COD_TIP_EQU;
		
		private string _DESC_EQU;
		
		private System.Nullable<decimal> _PREC_EQU;
		
		private string _COD_EST;
		
		private EntityRef<TIPO_EQUIPO> _TIPO_EQUIPO;
		
		private EntityRef<ESTADO_EQUIPO> _ESTADO_EQUIPO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDE_EQUChanging(string value);
    partial void OnIDE_EQUChanged();
    partial void OnCOD_TIP_EQUChanging(string value);
    partial void OnCOD_TIP_EQUChanged();
    partial void OnDESC_EQUChanging(string value);
    partial void OnDESC_EQUChanged();
    partial void OnPREC_EQUChanging(System.Nullable<decimal> value);
    partial void OnPREC_EQUChanged();
    partial void OnCOD_ESTChanging(string value);
    partial void OnCOD_ESTChanged();
    #endregion
		
		public EQUIPO()
		{
			this._TIPO_EQUIPO = default(EntityRef<TIPO_EQUIPO>);
			this._ESTADO_EQUIPO = default(EntityRef<ESTADO_EQUIPO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDE_EQU", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDE_EQU
		{
			get
			{
				return this._IDE_EQU;
			}
			set
			{
				if ((this._IDE_EQU != value))
				{
					this.OnIDE_EQUChanging(value);
					this.SendPropertyChanging();
					this._IDE_EQU = value;
					this.SendPropertyChanged("IDE_EQU");
					this.OnIDE_EQUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COD_TIP_EQU", DbType="Char(6) NOT NULL", CanBeNull=false)]
		public string COD_TIP_EQU
		{
			get
			{
				return this._COD_TIP_EQU;
			}
			set
			{
				if ((this._COD_TIP_EQU != value))
				{
					if (this._TIPO_EQUIPO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCOD_TIP_EQUChanging(value);
					this.SendPropertyChanging();
					this._COD_TIP_EQU = value;
					this.SendPropertyChanged("COD_TIP_EQU");
					this.OnCOD_TIP_EQUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESC_EQU", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DESC_EQU
		{
			get
			{
				return this._DESC_EQU;
			}
			set
			{
				if ((this._DESC_EQU != value))
				{
					this.OnDESC_EQUChanging(value);
					this.SendPropertyChanging();
					this._DESC_EQU = value;
					this.SendPropertyChanged("DESC_EQU");
					this.OnDESC_EQUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PREC_EQU", DbType="Money")]
		public System.Nullable<decimal> PREC_EQU
		{
			get
			{
				return this._PREC_EQU;
			}
			set
			{
				if ((this._PREC_EQU != value))
				{
					this.OnPREC_EQUChanging(value);
					this.SendPropertyChanging();
					this._PREC_EQU = value;
					this.SendPropertyChanged("PREC_EQU");
					this.OnPREC_EQUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COD_EST", DbType="Char(6)")]
		public string COD_EST
		{
			get
			{
				return this._COD_EST;
			}
			set
			{
				if ((this._COD_EST != value))
				{
					if (this._ESTADO_EQUIPO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCOD_ESTChanging(value);
					this.SendPropertyChanging();
					this._COD_EST = value;
					this.SendPropertyChanged("COD_EST");
					this.OnCOD_ESTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TIPO_EQUIPO_EQUIPO", Storage="_TIPO_EQUIPO", ThisKey="COD_TIP_EQU", OtherKey="COD_TIP_EQU", IsForeignKey=true)]
		public TIPO_EQUIPO TIPO_EQUIPO
		{
			get
			{
				return this._TIPO_EQUIPO.Entity;
			}
			set
			{
				TIPO_EQUIPO previousValue = this._TIPO_EQUIPO.Entity;
				if (((previousValue != value) 
							|| (this._TIPO_EQUIPO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TIPO_EQUIPO.Entity = null;
						previousValue.EQUIPO.Remove(this);
					}
					this._TIPO_EQUIPO.Entity = value;
					if ((value != null))
					{
						value.EQUIPO.Add(this);
						this._COD_TIP_EQU = value.COD_TIP_EQU;
					}
					else
					{
						this._COD_TIP_EQU = default(string);
					}
					this.SendPropertyChanged("TIPO_EQUIPO");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ESTADO_EQUIPO_EQUIPO", Storage="_ESTADO_EQUIPO", ThisKey="COD_EST", OtherKey="COD_EST", IsForeignKey=true)]
		public ESTADO_EQUIPO ESTADO_EQUIPO
		{
			get
			{
				return this._ESTADO_EQUIPO.Entity;
			}
			set
			{
				ESTADO_EQUIPO previousValue = this._ESTADO_EQUIPO.Entity;
				if (((previousValue != value) 
							|| (this._ESTADO_EQUIPO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ESTADO_EQUIPO.Entity = null;
						previousValue.EQUIPO.Remove(this);
					}
					this._ESTADO_EQUIPO.Entity = value;
					if ((value != null))
					{
						value.EQUIPO.Add(this);
						this._COD_EST = value.COD_EST;
					}
					else
					{
						this._COD_EST = default(string);
					}
					this.SendPropertyChanged("ESTADO_EQUIPO");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TIPO_EQUIPO")]
	public partial class TIPO_EQUIPO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _COD_TIP_EQU;
		
		private string _DES_TIP;
		
		private EntitySet<EQUIPO> _EQUIPO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCOD_TIP_EQUChanging(string value);
    partial void OnCOD_TIP_EQUChanged();
    partial void OnDES_TIPChanging(string value);
    partial void OnDES_TIPChanged();
    #endregion
		
		public TIPO_EQUIPO()
		{
			this._EQUIPO = new EntitySet<EQUIPO>(new Action<EQUIPO>(this.attach_EQUIPO), new Action<EQUIPO>(this.detach_EQUIPO));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COD_TIP_EQU", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string COD_TIP_EQU
		{
			get
			{
				return this._COD_TIP_EQU;
			}
			set
			{
				if ((this._COD_TIP_EQU != value))
				{
					this.OnCOD_TIP_EQUChanging(value);
					this.SendPropertyChanging();
					this._COD_TIP_EQU = value;
					this.SendPropertyChanged("COD_TIP_EQU");
					this.OnCOD_TIP_EQUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DES_TIP", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string DES_TIP
		{
			get
			{
				return this._DES_TIP;
			}
			set
			{
				if ((this._DES_TIP != value))
				{
					this.OnDES_TIPChanging(value);
					this.SendPropertyChanging();
					this._DES_TIP = value;
					this.SendPropertyChanged("DES_TIP");
					this.OnDES_TIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TIPO_EQUIPO_EQUIPO", Storage="_EQUIPO", ThisKey="COD_TIP_EQU", OtherKey="COD_TIP_EQU")]
		public EntitySet<EQUIPO> EQUIPO
		{
			get
			{
				return this._EQUIPO;
			}
			set
			{
				this._EQUIPO.Assign(value);
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
		
		private void attach_EQUIPO(EQUIPO entity)
		{
			this.SendPropertyChanging();
			entity.TIPO_EQUIPO = this;
		}
		
		private void detach_EQUIPO(EQUIPO entity)
		{
			this.SendPropertyChanging();
			entity.TIPO_EQUIPO = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ESTADO_EQUIPO")]
	public partial class ESTADO_EQUIPO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _COD_EST;
		
		private string _DES_EST;
		
		private EntitySet<EQUIPO> _EQUIPO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCOD_ESTChanging(string value);
    partial void OnCOD_ESTChanged();
    partial void OnDES_ESTChanging(string value);
    partial void OnDES_ESTChanged();
    #endregion
		
		public ESTADO_EQUIPO()
		{
			this._EQUIPO = new EntitySet<EQUIPO>(new Action<EQUIPO>(this.attach_EQUIPO), new Action<EQUIPO>(this.detach_EQUIPO));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COD_EST", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string COD_EST
		{
			get
			{
				return this._COD_EST;
			}
			set
			{
				if ((this._COD_EST != value))
				{
					this.OnCOD_ESTChanging(value);
					this.SendPropertyChanging();
					this._COD_EST = value;
					this.SendPropertyChanged("COD_EST");
					this.OnCOD_ESTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DES_EST", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string DES_EST
		{
			get
			{
				return this._DES_EST;
			}
			set
			{
				if ((this._DES_EST != value))
				{
					this.OnDES_ESTChanging(value);
					this.SendPropertyChanging();
					this._DES_EST = value;
					this.SendPropertyChanged("DES_EST");
					this.OnDES_ESTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ESTADO_EQUIPO_EQUIPO", Storage="_EQUIPO", ThisKey="COD_EST", OtherKey="COD_EST")]
		public EntitySet<EQUIPO> EQUIPO
		{
			get
			{
				return this._EQUIPO;
			}
			set
			{
				this._EQUIPO.Assign(value);
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
		
		private void attach_EQUIPO(EQUIPO entity)
		{
			this.SendPropertyChanging();
			entity.ESTADO_EQUIPO = this;
		}
		
		private void detach_EQUIPO(EQUIPO entity)
		{
			this.SendPropertyChanging();
			entity.ESTADO_EQUIPO = null;
		}
	}
}
#pragma warning restore 1591
