<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="UnboundColumnForCommenting._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=9B171C9FD64DA1D1"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=9B171C9FD64DA1D1"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" KeyFieldName="ID" OnCustomUnboundColumnData="ASPxGridView1_CustomUnboundColumnData" OnRowUpdating="ASPxGridView1_RowUpdating" Width="307px">
			<Columns>
				<dxwgv:GridViewDataTextColumn FieldName="Name" ReadOnly="True" VisibleIndex="0">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="Comment" UnboundType="String" VisibleIndex="1">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewCommandColumn VisibleIndex="2">
					<EditButton Visible="True">
					</EditButton>
					<CancelButton Visible="True">
					</CancelButton>
					<UpdateButton Visible="True">
					</UpdateButton>
					<ClearFilterButton Visible="True">
					</ClearFilterButton>
				</dxwgv:GridViewCommandColumn>
			</Columns>
		</dxwgv:ASPxGridView>
	</div>
	</form>
</body>
</html>
