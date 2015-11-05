using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace RemoteOp
{
	internal class clsLotInfo
	{
		
		public string TestSetup;
		public string LotSize;
		public string FirstBar;
		//public short BarType;
		public string lotID;
		
		private bool[,] BarMap;
		//private bool[] HeadMap;
		private string[] HeadsToSkip;
		
		public void LoadLotInfo(ref string LotNumber)
		{
			//TODO: Look up the lot information on the network.
			lotID = LotNumber;
			if (LotNumber == "LOT#1")
			{
				TestSetup = "c:\\Setups\\1.mds";
				LoadBarMap(LotNumber);
				LotSize = (4).ToString(); //there are ten bars in the lot, including the ones that are not present in the tray
				FirstBar = (3).ToString(); //first bar is 0
				//    BarType = HeadType.DOWN     'only down heads are in this lot
				HeadsToSkip = new string[6];
				HeadsToSkip[0] = "5C6DA0F501";
				HeadsToSkip[1] = "5C6DA0F502";
				HeadsToSkip[2] = "5C6DA0F503";
				HeadsToSkip[3] = "5C6DA0F504";
				HeadsToSkip[4] = "5C6DA0F505";
				HeadsToSkip[5] = "5C6DA0F510";
			}
			else if (LotNumber == "LOT#2")
			{
				TestSetup = "c:\\Setups\\2.mds";
				LotSize = (10).ToString(); //there are ten bars in the lot, including the ones that are not present in the tray
				FirstBar = (3).ToString(); //first bar is 0
				//    BarType = HeadType.UP       'only down heads are in this lot
				LoadBarMap(LotNumber);
				HeadsToSkip = new string[6];
				HeadsToSkip[0] = "5C6DA0B720";
				HeadsToSkip[1] = "5C6DA0B721";
				HeadsToSkip[2] = "5C6DA0B722";
				HeadsToSkip[3] = "5C6DA0B723";
				HeadsToSkip[4] = "5C6DA0B724";
				HeadsToSkip[5] = "5C6DA0B725";
			}
		}
		
		public void LoadBarMap(string lotIDStr)
		{
			if (lotIDStr == "LOT#1")
			{
				BarMap = new bool[1, 23];
				BarMap[0, 0] = true; //bar is present in tray 0, slot 0
				BarMap[0, 1] = true;
				BarMap[0, 2] = true;
				BarMap[0, 3] = true;
				BarMap[0, 4] = false; //bar is not present in Tray 0, slot 4
				BarMap[0, 5] = false; //bar is not present in Tray 0, slot 4
				BarMap[0, 6] = false; //bar is not present in Tray 0, slot 4
				BarMap[0, 7] = false; //bar is not present in Tray 0, slot 4
				BarMap[0, 8] = false; //bar is not present in Tray 0, slot 4
				BarMap[0, 9] = false; //bar is not present in Tray 0, slot 4
				BarMap[0, 10] = false; //bar is not present in Tray 0, slot 4
			}
			else if (lotIDStr == "LOT#1")
			{
				BarMap = new bool[1, 23];
				BarMap[0, 0] = false; //bar is present in tray 0, slot 0
				BarMap[0, 1] = false;
				BarMap[0, 2] = false;
				BarMap[0, 3] = true;
				BarMap[0, 4] = true; //bar is not present in Tray 0, slot 4
				BarMap[0, 5] = true; //bar is not present in Tray 0, slot 4
				BarMap[0, 6] = true; //bar is not present in Tray 0, slot 4
				BarMap[0, 7] = true; //bar is not present in Tray 0, slot 4
				BarMap[0, 8] = true; //bar is not present in Tray 0, slot 4
				BarMap[0, 9] = true; //bar is not present in Tray 0, slot 4
				BarMap[0, 10] = true; //bar is not present in Tray 0, slot 4
			}
		}
		
		public bool IsBarPresent(short traynum, short barnum)
		{
			bool returnValue = default(bool);
			returnValue = BarMap[traynum, barnum];
			return returnValue;
		}
		
		public bool IsHeadEnabled(string sn)
		{
			bool returnValue = default(bool);
			short i = 0;
			returnValue = true;
			for (i = 0; i <= (HeadsToSkip.Length - 1); i++)
			{
				if (HeadsToSkip[i] == sn)
				{
					returnValue = false;
					break;
				}
			}
			return returnValue;
		}
	}
}
