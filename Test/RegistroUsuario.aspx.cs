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
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=BARCELONA;Initial Catalog=Test;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                cargar_comboProvincia();
            }

        }

        public void cargar_comboProvincia() {

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Proc_ComboProvincia", sqlCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            sqlDa.Fill(ds);

            dlist_provincia.DataSource = ds;
            dlist_provincia.DataTextField = "PRO_NOMBRE";
            dlist_provincia.DataValueField = "IDProvincia";
            dlist_provincia.DataBind();

            dlist_provincia.Items.Insert(0, new ListItem("[Seleccionar]","0"));
            dlist_ciudad.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

        }

            

        protected void ProvinciaSelecciona(object sender, EventArgs e)
        {
            int PaisID = Convert.ToInt32(dlist_provincia.SelectedValue);

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlDa = new SqlCommand("Proc_ComboCiudad", sqlCon);

            sqlDa.CommandType = CommandType.StoredProcedure;
            sqlDa.Parameters.AddWithValue("@IDProvincia", PaisID);


            SqlDataAdapter da = new SqlDataAdapter(sqlDa);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dlist_ciudad.DataSource = ds;
            dlist_ciudad.DataTextField = "CIU_NOMBRE";
            dlist_ciudad.DataValueField = "IDCuidad";
            dlist_ciudad.DataBind();

            dlist_ciudad.Items.Insert(0, new ListItem("[Seleccionar]", "0"));


        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("Proc_RegistroUsuario", sqlCon);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@IDRegistro", (hfContactID.Value == "" ? 0 : Convert.ToInt32(hfContactID.Value)));
            sqlCmd.Parameters.AddWithValue("@FK_CIUDAD", dlist_ciudad.SelectedValue);
            sqlCmd.Parameters.AddWithValue("@USU_NOMBRE", txt_name.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@USU_USUARIO", txt_usuario.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@USU_CONTRASENA", txt_contrasena.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@USU_CEDULA", txt_cedula.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@USU_CORREO", txt_correo.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@USU_ESTADO", 'A');

            sqlCmd.ExecuteNonQuery();

            sqlCon.Close();

            string contacID = hfContactID.Value;

            Clear();

            if (contacID == "")
            {
                lblSuccefullMessagge.Text = "Save Succefull";
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblerrorMessagge.Text = "Update Succefull";

            }
        }

        public void Clear()
        {
            hfContactID.Value = "";
            txt_name.Text = "";
            lblSuccefullMessagge.Text = lblerrorMessagge.Text = "";
            txt_usuario.Text = "";
            txt_contrasena.Text = "";
            txt_cedula.Text = "";
            txt_correo.Text = "";
            btn_save.Text = "Save";
           
        }

       
    }
}