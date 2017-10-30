﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("29c2ac5a-6d4d-4dd9-8eba-25f4244dd788")> 

'Original file name:
'Generation date: 21-May-10 1:47:07 PM
'''<summary>
'''There are no comments for BeaconEntities in the schema.
'''</summary>
Partial Public Class BeaconEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new BeaconEntities object using the connection string found in the 'BeaconEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=BeaconEntities", "BeaconEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new BeaconEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "BeaconEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new BeaconEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "BeaconEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for Beacons in the schema.
    '''</summary>
    Public ReadOnly Property Beacons() As Global.System.Data.Objects.ObjectQuery(Of Beacon)
        Get
            If (Me._Beacons Is Nothing) Then
                Me._Beacons = MyBase.CreateQuery(Of Beacon)("[Beacons]")
            End If
            Return Me._Beacons
        End Get
    End Property
    Private _Beacons As Global.System.Data.Objects.ObjectQuery(Of Beacon)
    '''<summary>
    '''There are no comments for Beacons in the schema.
    '''</summary>
    Public Sub AddToBeacons(ByVal beacon As Beacon)
        MyBase.AddObject("Beacons", beacon)
    End Sub
End Class
'''<summary>
'''There are no comments for BeaconModel.Beacon in the schema.
'''</summary>
'''<KeyProperties>
'''BeaconID
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="BeaconModel", Name:="Beacon"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Beacon
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Beacon object.
    '''</summary>
    '''<param name="beaconID">Initial value of BeaconID.</param>
    Public Shared Function CreateBeacon(ByVal beaconID As Long) As Beacon
        Dim beacon As Beacon = New Beacon
        beacon.BeaconID = beaconID
        Return beacon
    End Function
    '''<summary>
    '''There are no comments for Property BeaconID in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property BeaconID() As Long
        Get
            Return Me._BeaconID
        End Get
        Set
            Me.OnBeaconIDChanging(value)
            Me.ReportPropertyChanging("BeaconID")
            Me._BeaconID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("BeaconID")
            Me.OnBeaconIDChanged
        End Set
    End Property
    Private _BeaconID As Long
    Partial Private Sub OnBeaconIDChanging(ByVal value As Long)
        End Sub
    Partial Private Sub OnBeaconIDChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property BeaconName in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property BeaconName() As String
        Get
            Return Me._BeaconName
        End Get
        Set
            Me.OnBeaconNameChanging(value)
            Me.ReportPropertyChanging("BeaconName")
            Me._BeaconName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("BeaconName")
            Me.OnBeaconNameChanged
        End Set
    End Property
    Private _BeaconName As String
    Partial Private Sub OnBeaconNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnBeaconNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Northing in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Northing() As String
        Get
            Return Me._Northing
        End Get
        Set
            Me.OnNorthingChanging(value)
            Me.ReportPropertyChanging("Northing")
            Me._Northing = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Northing")
            Me.OnNorthingChanged
        End Set
    End Property
    Private _Northing As String
    Partial Private Sub OnNorthingChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnNorthingChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Easting in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Easting() As String
        Get
            Return Me._Easting
        End Get
        Set
            Me.OnEastingChanging(value)
            Me.ReportPropertyChanging("Easting")
            Me._Easting = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Easting")
            Me.OnEastingChanged
        End Set
    End Property
    Private _Easting As String
    Partial Private Sub OnEastingChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnEastingChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Elevation in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Elevation() As String
        Get
            Return Me._Elevation
        End Get
        Set
            Me.OnElevationChanging(value)
            Me.ReportPropertyChanging("Elevation")
            Me._Elevation = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Elevation")
            Me.OnElevationChanged
        End Set
    End Property
    Private _Elevation As String
    Partial Private Sub OnElevationChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnElevationChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Description in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set
            Me.OnDescriptionChanging(value)
            Me.ReportPropertyChanging("Description")
            Me._Description = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Description")
            Me.OnDescriptionChanged
        End Set
    End Property
    Private _Description As String
    Partial Private Sub OnDescriptionChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnDescriptionChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Photo in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Photo() As String
        Get
            Return Me._Photo
        End Get
        Set
            Me.OnPhotoChanging(value)
            Me.ReportPropertyChanging("Photo")
            Me._Photo = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true)
            Me.ReportPropertyChanged("Photo")
            Me.OnPhotoChanged
        End Set
    End Property
    Private _Photo As String
    Partial Private Sub OnPhotoChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnPhotoChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Date in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property [Date]() As Global.System.Nullable(Of Date)
        Get
            Return Me._Date
        End Get
        Set
            Me.OnDateChanging(value)
            Me.ReportPropertyChanging("Date")
            Me._Date = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("Date")
            Me.OnDateChanged
        End Set
    End Property
    Private _Date As Global.System.Nullable(Of Date)
    Partial Private Sub OnDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
    Partial Private Sub OnDateChanged()
        End Sub
End Class
