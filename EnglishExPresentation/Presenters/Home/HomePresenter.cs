using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnglishExPresentation.ViewInterfaces.Home;

namespace EnglishExPresentation.Presenters.Home
{
    public class HomePresenter
    {
        private readonly IHomeView _view;

        public HomePresenter(IHomeView view)
        {
            _view = view;
        }
    }
}
