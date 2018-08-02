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
	public class CreditCardData : OrganizzeDAO
    {
        public CreditCardData()
        {
        }

		public List<CreditCard> GetCreditCards()
        {
            return this.GetData<List<CreditCard>>("credit_cards");
        }

        public List<CreditCardInvoice> GetInvoices(int creditCardId)
        {
            return this.GetData<List<CreditCardInvoice>>("credit_cards/" + creditCardId.ToString() + "/invoices");
        }

        public CreditCardInvoice GetInvoice(int creditCardId, int invoiceId)
        {
            return this.GetData<CreditCardInvoice>("credit_cards/" + creditCardId.ToString() + "/invoices/" + invoiceId.ToString());
        }
    }
}
