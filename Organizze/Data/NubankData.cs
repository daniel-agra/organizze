using System;
using System.Collections.Generic;
using System.IO;

using Organizze.Entities;

namespace Organizze.Data
{
    public class NubankData
    {
        public NubankData()
        {
        }

        public List<Transaction> getTransactionsFromNubankFile()
        {
            string csvFilePath = "/Users/dmav/Google Drive/Projetos/Organizze/nubank-2018-05.csv";
            //string csvFilePath = "/Users/danielmelo/Google Drive/Projetos/Organizze/nubank-2018-05.csv";
            StreamReader streamReader = new StreamReader(csvFilePath);

            //skip first line
            //date,category,title,amount
            streamReader.ReadLine();

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] values = line.Split(',');

                Transaction transaction = new Transaction();
                transaction.dateString = values[0];
                transaction.Description = values[2];
                transaction.Ammount = decimal.Parse(values[3]);
            }

            return new List<Transaction>();
        }
    }
}
