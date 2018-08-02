// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Organizze
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTableColumn DateColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn DescriptionColumn { get; set; }

		[Outlet]
		AppKit.NSTableView TransactionsTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn ValueColumn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TransactionsTable != null) {
				TransactionsTable.Dispose ();
				TransactionsTable = null;
			}

			if (DateColumn != null) {
				DateColumn.Dispose ();
				DateColumn = null;
			}

			if (DescriptionColumn != null) {
				DescriptionColumn.Dispose ();
				DescriptionColumn = null;
			}

			if (ValueColumn != null) {
				ValueColumn.Dispose ();
				ValueColumn = null;
			}
		}
	}
}
