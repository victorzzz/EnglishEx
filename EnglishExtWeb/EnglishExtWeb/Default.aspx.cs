using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.Unity;
using EnglishExPresentation.Presenters.Home;
using EnglishExPresentation.ViewInterfaces.Home; 

namespace EnglishExtWeb
{
    public partial class _Default : System.Web.UI.Page, IHomeView
    {
        private HomePresenter _presenter = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new HomePresenter(this);
        }
    }
}
