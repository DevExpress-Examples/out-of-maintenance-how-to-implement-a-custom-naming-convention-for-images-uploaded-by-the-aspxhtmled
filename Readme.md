<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545036/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4330)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [InsertImageForm.ascx.cs](./CS/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.cs) (VB: [InsertImageForm.ascx.vb](./VB/WebSite/DevExpress/ASPxHtmlEditorForms/InsertImageForm.ascx.vb))
<!-- default file list end -->
# How to implement a custom naming convention for images uploaded by the ASPxHtmlEditor
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4330)**
<!-- run online end -->


<p>There are three places to make changes to implement your own naming convention for images uploaded by ASPxHtmlEditor.</p><p>If you load an image “from your computer” you can set the file name in a SaveUploadFile method of the InsertImageForm class. To find this method, <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8904"><u>copy the default dialog forms</u></a> to your web project and view the InsertImageForm.ascx.cs file.</p><p>Please note that the names of uploaded images must be unique.</p><p>If the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxHtmlEditorASPxHtmlEditor_SettingsImageSelectortopic"><u>ASPxHtmlEditor.SettingsImageSelector</u></a> and ASPxHtmlEditor.SettingsImageSelector.UploadSettings are enabled, you can change a file name in the ImageSelectorFileUploading event handler.</p><p>Lastly, if you load an image “from the web (URL)" you have to save a file name directly and change its name after it is saved on a server.</p><p>To do this: first, on Page_Load, store an uploaded image file name and file extension. Then, handle the CustomJSProperties event to send the filename and your image name pattern to the client-side. Handle the OnCommandExecuted client-side event and set the image’s tag src parameter in the html text of the ASPxHtmlEditor. And, rename the Page_Unload uploaded image according to your pattern.</p>

<br/>


