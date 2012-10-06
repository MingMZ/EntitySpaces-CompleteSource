
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/23/2012 6:16:23 PM
'===============================================================================

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports System.Linq
Imports System.Data
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery



Namespace BusinessObjects

	' <summary>
	' Encapsulates the 'Territories' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Territories))> _
	<XmlType("Territories")> _	
	Partial Public Class Territories 
		Inherits esTerritories
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Territories()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal territoryID As System.String)
			Dim obj As New Territories()
			obj.TerritoryID = territoryID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal territoryID As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Territories()
			obj.TerritoryID = territoryID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
				
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal entity As Territories) As TerritoriesProxyStub
			Return New TerritoriesProxyStub(entity)
		End Operator

		#End Region
		
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("TerritoriesCollection")> _
	Partial Public Class TerritoriesCollection
		Inherits esTerritoriesCollection
		Implements IEnumerable(Of Territories)
	
		Public Function FindByPrimaryKey(ByVal territoryID As System.String) As Territories
			Return MyBase.SingleOrDefault(Function(e) e.TerritoryID = territoryID)
		End Function

        #Region "Implicit Casts"
		
        Public Shared Widening Operator CType(ByVal coll As TerritoriesCollection) As TerritoriesCollectionProxyStub
            Return New TerritoriesCollectionProxyStub(coll)
        End Operator
        
		#End Region

				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Territories))> _
		Public Class TerritoriesCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of TerritoriesCollection)
			
			Public Shared Widening Operator CType(packet As TerritoriesCollectionWCFPacket) As TerritoriesCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As TerritoriesCollection) As TerritoriesCollectionWCFPacket
				Return New TerritoriesCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "TerritoriesQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class TerritoriesQuery 
		Inherits esTerritoriesQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "TerritoriesQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As TerritoriesQuery) As String
			Return TerritoriesQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As TerritoriesQuery
			Return DirectCast(TerritoriesQuery.SerializeHelper.FromXml(query, GetType(TerritoriesQuery)), TerritoriesQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esTerritories
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal territoryID As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(territoryID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(territoryID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal territoryID As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(territoryID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(territoryID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal territoryID As System.String) As Boolean
		
			Dim query As New TerritoriesQuery()
			query.Where(query.TerritoryID = territoryID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal territoryID As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("TerritoryID", territoryID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Territories.TerritoryID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TerritoryID As System.String
			Get
				Return MyBase.GetSystemString(TerritoriesMetadata.ColumnNames.TerritoryID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TerritoriesMetadata.ColumnNames.TerritoryID, value) Then
					OnPropertyChanged(TerritoriesMetadata.PropertyNames.TerritoryID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Territories.TerritoryDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property TerritoryDescription As System.String
			Get
				Return MyBase.GetSystemString(TerritoriesMetadata.ColumnNames.TerritoryDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(TerritoriesMetadata.ColumnNames.TerritoryDescription, value) Then
					OnPropertyChanged(TerritoriesMetadata.PropertyNames.TerritoryDescription)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Territories.RegionID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RegionID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(TerritoriesMetadata.ColumnNames.RegionID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(TerritoriesMetadata.ColumnNames.RegionID, value) Then
					Me._UpToRegionByRegionID = Nothing
					Me.OnPropertyChanged("UpToRegionByRegionID")
					OnPropertyChanged(TerritoriesMetadata.PropertyNames.RegionID)
				End If
			End Set
		End Property	
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToRegionByRegionID As Region
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TerritoriesMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As TerritoriesQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TerritoriesQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As TerritoriesQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As TerritoriesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As TerritoriesQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esTerritoriesCollection
		Inherits esEntityCollection(Of Territories)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return TerritoriesMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "TerritoriesCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As TerritoriesQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New TerritoriesQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As TerritoriesQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New TerritoriesQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As TerritoriesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, TerritoriesQuery))
		End Sub
		
		#End Region
						
		Private m_query As TerritoriesQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esTerritoriesQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return TerritoriesMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "TerritoryID" 
					Return Me.TerritoryID
				Case "TerritoryDescription" 
					Return Me.TerritoryDescription
				Case "RegionID" 
					Return Me.RegionID
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property TerritoryID As esQueryItem
			Get
				Return New esQueryItem(Me, TerritoriesMetadata.ColumnNames.TerritoryID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TerritoryDescription As esQueryItem
			Get
				Return New esQueryItem(Me, TerritoriesMetadata.ColumnNames.TerritoryDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RegionID As esQueryItem
			Get
				Return New esQueryItem(Me, TerritoriesMetadata.ColumnNames.RegionID, esSystemType.Int32)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class Territories 
		Inherits esTerritories
		
	
		#Region "UpToEmployeesCollection - Many To Many"
		''' <summary>
		''' Many to Many
		''' Foreign Key Name - FK_EmployeeTerritories_Territories
		''' </summary>

		<XmlIgnore()> _
		Public Property UpToEmployeesCollection As EmployeesCollection
		
			Get
				If Me._UpToEmployeesCollection Is Nothing Then
					Me._UpToEmployeesCollection = New EmployeesCollection()
					Me._UpToEmployeesCollection.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("UpToEmployeesCollection", Me._UpToEmployeesCollection)
					If Not Me.es.IsLazyLoadDisabled And Not Me.TerritoryID.Equals(Nothing) Then 
				
						Dim m As New EmployeesQuery("m")
						Dim j As New EmployeeTerritoriesQuery("j")
						m.Select(m)
						m.InnerJoin(j).On(m.EmployeeID = j.EmployeeID)
                        m.Where(j.TerritoryID = Me.TerritoryID)

						Me._UpToEmployeesCollection.Load(m)

					End If
				End If

				Return Me._UpToEmployeesCollection
			End Get
			
			Set(ByVal value As EmployeesCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._UpToEmployeesCollection Is Nothing Then

					Me.RemovePostSave("UpToEmployeesCollection")
					Me._UpToEmployeesCollection = Nothing
					Me.OnPropertyChanged("UpToEmployeesCollection")

				End If
			End Set	
			
		End Property

		''' <summary>
		''' Many to Many Associate
		''' Foreign Key Name - FK_EmployeeTerritories_Territories
		''' </summary>
		Public Sub AssociateEmployeesCollection(entity As Employees)
			If Me._EmployeeTerritoriesCollection Is Nothing Then
				Me._EmployeeTerritoriesCollection = New EmployeeTerritoriesCollection()
				Me._EmployeeTerritoriesCollection.es.Connection.Name = Me.es.Connection.Name
				Me.SetPostSave("EmployeeTerritoriesCollection", Me._EmployeeTerritoriesCollection)
			End If
			
			Dim obj As EmployeeTerritories = Me._EmployeeTerritoriesCollection.AddNew()
			obj.TerritoryID = Me.TerritoryID
			obj.EmployeeID = entity.EmployeeID			
			
		End Sub

		''' <summary>
		''' Many to Many Dissociate
		''' Foreign Key Name - FK_EmployeeTerritories_Territories
		''' </summary>
		Public Sub DissociateEmployeesCollection(entity As Employees)
			If Me._EmployeeTerritoriesCollection Is Nothing Then
				Me._EmployeeTerritoriesCollection = new EmployeeTerritoriesCollection()
				Me._EmployeeTerritoriesCollection.es.Connection.Name = Me.es.Connection.Name
				Me.SetPostSave("EmployeeTerritoriesCollection", Me._EmployeeTerritoriesCollection)
			End If

			Dim obj As EmployeeTerritories = Me._EmployeeTerritoriesCollection.AddNew()
			obj.TerritoryID = Me.TerritoryID
            obj.EmployeeID = entity.EmployeeID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
		End Sub

		Private _UpToEmployeesCollection As EmployeesCollection
		Private _EmployeeTerritoriesCollection As EmployeeTerritoriesCollection
		#End Region

		#Region "EmployeeTerritoriesCollectionByTerritoryID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_EmployeeTerritoriesCollectionByTerritoryID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Territories.EmployeeTerritoriesCollectionByTerritoryID_Delegate)
				map.PropertyName = "EmployeeTerritoriesCollectionByTerritoryID"
				map.MyColumnName = "TerritoryID"
				map.ParentColumnName = "TerritoryID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub EmployeeTerritoriesCollectionByTerritoryID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New TerritoriesQuery(data.NextAlias())
			
			Dim mee As EmployeeTerritoriesQuery = If(data.You IsNot Nothing, TryCast(data.You, EmployeeTerritoriesQuery), New EmployeeTerritoriesQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.TerritoryID = mee.TerritoryID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_EmployeeTerritories_Territories
		''' </summary>

		<XmlIgnore()> _ 
		Public Property EmployeeTerritoriesCollectionByTerritoryID As EmployeeTerritoriesCollection 
		
			Get
				If Me._EmployeeTerritoriesCollectionByTerritoryID Is Nothing Then
					Me._EmployeeTerritoriesCollectionByTerritoryID = New EmployeeTerritoriesCollection()
					Me._EmployeeTerritoriesCollectionByTerritoryID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("EmployeeTerritoriesCollectionByTerritoryID", Me._EmployeeTerritoriesCollectionByTerritoryID)
				
					If Not Me.TerritoryID.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._EmployeeTerritoriesCollectionByTerritoryID.Query.Where(Me._EmployeeTerritoriesCollectionByTerritoryID.Query.TerritoryID = Me.TerritoryID)
							Me._EmployeeTerritoriesCollectionByTerritoryID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._EmployeeTerritoriesCollectionByTerritoryID.fks.Add(EmployeeTerritoriesMetadata.ColumnNames.TerritoryID, Me.TerritoryID)
					End If
				End If

				Return Me._EmployeeTerritoriesCollectionByTerritoryID
			End Get
			
			Set(ByVal value As EmployeeTerritoriesCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._EmployeeTerritoriesCollectionByTerritoryID Is Nothing Then

					Me.RemovePostSave("EmployeeTerritoriesCollectionByTerritoryID")
					Me._EmployeeTerritoriesCollectionByTerritoryID = Nothing
					Me.OnPropertyChanged("EmployeeTerritoriesCollectionByTerritoryID")

				End If
			End Set				
			
		End Property
		

		private _EmployeeTerritoriesCollectionByTerritoryID As EmployeeTerritoriesCollection
		#End Region

		#Region "UpToRegionByRegionID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_Territories_Region
		''' </summary>

		<XmlIgnore()> _		
		Public Property UpToRegionByRegionID As Region
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToRegionByRegionID Is Nothing _
						 AndAlso Not RegionID.Equals(Nothing)  Then
						
					Me._UpToRegionByRegionID = New Region()
					Me._UpToRegionByRegionID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToRegionByRegionID", Me._UpToRegionByRegionID)
					Me._UpToRegionByRegionID.Query.Where(Me._UpToRegionByRegionID.Query.RegionID = Me.RegionID)
					Me._UpToRegionByRegionID.Query.Load()
				End If

				Return Me._UpToRegionByRegionID
			End Get
			
            Set(ByVal value As Region)
				Me.RemovePreSave("UpToRegionByRegionID")
				
				Dim changed as Boolean = Me._UpToRegionByRegionID IsNot value

				If value Is Nothing Then
				
					Me.RegionID = Nothing
				
					Me._UpToRegionByRegionID = Nothing
				Else
				
					Me.RegionID = value.RegionID
					
					Me._UpToRegionByRegionID = value
					Me.SetPreSave("UpToRegionByRegionID", Me._UpToRegionByRegionID)
				End If
				
				If changed Then
					Me.OnPropertyChanged("UpToRegionByRegionID")
				End If
			End Set	

		End Property
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "EmployeeTerritoriesCollectionByTerritoryID"
					coll = Me.EmployeeTerritoriesCollectionByTerritoryID
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "EmployeeTerritoriesCollectionByTerritoryID", GetType(EmployeeTerritoriesCollection), New EmployeeTerritories()))
			Return props
			
		End Function
	End Class
		



    <DataContract(Namespace:="http://tempuri.org/", Name:="Territories")> _
    <XmlType(TypeName:="TerritoriesProxyStub")> _
    <Serializable> _
    Partial Public Class TerritoriesProxyStub
	
		Public Sub New()
            Me._entity = New Territories()
            Me.theEntity = Me._entity
		End Sub
		
		Public Sub New(ByVal obj As Territories)
            Me.Entity = obj
            Me.theEntity = Me._entity
		End Sub
		
		Public Sub New(ByVal obj As Territories, ByVal dirtyColumnsOnly As Boolean)
            Me.Entity = obj
            Me.theEntity = Me._entity
			Me.dirtyColumnsOnly = dirtyColumnsOnly
		End Sub	
		
			
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal entity As TerritoriesProxyStub) As Territories
			Return entity.Entity
		End Operator

		#End Region			

        Public Function GetEntityType() As Type
 	        Return GetType(Territories)
        End Function
		

		<DataMember(Name:="a0", Order:=1, EmitDefaultValue:=False)> _		
        Public Property TerritoryID As System.String
        
            Get
				If Me.Entity.es.IsDeleted Then
                    Dim o As Object = Me.Entity. _
                       GetOriginalColumnValue(TerritoriesMetadata.ColumnNames.TerritoryID)
					Return CType(o, System.String)
                Else
					Return Me.Entity.TerritoryID
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.TerritoryID = value
			End Set
			
		End Property

		<DataMember(Name:="a1", Order:=2, EmitDefaultValue:=False)> _		
        Public Property TerritoryDescription As System.String
        
            Get
                If Me.IncludeColumn(TerritoriesMetadata.ColumnNames.TerritoryDescription) Then
                    Return Me.Entity.TerritoryDescription
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.TerritoryDescription = value
			End Set
			
		End Property

		<DataMember(Name:="a2", Order:=3, EmitDefaultValue:=False)> _		
        Public Property RegionID As Nullable(Of System.Int32)
        
            Get
                If Me.IncludeColumn(TerritoriesMetadata.ColumnNames.RegionID) Then
                    Return Me.Entity.RegionID
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As Nullable(Of System.Int32))
				Me.Entity.RegionID = value
			End Set
			
		End Property


		<DataMember(Name := "a10000", Order := 10000)> _
        Public Property esRowState As String
            Get
				Return Me.TheRowState
            End Get

            Set 
				Me.TheRowState = value
            End Set
        End Property
		
		<DataMember(Name := "a10001", Order := 10001, EmitDefaultValue := False)> _
		Private Property ModifiedColumns() As List(Of String)
			Get
				Return Entity.es.ModifiedColumns
			End Get
			Set(ByVal value As List(Of String))
				Entity.es.ModifiedColumns.AddRange(value)
			End Set
		End Property		
		
		<DataMember(Name := "a10002", Order := 10002, EmitDefaultValue := False)> _
        <XmlIgnore> _		
		Public Property esExtraColumns() As Dictionary(Of String, Object)
			Get
				Return Entity.GetExtraColumns()
			End Get
			Set(ByVal value As Dictionary(Of String, Object))
				Entity.SetExtraColumns(value)
			End Set
		End Property
		
		<XmlArray("_x_ExtraColumns")> _
		<XmlArrayItem("_x_ExtraColumns", Type := GetType(DictionaryEntry))> _
		Public Property _x_ExtraColumns() As DictionaryEntry()
			Get
				Dim extra As Dictionary(Of String, Object) = Entity.GetExtraColumns()

				' Make an array of DictionaryEntries to return   
				Dim ret As DictionaryEntry() = New DictionaryEntry(extra.Count - 1) {}
				Dim i As Integer = 0
				Dim de As DictionaryEntry

				' Iterate through the extra columns to load items into the array.   
				For Each kv As KeyValuePair(Of String, Object) In extra
					de = New DictionaryEntry()
					de.Key = kv.Key
					de.Value = kv.Value
					ret(i) = de
					i += 1
				Next
				Return ret
			End Get
			Set
				Dim extra As New Dictionary(Of String, Object)()
				For i As Integer = 0 To value.Length - 1
					extra.Add(DirectCast(value(i).Key, String), CInt(value(i).Value))
				Next
				Entity.SetExtraColumns(extra)
			End Set
		End Property
		
        <XmlIgnore> _		
        Public Property Entity As Territories
        
            Get
                If Me._entity Is Nothing Then
                    Me.entity = New Territories()
					Me.theEntity = Me._entity					
                End If

                Return _entity
            End Get

            Set
                Me._entity = value
            End Set
        End Property
		
		Protected Property TheRowState() As String
			Get
				Return theEntity.es.RowState.ToString()
			End Get
			
			Set(ByVal value As String)
				Select Case value
					Case "Unchanged"
						theEntity.AcceptChanges()
						Exit Select
					
					Case "Added"
						theEntity.AcceptChanges()
						theEntity.es.RowState = esDataRowState.Added
						Exit Select
					
					Case "Modified"
						theEntity.AcceptChanges()
						theEntity.es.RowState = esDataRowState.Modified
						Exit Select
					
					Case "Deleted"
						theEntity.AcceptChanges()
						theEntity.MarkAsDeleted()
						Exit Select
				End Select
			End Set
		End Property	
		
		Protected Function IncludeColumn(ByVal columnName As String) As Boolean
			Dim include As Boolean = False
			
			If dirtyColumnsOnly Then
				If theEntity.es.ModifiedColumns IsNot Nothing AndAlso theEntity.es.ModifiedColumns.Contains(columnName) Then
					include = True
				End If
			ElseIf Not theEntity.es.IsDeleted Then
				include = True
			End If
			
			Return include
		End Function	

        <NonSerialized(), XmlIgnore(), CLSCompliant(False)> _
        Public _entity As Territories
		
        <NonSerialized(), XmlIgnore(), CLSCompliant(False)> _
        Protected theEntity As esEntity

        <NonSerialized(), XmlIgnore()> _
        Protected dirtyColumnsOnly As Boolean		

	End Class
	



    <DataContract(Namespace:="http://tempuri.org/", Name:="TerritoriesCollection")> _
    <XmlType(TypeName:="TerritoriesCollectionProxyStub")> _
    <Serializable> _
    Partial Public Class TerritoriesCollectionProxyStub
	
		Protected Sub New()
			
		End Sub	
		
		Public Sub New(ByVal coll As esEntityCollection(Of Territories))
			Me.New(coll, False, False)
		End Sub

		Public Sub New(ByVal coll As esEntityCollection(Of Territories), ByVal dirtyRowsOnly As Boolean)
			Me.New(coll, dirtyRowsOnly, False)
		End Sub
		
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal proxyStubCollection As TerritoriesCollectionProxyStub) As TerritoriesCollection
			Return proxyStubCollection.GetCollection()
		End Operator

		#End Region	
		
        Public Function GetEntityType() As Type
 	        Return GetType(Territories)
        End Function
		
		Public Sub New(ByVal coll As esEntityCollection(Of Territories), ByVal dirtyRowsOnly As Boolean, ByVal dirtyColumnsOnly As Boolean)

            For Each entity As Territories In coll
                Select Case entity.RowState
                    Case esDataRowState.Added, esDataRowState.Modified

                        Collection.Add(New TerritoriesProxyStub(entity, dirtyColumnsOnly))
                        Exit Select

                    Case esDataRowState.Unchanged

                        If Not dirtyRowsOnly Then
                            Collection.Add(New TerritoriesProxyStub(entity, dirtyColumnsOnly))
                        End If
                        Exit Select
                End Select
            Next

            If coll.es.DeletedEntities IsNot Nothing Then
                For Each entity As Territories In coll.es.DeletedEntities
                    Collection.Add(New TerritoriesProxyStub(entity, dirtyColumnsOnly))
                Next
            End If

        End Sub		

        <DataMember(Name := "Collection", EmitDefaultValue := False)> _
		Public Collection As New List(Of TerritoriesProxyStub)		

        Public Function GetCollection As TerritoriesCollection
			
                If Me._coll is Nothing Then
                    Me._coll = New TerritoriesCollection()
					
		            Dim proxy As TerritoriesProxyStub

                    For Each proxy In Me.Collection
                        Me._coll.AttachEntity(proxy.Entity)
                    Next
                End If

                Return Me._coll

        End Function

        <NonSerialized> _
		<XmlIgnore> _
        Private _coll As TerritoriesCollection
		
    End Class
	



	<Serializable> _
	Partial Public Class TerritoriesMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(TerritoriesMetadata.ColumnNames.TerritoryID, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = TerritoriesMetadata.PropertyNames.TerritoryID
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 20
			m_columns.Add(c)
				
			c = New esColumnMetadata(TerritoriesMetadata.ColumnNames.TerritoryDescription, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = TerritoriesMetadata.PropertyNames.TerritoryDescription
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
			c = New esColumnMetadata(TerritoriesMetadata.ColumnNames.RegionID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = TerritoriesMetadata.PropertyNames.RegionID
			c.NumericPrecision = 10
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As TerritoriesMetadata
			Return _meta
		End Function
		
		Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
			Get
				Return MyBase.m_dataID
			End Get
		End Property

		Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
			Get
				Return false
			End Get
		End Property

		Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
			Get
				Return MyBase.m_columns
			End Get
		End Property

#Region "ColumnNames"
		Public Class ColumnNames
			 Public Const TerritoryID As String = "TerritoryID"
			 Public Const TerritoryDescription As String = "TerritoryDescription"
			 Public Const RegionID As String = "RegionID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const TerritoryID As String = "TerritoryID"
			 Public Const TerritoryDescription As String = "TerritoryDescription"
			 Public Const RegionID As String = "RegionID"
		End Class
#End Region	

		Public Function GetProviderMetadata(ByVal mapName As String) As esProviderSpecificMetadata _
			Implements IMetadata.GetProviderMetadata

			Dim mapMethod As MapToMeta = mapDelegates(mapName)

			If (Not mapMethod = Nothing) Then
				Return mapMethod(mapName)
			Else
				Return Nothing
			End If

		End Function
		
#Region "MAP esDefault"

		Private Shared Function RegisterDelegateesDefault() As Integer
		
			' This is only executed once per the life of the application
			SyncLock GetType(TerritoriesMetadata)
			
				If TerritoriesMetadata.mapDelegates Is Nothing Then
					TerritoriesMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If TerritoriesMetadata._meta Is Nothing Then
					TerritoriesMetadata._meta = New TerritoriesMetadata()
				End If

				Dim mapMethod As New MapToMeta(AddressOf _meta.esDefault)
				mapDelegates.Add("esDefault", mapMethod)
				mapMethod("esDefault")
				Return 0

			End SyncLock
			
		End Function

		Private Function esDefault(ByVal mapName As String) As esProviderSpecificMetadata

			If (Not m_providerMetadataMaps.ContainsKey(mapName)) Then
			
				Dim meta As esProviderSpecificMetadata = New esProviderSpecificMetadata()
				


				meta.AddTypeMap("TerritoryID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("TerritoryDescription", new esTypeMap("nchar", "System.String"))
				meta.AddTypeMap("RegionID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "Territories"
				meta.Destination = "Territories"
				
				meta.spInsert = "proc_TerritoriesInsert"
				meta.spUpdate = "proc_TerritoriesUpdate"
				meta.spDelete = "proc_TerritoriesDelete"
				meta.spLoadAll = "proc_TerritoriesLoadAll"
				meta.spLoadByPrimaryKey = "proc_TerritoriesLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As TerritoriesMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
