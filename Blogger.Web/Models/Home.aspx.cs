using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtDogumTarihi.Text = "";
                txtAdres.Text = "";
            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            lblAdSoyad.Text = $"{txtAd.Text} {txtSoyad.Text}";
            lblCinsiyet.Text = $"({rdCinsiyet.SelectedValue})- {rdCinsiyet.SelectedItem.Text}";
            lblDogumTarihi.Text = txtDogumTarihi.Text;
            lblAdres.Text = txtAdres.Text;
            pnlResult.Visible = true;
        }
    }
}