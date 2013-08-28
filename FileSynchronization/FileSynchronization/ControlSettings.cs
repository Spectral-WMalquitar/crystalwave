using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlUtilities
{
    class ControlSettings
    {
        public static void SetTextToNull(Control sourceForm)
        {
            foreach (Control c in sourceForm.Controls)
            {
                if (c.GetType().Name.Equals("TextBox"))
                    c.Text = "";
            }
        }
        public static bool isAllTextHasValue(Control sourceForm)
        {
            foreach (Control c in sourceForm.Controls)
            {
                if (c.GetType().Name.Equals("TextBox"))
                    if (c.Text.Trim().Equals("")) return false;
            }
            return true;
        }
        public static bool isRadioSelected(Control sourceForm)
        {
            foreach (Control c in sourceForm.Controls)
            {
                if (c.GetType().Name.Equals("RadioButton"))
                {
                    RadioButton radioButton = (RadioButton)c;
                    if (radioButton.Checked) return true;
                }
            }
            return false;
        }
        public static void SetComboToFirstItem(ComboBox comboBox)
        {
            comboBox.SelectedIndex = 0;
        }
        public static void SetAllRadioButtonToFalse(Control sourceForm)
        {
            foreach (Control c in sourceForm.Controls)
            {
                if (c.GetType().Name.Equals("RadioButton"))
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Checked = false;
                }
            }
        }
        public static void SetRadioButtonToTrue(RadioButton radioButton)
        {
            radioButton.Checked = true;
        }
        public static void SetAllCheckBoxValue(Control sourceForm, bool setTo)
        {
            foreach (Control c in sourceForm.Controls)
            {
                CheckBox checkBox = (CheckBox)c;
                checkBox.Checked = setTo;
            }
        }
        public static void SetControlEnabled(Control sourceForm, bool setTo, String[] listOfControls)
        {
            foreach (Control c in sourceForm.Controls)
            {
                foreach (String controlType in listOfControls)
                {
                    if (c.GetType().Name.Equals(controlType))
                        c.Enabled = setTo;
                }
            }
        }
        public static string RemoveQuotes(string sourceStr)
        {
            return sourceStr.Replace("\"", "").Replace("\'", "");
        }
    }
}
