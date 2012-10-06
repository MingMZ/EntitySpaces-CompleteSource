
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : SQL
Date Generated       : 3/17/2012 4:43:28 AM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'EmployeeTerritories' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(EmployeeTerritories))]	
	[XmlType("EmployeeTerritories")]
	[Table(Name="EmployeeTerritories")]
	public partial class EmployeeTerritories : esEmployeeTerritories
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new EmployeeTerritories();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 employeeID, System.String territoryID)
		{
			var obj = new EmployeeTerritories();
			obj.EmployeeID = employeeID;
			obj.TerritoryID = territoryID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 employeeID, System.String territoryID, esSqlAccessType sqlAccessType)
		{
			var obj = new EmployeeTerritories();
			obj.EmployeeID = employeeID;
			obj.TerritoryID = territoryID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		#region Implicit Casts

		public static implicit operator EmployeeTerritoriesProxyStub(EmployeeTerritories entity)
		{
			return new EmployeeTerritoriesProxyStub(entity);
		}

		#endregion
		
					
		

		#region LINQtoSQL overrides (shame but we must do this)

			
		[Column(IsPrimaryKey = true, CanBeNull = false)]
		public override System.Int32? EmployeeID
		{
			get { return base.EmployeeID;  }
			set { base.EmployeeID = value; }
		}

			
		[Column(IsPrimaryKey = true, CanBeNull = false)]
		public override System.String TerritoryID
		{
			get { return base.TerritoryID;  }
			set { base.TerritoryID = value; }
		}


		#endregion
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[DebuggerVisualizer(typeof(EntitySpaces.DebuggerVisualizer.esVisualizer))]
	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeeTerritoriesCollection")]
	public partial class EmployeeTerritoriesCollection : esEmployeeTerritoriesCollection, IEnumerable<EmployeeTerritories>
	{
		public EmployeeTerritories FindByPrimaryKey(System.Int32 employeeID, System.String territoryID)
		{
			return this.SingleOrDefault(e => e.EmployeeID == employeeID && e.TerritoryID == territoryID);
		}

		#region Implicit Casts
		
		public static implicit operator EmployeeTerritoriesCollectionProxyStub(EmployeeTerritoriesCollection coll)
		{
			return new EmployeeTerritoriesCollectionProxyStub(coll);
		}
		
		#endregion
		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(EmployeeTerritories))]
		public class EmployeeTerritoriesCollectionWCFPacket : esCollectionWCFPacket<EmployeeTerritoriesCollection>
		{
			public static implicit operator EmployeeTerritoriesCollection(EmployeeTerritoriesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator EmployeeTerritoriesCollectionWCFPacket(EmployeeTerritoriesCollection collection)
			{
				return new EmployeeTerritoriesCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]
	[DataContract(Name = "EmployeeTerritoriesQuery", Namespace = "http://www.entityspaces.net")]	
	public partial class EmployeeTerritoriesQuery : esEmployeeTerritoriesQuery
	{
		public EmployeeTerritoriesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "EmployeeTerritoriesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeeTerritoriesQuery query)
		{
			return EmployeeTerritoriesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeeTerritoriesQuery(string query)
		{
			return (EmployeeTerritoriesQuery)EmployeeTerritoriesQuery.SerializeHelper.FromXml(query, typeof(EmployeeTerritoriesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployeeTerritories : EntityBase
	{
		public esEmployeeTerritories()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 employeeID, System.String territoryID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeID, territoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeID, territoryID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 employeeID, System.String territoryID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeID, territoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeID, territoryID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 employeeID, System.String territoryID)
		{
			EmployeeTerritoriesQuery query = new EmployeeTerritoriesQuery();
			query.Where(query.EmployeeID == employeeID, query.TerritoryID == territoryID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 employeeID, System.String territoryID)
		{
			esParameters parms = new esParameters();
			parms.Add("EmployeeID", employeeID);			parms.Add("TerritoryID", territoryID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to EmployeeTerritories.EmployeeID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EmployeeID
		{
			get
			{
				return base.GetSystemInt32(EmployeeTerritoriesMetadata.ColumnNames.EmployeeID);
			}
			
			set
			{
				if(base.SetSystemInt32(EmployeeTerritoriesMetadata.ColumnNames.EmployeeID, value))
				{
					this._UpToEmployeesByEmployeeID = null;
					this.OnPropertyChanged("UpToEmployeesByEmployeeID");
					OnPropertyChanged(EmployeeTerritoriesMetadata.PropertyNames.EmployeeID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EmployeeTerritories.TerritoryID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TerritoryID
		{
			get
			{
				return base.GetSystemString(EmployeeTerritoriesMetadata.ColumnNames.TerritoryID);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeTerritoriesMetadata.ColumnNames.TerritoryID, value))
				{
					this._UpToTerritoriesByTerritoryID = null;
					this.OnPropertyChanged("UpToTerritoriesByTerritoryID");
					OnPropertyChanged(EmployeeTerritoriesMetadata.PropertyNames.TerritoryID);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected Employees _UpToEmployeesByEmployeeID;
		[CLSCompliant(false)]
		internal protected Territories _UpToTerritoriesByTerritoryID;
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "EmployeeID": this.str().EmployeeID = (string)value; break;							
						case "TerritoryID": this.str().TerritoryID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "EmployeeID":
						
							if (value == null || value is System.Int32)
								this.EmployeeID = (System.Int32?)value;
								OnPropertyChanged(EmployeeTerritoriesMetadata.PropertyNames.EmployeeID);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esEmployeeTerritories entity)
			{
				this.entity = entity;
			}
			
	
			public System.String EmployeeID
			{
				get
				{
					System.Int32? data = entity.EmployeeID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EmployeeID = null;
					else entity.EmployeeID = Convert.ToInt32(value);
				}
			}
				
			public System.String TerritoryID
			{
				get
				{
					System.String data = entity.TerritoryID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TerritoryID = null;
					else entity.TerritoryID = Convert.ToString(value);
				}
			}
			

			private esEmployeeTerritories entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeeTerritoriesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeeTerritoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeTerritoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeTerritoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeeTerritoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeeTerritoriesQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeeTerritoriesCollection : CollectionBase<EmployeeTerritories>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeTerritoriesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeeTerritoriesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeeTerritoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeTerritoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeTerritoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeeTerritoriesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeeTerritoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeeTerritoriesQuery)query);
		}

		#endregion
		
		private EmployeeTerritoriesQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeeTerritoriesQuery : QueryBase
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeTerritoriesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "EmployeeID": return this.EmployeeID;
				case "TerritoryID": return this.TerritoryID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem EmployeeID
		{
			get { return new esQueryItem(this, EmployeeTerritoriesMetadata.ColumnNames.EmployeeID, esSystemType.Int32); }
		} 
		
		public esQueryItem TerritoryID
		{
			get { return new esQueryItem(this, EmployeeTerritoriesMetadata.ColumnNames.TerritoryID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class EmployeeTerritories : esEmployeeTerritories
	{

				
		#region UpToEmployeesByEmployeeID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_EmployeeTerritories_Employees
		/// </summary>

		[XmlIgnore]
					
		public Employees UpToEmployeesByEmployeeID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToEmployeesByEmployeeID == null && EmployeeID != null)
				{
					this._UpToEmployeesByEmployeeID = new Employees();
					this._UpToEmployeesByEmployeeID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToEmployeesByEmployeeID", this._UpToEmployeesByEmployeeID);
					this._UpToEmployeesByEmployeeID.Query.Where(this._UpToEmployeesByEmployeeID.Query.EmployeeID == this.EmployeeID);
					this._UpToEmployeesByEmployeeID.Query.Load();
				}	
				return this._UpToEmployeesByEmployeeID;
			}
			
			set
			{
				this.RemovePreSave("UpToEmployeesByEmployeeID");
				
				bool changed = this._UpToEmployeesByEmployeeID != value;

				if(value == null)
				{
					this.EmployeeID = null;
					this._UpToEmployeesByEmployeeID = null;
				}
				else
				{
					this.EmployeeID = value.EmployeeID;
					this._UpToEmployeesByEmployeeID = value;
					this.SetPreSave("UpToEmployeesByEmployeeID", this._UpToEmployeesByEmployeeID);
				}
				
				if( changed )
				{
					this.OnPropertyChanged("UpToEmployeesByEmployeeID");
				}
			}
		}
		#endregion
		

				
		#region UpToTerritoriesByTerritoryID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_EmployeeTerritories_Territories
		/// </summary>

		[XmlIgnore]
					
		public Territories UpToTerritoriesByTerritoryID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToTerritoriesByTerritoryID == null && TerritoryID != null)
				{
					this._UpToTerritoriesByTerritoryID = new Territories();
					this._UpToTerritoriesByTerritoryID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToTerritoriesByTerritoryID", this._UpToTerritoriesByTerritoryID);
					this._UpToTerritoriesByTerritoryID.Query.Where(this._UpToTerritoriesByTerritoryID.Query.TerritoryID == this.TerritoryID);
					this._UpToTerritoriesByTerritoryID.Query.Load();
				}	
				return this._UpToTerritoriesByTerritoryID;
			}
			
			set
			{
				this.RemovePreSave("UpToTerritoriesByTerritoryID");
				
				bool changed = this._UpToTerritoriesByTerritoryID != value;

				if(value == null)
				{
					this.TerritoryID = null;
					this._UpToTerritoriesByTerritoryID = null;
				}
				else
				{
					this.TerritoryID = value.TerritoryID;
					this._UpToTerritoriesByTerritoryID = value;
					this.SetPreSave("UpToTerritoriesByTerritoryID", this._UpToTerritoriesByTerritoryID);
				}
				
				if( changed )
				{
					this.OnPropertyChanged("UpToTerritoriesByTerritoryID");
				}
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._UpToEmployeesByEmployeeID != null)
			{
				this.EmployeeID = this._UpToEmployeesByEmployeeID.EmployeeID;
			}
		}
		
	}
	



	[DataContract(Namespace = "http://tempuri.org/", Name = "EmployeeTerritories")]
	[XmlType(TypeName="EmployeeTerritoriesProxyStub")]	
	[Serializable]
	public partial class EmployeeTerritoriesProxyStub
	{
		public EmployeeTerritoriesProxyStub() 
		{
			theEntity = this.entity = new EmployeeTerritories();
		}

		public EmployeeTerritoriesProxyStub(EmployeeTerritories obj)
		{
			theEntity = this.entity = obj;
		}

		public EmployeeTerritoriesProxyStub(EmployeeTerritories obj, bool dirtyColumnsOnly)
		{
			theEntity = this.entity = obj;
			this.dirtyColumnsOnly = dirtyColumnsOnly;
		}
			
		#region Implicit Casts

		public static implicit operator EmployeeTerritories(EmployeeTerritoriesProxyStub entity)
		{
			return entity.Entity;
		}

		#endregion	
		
		public Type GetEntityType()
		{
			return typeof(EmployeeTerritories);
		}

		[DataMember(Name="a0", Order=1, EmitDefaultValue=false)]
		public System.Int32? EmployeeID
		{
			get 
			{ 
				if (this.Entity.es.IsDeleted)
					return (System.Int32?)this.Entity.
						GetOriginalColumnValue(EmployeeTerritoriesMetadata.ColumnNames.EmployeeID);
				else
					return this.Entity.EmployeeID;
			}
			set { this.Entity.EmployeeID = value; }
		}

		[DataMember(Name="a1", Order=2, EmitDefaultValue=false)]
		public System.String TerritoryID
		{
			get 
			{ 
				if (this.Entity.es.IsDeleted)
					return (System.String)this.Entity.
						GetOriginalColumnValue(EmployeeTerritoriesMetadata.ColumnNames.TerritoryID);
				else
					return this.Entity.TerritoryID;
			}
			set { this.Entity.TerritoryID = value; }
		}


		[DataMember(Name="a10000", Order=10000)]
		public string esRowState
		{
			get { return TheRowState;  }
			set { TheRowState = value; }
		}
		
		[DataMember(Name="a10001", Order=10001, EmitDefaultValue=false)]
		private List<string> ModifiedColumns
		{
			get { return Entity.es.ModifiedColumns; }
			set 
			{ 
				Entity.es.ModifiedColumns.AddRange(value); 
			}
		}
		
		[DataMember(Name="a10002", Order=10002, EmitDefaultValue=false)]
		[XmlIgnore]		
		public Dictionary<string, object> esExtraColumns
		{
			get { return Entity.GetExtraColumns(); }
			set { Entity.SetExtraColumns(value);   }
		}
		
		[XmlArray("_x_ExtraColumns")]
		[XmlArrayItem("_x_ExtraColumns", Type = typeof(DictionaryEntry))]
		public DictionaryEntry[] _x_ExtraColumns
		{
			get
			{
				Dictionary<string, object> extra = Entity.GetExtraColumns();

				// Make an array of DictionaryEntries to return   
				DictionaryEntry[] ret = new DictionaryEntry[extra.Count];
				int i = 0;
				DictionaryEntry de;

				// Iterate through the extra columns to load items into the array.   
				foreach (KeyValuePair<string, object> kv in extra)
				{
					de = new DictionaryEntry();
					de.Key = kv.Key;
					de.Value = kv.Value;
					ret[i] = de;
					i++;
				}
				return ret;
			}
			set
			{
				Dictionary<string, object> extra = new Dictionary<string, object>();
				for (int i = 0; i < value.Length; i++)
				{
					extra.Add((string)value[i].Key, (int)value[i].Value);
				}
				Entity.SetExtraColumns(extra);
			}
		}	

		[XmlIgnore]
		public EmployeeTerritories Entity
		{
			get
			{
				if (this.entity == null)
				{
					theEntity = this.entity = new EmployeeTerritories();
				}

				return this.entity;
			}

			set
			{
				this.entity = value;
			}
		}
		
		protected string TheRowState
		{
			get
			{
				return theEntity.es.RowState.ToString();
			}

			set
			{
				switch (value)
				{
					case "Unchanged":
						theEntity.AcceptChanges();
						break;

					case "Added":
						theEntity.AcceptChanges();
						theEntity.es.RowState = esDataRowState.Added;
						break;

					case "Modified":
						theEntity.AcceptChanges();
						theEntity.es.RowState = esDataRowState.Modified;
						break;

					case "Deleted":
						theEntity.AcceptChanges();
						theEntity.MarkAsDeleted();
						break;
				}
			}
		}		
		
		protected bool IncludeColumn(string columnName)
		{
			bool include = false;

			if (dirtyColumnsOnly)
			{
				if (theEntity.es.ModifiedColumns != null &&
					theEntity.es.ModifiedColumns.Contains(columnName))
				{
					include = true;
				}
			}
			else if (!theEntity.es.IsDeleted)
			{
				include = true;
			}

			return include;
		}		

		[NonSerialized, XmlIgnore, CLSCompliant(false)]
		public EmployeeTerritories entity;
		
		[NonSerialized, XmlIgnore, CLSCompliant(false)]
		protected esEntity theEntity;

		[NonSerialized, XmlIgnore]
		protected bool dirtyColumnsOnly;		
	}



	[DataContract(Namespace = "http://tempuri.org/", Name = "EmployeeTerritoriesCollection")]
	[XmlType(TypeName="EmployeeTerritoriesCollectionProxyStub")]	
	[Serializable]
	public partial class EmployeeTerritoriesCollectionProxyStub 
	{
		protected EmployeeTerritoriesCollectionProxyStub() {}
		
		public EmployeeTerritoriesCollectionProxyStub(esEntityCollection<EmployeeTerritories> coll)
			: this(coll, false, false)
		{
		
		}		
		
		public EmployeeTerritoriesCollectionProxyStub(esEntityCollection<EmployeeTerritories> coll, bool dirtyRowsOnly)
			: this(coll, dirtyRowsOnly, false)
		{

		}	
		
		#region Implicit Casts

		public static implicit operator EmployeeTerritoriesCollection(EmployeeTerritoriesCollectionProxyStub proxyStubCollection)
		{
			return proxyStubCollection.GetCollection();
		}

		#endregion

		public Type GetEntityType()
		{
			return typeof(EmployeeTerritories);
		}
		
		public EmployeeTerritoriesCollectionProxyStub(esEntityCollection<EmployeeTerritories> coll, bool dirtyRowsOnly, bool dirtyColumnsOnly)
		{		
			foreach (EmployeeTerritories entity in coll)
			{
				switch (entity.RowState)
				{
					case esDataRowState.Added:
					case esDataRowState.Modified:

						Collection.Add(new EmployeeTerritoriesProxyStub(entity, dirtyColumnsOnly));
						break;

					case esDataRowState.Unchanged:

						if (!dirtyRowsOnly)
						{
							Collection.Add(new EmployeeTerritoriesProxyStub(entity, dirtyColumnsOnly));
						}
						break;
				}
			}

			if (coll.es.DeletedEntities != null)
			{
				foreach (EmployeeTerritories entity in coll.es.DeletedEntities)
				{
					Collection.Add(new EmployeeTerritoriesProxyStub(entity, dirtyColumnsOnly));
				}
			}
		}		

		[DataMember(Name = "Collection", EmitDefaultValue = false)]
		public List<EmployeeTerritoriesProxyStub> Collection = new List<EmployeeTerritoriesProxyStub>();

		public EmployeeTerritoriesCollection GetCollection()
		{
			if (this._coll == null)
			{
				this._coll = new EmployeeTerritoriesCollection();

				foreach (EmployeeTerritoriesProxyStub proxy in this.Collection)
				{
					this._coll.AttachEntity(proxy.Entity);
				}
			}

			return this._coll;
		}

		[NonSerialized]
		[XmlIgnore]
		private EmployeeTerritoriesCollection _coll;
	}



	[Serializable]
	public partial class EmployeeTerritoriesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeeTerritoriesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeeTerritoriesMetadata.ColumnNames.EmployeeID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = EmployeeTerritoriesMetadata.PropertyNames.EmployeeID;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeTerritoriesMetadata.ColumnNames.TerritoryID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeTerritoriesMetadata.PropertyNames.TerritoryID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeeTerritoriesMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return true; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string EmployeeID = "EmployeeID";
			 public const string TerritoryID = "TerritoryID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string EmployeeID = "EmployeeID";
			 public const string TerritoryID = "TerritoryID";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(EmployeeTerritoriesMetadata))
			{
				if(EmployeeTerritoriesMetadata.mapDelegates == null)
				{
					EmployeeTerritoriesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeeTerritoriesMetadata.meta == null)
				{
					EmployeeTerritoriesMetadata.meta = new EmployeeTerritoriesMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("EmployeeID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TerritoryID", new esTypeMap("nvarchar", "System.String"));			
				meta.Catalog = "Northwind";
				meta.Schema = "dbo";
				
				meta.Source = "EmployeeTerritories";
				meta.Destination = "EmployeeTerritories";
				
				meta.spInsert = "proc_EmployeeTerritoriesInsert";				
				meta.spUpdate = "proc_EmployeeTerritoriesUpdate";		
				meta.spDelete = "proc_EmployeeTerritoriesDelete";
				meta.spLoadAll = "proc_EmployeeTerritoriesLoadAll";
				meta.spLoadByPrimaryKey = "proc_EmployeeTerritoriesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeeTerritoriesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
