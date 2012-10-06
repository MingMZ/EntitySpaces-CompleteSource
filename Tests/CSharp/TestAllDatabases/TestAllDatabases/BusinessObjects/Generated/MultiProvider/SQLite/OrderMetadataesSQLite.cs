/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : SQLite
Date Generated       : 3/17/2012 4:45:16 AM
===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using EntitySpaces.Interfaces;
using EntitySpaces.Core;

namespace BusinessObjects
{
    public partial class OrderMetadata : esMetadata, IMetadata
    {
		static private int RegisterDelegateesSQLite()
		{
			// This is only executed once per the life of the application
			lock (typeof(OrderMetadata))
			{
				if(OrderMetadata.mapDelegates == null)
				{
					OrderMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrderMetadata.meta == null)
				{
					OrderMetadata.meta = new OrderMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esSQLite);
				mapDelegates.Add("esSQLite", mapMethod);
				mapMethod("esSQLite");
			}
			return 0;	
		}		
		
		private esProviderSpecificMetadata esSQLite(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();	
				

				meta.AddTypeMap("OrderID", new esTypeMap("integer", "System.Int32"));
				meta.AddTypeMap("CustID", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("CustSub", new esTypeMap("char", "System.String"));
				meta.AddTypeMap("PlacedBy", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("OrderDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("ConcurrencyCheck", new esTypeMap("blob", "System.Byte[]"));
				meta.AddTypeMap("EmployeeID", new esTypeMap("integer", "System.Int32"));				
				meta.Catalog = "main";
				
				meta.Source = "Order";
				meta.Destination = "Order";
				
				meta.spInsert = "proc_OrderInsert";				
				meta.spUpdate = "proc_OrderUpdate";		
				meta.spDelete = "proc_OrderDelete";
				meta.spLoadAll = "proc_OrderLoadAll";
				meta.spLoadByPrimaryKey = "proc_OrderLoadByPrimaryKey";
				
				m_providerMetadataMaps["esSQLite"] = meta;
			}
			
			return m_providerMetadataMaps["esSQLite"];
		}
		
		static private int _esSQLite = RegisterDelegateesSQLite();
    }
}
