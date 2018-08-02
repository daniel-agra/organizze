using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace Organizze
{
    public class TransactionsTableDelegate: NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "TransactionCell";
        #endregion

        #region Private Variables
        private TransactionsTableDataSource DataSource;
        #endregion

        #region Constructors
        public TransactionsTableDelegate(TransactionsTableDataSource dataSource)
        {
            this.DataSource = dataSource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Data":
                    view.StringValue = DataSource.Transactions[(int)row].Date.ToString();
                    break;
                case "Descrição":
                    view.StringValue = DataSource.Transactions[(int)row].Description;
                    break;
                case "Valor":
                    view.FloatValue = float.Parse(DataSource.Transactions[(int)row].Ammount.ToString());
                    break;
            }

            return view;
        }
        #endregion
    }
}
