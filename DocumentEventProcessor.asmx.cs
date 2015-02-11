using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.IO;

namespace CleverDome
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class DocumentEventProcessor : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string EventProcessor(string docGuid, string action)
        {
            Guid documentGuid;
            if (Guid.TryParse(docGuid, out documentGuid))
            {
                CleverDome.EventType evt;
                try
                {
                    evt = (CleverDome.EventType)Enum.Parse(typeof(CleverDome.EventType), action);
                }
                catch {
                    //Invalid Document Event.
                }

                //Implement your logics
            }
            else
            {
                //Invalid Document GUID
            }

            return "Ok";
        }
    }
}
