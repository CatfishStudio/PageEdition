﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DataSet13
    Inherits DataSet
    
    Private tableХранилище As ХранилищеDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Хранилище")) Is Nothing) Then
                Me.Tables.Add(New ХранилищеDataTable(ds.Tables("Хранилище")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Хранилище As ХранилищеDataTable
        Get
            Return Me.tableХранилище
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet13 = CType(MyBase.Clone,DataSet13)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Хранилище")) Is Nothing) Then
            Me.Tables.Add(New ХранилищеDataTable(ds.Tables("Хранилище")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableХранилище = CType(Me.Tables("Хранилище"),ХранилищеDataTable)
        If (Not (Me.tableХранилище) Is Nothing) Then
            Me.tableХранилище.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DataSet13"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet13.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ru-RU")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableХранилище = New ХранилищеDataTable
        Me.Tables.Add(Me.tableХранилище)
    End Sub
    
    Private Function ShouldSerializeХранилище() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ХранилищеRowChangeEventHandler(ByVal sender As Object, ByVal e As ХранилищеRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ХранилищеDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnДатаПоследнегоСохранения As DataColumn
        
        Private columnПапкаИдентификатор As DataColumn
        
        Private columnСодержаниеФайла As DataColumn
        
        Private columnСтрока As DataColumn
        
        Private columnТипОбъекта As DataColumn
        
        Private columnФайлВПапке As DataColumn
        
        Private columnФайлИдентификатор As DataColumn
        
        Friend Sub New()
            MyBase.New("Хранилище")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property ДатаПоследнегоСохраненияColumn As DataColumn
            Get
                Return Me.columnДатаПоследнегоСохранения
            End Get
        End Property
        
        Friend ReadOnly Property ПапкаИдентификаторColumn As DataColumn
            Get
                Return Me.columnПапкаИдентификатор
            End Get
        End Property
        
        Friend ReadOnly Property СодержаниеФайлаColumn As DataColumn
            Get
                Return Me.columnСодержаниеФайла
            End Get
        End Property
        
        Friend ReadOnly Property СтрокаColumn As DataColumn
            Get
                Return Me.columnСтрока
            End Get
        End Property
        
        Friend ReadOnly Property ТипОбъектаColumn As DataColumn
            Get
                Return Me.columnТипОбъекта
            End Get
        End Property
        
        Friend ReadOnly Property ФайлВПапкеColumn As DataColumn
            Get
                Return Me.columnФайлВПапке
            End Get
        End Property
        
        Friend ReadOnly Property ФайлИдентификаторColumn As DataColumn
            Get
                Return Me.columnФайлИдентификатор
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ХранилищеRow
            Get
                Return CType(Me.Rows(index),ХранилищеRow)
            End Get
        End Property
        
        Public Event ХранилищеRowChanged As ХранилищеRowChangeEventHandler
        
        Public Event ХранилищеRowChanging As ХранилищеRowChangeEventHandler
        
        Public Event ХранилищеRowDeleted As ХранилищеRowChangeEventHandler
        
        Public Event ХранилищеRowDeleting As ХранилищеRowChangeEventHandler
        
        Public Overloads Sub AddХранилищеRow(ByVal row As ХранилищеRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddХранилищеRow(ByVal ДатаПоследнегоСохранения As Date, ByVal ПапкаИдентификатор As String, ByVal СодержаниеФайла As String, ByVal ТипОбъекта As String, ByVal ФайлВПапке As String, ByVal ФайлИдентификатор As String) As ХранилищеRow
            Dim rowХранилищеRow As ХранилищеRow = CType(Me.NewRow,ХранилищеRow)
            rowХранилищеRow.ItemArray = New Object() {ДатаПоследнегоСохранения, ПапкаИдентификатор, СодержаниеФайла, Nothing, ТипОбъекта, ФайлВПапке, ФайлИдентификатор}
            Me.Rows.Add(rowХранилищеRow)
            Return rowХранилищеRow
        End Function
        
        Public Function FindByСтрока(ByVal Строка As Integer) As ХранилищеRow
            Return CType(Me.Rows.Find(New Object() {Строка}),ХранилищеRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ХранилищеDataTable = CType(MyBase.Clone,ХранилищеDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ХранилищеDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnДатаПоследнегоСохранения = Me.Columns("ДатаПоследнегоСохранения")
            Me.columnПапкаИдентификатор = Me.Columns("ПапкаИдентификатор")
            Me.columnСодержаниеФайла = Me.Columns("СодержаниеФайла")
            Me.columnСтрока = Me.Columns("Строка")
            Me.columnТипОбъекта = Me.Columns("ТипОбъекта")
            Me.columnФайлВПапке = Me.Columns("ФайлВПапке")
            Me.columnФайлИдентификатор = Me.Columns("ФайлИдентификатор")
        End Sub
        
        Private Sub InitClass()
            Me.columnДатаПоследнегоСохранения = New DataColumn("ДатаПоследнегоСохранения", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnДатаПоследнегоСохранения)
            Me.columnПапкаИдентификатор = New DataColumn("ПапкаИдентификатор", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnПапкаИдентификатор)
            Me.columnСодержаниеФайла = New DataColumn("СодержаниеФайла", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnСодержаниеФайла)
            Me.columnСтрока = New DataColumn("Строка", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnСтрока)
            Me.columnТипОбъекта = New DataColumn("ТипОбъекта", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnТипОбъекта)
            Me.columnФайлВПапке = New DataColumn("ФайлВПапке", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnФайлВПапке)
            Me.columnФайлИдентификатор = New DataColumn("ФайлИдентификатор", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnФайлИдентификатор)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnСтрока}, true))
            Me.columnСтрока.AutoIncrement = true
            Me.columnСтрока.AllowDBNull = false
            Me.columnСтрока.Unique = true
        End Sub
        
        Public Function NewХранилищеRow() As ХранилищеRow
            Return CType(Me.NewRow,ХранилищеRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ХранилищеRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ХранилищеRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ХранилищеRowChangedEvent) Is Nothing) Then
                RaiseEvent ХранилищеRowChanged(Me, New ХранилищеRowChangeEvent(CType(e.Row,ХранилищеRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ХранилищеRowChangingEvent) Is Nothing) Then
                RaiseEvent ХранилищеRowChanging(Me, New ХранилищеRowChangeEvent(CType(e.Row,ХранилищеRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ХранилищеRowDeletedEvent) Is Nothing) Then
                RaiseEvent ХранилищеRowDeleted(Me, New ХранилищеRowChangeEvent(CType(e.Row,ХранилищеRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ХранилищеRowDeletingEvent) Is Nothing) Then
                RaiseEvent ХранилищеRowDeleting(Me, New ХранилищеRowChangeEvent(CType(e.Row,ХранилищеRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveХранилищеRow(ByVal row As ХранилищеRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ХранилищеRow
        Inherits DataRow
        
        Private tableХранилище As ХранилищеDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableХранилище = CType(Me.Table,ХранилищеDataTable)
        End Sub
        
        Public Property ДатаПоследнегоСохранения As Date
            Get
                Try 
                    Return CType(Me(Me.tableХранилище.ДатаПоследнегоСохраненияColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableХранилище.ДатаПоследнегоСохраненияColumn) = value
            End Set
        End Property
        
        Public Property ПапкаИдентификатор As String
            Get
                Try 
                    Return CType(Me(Me.tableХранилище.ПапкаИдентификаторColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableХранилище.ПапкаИдентификаторColumn) = value
            End Set
        End Property
        
        Public Property СодержаниеФайла As String
            Get
                Try 
                    Return CType(Me(Me.tableХранилище.СодержаниеФайлаColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableХранилище.СодержаниеФайлаColumn) = value
            End Set
        End Property
        
        Public Property Строка As Integer
            Get
                Return CType(Me(Me.tableХранилище.СтрокаColumn),Integer)
            End Get
            Set
                Me(Me.tableХранилище.СтрокаColumn) = value
            End Set
        End Property
        
        Public Property ТипОбъекта As String
            Get
                Try 
                    Return CType(Me(Me.tableХранилище.ТипОбъектаColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableХранилище.ТипОбъектаColumn) = value
            End Set
        End Property
        
        Public Property ФайлВПапке As String
            Get
                Try 
                    Return CType(Me(Me.tableХранилище.ФайлВПапкеColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableХранилище.ФайлВПапкеColumn) = value
            End Set
        End Property
        
        Public Property ФайлИдентификатор As String
            Get
                Try 
                    Return CType(Me(Me.tableХранилище.ФайлИдентификаторColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableХранилище.ФайлИдентификаторColumn) = value
            End Set
        End Property
        
        Public Function IsДатаПоследнегоСохраненияNull() As Boolean
            Return Me.IsNull(Me.tableХранилище.ДатаПоследнегоСохраненияColumn)
        End Function
        
        Public Sub SetДатаПоследнегоСохраненияNull()
            Me(Me.tableХранилище.ДатаПоследнегоСохраненияColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsПапкаИдентификаторNull() As Boolean
            Return Me.IsNull(Me.tableХранилище.ПапкаИдентификаторColumn)
        End Function
        
        Public Sub SetПапкаИдентификаторNull()
            Me(Me.tableХранилище.ПапкаИдентификаторColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsСодержаниеФайлаNull() As Boolean
            Return Me.IsNull(Me.tableХранилище.СодержаниеФайлаColumn)
        End Function
        
        Public Sub SetСодержаниеФайлаNull()
            Me(Me.tableХранилище.СодержаниеФайлаColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsТипОбъектаNull() As Boolean
            Return Me.IsNull(Me.tableХранилище.ТипОбъектаColumn)
        End Function
        
        Public Sub SetТипОбъектаNull()
            Me(Me.tableХранилище.ТипОбъектаColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsФайлВПапкеNull() As Boolean
            Return Me.IsNull(Me.tableХранилище.ФайлВПапкеColumn)
        End Function
        
        Public Sub SetФайлВПапкеNull()
            Me(Me.tableХранилище.ФайлВПапкеColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsФайлИдентификаторNull() As Boolean
            Return Me.IsNull(Me.tableХранилище.ФайлИдентификаторColumn)
        End Function
        
        Public Sub SetФайлИдентификаторNull()
            Me(Me.tableХранилище.ФайлИдентификаторColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ХранилищеRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ХранилищеRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ХранилищеRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ХранилищеRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
