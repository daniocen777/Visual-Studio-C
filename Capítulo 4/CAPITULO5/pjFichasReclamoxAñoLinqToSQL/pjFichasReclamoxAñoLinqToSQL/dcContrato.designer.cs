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

namespace pjFichasReclamoxAñoLinqToSQL
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
    partial void InsertFICHARECLAMO(FICHARECLAMO instance);
    partial void UpdateFICHARECLAMO(FICHARECLAMO instance);
    partial void DeleteFICHARECLAMO(FICHARECLAMO instance);
    #endregion
		
		public dcContratoDataContext() : 
				base(global::pjFichasReclamoxAñoLinqToSQL.Properties.Settings.Default.CONTRATOConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<FICHARECLAMO> FICHARECLAMO
		{
			get
			{
				return this.GetTable<FICHARECLAMO>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_LISTAAÑOS")]
		public ISingleResult<SP_LISTAAÑOSResult> SP_LISTAAÑOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_LISTAAÑOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_LISTAFICHASRECLAMOXAÑO")]
		public ISingleResult<SP_LISTAFICHASRECLAMOXAÑOResult> SP_LISTAFICHASRECLAMOXAÑO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AÑO", DbType="Int")] System.Nullable<int> aÑO)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), aÑO);
			return ((ISingleResult<SP_LISTAFICHASRECLAMOXAÑOResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FICHARECLAMO")]
	public partial class FICHARECLAMO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _COD_FIC;
		
		private string _IDE_CON;
		
		private string _IDE_CLI;
		
		private System.DateTime _FFI_FIC;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCOD_FICChanging(string value);
    partial void OnCOD_FICChanged();
    partial void OnIDE_CONChanging(string value);
    partial void OnIDE_CONChanged();
    partial void OnIDE_CLIChanging(string value);
    partial void OnIDE_CLIChanged();
    partial void OnFFI_FICChanging(System.DateTime value);
    partial void OnFFI_FICChanged();
    #endregion
		
		public FICHARECLAMO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COD_FIC", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string COD_FIC
		{
			get
			{
				return this._COD_FIC;
			}
			set
			{
				if ((this._COD_FIC != value))
				{
					this.OnCOD_FICChanging(value);
					this.SendPropertyChanging();
					this._COD_FIC = value;
					this.SendPropertyChanged("COD_FIC");
					this.OnCOD_FICChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDE_CON", DbType="Char(6) NOT NULL", CanBeNull=false)]
		public string IDE_CON
		{
			get
			{
				return this._IDE_CON;
			}
			set
			{
				if ((this._IDE_CON != value))
				{
					this.OnIDE_CONChanging(value);
					this.SendPropertyChanging();
					this._IDE_CON = value;
					this.SendPropertyChanged("IDE_CON");
					this.OnIDE_CONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDE_CLI", DbType="Char(6) NOT NULL", CanBeNull=false)]
		public string IDE_CLI
		{
			get
			{
				return this._IDE_CLI;
			}
			set
			{
				if ((this._IDE_CLI != value))
				{
					this.OnIDE_CLIChanging(value);
					this.SendPropertyChanging();
					this._IDE_CLI = value;
					this.SendPropertyChanged("IDE_CLI");
					this.OnIDE_CLIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FFI_FIC", DbType="Date NOT NULL")]
		public System.DateTime FFI_FIC
		{
			get
			{
				return this._FFI_FIC;
			}
			set
			{
				if ((this._FFI_FIC != value))
				{
					this.OnFFI_FICChanging(value);
					this.SendPropertyChanging();
					this._FFI_FIC = value;
					this.SendPropertyChanged("FFI_FIC");
					this.OnFFI_FICChanged();
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
	
	public partial class SP_LISTAAÑOSResult
	{
		
		private System.Nullable<int> _AÑO;
		
		public SP_LISTAAÑOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AÑO", DbType="Int")]
		public System.Nullable<int> AÑO
		{
			get
			{
				return this._AÑO;
			}
			set
			{
				if ((this._AÑO != value))
				{
					this._AÑO = value;
				}
			}
		}
	}
	
	public partial class SP_LISTAFICHASRECLAMOXAÑOResult
	{
		
		private string _CODIGO;
		
		private string _CONTRATISTA;
		
		private string _CLIENTE;
		
		private System.DateTime _FECHA;
		
		public SP_LISTAFICHASRECLAMOXAÑOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO", DbType="Char(6) NOT NULL", CanBeNull=false)]
		public string CODIGO
		{
			get
			{
				return this._CODIGO;
			}
			set
			{
				if ((this._CODIGO != value))
				{
					this._CODIGO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTRATISTA", DbType="VarChar(72)")]
		public string CONTRATISTA
		{
			get
			{
				return this._CONTRATISTA;
			}
			set
			{
				if ((this._CONTRATISTA != value))
				{
					this._CONTRATISTA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLIENTE", DbType="VarChar(102)")]
		public string CLIENTE
		{
			get
			{
				return this._CLIENTE;
			}
			set
			{
				if ((this._CLIENTE != value))
				{
					this._CLIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA", DbType="Date NOT NULL")]
		public System.DateTime FECHA
		{
			get
			{
				return this._FECHA;
			}
			set
			{
				if ((this._FECHA != value))
				{
					this._FECHA = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
