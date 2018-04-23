# How to implement a custom naming convention for images uploaded by the ASPxHtmlEditor


<p>There are three places to make changes to implement your own naming convention for images uploaded by ASPxHtmlEditor.</p><p>If you load an image “from your computer” you can set the file name in a SaveUploadFile method of the InsertImageForm class. To find this method, <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8904"><u>copy the default dialog forms</u></a> to your web project and view the InsertImageForm.ascx.cs file.</p><p>Please note that the names of uploaded images must be unique.</p><p>If the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxHtmlEditorASPxHtmlEditor_SettingsImageSelectortopic"><u>ASPxHtmlEditor.SettingsImageSelector</u></a> and ASPxHtmlEditor.SettingsImageSelector.UploadSettings are enabled, you can change a file name in the ImageSelectorFileUploading event handler.</p><p>Lastly, if you load an image “from the web (URL)" you have to save a file name directly and change its name after it is saved on a server.</p><p>To do this: first, on Page_Load, store an uploaded image file name and file extension. Then, handle the CustomJSProperties event to send the filename and your image name pattern to the client-side. Handle the OnCommandExecuted client-side event and set the image’s tag src parameter in the html text of the ASPxHtmlEditor. And, rename the Page_Unload uploaded image according to your pattern.</p>

<br/>


