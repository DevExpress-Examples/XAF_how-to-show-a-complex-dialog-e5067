Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security
Imports ComplexDialogSample.Module.BusinessObjects
'using DevExpress.ExpressApp.Reports;
'using DevExpress.ExpressApp.PivotChart;
'using DevExpress.ExpressApp.Security.Strategy;
'using ComplexDialogSample.Module.BusinessObjects;

Namespace ComplexDialogSample.Module.DatabaseUpdate
	' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()

			If ObjectSpace.FindObject(Of Team)(Nothing) Is Nothing Then
				Dim team = ObjectSpace.CreateObject(Of Team)()
				team.Name = "Violet"
				team = ObjectSpace.CreateObject(Of Team)()
				team.Name = "Green"
				team = ObjectSpace.CreateObject(Of Team)()
				team.Name = "Orange"
			End If
			Dim rnd As New Random()
			Dim n As Integer = 1
			If ObjectSpace.FindObject(Of Office)(Nothing) Is Nothing Then
				For floor As Integer = 1 To 4
					For i As Integer = 0 To 39
						Dim office = ObjectSpace.CreateObject(Of Office)()
						office.Index = String.Format("{0:d3}", floor * 100 + i)
						office.OccupiedBy = If(rnd.Next(20) = 0, Nothing, String.Format("somebody{0:d3}", n))
						n += 1
					Next i
				Next floor
			End If
			If ObjectSpace.FindObject(Of Service)(Nothing) Is Nothing Then
				Dim s = ObjectSpace.CreateObject(Of Service)()
				s.Description = "Clean"
				s = ObjectSpace.CreateObject(Of Service)()
				s.Description = "Refill"
				s = ObjectSpace.CreateObject(Of Service)()
				s.Description = "Secure"
				s = ObjectSpace.CreateObject(Of Service)()
				s.Description = "Inspect"
			End If
		End Sub
		Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
			MyBase.UpdateDatabaseBeforeUpdateSchema()
			'if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
			'    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
			'}
		End Sub
	End Class
End Namespace
