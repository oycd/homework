using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace 教务系统
{
    class DBHelper
    {
        DbProviderFactory factor;//工厂模式
        string connString;
        DbConnection conn;
        DbCommand cmd;
        DbDataAdapter adapter;
        public DBHelper(string provider)
        {
            factor = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings[provider].ProviderName);
            connString = ConfigurationManager.ConnectionStrings[provider].ToString();
            conn = factor.CreateConnection();
            conn.ConnectionString = connString;
            cmd = factor.CreateCommand();
            cmd.Connection = conn;
            adapter = factor.CreateDataAdapter();
        }

        //连接数据库
        public bool Connection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //断开连接
        public void DisConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //数据更新操作，返回影响记录数量
        public long Update(string sSql)
        {
            long nRow = 0;
            if (conn.State != ConnectionState.Open)
            {
                if (!this.Connection())
                {
                    nRow = -1;
                    return nRow;
                }
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            try
            {
                nRow = cmd.ExecuteNonQuery();
            }
            catch
            {
                nRow = 0;
            }
            return nRow;
        }

        //数据检索
        public DbDataReader DataRead(string sSql)
        {
            DbDataReader reader = null;
            if (conn.State != ConnectionState.Open)
            {
                if (!this.Connection())
                {
                    reader = null;
                    return reader;
                }
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch
            {
                reader = null;
            }
            return reader;
        }

        //执行查询，返回一个DataTable
        public DataTable FillTable(string sSql)
        {
            DataTable table = new DataTable();
            if (conn.State != ConnectionState.Open)
            {
                if (!this.Connection())
                {
                    table = null;
                    return table;
                }
            }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            adapter.SelectCommand = cmd;
            try
            {
                adapter.Fill(table);
            }
            catch
            {
                table = null;
            }
            return table;
        }
    }
}
