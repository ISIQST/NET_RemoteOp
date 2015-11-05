Option Strict Off
Option Explicit On
Friend Class clsQuasiEvents
	
	Public WithEvents TestSeqEvnts As Quasi97.TestSequencer
	
	Private Sub QuasiEvnts_CloseLogFileInitiate(ByRef FileName As String, ByRef abort As Boolean)
		'UPGRADE_NOTE: Object TestSeqEvnts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		TestSeqEvnts = Nothing
	End Sub
	
	Private Sub TestSeqEvnts_RunTestInitiate() Handles TestSeqEvnts.RunTestInitiate
		EndTest = False
	End Sub
	
	Private Sub TestSeqEvnts_RunTestTerminate() Handles TestSeqEvnts.RunTestTerminate
		EndTest = True
	End Sub
End Class