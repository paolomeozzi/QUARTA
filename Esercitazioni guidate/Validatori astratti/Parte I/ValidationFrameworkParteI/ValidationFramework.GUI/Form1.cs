using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ValidationFramework.GUI
{
    using Validators;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        GroupValidator groupValid;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRegistra.Select();

            groupValid = new GroupValidator();
            groupValid.Add(new NotEmptyValidator(() => txtNominativo.Text));
            groupValid.Add(new DateValidator(() => txtDataNascita.Text));
            groupValid.Add(new MailValidator(() => txtMail.Text));


        }
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //bool ok = notEmptyValid.Validate() && dateValid.Validate() && mailValid.Validate();
            bool ok = groupValid.Validate();
            if (ok)
            {
                lblRisultato.ForeColor = Color.DarkGreen;
                lblRisultato.Text = "Utente registrato con successo";
            }
            else
            {
                lblRisultato.Text = "Uno o più dati non sono validi";
                lblRisultato.ForeColor = Color.DarkRed;
            }
        }
        
    }
}
