using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumericSequenceCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReturnResult(object sender, EventArgs e)
        {
            divSequence.InnerHtml = "<p><b>Numeric Sequence: Results</b></p>";
            
            var checkedButton = options.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string idString = checkedButton.ID;
            char idStringParsed = idString[idString.Length - 1];

            int id = 0;
            id = (int)Char.GetNumericValue(idStringParsed);

            divSequence.InnerHtml += Calculate.ReturnSequence(txtEnteredNumber.Text, id); 
        } 
    }
}