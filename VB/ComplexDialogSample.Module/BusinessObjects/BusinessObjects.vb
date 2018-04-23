Imports Microsoft.VisualBasic
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports System
Imports System.ComponentModel

Namespace ComplexDialogSample.Module.BusinessObjects
	<NavigationItem("Resources")> _
	Public Class Team
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property
	End Class
	<NavigationItem("Process"), DefaultProperty("Index")> _
	Public Class Office
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property Index() As String
			Get
				Return GetPropertyValue(Of String)("Index")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Index", value)
			End Set
		End Property
		Public Property OccupiedBy() As String
			Get
				Return GetPropertyValue(Of String)("OccupiedBy")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("OccupiedBy", value)
			End Set
		End Property
	End Class
	<NavigationItem("Process")> _
	Public Class Order
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property Team() As Team
			Get
				Return GetPropertyValue(Of Team)("Team")
			End Get
			Set(ByVal value As Team)
				SetPropertyValue(Of Team)("Team", value)
			End Set
		End Property
		Public Property Office() As Office
			Get
				Return GetPropertyValue(Of Office)("Office")
			End Get
			Set(ByVal value As Office)
				SetPropertyValue(Of Office)("Office", value)
			End Set
		End Property
		Public Property Service() As Service
			Get
				Return GetPropertyValue(Of Service)("Service")
			End Get
			Set(ByVal value As Service)
				SetPropertyValue(Of Service)("Service", value)
			End Set
		End Property
		Public Property DueDate() As DateTime
			Get
				Return GetPropertyValue(Of DateTime)("DueDate")
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue(Of DateTime)("DueDate", value)
			End Set
		End Property
	End Class
	<NavigationItem("Resources"), DefaultProperty("Description")> _
	Public Class Service
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property Description() As String
			Get
				Return GetPropertyValue(Of String)("Description")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Description", value)
			End Set
		End Property
	End Class
End Namespace
