﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.EF6;

namespace WpfEnergyCalculator.Data
{
    public class Configuration : DbConfiguration
    {
        public Configuration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);

            var providerServices = (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices));

            SetProviderServices("System.Data.SQLite", providerServices);
            SetProviderServices("System.Data.SQLite.EF6", providerServices);
        }

        public DbConnection CreateConnection(string connectionString)
            => new SQLiteConnection(connectionString);
    }
}
