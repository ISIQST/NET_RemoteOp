Option Strict Off
Option Explicit On

Imports System.Collections.Generic

Public Class clsHOption
    Implements Quasi97.iHOption

    Private Const errModID As String = "clsHOption: " 'identifier for errorhandlers
    Private Notifiers As New List(Of Object) 'all the objects in this collection should be notified about user feedback and others - whatever this application deems necessary
    Private mvarInstanceName As String = "" 'identifier or instance in Quasi97

    Private Enum eEventInt
        eCheckHealth = 1
        eRecover = 2
        eStartStop = 4
        eConnectHead = 8
        eSetupOpenClose = &H10
    End Enum

    Public ReadOnly Property Present() As Boolean
        Get
            Return True
        End Get
    End Property

    Sub UpdateUserFeedback(ByRef lastUserFeeback As String, ByRef prg As Single)
        For Each s As Object In Notifiers
            s.Message = lastUserFeeback
            s.Progress = prg
        Next s
    End Sub

    Public Function ID() As String
        ID = "RemoteOp.clsHOption"
    End Function

    Public Sub AddNotifier(ByRef objnot As Object) Implements Quasi97.iHOption.AddNotifier
        If Not Notifiers.Contains(objnot) Then Notifiers.Add(objnot)
    End Sub

    Public Function CheckHealth(ByRef usrDescr As String, PartLoadedState As Byte) As Short Implements Quasi97.iHOption.CheckHealth
        'the module will use this call as an opportunity to check itself
        'if fails this would return non-zero value and change the status. partloadedstate non-zero indicates that the head is probing (perhaps some checks can be done only while not probing the head)
        Dim i, N As Short

        On Error Resume Next
        ''
        ''   If curHDW.VerifyPower(True) = 0 Then
        ''      CheckHealth = 1001
        ''      usrDescr = "Power loss has been detected"
        ''      Call gUserMsgBox(usrDescr, vbCritical Or vbOKOnly)
        ''
        ''      Dim s As Object
        ''      For Each s In Notifier
        ''         Call s.DoEvent(Me, "SuspendFlag", True)
        ''      Next
        ''      HDWSuspended = 2              'more critical error, need to reinitialize
        ''   End If
    End Function

    Public Sub ConnectHead(ByRef doConnect As Byte) Implements Quasi97.iHOption.ConnectHead

    End Sub

    Public Sub CurrentHeadInitiate(ByRef hdnum As Short) Implements Quasi97.iHOption.CurrentHeadInitiate

    End Sub

    Public Sub CurrentHeadTerminate(hdNum As Short) Implements Quasi97.iHOption.CurrentHeadTerminate

    End Sub

    Public Sub DetectAllNew(ByRef Devs1Based() As String) Implements Quasi97.iHOption.DetectAllNew
        'the items in the collection must be easily identifiable for "Initialize" function later on

        'read serial number from the board and add it to the collection
        ReDim Devs1Based(1)
        Devs1Based(1) = ""
    End Sub

    Public ReadOnly Property EventInterests As Integer Implements Quasi97.iHOption.EventInterests
        Get
            Return &H14 'eEventInt.eCheckHealth Or eEventInt.eRecover Or eEventInt.eConnectHead Or eEventInt.eSetupOpenClose Or eEventInt.eStartStop
        End Get
    End Property

    Public Sub GetChannels(ByRef Channels() As Short) Implements Quasi97.iHOption.GetChannels

    End Sub

    Public Function GetNewProperties2(ByRef propDetails(,) As String) As Object Implements Quasi97.iHOption.GetNewProperties2
        'propdetails has 1+colobjects.count number of rows and 4 columns.
        'Call AddCustomProperty("AC Gain (dB)", "ACGaindB", False, Round(MinACGaindB, 1) & ";" & Round(MaxACGaindB, 1), False, colobjects, propDetails, Me)
        Return Nothing
    End Function

    Public Sub Initialize3(InstanceName As String, ByRef AppPtr As Object) Implements Quasi97.iHOption.Initialize3
        Try

            mvarInstanceName = InstanceName

            If objFrmSimple IsNot Nothing AndAlso Not objFrmSimple.IsDisposed Then objFrmSimple.Close()
            objFrmSimple = New frmSimple

            'connect to Quasi97.application object to start the quasi software
            qst = CType(AppPtr, Quasi97.Application)

            'Set the remote flag in the Integral Solutions Int'l/common/Quasi.ini file
            qst.RemoteMode = 1

            'show user GUI
            objFrmSimple.Show()
            objFrmSimple.TopMost = True

            'set the event handler
            Call UpdateUserFeedback("Initializing QuasiEvents", 0)
            QuasiEvents = New clsQuasiEvents
            Call UpdateUserFeedback("Connecting to Barcont", 0)
            Dim hopt As Quasi97.clsHardwareOption
            hopt = CType(qst.HOptionManager.GetPointerByFunctionNET("MechDriver"), Quasi97.clsHardwareOption)
            If Not hopt Is Nothing Then
                MechHandler = hopt.GetHandle
            Else
                Call UpdateUserFeedback("Failed to find MechDriver", 0)
            End If
            '   Set BarEvents = New clsBarEvents

            Call objFrmSimple.EnableControls()
            'function will be called to activate the module

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public WriteOnly Property NetHostCallBack As Object Implements Quasi97.iHOption.NetHostCallBack
        Set(value As Object)

        End Set
    End Property

    Public Sub NotifyOptionsUpdated() Implements Quasi97.iHOption.NotifyOptionsUpdated
        'signals to the module that other modules have changed (configuration)

    End Sub

    Public Function Recover(ByRef usrDescr As String) As Short Implements Quasi97.iHOption.Recover
        'module will use this call as an opportunity to recover from checkhealth suspension. For example if interlock door was opened
        '0 means success
        ''   If HDWSuspended = 1 Then
        ''      HDWSuspended = 0 'occurs for the first time after everything is aborted and stop button is pressed
        ''   ElseIf HDWSuspended = 2 Then
        ''      Unload objFrmPulserDiag
        ''      Unload objFrmUser
        ''      Call curHDW.Initialize(mvarCurrentApp)
        ''      Dim s As Object
        ''      For Each s In Notifier
        ''         Call s.DoEvent(Me, "SuspendFlag", False)
        ''      Next
        ''      HDWSuspended = 0
        ''   End If
        'no critical errors are yet detecetd
        Return 0
    End Function

    Public Sub RemoveNotifier(ByRef objnot As Object) Implements Quasi97.iHOption.RemoveNotifier
        If Notifiers.Contains(objnot) Then Notifiers.Remove(objnot)
    End Sub

    Public Sub SetChannels(ByRef Channels() As Short) Implements Quasi97.iHOption.SetChannels
        ''   mvarChannels = Channels       'copying the array here
        ''   Dim i%, j%
        ''
        ''   For i = 0 To UBound(channelLUT)
        ''      channelLUT(i) = False
        ''   Next i
        ''
        ''   For i = 0 To UBound(mvarChannels)
        ''      channelLUT(mvarChannels(i)) = True
        ''   Next i
        ''   curHDW.AssignedChannel = mvarChannels(0) Mod 2
    End Sub

    Public Sub SetupOpenClose(DoOpen As Boolean) Implements Quasi97.iHOption.SetupOpenClose
        'signals to the module that setup open or setup close is in progress
        If DoOpen Then
            QuasiEvents.TestSeqEvnts = qst.TestSequencer
        Else
            QuasiEvents.TestSeqEvnts = Nothing
        End If
    End Sub

    Public Sub ShowDiagnostics() Implements Quasi97.iHOption.ShowDiagnostics
        objFrmSimple.Show()
    End Sub

    Public Sub ShowUserMenu() Implements Quasi97.iHOption.ShowUserMenu
        objFrmSimple.Show()
    End Sub

    Public Sub StartStop(ByRef doStart As Boolean) Implements Quasi97.iHOption.StartStop
        'user presses start, the module may need to prepare (turn on relays, initialize something etc) - all of the slow processes
        If doStart Then
            'todo: do something when operator starts test
        Else
            'todo: do something when the test is finished
        End If
    End Sub

    Public ReadOnly Property Status As Short Implements Quasi97.iHOption.Status
        Get
            'retrieves the current status from the device
            Status = 0
        End Get
    End Property

    Public Sub Terminate() Implements Quasi97.iHOption.Terminate
        Notifiers.Clear()
        objFrmSimple.Close()
        MechHandler = Nothing
        qst = Nothing
    End Sub

    Public ReadOnly Property UserControl As String Implements Quasi97.iHOption.UserControl
        Get
            Return ""
        End Get
    End Property
End Class