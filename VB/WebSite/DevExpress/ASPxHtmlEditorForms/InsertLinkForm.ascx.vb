Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Web.ASPxHtmlEditor.Localization
Imports DevExpress.Web.ASPxClasses
Imports DevExpress.Web.ASPxEditors

Partial Public Class InsertLinkForm
	Inherits HtmlEditorUserControl
	Protected Overrides Sub PrepareChildControls()
		Localize()

		MyBase.PrepareChildControls()

		Dim documentSelectorEnabled As Boolean = HtmlEditor.SettingsDocumentSelector.Enabled
		txbURL.Buttons(0).Visible = documentSelectorEnabled
		BrowsePopup.Visible = documentSelectorEnabled
	End Sub
	Private Sub Localize()
		rblLinkType.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Url), "URL")
		rblLinkType.Items.Add(ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Email), "Email")
		lblUrl.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Url) & ":"
		txbURL.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError)
		lblEmailTo.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_EmailTo) & ":"
		txbEmailTo.ValidationSettings.RequiredField.ErrorText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.RequiredFieldError)
		lblSubject.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Subject) & ":"
		lblLinkDisplay.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_DisplayProperties)
		lblText.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_Text) & ":"
		lblToolTip.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_ToolTip) & ":"
		ckbOpenInNewWindow.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_OpenInNewWindow)
		btnOk.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonOk)
		btnChange.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonChange)
		btnCancel.Text = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.ButtonCancel)
		BrowsePopup.HeaderText = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.SelectDocument)
		txbURL.Buttons(0).ToolTip = ASPxHtmlEditorLocalizer.GetString(ASPxHtmlEditorStringId.InsertLink_SelectDocument)
	End Sub

	Protected Overrides Function GetChildDxEdits() As ASPxEditBase()
		Return New ASPxEditBase() { rblLinkType, lblUrl, txbURL, lblEmailTo, txbEmailTo, lblSubject, txbSubject, lblLinkDisplay, lblText, txbText, lblToolTip, txbToolTip, ckbOpenInNewWindow }
	End Function
	Protected Overrides Function GetChildDxButtons() As ASPxButton()
		Return New ASPxButton() { btnOk, btnCancel, btnChange }
	End Function
	Protected Overrides Function GetChildDxHtmlEditorRoundPanel() As ASPxHtmlEditorRoundPanel
		Return rpInsertLink
	End Function
End Class