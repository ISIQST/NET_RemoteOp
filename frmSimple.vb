Option Strict Off
Option Explicit On
Friend Class frmSimple
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStart.Click
		Status = "Loading Lot Information for LOT " & txtLotNumber.Text
		cmdStart.Enabled = False
		Call LotINFO.LoadLotInfo((txtLotNumber.Text))
		LotINFO.TestSetup = "c:\a.mds"
		Call LoadTestSetup((LotINFO.TestSetup))
		'BarDriver.AutomationEvents.TotalBars = LotINFO.LotSize
		'BarDriver.AutomationEvents.MoveToNthBar (LotINFO.FirstBar)
		'BarDriver.AutomationEvents.BarType = LotINFO.BarType
		'qst.SystemParameters.lotID = txtLotNumber.Text
		''Open a new log file
		qst.OptionsParameters.LogFileType = LOGCSV 'log file type definitions in globals
		qst.OptionsParameters.LogFileName = "c:\setups\" & LotINFO.TestSetup & CDate(Now) & LotINFO.lotID & " - NEW.csv"
		Call qst.QuasiParameters.OpenLogFile(qst.OptionsParameters.LogFileName)
		
		Status = "Starting the Test for LOT " & txtLotNumber.Text
		qst.QuasiParameters.Start = True
	End Sub
	
	Private Sub cmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStop.Click
		cmdStart.Enabled = True
		qst.QuasiParameters.AbortTest = True
	End Sub
	
	Private Sub frmSimple_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Call EnableControls(False)
	End Sub
	
	Private Sub frmSimple_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		QuasiEvents = Nothing
		Call qst.CloseApplication()
		qst = Nothing
		Exit Sub
	End Sub
	
	Public WriteOnly Property Status() As String
		Set(ByVal Value As String)
			lstStatus.Items.Insert(0, Value)
		End Set
	End Property
	
	Private Sub txtLotNumber_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLotNumber.Click
		txtLotNumber.SelectionStart = 0
		txtLotNumber.SelectionLength = Len(txtLotNumber.Text)
	End Sub
	
	Private Sub txtLotNumber_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLotNumber.Enter
		txtLotNumber.SelectionStart = 0
		txtLotNumber.SelectionLength = Len(txtLotNumber.Text)
	End Sub
	
	Public Sub EnableControls(Optional ByRef DoEnable As Boolean = True)
		txtLotNumber.Enabled = DoEnable
		cmdStart.Enabled = DoEnable
		cmdStop.Enabled = DoEnable
	End Sub
End Class