using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// step 1 include database library
using System.Data.SqlClient;


namespace basicWebApplication
{
    public partial class DBConnect : System.Web.UI.Page
    {
        // step 2 create database object
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            // step 3 break page refreshment
            if (!IsPostBack)
            {
                //  
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // step 1 open database
            string path = "Database connection";
            con = new SqlConnection(path);

            con.Open();

            // step 2 apply command
            string k = "INSERT query";
            com = new SqlCommand(k, con); // variable, connection object

            // step 3 execute command
            com.ExecuteNonQuery(); 
        }
    }
}