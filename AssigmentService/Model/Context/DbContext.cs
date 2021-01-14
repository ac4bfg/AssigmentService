﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.OleDb;

namespace AssigmentService.Model.Context
{
    public class DbContext : IDisposable
    {

        private OleDbConnection _conn;

        public OleDbConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }


        private OleDbConnection GetOpenConnection()
        {
            OleDbConnection conn = null; 

            try 
            {
                string dbName = Directory.GetCurrentDirectory() + "\\FP.accdb";

                string connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", dbName);

                conn = new OleDbConnection(connectionString); 
                conn.Open(); 
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }


        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
