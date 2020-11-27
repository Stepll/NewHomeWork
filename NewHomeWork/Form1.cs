using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace NewHomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string Data = reader.ReadToEnd();
            response.Close();

            dynamic d = JsonConvert.DeserializeObject(Data);
            label1.Text = d[0].exchangedate;
            string str = "";
            decimal UAN = 1, USD = 1, EUR = 1;
            for (int i = 1; i < 50; i++)
            {
                if (d[i].cc == "USD")
                {
                    str += d[i].cc + " " + d[i].rate + "    ";
                    USD = Convert.ToDecimal(d[i].rate);
                }
                if (d[i].cc == "EUR")
                {
                    str += d[i].cc + " " + d[i].rate + "    ";
                    EUR = Convert.ToDecimal(d[i].rate);
                }
            }
            label2.Text = str;
            UAN /= USD;
            EUR /= USD;

            label3.Text =  $"USD: UAN {Convert.ToString(Math.Round(UAN, 5))}    EUR {Convert.ToString(Math.Round(EUR, 5))}";

        }
    }
}
