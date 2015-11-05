using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Collections;

namespace RemoteOp
{
	partial class frmSimple : System.Windows.Forms.Form
	{
		
		public void cmdStart_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			Status = "Loading Lot Information for LOT " + txtLotNumber.Text;
			cmdStart.Enabled = false;
			string temp_LotNumber = (txtLotNumber.Text);
			modMain.LotINFO.LoadLotInfo(ref temp_LotNumber);
			modMain.LotINFO.TestSetup = "c:\\a.mds";
			modMain.LoadTestSetup(modMain.LotINFO.TestSetup);
			//BarDriver.AutomationEvents.TotalBars = LotINFO.LotSize
			//BarDriver.AutomationEvents.MoveToNthBar (LotINFO.FirstBar)
			//BarDriver.AutomationEvents.BarType = LotINFO.BarType
			//qst.SystemParameters.lotID = txtLotNumber.Text
			//'Open a new log file
			modMain.qst.OptionsParameters.LogFileType = modMain.LOGCSV; //log file type definitions in globals
			modMain.qst.OptionsParameters.LogFileName = "c:\\setups\\" + modMain.LotINFO.TestSetup + System.Convert.ToString(DateTime.Now) + modMain.LotINFO.lotID + " - NEW.csv";
            string lfn = modMain.qst.OptionsParameters.LogFileName;
            string ret = modMain.qst.QuasiParameters.OpenLogFile(ref lfn);
			
			Status = "Starting the Test for LOT " + txtLotNumber.Text;
			modMain.qst.QuasiParameters.Start = true;
		}
		
		public void cmdStop_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			cmdStart.Enabled = true;
			modMain.qst.QuasiParameters.AbortTest = true;
		}
		
		public void frmSimple_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			EnableControls(false);
		}
		
		public void frmSimple_FormClosing(System.Object eventSender, System.Windows.Forms.FormClosingEventArgs eventArgs)
		{
			modMain.QuasiEvents = null;
			modMain.qst.CloseApplication();
			modMain.qst = null;
			return;
		}
		
public string Status
		{
			set
			{
				lstStatus.Items.Insert(0, value);
			}
		}
		
		public void txtLotNumber_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			txtLotNumber.SelectionStart = 0;
			txtLotNumber.SelectionLength = txtLotNumber.Text.Length;
		}
		
		public void txtLotNumber_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			txtLotNumber.SelectionStart = 0;
			txtLotNumber.SelectionLength = txtLotNumber.Text.Length;
		}
		
		public void EnableControls(bool DoEnable)
		{
			txtLotNumber.Enabled = DoEnable;
			cmdStart.Enabled = DoEnable;
			cmdStop.Enabled = DoEnable;
		}
	}
}
