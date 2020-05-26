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

namespace websitestintuc.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Web")]
	public partial class DataWebTinTucDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void Insertcategory(category instance);
    partial void Updatecategory(category instance);
    partial void Deletecategory(category instance);
    partial void InsertLogo(Logo instance);
    partial void UpdateLogo(Logo instance);
    partial void DeleteLogo(Logo instance);
    partial void InsertTinTuc(TinTuc instance);
    partial void UpdateTinTuc(TinTuc instance);
    partial void DeleteTinTuc(TinTuc instance);
    #endregion
		
		public DataWebTinTucDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataWebTinTucDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataWebTinTucDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataWebTinTucDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataWebTinTucDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<category> categories
		{
			get
			{
				return this.GetTable<category>();
			}
		}
		
		public System.Data.Linq.Table<Logo> Logos
		{
			get
			{
				return this.GetTable<Logo>();
			}
		}
		
		public System.Data.Linq.Table<TinTuc> TinTucs
		{
			get
			{
				return this.GetTable<TinTuc>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _userName;
		
		private string _password;
		
		private string _displayname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OndisplaynameChanging(string value);
    partial void OndisplaynameChanged();
    #endregion
		
		public Account()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(10)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(10)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_displayname", DbType="NVarChar(10)")]
		public string displayname
		{
			get
			{
				return this._displayname;
			}
			set
			{
				if ((this._displayname != value))
				{
					this.OndisplaynameChanging(value);
					this.SendPropertyChanging();
					this._displayname = value;
					this.SendPropertyChanged("displayname");
					this.OndisplaynameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.category")]
	public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _CategoryName;
		
		private EntitySet<TinTuc> _TinTucs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    #endregion
		
		public category()
		{
			this._TinTucs = new EntitySet<TinTuc>(new Action<TinTuc>(this.attach_TinTucs), new Action<TinTuc>(this.detach_TinTucs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_TinTuc", Storage="_TinTucs", ThisKey="ID", OtherKey="IDcategory")]
		public EntitySet<TinTuc> TinTucs
		{
			get
			{
				return this._TinTucs;
			}
			set
			{
				this._TinTucs.Assign(value);
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
		
		private void attach_TinTucs(TinTuc entity)
		{
			this.SendPropertyChanging();
			entity.category = this;
		}
		
		private void detach_TinTucs(TinTuc entity)
		{
			this.SendPropertyChanging();
			entity.category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Logo")]
	public partial class Logo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Image;
		
		private string _SourceName;
		
		private EntitySet<TinTuc> _TinTucs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnSourceNameChanging(string value);
    partial void OnSourceNameChanged();
    #endregion
		
		public Logo()
		{
			this._TinTucs = new EntitySet<TinTuc>(new Action<TinTuc>(this.attach_TinTucs), new Action<TinTuc>(this.detach_TinTucs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(50)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceName", DbType="NVarChar(50)")]
		public string SourceName
		{
			get
			{
				return this._SourceName;
			}
			set
			{
				if ((this._SourceName != value))
				{
					this.OnSourceNameChanging(value);
					this.SendPropertyChanging();
					this._SourceName = value;
					this.SendPropertyChanged("SourceName");
					this.OnSourceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Logo_TinTuc", Storage="_TinTucs", ThisKey="ID", OtherKey="IDlogo")]
		public EntitySet<TinTuc> TinTucs
		{
			get
			{
				return this._TinTucs;
			}
			set
			{
				this._TinTucs.Assign(value);
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
		
		private void attach_TinTucs(TinTuc entity)
		{
			this.SendPropertyChanging();
			entity.Logo = this;
		}
		
		private void detach_TinTucs(TinTuc entity)
		{
			this.SendPropertyChanging();
			entity.Logo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TinTuc")]
	public partial class TinTuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _title;
		
		private string _description;
		
		private System.Nullable<System.DateTime> _dateup;
		
		private System.Nullable<bool> _topList;
		
		private string _Imagedemo;
		
		private string _Link;
		
		private System.Nullable<int> _IDlogo;
		
		private System.Nullable<int> _IDcategory;
		
		private EntityRef<category> _category;
		
		private EntityRef<Logo> _Logo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OndateupChanging(System.Nullable<System.DateTime> value);
    partial void OndateupChanged();
    partial void OntopListChanging(System.Nullable<bool> value);
    partial void OntopListChanged();
    partial void OnImagedemoChanging(string value);
    partial void OnImagedemoChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    partial void OnIDlogoChanging(System.Nullable<int> value);
    partial void OnIDlogoChanged();
    partial void OnIDcategoryChanging(System.Nullable<int> value);
    partial void OnIDcategoryChanged();
    #endregion
		
		public TinTuc()
		{
			this._category = default(EntityRef<category>);
			this._Logo = default(EntityRef<Logo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(50)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateup", DbType="Date")]
		public System.Nullable<System.DateTime> dateup
		{
			get
			{
				return this._dateup;
			}
			set
			{
				if ((this._dateup != value))
				{
					this.OndateupChanging(value);
					this.SendPropertyChanging();
					this._dateup = value;
					this.SendPropertyChanged("dateup");
					this.OndateupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_topList", DbType="Bit")]
		public System.Nullable<bool> topList
		{
			get
			{
				return this._topList;
			}
			set
			{
				if ((this._topList != value))
				{
					this.OntopListChanging(value);
					this.SendPropertyChanging();
					this._topList = value;
					this.SendPropertyChanged("topList");
					this.OntopListChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagedemo", DbType="NVarChar(50)")]
		public string Imagedemo
		{
			get
			{
				return this._Imagedemo;
			}
			set
			{
				if ((this._Imagedemo != value))
				{
					this.OnImagedemoChanging(value);
					this.SendPropertyChanging();
					this._Imagedemo = value;
					this.SendPropertyChanged("Imagedemo");
					this.OnImagedemoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="VarChar(50)")]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDlogo", DbType="Int")]
		public System.Nullable<int> IDlogo
		{
			get
			{
				return this._IDlogo;
			}
			set
			{
				if ((this._IDlogo != value))
				{
					if (this._Logo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDlogoChanging(value);
					this.SendPropertyChanging();
					this._IDlogo = value;
					this.SendPropertyChanged("IDlogo");
					this.OnIDlogoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDcategory", DbType="Int")]
		public System.Nullable<int> IDcategory
		{
			get
			{
				return this._IDcategory;
			}
			set
			{
				if ((this._IDcategory != value))
				{
					if (this._category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDcategoryChanging(value);
					this.SendPropertyChanging();
					this._IDcategory = value;
					this.SendPropertyChanged("IDcategory");
					this.OnIDcategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="category_TinTuc", Storage="_category", ThisKey="IDcategory", OtherKey="ID", IsForeignKey=true)]
		public category category
		{
			get
			{
				return this._category.Entity;
			}
			set
			{
				category previousValue = this._category.Entity;
				if (((previousValue != value) 
							|| (this._category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._category.Entity = null;
						previousValue.TinTucs.Remove(this);
					}
					this._category.Entity = value;
					if ((value != null))
					{
						value.TinTucs.Add(this);
						this._IDcategory = value.ID;
					}
					else
					{
						this._IDcategory = default(Nullable<int>);
					}
					this.SendPropertyChanged("category");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Logo_TinTuc", Storage="_Logo", ThisKey="IDlogo", OtherKey="ID", IsForeignKey=true)]
		public Logo Logo
		{
			get
			{
				return this._Logo.Entity;
			}
			set
			{
				Logo previousValue = this._Logo.Entity;
				if (((previousValue != value) 
							|| (this._Logo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Logo.Entity = null;
						previousValue.TinTucs.Remove(this);
					}
					this._Logo.Entity = value;
					if ((value != null))
					{
						value.TinTucs.Add(this);
						this._IDlogo = value.ID;
					}
					else
					{
						this._IDlogo = default(Nullable<int>);
					}
					this.SendPropertyChanged("Logo");
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