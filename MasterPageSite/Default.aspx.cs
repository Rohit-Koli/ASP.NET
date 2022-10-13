using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
   // OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Rohit\\Database\\MasterDB.accdb");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*
        con.Open();
        OleDbCommand cmd = new OleDbCommand("insert into NewDB values ('"+txtName.Text+"','"+Convert.ToInt32(txtRno.Text)+"','"+txtCo.Text+"')",con);
        cmd.ExecuteNonQuery();
        con.Close();*/
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        Response.Write("Record IS Inserted !!!");
    }
}