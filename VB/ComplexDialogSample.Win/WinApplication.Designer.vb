Imports Microsoft.VisualBasic
Imports System
Namespace ComplexDialogSample.Win
	Partial Public Class ComplexDialogSampleWindowsFormsApplication
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.module3 = New ComplexDialogSample.Module.ComplexDialogSampleModule()
			Me.module4 = New ComplexDialogSample.Module.Win.ComplexDialogSampleWindowsFormsModule()

			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' ComplexDialogSampleWindowsFormsApplication
			' 
			Me.ApplicationName = "ComplexDialogSample"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.ComplexDialogSampleWindowsFormsApplication_DatabaseVersionMismatch);
'			Me.CustomizeLanguagesList += New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(Me.ComplexDialogSampleWindowsFormsApplication_CustomizeLanguagesList);

			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module3 As ComplexDialogSample.Module.ComplexDialogSampleModule
		Private module4 As ComplexDialogSample.Module.Win.ComplexDialogSampleWindowsFormsModule
	End Class
End Namespace
