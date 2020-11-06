using BasketballLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Basketball
{
    public partial class _Default : Page
    {
        PlayerCollection player = new PlayerCollection();
        Team team = new Team();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                player.PlayersDal();
                foreach (Player item in player.GetPlayers())
                {
                    ddlSpelers.Items.Add(item.FirstName + " " + item.LastName);
                }
            }
        }

        protected void bnAdd_Click(object sender, EventArgs e)
        {
            player.PlayersDal();
            Session["player"] = ddlSpelers.SelectedValue;
            foreach (Player item in player.GetPlayers())
            {
                if (ddlSpelers.SelectedValue == item.FirstName + " " + item.LastName)
                {
                    team.AddPlayer(item);
                }
            }
            foreach (Player item1 in team.GetPlayers())
            {
                ListBox1.Items.Add(item1.LastName);
            }
            tbName.Text = (string)Session["player"];
        }

        protected void bnShow_Click(object sender, EventArgs e)
        {

        }

    }
}