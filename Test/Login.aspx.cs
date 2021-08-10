using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class Login : System.Web.UI.Page
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=BARCELONA;Initial Catalog=Test;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        String usu_G;

        protected void btn_Inicio_Click(object sender, EventArgs e)
        {


            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Proc_InicionSesion", sqlCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@USU_USUARIO", txt_usuario.Text.Trim());
            sqlDa.SelectCommand.Parameters.AddWithValue("@USU_CONTRASENA", txt_contresena.Text.Trim());
            DataTable dt = new DataTable();

            sqlDa.Fill(dt);
            sqlCon.Close();

            if (dt.Rows.Count > 0)
            {

                lbl_mensaje.Text = "Usuario Encontrado";
                clear();

                Response.Redirect("Master_Compras.aspx");
                usu_G = dt.Rows[0]["IDRegistro"].ToString();
            }
            else {

                lbl_mensaje.Text = "Usuario No Encontrado";
                usu_G = "";
                clear();
            }
           


        }


        public void clear() {

            txt_usuario.Text = txt_contresena.Text = "";
        }

        protected void linkRegistrarse_Click(object sender, EventArgs e)
        {

            Response.Redirect("RegistroUsuario.aspx"); 


        }
    }
}