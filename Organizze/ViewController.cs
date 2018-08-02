using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using AppKit;
using Foundation;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;

using Organizze.Entities;
using Organizze.Data;
using Organizze.Business;

namespace Organizze
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            // Create the Transactions Table Data Source and populate it
            var DataSource = new TransactionsTableDataSource();

			//AccountsData accountsData = new AccountsData();
			//List<Account> accounts = accountsData.GetAccounts();

			//CreditCardData creditCardsData = new CreditCardData();
			//List<CreditCard> creditCards = creditCardsData.GetCreditCards();

			//TransactionData transactionsData = new TransactionData();
			//List<Transaction> organizzeTransactions = transactionsData.GetTransactions();

            //Nubank Daniel Id = 35500

            CreditCardBusiness creditCardBusiness = new CreditCardBusiness();
            CreditCardInvoice invoice = creditCardBusiness.GetInvoiceByMonth(35500, 4, 2018);

			//List<Transaction> nubankTransactions = this.getTransactionsFromNubankFile();

			DataSource.Transactions.AddRange(invoice.Transactions);

            // Populate the Product Table
            TransactionsTable.DataSource = DataSource;
            TransactionsTable.Delegate = new TransactionsTableDelegate(DataSource);
        }
    }
}
