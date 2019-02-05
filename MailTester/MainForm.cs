using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e) // parametry -> object sender -> przyciśnięcie (coś co wywołało), event args -> parametry zwiazane z kliknięciem
        {
            string text = Send.Text;
            //var b = (Button)sender; //rzutowanie -> rzuca wyjąkiem w przypadku nieudanej konwersji
            var b = sender as Button; //as -> jesli nie uda się sparsować to zwroci null a nie wyjątek

            text = b.Text;

            MailModel model = new MailModel();
            model.FromAddress = tbFrom.Text;
            model.SetMailTo(tbTo.Text);
            model.Subject = title.Text;
            model.Body = message.Text;
            MailService.Send(model);
       
        }



        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Jest ok";
            label2.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }


    }
}
