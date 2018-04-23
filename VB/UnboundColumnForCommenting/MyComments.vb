Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections

Namespace UnboundColumnForCommenting
	Public NotInheritable Class MyComments
		Private Const StorageName As String = "MyComments"

		Private Sub New()
		End Sub
		Private Shared Property Storage() As Hashtable
			Get
				Return CType(HttpContext.Current.Session(StorageName), Hashtable)
			End Get
			Set(ByVal value As Hashtable)
				HttpContext.Current.Session(StorageName) = value
			End Set
		End Property

		Public Shared Function GetComment(ByVal rowKey As Object) As String
			Dim hash As Hashtable = Storage
			If hash IsNot Nothing Then
				Return CStr(hash(rowKey))
			End If
			Return Nothing
		End Function

		Public Shared Sub SetComment(ByVal rowKey As Object, ByVal comment As String)
			Dim hash As Hashtable = Storage
			If hash Is Nothing Then
				hash = New Hashtable()
			End If
			hash(rowKey) = comment
			Storage = hash
		End Sub
	End Class
End Namespace
