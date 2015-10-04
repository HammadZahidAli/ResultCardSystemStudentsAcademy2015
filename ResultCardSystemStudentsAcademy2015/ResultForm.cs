using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ResultCardSystemStudentsAcademy2015
{
    public partial class BySoftFort : Form
    {

        float term1Total = 0;
        float term2Total = 0;
        float term3Total = 0;

        float term1Marks = 0;
        float term2Marks = 0;
        float term3Marks = 0;
 


        public BySoftFort()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
  
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                comboBox100.Hide();
                comboBox102.Hide();
                comboBox104.Hide();
                comboBox106.Hide();
                comboBox108.Hide();
                comboBox110.Hide();
                comboBox112.Hide();
                comboBox114.Hide();
                comboBox116.Hide();
                comboBox118.Hide();
                comboBox120.Hide();
                comboBox122.Hide();
                comboBox124.Hide();


                comboBox101.Hide();
                comboBox103.Hide();
                comboBox105.Hide();
                comboBox107.Hide();
                comboBox109.Hide();
                comboBox111.Hide();
                comboBox113.Hide();
                comboBox115.Hide();
                comboBox117.Hide();
                comboBox119.Hide();
                comboBox121.Hide();
                comboBox123.Hide();
                comboBox125.Hide();
            }
            else
            {
                comboBox100.Show();
                comboBox102.Show();
                comboBox104.Show();
                comboBox106.Show();
                comboBox108.Show();
                comboBox110.Show();
                comboBox112.Show();
                comboBox114.Show();
                comboBox116.Show();
                comboBox118.Show();
                comboBox120.Show();
                comboBox122.Show();
                comboBox124.Show();


                comboBox101.Show();
                comboBox103.Show();
                comboBox105.Show();
                comboBox107.Show();
                comboBox109.Show();
                comboBox111.Show();
                comboBox113.Show();
                comboBox115.Show();
                comboBox117.Show();
                comboBox119.Show();
                comboBox121.Show();
                comboBox123.Show();
                comboBox125.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                comboBox200.Hide();
                comboBox202.Hide();
                comboBox204.Hide();
                comboBox206.Hide();
                comboBox208.Hide();
                comboBox210.Hide();
                comboBox212.Hide();
                comboBox214.Hide();
                comboBox216.Hide();
                comboBox218.Hide();
                comboBox220.Hide();
                comboBox222.Hide();
                comboBox224.Hide();


                comboBox201.Hide();
                comboBox203.Hide();
                comboBox205.Hide();
                comboBox207.Hide();
                comboBox209.Hide();
                comboBox211.Hide();
                comboBox213.Hide();
                comboBox215.Hide();
                comboBox217.Hide();
                comboBox219.Hide();
                comboBox221.Hide();
                comboBox223.Hide();
                comboBox225.Hide();
            }
            else
            {
                comboBox200.Show();
                comboBox202.Show();
                comboBox204.Show();
                comboBox206.Show();
                comboBox208.Show();
                comboBox210.Show();
                comboBox212.Show();
                comboBox214.Show();
                comboBox216.Show();
                comboBox218.Show();
                comboBox220.Show();
                comboBox222.Show();
                comboBox224.Show();


                comboBox201.Show();
                comboBox203.Show();
                comboBox205.Show();
                comboBox207.Show();
                comboBox209.Show();
                comboBox211.Show();
                comboBox213.Show();
                comboBox215.Show();
                comboBox217.Show();
                comboBox219.Show();
                comboBox221.Show();
                comboBox223.Show();
                comboBox225.Show();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox300.Hide();
                comboBox302.Hide();
                comboBox304.Hide();
                comboBox306.Hide();
                comboBox308.Hide();
                comboBox310.Hide();
                comboBox312.Hide();
                comboBox314.Hide();
                comboBox316.Hide();
                comboBox318.Hide();
                comboBox320.Hide();
                comboBox322.Hide();
                comboBox324.Hide();


                comboBox301.Hide();
                comboBox303.Hide();
                comboBox305.Hide();
                comboBox307.Hide();
                comboBox309.Hide();
                comboBox311.Hide();
                comboBox313.Hide();
                comboBox315.Hide();
                comboBox317.Hide();
                comboBox319.Hide();
                comboBox321.Hide();
                comboBox323.Hide();
                comboBox325.Hide();
            }
            else
            {
                comboBox300.Show();
                comboBox302.Show();
                comboBox304.Show();
                comboBox306.Show();
                comboBox308.Show();
                comboBox310.Show();
                comboBox312.Show();
                comboBox314.Show();
                comboBox316.Show();
                comboBox318.Show();
                comboBox320.Show();
                comboBox322.Show();
                comboBox324.Show();


                comboBox301.Show();
                comboBox303.Show();
                comboBox305.Show();
                comboBox307.Show();
                comboBox309.Show();
                comboBox311.Show();
                comboBox313.Show();
                comboBox315.Show();
                comboBox317.Show();
                comboBox319.Show();
                comboBox321.Show();
                comboBox323.Show();
                comboBox325.Show();
            }
        }

        private void comboBox100_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }


        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //float cash = float.Parse(textBox4.Text.ToString());
            // float change = 0.00f;

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Times New Roman", 10); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            //graphic.DrawString(" KIDS GARDENIA SCHOOL \n", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            // string top = "Item Name".PadRight(30) + "Price";
            //graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent

            // graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            //graphic.DrawString("".PadLeft(10) + "Name".PadRight(5) + comboBox1.Text.PadRight(20) + " Class".PadRight(10) + comboBox2.Text + "\n" +
            //                  "".PadLeft(10) + "Roll No.".PadRight(10) + comboBox3.Text.PadRight(20) + "Attendance".PadRight(10) + comboBox4.Text + "\n" +
            //                  "".PadLeft(10) + "Position".PadRight(10) + comboBox5.Text.PadRight(20) + "Session".PadRight(10) + comboBox6.Text + "\n\n"
            //   , new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX, startY + offset);

            //left side
            graphic.DrawString("".PadLeft(10) + "Name: ".PadRight(5) + comboBox1.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Class: ".PadRight(5) + comboBox2.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX + 300, startY + offset);

            offset = offset + FontHeight;
            graphic.DrawString("".PadLeft(10) + "RollNO.".PadRight(5) + comboBox3.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Attendance: ".PadRight(5) + comboBox4.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX + 300, startY + offset);

            offset = offset + FontHeight;
            graphic.DrawString("".PadLeft(10) + "Position: ".PadRight(5) + comboBox3.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Session: ".PadRight(5) + comboBox6.Text, new Font("Times New Roman", 12), new SolidBrush(Color.Black), startX + 300, startY + offset);



            offset = offset + (int)fontHeight + 10; //make the spacing consistent
            // Marks
            offset = offset + 40;

            string subj = "".PadLeft(3) + "Subjects".PadRight(13);

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                subj = "".PadLeft(14) + "Subjects".PadRight(13);

            string top1 = "", top2 = "", top3 = "", top4 = "", top5 = "", top6 = "";
            if (!checkBox1.Checked)
            {
                top1 = "1st Term".PadRight(10);
                top2 = "Obt.Marks".PadRight(12);
            }
            if (!checkBox2.Checked)
            {
                top3 = "2nd Term".PadRight(10);
                top4 = "Obt.Marks".PadRight(12);
            }
            if (!checkBox3.Checked)
            {
                top5 = "3rd Term".PadRight(10);
                top6 = "Obt.Marks".PadRight(15);
            }
                

            //graphic.DrawString(subj+top1+top2+top3, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(subj, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(top1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
            graphic.DrawString(top2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
            graphic.DrawString(top3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
            graphic.DrawString(top4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
            graphic.DrawString(top5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
            graphic.DrawString(top6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);


            //list of subjects
            //offset = offset + 40;
            string sb1="",sb2="",sb3="",sb4="", sb5="",sb6="",sb7="",sb8="", sb9="", sb10="",sb11="",sb12="", sb13 = "";
            string r1="", r2="", r3="", r4="", r5="", r6="";

            if (comboBox8.Text != "" )// )//comboBox8.Text != null)
            {
                sb1 = "".PadLeft(3) + comboBox8.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if(checkBox2.Checked || checkBox3.Checked)
                        sb1 = "".PadLeft(14) + comboBox8.Text.PadRight(13);

                    r1 = comboBox100.Text.PadRight(10);
                    r2 = comboBox101.Text.PadRight(12);

                    term1Total += float.Parse(comboBox100.Text); 
                    term1Marks += float.Parse(comboBox101.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb1 = "".PadLeft(14) + comboBox8.Text.PadRight(13);

                    r3 = (comboBox200.Text).PadRight(10);
                    r4 = (comboBox201.Text).PadRight(12);

                    term2Total += float.Parse(comboBox200.Text); ;
                    term2Marks += float.Parse(comboBox201.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb1 = "".PadLeft(14) + comboBox8.Text.PadRight(13);

                    r5 = (comboBox300.Text).PadRight(10);
                    r6 = (comboBox301.Text).PadRight(12);

                    term3Total += float.Parse(comboBox300.Text); ;
                    term3Marks += float.Parse(comboBox301.Text); ;
                }
                offset += 40;
               // graphic.DrawString(sb1 + r1 +r2+ r3 + r4 + r5+ r6+"\n" , font, new SolidBrush(Color.Black), startX, startY + offset);

                graphic.DrawString(sb1 , font, new SolidBrush(Color.Black), startX , startY + offset);
                graphic.DrawString(r1 , font, new SolidBrush(Color.Black), startX+100 , startY + offset);
                graphic.DrawString(r2 , font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3 , font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4 , font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5 , font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6 , font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }

            if (comboBox9.Text != "" ) //comboBox9.Text != null)
            {
                sb2 = "".PadLeft(3) + comboBox9.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb2 = "".PadLeft(14) + comboBox9.Text.PadRight(13);

                    r1 = comboBox102.Text.PadRight(10);
                    r2 = comboBox103.Text.PadRight(12);

                    term1Total += float.Parse(comboBox102.Text);
                    term1Marks += float.Parse(comboBox103.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb2 = "".PadLeft(14) + comboBox9.Text.PadRight(13);

                    r3 = (comboBox202.Text).PadRight(10);
                    r4 = (comboBox203.Text).PadRight(12);

                    term2Total += float.Parse(comboBox202.Text); ;
                    term2Marks += float.Parse(comboBox203.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                        sb2 = "".PadLeft(14) + comboBox9.Text.PadRight(13);

                    r5 = (comboBox302.Text).PadRight(10);
                    r6 = (comboBox303.Text).PadRight(12);

                    term3Total += float.Parse(comboBox302.Text); ;
                    term3Marks += float.Parse(comboBox303.Text); ;
                }
                offset += 40;
                // graphic.DrawString(sb2 + r1 + r2 + r3 + r4 + r5 + r6 +"\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb2, font, new SolidBrush(Color.Black), startX , startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox10.Text != "" )//|| comboBox10.Text != null)
            {
                sb3 = "".PadLeft(3) + comboBox10.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb3 = "".PadLeft(14) + comboBox10.Text.PadRight(13);

                    r1 = comboBox104.Text.PadRight(10);
                    r2 = comboBox105.Text.PadRight(12);

                    term1Total += float.Parse(comboBox104.Text);
                    term1Marks += float.Parse(comboBox105.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb3 = "".PadLeft(14) + comboBox10.Text.PadRight(13);

                    r3 = (comboBox204.Text).PadRight(10);
                    r4 = (comboBox205.Text).PadRight(12);

                    term2Total += float.Parse(comboBox204.Text); ;
                    term2Marks += float.Parse(comboBox205.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb3 = "".PadLeft(14) + comboBox10.Text.PadRight(13);

                    r5 = (comboBox304.Text).PadRight(10);
                    r6 = (comboBox305.Text).PadRight(12);

                    term3Total += float.Parse(comboBox304.Text); ;
                    term3Marks += float.Parse(comboBox305.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb3+ r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb3, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox11.Text != "" )//|| comboBox11.Text != null)
            {
                sb4 = "".PadLeft(3) + comboBox11.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb4 = "".PadLeft(14) + comboBox11.Text.PadRight(13);

                    r1 = comboBox106.Text.PadRight(10);
                    r2 = comboBox107.Text.PadRight(12);

                    term1Total += float.Parse(comboBox106.Text);
                    term1Marks += float.Parse(comboBox107.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb4 = "".PadLeft(14) + comboBox11.Text.PadRight(13);

                    r3 = (comboBox206.Text).PadRight(10);
                    r4 = (comboBox207.Text).PadRight(12);

                    term2Total += float.Parse(comboBox206.Text); ;
                    term2Marks += float.Parse(comboBox207.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb4 = "".PadLeft(14) + comboBox11.Text.PadRight(13);

                    r5 = (comboBox306.Text).PadRight(10);
                    r6 = (comboBox307.Text).PadRight(12);

                    term3Total += float.Parse(comboBox306.Text); ;
                    term3Marks += float.Parse(comboBox307.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb4+ r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb4, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox12.Text != "" )//||  comboBox12.Text != null)
            {
                sb5 = "".PadLeft(3) + comboBox12.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb5 = "".PadLeft(14) + comboBox12.Text.PadRight(13);

                    r1 = comboBox108.Text.PadRight(10);
                    r2 = comboBox109.Text.PadRight(12);

                    term1Total += float.Parse(comboBox108.Text);
                    term1Marks += float.Parse(comboBox109.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox3.Checked || checkBox1.Checked)
                        sb5 = "".PadLeft(14) + comboBox12.Text.PadRight(13);

                    r3 = (comboBox208.Text).PadRight(10);
                    r4 = (comboBox209.Text).PadRight(12);

                    term2Total += float.Parse(comboBox208.Text); ;
                    term2Marks += float.Parse(comboBox209.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb5 = "".PadLeft(14) + comboBox12.Text.PadRight(13);

                    r5 = (comboBox308.Text).PadRight(10);
                    r6 = (comboBox309.Text).PadRight(12);

                    term3Total += float.Parse(comboBox308.Text); ;
                    term3Marks += float.Parse(comboBox309.Text); ;
                }
                offset += 40;
                // graphic.DrawString(sb5 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb5, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox13.Text != "" )//|| comboBox13.Text != null )
            {
                sb6 = "".PadLeft(3) + comboBox13.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb6 = "".PadLeft(14) + comboBox13.Text.PadRight(13);

                    r1 = comboBox110.Text.PadRight(10);
                    r2 = comboBox111.Text.PadRight(12);

                    term1Total += float.Parse(comboBox110.Text);
                    term1Marks += float.Parse(comboBox111.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb6 = "".PadLeft(14) + comboBox13.Text.PadRight(13);

                    r3 = (comboBox210.Text).PadRight(10);
                    r4 = (comboBox211.Text).PadRight(12);

                    term2Total += float.Parse(comboBox210.Text); ;
                    term2Marks += float.Parse(comboBox211.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb6 = "".PadLeft(14) + comboBox13.Text.PadRight(13);

                    r5 = (comboBox310.Text).PadRight(10);
                    r6 = (comboBox311.Text).PadRight(12);

                    term3Total += float.Parse(comboBox310.Text); ;
                    term3Marks += float.Parse(comboBox311.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb6 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb6, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox14.Text != "" )//|| comboBox14.Text != null)
            {
                sb7 = "".PadLeft(3) + comboBox14.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb7 = "".PadLeft(14) + comboBox14.Text.PadRight(13);

                    r1 = comboBox112.Text.PadRight(10);
                    r2 = comboBox113.Text.PadRight(12);

                    term1Total += float.Parse(comboBox112.Text);
                    term1Marks += float.Parse(comboBox113.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb7 = "".PadLeft(14) + comboBox14.Text.PadRight(13);

                    r3 = (comboBox212.Text).PadRight(10);
                    r4 = (comboBox213.Text).PadRight(12);

                    term2Total += float.Parse(comboBox212.Text); ;
                    term2Marks += float.Parse(comboBox213.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb7 = "".PadLeft(14) + comboBox14.Text.PadRight(13);

                    r5 = (comboBox312.Text).PadRight(10);
                    r6 = (comboBox313.Text).PadRight(12);

                    term3Total += float.Parse(comboBox312.Text); ;
                    term3Marks += float.Parse(comboBox313.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb7 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb7, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox15.Text != "" )//||  comboBox15.Text != null)
            {
                sb8 = "".PadLeft(3) + comboBox15.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb8 = "".PadLeft(14) + comboBox15.Text.PadRight(13);

                    r1 = comboBox114.Text.PadRight(10);
                    r2 = comboBox115.Text.PadRight(12);

                    term1Total += float.Parse(comboBox114.Text);
                    term1Marks += float.Parse(comboBox115.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb8 = "".PadLeft(14) + comboBox15.Text.PadRight(13);

                    r3 = (comboBox214.Text).PadRight(10);
                    r4 = (comboBox215.Text).PadRight(12);

                    term2Total += float.Parse(comboBox214.Text); ;
                    term2Marks += float.Parse(comboBox215.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb8 = "".PadLeft(14) + comboBox15.Text.PadRight(13);

                    r5 = (comboBox314.Text).PadRight(10);
                    r6 = (comboBox315.Text).PadRight(12);

                    term3Total += float.Parse(comboBox314.Text); ;
                    term3Marks += float.Parse(comboBox315.Text); ;
                }
                offset += 40;
                // graphic.DrawString(sb8 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(sb8, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox16.Text != "" )//||  comboBox16.Text != null)
            {
                sb9 = "".PadLeft(3) + comboBox16.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb9 = "".PadLeft(14) + comboBox16.Text.PadRight(13);

                    r1 = comboBox116.Text.PadRight(10);
                    r2 = comboBox117.Text.PadRight(12);

                    term1Total += float.Parse(comboBox116.Text);
                    term1Marks += float.Parse(comboBox117.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb9 = "".PadLeft(14) + comboBox16.Text.PadRight(13);

                    r3 = (comboBox216.Text).PadRight(10);
                    r4 = (comboBox217.Text).PadRight(12);

                    term2Total += float.Parse(comboBox216.Text); ;
                    term2Marks += float.Parse(comboBox217.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb9 = "".PadLeft(14) + comboBox16.Text.PadRight(13);

                    r5 = (comboBox316.Text).PadRight(10);
                    r6 = (comboBox317.Text).PadRight(12);

                    term3Total += float.Parse(comboBox316.Text); ;
                    term3Marks += float.Parse(comboBox317.Text); ;
                }
                offset += 40;
                // graphic.DrawString(sb9 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb9, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox17.Text != "" )//||  comboBox17.Text != null)
            {
                sb10 = "".PadLeft(3) + comboBox17.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb10 = "".PadLeft(14) + comboBox17.Text.PadRight(13);

                    r1 = comboBox118.Text.PadRight(10);
                    r2 = comboBox119.Text.PadRight(12);

                    term1Total += float.Parse(comboBox118.Text);
                    term1Marks += float.Parse(comboBox119.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb10 = "".PadLeft(14) + comboBox17.Text.PadRight(13);

                    r3 = (comboBox218.Text).PadRight(10);
                    r4 = (comboBox219.Text).PadRight(12);

                    term2Total += float.Parse(comboBox218.Text); ;
                    term2Marks += float.Parse(comboBox219.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb10 = "".PadLeft(14) + comboBox17.Text.PadRight(13);

                    r5 = (comboBox318.Text).PadRight(10);
                    r6 = (comboBox319.Text).PadRight(12);

                    term3Total += float.Parse(comboBox318.Text); ;
                    term3Marks += float.Parse(comboBox319.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb10 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb10, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox18.Text != "" )//|| comboBox18.Text != null)
            {
                sb11 = "".PadLeft(3) + comboBox18.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb11 = "".PadLeft(14) + comboBox18.Text.PadRight(13);

                    r1 = comboBox120.Text.PadRight(10);
                    r2 = comboBox121.Text.PadRight(12);

                    term1Total += float.Parse(comboBox120.Text);
                    term1Marks += float.Parse(comboBox121.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb11 = "".PadLeft(14) + comboBox18.Text.PadRight(13);

                    r3 = (comboBox220.Text).PadRight(10);
                    r4 = (comboBox221.Text).PadRight(12);

                    term2Total += float.Parse(comboBox220.Text); ;
                    term2Marks += float.Parse(comboBox221.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb11 = "".PadLeft(14) + comboBox18.Text.PadRight(13);

                    r5 = (comboBox320.Text).PadRight(10);
                    r6 = (comboBox321.Text).PadRight(12);

                    term3Total += float.Parse(comboBox320.Text); ;
                    term3Marks += float.Parse(comboBox321.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb11 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb11, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox19.Text != "" )//|| comboBox19.Text != null)
            {
                sb12 = "".PadLeft(3) + comboBox19.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb12 = "".PadLeft(14) + comboBox19.Text.PadRight(13);

                    r1 = comboBox122.Text.PadRight(10);
                    r2 = comboBox123.Text.PadRight(12);

                    term1Total += float.Parse(comboBox122.Text);
                    term1Marks += float.Parse(comboBox123.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb12 = "".PadLeft(14) + comboBox19.Text.PadRight(13);

                    r3 = (comboBox222.Text).PadRight(10);
                    r4 = (comboBox223.Text).PadRight(12);

                    term2Total += float.Parse(comboBox222.Text); ;
                    term2Marks += float.Parse(comboBox223.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                        sb12 = "".PadLeft(14) + comboBox19.Text.PadRight(13);

                    r5 = (comboBox322.Text).PadRight(10);
                    r6 = (comboBox323.Text).PadRight(12);

                    term3Total += float.Parse(comboBox322.Text); ;
                    term3Marks += float.Parse(comboBox323.Text); ;
                }
                offset += 40;
                //graphic.DrawString(sb12 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY + offset );
                graphic.DrawString(sb12, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }
            if (comboBox20.Text != "" )//|| comboBox20.Text != null)
            {
                sb13 = "".PadLeft(3) + comboBox20.Text.PadRight(13);
                if (!checkBox1.Checked)
                {
                    if (checkBox2.Checked || checkBox3.Checked)
                        sb13 = "".PadLeft(14) + comboBox20.Text.PadRight(13);

                    r1 = comboBox124.Text.PadRight(10);
                    r2 = comboBox125.Text.PadRight(12);

                    term1Total += float.Parse(comboBox124.Text);
                    term1Marks += float.Parse(comboBox125.Text);
                }
                if (!checkBox2.Checked)
                {
                    if (checkBox1.Checked || checkBox3.Checked)
                        sb13 = "".PadLeft(14) + comboBox20.Text.PadRight(13);

                    r3 = (comboBox224.Text).PadRight(10);
                    r4 = (comboBox225.Text).PadRight(12);

                    term2Total += float.Parse(comboBox224.Text); ;
                    term2Marks += float.Parse(comboBox225.Text); ;
                }
                if (!checkBox3.Checked)
                {
                    if (checkBox2.Checked || checkBox1.Checked)
                        sb13 = "".PadLeft(14) + comboBox20.Text.PadRight(13);

                    r5 = (comboBox324.Text).PadRight(10);
                    r6 = (comboBox325.Text).PadRight(12);

                    term3Total += float.Parse(comboBox324.Text); ;
                    term3Marks += float.Parse(comboBox325.Text); ;
                }
                offset += 40;
                // graphic.DrawString(sb13 + r1 + r2 + r3 + r4 + r5 + r6 + "\n", font, new SolidBrush(Color.Black), startX, startY );
                graphic.DrawString(sb13, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(r1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
                graphic.DrawString(r2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(r3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
                graphic.DrawString(r4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
                graphic.DrawString(r5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
                graphic.DrawString(r6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);
            }

            label28.Text = term1Total.ToString();
            label29.Text = term1Marks.ToString();
            label30.Text = term2Total.ToString();
            label31.Text = term2Marks.ToString();
            label32.Text = term2Total.ToString();
            label33.Text = term3Marks.ToString();



            offset += 40;
            string marks = "".PadLeft(3) + "Total:".PadRight(13);
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                marks = "".PadLeft(14) + "Total:".PadRight(13);

            string m1 = "", m2 = "", m3 = "", m4 = "", m5 = "", m6 = "";
            if (!checkBox1.Checked)
            {
                m1 = term1Total.ToString().PadRight(10);
                m2 = term1Marks.ToString().PadRight(12);
            }
            if (!checkBox2.Checked)
            {
                m3 = term2Total.ToString().PadRight(10);
                m4 = term2Marks.ToString().PadRight(12);
            }
            if (!checkBox3.Checked)
            {
                m5 = term3Total.ToString().PadRight(10);
                m6 = term3Marks.ToString().PadRight(15);
            }
                

            //graphic.DrawString(marks + m1 + m2 + m3, font, new SolidBrush(Color.Black), startX, startY + offset);

            graphic.DrawString(marks, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(m1, font, new SolidBrush(Color.Black), startX + 100, startY + offset);
            graphic.DrawString(m2, font, new SolidBrush(Color.Black), startX + 200, startY + offset);
            graphic.DrawString(m3, font, new SolidBrush(Color.Black), startX + 300, startY + offset);
            graphic.DrawString(m4, font, new SolidBrush(Color.Black), startX + 400, startY + offset);
            graphic.DrawString(m5, font, new SolidBrush(Color.Black), startX + 500, startY + offset);
            graphic.DrawString(m6, font, new SolidBrush(Color.Black), startX + 600, startY + offset);



        }

    }

}
    

