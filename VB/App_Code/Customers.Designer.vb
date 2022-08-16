﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("630c21f0-b908-4663-a06d-4c2ca8292006")>
Namespace NorthwindModel
    
    #Region "Contexts"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public Partial Class NorthwindEntities
        Inherits ObjectContext
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        ''' </summary>
        Public Sub New()
            MyBase.New("name=NorthwindEntities", "NorthwindEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new NorthwindEntities object.
        ''' </summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "NorthwindEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new NorthwindEntities object.
        ''' </summary>
        Public Sub New(ByVal connection As EntityConnection)
            MyBase.New(connection, "NorthwindEntities")
        MyBase.ContextOptions.LazyLoadingEnabled = true
            OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "Partial Methods"
    
        Partial Private Sub OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "ObjectSet Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Customers() As ObjectSet(Of Customer)
            Get
                If (_Customers Is Nothing) Then
                    _Customers = MyBase.CreateObjectSet(Of Customer)("Customers")
                End If
                Return _Customers
            End Get
        End Property
    
        Private _Customers As ObjectSet(Of Customer)

        #End Region
        #Region "AddTo Methods"
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToCustomers(ByVal customer As Customer)
            MyBase.AddObject("Customers", customer)
        End Sub

        #End Region
    End Class

    #End Region
    #Region "Entities"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Customer")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class Customer
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new Customer object.
        ''' </summary>
        ''' <param name="customerID">Initial value of the CustomerID property.</param>
        ''' <param name="companyName">Initial value of the CompanyName property.</param>
        Public Shared Function CreateCustomer(customerID As Global.System.String, companyName As Global.System.String) As Customer
            Dim customer as Customer = New Customer
            customer.CustomerID = customerID
            customer.CompanyName = companyName
            Return customer
        End Function

        #End Region
        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property CustomerID() As Global.System.String
            Get
                Return _CustomerID
            End Get
            Set
                If (_CustomerID <> Value) Then
                    OnCustomerIDChanging(value)
                    ReportPropertyChanging("CustomerID")
                    _CustomerID = StructuralObject.SetValidValue(value, false)
                    ReportPropertyChanged("CustomerID")
                    OnCustomerIDChanged()
                End If
            End Set
        End Property
    
        Private _CustomerID As Global.System.String
        Private Partial Sub OnCustomerIDChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCustomerIDChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property CompanyName() As Global.System.String
            Get
                Return _CompanyName
            End Get
            Set
                OnCompanyNameChanging(value)
                ReportPropertyChanging("CompanyName")
                _CompanyName = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("CompanyName")
                OnCompanyNameChanged()
            End Set
        End Property
    
        Private _CompanyName As Global.System.String
        Private Partial Sub OnCompanyNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCompanyNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property ContactName() As Global.System.String
            Get
                Return _ContactName
            End Get
            Set
                OnContactNameChanging(value)
                ReportPropertyChanging("ContactName")
                _ContactName = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("ContactName")
                OnContactNameChanged()
            End Set
        End Property
    
        Private _ContactName As Global.System.String
        Private Partial Sub OnContactNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnContactNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property ContactTitle() As Global.System.String
            Get
                Return _ContactTitle
            End Get
            Set
                OnContactTitleChanging(value)
                ReportPropertyChanging("ContactTitle")
                _ContactTitle = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("ContactTitle")
                OnContactTitleChanged()
            End Set
        End Property
    
        Private _ContactTitle As Global.System.String
        Private Partial Sub OnContactTitleChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnContactTitleChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Address() As Global.System.String
            Get
                Return _Address
            End Get
            Set
                OnAddressChanging(value)
                ReportPropertyChanging("Address")
                _Address = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Address")
                OnAddressChanged()
            End Set
        End Property
    
        Private _Address As Global.System.String
        Private Partial Sub OnAddressChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnAddressChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property City() As Global.System.String
            Get
                Return _City
            End Get
            Set
                OnCityChanging(value)
                ReportPropertyChanging("City")
                _City = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("City")
                OnCityChanged()
            End Set
        End Property
    
        Private _City As Global.System.String
        Private Partial Sub OnCityChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCityChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Region() As Global.System.String
            Get
                Return _Region
            End Get
            Set
                OnRegionChanging(value)
                ReportPropertyChanging("Region")
                _Region = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Region")
                OnRegionChanged()
            End Set
        End Property
    
        Private _Region As Global.System.String
        Private Partial Sub OnRegionChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnRegionChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property PostalCode() As Global.System.String
            Get
                Return _PostalCode
            End Get
            Set
                OnPostalCodeChanging(value)
                ReportPropertyChanging("PostalCode")
                _PostalCode = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("PostalCode")
                OnPostalCodeChanged()
            End Set
        End Property
    
        Private _PostalCode As Global.System.String
        Private Partial Sub OnPostalCodeChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnPostalCodeChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Country() As Global.System.String
            Get
                Return _Country
            End Get
            Set
                OnCountryChanging(value)
                ReportPropertyChanging("Country")
                _Country = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Country")
                OnCountryChanged()
            End Set
        End Property
    
        Private _Country As Global.System.String
        Private Partial Sub OnCountryChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCountryChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Phone() As Global.System.String
            Get
                Return _Phone
            End Get
            Set
                OnPhoneChanging(value)
                ReportPropertyChanging("Phone")
                _Phone = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Phone")
                OnPhoneChanged()
            End Set
        End Property
    
        Private _Phone As Global.System.String
        Private Partial Sub OnPhoneChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnPhoneChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Fax() As Global.System.String
            Get
                Return _Fax
            End Get
            Set
                OnFaxChanging(value)
                ReportPropertyChanging("Fax")
                _Fax = StructuralObject.SetValidValue(value, true)
                ReportPropertyChanged("Fax")
                OnFaxChanged()
            End Set
        End Property
    
        Private _Fax As Global.System.String
        Private Partial Sub OnFaxChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnFaxChanged()
        End Sub

        #End Region
    End Class

    #End Region
    
End Namespace
