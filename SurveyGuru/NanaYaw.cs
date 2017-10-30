
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Math;
static class NanaYaw
{





	//RadiansConvert works converting Degrees to radians
	public static double RadiansConvert(double DegreesValue)
	{

		return DegreesValue * (PI / 180);
	}

	public static double DegreesConvert(double RadiansValue)
	{
		return RadiansValue * (180 / PI);
	}

	//Works Determines if number is integer
	public static bool IsInteger(double Number)
	{
		if (Conversion.Int(Number) == Number) {
			return true;
		} else {
			return false;
		}
	}

	//Works Finds the next multiple of Multiple after Number
	public static double NextMultiple(int Multiple, double Number)
	{
		double functionReturnValue = 0;

		if (Multiple == 0) {
			MessageBox.Show("Multiple cannot be zero");
			return -1;
		}

		int counter = 1;
		Number = Conversion.Int(Number);

		do {
			if (IsInteger((Number + counter) / Multiple)) {
				return Number + counter;
				break; // TODO: might not be correct. Was : Exit Do
			}
			counter = counter + 1;

			if (counter > 999999) {
				MessageBox.Show("An Overflow occured in function NextMultiple", "Overflow", MessageBoxButton.OK, MessageBoxImage.Warning);
				return -1;
				return functionReturnValue;
			}
		} while (true);
		return functionReturnValue;


	}

	//Works finds the previous multiple of multiple before number
	public static double PrevMultiple(int Multiple, double Number)
	{
		double functionReturnValue = 0;
		int counter = -1;
		Number = Conversion.Int(Number);

		if (Multiple == 0) {
			MessageBox.Show("Multiple cannot be zero");
			return -1;
		}
		do {
			if (IsInteger((Number + counter) / Multiple)) {
				return Number + counter;
				break; // TODO: might not be correct. Was : Exit Do
			}

			counter = counter - 1;

			if (counter < -999999) {
				MessageBox.Show("An Overflow occured in function prevMultiple", "Overflow", MessageBoxButton.OK, MessageBoxImage.Warning);
				return -1;
				return functionReturnValue;
			}

		} while (true);
		return functionReturnValue;


	}
	//Works converting a decimal angle to the deg min sec format
	public static string DegreesFormat(double DecimalAngle)
	{
		int fDeg = 0;
		int fMin = 0;
		double fSec = 0;
		string fReturnString = "";

		fDeg = Truncate(DecimalAngle);
		fMin = Truncate((DecimalAngle - fDeg) * 60);
		fSec = (((DecimalAngle - fDeg) * 60) - fMin) * 60;
		fSec = Round(fSec, 2);

		if (fSec == 60) {
			fSec = 0;
			fMin += 1;
		}


		fReturnString += Strings.Format(fDeg, 0 + 0 + 0) + Strings.Chr(176) + " ";
		fReturnString += Strings.Format(fMin, 0 + 0) + Strings.Chr(39) + " ";

		if (IsInteger(fSec)) {
			fReturnString += Strings.Format(fSec, 0 + 0) + Strings.Chr(34);
		} else {
			fReturnString += fSec + Strings.Chr(34);
		}

		return fReturnString;
	}


	//Finding distance of a line AB
	public static object Distance(double N1, double E1, double N2, double E2)
	{
		double Echange = 0;
		double Nchange = 0;
		double Value = 0;

		Echange = E2 - E1;
		Nchange = N2 - N1;

		Value = Sqrt(Math.Pow(Echange, 2) + Math.Pow(Nchange, 2));
		return Value;
		//ReturnValue

	}


	//Finding Bearing of a line AB   (Enter Northings before Eastings)
	public static object Bearing(double N1, double E1, double N2, double E2)
	{
		double Echange = 0;
		double Nchange = 0;
		double Value = 0;

		Echange = E2 - E1;
		Nchange = N2 - N1;
		Value = Atan(Echange / Nchange) * (180 / PI);

		if (Echange > 0 & Nchange > 0) {
			//Is quadrant 1
			Value = Value;

		} else if (Echange > 0 & Nchange < 0) {
			//Is quadrant 2
			Value = Value + 180;

		} else if (Echange < 0 & Nchange < 0) {
			//Is quadrant 3
			Value = Value + 180;

		} else if (Echange < 0 & Nchange > 0) {
			//Is quadrant 4
			Value = Value + 360;

		} else {
			Value = 0;
			//Error

		}

		return Value;
		//ReturnValue
	}

	public static double Sexag2Dec(int Deg, int Min, double sec)
	{
		double myValue = 0;

		myValue = Deg + (Min / 60) + (sec / 3600);
		if (myValue < 0 | myValue > 360) {
			//Error checking
			return 0;
		} else {
			return myValue;
		}

	}

}



//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
