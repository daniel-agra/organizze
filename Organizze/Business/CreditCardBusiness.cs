using System;
using System.Collections.Generic;

using Organizze.Entities;
using Organizze.Data;

namespace Organizze.Business
{
    public class CreditCardBusiness
    {
        CreditCardData creditCardData { get; set; }

        public CreditCardBusiness()
        {
            this.creditCardData = new CreditCardData();
        }

        public CreditCardInvoice GetInvoiceByMonth(int creditCardId, int month, int year)
        {
            CreditCardInvoice invoice = null;

            string targetMonth = string.Format("{0}{1}", month.ToString().PadLeft(2, '0'), year.ToString());

            List<CreditCardInvoice> invoices = this.creditCardData.GetInvoices(creditCardId);
            foreach (CreditCardInvoice invoiceItem in invoices)
            {
                if (invoiceItem.Date.ToString("MMyyyy") == targetMonth)
                {
                    invoice = invoiceItem;
                    break;
                }
            }

            if (invoice != null)
            {
                invoice = this.creditCardData.GetInvoice(creditCardId, invoice.Id);
            }

            return invoice;
        }

        public CreateTransaction(Transaction transaction)
        {
            //Verifica se a fatura do mês da transação existe

            //Se não existe a fatura, cria a fatura

            //Cria a transação
        }
    }
}
