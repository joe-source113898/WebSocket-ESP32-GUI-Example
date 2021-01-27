using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp;
using System.Windows.Forms;

namespace Ejemplo_GUI
{
    public partial class Form1 : Form
    {
        public Thread chartThread;
        private readonly WebSocket _client;
        const string host = "ws://192.168.4.1:81/";
        public int Pot_value_to_chart;
        public int PWM_value_to_chart;
        public bool connection = false;

        public class PWM
        {
            public int json { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            _client = new WebSocket(host);
            _client.OnOpen += (s, e) => txtEstatusConexion.AppendText("¡Conectado a " + host + " exitosamente!");
            _client.OnMessage += Ws_OnMessage;
            _client.OnError += Ws_OnError;
            _client.OnClose += (s, e) => txtEstatusConexion.AppendText("¡Desconectado de " + host + " exitosamente!");
        }

        private void Ws_OnError(object sender, ErrorEventArgs e)
        {
 
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.IsText)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    var dic = JObject.Parse(e.Data);
                    txtPotValue.Text = dic["json"].ToString();
                    Pot_value_to_chart = Convert.ToInt32(txtPotValue.Text);
                }));
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            txtEstatusConexion.Clear();
            _client.Connect();
            connection = true;
            chartThread = new Thread(chartDataSensorsUpdating);
            chartThread.Start();
        }

        public void chartDataSensorsUpdating()
        {
            while(true)
            {
                try
                {
                    if (connection)
                    {

                        chartDataSensors.Invoke((MethodInvoker)(() => chartDataSensors.Series["Pot"].Points.AddY(Pot_value_to_chart)));
                        chartDataSensors.Invoke((MethodInvoker)(() => chartDataSensors.Series["LED"].Points.AddY(PWM_value_to_chart)));
                    }
                    else
                    {
                        chartDataSensors.Invoke((MethodInvoker)(() => chartDataSensors.Series.Clear()));
                    }
                }
                catch(Exception ex)
                {
                    //Excepción
                }
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            txtEstatusConexion.Clear();
            _client.Close();
            connection = false;
            chartThread.Join();
        }

        private void tbPWM_Scroll(object sender, EventArgs e)
        {
            PWM_value_to_chart = tbPWM.Value;
            var pwm_value = new PWM
            {
                json = tbPWM.Value
            };
            string json_data_to_send = JsonConvert.SerializeObject(pwm_value);
            _client.Send(json_data_to_send);
        }
    }
}