using System;
using System.IO;
using DevExpress.Web.ASPxClasses;
using DevExpress.Web.ASPxFileManager;

public partial class _Default : System.Web.UI.Page {
    private string oldFile;
    private string fileName;
    private string ext;
    private string pattern;

    protected void Page_Load(object sender, EventArgs e) {
        string s = Request.Params["__CALLBACKPARAM"];
        if(!String.IsNullOrEmpty(s)) {
            string[] st = s.Split('|');
            if(!String.IsNullOrEmpty(st[0]) && !String.IsNullOrEmpty(st[2])) {
                if(st[0].Contains("ImageToServer")) {
                    fileName = Path.GetFileNameWithoutExtension(st[2]);
                    ext = Path.GetExtension(st[2]);
                }
            }
        }
    }

    protected void Page_Unload(object sender, EventArgs e) {
        if(!String.IsNullOrEmpty(fileName)) {
            string newFile = Path.Combine(Server.MapPath("~/"), pattern);

            // Old file will be overridden as this is an example.
            // In your application use a unique name for files.
            FileInfo image = new FileInfo(newFile);
            if(image.Exists)
                File.Delete(newFile);

            if(!String.IsNullOrEmpty(oldFile))
                File.Move(oldFile, newFile);
        }
    }

    protected void he_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        if(!String.IsNullOrEmpty(fileName)) {
            string[] file = Directory.GetFiles(Server.MapPath("~/"), String.Format("{0}*", fileName));
            if(file.Length > 0)
                oldFile = file[0];

            // In your application use a unique value for "pattern"
            pattern = String.Format("image{0}", ext);
            e.Properties.Add("cpSrc", Path.GetFileName(oldFile));
            e.Properties.Add("cpPattern", pattern);
        }
    }

    protected void he_ImageSelectorFileUploading(object source, FileManagerFileUploadEventArgs e) {
        e.FileName = String.Format("image{0}", Path.GetExtension(e.FileName));
    }
}