<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dtpPTO = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cbxPTOP = New System.Windows.Forms.CheckBox()
		Me.btnEnter = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtStartTime = New System.Windows.Forms.TextBox()
		Me.txtEndTime = New System.Windows.Forms.TextBox()
		Me.txtBoxScheduled = New System.Windows.Forms.TextBox()
		Me.btnEditTime = New System.Windows.Forms.Button()
		Me.PTOToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.PTOToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
		Me.EditToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnRefresh = New System.Windows.Forms.Button()
		Me.RefreshToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.picASIC = New System.Windows.Forms.PictureBox()
		Me.txtPTORtotal = New System.Windows.Forms.TextBox()
		Me.PTOHoursToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnPTOI = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtPTOPtotal = New System.Windows.Forms.TextBox()
		Me.PTOPToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.PTOPBoxToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtPTOPused = New System.Windows.Forms.TextBox()
		Me.txtPTORused = New System.Windows.Forms.TextBox()
		Me.btnPTOU = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblOverall = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblPTOPremain = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lblPTORremain = New System.Windows.Forms.Label()
		Me.btnClearPTO = New System.Windows.Forms.Button()
		Me.ClearPTOToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip1.SuspendLayout()
		CType(Me.picASIC, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(679, 24)
		Me.MenuStrip1.TabIndex = 9
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(21, 54)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Select PTO Day:"
		'
		'dtpPTO
		'
		Me.dtpPTO.CustomFormat = ""
		Me.dtpPTO.Location = New System.Drawing.Point(24, 74)
		Me.dtpPTO.Name = "dtpPTO"
		Me.dtpPTO.Size = New System.Drawing.Size(237, 25)
		Me.dtpPTO.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 112)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 17)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Start Time:"
		Me.PTOToolTip1.SetToolTip(Me.Label2, "Make sure to include AM and PM with your submission." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(158, 112)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "End Time:"
		Me.PTOToolTip2.SetToolTip(Me.Label3, "Make sure to include AM and PM with your submission." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'cbxPTOP
		'
		Me.cbxPTOP.AutoSize = True
		Me.cbxPTOP.Location = New System.Drawing.Point(24, 173)
		Me.cbxPTOP.Name = "cbxPTOP"
		Me.cbxPTOP.Size = New System.Drawing.Size(110, 21)
		Me.cbxPTOP.TabIndex = 4
		Me.cbxPTOP.Text = "Protected PTO"
		Me.PTOPBoxToolTip.SetToolTip(Me.cbxPTOP, "Click here to schedule time as Protected Time.")
		Me.cbxPTOP.UseVisualStyleBackColor = True
		'
		'btnEnter
		'
		Me.btnEnter.Location = New System.Drawing.Point(24, 210)
		Me.btnEnter.Name = "btnEnter"
		Me.btnEnter.Size = New System.Drawing.Size(100, 28)
		Me.btnEnter.TabIndex = 5
		Me.btnEnter.Text = "Enter PTO Day"
		Me.btnEnter.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(293, 54)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(98, 17)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Scheduled PTO:"
		'
		'txtStartTime
		'
		Me.txtStartTime.Location = New System.Drawing.Point(24, 132)
		Me.txtStartTime.Name = "txtStartTime"
		Me.txtStartTime.Size = New System.Drawing.Size(100, 25)
		Me.txtStartTime.TabIndex = 11
		'
		'txtEndTime
		'
		Me.txtEndTime.Location = New System.Drawing.Point(161, 132)
		Me.txtEndTime.Name = "txtEndTime"
		Me.txtEndTime.Size = New System.Drawing.Size(100, 25)
		Me.txtEndTime.TabIndex = 12
		'
		'txtBoxScheduled
		'
		Me.txtBoxScheduled.BackColor = System.Drawing.SystemColors.Control
		Me.txtBoxScheduled.Location = New System.Drawing.Point(296, 74)
		Me.txtBoxScheduled.Multiline = True
		Me.txtBoxScheduled.Name = "txtBoxScheduled"
		Me.txtBoxScheduled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtBoxScheduled.Size = New System.Drawing.Size(355, 161)
		Me.txtBoxScheduled.TabIndex = 13
		'
		'btnEditTime
		'
		Me.btnEditTime.Location = New System.Drawing.Point(355, 232)
		Me.btnEditTime.Name = "btnEditTime"
		Me.btnEditTime.Size = New System.Drawing.Size(95, 28)
		Me.btnEditTime.TabIndex = 14
		Me.btnEditTime.Text = "Edit Time Off"
		Me.EditToolTip.SetToolTip(Me.btnEditTime, "This will open a text file so you can make changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to any time that you previous" &
		"ly submitted." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.btnEditTime.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(21, 380)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(122, 17)
		Me.Label5.TabIndex = 17
		Me.Label5.Text = "Regular PTO Hours:"
		Me.PTOToolTip1.SetToolTip(Me.Label5, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.PTOHoursToolTip.SetToolTip(Me.Label5, "This is for Regular PTO ONLY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(this includes Deviated Holiday time)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(21, 428)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(133, 17)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Protected PTO Hours:"
		Me.PTOToolTip1.SetToolTip(Me.Label6, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.PTOHoursToolTip.SetToolTip(Me.Label6, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.PTOPToolTip.SetToolTip(Me.Label6, "This is for Protected PTO ONLY." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(21, 524)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(128, 17)
		Me.Label7.TabIndex = 25
		Me.Label7.Text = "Protected PTO Used:"
		Me.PTOToolTip1.SetToolTip(Me.Label7, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.PTOHoursToolTip.SetToolTip(Me.Label7, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.PTOPToolTip.SetToolTip(Me.Label7, "This is for Protected PTO ONLY." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(21, 476)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(117, 17)
		Me.Label8.TabIndex = 23
		Me.Label8.Text = "Regular PTO Used:"
		Me.PTOToolTip1.SetToolTip(Me.Label8, "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.PTOHoursToolTip.SetToolTip(Me.Label8, "This is for Regular PTO ONLY." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(565, 626)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(86, 28)
		Me.btnExit.TabIndex = 16
		Me.btnExit.Text = "E&xit"
		Me.EditToolTip.SetToolTip(Me.btnExit, "This will open a text file so you can make changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to any time that you previous" &
		"ly submitted." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnRefresh
		'
		Me.btnRefresh.Location = New System.Drawing.Point(456, 232)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(95, 28)
		Me.btnRefresh.TabIndex = 15
		Me.btnRefresh.Text = "Refresh List"
		Me.RefreshToolTip.SetToolTip(Me.btnRefresh, "Click here after any changes have been made" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to the Scheduled PTO file to refresh" &
		" the list above.")
		Me.btnRefresh.UseVisualStyleBackColor = True
		'
		'picASIC
		'
		Me.picASIC.Image = Global.ASIC_PTO_Tracker.My.Resources.Resources.ASICLogoNew
		Me.picASIC.Location = New System.Drawing.Point(149, 160)
		Me.picASIC.Name = "picASIC"
		Me.picASIC.Size = New System.Drawing.Size(101, 100)
		Me.picASIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picASIC.TabIndex = 9
		Me.picASIC.TabStop = False
		'
		'txtPTORtotal
		'
		Me.txtPTORtotal.Location = New System.Drawing.Point(24, 400)
		Me.txtPTORtotal.Name = "txtPTORtotal"
		Me.txtPTORtotal.Size = New System.Drawing.Size(130, 25)
		Me.txtPTORtotal.TabIndex = 18
		'
		'btnPTOI
		'
		Me.btnPTOI.Location = New System.Drawing.Point(176, 420)
		Me.btnPTOI.Name = "btnPTOI"
		Me.btnPTOI.Size = New System.Drawing.Size(85, 25)
		Me.btnPTOI.TabIndex = 19
		Me.btnPTOI.Text = "PTO Input"
		Me.btnPTOI.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.picASIC)
		Me.GroupBox1.Controls.Add(Me.btnEditTime)
		Me.GroupBox1.Controls.Add(Me.btnRefresh)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(655, 282)
		Me.GroupBox1.TabIndex = 20
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "PTO Selection"
		'
		'txtPTOPtotal
		'
		Me.txtPTOPtotal.Location = New System.Drawing.Point(24, 448)
		Me.txtPTOPtotal.Name = "txtPTOPtotal"
		Me.txtPTOPtotal.Size = New System.Drawing.Size(130, 25)
		Me.txtPTOPtotal.TabIndex = 22
		'
		'txtPTOPused
		'
		Me.txtPTOPused.Location = New System.Drawing.Point(24, 544)
		Me.txtPTOPused.Name = "txtPTOPused"
		Me.txtPTOPused.Size = New System.Drawing.Size(130, 25)
		Me.txtPTOPused.TabIndex = 26
		'
		'txtPTORused
		'
		Me.txtPTORused.Location = New System.Drawing.Point(24, 496)
		Me.txtPTORused.Name = "txtPTORused"
		Me.txtPTORused.Size = New System.Drawing.Size(130, 25)
		Me.txtPTORused.TabIndex = 24
		'
		'btnPTOU
		'
		Me.btnPTOU.Location = New System.Drawing.Point(164, 178)
		Me.btnPTOU.Name = "btnPTOU"
		Me.btnPTOU.Size = New System.Drawing.Size(86, 25)
		Me.btnPTOU.TabIndex = 29
		Me.btnPTOU.Text = "PTO Used"
		Me.btnPTOU.UseVisualStyleBackColor = True
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(412, 86)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(66, 17)
		Me.Label9.TabIndex = 30
		Me.Label9.Text = "Total PTO:"
		'
		'lblOverall
		'
		Me.lblOverall.AutoSize = True
		Me.lblOverall.BackColor = System.Drawing.SystemColors.Control
		Me.lblOverall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblOverall.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblOverall.Location = New System.Drawing.Point(484, 83)
		Me.lblOverall.MinimumSize = New System.Drawing.Size(100, 20)
		Me.lblOverall.Name = "lblOverall"
		Me.lblOverall.Size = New System.Drawing.Size(100, 20)
		Me.lblOverall.TabIndex = 31
		Me.lblOverall.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label12)
		Me.GroupBox2.Controls.Add(Me.lblPTOPremain)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Controls.Add(Me.lblPTORremain)
		Me.GroupBox2.Controls.Add(Me.btnClearPTO)
		Me.GroupBox2.Controls.Add(Me.btnPTOU)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Controls.Add(Me.lblOverall)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 342)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(655, 278)
		Me.GroupBox2.TabIndex = 32
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "PTO Hours"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(367, 182)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(111, 17)
		Me.Label12.TabIndex = 35
		Me.Label12.Text = "PTO-P Remaining:"
		'
		'lblPTOPremain
		'
		Me.lblPTOPremain.AutoSize = True
		Me.lblPTOPremain.BackColor = System.Drawing.SystemColors.Control
		Me.lblPTOPremain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPTOPremain.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPTOPremain.Location = New System.Drawing.Point(484, 179)
		Me.lblPTOPremain.MinimumSize = New System.Drawing.Size(100, 20)
		Me.lblPTOPremain.Name = "lblPTOPremain"
		Me.lblPTOPremain.Size = New System.Drawing.Size(100, 20)
		Me.lblPTOPremain.TabIndex = 36
		Me.lblPTOPremain.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(366, 134)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(112, 17)
		Me.Label10.TabIndex = 33
		Me.Label10.Text = "PTO-R Remaining:"
		'
		'lblPTORremain
		'
		Me.lblPTORremain.AutoSize = True
		Me.lblPTORremain.BackColor = System.Drawing.SystemColors.Control
		Me.lblPTORremain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPTORremain.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPTORremain.Location = New System.Drawing.Point(484, 131)
		Me.lblPTORremain.MinimumSize = New System.Drawing.Size(100, 20)
		Me.lblPTORremain.Name = "lblPTORremain"
		Me.lblPTORremain.Size = New System.Drawing.Size(100, 20)
		Me.lblPTORremain.TabIndex = 34
		Me.lblPTORremain.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'btnClearPTO
		'
		Me.btnClearPTO.Location = New System.Drawing.Point(12, 246)
		Me.btnClearPTO.Name = "btnClearPTO"
		Me.btnClearPTO.Size = New System.Drawing.Size(86, 25)
		Me.btnClearPTO.TabIndex = 32
		Me.btnClearPTO.Text = "Clear PTO"
		Me.ClearPTOToolTip.SetToolTip(Me.btnClearPTO, "Click here if you need to change your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Regular and Protected PTO hours.")
		Me.btnClearPTO.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(679, 666)
		Me.Controls.Add(Me.txtPTOPused)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtPTORused)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtPTOPtotal)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.btnPTOI)
		Me.Controls.Add(Me.txtPTORtotal)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.txtBoxScheduled)
		Me.Controls.Add(Me.txtEndTime)
		Me.Controls.Add(Me.txtStartTime)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.btnEnter)
		Me.Controls.Add(Me.cbxPTOP)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.dtpPTO)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox2)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ASIC PTO Tracker"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.picASIC, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label1 As Label
	Friend WithEvents dtpPTO As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents cbxPTOP As CheckBox
	Friend WithEvents btnEnter As Button
	Friend WithEvents picASIC As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtStartTime As TextBox
	Friend WithEvents txtEndTime As TextBox
	Friend WithEvents txtBoxScheduled As TextBox
	Friend WithEvents btnEditTime As Button
	Friend WithEvents PTOToolTip1 As ToolTip
	Friend WithEvents PTOToolTip2 As ToolTip
	Friend WithEvents EditToolTip As ToolTip
	Friend WithEvents btnRefresh As Button
	Friend WithEvents RefreshToolTip As ToolTip
	Friend WithEvents btnExit As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents txtPTORtotal As TextBox
	Friend WithEvents PTOHoursToolTip As ToolTip
	Friend WithEvents btnPTOI As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtPTOPtotal As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents PTOPToolTip As ToolTip
	Friend WithEvents PTOPBoxToolTip As ToolTip
	Friend WithEvents txtPTOPused As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtPTORused As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents btnPTOU As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents lblOverall As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnClearPTO As Button
	Friend WithEvents ClearPTOToolTip As ToolTip
	Friend WithEvents Label12 As Label
	Friend WithEvents lblPTOPremain As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents lblPTORremain As Label
End Class
