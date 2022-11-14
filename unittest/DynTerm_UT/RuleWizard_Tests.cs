using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using term;
using System.Windows.Forms;

namespace DynTerm_UT
{
    [TestClass]
    public class RuleWizard_Tests
    {
        Form_Center mock_center = new Form_Center();

        [TestMethod]
        public void Test_NegativeDisplayOutput_Not_Enabled_When_ExecuteAlways()
        {
            Form_NewEditRule testForm = new Form_NewEditRule(mock_center, false);

            testForm.cob_CheckOperation.SelectedIndex = (int)(KeywordCheckOperation.ExecuteAlways);

            testForm.chb_output.Checked = false;

            Assert.AreEqual(testForm.lbl_negOutput_Title.Enabled, false);
            Assert.AreEqual(testForm.lbl_negOutputElement.Enabled, false);
            Assert.AreEqual(testForm.cob_outputElementNeg.Enabled, false);
            Assert.AreEqual(testForm.cob_negativeOutput.Enabled, false);
        }

        [TestMethod]
        public void Test_NegativeSerialOutput_Not_Enabled_When_ExecuteAlways()
        {
            Form_NewEditRule testForm = new Form_NewEditRule(mock_center, false);

            testForm.cob_CheckOperation.SelectedIndex = (int)(KeywordCheckOperation.ExecuteAlways);

            testForm.chb_serialOption.Checked = false;

            Assert.AreEqual(testForm.lbl_sendNeg.Enabled, false);
            Assert.AreEqual(testForm.chb_sendIfNegative.Enabled, false);
            Assert.AreEqual(testForm.txt_sendIfNegative.Enabled, false);
            Assert.AreEqual(testForm.chb_sendIfNegative.Checked, false);
        }

        [TestMethod]
        public void Test_NegativeSerialOutput_Enabled_When_Not_ExecuteAlways()
        {
            Form_NewEditRule testForm = new Form_NewEditRule(mock_center, false);

            testForm.cob_CheckOperation.SelectedIndex = (int)(KeywordCheckOperation.Contains);

            testForm.chb_serialOption.Checked = true;

            Assert.AreEqual(testForm.lbl_sendNeg.Enabled, true);
            Assert.AreEqual(testForm.chb_sendIfNegative.Enabled, true);
            Assert.AreEqual(testForm.txt_sendIfNegative.Enabled, true);
            Assert.AreEqual(testForm.chb_sendIfNegative.Checked, true);
        }
    }
}
