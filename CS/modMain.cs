using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;

namespace RemoteOp
{
	sealed class modMain
	{
		
		public static Quasi97.Application qst;
		public static object MechHandler; //BarContLib.Driver
		public static clsQuasiEvents QuasiEvents;
		public static clsLotInfo LotINFO = new clsLotInfo();
		public const short LOGEXCEL = 2;
		public const short LOGCSV = 3;
		public const short LOGCSVSINGLE = 4;
		
		public static bool EndTest;
		public static frmSimple objFrmSimple = new frmSimple();
		
		static public void LoadTestSetup(string TestProgramFile)
		{
			
			try
			{
				
				//open a setup file
				if (qst.QuasiParameters.SetupFileName != TestProgramFile)
				{
					objFrmSimple.Status = "Loading Setup Database " + TestProgramFile;
					qst.QuasiParameters.OpenSetupFile(ref TestProgramFile);
					System.Windows.Forms.Application.DoEvents();
				}
				//Set the Operator ID etc (not necessary but usually desired)
				qst.SystemParameters.OperatorID = "Remote";
				
			}
			catch (Exception ex)
			{
				errorhandler(ex);
			}
		}
		
		static public Microsoft.VisualBasic.MsgBoxResult  errorhandler(Exception ex)
		{
			if (ex != null)
			{
				return Interaction.MsgBox(" [" + ex.Source + "] : " + ex.Message, MsgBoxStyle.AbortRetryIgnore, Information.Err().Source);
			}
			else
			{
				return (short)  0;
			}
		}
	}
}
