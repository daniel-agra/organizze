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
	public class AccountData : OrganizzeDAO
    {
        public AccountData()
        {
        }

		public List<Account> GetAccounts()
        {
            return this.GetData<List<Account>>("accounts");
        }
    }
}
