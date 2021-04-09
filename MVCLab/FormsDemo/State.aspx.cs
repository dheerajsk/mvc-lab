using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsDemo
{
    public partial class State : System.Web.UI.Page
    {
        int counter
        {
            get
            {
                if (ViewState["counter"] is null)
                {
                    return 0;
                }
                return (int)ViewState["counter"];
            }
            set
            {
                ViewState["counter"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblCounter.Text = counter.ToString();
            counter++;
        }
    }
}