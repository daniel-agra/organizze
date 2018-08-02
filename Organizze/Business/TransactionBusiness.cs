using System;
using System.Collections.Generic;

using Organizze.Entities;

namespace Organizze.Business
{
    public class TransactionBusiness
    {
        public TransactionBusiness()
        {
        }

        public List<Transaction> GetTransactionsDiff(List<Transaction> baseList, List<Transaction> listToCheck)
        {
            List<Transaction> diffList = new List<Transaction>();

            baseList.Sort();
            listToCheck.Sort();

            foreach(Transaction newTransaction in listToCheck)
            {
                bool foundEqual = false;
                foreach(Transaction oldTransaction in listToCheck)
                {
                    if((newTransaction.Date == oldTransaction.Date) && newTransaction.Ammount.Equals(oldTransaction.Ammount))
                    {
                        foundEqual = true;
                    }
                    else if((newTransaction.Date > oldTransaction.Date) && !foundEqual)
                    {
                        diffList.Add(newTransaction);
                        break;
                    }
                }
            }

            return diffList;
        }
    }
}
