using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsDemo
{
    public partial class _Default : Page
    {
        string log = "";

        protected void Page_PreInit(object sender, EventArgs e)
        {
            log += "page_preinit()<br>";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            log += "page_init()<br>";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            log += "page_initComplete()<br>";

        }

        protected override void OnPreLoad(EventArgs e)
        {
            log += "OnPreload()<br>";

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {

        }

    }
}