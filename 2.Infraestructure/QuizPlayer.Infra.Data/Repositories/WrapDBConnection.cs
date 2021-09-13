﻿namespace QuizPlayer.Infra.Data.Repositories
{
    using System;
    using System.Data;
    using System.Data.Common;

    public class WrapDBConnection : DbConnection
    {
        private DbConnection _Connection;

        public WrapDBConnection(DbConnection connection)
        {
            _Connection = connection;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _Connection != null)
            {
                _Connection.Dispose();
            }
            _Connection = null;
            base.Dispose(disposing);
        }

        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            return _Connection.BeginTransaction(isolationLevel);
        }

        public override void Close()
        {
            _Connection.Close();
        }

        public override void ChangeDatabase(String databaseName)
        {
            _Connection.ChangeDatabase(databaseName);
        }

        public override void Open()
        {
            _Connection.Open();
        }

        public override String ConnectionString
        {
            get { return _Connection.ConnectionString; }
            set { _Connection.ConnectionString = value; }
        }

        public override String Database
        {
            get { return _Connection.Database; }
        }

        public override ConnectionState State
        {
            get { return _Connection.State; }
        }

        public override String DataSource
        {
            get { return _Connection.DataSource; }
        }

        public override String ServerVersion
        {
            get { return _Connection.ServerVersion; }
        }

        protected override DbCommand CreateDbCommand()
        {
            const int timeOut = 25;
            var result = _Connection.CreateCommand();
            result.CommandTimeout = timeOut;
            return result;
        }
    }
}