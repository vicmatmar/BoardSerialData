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

namespace BoardSerialData
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ManufacturingStore_RAD")]
	public partial class BoardSerial_DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertTester(Tester instance);
    partial void UpdateTester(Tester instance);
    partial void DeleteTester(Tester instance);
    #endregion
		
		public BoardSerial_DataContext() : 
				base(global::BoardSerialData.Properties.Settings.Default.ManufacturingStore_RADConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BoardSerial_DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BoardSerial_DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BoardSerial_DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BoardSerial_DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Tester> Testers
		{
			get
			{
				return this.GetTable<Tester>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _ModelString;
		
		private string _Description;
		
		private System.Nullable<bool> _Released;
		
		private int _BoardId;
		
		private System.DateTime _CreateDate;
		
		private string _SerialNumberCode;
		
		private string _ZigbeeModelString;
		
		private int _ExtensionId;
		
		private string _SKU;
		
		private bool _CurrentTest;
		
		private System.Nullable<int> _ModelEncodingNumber;
		
		private string _ZplFile;
		
		private bool _EnableReadProtectOnDevice;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnModelStringChanging(string value);
    partial void OnModelStringChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnReleasedChanging(System.Nullable<bool> value);
    partial void OnReleasedChanged();
    partial void OnBoardIdChanging(int value);
    partial void OnBoardIdChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnSerialNumberCodeChanging(string value);
    partial void OnSerialNumberCodeChanged();
    partial void OnZigbeeModelStringChanging(string value);
    partial void OnZigbeeModelStringChanged();
    partial void OnExtensionIdChanging(int value);
    partial void OnExtensionIdChanged();
    partial void OnSKUChanging(string value);
    partial void OnSKUChanged();
    partial void OnCurrentTestChanging(bool value);
    partial void OnCurrentTestChanged();
    partial void OnModelEncodingNumberChanging(System.Nullable<int> value);
    partial void OnModelEncodingNumberChanged();
    partial void OnZplFileChanging(string value);
    partial void OnZplFileChanged();
    partial void OnEnableReadProtectOnDeviceChanging(bool value);
    partial void OnEnableReadProtectOnDeviceChanged();
    #endregion
		
		public Product()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelString", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ModelString
		{
			get
			{
				return this._ModelString;
			}
			set
			{
				if ((this._ModelString != value))
				{
					this.OnModelStringChanging(value);
					this.SendPropertyChanging();
					this._ModelString = value;
					this.SendPropertyChanged("ModelString");
					this.OnModelStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Released", DbType="Bit")]
		public System.Nullable<bool> Released
		{
			get
			{
				return this._Released;
			}
			set
			{
				if ((this._Released != value))
				{
					this.OnReleasedChanging(value);
					this.SendPropertyChanging();
					this._Released = value;
					this.SendPropertyChanged("Released");
					this.OnReleasedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BoardId", DbType="Int NOT NULL")]
		public int BoardId
		{
			get
			{
				return this._BoardId;
			}
			set
			{
				if ((this._BoardId != value))
				{
					this.OnBoardIdChanging(value);
					this.SendPropertyChanging();
					this._BoardId = value;
					this.SendPropertyChanged("BoardId");
					this.OnBoardIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumberCode", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string SerialNumberCode
		{
			get
			{
				return this._SerialNumberCode;
			}
			set
			{
				if ((this._SerialNumberCode != value))
				{
					this.OnSerialNumberCodeChanging(value);
					this.SendPropertyChanging();
					this._SerialNumberCode = value;
					this.SendPropertyChanged("SerialNumberCode");
					this.OnSerialNumberCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZigbeeModelString", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ZigbeeModelString
		{
			get
			{
				return this._ZigbeeModelString;
			}
			set
			{
				if ((this._ZigbeeModelString != value))
				{
					this.OnZigbeeModelStringChanging(value);
					this.SendPropertyChanging();
					this._ZigbeeModelString = value;
					this.SendPropertyChanged("ZigbeeModelString");
					this.OnZigbeeModelStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtensionId", DbType="Int NOT NULL")]
		public int ExtensionId
		{
			get
			{
				return this._ExtensionId;
			}
			set
			{
				if ((this._ExtensionId != value))
				{
					this.OnExtensionIdChanging(value);
					this.SendPropertyChanging();
					this._ExtensionId = value;
					this.SendPropertyChanged("ExtensionId");
					this.OnExtensionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SKU", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SKU
		{
			get
			{
				return this._SKU;
			}
			set
			{
				if ((this._SKU != value))
				{
					this.OnSKUChanging(value);
					this.SendPropertyChanging();
					this._SKU = value;
					this.SendPropertyChanged("SKU");
					this.OnSKUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentTest", DbType="Bit NOT NULL")]
		public bool CurrentTest
		{
			get
			{
				return this._CurrentTest;
			}
			set
			{
				if ((this._CurrentTest != value))
				{
					this.OnCurrentTestChanging(value);
					this.SendPropertyChanging();
					this._CurrentTest = value;
					this.SendPropertyChanged("CurrentTest");
					this.OnCurrentTestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModelEncodingNumber", DbType="Int")]
		public System.Nullable<int> ModelEncodingNumber
		{
			get
			{
				return this._ModelEncodingNumber;
			}
			set
			{
				if ((this._ModelEncodingNumber != value))
				{
					this.OnModelEncodingNumberChanging(value);
					this.SendPropertyChanging();
					this._ModelEncodingNumber = value;
					this.SendPropertyChanged("ModelEncodingNumber");
					this.OnModelEncodingNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZplFile", DbType="NVarChar(255)")]
		public string ZplFile
		{
			get
			{
				return this._ZplFile;
			}
			set
			{
				if ((this._ZplFile != value))
				{
					this.OnZplFileChanging(value);
					this.SendPropertyChanging();
					this._ZplFile = value;
					this.SendPropertyChanged("ZplFile");
					this.OnZplFileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EnableReadProtectOnDevice", DbType="Bit NOT NULL")]
		public bool EnableReadProtectOnDevice
		{
			get
			{
				return this._EnableReadProtectOnDevice;
			}
			set
			{
				if ((this._EnableReadProtectOnDevice != value))
				{
					this.OnEnableReadProtectOnDeviceChanging(value);
					this.SendPropertyChanging();
					this._EnableReadProtectOnDevice = value;
					this.SendPropertyChanged("EnableReadProtectOnDevice");
					this.OnEnableReadProtectOnDeviceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tester")]
	public partial class Tester : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private System.Nullable<int> _Pin;
		
		private System.DateTime _CreateDate;
		
		private int _Id;
		
		private bool _Active;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPinChanging(System.Nullable<int> value);
    partial void OnPinChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public Tester()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pin", DbType="Int")]
		public System.Nullable<int> Pin
		{
			get
			{
				return this._Pin;
			}
			set
			{
				if ((this._Pin != value))
				{
					this.OnPinChanging(value);
					this.SendPropertyChanging();
					this._Pin = value;
					this.SendPropertyChanged("Pin");
					this.OnPinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
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
