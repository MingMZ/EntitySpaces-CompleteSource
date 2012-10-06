/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2012 4:39:37 AM
===============================================================================
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.DynamicQuery;

namespace Proxies
{
	[DataContract(Namespace = "http://tempuri.org/", Name = "KeyNotFirstCollection")]	
	[XmlType(TypeName = "KeyNotFirstCollectionProxyStub")]	
	[Serializable]	
	public partial class KeyNotFirstCollectionProxyStub 
	{
		public KeyNotFirstCollectionProxyStub() { }
	
		[DataMember(Name = "Collection", EmitDefaultValue = false)]
		public BindingList<KeyNotFirstProxyStub> Collection = new BindingList<KeyNotFirstProxyStub>();
		
		public bool IsDirty()
		{
			foreach (KeyNotFirstProxyStub obj in Collection)
			{
				if (obj.IsDirty()) return true;
			}

			return false;
		}
	}
	
	[DataContract(Namespace = "http://tempuri.org/", Name = "KeyNotFirst")]
	[XmlType(TypeName = "KeyNotFirstProxyStub")]	
	[Serializable]	
	public partial class KeyNotFirstProxyStub : object, System.ComponentModel.INotifyPropertyChanged
	{
		public KeyNotFirstProxyStub()
		{
			this.esRowState = "Added";
		}
		
		public bool IsDirty()
		{
			return esRowState != "Unchanged" ? true : false;
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) 
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) 
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[DataMember(Name="SomeText", Order=1, EmitDefaultValue=false)]
		public System.String SomeText
		{
			get
			{
				return _SomeText;
			}
			set
			{
				if (_SomeText != value)
				{
					_SomeText = value;
					SetDirty("SomeText");
					RaisePropertyChanged("SomeText");
				}
			}
		}
		private System.String _SomeText;
		
		[DataMember(Name="TheKey", Order=2, EmitDefaultValue=false)]
		public System.Int32? TheKey
		{
			get
			{
				return _TheKey;
			}
			set
			{
				if (_TheKey != value)
				{
					_TheKey = value;
					SetDirty("TheKey");
					RaisePropertyChanged("TheKey");
				}
			}
		}
		private System.Int32? _TheKey;
		
	
		[DataMember(Name="esRowState", Order=10000)]
		public string esRowState
		{
			get { return _esRowState; }
			set 
			{
				if(_esRowState != value)
				{
					_esRowState = value; 
					RaisePropertyChanged("esRowState");
				}
			}
		}
		private string _esRowState = "Unchanged";
		
		[DataMember(Name="ModifiedColumns", Order=10001, EmitDefaultValue=false)]
		public List<string> ModifiedColumns
		{
			get
			{
				if (_ModifiedColumns == null)
				{
					_ModifiedColumns = new List<string>();
				}
				return _ModifiedColumns;
			}
			set
			{
				_ModifiedColumns = new List<string>(value);
			}
		}
		List<string> _ModifiedColumns;
		
		[DataMember(Name="ExtraColumns", Order=10002, EmitDefaultValue=false)]		
		public Dictionary<string, object> esExtraColumns
		{
			get
			{
				if (_ExtraColumns == null)
				{
					_ExtraColumns = new Dictionary<string, object>();
				}
				return _ExtraColumns;
			}
			set
			{
				_ExtraColumns = new Dictionary<string, object>(value);
			}
		}
		Dictionary<string, object> _ExtraColumns;

		public void MarkAsDeleted()
		{
			this.esRowState = "Deleted";
		}

		private void SetDirty(string property)
		{
			if (!ModifiedColumns.Contains(property))
			{
				ModifiedColumns.Add(property);
			}

			if (this.esRowState == "Unchanged")
			{
				this.esRowState = "Modified";
			}
		}
	}
	
	[XmlType(TypeName = "KeyNotFirstQueryProxyStub")]	
	[Serializable]	
	[DataContract(Name = "KeyNotFirstQuery", Namespace = "http://www.entityspaces.net")]
	public partial class KeyNotFirstQueryProxyStub : esDynamicQuerySerializable
	{
		public KeyNotFirstQueryProxyStub() { }
		
		public KeyNotFirstQueryProxyStub(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
		override protected string GetQueryName()
		{
			return "KeyNotFirstQuery";
		}
		
		#region Implicit Casts

		public static implicit operator string(KeyNotFirstQueryProxyStub query)
		{
			return Proxies.KeyNotFirstQueryProxyStub.SerializeHelper.ToXml(query);
		}

		#endregion
	
		public esQueryItem SomeText
		{
			get { return new esQueryItem(this, "SomeText", esSystemType.String); }
		} 
		
		public esQueryItem TheKey
		{
			get { return new esQueryItem(this, "TheKey", esSystemType.Int32); }
		} 
		
	}
}