using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

using Organizze.Entities;

namespace Organizze
{
    public class TransactionsTableDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<Transaction> Transactions = new List<Transaction>();
        #endregion

        #region Constructors
        public TransactionsTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Transactions.Count;
        }
        #endregion
    }
}
