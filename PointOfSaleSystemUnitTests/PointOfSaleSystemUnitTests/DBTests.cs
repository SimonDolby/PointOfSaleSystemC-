using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSaleSystemUnitTests
{
    [TestClass]
    public class DBTests
    {
        [TestMethod]
        public void DBConnectionTest()

        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.DBConnectionString;
            con.Open();
            MessageBox.Show("This connection is working");
            con.Close();

        }

        [TestMethod]
        public void AddStaffMemberTest()
        {

            
        }

        public void AddProductTest()

        {


        }


    }

}
