using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace NASA_Life_Support_System
{


    public partial class Form1 : Form
    {
        NitrogenMonitor nMonitor;
        CarbonMonoxideMonitor cMonitor;
        OxygenMonitor oMonitor;
        Sensor nSensor, cSensor, oSensor;
        Boolean dialogOpen = false;
        double totalPressure;
        Boolean lowPower = false;


        public Form1()
        {
            InitializeComponent();

            string messageBoxText = "Do you want to save changes?";
            string caption = "Word Processor";

            nMonitor = new NitrogenMonitor();           
            cMonitor = new CarbonMonoxideMonitor();
            oMonitor = new OxygenMonitor();

            nSensor = new Sensor(11.5, 0.05, nMonitor.getMin(), nMonitor.getMax());
            cSensor = new Sensor(0.10, 0.001, cMonitor.getMin(), cMonitor.getMax());
            oSensor = new Sensor(2.9, 0.1, oMonitor.getMin(), oMonitor.getMax());

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cMain.Text = cMonitor.getMainName();
            cBackup.Text = cMonitor.getBackupName();

            nMain.Text = nMonitor.getMainName();
            nBackup.Text = nMonitor.getBackupName();

            oMain.Text = oMonitor.getMainName();
            oBackup.Text = oMonitor.getBackupName();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            nMonitor.update(nSensor);
            cMonitor.update(cSensor);
            oMonitor.update(oSensor);

            nSensor.update(nMonitor);
            cSensor.update(cMonitor);
            oSensor.update(oMonitor);

            totalPressure = nMonitor.getCurrentSensorValue() + cMonitor.getCurrentSensorValue() + oMonitor.getCurrentSensorValue();

            nValue.Text = Math.Round(nSensor.getValue(), 2).ToString();
            nAvgVal.Text = Math.Round(nMonitor.getAverageValue(), 2).ToString();
            nState.Text = nMonitor.getState();

            cValue.Text = cSensor.getValue().ToString();
            cAvgVal.Text = cMonitor.getAverageValue().ToString();
            cState.Text = cMonitor.getState();

            oValue.Text = Math.Round(oSensor.getValue(), 2).ToString();
            oAvgVal.Text = Math.Round(oMonitor.getAverageValue(), 2).ToString();
            oState.Text = oMonitor.getState();
            pressureVal.Text = totalPressure.ToString();

            if (oState.Text == "emergency" || cState.Text == "emergency" || nState.Text == "emergency")
            {
                alert(nMonitor, cMonitor, oMonitor);        // Emergency Dialog

            }

            if (lowPower == true)
            {
                nState.Text = "Low Power";
                oState.Text = "Low Power";
            }

            if (cMonitor.getState() == "heightened")
            {
                cState.BackColor = Color.Yellow;
                cBackup.BackColor = Color.PaleGreen;
                cMain.BackColor = Color.PaleGreen;
            }
            else
            {
                cState.BackColor = Color.Transparent;
                cBackup.BackColor = Color.Transparent;
                cMain.BackColor = Color.PaleGreen;
            }

            if (nMonitor.getState() == "heightened")
            {

                nState.BackColor = Color.Yellow;
                nBackup.BackColor = Color.PaleGreen;
                nMain.BackColor = Color.PaleGreen;
            }
            else
            {
                nState.BackColor = Color.Transparent;
                nBackup.BackColor = Color.Transparent;
                nMain.BackColor = Color.PaleGreen;
            }

            if (oMonitor.getState() == "heightened")
            {
                oState.BackColor = Color.Yellow;
                oBackup.BackColor = Color.PaleGreen;
                oMain.BackColor = Color.PaleGreen;
            }
            else
            {
                oState.BackColor = Color.Transparent;
                oBackup.BackColor = Color.Transparent;
                oMain.BackColor = Color.PaleGreen;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oSensor.setValue(Convert.ToDouble(textO.Text));
            nSensor.setValue(Convert.ToDouble(textN.Text));
            cSensor.setValue(Convert.ToDouble(textC.Text));
        }



        private void alert(Monitor n, Monitor c, Monitor o){

            List<Monitor> mons = new List<Monitor>();

            if(n.getState() == "emergency"){
                mons.Add(n);
            }
            if(c.getState() == "emergency"){
                mons.Add(c);
            }
            if(o.getState() == "emergency"){
                mons.Add(o);
            }

            String error=mons[0].returnName();
            String amount = " is";
            for (int i = 1; i < mons.Count(); i++)
            {
                error = error +" and "+ mons[i].returnName();
                amount = " are";
            }



                if (dialogOpen == false)
                {
                    dialogOpen = true;
                    DialogResult dialogResult = MessageBox.Show(error + amount + " in Emergency State.\n Has the issue been solved?", "Critical Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (n.getState() == "emergency")
                        {
                            nSensor.setValue(11.2);
                            n.init();
                        }
                        if (c.getState() == "emergency")
                        {
                            cSensor.setValue(0.1);
                            c.init();
                        }
                        if (o.getState() == "emergency")
                        {
                            oSensor.setValue(3.2);
                            o.init();
                        }

                        dialogOpen = false;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        dialogOpen = false;
                    }
                }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                nMonitor.setTargetLevel(Convert.ToDouble(nTarget.Text));
            }
            catch
            {
                nTarget.Text = "INVALID";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cMonitor.setTargetLevel(Convert.ToDouble(cTarget.Text));
            }
            catch
            {
                cTarget.Text = "INVALID";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                oMonitor.setTargetLevel(Convert.ToDouble(oTarget.Text));
            }
            catch 
            {
                oTarget.Text = "INVALID";
            }


        }

        private void lpState_CheckedChanged(object sender, EventArgs e)
        {
            if (lpState.Checked == true)
            {

                nMonitor.setLowPower();
                oMonitor.setLowPower();
                cMonitor.setLowPower();

                nSensor.setMinAvgValue(nMonitor.getMin());
                cSensor.setMinAvgValue(cMonitor.getMin());
                oSensor.setMinAvgValue(oMonitor.getMin());

                nSensor.setMaxAvgValue(nMonitor.getMax());
                cSensor.setMaxAvgValue(cMonitor.getMax());
                oSensor.setMaxAvgValue(oMonitor.getMax());

                lowPower = true;
            }

            else
            {
                nMonitor.init();
                oMonitor.init();
                cMonitor.init();

                nMonitor.overrideState("heightened");
                oMonitor.overrideState("heightened");
                nSensor.setMinAvgValue(nMonitor.getMin());
                cSensor.setMinAvgValue(cMonitor.getMin());
                oSensor.setMinAvgValue(oMonitor.getMin());

                nSensor.setMaxAvgValue(nMonitor.getMax());
                cSensor.setMaxAvgValue(cMonitor.getMax());
                oSensor.setMaxAvgValue(oMonitor.getMax());

                lowPower = false;
            }
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            cMonitor.init();
            nMonitor.init();
            oMonitor.init();
        }

        private void nTarget_Enter(object sender, EventArgs e)
        {
            nTarget.Text = "";
        }

        private void cTarget_Enter(object sender, EventArgs e)
        {
            cTarget.Text = "";
        }

        private void oTarget_Enter(object sender, EventArgs e)
        {
            oTarget.Text = "";
        }
    }
}
