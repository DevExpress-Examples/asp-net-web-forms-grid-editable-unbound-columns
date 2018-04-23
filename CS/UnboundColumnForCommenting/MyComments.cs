using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;

namespace UnboundColumnForCommenting {
    public static class MyComments {
        const string StorageName = "MyComments";

        private static Hashtable Storage {
            get {
                return (Hashtable)HttpContext.Current.Session[StorageName];
            }
            set {
                HttpContext.Current.Session[StorageName] = value;
            }
        }

        public static string GetComment(object rowKey) {
            Hashtable hash = Storage;
            if(hash != null)
                return (string)hash[rowKey];
            return null;
        }

        public static void SetComment(object rowKey, string comment) {
            Hashtable hash = Storage;
            if(hash == null)
                hash = new Hashtable();
            hash[rowKey] = comment;
            Storage = hash;
        }
    }
}
