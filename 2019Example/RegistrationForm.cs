using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace _2019Example
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }


        public void saveFamilyUser()
        {
            XDocument xdoc = new XDocument(
               new XDeclaration("1.0", "UTF-8", "yes"),
                   new XElement("FamilyUser",
                       new XElement("FirstName", fNameTextbox.Text),
                       new XElement("MiddleInitial", mInitialTextBox.Text),
                       new XElement("LastName", lNameTextBox.Text),
                       new XElement("Address", addressTextBox.Text),
                       new XElement("City", cityTextBox.Text),
                       new XElement("State", stateTextBox.Text),
                       new XElement("ZipCode", zipcodeTextBox.Text),
                       new XElement("UserID", userIDTextBox.Text),
                       new XElement("Password", passwordTextBox.Text),
                       new XElement("PhoneNumber", phoneNumberTextBox.Text),
                       new XElement("EmailAddress", emailAddressTextBox.Text)
                       )
               );

            xdoc.Save("C:/Users/Wayla/source/repos/2019Example.xml");
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            saveFamilyUser();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
