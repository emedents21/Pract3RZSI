using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFforServer;
namespace Practice3LL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ITransferObject> factory = new ChannelFactory<ITransferObject>(clientBinding, address);
            var service = factory.CreateChannel();

            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);



            var sum = service.Calculate(x, y, b * Math.PI, a * Math.PI);
            label4.Text = sum.ToString();
        }
    }
}
