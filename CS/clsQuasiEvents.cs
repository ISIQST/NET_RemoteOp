using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Collections;
using System.Windows.Forms;


namespace RemoteOp
{
	internal class clsQuasiEvents
	{
		
		public Quasi97.TestSequencer TestSeqEvnts;
		
		private void QuasiEvnts_CloseLogFileInitiate(string FileName, bool abort)
		{
			TestSeqEvnts = null;
			TestSeqEvnts.RunTestInitiate += this.TestSeqEvnts_RunTestInitiate;
			TestSeqEvnts.RunTestTerminate += this.TestSeqEvnts_RunTestTerminate;
		}
		
		public void TestSeqEvnts_RunTestInitiate()
		{
			modMain.EndTest = false;
		}
		
		public void TestSeqEvnts_RunTestTerminate()
		{
			modMain.EndTest = true;
		}
	}
}
