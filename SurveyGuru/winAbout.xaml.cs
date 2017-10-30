
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

public partial class winAbout
{
	public winAbout() : base()
	{
		Loaded += winAbout_Loaded;

		this.InitializeComponent();

		// Insert code required on object creation below this point.
	}

	private void winAbout_Loaded(object sender, System.Windows.RoutedEventArgs e)
	{
		this.lblVersion.Text = "1.0.0.0";
		this.lblUserName.Text = My.User.Name;
		this.lblUserOS.Text = My.Computer.Info.OSFullName + ", " + My.Computer.Info.OSPlatform;
	}

	private void cmdClose_Click(System.Object sender, System.Windows.RoutedEventArgs e)
	{
		this.Close();
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
