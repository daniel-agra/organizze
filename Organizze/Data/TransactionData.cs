using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;

using Organizze.Entities;


namespace Organizze.Data
{
	public class TransactionData : OrganizzeDAO
    {
        public TransactionData()
        {
        }

		//private List<Transaction> getTransactionsFromOrganizze(DateTime startDate, DateTime endDate, int accountId)
        public List<Transaction> GetTransactions()
        {
            return this.GetData<List<Transaction>>("transactions");
        }

        public void CreateTransaction(Transaction transaction)
        {

        }
    }
}
