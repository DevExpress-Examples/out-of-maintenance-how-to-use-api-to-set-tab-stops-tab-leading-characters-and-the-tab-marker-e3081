Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings
Imports DevExpress.XtraRichEdit.Commands

Namespace TabStops
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'richEditControl1.CreateNewDocument();
'			#Region "#tabs"
			richEditControl1.Document.Unit = DevExpress.XtraRichEdit.DocumentUnit.Inch
			Dim tabs As TabInfoCollection = richEditControl1.Document.Paragraphs(0).BeginUpdateTabs(True)
			Dim tab1 As New  DevExpress.XtraRichEdit.API.Native.TabInfo()
			' Sets tab stop at 2.5 inch
			tab1.Position = 2.5f
			tab1.Alignment = TabAlignmentType.Left
			tab1.Leader = TabLeaderType.MiddleDots
			tabs.Add(tab1)
			Dim tab2 As New  DevExpress.XtraRichEdit.API.Native.TabInfo()
			tab2.Position = 5.5f
			tab2.Alignment = TabAlignmentType.Decimal
			tab2.Leader = TabLeaderType.EqualSign
			tabs.Add(tab2)
			richEditControl1.Document.Paragraphs(0).EndUpdateTabs(tabs)
'			#End Region ' #tabs
			If checkEdit1.Checked Then
				Dim s As String = textEdit1.Text.Replace("\t",Constants.vbTab)
				richEditControl1.Options.Behavior.TabMarker = s
			End If

			Dim cmd As New InsertTabCommand(richEditControl1)
			cmd.Execute()
			richEditControl1.Document.InsertSingleLineText(richEditControl1.Document.Selection.Start, "Amount")
			cmd.Execute()
			richEditControl1.Document.InsertSingleLineText(richEditControl1.Document.Selection.Start, "222.22")

		End Sub
	End Class
End Namespace