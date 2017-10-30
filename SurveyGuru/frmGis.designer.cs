
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
partial class frmGis : System.Windows.Forms.Form
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		try {
			if (disposing && components != null) {
				components.Dispose();
			}
		} finally {
			base.Dispose(disposing);
		}
	}

	//Required by the Windows Form Designer

	private System.ComponentModel.IContainer components;
	//NOTE: The following procedure is required by the Windows Form Designer
	//It can be modified using the Windows Form Designer.  
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGis));
		this.AxArcReaderControl1 = new ESRI.ArcGIS.PublisherControls.AxArcReaderControl();
		this.cboLayers = new System.Windows.Forms.ComboBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.optZoomIn = new System.Windows.Forms.ToolStripButton();
		this.optZoomOut = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.cmdFullExtent = new System.Windows.Forms.ToolStripButton();
		this.optPan = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.IdentityBtn = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.NewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
		this.SaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
		this.PrintToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.PrintPreviewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
		this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZoomToFullExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.IdentityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ExportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ContentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.IndexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.SearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
		this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		((System.ComponentModel.ISupportInitialize)this.AxArcReaderControl1).BeginInit();
		this.StatusStrip1.SuspendLayout();
		this.ToolStrip1.SuspendLayout();
		this.MenuStrip1.SuspendLayout();
		this.SuspendLayout();
		//
		//AxArcReaderControl1
		//
		this.AxArcReaderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.AxArcReaderControl1.Location = new System.Drawing.Point(0, 0);
		this.AxArcReaderControl1.Name = "AxArcReaderControl1";
		this.AxArcReaderControl1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("AxArcReaderControl1.OcxState");
		this.AxArcReaderControl1.Size = new System.Drawing.Size(692, 575);
		this.AxArcReaderControl1.TabIndex = 0;
		//
		//cboLayers
		//
		this.cboLayers.FormattingEnabled = true;
		this.cboLayers.Location = new System.Drawing.Point(518, 529);
		this.cboLayers.Name = "cboLayers";
		this.cboLayers.Size = new System.Drawing.Size(174, 21);
		this.cboLayers.TabIndex = 1;
		this.cboLayers.Visible = false;
		//
		//Timer1
		//
		this.Timer1.Interval = 1500;
		//
		//StatusStrip1
		//
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.StatusLabel1,
			this.ToolStripProgressBar1
		});
		this.StatusStrip1.Location = new System.Drawing.Point(0, 553);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(692, 22);
		this.StatusStrip1.TabIndex = 2;
		this.StatusStrip1.Text = "StatusStrip1";
		//
		//StatusLabel1
		//
		this.StatusLabel1.Name = "StatusLabel1";
		this.StatusLabel1.Size = new System.Drawing.Size(39, 17);
		this.StatusLabel1.Text = "Ready";
		//
		//ToolStripProgressBar1
		//
		this.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
		this.ToolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
		//
		//ToolStrip1
		//
		this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.optZoomIn,
			this.optZoomOut,
			this.ToolStripSeparator2,
			this.cmdFullExtent,
			this.optPan,
			this.ToolStripSeparator1,
			this.IdentityBtn,
			this.ToolStripSeparator3
		});
		this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.ToolStrip1.Size = new System.Drawing.Size(379, 25);
		this.ToolStrip1.TabIndex = 3;
		this.ToolStrip1.Text = "emmaddai";
		//
		//optZoomIn
		//
		this.optZoomIn.Image = global::BeaconBase.My.Resources.Resources.ZoomIn;
		this.optZoomIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.optZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.optZoomIn.Name = "optZoomIn";
		this.optZoomIn.Size = new System.Drawing.Size(72, 22);
		this.optZoomIn.Text = "Zoom In";
		//
		//optZoomOut
		//
		this.optZoomOut.Image = global::BeaconBase.My.Resources.Resources.ZoomOut;
		this.optZoomOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.optZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.optZoomOut.Name = "optZoomOut";
		this.optZoomOut.Size = new System.Drawing.Size(82, 22);
		this.optZoomOut.Text = "Zoom Out";
		//
		//ToolStripSeparator2
		//
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
		//
		//cmdFullExtent
		//
		this.cmdFullExtent.Image = global::BeaconBase.My.Resources.Resources.FullExtent;
		this.cmdFullExtent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.cmdFullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.cmdFullExtent.Name = "cmdFullExtent";
		this.cmdFullExtent.Size = new System.Drawing.Size(81, 22);
		this.cmdFullExtent.Text = "Full Extent";
		//
		//optPan
		//
		this.optPan.Image = (System.Drawing.Image)resources.GetObject("optPan.Image");
		this.optPan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.optPan.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.optPan.Name = "optPan";
		this.optPan.Size = new System.Drawing.Size(47, 22);
		this.optPan.Text = "Pan";
		//
		//ToolStripSeparator1
		//
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
		//
		//IdentityBtn
		//
		this.IdentityBtn.Image = global::BeaconBase.My.Resources.Resources.information;
		this.IdentityBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.IdentityBtn.Name = "IdentityBtn";
		this.IdentityBtn.Size = new System.Drawing.Size(67, 22);
		this.IdentityBtn.Text = "Identify";
		//
		//ToolStripSeparator3
		//
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
		//
		//MenuStrip1
		//
		this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.FileToolStripMenuItem1,
			this.ViewToolStripMenuItem,
			this.ToolsToolStripMenuItem1,
			this.HelpToolStripMenuItem1
		});
		this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
		this.MenuStrip1.Name = "MenuStrip1";
		this.MenuStrip1.Size = new System.Drawing.Size(692, 24);
		this.MenuStrip1.TabIndex = 4;
		this.MenuStrip1.Text = "MenuStrip1";
		//
		//FileToolStripMenuItem1
		//
		this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.NewToolStripMenuItem1,
			this.OpenToolStripMenuItem1,
			this.toolStripSeparator9,
			this.SaveToolStripMenuItem1,
			this.toolStripSeparator10,
			this.PrintToolStripMenuItem1,
			this.PrintPreviewToolStripMenuItem1,
			this.toolStripSeparator11,
			this.ExitToolStripMenuItem1
		});
		this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
		this.FileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
		this.FileToolStripMenuItem1.Text = "&File";
		//
		//NewToolStripMenuItem1
		//
		this.NewToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("NewToolStripMenuItem1.Image");
		this.NewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1";
		this.NewToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
		this.NewToolStripMenuItem1.Text = "&New";
		//
		//OpenToolStripMenuItem1
		//
		this.OpenToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("OpenToolStripMenuItem1.Image");
		this.OpenToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
		this.OpenToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
		this.OpenToolStripMenuItem1.Text = "&Open";
		//
		//toolStripSeparator9
		//
		this.toolStripSeparator9.Name = "toolStripSeparator9";
		this.toolStripSeparator9.Size = new System.Drawing.Size(140, 6);
		//
		//SaveToolStripMenuItem1
		//
		this.SaveToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SaveToolStripMenuItem1.Image");
		this.SaveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
		this.SaveToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
		this.SaveToolStripMenuItem1.Text = "&Save";
		//
		//toolStripSeparator10
		//
		this.toolStripSeparator10.Name = "toolStripSeparator10";
		this.toolStripSeparator10.Size = new System.Drawing.Size(140, 6);
		//
		//PrintToolStripMenuItem1
		//
		this.PrintToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("PrintToolStripMenuItem1.Image");
		this.PrintToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1";
		this.PrintToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
		this.PrintToolStripMenuItem1.Text = "&Print";
		//
		//PrintPreviewToolStripMenuItem1
		//
		this.PrintPreviewToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("PrintPreviewToolStripMenuItem1.Image");
		this.PrintPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1";
		this.PrintPreviewToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
		this.PrintPreviewToolStripMenuItem1.Text = "Print Pre&view";
		//
		//toolStripSeparator11
		//
		this.toolStripSeparator11.Name = "toolStripSeparator11";
		this.toolStripSeparator11.Size = new System.Drawing.Size(140, 6);
		//
		//ExitToolStripMenuItem1
		//
		this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
		this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
		this.ExitToolStripMenuItem1.Text = "E&xit";
		//
		//ViewToolStripMenuItem
		//
		this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ZoomInToolStripMenuItem,
			this.ZoomOutToolStripMenuItem,
			this.ZoomToFullExtentToolStripMenuItem,
			this.PanToolStripMenuItem
		});
		this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
		this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
		this.ViewToolStripMenuItem.Text = "&View";
		//
		//ZoomInToolStripMenuItem
		//
		this.ZoomInToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem";
		this.ZoomInToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
		this.ZoomInToolStripMenuItem.Text = "Zoom In";
		//
		//ZoomOutToolStripMenuItem
		//
		this.ZoomOutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem";
		this.ZoomOutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
		this.ZoomOutToolStripMenuItem.Text = "Zoom Out";
		//
		//ZoomToFullExtentToolStripMenuItem
		//
		this.ZoomToFullExtentToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.ZoomToFullExtentToolStripMenuItem.Name = "ZoomToFullExtentToolStripMenuItem";
		this.ZoomToFullExtentToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
		this.ZoomToFullExtentToolStripMenuItem.Text = "Zoom to Full Extent";
		//
		//PanToolStripMenuItem
		//
		this.PanToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.PanToolStripMenuItem.Name = "PanToolStripMenuItem";
		this.PanToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
		this.PanToolStripMenuItem.Text = "Pan";
		//
		//ToolsToolStripMenuItem1
		//
		this.ToolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.IdentityToolStripMenuItem1,
			this.ExportToolStripMenuItem1
		});
		this.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1";
		this.ToolsToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
		this.ToolsToolStripMenuItem1.Text = "&Tools";
		//
		//IdentityToolStripMenuItem1
		//
		this.IdentityToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.IdentityToolStripMenuItem1.Name = "IdentityToolStripMenuItem1";
		this.IdentityToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.IdentityToolStripMenuItem1.Text = "Identity";
		//
		//ExportToolStripMenuItem1
		//
		this.ExportToolStripMenuItem1.Name = "ExportToolStripMenuItem1";
		this.ExportToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.ExportToolStripMenuItem1.Text = "Export Map";
		//
		//HelpToolStripMenuItem1
		//
		this.HelpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ContentsToolStripMenuItem1,
			this.IndexToolStripMenuItem1,
			this.SearchToolStripMenuItem1,
			this.toolStripSeparator14,
			this.AboutToolStripMenuItem1
		});
		this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
		this.HelpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
		this.HelpToolStripMenuItem1.Text = "&Help";
		//
		//ContentsToolStripMenuItem1
		//
		this.ContentsToolStripMenuItem1.Name = "ContentsToolStripMenuItem1";
		this.ContentsToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
		this.ContentsToolStripMenuItem1.Text = "&Contents";
		//
		//IndexToolStripMenuItem1
		//
		this.IndexToolStripMenuItem1.Name = "IndexToolStripMenuItem1";
		this.IndexToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
		this.IndexToolStripMenuItem1.Text = "&Index";
		//
		//SearchToolStripMenuItem1
		//
		this.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1";
		this.SearchToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
		this.SearchToolStripMenuItem1.Text = "&Search";
		//
		//toolStripSeparator14
		//
		this.toolStripSeparator14.Name = "toolStripSeparator14";
		this.toolStripSeparator14.Size = new System.Drawing.Size(119, 6);
		//
		//AboutToolStripMenuItem1
		//
		this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
		this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
		this.AboutToolStripMenuItem1.Text = "&About...";
		//
		//frmGis
		//
		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(692, 575);
		this.Controls.Add(this.MenuStrip1);
		this.Controls.Add(this.ToolStrip1);
		this.Controls.Add(this.StatusStrip1);
		this.Controls.Add(this.cboLayers);
		this.Controls.Add(this.AxArcReaderControl1);
		this.Name = "frmGis";
		this.Text = "GIS visualisation";
		((System.ComponentModel.ISupportInitialize)this.AxArcReaderControl1).EndInit();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		this.MenuStrip1.ResumeLayout(false);
		this.MenuStrip1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	internal ESRI.ArcGIS.PublisherControls.AxArcReaderControl AxArcReaderControl1;
	public static string queryBeacon;

	public frmGis(string mBeaconName)
	{
		// This call is required by the Windows Form Designer.
		InitializeComponent();

		// Add any initialization after the InitializeComponent() call.
		//MessageBox.Show("Create new GIS and zoom to" & mBeaconName)
		queryBeacon = mBeaconName;
	}
	internal System.Windows.Forms.ComboBox cboLayers;
	internal System.Windows.Forms.Timer Timer1;
	internal System.Windows.Forms.StatusStrip StatusStrip1;
	internal System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
	internal System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar1;
	internal System.Windows.Forms.ToolStrip ToolStrip1;
	internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
	internal System.Windows.Forms.ToolStripButton optZoomIn;
	internal System.Windows.Forms.ToolStripButton optZoomOut;
	internal System.Windows.Forms.ToolStripButton cmdFullExtent;
	internal System.Windows.Forms.ToolStripButton optPan;
	internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
	internal System.Windows.Forms.ToolStripButton IdentityBtn;
	internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
	internal System.Windows.Forms.MenuStrip MenuStrip1;
	internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
	internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
	internal System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem PrintPreviewToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
	internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem ZoomInToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem ZoomOutToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem ZoomToFullExtentToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem PanToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem IdentityToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem ContentsToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem IndexToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
	internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
	internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem1;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
