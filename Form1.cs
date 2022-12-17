using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Project
{
    public partial class Form1 : Form
    {
        //=======================================The Prices List=========================================================
        const double Price_fish = 20;
        const double Price_meat= 20;
        const double Price_3chicken= 20;
        const double Price_4 = 20;
        const double Price_5 = 20;
        const double Price_6 = 20;
        const double Price_7 = 20;
        const double Price_8 = 20;
        const double Price_9 = 20;
        const double Price_10 = 20;
        const double Price_11 = 20;
        const double Price_12 = 20;
        const double Price_13 = 20;
        const double Price_14 = 20;
        const double Price_15 = 20;
        const double Price_16 = 20;
        const double Price_17 = 20;
        const double Price_18 = 20;
        const double Price_19 = 20;
        const double Price_20 = 20;
        const double Price_21 = 20;
        const double Price_22 = 20;
        





        //
        double iTax, iSubTotal, iTotal;
        double Tax_Rate = 10;















        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text).ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //=================================================Exit Button code===================================================
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("confirm you wan to exist the system ","fast food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        //========================================================Reset text boxes================================
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
         

        }
        //======================================Enable Text Box=====================================================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);


        }
        //========================================Reset Check Boxes====================================
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);


        }


        //================================Reset Button Collection===================================

        private void Reset_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //============================================== CompoBox===================================
         if (comboBox1.Text== "Cash ")
            {
                textBox23.Enabled = true;
                textBox23.Text = "";
                textBox23.Focus();   

            }
            else
            {
                textBox23.Enabled = false;   
                textBox23.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();

        }
        /* 
          ============================================the code required to enable & disable text box by the checking box========================================

         if (checkBox1.Checked== true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();   

            }
            else
            {
                textBox1.Enabled = false;   
                textBox1.Text = "0";
            }
         
         */


        //======================check box1 =================================
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();   

            }
            else
            {
                textBox1.Enabled = false;   
                textBox1.Text = "0";
            }
        }
        //======================check box2 =================================
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }
        //======================check box3 =================================
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();

            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }
        //======================check box4 ============================================
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }
        //======================check box5 ============================================
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }
        //======================check box6 ============================================
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();

            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }
        //======================check box7 ============================================
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();

            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }
        //======================check box8 ============================================
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();

            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }
        //======================check box9 ============================================
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();

            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }
        //======================check box10  ============================================
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();

            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }
        //======================check box13 ============================================
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();

            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }
        //======================check box12 ============================================
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();

            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }
        //======================check box11 ============================================
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();

            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }
        
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
//======================check box14 ============================================
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();

            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }
        //======================check box15============================================
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();

            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }
        //======================check box16 ============================================
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();

            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }
        //======================check box17 ============================================
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();

            }
            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }
        //======================check box18 ============================================
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();

            }
            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }
        //======================check box5 ============================================
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();

            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }
        //======================check box20============================================
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();

            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //==================Total Click =====================
        private void Total_Click(object sender, EventArgs e)
        {
            double []itemcost = new double [23];
            itemcost [0] =Convert.ToDouble (textBox1.Text)* Price_fish;
            itemcost[1] = Convert.ToDouble(textBox2.Text) * Price_meat;
            itemcost[2] = Convert.ToDouble(textBox3.Text) * Price_chicken;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * Price_4;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * Price_5;
            itemcost[5] = Convert.ToDouble(textBox6.Text) * Price_6;
            itemcost[6] = Convert.ToDouble(textBox7.Text) * Price_7;
            itemcost[7] = Convert.ToDouble(textBox8.Text) * Price_8;
            itemcost[8] = Convert.ToDouble(textBox9.Text) * Price_9;
            itemcost[9] = Convert.ToDouble(textBox10.Text) * Price_10;
            itemcost[10] = Convert.ToDouble(textBox11.Text) * Price_11;
            itemcost[11] = Convert.ToDouble(textBox12.Text) * Price_12;
            itemcost[12] = Convert.ToDouble(textBox13.Text) * Price_13;
            itemcost[13] = Convert.ToDouble(textBox14.Text) * Price_14;
            itemcost[14] = Convert.ToDouble(textBox15.Text) * Price_15;
            itemcost[15] = Convert.ToDouble(textBox16.Text) * Price_16;
            itemcost[16] = Convert.ToDouble(textBox17.Text) * Price_17;
            itemcost[17] = Convert.ToDouble(textBox18.Text) * Price_18;
            itemcost[18] = Convert.ToDouble(textBox19.Text) * Price_19;
            itemcost[19] = Convert.ToDouble(textBox20.Text) * Price_20;
            itemcost[20] = Convert.ToDouble(textBox21.Text) * Price_21;
            itemcost[21] = Convert.ToDouble(textBox22.Text) * Price_22;
            







            double cost , ichange;
            if (comboBox1.Text== "Cash ")
            {
                iSubTotal = itemcost[0] + itemcost[1]
                    + itemcost[2]
                    + itemcost[3]
                    + itemcost[4]
                    + itemcost[5]
                    + itemcost[6]
                    + itemcost[7]
                    + itemcost[8]
                    + itemcost[9]
                    + itemcost[10]
                    + itemcost[11]
                    + itemcost[12]
                    + itemcost[13]
                    + itemcost[14]
                    + itemcost[15]
                    + itemcost[16]
                    + itemcost[17]
                    + itemcost[18]
                    + itemcost[19]
                    + itemcost[20]
                    + itemcost[21]
                    + itemcost[22]
                    + itemcost[23]
                    ;
                textBox26.Text= Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox25.Text= Convert.ToString(iTax);

                iTotal = (iSubTotal + iTax);

                textBox27.Text = Convert.ToString(iTotal);


                ichange=Convert.ToDouble(textBox23.Text);
                cost = ichange-(iTotal);
                textBox24.Text= Convert.ToString(cost);

            }
            else
            {

                iSubTotal = itemcost[0] + itemcost[1]
                   + itemcost[2]
                   + itemcost[3]
                   + itemcost[4]
                   + itemcost[5]
                   + itemcost[6]
                   + itemcost[7]
                   + itemcost[8]
                   + itemcost[9]
                   + itemcost[10]
                   + itemcost[11]
                   + itemcost[12]
                   + itemcost[13]
                   + itemcost[14]
                   + itemcost[15]
                   + itemcost[16]
                   + itemcost[17]
                   + itemcost[18]
                   + itemcost[19]
                   + itemcost[20]
                   + itemcost[21]
                   + itemcost[22]
                   + itemcost[23]
                   ;
                textBox26.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox25.Text = Convert.ToString(iTax);

                iTotal = (iSubTotal + iTax);

                textBox27.Text = Convert.ToString(iTotal);


                
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }
        //=============================================================demo for tax =======================
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }
        //==================================demo isubtotal check box /////////////////////////
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        //======================check box21 ============================================
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();

            }
            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }
        //======================check box22 ============================================
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();

            }
            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }
    }
}
