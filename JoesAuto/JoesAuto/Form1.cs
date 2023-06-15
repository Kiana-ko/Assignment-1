using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;
using System;

namespace JoesAuto
{
    public partial class Form1 : Form
    {

        decimal OilChange = 26.00m;
        decimal LubeJob = 18.00m;
        decimal RadiatorFlush = 30.00m;
        decimal TransmissionFlush = 80.00m;
        decimal Inspection = 15.00m;
        decimal MufflerReplacement = 100.00m;
        decimal TireRotation = 20.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal ChargeForOilChange()
        {
            decimal totalCharges = 0.0m;

            if (checkBox1.Checked)
                totalCharges += OilChange;

            return totalCharges;
        }



        private decimal ChargeForLube()
        {

            decimal totalCharges = 0.0m;

            if (checkBox2.Checked)
                totalCharges += LubeJob;

            return totalCharges;
        }

        private decimal ChargeForRadiatorFlush()
        {

            decimal totalCharges = 0.0m;

            if (checkBox3.Checked)
                totalCharges += RadiatorFlush;

            return totalCharges;
        }

        private decimal ChargeForTransmissionFlush()
        {
            decimal totalCharges = 0.0m;

            if (checkBox4.Checked)
                totalCharges += TransmissionFlush;

            return totalCharges;
        }

        private decimal ChargeForMuffler()
        {
            decimal totalCharges = 0.0m;

            if (checkBox6.Checked)
                totalCharges += MufflerReplacement;

            return totalCharges;
        }

        private decimal ChargeForTireRotation()
        {
            decimal totalCharges = 0.0m;

            if (checkBox4.Checked)
                totalCharges += TireRotation;
            return totalCharges;
        }

        private decimal ChargeForInspectetion()
        {
            decimal totalCharges = 0.0m;

            if (checkBox5.Checked)
                totalCharges += Inspection;

            return totalCharges;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Responsible for clearing the checkboxes:
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

            //Responsible for Clearing the textboxes:
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal oilChangeCharges = ChargeForOilChange();
            decimal lubeCharges = ChargeForLube();
            decimal radiatorFlushCharge = ChargeForRadiatorFlush();
            decimal transmitionFlushCharge = ChargeForTransmissionFlush();
            decimal mufflerCharge = ChargeForMuffler();
            decimal tireRotationCharge = ChargeForTireRotation();
            decimal tireInspectionCharge = ChargeForInspectetion();
            
            decimal totalCharges = oilChangeCharges + lubeCharges + radiatorFlushCharge +transmitionFlushCharge + mufflerCharge + tireRotationCharge;

            textBox3.Text = totalCharges.ToString("C");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}