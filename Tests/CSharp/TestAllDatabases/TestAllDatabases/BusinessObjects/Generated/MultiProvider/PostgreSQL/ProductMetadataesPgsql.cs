/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : PostgreSQL
Date Generated       : 3/17/2012 4:45:08 AM
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
    public partial class ProductMetadata : esMetadata, IMetadata
    {
		static private int RegisterDelegateesPgsql()
		{
			// This is only executed once per the life of the application
			lock (typeof(ProductMetadata))
			{
				if(ProductMetadata.mapDelegates == null)
				{
					ProductMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProductMetadata.meta == null)
				{
					ProductMetadata.meta = new ProductMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esPgsql);
				mapDelegates.Add("esPgsql", mapMethod);
				mapMethod("esPgsql");
			}
			return 0;	
		}		
		
		private esProviderSpecificMetadata esPgsql(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();	
				

				meta.AddTypeMap("ProductID", new esTypeMap("int8", "System.Int64"));
				meta.AddTypeMap("ProductName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("UnitPrice", new esTypeMap("numeric", "System.Decimal"));
				meta.AddTypeMap("Discontinued", new esTypeMap("bool", "System.Boolean"));

				meta["AutoKeyText"] = @"nextval('""Product_ProductID_seq""'::regclass)";				
				meta.Catalog = "ForeignKeyTest";
				meta.Schema = "public";
				meta.Source = "Product";
				meta.Destination = "Product";
				
				meta.spInsert = "proc_ProductInsert";				
				meta.spUpdate = "proc_ProductUpdate";		
				meta.spDelete = "proc_ProductDelete";
				meta.spLoadAll = "proc_ProductLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProductLoadByPrimaryKey";
				
				m_providerMetadataMaps["esPgsql"] = meta;
			}
			
			return m_providerMetadataMaps["esPgsql"];
		}
		
		static private int _esPgsql = RegisterDelegateesPgsql();
    }
}
