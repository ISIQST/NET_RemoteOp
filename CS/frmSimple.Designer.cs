// VBConversions Note: VB project level imports
using System;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace RemoteOp
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmSimple
	{
#region Windows Form Designer generated code
		[System.Diagnostics.DebuggerNonUserCode()]public frmSimple()
		{
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool Disposing)
		{
			if (Disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.ListBox lstStatus;
		public System.Windows.Forms.ProgressBar pbMainProgress;
		public System.Windows.Forms.Button cmdStop;
		public System.Windows.Forms.Button cmdStart;
		public System.Windows.Forms.TextBox txtLotNumber;
		public System.Windows.Forms.Label Label1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSimple));
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmSimple_Load);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.lstStatus = new System.Windows.Forms.ListBox();
			this.pbMainProgress = new System.Windows.Forms.ProgressBar();
			this.cmdStop = new System.Windows.Forms.Button();
			this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
			this.cmdStart = new System.Windows.Forms.Button();
			this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
			this.txtLotNumber = new System.Windows.Forms.TextBox();
			this.txtLotNumber.Click += new System.EventHandler(this.txtLotNumber_Click);
			this.txtLotNumber.Enter += new System.EventHandler(this.txtLotNumber_Enter);
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.ToolTip1.Active = true;
			this.Text = "Custom User Interface";
			this.ClientSize = new System.Drawing.Size(654, 330);
			this.Location = new System.Drawing.Point(4, 23);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("frmSimple.Icon"));
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			this.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.ControlBox = true;
			this.Enabled = true;
			this.KeyPreview = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = true;
			this.HelpButton = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Name = "frmSimple";
			this.lstStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstStatus.Size = new System.Drawing.Size(427, 187);
			this.lstStatus.Location = new System.Drawing.Point(26, 74);
			this.lstStatus.TabIndex = 5;
			this.lstStatus.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lstStatus.BackColor = System.Drawing.SystemColors.Window;
			this.lstStatus.CausesValidation = true;
			this.lstStatus.Enabled = true;
			this.lstStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstStatus.IntegralHeight = true;
			this.lstStatus.Cursor = System.Windows.Forms.Cursors.Default;
			this.lstStatus.SelectionMode = System.Windows.Forms.SelectionMode.One;
			this.lstStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lstStatus.Sorted = false;
			this.lstStatus.TabStop = true;
			this.lstStatus.Visible = true;
			this.lstStatus.MultiColumn = false;
			this.lstStatus.Name = "lstStatus";
			this.pbMainProgress.Size = new System.Drawing.Size(427, 39);
			this.pbMainProgress.Location = new System.Drawing.Point(26, 280);
			this.pbMainProgress.TabIndex = 4;
			this.pbMainProgress.Name = "pbMainProgress";
			this.cmdStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdStop.Size = new System.Drawing.Size(145, 145);
			this.cmdStop.Location = new System.Drawing.Point(484, 176);
			this.cmdStop.Image = (System.Drawing.Image) (resources.GetObject("cmdStop.Image"));
			this.cmdStop.TabIndex = 3;
			this.cmdStop.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdStop.BackColor = System.Drawing.SystemColors.Control;
			this.cmdStop.CausesValidation = true;
			this.cmdStop.Enabled = true;
			this.cmdStop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdStop.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdStop.TabStop = true;
			this.cmdStop.Name = "cmdStop";
			this.cmdStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdStart.Size = new System.Drawing.Size(145, 145);
			this.cmdStart.Location = new System.Drawing.Point(484, 20);
			this.cmdStart.Image = (System.Drawing.Image) (resources.GetObject("cmdStart.Image"));
			this.cmdStart.TabIndex = 2;
			this.cmdStart.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdStart.BackColor = System.Drawing.SystemColors.Control;
			this.cmdStart.CausesValidation = true;
			this.cmdStart.Enabled = true;
			this.cmdStart.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdStart.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdStart.TabStop = true;
			this.cmdStart.Name = "cmdStart";
			this.txtLotNumber.AutoSize = false;
			this.txtLotNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtLotNumber.Font = new System.Drawing.Font("Courier New", 18, (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtLotNumber.Size = new System.Drawing.Size(265, 41);
			this.txtLotNumber.Location = new System.Drawing.Point(188, 22);
			this.txtLotNumber.MaxLength = 15;
			this.txtLotNumber.TabIndex = 1;
			this.txtLotNumber.Text = "AAA123";
			this.txtLotNumber.AcceptsReturn = true;
			this.txtLotNumber.BackColor = System.Drawing.SystemColors.Window;
			this.txtLotNumber.CausesValidation = true;
			this.txtLotNumber.Enabled = true;
			this.txtLotNumber.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtLotNumber.HideSelection = true;
			this.txtLotNumber.ReadOnly = false;
			this.txtLotNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLotNumber.Multiline = false;
			this.txtLotNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtLotNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtLotNumber.TabStop = true;
			this.txtLotNumber.Visible = true;
			this.txtLotNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtLotNumber.Name = "txtLotNumber";
			this.Label1.Text = "Lot Number";
			this.Label1.Font = new System.Drawing.Font("Courier New", (float) (15.75F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Size = new System.Drawing.Size(137, 25);
			this.Label1.Location = new System.Drawing.Point(26, 28);
			this.Label1.TabIndex = 0;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Enabled = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.UseMnemonic = true;
			this.Label1.Visible = true;
			this.Label1.AutoSize = false;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Name = "Label1";
			this.Controls.Add(lstStatus);
			this.Controls.Add(pbMainProgress);
			this.Controls.Add(cmdStop);
			this.Controls.Add(cmdStart);
			this.Controls.Add(txtLotNumber);
			this.Controls.Add(Label1);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
#endregion
	}
}
