using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 * @author: Akhil Thakkar
 * @date: May 26, 2016
 * @version: 0.0.1 - added the SetActive method
 */

namespace COMP2007_S2016_Lesson3B
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActive();
        }

        /**
         * 
         * This method below will add a css class of active to list items related
         * to navigation links of every page 
         * 
         * @method SetActive
         * 
         */
        private void SetActive()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}