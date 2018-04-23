using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace UnboundColumnForCommenting {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxGridView1.DataSource = GetData();

            if(!IsPostBack && !IsCallback) {
                // pre-define one comment
                MyComments.SetComment(2, "It's me");

                // call DataBind on the first page load 
                // if the grid's DataSource is assigned in code behind
                ASPxGridView1.DataBind();
            }
        }

        private DataTable GetData() {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name");
            table.Rows.Add(1, "Max");
            table.Rows.Add(2, "Nick");
            table.Rows.Add(3, "Plato");
            return table;
        }

        // Fetch unbound data here
        protected void ASPxGridView1_CustomUnboundColumnData(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs e) {
            if(e.IsGetData && e.Column.FieldName == "Comment") {
                object key = e.GetListSourceFieldValue(e.ListSourceRowIndex, ASPxGridView1.KeyFieldName);
                e.Value = MyComments.GetComment(key);
            }
        }

        // Persist unbound data here
        protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
            // main data is read-only to keep this example simple
            e.Cancel = true;
            ASPxGridView1.CancelEdit();

            // only unbound data is editable
            object key = e.Keys[0];
            string newComment = (string)e.NewValues["Comment"];
            MyComments.SetComment(key, newComment);
        }
    }
}
