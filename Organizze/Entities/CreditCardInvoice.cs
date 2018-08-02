using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Organizze.Entities
{
    [DataContract]
    public class CreditCardInvoice
    {
        #region Computed Properties
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "date")]
        public string dateString { get; set; } = "";

        [DataMember(Name = "transactions")]
        public List<Transaction> Transactions { get; set; }

        public DateTime Date
        {
            get
            {
                return DateTime.Parse(this.dateString);
            }
        }

        [DataMember(Name = "balance_cents")]
        public int BalanceCents
        {
            set
            {
                this.Balance = ((decimal)(value)) / 100;
            }
            get
            {
                return int.Parse(this.Balance.ToString().Replace(".", ""));
            }
        }

        public decimal Balance { set; get; }
        #endregion

        public CreditCardInvoice()
        {
        }
    }
}
