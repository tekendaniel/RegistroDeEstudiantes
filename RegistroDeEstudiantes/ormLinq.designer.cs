#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistroDeEstudiantes
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Colegio")]
	public partial class ormLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertEstudiante(Estudiante instance);
    partial void UpdateEstudiante(Estudiante instance);
    partial void DeleteEstudiante(Estudiante instance);
    #endregion
		
		public ormLinqDataContext() : 
				base(global::RegistroDeEstudiantes.Properties.Settings.Default.ColegioConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ormLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ormLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ormLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ormLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Estudiante> Estudiante
		{
			get
			{
				return this.GetTable<Estudiante>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Estudiante")]
	public partial class Estudiante : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombres;
		
		private string _Apellidos;
		
		private System.Nullable<int> _edad;
		
		private string _carrera;
		
		private string _semestre;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombresChanging(string value);
    partial void OnNombresChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnedadChanging(System.Nullable<int> value);
    partial void OnedadChanged();
    partial void OncarreraChanging(string value);
    partial void OncarreraChanged();
    partial void OnsemestreChanging(string value);
    partial void OnsemestreChanged();
    #endregion
		
		public Estudiante()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombres", DbType="VarChar(50)")]
		public string Nombres
		{
			get
			{
				return this._Nombres;
			}
			set
			{
				if ((this._Nombres != value))
				{
					this.OnNombresChanging(value);
					this.SendPropertyChanging();
					this._Nombres = value;
					this.SendPropertyChanged("Nombres");
					this.OnNombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="VarChar(50)")]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_edad", DbType="Int")]
		public System.Nullable<int> edad
		{
			get
			{
				return this._edad;
			}
			set
			{
				if ((this._edad != value))
				{
					this.OnedadChanging(value);
					this.SendPropertyChanging();
					this._edad = value;
					this.SendPropertyChanged("edad");
					this.OnedadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carrera", DbType="VarChar(50)")]
		public string carrera
		{
			get
			{
				return this._carrera;
			}
			set
			{
				if ((this._carrera != value))
				{
					this.OncarreraChanging(value);
					this.SendPropertyChanging();
					this._carrera = value;
					this.SendPropertyChanged("carrera");
					this.OncarreraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_semestre", DbType="VarChar(50)")]
		public string semestre
		{
			get
			{
				return this._semestre;
			}
			set
			{
				if ((this._semestre != value))
				{
					this.OnsemestreChanging(value);
					this.SendPropertyChanging();
					this._semestre = value;
					this.SendPropertyChanged("semestre");
					this.OnsemestreChanged();
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
