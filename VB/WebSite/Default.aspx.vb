Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Web.ASPxClasses
Imports DevExpress.Web.ASPxFileManager

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private oldFile As String
	Private fileName As String
	Private ext As String
	Private pattern As String

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim s As String = Request.Params("__CALLBACKPARAM")
		If (Not String.IsNullOrEmpty(s)) Then
			Dim st() As String = s.Split("|"c)
			If (Not String.IsNullOrEmpty(st(0))) AndAlso (Not String.IsNullOrEmpty(st(2))) Then
				If st(0).Contains("ImageToServer") Then
					fileName = Path.GetFileNameWithoutExtension(st(2))
					ext = Path.GetExtension(st(2))
				End If
			End If
		End If
	End Sub

	Protected Sub Page_Unload(ByVal sender As Object, ByVal e As EventArgs)
		If (Not String.IsNullOrEmpty(fileName)) Then
			Dim newFile As String = Path.Combine(Server.MapPath("~/"), pattern)

			' Old file will be overridden as this is an example.
			' In your application use a unique name for files.
			Dim image As New FileInfo(newFile)
			If image.Exists Then
				File.Delete(newFile)
			End If

			If (Not String.IsNullOrEmpty(oldFile)) Then
				File.Move(oldFile, newFile)
			End If
		End If
	End Sub

	Protected Sub he_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
		If (Not String.IsNullOrEmpty(fileName)) Then
			Dim file() As String = Directory.GetFiles(Server.MapPath("~/"), String.Format("{0}*", fileName))
			If file.Length > 0 Then
				oldFile = file(0)
			End If

			' In your application use a unique value for "pattern"
			pattern = String.Format("image{0}", ext)
			e.Properties.Add("cpSrc", Path.GetFileName(oldFile))
			e.Properties.Add("cpPattern", pattern)
		End If
	End Sub

	Protected Sub he_ImageSelectorFileUploading(ByVal source As Object, ByVal e As FileManagerFileUploadEventArgs)
		e.FileName = String.Format("image{0}", Path.GetExtension(e.FileName))
	End Sub
End Class