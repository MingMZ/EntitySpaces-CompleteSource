/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2012 4:39:38 AM
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
	[DataContract(Namespace = "http://tempuri.org/", Name = "OrderItemCollection")]	
	[XmlType(TypeName = "OrderItemCollectionProxyStub")]	
	[Serializable]	
	public partial class OrderItemCollectionProxyStub 
	{
		public OrderItemCollectionProxyStub() { }
	
		[DataMember(Name = "Collection", EmitDefaultValue = false)]
		public BindingList<OrderItemProxyStub> Collection = new BindingList<OrderItemProxyStub>();
		
		public bool IsDirty()
		{
			foreach (OrderItemProxyStub obj in Collection)
			{
				if (obj.IsDirty()) return true;
			}

			return false;
		}
	}
	
	[DataContract(Namespace = "http://tempuri.org/", Name = "OrderItem")]
	[XmlType(TypeName = "OrderItemProxyStub")]	
	[Serializable]	
	public partial class OrderItemProxyStub : object, System.ComponentModel.INotifyPropertyChanged
	{
		public OrderItemProxyStub()
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
		
		[DataMember(Name="OrderID", Order=1, EmitDefaultValue=false)]
		public System.Int32? OrderID
		{
			get
			{
				return _OrderID;
			}
			set
			{
				if (_OrderID != value)
				{
					_OrderID = value;
					SetDirty("OrderID");
					RaisePropertyChanged("OrderID");
				}
			}
		}
		private System.Int32? _OrderID;
		
		[DataMember(Name="ProductID", Order=2, EmitDefaultValue=false)]
		public System.Int32? ProductID
		{
			get
			{
				return _ProductID;
			}
			set
			{
				if (_ProductID != value)
				{
					_ProductID = value;
					SetDirty("ProductID");
					RaisePropertyChanged("ProductID");
				}
			}
		}
		private System.Int32? _ProductID;
		
		[DataMember(Name="UnitPrice", Order=3, EmitDefaultValue=false)]
		public System.Decimal? UnitPrice
		{
			get
			{
				return _UnitPrice;
			}
			set
			{
				if (_UnitPrice != value)
				{
					_UnitPrice = value;
					SetDirty("UnitPrice");
					RaisePropertyChanged("UnitPrice");
				}
			}
		}
		private System.Decimal? _UnitPrice;
		
		[DataMember(Name="Quantity", Order=4, EmitDefaultValue=false)]
		public System.Int16? Quantity
		{
			get
			{
				return _Quantity;
			}
			set
			{
				if (_Quantity != value)
				{
					_Quantity = value;
					SetDirty("Quantity");
					RaisePropertyChanged("Quantity");
				}
			}
		}
		private System.Int16? _Quantity;
		
		[DataMember(Name="Discount", Order=5, EmitDefaultValue=false)]
		public System.Single? Discount
		{
			get
			{
				return _Discount;
			}
			set
			{
				if (_Discount != value)
				{
					_Discount = value;
					SetDirty("Discount");
					RaisePropertyChanged("Discount");
				}
			}
		}
		private System.Single? _Discount;
		
	
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
	
	[XmlType(TypeName = "OrderItemQueryProxyStub")]	
	[Serializable]	
	[DataContract(Name = "OrderItemQuery", Namespace = "http://www.entityspaces.net")]
	public partial class OrderItemQueryProxyStub : esDynamicQuerySerializable
	{
		public OrderItemQueryProxyStub() { }
		
		public OrderItemQueryProxyStub(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
		override protected string GetQueryName()
		{
			return "OrderItemQuery";
		}
		
		#region Implicit Casts

		public static implicit operator string(OrderItemQueryProxyStub query)
		{
			return Proxies.OrderItemQueryProxyStub.SerializeHelper.ToXml(query);
		}

		#endregion
	
		public esQueryItem OrderID
		{
			get { return new esQueryItem(this, "OrderID", esSystemType.Int32); }
		} 
		
		public esQueryItem ProductID
		{
			get { return new esQueryItem(this, "ProductID", esSystemType.Int32); }
		} 
		
		public esQueryItem UnitPrice
		{
			get { return new esQueryItem(this, "UnitPrice", esSystemType.Decimal); }
		} 
		
		public esQueryItem Quantity
		{
			get { return new esQueryItem(this, "Quantity", esSystemType.Int16); }
		} 
		
		public esQueryItem Discount
		{
			get { return new esQueryItem(this, "Discount", esSystemType.Single); }
		} 
		
	}
}