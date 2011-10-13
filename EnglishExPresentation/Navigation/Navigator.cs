using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishExPresentation.Navigation
{
    public static class Navigator
    {
        #region Fields
        private static INavigationWorkflow _navigationWorkflow;
        private static Object _navigationArgument;
        #endregion

        public static void Attach(INavigationWorkflow workflow)
        {
            if (workflow != null)
                _navigationWorkflow = workflow;
        }

        public static Object Argument
        {
            get { return _navigationArgument; }
        }

        public static void Goto(String view)
        {
            if (_navigationWorkflow != null)
                _navigationWorkflow.Goto(view);
        }

        public static void Goto(String view, Object argument)
        {
            if (_navigationWorkflow != null)
            {
                _navigationArgument = argument;
                Navigator.Goto(view);
            }
        }

        public static void NextViewFrom(String currentView)
        {
            if (_navigationWorkflow != null)
                _navigationWorkflow.NextViewFrom(currentView);
        }

        public static void NextViewFrom(String currentView, Object argument)
        {
            if (_navigationWorkflow != null)
            {
                _navigationArgument = argument;
                Navigator.NextViewFrom(currentView, argument);
            }
        }

    }
}
