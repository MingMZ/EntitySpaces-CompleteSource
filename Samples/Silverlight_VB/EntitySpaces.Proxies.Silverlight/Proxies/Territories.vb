'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/23/2012 6:16:24 PM
'===============================================================================

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Text
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports EntitySpaces.DynamicQuery

Namespace Proxies

	<DataContract(Namespace:="http://tempuri.org/", Name:="TerritoriesCollection")> _
	<XmlType(TypeName:="TerritoriesCollectionProxyStub")> _	
	Partial Public Class TerritoriesCollectionProxyStub 

		Public Sub New() 
		
		End Sub
		
		<DataMember(Name:="Collection", EmitDefaultValue:=False)> _
		Public Collection As New ObservableCollection (Of TerritoriesProxyStub)
		
		Public Function IsDirty() As Boolean
			For Each obj As TerritoriesProxyStub In Collection
				If obj.IsDirty() Then
					Return True
				End If
			Next
			Return False
		End Function
	

	End Class
	
	<DataContract(Namespace:="http://tempuri.org/", Name:="Territories")> _
	<XmlType(TypeName:="TerritoriesProxyStub")> _	
	Partial Public Class TerritoriesProxyStub
		Implements System.ComponentModel.INotifyPropertyChanged
		
		Public Sub New()
			Me.esRowState = "Added"
		End Sub
		
		Public Function IsDirty() As Boolean
			Return If(esRowState <> "Unchanged", True, False)
		End Function
		
		Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Sub RaisePropertyChanged(ByVal propertyName As String)
			Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
			If (Not (propertyChanged) Is Nothing) Then
				propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		
		<DataMember(Name:="a0", Order:=1, EmitDefaultValue:=False)> _
        Public Property TerritoryID As System.String
			Get
				Return _TerritoryID
			End Get
			Set(ByVal value As System.String)
				If Not String.Compare(_TerritoryID, value) = 0 Then
					_TerritoryID = value
					SetDirty("TerritoryID")
					RaisePropertyChanged("TerritoryID")
				End If
			End Set
		End Property
		Private _TerritoryID As System.String
		<DataMember(Name:="a1", Order:=2, EmitDefaultValue:=False)> _
        Public Property TerritoryDescription As System.String
			Get
				Return _TerritoryDescription
			End Get
			Set(ByVal value As System.String)
				If Not String.Compare(_TerritoryDescription, value) = 0 Then
					_TerritoryDescription = value
					SetDirty("TerritoryDescription")
					RaisePropertyChanged("TerritoryDescription")
				End If
			End Set
		End Property
		Private _TerritoryDescription As System.String
		<DataMember(Name:="a2", Order:=3, EmitDefaultValue:=False)> _
        Public Property RegionID As Nullable(Of System.Int32)
			Get
				Return _RegionID
			End Get
			Set(ByVal value As Nullable(Of System.Int32))
				If Not _RegionID.Equals(value) Then
					_RegionID = value
					SetDirty("RegionID")
					RaisePropertyChanged("RegionID")
				End If
			End Set
		End Property
		Private _RegionID As Nullable(Of System.Int32)
		
		

		<DataMember(Name:="a10000", Order:=10000)> _
		Public Property esRowState As String
			Get
				Return Me._esRowState
			End Get
			Set
				If Not String.Compare(_esRowState, value) = 0 Then
					Me._esRowState = value
					RaisePropertyChanged("esRowState")
				End If
			End Set
		End Property
		Private _esRowState As String = "Unchanged"
		
		<DataMember(Name := "a10001", Order := 10001, EmitDefaultValue := False)> _		
		Public Property ModifiedColumns() As List(Of String)
			Get
				If _ModifiedColumns Is Nothing Then
					_ModifiedColumns = New List(Of String)()
				End If
				Return _ModifiedColumns
			End Get
			Set(ByVal value As List(Of String))
				_ModifiedColumns = New List(Of String)(value)
			End Set
		End Property
		Private _ModifiedColumns As List(Of String)

		<DataMember(Name := "a10002", Order := 10002, EmitDefaultValue := False)> _
		Public Property esExtraColumns() As Dictionary(Of String, Object)
			Get
				If _ExtraColumns Is Nothing Then
					_ExtraColumns = New Dictionary(Of String, Object)()
				End If
				Return _ExtraColumns
			End Get
			Set(ByVal value As Dictionary(Of String, Object))
				_ExtraColumns = New Dictionary(Of String, Object)(value)
			End Set
		End Property
		Private _ExtraColumns As Dictionary(Of String, Object)

		Public Sub MarkAsDeleted()
			Me.esRowState = "Deleted"
		End Sub

		Private Sub SetDirty(ByVal [property] As String)
			If Not ModifiedColumns.Contains([property]) Then
				ModifiedColumns.Add([property])
			End If
			
			If Me.esRowState = "Unchanged" Then
				Me.esRowState = "Modified"
			End If
		End Sub
		
	End Class
	
	<XmlType(TypeName:="TerritoriesQueryProxyStub")> _	
	<DataContract(Name:="TerritoriesQuery", Namespace:= "http://www.entityspaces.net")> _	
	Partial Public Class TerritoriesQueryProxyStub 
		Inherits esDynamicQuerySerializable

		Public Sub New()
		
		End Sub

		Public Sub New(ByVal joinAlias As String)
			MyBase.es.JoinAlias = joinAlias
		End Sub	
		
		
		Protected Overrides Function GetQueryName() As String
			Return "TerritoriesQuery"
		End Function

		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal query As TerritoriesQueryProxyStub) As String
			Return TerritoriesQueryProxyStub.SerializeHelper.ToXml(query)
		End Operator

		#End Region
		

		Public ReadOnly Property TerritoryID As esQueryItem
			Get
				Return new esQueryItem(Me, "TerritoryID", esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TerritoryDescription As esQueryItem
			Get
				Return new esQueryItem(Me, "TerritoryDescription", esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RegionID As esQueryItem
			Get
				Return new esQueryItem(Me, "RegionID", esSystemType.Int32)
			End Get
		End Property 
		
	
	End Class
	
End Namespace
