Option Strict Off
Option Explicit On
Module modMain
	
    Public qst As Quasi97.Application
    Public MechHandler As Object 'BarContLib.Driver
	Public QuasiEvents As clsQuasiEvents
	Public LotINFO As New clsLotInfo
	Public Const LOGEXCEL As Short = 2
	Public Const LOGCSV As Short = 3
	Public Const LOGCSVSINGLE As Short = 4

    Public EndTest As Boolean
	Public objFrmSimple As New frmSimple
	Public gNetHostCallBack As Object
	
    Sub LoadTestSetup(ByRef TestProgramFile As String)

        Try

            'open a setup file
            If qst.QuasiParameters.SetupFileName <> TestProgramFile Then
                objFrmSimple.Status = "Loading Setup Database " & TestProgramFile
                qst.QuasiParameters.OpenSetupFile(TestProgramFile)
                System.Windows.Forms.Application.DoEvents()
            End If
            'Set the Operator ID etc (not necessary but usually desired)
            qst.SystemParameters.OperatorID = "Remote"

        Catch ex As Exception
            errorhandler(ex)
        End Try
    End Sub

    Function errorhandler(ByVal ex As Exception) As Short
        If ex IsNot Nothing Then
            Return MsgBox(" [" & ex.Source & "] : " & ex.Message, MsgBoxStyle.AbortRetryIgnore, Err.Source)
        Else
            Return 0
        End If
    End Function
End Module