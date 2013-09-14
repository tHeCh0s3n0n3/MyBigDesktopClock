Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DraggableForm
    Public Class FormBase
        Inherits Form

#Region "Declarations"
        Private drag As Boolean = False
        Private start_point As New Point(0, 0)
        Private m_draggable As Boolean = True
        Private exclude_list As String = ""

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        ''' <remarks></remarks>
        Private components As System.ComponentModel.IContainer = Nothing
#End Region

#Region "Constructor , Dispose"

        Public Sub New()
            InitializeComponent()

            ''
            '' Adding Mouse Event Handlers for the Form
            ''
            AddHandler Me.MouseDown, New MouseEventHandler(AddressOf Form_MouseDown)
            AddHandler Me.MouseUp, New MouseEventHandler(AddressOf Form_MouseUp)
            AddHandler Me.MouseMove, New MouseEventHandler(AddressOf Form_MouseMove)
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ''' <remarks></remarks>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#End Region

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub InitializeComponent()
            '' 
            '' FormBase
            '' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(369, 182)
            Me.Name = "FormBase"
            Me.Text = "AlerterForm"
        End Sub

#End Region

#Region "Overriden Functions"

        Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
            ''
            '' Add Mouse Event Handlers for each control added into the form,
            '' if Draggable property of the form is set to true and the control
            '' name is not in the ExcludeList.Exclude list is the comma separated
            '' list of the Controls for which you do not require the mouse handler 
            '' to be added. For Example a button.  
            ''
            If Me.Draggable AndAlso (Me.ExcludeList.IndexOf(e.Control.Name) = -1) Then
                AddHandler e.Control.MouseDown, New MouseEventHandler(AddressOf Form_MouseDown)
                AddHandler e.Control.MouseUp, New MouseEventHandler(AddressOf Form_MouseUp)
                AddHandler e.Control.MouseMove, New MouseEventHandler(AddressOf Form_MouseMove)
            End If
            MyBase.OnControlAdded(e)
        End Sub

#End Region

#Region "Event Handlers"

        Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs)
            ''
            '' On Mouse Down set the flag drag=true and 
            '' Store the clicked point to the start_point variable
            ''
            Me.drag = True
            Me.start_point = New Point(e.X, e.Y)
        End Sub

        Private Sub Form_MouseUp(sender As Object, e As MouseEventArgs)
            ''
            '' Set the drag flag = false;
            ''
            Me.drag = False
        End Sub

        Private Sub Form_MouseMove(sender As Object, e As MouseEventArgs)
            ''
            '' If drag = true, drag the form
            ''
            If Me.drag Then
                Dim p1 As New Point(e.X, e.Y)
                Dim p2 As Point = Me.PointToScreen(p1)
                Dim p3 As New Point(p2.X - Me.start_point.X, p2.Y - Me.start_point.Y)
                Me.Location = p3
            End If
        End Sub

#End Region

#Region "Properties"

        Public Property ExcludeList() As String
            Get
                Return Me.exclude_list.Trim()
            End Get
            Set(value As String)
                Me.exclude_list = value
            End Set
        End Property

        Public Property Draggable() As Boolean
            Get
                Return Me.m_draggable
            End Get
            Set(value As Boolean)
                Me.m_draggable = value
            End Set
        End Property

#End Region
    End Class
End Namespace
