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
Public Class DataSet8
    Inherits DataSet
    
    Private tableНастройки As НастройкиDataTable
    
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
            If (Not (ds.Tables("Настройки")) Is Nothing) Then
                Me.Tables.Add(New НастройкиDataTable(ds.Tables("Настройки")))
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
    Public ReadOnly Property Настройки As НастройкиDataTable
        Get
            Return Me.tableНастройки
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet8 = CType(MyBase.Clone,DataSet8)
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
        If (Not (ds.Tables("Настройки")) Is Nothing) Then
            Me.Tables.Add(New НастройкиDataTable(ds.Tables("Настройки")))
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
        Me.tableНастройки = CType(Me.Tables("Настройки"),НастройкиDataTable)
        If (Not (Me.tableНастройки) Is Nothing) Then
            Me.tableНастройки.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DataSet8"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet8.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ru-RU")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableНастройки = New НастройкиDataTable
        Me.Tables.Add(Me.tableНастройки)
    End Sub
    
    Private Function ShouldSerializeНастройки() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub НастройкиRowChangeEventHandler(ByVal sender As Object, ByVal e As НастройкиRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class НастройкиDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnИмяШрифта As DataColumn
        
        Private columnРазмерШрифта As DataColumn
        
        Private columnСтрока As DataColumn
        
        Private columnФорматированиеМодуля As DataColumn
        
        Friend Sub New()
            MyBase.New("Настройки")
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
        
        Friend ReadOnly Property ИмяШрифтаColumn As DataColumn
            Get
                Return Me.columnИмяШрифта
            End Get
        End Property
        
        Friend ReadOnly Property РазмерШрифтаColumn As DataColumn
            Get
                Return Me.columnРазмерШрифта
            End Get
        End Property
        
        Friend ReadOnly Property СтрокаColumn As DataColumn
            Get
                Return Me.columnСтрока
            End Get
        End Property
        
        Friend ReadOnly Property ФорматированиеМодуляColumn As DataColumn
            Get
                Return Me.columnФорматированиеМодуля
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As НастройкиRow
            Get
                Return CType(Me.Rows(index),НастройкиRow)
            End Get
        End Property
        
        Public Event НастройкиRowChanged As НастройкиRowChangeEventHandler
        
        Public Event НастройкиRowChanging As НастройкиRowChangeEventHandler
        
        Public Event НастройкиRowDeleted As НастройкиRowChangeEventHandler
        
        Public Event НастройкиRowDeleting As НастройкиRowChangeEventHandler
        
        Public Overloads Sub AddНастройкиRow(ByVal row As НастройкиRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddНастройкиRow(ByVal ИмяШрифта As String, ByVal РазмерШрифта As String, ByVal ФорматированиеМодуля As Integer) As НастройкиRow
            Dim rowНастройкиRow As НастройкиRow = CType(Me.NewRow,НастройкиRow)
            rowНастройкиRow.ItemArray = New Object() {ИмяШрифта, РазмерШрифта, Nothing, ФорматированиеМодуля}
            Me.Rows.Add(rowНастройкиRow)
            Return rowНастройкиRow
        End Function
        
        Public Function FindByСтрока(ByVal Строка As Integer) As НастройкиRow
            Return CType(Me.Rows.Find(New Object() {Строка}),НастройкиRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As НастройкиDataTable = CType(MyBase.Clone,НастройкиDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New НастройкиDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnИмяШрифта = Me.Columns("ИмяШрифта")
            Me.columnРазмерШрифта = Me.Columns("РазмерШрифта")
            Me.columnСтрока = Me.Columns("Строка")
            Me.columnФорматированиеМодуля = Me.Columns("ФорматированиеМодуля")
        End Sub
        
        Private Sub InitClass()
            Me.columnИмяШрифта = New DataColumn("ИмяШрифта", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnИмяШрифта)
            Me.columnРазмерШрифта = New DataColumn("РазмерШрифта", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnРазмерШрифта)
            Me.columnСтрока = New DataColumn("Строка", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnСтрока)
            Me.columnФорматированиеМодуля = New DataColumn("ФорматированиеМодуля", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnФорматированиеМодуля)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnСтрока}, true))
            Me.columnСтрока.AutoIncrement = true
            Me.columnСтрока.AllowDBNull = false
            Me.columnСтрока.Unique = true
        End Sub
        
        Public Function NewНастройкиRow() As НастройкиRow
            Return CType(Me.NewRow,НастройкиRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New НастройкиRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(НастройкиRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.НастройкиRowChangedEvent) Is Nothing) Then
                RaiseEvent НастройкиRowChanged(Me, New НастройкиRowChangeEvent(CType(e.Row,НастройкиRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.НастройкиRowChangingEvent) Is Nothing) Then
                RaiseEvent НастройкиRowChanging(Me, New НастройкиRowChangeEvent(CType(e.Row,НастройкиRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.НастройкиRowDeletedEvent) Is Nothing) Then
                RaiseEvent НастройкиRowDeleted(Me, New НастройкиRowChangeEvent(CType(e.Row,НастройкиRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.НастройкиRowDeletingEvent) Is Nothing) Then
                RaiseEvent НастройкиRowDeleting(Me, New НастройкиRowChangeEvent(CType(e.Row,НастройкиRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveНастройкиRow(ByVal row As НастройкиRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class НастройкиRow
        Inherits DataRow
        
        Private tableНастройки As НастройкиDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableНастройки = CType(Me.Table,НастройкиDataTable)
        End Sub
        
        Public Property ИмяШрифта As String
            Get
                Try 
                    Return CType(Me(Me.tableНастройки.ИмяШрифтаColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableНастройки.ИмяШрифтаColumn) = value
            End Set
        End Property
        
        Public Property РазмерШрифта As String
            Get
                Try 
                    Return CType(Me(Me.tableНастройки.РазмерШрифтаColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableНастройки.РазмерШрифтаColumn) = value
            End Set
        End Property
        
        Public Property Строка As Integer
            Get
                Return CType(Me(Me.tableНастройки.СтрокаColumn),Integer)
            End Get
            Set
                Me(Me.tableНастройки.СтрокаColumn) = value
            End Set
        End Property
        
        Public Property ФорматированиеМодуля As Integer
            Get
                Try 
                    Return CType(Me(Me.tableНастройки.ФорматированиеМодуляColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableНастройки.ФорматированиеМодуляColumn) = value
            End Set
        End Property
        
        Public Function IsИмяШрифтаNull() As Boolean
            Return Me.IsNull(Me.tableНастройки.ИмяШрифтаColumn)
        End Function
        
        Public Sub SetИмяШрифтаNull()
            Me(Me.tableНастройки.ИмяШрифтаColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsРазмерШрифтаNull() As Boolean
            Return Me.IsNull(Me.tableНастройки.РазмерШрифтаColumn)
        End Function
        
        Public Sub SetРазмерШрифтаNull()
            Me(Me.tableНастройки.РазмерШрифтаColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsФорматированиеМодуляNull() As Boolean
            Return Me.IsNull(Me.tableНастройки.ФорматированиеМодуляColumn)
        End Function
        
        Public Sub SetФорматированиеМодуляNull()
            Me(Me.tableНастройки.ФорматированиеМодуляColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class НастройкиRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As НастройкиRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As НастройкиRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As НастройкиRow
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
