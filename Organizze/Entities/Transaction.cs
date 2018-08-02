using System;
using System.Runtime.Serialization;

namespace Organizze.Entities
{
    [DataContract]
    public class Transaction : IComparable
    {
        #region Computed Properties
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name ="date")]
        public string dateString { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; } = "";

        [DataMember(Name = "credit_card_id")]
        public string CreditCardId { get; set; }

        [DataMember(Name = "credit_card_invoice_id")]
        public string CreditCardInvoiceId { get; set; }

        public DateTime Date {
            get {
                return DateTime.Parse(this.dateString);
            }
        }

        [DataMember(Name = "amount_cents")]
        public int AmmountCents {
            set
            {
                this.Ammount = ((decimal)(value)) / 100;  
            }
            get
            {
                return int.Parse(this.Ammount.ToString().Replace(".", ""));
            }
         }

        public decimal Ammount { set; get; }
        #endregion

        #region Constructors
        public Transaction()
        {
        }

        public Transaction(DateTime date, string description, int ammountCents)
        {
            //this.Date = date;
            this.Description = description;
            this.AmmountCents = ammountCents;
        }
        #endregion

        public int CompareTo(object obj)
        {
            Transaction transaction = obj as Transaction;

            if(this.Date == transaction.Date)
            {
                return 0;
            }
            else if (this.Date < transaction.Date)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

    }
}
