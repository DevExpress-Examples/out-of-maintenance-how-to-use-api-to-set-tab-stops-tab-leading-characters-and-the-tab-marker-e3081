Imports Microsoft.VisualBasic
Imports System
Namespace TabStops
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 52)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(790, 379)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.textEdit1)
			Me.panelControl1.Controls.Add(Me.checkEdit1)
			Me.panelControl1.Controls.Add(Me.button1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(790, 52)
			Me.panelControl1.TabIndex = 1
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(12, 12)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(96, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Set Tab stops"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(130, 14)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Set Tab Leader character to the following:"
			Me.checkEdit1.Size = New System.Drawing.Size(228, 19)
			Me.checkEdit1.TabIndex = 1
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "\tGBP "
			Me.textEdit1.Location = New System.Drawing.Point(364, 14)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(35, 20)
			Me.textEdit1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(790, 431)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
	End Class
End Namespace

