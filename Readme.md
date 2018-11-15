<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [ImagePropertiesForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx) (VB: [ImagePropertiesForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx.vb))
* [ImagePropertiesForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx.cs) (VB: [ImagePropertiesForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/ImagePropertiesForm.ascx.vb))
* [InsertImageForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx) (VB: [InsertImageForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.vb))
* [InsertImageForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.cs) (VB: [InsertImageForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.vb))
* [InsertLinkForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx) (VB: [InsertLinkForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx.vb))
* [InsertLinkForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx.cs) (VB: [InsertLinkForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertLinkForm.ascx.vb))
* [InsertTableForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx) (VB: [InsertTableForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx))
* [InsertTableForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx.cs) (VB: [InsertTableForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertTableForm.ascx))
* [PasteFromWordForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx) (VB: [PasteFromWordForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx))
* [PasteFromWordForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx.cs) (VB: [PasteFromWordForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/PasteFromWordForm.ascx))
* [SelectDocumentForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/SelectDocumentForm.ascx) (VB: [SelectDocumentForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/SelectDocumentForm.ascx.vb))
* [SelectDocumentForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/SelectDocumentForm.ascx.cs) (VB: [SelectDocumentForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/SelectDocumentForm.ascx.vb))
* [SelectImageForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx) (VB: [SelectImageForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx))
* [SelectImageForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx.cs) (VB: [SelectImageForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/SelectImageForm.ascx))
* [TableColumnPropertiesForm.ascx](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx) (VB: [TableColumnPropertiesForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx))
* [TableColumnPropertiesForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx.cs) (VB: [TableColumnPropertiesForm.ascx](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/TableColumnPropertiesForm.ascx))
* [SpellCheckForm.ascx](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx) (VB: [SpellCheckForm.ascx](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx))
* [SpellCheckForm.ascx.cs](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx.cs) (VB: [SpellCheckForm.ascx](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckForm.ascx))
* [SpellCheckOptionsForm.ascx](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx) (VB: [SpellCheckOptionsForm.ascx](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx))
* [SpellCheckOptionsForm.ascx.cs](./CS/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx.cs) (VB: [SpellCheckOptionsForm.ascx](./VB/WebSite/DevExpress/ASPxSpellCheckerForms/SpellCheckOptionsForm.ascx))
<!-- default file list end -->
# How to implement a custom naming convention for images uploaded by the ASPxHtmlEditor


<p>There are three places to make changes to implement your own naming convention for images uploaded by ASPxHtmlEditor.</p><p>If you load an image “from your computer” you can set the file name in a SaveUploadFile method of the InsertImageForm class. To find this method, <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8904"><u>copy the default dialog forms</u></a> to your web project and view the InsertImageForm.ascx.cs file.</p><p>Please note that the names of uploaded images must be unique.</p><p>If the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxHtmlEditorASPxHtmlEditor_SettingsImageSelectortopic"><u>ASPxHtmlEditor.SettingsImageSelector</u></a> and ASPxHtmlEditor.SettingsImageSelector.UploadSettings are enabled, you can change a file name in the ImageSelectorFileUploading event handler.</p><p>Lastly, if you load an image “from the web (URL)" you have to save a file name directly and change its name after it is saved on a server.</p><p>To do this: first, on Page_Load, store an uploaded image file name and file extension. Then, handle the CustomJSProperties event to send the filename and your image name pattern to the client-side. Handle the OnCommandExecuted client-side event and set the image’s tag src parameter in the html text of the ASPxHtmlEditor. And, rename the Page_Unload uploaded image according to your pattern.</p>

<br/>


