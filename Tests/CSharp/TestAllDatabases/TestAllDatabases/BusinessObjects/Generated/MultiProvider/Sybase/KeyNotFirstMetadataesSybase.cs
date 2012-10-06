/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0319.0
EntitySpaces Driver  : Sybase
Date Generated       : 3/17/2012 4:45:27 AM
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
    public partial class KeyNotFirstMetadata : esMetadata, IMetadata
    {
		static private int RegisterDelegateesSybase()
		{
			// This is only executed once per the life of the application
			lock (typeof(KeyNotFirstMetadata))
			{
				if(KeyNotFirstMetadata.mapDelegates == null)
				{
					KeyNotFirstMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (KeyNotFirstMetadata.meta == null)
				{
					KeyNotFirstMetadata.meta = new KeyNotFirstMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esSybase);
				mapDelegates.Add("esSybase", mapMethod);
				mapMethod("esSybase");
			}
			return 0;	
		}		
		
		private esProviderSpecificMetadata esSybase(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();	
				

				meta.AddTypeMap("SomeText", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("TheKey", new esTypeMap("integer", "System.Int32"));				
				meta.Catalog = "AggregateDB";
				meta.Schema = "DBA";
				meta.Source = "KeyNotFirst";
				meta.Destination = "KeyNotFirst";
				
				meta.spInsert = "proc_KeyNotFirstInsert";				
				meta.spUpdate = "proc_KeyNotFirstUpdate";		
				meta.spDelete = "proc_KeyNotFirstDelete";
				meta.spLoadAll = "proc_KeyNotFirstLoadAll";
				meta.spLoadByPrimaryKey = "proc_KeyNotFirstLoadByPrimaryKey";
				
				m_providerMetadataMaps["esSybase"] = meta;
			}
			
			return m_providerMetadataMaps["esSybase"];
		}
		
		static private int _esSybase = RegisterDelegateesSybase();
    }
}
