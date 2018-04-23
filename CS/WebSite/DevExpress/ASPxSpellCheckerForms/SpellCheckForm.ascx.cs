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
using DevExpress.Web.ASPxSpellChecker;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxSpellChecker.Localization;
using DevExpress.Web.ASPxClasses.Internal;

public partial class SpellCheckForm : SpellCheckerUserControl {
    protected override void PrepareChildControls() {
        PrepareCheckedDiv();
        PrepareChangeToPanel();
        PrepareAddToDictionaryButton();
        Localize();

        base.PrepareChildControls();
    }
    protected override ASPxEditBase[] GetChildDxEdits() {
        return new ASPxEditBase[] { txtChangeTo, SCSuggestionsListBox };
    }

    protected override ASPxButton[] GetChildDxButtons() {
        return new ASPxButton[] {
            btnAddToDictionary,
            btnChange,
            btnChangeAll,
            btnClose,
            btnIgnore,
            btnIgnoreAll,
            btnOptions
        };
    }

    protected void PrepareAddToDictionaryButton() {
        btnAddToDictionary.Enabled = SpellChecker.GetCustomDictionary() != null;
    }
    protected void PrepareCheckedDiv() {
        WebControl checkedDiv = RenderUtils.CreateDiv();
        checkedDiv.ID = "SCCheckedDiv";
        SCCheckedDivPlaceHolder.Controls.Add(checkedDiv);

        CheckedTextContainerStyle style = SpellChecker.GetCheckedTextContainerStyle();
        checkedDiv.Attributes.Add("class", style.CssClass);
        CssStyleCollection styles = style.GetStyleAttributes(Page);
        foreach (string key in styles.Keys)
            checkedDiv.Style.Add(key, styles[key]);
    }
    protected void PrepareChangeToPanel() {
        ClientIDHelper.EnableClientIDGeneration(txtChangeTo);
        ClientIDHelper.EnableClientIDGeneration(SCSuggestionsListBox);
    }
	protected void Localize() {
		btnIgnore.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.IgnoreOnceButton);
		btnIgnoreAll.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.IgnoreAllButton);
		btnAddToDictionary.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.AddToDictionaryButton);
		btnChange.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.ChangeButton);
		btnChangeAll.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.ChangeAllButton);
		btnOptions.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.OptionsButton);
		btnClose.Text = ASPxSpellCheckerLocalizer.GetString(ASPxSpellCheckerStringId.CloseButton);
	}
}