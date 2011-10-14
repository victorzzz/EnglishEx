using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EnglishExtWeb.WCFService.Lesson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnglishExLesson" in both code and config file together.
    [ServiceContract]
    public interface IEnglishExLesson
    {
        [OperationContract]
        void DoWork();
    }
}
