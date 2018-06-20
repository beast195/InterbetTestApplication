using InterbetTestAppplication.ApplicationLogic.Models;
using InterbetTestAppplication.ApplicationLogic.Service.Interface;
using InterbetTestAppplication.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Unity;

namespace InterbetTestAppplication.WinForms
{
    public partial class PaymentImport : Form
    {
        private List<CorporatePayments> payments;

        public PaymentImport()
        {
            InitializeComponent();
            payments = new List<CorporatePayments>();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _container = DIHelper.BuildUnityContainer();
            using (var child = _container.CreateChildContainer())
            {
                var transService = child.Resolve<ITransactionService>();
                transService.AddPayments(payments);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Find payment transactions";
            ofd.Filter = "Text files|*.txt";
            ofd.InitialDirectory = @"C:\";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filenames = ofd.FileNames;

                foreach (var filename in filenames)
                {
                    payments.Add(Deserialize<CorporatePayments>(File.ReadAllText(filename)));
                }
            }
            label2.Show();
        }

        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}