// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace InFlow_Mobile.iOS.Views
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton AddNewButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISearchBar SearchBar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AddNewButton != null) {
				AddNewButton.Dispose ();
				AddNewButton = null;
			}
			if (SearchBar != null) {
				SearchBar.Dispose ();
				SearchBar = null;
			}
		}
	}
}
