
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public partial class winBackUp
{
	private void cmdUpload_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		string DBpath = null;
		//Make dbpath relative
		DBpath = My.Computer.FileSystem.CurrentDirectory + "\\BeaconDB.sdf";

		//MsgBox(My.Application.Info.DirectoryPath)

		if (string.IsNullOrEmpty(DBpath)) {
			MessageBox.Show("Database file not found");
			return;
		}

		if (!string.IsNullOrEmpty(this.txtAddress.Text)) {
			//Try upload to Web
			try {
				My.Computer.Network.UploadFile(DBpath, this.txtAddress.Text, "", "", true, 2000);
				this.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message + Constants.vbCrLf + "Please verify the Server Address", "Problem Uploading", MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
		} else if (!string.IsNullOrEmpty(this.txtFilePath.Text)) {
			//Try upload to Local
			My.Computer.FileSystem.CopyFile(DBpath, this.txtFilePath.Text);
			MessageBox.Show("BackUp Successful!");
			this.Close();
		} else {
			MessageBox.Show("No upload target found. Please provide a destination");
		}



	}

	private void winBackUp_Loaded(object sender, System.Windows.RoutedEventArgs e)
	{
		bool isAvailable = false;
		isAvailable = My.Computer.Network.IsAvailable;

		if (isAvailable) {
			this.lblInformation.Text = "Network connection detected";
			this.txtFilePath.IsEnabled = false;
			this.cmdBrowse.IsEnabled = false;
		} else {
			dynamic LocalDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\BeaconBase_BackUp";
			this.lblInformation.Text = "The network stream is not available at this time";
			this.txtAddress.IsEnabled = false;

			if (!My.Computer.FileSystem.DirectoryExists(LocalDirectory)) {
				My.Computer.FileSystem.CreateDirectory(LocalDirectory);
			}
			this.txtFilePath.Text = LocalDirectory + "\\BeaconDB_BK" + Today.Day + Today.Month + Today.Year + ".sdf";
		}
	}

	Microsoft.Win32.SaveFileDialog SaveDialog = new Microsoft.Win32.SaveFileDialog();

	private void cmdBrowse_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		var _with1 = SaveDialog;
		_with1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments;
		_with1.Title = "Please select the destination folder";
		_with1.Filter = "DataBase File (*.sdf)|*.sdf";
		_with1.AddExtension = true;
		//.FileName = "lendStore"

		SaveDialog.FileOk += SaveDialog_Ok;
		SaveDialog.ShowDialog();


	}

	private void SaveDialog_Ok()
	{
		this.txtFilePath.Text = SaveDialog.FileName;
	}
	public winBackUp()
	{
		Loaded += winBackUp_Loaded;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
