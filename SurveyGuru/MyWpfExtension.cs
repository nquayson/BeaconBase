
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using BeaconBase.XamlGeneratedNamespace;

#if _MyType <> "Empty"

namespace My
{
	/// <summary>
	/// Module used to define the properties that are available in the My Namespace for WPF
	/// </summary>
	/// <remarks></remarks>
	[Microsoft.VisualBasic.HideModuleName()]
	static class MyWpfExtension
	{
		private static ThreadSafeObjectProvider<global::Microsoft.VisualBasic.Devices.Computer> s_Computer = new ThreadSafeObjectProvider<global::Microsoft.VisualBasic.Devices.Computer>();
		private static ThreadSafeObjectProvider<global::Microsoft.VisualBasic.ApplicationServices.User> s_User = new ThreadSafeObjectProvider<global::Microsoft.VisualBasic.ApplicationServices.User>();
		private static ThreadSafeObjectProvider<MyWindows> s_Windows = new ThreadSafeObjectProvider<MyWindows>();
		private static ThreadSafeObjectProvider<global::Microsoft.VisualBasic.Logging.Log> s_Log = new ThreadSafeObjectProvider<global::Microsoft.VisualBasic.Logging.Log>();
		/// <summary>
		/// Returns the application object for the running application
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		static internal Application Application {
			get { return (Application)global::System.Windows.Application.Current; }
		}
		/// <summary>
		/// Returns information about the host computer.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		static internal global::Microsoft.VisualBasic.Devices.Computer Computer {
			get { return s_Computer.GetInstance(); }
		}
		/// <summary>
		/// Returns information for the current user.  If you wish to run the application with the current 
		/// Windows user credentials, call My.User.InitializeWithWindowsUser().
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		static internal global::Microsoft.VisualBasic.ApplicationServices.User User {
			get { return s_User.GetInstance(); }
		}
		/// <summary>
		/// Returns the application log. The listeners can be configured by the application's configuration file.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		static internal global::Microsoft.VisualBasic.Logging.Log Log {
			get { return s_Log.GetInstance(); }
		}

		/// <summary>
		/// Returns the collection of Windows defined in the project.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		static internal MyWindows Windows {
			[System.Diagnostics.DebuggerHidden()]
			get { return s_Windows.GetInstance(); }
		}
		[System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.VisualBasic.MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")]
		internal sealed class MyWindows
		{
			[System.Diagnostics.DebuggerHidden()]
			private static T Create__Instance__<T>(T Instance) where T : new(), global::System.Windows.Window
			{
				if (Instance == null) {
					if (s_WindowBeingCreated != null) {
						if (s_WindowBeingCreated.ContainsKey(typeof(T)) == true) {
							throw new global::System.InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.");
						}
					} else {
						s_WindowBeingCreated = new global::System.Collections.Hashtable();
					}
					s_WindowBeingCreated.Add(typeof(T), null);
					return new T();
					s_WindowBeingCreated.Remove(typeof(T));
				} else {
					return Instance;
				}
			}
			[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
			[System.Diagnostics.DebuggerHidden()]
			private void Dispose__Instance__<T>(ref T instance) where T : global::System.Windows.Window
			{
				instance = null;
			}
			[System.Diagnostics.DebuggerHidden()]
			[System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
			public MyWindows() : base()
			{
			}
			[System.ThreadStatic()]
			private static global::System.Collections.Hashtable s_WindowBeingCreated;
			[System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(o);
			}
			[System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode;
			}
			[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
			[System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			internal global::System.Type GetType()
			{
				return typeof(MyWindows);
			}
			[System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString;
			}
		}
	}
}
partial class Application : global::System.Windows.Application
{
	[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	internal global::Microsoft.VisualBasic.ApplicationServices.AssemblyInfo Info {
		[System.Diagnostics.DebuggerHidden()]
		get { return new global::Microsoft.VisualBasic.ApplicationServices.AssemblyInfo(global::System.Reflection.Assembly.GetExecutingAssembly()); }
	}
}
#endif

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
