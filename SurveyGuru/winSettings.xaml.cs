
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

public partial class winSettings
{

	public static bool Audio = true;

	public winSettings() : base()
	{

		this.InitializeComponent();

		// Insert code required on object creation below this point.
	}


	private void chkAudio_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		if (chkAudio.IsChecked) {
			Audio = true;
		} else {
			Audio = false;
		}
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
