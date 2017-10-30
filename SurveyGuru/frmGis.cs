
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using ESRI.ArcGIS.PublisherControls;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class frmGis
{
	private ARFeatureSet m_pARFeatureSetMeets;
	private ARFeatureSet m_pARFeatureSetFails;
	private [,] m_InverseOperators = new[];

	private Collections.Hashtable m_LayersIndex;
	private void frmGis_Disposed(object sender, System.EventArgs e)
	{
		ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();
	}

	private void frmGis_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
	{
		Timer1 = null;
	}



	private void frmGis_Load(System.Object sender, System.EventArgs e)
	{
		//MessageBox.Show(frmGis.queryBeacon & "See if gotten it???")
		loadMap();
		PerformQuery();

	}

	private void loadMap()
	{
		string sFilePath = null;

		//sFilePath = My.Computer.FileSystem.CurrentDirectory & "\pmf\BeaconMap.pmf"
		//sFilePath = Application.StartupPath & "\Resources\pmf\myMap.pmf"
		sFilePath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\\pmf\\BeaconMap.pmf";
		//MsgBox(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData)
		//Load the specified pmf
		if (AxArcReaderControl1.CheckDocument(sFilePath) == true) {
			AxArcReaderControl1.DocumentFilename = null;
			AxArcReaderControl1.LoadDocument(sFilePath);
		} else {
			Interaction.MsgBox("This document cannot be loaded!");
			return;
		}

		//Determine whether permission to search layers and query field values
		bool bQueryFeatures = false;
		bool bQueryValues = false;
		bQueryFeatures = AxArcReaderControl1.HasDocumentPermission(esriARDocumentPermissions.esriARDocumentPermissionsQueryFeatures);
		bQueryValues = AxArcReaderControl1.HasDocumentPermission(esriARDocumentPermissions.esriARDocumentPermissionsQueryValues);

		if ((bQueryFeatures == false) | (bQueryValues == false)) {
			Interaction.MsgBox("The selected Document does not have Query Permissions.", Constants.vbInformation);
			AxArcReaderControl1.UnloadDocument();
			return;
		}

		//Add map layers to combo and store in HashTable with combo index
		m_LayersIndex = new Hashtable();
		ARPopulateComboWithMapLayers(cboLayers, m_LayersIndex);

	}

	private void ARPopulateComboWithMapLayers(ComboBox Layers, System.Collections.Hashtable LayersIndex)
	{
		//In case cboLayers is already populated
		LayersIndex.Clear();
		Layers.Items.Clear();

		ARLayer pARLayer = default(ARLayer);
		ARLayer pARGroupLayer = default(ARLayer);

		// Get the focus map
		ARMap pARMap = AxArcReaderControl1.ARPageLayout.FocusARMap;

		// Loop through each layer in the focus map
		int i = 0;
		for (i = 0; i <= pARMap.ARLayerCount - 1; i += i + 1) {
			// Get the layer name
			pARLayer = pARMap.ARLayer(i);
			//'Code was here
			if (pARLayer.IsGroupLayer == true) {
				//If a GroupLayer add the ARChildLayers to the combo and HashTable
				int g = 0;
				for (g = 0; g <= pARLayer.ARLayerCount - 1; g += g + 1) {
					pARGroupLayer = pARMap.ARLayer(i).ChildARLayer(g);
					Layers.Items.Add(pARGroupLayer.Name);
					LayersIndex.Add(Layers.Items.Count - 1, pARGroupLayer);
				}
			} else if (pARLayer.Searchable == true) {
				Layers.Items.Add(pARLayer.Name);
				LayersIndex.Add(Layers.Items.Count - 1, pARLayer);
			}
		}

	}


	private void PerformQuery()
	{
		//Get layer to query
		ARMap pARMap = default(ARMap);
		pARMap = AxArcReaderControl1.ARPageLayout.FocusARMap;

		ARLayer pARLayer = (ARLayer)m_LayersIndex(0);

		//Build the ARSearchDef
		ArcReaderSearchDef pARSearchDef = default(ArcReaderSearchDef);
		pARSearchDef = new ArcReaderSearchDef();


		//**************************************************************
		//Build WhereClause that meets search criteria *******************
		string sWhereClause = null;
		sWhereClause = "BeaconName" + " " + "=" + " '" + queryBeacon + "'";

		pARSearchDef.WhereClause = sWhereClause;

		//Get ARFeatureSet that meets the search criteria
		m_pARFeatureSetMeets = pARLayer.QueryARFeatures(pARSearchDef);

		if (m_pARFeatureSetMeets.ARFeatureCount > 0) {
			//MessageBox.Show("Features MEETING the search criteria: " + m_pARFeatureSetMeets.ARFeatureCount.ToString())
			this.StatusLabel1.Text = m_pARFeatureSetMeets.ARFeatureCount.ToString() + " beacon(s) selected: " + frmGis.queryBeacon;
		} else {
			Interaction.MsgBox("No feature meets the criteria");
		}

		//The selected feature is highlighted here
		exposeFeature();
	}
	private void exposeFeature()
	{
		ARMap pARMap = default(ARMap);
		pARMap = AxArcReaderControl1.ARPageLayout.FocusARMap;

		m_pARFeatureSetMeets.ZoomTo();
		m_pARFeatureSetMeets.CenterAt();
		//pARMap.ZoomIn(2)

		//MessageBox.Show("About to flash")
		Timer1.Enabled = true;
	}

	private string ARFeatureValueAsString(ARFeature pARFeature, long pFieldNameIndex)
	{
		string functionReturnValue = null;

		//If there is an issue accessing the value the function returns a string of asterisks
		//There are many reason Asterisks may be returned...
		//The return value cant be cast into a string e.g. a BLOB value
		//The return value is stored within a hidden field in the PMF
		//The return value is a Geometry Object

		 // ERROR: Not supported in C#: OnErrorStatement

		functionReturnValue = "***";
		functionReturnValue = Convert.ToString(pARFeature.Value(pARFeature.FieldName(pFieldNameIndex)));
		return functionReturnValue;

	}

	private void Timer1_Tick(System.Object sender, System.EventArgs e)
	{
		m_pARFeatureSetMeets.Flash();
		//m_pARFeatureSetMeets.Flicker()
	}


	private void MixedControls_Click(System.Object sender, System.EventArgs e)
	{
		switch (sender.Name) {
			case "optZoomIn":
				AxArcReaderControl1.ARPageLayout.FocusARMap.ZoomIn(1.3654);
				AxArcReaderControl1.CurrentARTool = esriARTool.esriARToolMapZoomIn;
				break;
			case "optZoomOut":
				AxArcReaderControl1.ARPageLayout.FocusARMap.ZoomOut(1.3654);
				AxArcReaderControl1.CurrentARTool = esriARTool.esriARToolMapZoomOut;
				break;
			case "optPan":
				AxArcReaderControl1.CurrentARTool = esriARTool.esriARToolMapPan;
				break;
		}

	}

	private void cmdFullExtent_Click(System.Object sender, System.EventArgs e)
	{
		AxArcReaderControl1.ARPageLayout.FocusARMap.ZoomToFullExtent();
	}
	private void IdentityBtn_Click(System.Object sender, System.EventArgs e)
	{
		AxArcReaderControl1.CurrentARTool = ESRI.ArcGIS.PublisherControls.esriARTool.esriARToolMapIdentify;
	}

	private void ExitToolStripMenuItem1_Click(System.Object sender, System.EventArgs e)
	{
		this.Close();
	}
	public frmGis()
	{
		Load += frmGis_Load;
		FormClosing += frmGis_FormClosing;
		Disposed += frmGis_Disposed;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
