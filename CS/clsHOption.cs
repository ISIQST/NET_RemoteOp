using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RemoteOp
{
	public class clsHOption : Quasi97.iHOption
	{
		
		private const string errModID = "clsHOption: "; //identifier for errorhandlers
		private List<object> Notifiers = new List<object>(); //all the objects in this collection should be notified about user feedback and others - whatever this application deems necessary
		private string mvarInstanceName = ""; //identifier or instance in Quasi97
		
		private enum eEventInt
		{
			eCheckHealth = 1,
			eRecover = 2,
			eStartStop = 4,
			eConnectHead = 8,
			eSetupOpenClose = 0x10
		}
		
public bool Present
		{
			get
			{
				return true;
			}
		}
		
		public void UpdateUserFeedback(string lastUserFeeback, float prg)
		{
			foreach (dynamic s in Notifiers)
			{
				s.Message = lastUserFeeback;
				s.Progress = prg;
			}
		}
		
		public string ID()
		{
			string returnValue = "";
			returnValue = "RemoteOp.clsHOption";
			return returnValue;
		}
		
		public void AddNotifier(ref object objnot)
		{
			if (!Notifiers.Contains(objnot))
			{
				Notifiers.Add(objnot);
			}
		}
		
		public short CheckHealth(ref string usrDescr, byte PartLoadedState)
		{
			//the module will use this call as an opportunity to check itself
			//if fails this would return non-zero value and change the status. partloadedstate non-zero indicates that the head is probing (perhaps some checks can be done only while not probing the head)
			//short i;
			//short N;
			
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			//'
			//'   If curHDW.VerifyPower(True) = 0 Then
			//'      CheckHealth = 1001
			//'      usrDescr = "Power loss has been detected"
			//'      Call gUserMsgBox(usrDescr, vbCritical Or vbOKOnly)
			//'
			//'      Dim s As Object
			//'      For Each s In Notifier
			//'         Call s.DoEvent(Me, "SuspendFlag", True)
			//'      Next
			//'      HDWSuspended = 2              'more critical error, need to reinitialize
			//'   End If
            return 0;
		}
		
		public void ConnectHead(ref byte doConnect)
		{
			
		}
		
		public void CurrentHeadInitiate(ref short hdnum)
		{
			
		}
		
		public void CurrentHeadTerminate(short hdNum)
		{
			
		}
		
		public void DetectAllNew(ref string[] Devs1Based)
		{
			//the items in the collection must be easily identifiable for "Initialize" function later on
			
			//read serial number from the board and add it to the collection
			Devs1Based = new string[2];
			Devs1Based[1] = "";
		}
		
public int EventInterests
		{
			get
			{
				return 0x14; //eEventInt.eCheckHealth Or eEventInt.eRecover Or eEventInt.eConnectHead Or eEventInt.eSetupOpenClose Or eEventInt.eStartStop
			}
		}
		
		public void GetChannels(ref short[] Channels)
		{
			
		}
		
		public dynamic GetNewProperties2(ref string[,] propDetails)
		{
			//propdetails has 1+colobjects.count number of rows and 4 columns.
			//Call AddCustomProperty("AC Gain (dB)", "ACGaindB", False, Round(MinACGaindB, 1) & ";" & Round(MaxACGaindB, 1), False, colobjects, propDetails, Me)
			return null;
		}
		
		public void Initialize3(string InstanceName, ref object AppPtr)
		{
			try
			{
				
				mvarInstanceName = InstanceName;
				
				if (modMain.objFrmSimple != null && !modMain.objFrmSimple.IsDisposed)
				{
					modMain.objFrmSimple.Close();
				}
				modMain.objFrmSimple = new frmSimple();
				modMain.objFrmSimple.FormClosing += modMain.objFrmSimple.frmSimple_FormClosing;
				
				//connect to Quasi97.application object to start the quasi software
				modMain.qst = (Quasi97.Application) AppPtr;
				
				//Set the remote flag in the Integral Solutions Int'l/common/Quasi.ini file
				modMain.qst.RemoteMode = 1;
				
				//show user GUI
				modMain.objFrmSimple.Show();
				modMain.objFrmSimple.TopMost = true;
				
				//set the event handler
				UpdateUserFeedback("Initializing QuasiEvents", 0);
				modMain.QuasiEvents = new clsQuasiEvents();
				UpdateUserFeedback("Connecting to Barcont", 0);
				Quasi97.clsHardwareOption hopt = default(Quasi97.clsHardwareOption);
				hopt = (Quasi97.clsHardwareOption) (modMain.qst.HOptionManager.GetPointerByFunctionNET("MechDriver"));
				if (!(hopt == null))
				{
					modMain.MechHandler = hopt.GetHandle();
				}
				else
				{
					UpdateUserFeedback("Failed to find MechDriver", 0);
				}
				//   Set BarEvents = New clsBarEvents
				
				modMain.objFrmSimple.EnableControls(true);
				//function will be called to activate the module
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
public dynamic NetHostCallBack
		{
			set
			{
				
			}
		}
		
		public void NotifyOptionsUpdated()
		{
			//signals to the module that other modules have changed (configuration)
			
		}
		
		public short Recover(ref string usrDescr)
		{
			//module will use this call as an opportunity to recover from checkhealth suspension. For example if interlock door was opened
			//0 means success
			//'   If HDWSuspended = 1 Then
			//'      HDWSuspended = 0 'occurs for the first time after everything is aborted and stop button is pressed
			//'   ElseIf HDWSuspended = 2 Then
			//'      Unload objFrmPulserDiag
			//'      Unload objFrmUser
			//'      Call curHDW.Initialize(mvarCurrentApp)
			//'      Dim s As Object
			//'      For Each s In Notifier
			//'         Call s.DoEvent(Me, "SuspendFlag", False)
			//'      Next
			//'      HDWSuspended = 0
			//'   End If
			//no critical errors are yet detecetd
			return (short)  0;
		}
		
		public void RemoveNotifier(ref object objnot)
		{
			if (Notifiers.Contains(objnot))
			{
				Notifiers.Remove(objnot);
			}
		}
		
		public void SetChannels(ref short[] Channels)
		{
			//'   mvarChannels = Channels       'copying the array here
			//'   Dim i%, j%
			//'
			//'   For i = 0 To UBound(channelLUT)
			//'      channelLUT(i) = False
			//'   Next i
			//'
			//'   For i = 0 To UBound(mvarChannels)
			//'      channelLUT(mvarChannels(i)) = True
			//'   Next i
			//'   curHDW.AssignedChannel = mvarChannels(0) Mod 2
		}
		
		public void SetupOpenClose(bool DoOpen)
		{
			//signals to the module that setup open or setup close is in progress
			if (DoOpen)
			{
				modMain.QuasiEvents.TestSeqEvnts = modMain.qst.TestSequencer;
			}
			else
			{
				modMain.QuasiEvents.TestSeqEvnts = null;
			}
		}
		
		public void ShowDiagnostics()
		{
			modMain.objFrmSimple.Show();
		}
		
		public void ShowUserMenu()
		{
			modMain.objFrmSimple.Show();
		}
		
		public void StartStop(ref bool doStart)
		{
			//user presses start, the module may need to prepare (turn on relays, initialize something etc) - all of the slow processes
			if (doStart)
			{
				//todo: do something when operator starts test
			}
			else
			{
				//todo: do something when the test is finished
			}
		}
		
public short Status
		{
			get
			{
				short returnValue = 0;
				//retrieves the current status from the device
				returnValue = (short) 0;
				return returnValue;
			}
		}
		
		public void Terminate()
		{
			Notifiers.Clear();
			modMain.objFrmSimple.Close();
			modMain.MechHandler = null;
			modMain.qst = null;
		}
		
public string UserControl
		{
			get
			{
				return "";
			}
		}
	}
}
