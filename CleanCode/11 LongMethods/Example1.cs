using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FooFoo
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = CreateMemoryFile();

            byte[] byteArray = ms.ToArray();
            ms.Flush();
            ms.Close();

            PageResponseClear(Response);
            PageResponseCreate(Response, byteArray);

        }

        public System.IO.MemoryStream CreateMemoryFile()
        {
            MemoryStream ReturnStream = new MemoryStream();
            //Create a streamwriter to write to the memory stream
            StreamWriter streamWriter = new StreamWriter(ReturnStream);
            try
            {
                string stringConnection = ConfigurationManager.ConnectionStrings["FooFooConnectionString"].ToString();
                SqlConnection Connection = new SqlConnection(stringConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [FooFoo] ORDER BY id ASC", Connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "FooFoo");
                DataTable dataTable = dataSet.Tables["FooFoo"];

                CreateStreamwriter(streamWriter, dataTable);
                WriteRows(streamWriter, dataTable);
                StreamerClean(streamWriter);                
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return ReturnStream;
        }

        private void PageResponseClear(HttpResponse Response)
        {
            //Clears the response 
            Response.Clear();
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Cookies.Clear();
        }

        private void PageResponseCreate(HttpResponse Response, byte[] byteArray)
        {
            //Set cache, encoding and creates Header
            Response.Cache.SetCacheability(HttpCacheability.Private);
            Response.CacheControl = "private";
            Response.Charset = System.Text.UTF8Encoding.UTF8.WebName;
            Response.ContentEncoding = System.Text.UTF8Encoding.UTF8;
            Response.AppendHeader("Pragma", "cache");
            Response.AppendHeader("Expires", "60");
            Response.ContentType = "text/comma-separated-values";
            Response.AddHeader("Content-Disposition", "attachment; filename=FooFoo.csv");
            Response.AddHeader("Content-Length", byteArray.Length.ToString());
            Response.BinaryWrite(byteArray);
        }


        private void CreateStreamwriter(StreamWriter textWriter, DataTable dataTable)
        {
            int ColumnCount = dataTable.Columns.Count;

            for (int i = 0; i < ColumnCount; i++)
            {
                textWriter.Write(dataTable.Columns[i]);
                if (i < ColumnCount - 1)
                {
                    textWriter.Write(",");
                }
            }
            textWriter.WriteLine();
        }

        private void WriteRows(StreamWriter textWriter, DataTable dataTable)
        {
            int RowsCount = dataTable.Rows.Count;
            int ColumnCount = dataTable.Columns.Count;

            // Now write all the rows.
            foreach (DataRow DataRow in dataTable.Rows)
            {
                for (int i = 0; i < ColumnCount; i++)
                {

                    if (!Convert.IsDBNull(DataRow[i]))
                    {
                        // Replace html empty data with dataTable rows
                        string rowString = String.Format("\"{0:c}\"", DataRow[i].ToString()).Replace("\r\n", " ");
                        textWriter.Write(rowString);
                    }
                    else
                    {
                        textWriter.Write("");
                    }

                    if (i < ColumnCount - 1)
                    {
                        textWriter.Write(",");
                    }
                }
                textWriter.WriteLine();
            }
        }

        private void StreamerClean(StreamWriter textWriter)
        {
            textWriter.Flush();
            textWriter.Close();
        }
    }
}