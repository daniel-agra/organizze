using System;
using System.Runtime.Serialization;

namespace Organizze.Entities
{
	[DataContract]
    public class CreditCard
    {
		#region Computed Properties
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
        #endregion

        #region Constructors
		public CreditCard()
        {
        }
        #endregion
        
    }
}
