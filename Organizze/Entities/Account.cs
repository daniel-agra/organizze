using System;
using System.Runtime.Serialization;

namespace Organizze.Entities
{
    [DataContract]
    public class Account
    {
        #region Computed Properties
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
        #endregion

        #region Constructors
        public Account()
        {
        }
        #endregion
    }
}
