﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQExam
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_test")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_student(tbl_student instance);
    partial void Updatetbl_student(tbl_student instance);
    partial void Deletetbl_student(tbl_student instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["db_testConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_student> tbl_students
		{
			get
			{
				return this.GetTable<tbl_student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_student")]
	public partial class tbl_student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _stud_id;
		
		private string _stud_name;
		
		private string _stud_city;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onstud_idChanging(int value);
    partial void Onstud_idChanged();
    partial void Onstud_nameChanging(string value);
    partial void Onstud_nameChanged();
    partial void Onstud_cityChanging(string value);
    partial void Onstud_cityChanged();
    #endregion
		
		public tbl_student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stud_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int stud_id
		{
			get
			{
				return this._stud_id;
			}
			set
			{
				if ((this._stud_id != value))
				{
					this.Onstud_idChanging(value);
					this.SendPropertyChanging();
					this._stud_id = value;
					this.SendPropertyChanged("stud_id");
					this.Onstud_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stud_name", DbType="VarChar(25)")]
		public string stud_name
		{
			get
			{
				return this._stud_name;
			}
			set
			{
				if ((this._stud_name != value))
				{
					this.Onstud_nameChanging(value);
					this.SendPropertyChanging();
					this._stud_name = value;
					this.SendPropertyChanged("stud_name");
					this.Onstud_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stud_city", DbType="VarChar(30)")]
		public string stud_city
		{
			get
			{
				return this._stud_city;
			}
			set
			{
				if ((this._stud_city != value))
				{
					this.Onstud_cityChanging(value);
					this.SendPropertyChanging();
					this._stud_city = value;
					this.SendPropertyChanged("stud_city");
					this.Onstud_cityChanged();
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
