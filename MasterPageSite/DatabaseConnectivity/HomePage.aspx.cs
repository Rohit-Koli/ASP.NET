using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class HomePage : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Rohit\\Database\\DatbaseCon1.accdb");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        con.Open();
        int rn = Convert.ToInt32(txtRno.Text);
        string name=txtName.Text;
        string mail = txtMail.Text;
        OleDbCommand cmd = new OleDbCommand("insert into DB values("+rn+",'"+name+"','"+mail+"')",con);
        int c = cmd.ExecuteNonQuery();
        if (c == 1)
        {
            Response.Write("Record Inserted !!");
        }
        else
        {
            Response.Write("Fail to Insert Record !!");
        }
        con.Close();        
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();
        int rn = Convert.ToInt32(txtRno.Text);
        string name = txtName.Text;
        string mail = txtMail.Text;
        OleDbCommand cmd2 = new OleDbCommand("update DB set Sname='" + name + "',mail='" + mail + " ' where rno=" + rn + " ", con);
        int c = cmd2.ExecuteNonQuery();
        if (c == 1)
        {
            Response.Write("Record Updated !!");
        }
        else
        {
            Response.Write("Fail to Update Record !!");
        }
        con.Close();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        int rn = Convert.ToInt32(txtRno.Text);
        OleDbCommand cmd3 = new OleDbCommand("delete from DB where rno=" + rn + "", con);
        int c = cmd3.ExecuteNonQuery();
        if (c == 1)
        {
            Response.Write("Record has been Deleted !!");
        }
        else
        {
            Response.Write("Fail to Deleted Record !!");
        }
        con.Close();
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        con.Open();
        int rn = Convert.ToInt32(txtRno.Text);
        OleDbCommand cmd4 = new OleDbCommand("select * from DB where rno="+rn+"",con);
        OleDbDataReader r = cmd4.ExecuteReader();
        while (r.Read())
        {
            txtRno.Text = r["rno"].ToString();
            txtName.Text = r["Sname"].ToString();
            txtMail.Text = r["mail"].ToString();
        }
        con.Close();
    }
}