using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishExPresentation.Navigation
{
    public interface INavigationWorkflow
    {
        void Goto(String view);
        void NextViewFrom(String currentView);
    }
}
