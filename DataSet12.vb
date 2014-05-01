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
Public Class DataSet12
    Inherits DataSet
    
    Private tableFTP As FTPDataTable
    
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
            If (Not (ds.Tables("FTP")) Is Nothing) Then
                Me.Tables.Add(New FTPDataTable(ds.Tables("FTP")))
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
    Public ReadOnly Property FTP As FTPDataTable
        Get
            Return Me.tableFTP
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet12 = CType(MyBase.Clone,DataSet12)
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
        If (Not (ds.Tables("FTP")) Is Nothing) Then
            Me.Tables.Add(New FTPDataTable(ds.Tables("FTP")))
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
        Me.tableFTP = CType(Me.Tables("FTP"),FTPDataTable)
        If (Not (Me.tableFTP) Is Nothing) Then
            Me.tableFTP.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DataSet12"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet12.xsd"
        Me.Locale = New System.Globalization.CultureInfo("ru-RU")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableFTP = New FTPDataTable
        Me.Tables.Add(Me.tableFTP)
    End Sub
    
    Private Function ShouldSerializeFTP() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub FTPRowChangeEventHandler(ByVal sender As Object, ByVal e As FTPRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class FTPDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnid As DataColumn
        
        Private columnИмяПользователя As DataColumn
        
        Private columnИмяСоединения As DataColumn
        
        Private columnИнформация As DataColumn
        
        Private columnПароль As DataColumn
        
        Private columnСерверИПорт As DataColumn
        
        Friend Sub New()
            MyBase.New("FTP")
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
        
        Friend ReadOnly Property idColumn As DataColumn
            Get
                Return Me.columnid
            End Get
        End Property
        
        Friend ReadOnly Property ИмяПользователяColumn As DataColumn
            Get
                Return Me.columnИмяПользователя
            End Get
        End Property
        
        Friend ReadOnly Property ИмяСоединенияColumn As DataColumn
            Get
                Return Me.columnИмяСоединения
            End Get
        End Property
        
        Friend ReadOnly Property ИнформацияColumn As DataColumn
            Get
                Return Me.columnИнформация
            End Get
        End Property
        
        Friend ReadOnly Property ПарольColumn As DataColumn
            Get
                Return Me.columnПароль
            End Get
        End Property
        
        Friend ReadOnly Property СерверИПортColumn As DataColumn
            Get
                Return Me.columnСерверИПорт
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As FTPRow
            Get
                Return CType(Me.Rows(index),FTPRow)
            End Get
        End Property
        
        Public Event FTPRowChanged As FTPRowChangeEventHandler
        
        Public Event FTPRowChanging As FTPRowChangeEventHandler
        
        Public Event FTPRowDeleted As FTPRowChangeEventHandler
        
        Public Event FTPRowDeleting As FTPRowChangeEventHandler
        
        Public Overloads Sub AddFTPRow(ByVal row As FTPRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddFTPRow(ByVal ИмяПользователя As String, ByVal ИмяСоединения As String, ByVal Информация As String, ByVal Пароль As String, ByVal СерверИПорт As String) As FTPRow
            Dim rowFTPRow As FTPRow = CType(Me.NewRow,FTPRow)
            rowFTPRow.ItemArray = New Object() {Nothing, ИмяПользователя, ИмяСоединения, Информация, Пароль, СерверИПорт}
            Me.Rows.Add(rowFTPRow)
            Return rowFTPRow
        End Function
        
        Public Function FindByid(ByVal id As Integer) As FTPRow
            Return CType(Me.Rows.Find(New Object() {id}),FTPRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As FTPDataTable = CType(MyBase.Clone,FTPDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New FTPDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnid = Me.Columns("id")
            Me.columnИмяПользователя = Me.Columns("ИмяПользователя")
            Me.columnИмяСоединения = Me.Columns("ИмяСоединения")
            Me.columnИнформация = Me.Columns("Информация")
            Me.columnПароль = Me.Columns("Пароль")
            Me.columnСерверИПорт = Me.Columns("СерверИПорт")
        End Sub
        
        Private Sub InitClass()
            Me.columnid = New DataColumn("id", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnid)
            Me.columnИмяПользователя = New DataColumn("ИмяПользователя", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnИмяПользователя)
            Me.columnИмяСоединения = New DataColumn("ИмяСоединения", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnИмяСоединения)
            Me.columnИнформация = New DataColumn("Информация", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnИнформация)
            Me.columnПароль = New DataColumn("Пароль", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnПароль)
            Me.columnСерверИПорт = New DataColumn("СерверИПорт", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnСерверИПорт)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnid}, true))
            Me.columnid.AutoIncrement = true
            Me.columnid.AllowDBNull = false
            Me.columnid.Unique = true
        End Sub
        
        Public Function NewFTPRow() As FTPRow
            Return CType(Me.NewRow,FTPRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New FTPRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(FTPRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.FTPRowChangedEvent) Is Nothing) Then
                RaiseEvent FTPRowChanged(Me, New FTPRowChangeEvent(CType(e.Row,FTPRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.FTPRowChangingEvent) Is Nothing) Then
                RaiseEvent FTPRowChanging(Me, New FTPRowChangeEvent(CType(e.Row,FTPRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.FTPRowDeletedEvent) Is Nothing) Then
                RaiseEvent FTPRowDeleted(Me, New FTPRowChangeEvent(CType(e.Row,FTPRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.FTPRowDeletingEvent) Is Nothing) Then
                RaiseEvent FTPRowDeleting(Me, New FTPRowChangeEvent(CType(e.Row,FTPRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveFTPRow(ByVal row As FTPRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class FTPRow
        Inherits DataRow
        
        Private tableFTP As FTPDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableFTP = CType(Me.Table,FTPDataTable)
        End Sub
        
        Public Property id As Integer
            Get
                Return CType(Me(Me.tableFTP.idColumn),Integer)
            End Get
            Set
                Me(Me.tableFTP.idColumn) = value
            End Set
        End Property
        
        Public Property ИмяПользователя As String
            Get
                Try 
                    Return CType(Me(Me.tableFTP.ИмяПользователяColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableFTP.ИмяПользователяColumn) = value
            End Set
        End Property
        
        Public Property ИмяСоединения As String
            Get
                Try 
                    Return CType(Me(Me.tableFTP.ИмяСоединенияColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableFTP.ИмяСоединенияColumn) = value
            End Set
        End Property
        
        Public Property Информация As String
            Get
                Try 
                    Return CType(Me(Me.tableFTP.ИнформацияColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableFTP.ИнформацияColumn) = value
            End Set
        End Property
        
        Public Property Пароль As String
            Get
                Try 
                    Return CType(Me(Me.tableFTP.ПарольColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableFTP.ПарольColumn) = value
            End Set
        End Property
        
        Public Property СерверИПорт As String
            Get
                Try 
                    Return CType(Me(Me.tableFTP.СерверИПортColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Невозможно получить значение, т.к. оно является DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableFTP.СерверИПортColumn) = value
            End Set
        End Property
        
        Public Function IsИмяПользователяNull() As Boolean
            Return Me.IsNull(Me.tableFTP.ИмяПользователяColumn)
        End Function
        
        Public Sub SetИмяПользователяNull()
            Me(Me.tableFTP.ИмяПользователяColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsИмяСоединенияNull() As Boolean
            Return Me.IsNull(Me.tableFTP.ИмяСоединенияColumn)
        End Function
        
        Public Sub SetИмяСоединенияNull()
            Me(Me.tableFTP.ИмяСоединенияColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsИнформацияNull() As Boolean
            Return Me.IsNull(Me.tableFTP.ИнформацияColumn)
        End Function
        
        Public Sub SetИнформацияNull()
            Me(Me.tableFTP.ИнформацияColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsПарольNull() As Boolean
            Return Me.IsNull(Me.tableFTP.ПарольColumn)
        End Function
        
        Public Sub SetПарольNull()
            Me(Me.tableFTP.ПарольColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsСерверИПортNull() As Boolean
            Return Me.IsNull(Me.tableFTP.СерверИПортColumn)
        End Function
        
        Public Sub SetСерверИПортNull()
            Me(Me.tableFTP.СерверИПортColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class FTPRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As FTPRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As FTPRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As FTPRow
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
