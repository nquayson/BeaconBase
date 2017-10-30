
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using BeaconBase.NanaYaw;
using BeaconDAL;

class winBeaconBase
{
	private BeaconEntities DB = new BeaconEntities();
	private BindingListCollectionView View;
		//= CType(Me.Resources("BeaconSource"), CollectionViewSource)
	private CollectionViewSource BeaconSource;
	private int NewBeaconsCount = 0;
	private bool ChangesCommitted = false;
	private Microsoft.Win32.SaveFileDialog Exportdialog = new Microsoft.Win32.SaveFileDialog();
	private Microsoft.Win32.OpenFileDialog UpdatePhotoDialog = new Microsoft.Win32.OpenFileDialog();

	private System.Speech.Synthesis.SpeechSynthesizer mySynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
	private void winBeaconBase_Closed(object sender, System.EventArgs e)
	{
		//Release resources and properly end the app
	}


	private void winBeaconBase_Closing(object sender, System.ComponentModel.CancelEventArgs e)
	{
		System.Windows.RoutedEventArgs myE = new System.Windows.RoutedEventArgs();
		if (ChangesCommitted) {
			MessageBoxResult verifier = default(MessageBoxResult);
			verifier = MessageBox.Show("There have been some observable changes committed to the DataModel." + Constants.vbCrLf + "Do you wish to SAVE the changes?", "Warning", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
			if (verifier == MessageBoxResult.Yes) {
				cmdSave_Click(sender, myE);
			} else if (verifier == MessageBoxResult.Cancel) {
				e.Cancel = true;
			}
		}
	}


	private void winBeaconBase_Loaded(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		dynamic AllBeacons = from B in DB.Beaconsorderby B.BeaconID ascendingB;

		BeaconSource = (CollectionViewSource)this.Resources("BeaconSource");
		BeaconSource.Source = AllBeacons;
		View = BeaconSource.View;

		Exportdialog.FileOk += ExportBeacon;
		UpdatePhotoDialog.FileOk += UpdatePhoto;

		//MessageBox.Show(My.Application.Info.DirectoryPath)
	}

	const double Met2Ft = 3.2808399;
	private void lstBeacons_SelectionChanged(System.Object sender, System.Windows.Controls.SelectionChangedEventArgs e)
	{
		try {
			switch (cboUnits.SelectedIndex) {
				case 0:
					//Default(Metres)
					this.infoEasting.Text = txtEasting.Text;
					this.infoNorthing.Text = txtNorthing.Text;
					this.infoElevation.Text = txtElevation.Text;

					break;
				case 1:
					//Feet
					this.infoEasting.Text = Math.Round(Conversion.Val(txtEasting.Text) * Met2Ft, 3);
					this.infoNorthing.Text = Math.Round(Conversion.Val(txtNorthing.Text) * Met2Ft, 3);
					this.infoElevation.Text = Math.Round(Conversion.Val(txtElevation.Text) * Met2Ft, 3);

					break;
				default:
					//Unknown Units
					MessageBox.Show("Please select a Display Unit from the Dropdown Combobox in the Top right corner", "Unknow Units", MessageBoxButton.OK, MessageBoxImage.Exclamation);
					break;
			}

			SpeakBeacon(this.infoBeaconName.Text);
			DisableTextboxes();
		} catch (Exception ex) {
			//MessageBox.Show(ex.GetHashCode)
		}
		//Me.infoLat.Text = 
		//Me.infoLong .Text = 
		//Me.infoConv .Text =
	}
	private void DisableTextboxes()
	{
		this.txtBeaconName.IsEnabled = false;
		this.txtNorthing.IsEnabled = false;
		this.txtEasting.IsEnabled = false;
		this.txtElevation.IsEnabled = false;
		this.txtDescription.IsEnabled = false;
		this.txtDate.IsEnabled = false;
		this.cmdUpdatePhoto.IsEnabled = false;
	}

	//Will clear display labels(infoxxx)
	private void ClearDisplay()
	{
		this.infoNorthing.Text = "";
		this.infoEasting.Text = "";
		this.infoElevation.Text = "";
		//Me.infoLat.Text = ""
		//Me.infoLong.Text = ""
		//Me.infoConv.Text = ""

	}

	private void txtSearchBox_KeyUp(System.Object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == Key.Enter) {
			cmdSearch_Click(txtSearchBox, e);
		}
	}


