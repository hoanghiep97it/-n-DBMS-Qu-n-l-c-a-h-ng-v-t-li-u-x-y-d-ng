﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUAN_LY_CUA_HANG_VLXD.DAL
{
    public class DALayer
    {
        string ketnoi = "Data Source = DESKTOP-F5AQID7;Initial Catalog=CUA_HANG_VAT_LIEU_XAY_DUNG_NGHIA_HIEP;Integrated Security=True;";
        //string ketnoi ="Server= 192.168.100.6;Database=CUA_HANG_VAT_LIEU_XAY_DUNG_NGHIA_HIEP;User Id=hiep; Password=123";
        //string ketnoi = "Server= 192.168.43.125;Database=CUA_HANG_VAT_LIEU_XAY_DUNG_NGHIA_HIEP;User Id=hiep; Password=123";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DALayer()
        {
            conn = new SqlConnection(ketnoi);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSql, CommandType cmt, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)

                conn.Close();

            conn.Open();
            //Command.Parameters.Clear();
            comm.CommandText = strSql;
            comm.CommandType = cmt;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        //public bool MyExcuteNonQuery(string strSQL, CommandType cmt, ref string error,
        //    params SqlParameter[] para)
        //{
        //    bool f = false;
        //    try
        //    {
        //        if (conn.State == ConnectionState.Open)
        //            conn.Close();
        //        conn.Open();
        //        comm.Parameters.Clear();
        //        comm.CommandType = cmt;
        //        comm.CommandText = strSQL;
        //        //foreach (SqlParameter p in para)
        //        //{
        //        //    comm.Parameters.Add(p);
        //        //}
        //        try
        //        {
        //            comm.ExecuteNonQuery();
        //            f = true;
        //        }
        //        catch (Exception e)
        //        {
        //            error = e.Message;
        //        }

        //    }
        //    catch (SqlException e)
        //    {
        //        error = e.Message;
        //    }
        //    return f;
        //}
        public int MyExecuteScalar(string strsql, CommandType cmt, ref string error, params SqlParameter[] p)
        {
            int temp = 0;
            if (conn.State == ConnectionState.Open)

                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strsql;
            comm.CommandType = cmt;



            foreach (SqlParameter i in p)

                comm.Parameters.Add(i);
            try
            {
                temp = (int)comm.ExecuteScalar();

            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return temp;


        }
    }
}
