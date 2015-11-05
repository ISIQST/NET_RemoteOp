<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSimple
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents lstStatus As System.Windows.Forms.ListBox
	Public WithEvents pbMainProgress As System.Windows.Forms.ProgressBar
	Public WithEvents cmdStop As System.Windows.Forms.Button
	Public WithEvents cmdStart As System.Windows.Forms.Button
	Public WithEvents txtLotNumber As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSimple))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.lstStatus = New System.Windows.Forms.ListBox
		Me.pbMainProgress = New System.Windows.Forms.ProgressBar
		Me.cmdStop = New System.Windows.Forms.Button
		Me.cmdStart = New System.Windows.Forms.Button
		Me.txtLotNumber = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Custom User Interface"
		Me.ClientSize = New System.Drawing.Size(654, 330)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmSimple.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSimple"
		Me.lstStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lstStatus.Size = New System.Drawing.Size(427, 187)
		Me.lstStatus.Location = New System.Drawing.Point(26, 74)
		Me.lstStatus.TabIndex = 5
		Me.lstStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstStatus.BackColor = System.Drawing.SystemColors.Window
		Me.lstStatus.CausesValidation = True
		Me.lstStatus.Enabled = True
		Me.lstStatus.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstStatus.IntegralHeight = True
		Me.lstStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstStatus.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstStatus.Sorted = False
		Me.lstStatus.TabStop = True
		Me.lstStatus.Visible = True
		Me.lstStatus.MultiColumn = False
		Me.lstStatus.Name = "lstStatus"
		Me.pbMainProgress.Size = New System.Drawing.Size(427, 39)
		Me.pbMainProgress.Location = New System.Drawing.Point(26, 280)
		Me.pbMainProgress.TabIndex = 4
		Me.pbMainProgress.Name = "pbMainProgress"
		Me.cmdStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdStop.Size = New System.Drawing.Size(145, 145)
		Me.cmdStop.Location = New System.Drawing.Point(484, 176)
		Me.cmdStop.Image = CType(resources.GetObject("cmdStop.Image"), System.Drawing.Image)
		Me.cmdStop.TabIndex = 3
		Me.cmdStop.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStop.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStop.CausesValidation = True
		Me.cmdStop.Enabled = True
		Me.cmdStop.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStop.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStop.TabStop = True
		Me.cmdStop.Name = "cmdStop"
		Me.cmdStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdStart.Size = New System.Drawing.Size(145, 145)
		Me.cmdStart.Location = New System.Drawing.Point(484, 20)
		Me.cmdStart.Image = CType(resources.GetObject("cmdStart.Image"), System.Drawing.Image)
		Me.cmdStart.TabIndex = 2
		Me.cmdStart.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStart.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStart.CausesValidation = True
		Me.cmdStart.Enabled = True
		Me.cmdStart.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStart.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStart.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStart.TabStop = True
		Me.cmdStart.Name = "cmdStart"
		Me.txtLotNumber.AutoSize = False
		Me.txtLotNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtLotNumber.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLotNumber.Size = New System.Drawing.Size(265, 41)
		Me.txtLotNumber.Location = New System.Drawing.Point(188, 22)
		Me.txtLotNumber.Maxlength = 15
		Me.txtLotNumber.TabIndex = 1
		Me.txtLotNumber.Text = "AAA123"
		Me.txtLotNumber.AcceptsReturn = True
		Me.txtLotNumber.BackColor = System.Drawing.SystemColors.Window
		Me.txtLotNumber.CausesValidation = True
		Me.txtLotNumber.Enabled = True
		Me.txtLotNumber.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLotNumber.HideSelection = True
		Me.txtLotNumber.ReadOnly = False
		Me.txtLotNumber.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLotNumber.MultiLine = False
		Me.txtLotNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLotNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtLotNumber.TabStop = True
		Me.txtLotNumber.Visible = True
		Me.txtLotNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtLotNumber.Name = "txtLotNumber"
		Me.Label1.Text = "Lot Number"
		Me.Label1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(137, 25)
		Me.Label1.Location = New System.Drawing.Point(26, 28)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(lstStatus)
		Me.Controls.Add(pbMainProgress)
		Me.Controls.Add(cmdStop)
		Me.Controls.Add(cmdStart)
		Me.Controls.Add(txtLotNumber)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class