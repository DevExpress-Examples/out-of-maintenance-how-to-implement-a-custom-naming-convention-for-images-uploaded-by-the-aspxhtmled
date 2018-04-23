<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v13.1, Version=13.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v13.1, Version=13.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>How to implement a custom naming convention for images uploaded by the ASPxHtmlEditor</title>
	<script type="text/javascript">
		function he_OnCommandExecuted(s, e) {
			if (e.commandName === ASPxClientCommandConsts.INSERTIMAGE_COMMAND) {
				var text = he.GetHtml();
				var newText = text.replace(he.cpSrc, he.cpPattern);
				he.SetHtml(newText);
				return;
			}
		}
	</script>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxHtmlEditor ID="he" runat="server" ClientInstanceName="he" OnCustomJSProperties="he_CustomJSProperties"
			OnImageSelectorFileUploading="he_ImageSelectorFileUploading">
			<ClientSideEvents CommandExecuted="he_OnCommandExecuted" />
			<SettingsForms InsertImageFormPath="~/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx"
				InsertLinkFormPath="~/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx"
				InsertTableFormPath="~/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx"
				PasteFromWordFormPath="~/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx"
				TableColumnPropertiesFormPath="~/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx">
				<SpellCheckerForms SpellCheckFormPath="~/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx"
					SpellCheckOptionsFormPath="~/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx" />
			</SettingsForms>
			<SettingsImageSelector Enabled="true">
				<UploadSettings Enabled="true"></UploadSettings>
			</SettingsImageSelector>
		</dx:ASPxHtmlEditor>
	</form>
</body>
</html>