	private void cmdSearch_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		//Pulling srch match in db
		string SearchQuery = Strings.Trim(this.txtSearchBox.Text).ToLower;
		Linq.IQueryable<Beacon> BestMatch = default(Linq.IQueryable<Beacon>);

		switch (SearchQuery) {
			case "all":
				//Pulling all Beacons
				BestMatch = from B in DB.Beaconsorderby B.BeaconID;
				break;
			default:
				//Lambda Expression that retrns bestmatch
				BestMatch = DB.Beacons.Where("it.BeaconName like '" + "%" + SearchQuery + "%" + "'").OrderBy("it.BeaconID");
				break;
		}

		this.BeaconSource.Source = BestMatch;
		View = (BindingListCollectionView)BeaconSource.View;
	}

	private void cmdAdd_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		MessageBoxResult msgResult = MessageBoxResult.No;
		DisableTextboxes();

		msgResult = MessageBox.Show(("A new beacon will be created at index " + this.DB.Beacons.Count + NewBeaconsCount + 1 + Constants.vbCrLf + "Do you wish to proceed?"), "Notification", MessageBoxButton.YesNo, MessageBoxImage.Question);
		if (msgResult == MessageBoxResult.Yes) {
			ClearDisplay();
			try {
				dynamic newBeacon = (Beacon)this.View.AddNew();
				newBeacon.BeaconID = Convert.ToInt32(this.DB.Beacons.Count + NewBeaconsCount + 1);
				newBeacon.BeaconName = "[New]";
				newBeacon.Description = "Enter Description";
				newBeacon.Photo = "Images\\Default.jpg";
				newBeacon.Date = new System.DateTime(2010, 1, 1);
				this.View.CommitNew();
				NewBeaconsCount += 1;
				ChangesCommitted = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.GetHashCode, "Error Adding New Beacon");
			}
		}
	}

	private void cmdSave_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		DisableTextboxes();
		if (ChangesCommitted) {
			try {
				//All changes made to the view/DB will b persisted
				DB.SaveChanges();
				Interaction.MsgBox("Save Successful");
				NewBeaconsCount = 0;
				this.ChangesCommitted = false;
				Speak("Save successful");
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString);
			}
		}

	}

	private void cmdDelete_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		DisableTextboxes();
		MessageBoxResult verifier = default(MessageBoxResult);
		verifier = MessageBox.Show("Are you sure you wish to Remove the selected BEACON?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);

		if (verifier == MessageBoxResult.Yes && this.View.CurrentPosition > -1) {
			//ToDo: Instead of these, Create a standard DelBeac Obj with these properties
			this.txtBeaconName.Text = "[Empty]";
			this.txtNorthing.Text = "";
			this.txtEasting.Text = "";
			this.txtElevation.Text = "";
			this.txtDescription.Text = "";
			this.imgBeacon.Source = new BitmapImage(new Uri("Images\\Default.jpg", UriKind.Relative));
			this.txtDate.DateTime = new System.DateTime(2010, 1, 1);
			this.ChangesCommitted = true;
		}
		this.View.Refresh();
	}

	private void cmdEdit_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		if (this.View.CurrentPosition > -1) {
			this.txtBeaconName.IsEnabled = true;
			this.txtNorthing.IsEnabled = true;
			this.txtEasting.IsEnabled = true;
			this.txtElevation.IsEnabled = true;
			this.txtDescription.IsEnabled = true;
			this.txtDate.IsEnabled = true;
			this.cmdUpdatePhoto.IsEnabled = true;

			Speak("Editing started");
		}
	}

	private void textboxes_Changed(System.Object sender, System.Windows.Controls.TextChangedEventArgs e)
	{
		if (this.txtBeaconName.IsEnabled && !(this.ChangesCommitted)) {
			this.ChangesCommitted = true;
			MessageBox.Show(this.ChangesCommitted, "ChangesCommitted?");
		}
	}

	private void cmdExport_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		//Using  Exportdialog
		var _with1 = Exportdialog;
		_with1.Filter = "Comma Delimited (*.csv)|*.csv|Plain Text files (*.txt)|*.txt";
		_with1.FilterIndex = 1;
		_with1.AddExtension = true;
		_with1.InitialDirectory = Environment.SpecialFolder.MyDocuments;
		_with1.Title = "Select Export Destination";

		if (this.lstBeacons.SelectedIndex >= 0) {
			Exportdialog.ShowDialog();
		} else {
			MessageBox.Show("Please select a Beacon", "Unknown beacon", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	//Handles ExportDialog.fileok set in me.Loaded
	private void ExportBeacon()
	{
		string filename = Exportdialog.FileName;
		string filecontent = "";

		switch (Exportdialog.FilterIndex) {

			case 1:
				//CSV file chosen
				filecontent += "Exported from BeaconBase " + "1.0.0.0" + Constants.vbCrLf + Constants.vbCrLf;
				filecontent += "Beacon " + this.infoBeaconID.Text + "," + this.infoBeaconName.Text + Constants.vbCrLf;
				filecontent += "N" + "," + this.infoNorthing.Text + ",," + "Lat" + "," + this.infoLat.Text + Constants.vbCrLf;
				filecontent += "E" + "," + this.infoEasting.Text + ",," + "Lon" + "," + this.infoLong.Text + Constants.vbCrLf;
				filecontent += "Z" + "," + this.infoElevation.Text + Constants.vbCrLf;
				filecontent += "Conv" + "," + this.infoConv.Text + Constants.vbCrLf + Constants.vbCrLf;
				filecontent += "Description" + "," + this.txtDescription.Text + Constants.vbCrLf;

				break;

			case 2:
				//Txt file chosen
				filecontent += "Exported from BeaconBase " + "1.0.0.0" + Constants.vbCrLf + Constants.vbCrLf;
				filecontent += "Beacon " + this.infoBeaconID.Text + Constants.vbTab + this.infoBeaconName.Text + Constants.vbCrLf;
				filecontent += "N" + Constants.vbTab + this.infoNorthing.Text + Constants.vbTab + Constants.vbTab + "Lat" + Constants.vbTab + this.infoLat.Text + Constants.vbCrLf;
				filecontent += "E" + Constants.vbTab + this.infoEasting.Text + Constants.vbTab + Constants.vbTab + "Lon" + Constants.vbTab + this.infoLong.Text + Constants.vbCrLf;
				filecontent += "Z" + Constants.vbTab + this.infoElevation.Text + Constants.vbCrLf;
				filecontent += "Conv" + Constants.vbTab + this.infoConv.Text + Constants.vbCrLf + Constants.vbCrLf;
				filecontent += "Description" + Constants.vbTab + this.txtDescription.Text + Constants.vbCrLf;

				break;
		}
		My.Computer.FileSystem.WriteAllText(filename, filecontent, true);

	}

	Beacon beacon1;
	Beacon beacon2;
	private void cmdMark_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		this.tabDisplay2.IsSelected = true;
		if ((beacon1 != null) && (beacon2 != null)) {
			beacon1 = null;
			beacon2 = null;
			ClearGridBearDist();
		}

		if (beacon1 == null) {
			beacon1 = this.View.CurrentItem;
			Speak("Please mark another");
			this.lblControl1.Text = beacon1.BeaconName;
			//MsgBox("Beacon1 " & Me.lblControl1.Text)
		} else if (beacon2 == null) {
			beacon2 = this.View.CurrentItem;
			this.lblControl2.Text = beacon2.BeaconName;
			//MsgBox("Beacon2 " & Me.lblControl2.Text)

			//Calculate Bearing/distance here
			double Bearing = 0;
			double Distance = 0;
			Bearing = NanaYaw.Bearing(beacon1.Northing, beacon1.Easting, beacon2.Northing, beacon2.Easting);
			Distance = NanaYaw.Distance(beacon1.Northing, beacon1.Easting, beacon2.Northing, beacon2.Easting);
			lblBearing.Text = NanaYaw.DegreesFormat(Bearing);
			lblDistance.Text = Math.Round(Distance, 2);

			Speak("Bearing and Distance calculated");
		} else {
			MessageBox.Show("An unexpected error has occured");
		}

	}

	private void ClearGridBearDist()
	{
		this.lblControl1.Text = "";
		this.lblControl2.Text = "";
		this.lblDistance.Text = "Unknown";
		this.lblBearing.Text = "Unknown";
	}

	private void cmdUpdatePhoto_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		var _with2 = UpdatePhotoDialog;
		_with2.Title = "Update Photo";
		_with2.InitialDirectory = Environment.SpecialFolder.MyPictures;


		UpdatePhotoDialog.ShowDialog();
	}

	//Handles UpdatePhotoDialog.FileOk
	private void UpdatePhoto()
	{
		Interaction.MsgBox("Photo Updated (UpdatePhotoDialog.FileOk");
	}

	private void cmdPrint_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		MessageBox.Show("No printer detected at this time. ", "Print", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void cmdHelp_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		winHelp myHelp = new winHelp();
		myHelp.show();
	}

	private void cmdAbout_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		winAbout myAbout = new winAbout();
		myAbout.Show();
	}

	private void cmdExit_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		MsgBoxResult verifier = default(MsgBoxResult);
		verifier = MessageBox.Show("Are you sure you wish to quit the application?", "Verify", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
		if (verifier == MsgBoxResult.Yes) {
			this.Close();
		}
	}


	private void cmdSettings_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		winSettings DwinSettings = new winSettings();
		DwinSettings.ShowDialog();
	}

	private void cmdVisualise_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		StartWait();
		Speak("Loading GIS window. Please wait");

		frmGis myfrmGis = new frmGis(Strings.Trim(this.infoBeaconName.Text));
		myfrmGis.Show();

	}
	private void StartWait()
	{
		LoadingAdorner.IsAdornerVisible = true;
	}
	private void StopWait()
	{
		LoadingAdorner.IsAdornerVisible = false;
	}

	private void Speak(string Statement)
	{
		if (!(winSettings.Audio)) {
			return;
		}


		mySynthesizer.Volume = 90;
		mySynthesizer.Rate = -2;

		mySynthesizer.SpeakAsync(Statement);
	}
	private void SpeakBeacon(string BeaconName)
	{
		if (!(winSettings.Audio)) {
			return;
		}

		//Processing BeaconName
		//BeaconName.Replace("/", " ")
		BeaconName = BeaconName.Replace("ENG", "E. N. G. ");
		BeaconName = BeaconName.Replace("UST", "U. S. T. ");
		BeaconName = BeaconName.Replace("AM", " A. M. ");
		BeaconName = BeaconName.Replace("KNUST", "K. N. U. S. T. ");
		BeaconName = BeaconName.Replace("GE", "G. E, ");
		BeaconName = BeaconName.Replace("ED", "E. D. ");
		BeaconName = BeaconName.Replace("KU", "K. U. ");
		BeaconName = BeaconName.Replace("KTC", "K. T. C. ");


		mySynthesizer.Volume = 90;
		mySynthesizer.Rate = 0;
		//MessageBox.Show("Audio " & winSettings.Audio)
		mySynthesizer.SpeakAsyncCancelAll();
		mySynthesizer.SpeakAsync(BeaconName);

	}

	protected override void Finalize()
	{
		base.Finalize();
	}
	private void cmdBackUp_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		winBackUp myWinBackUp = new winBackUp();
		myWinBackUp.ShowDialog();
	}


	private void winBeaconBase_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
	{
		//Add StopWait to open window closed

		StopWait();
	}

	private void cmdVisualise_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
	{
		//StartWait()
	}
	public winBeaconBase()
	{
		MouseMove += winBeaconBase_MouseEnter;
		MouseEnter += winBeaconBase_MouseEnter;
		Loaded += winBeaconBase_Loaded;
		Closing += winBeaconBase_Closing;
		Closed += winBeaconBase_Closed;
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
