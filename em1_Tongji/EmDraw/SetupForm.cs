using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//copy right EM Earth Consulting 2012
namespace EmDraw
{
    public partial class setupForm : Form
    {
        public setupForm()
        {
            InitializeComponent();
            readDefPara();
        }

       public static int ijk;
       public static int fnr;
       public static int trange;
       public static double yratio;
       public static string filename;
       public static string fname;
       public static string fname1;
       public static string depS;



        void readDefPara()
        {
            //read default parameter to textBox and checkbutton
            StreamReader rf = new StreamReader( "para.lis");
            //StreamReader rf = new StreamReader(mainForm.currenDir + "para.lis");
            this.textBoxFN.Text = rf.ReadLine();
            this.textBoxStartF.Text = rf.ReadLine();
            this.textBoxStopF.Text = rf.ReadLine();
            string ifdef = rf.ReadLine();
            this.textBoxFile.Text = rf.ReadLine();

        /*    while (ifdef = "300") { this.radioButtonIF1.Checked = true; }
            while (ifdef ="1000") this.radioButtonIF2.Checked;
            if (ifdef = "3000") this.radioButtonIF3.Checked;
            string cndef = rf.ReadLine();
            if (cndef = "s11") this.radioButtonTC1.Checked;
            if (cndef = "s21") this.radioButtonTC2.Checked; */
            this.textBoxFile.Text = rf.ReadLine();
            this.textBox1.Text = rf.ReadLine();
            rf.Close();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            // Start parameter settings.
            string startTime = "Start Time:" + DateTime.Now;
           
            string fn = this.textBoxFN.Text;
            string startF = this.textBoxStartF.Text;
            string stopF = this.textBoxStopF.Text;
            string cableL = this.textBox1.Text;

           string fnum = ":SENS:SWE:POIN " + this.textBoxFN.Text;
           string startFrequncy = ":SENS:FREQ:STAR " + this.textBoxStartF.Text;
           string stopFrequncy = ":SENS:FREQ:STOP " + this.textBoxStopF.Text;

            string ifbw1 = "300";
            string ifbw2 = "1000";
            string ifbw3 = "3000";
            // string ifbw = "IF Band Width:";
            string ifbw = ":SENS:BWID ";
            string ifdef = "";
            if (this.radioButtonIF1.Checked)
            {
                ifbw = ifbw + ifbw1;
                ifdef = "300";
            }
            if (this.radioButtonIF2.Checked)
            {
                ifbw = ifbw + ifbw2;
                ifdef = "1000";
            }
            if (this.radioButtonIF3.Checked)
            {
                ifbw = ifbw + ifbw3;
                ifdef = "3000";
            }

            string tchl1 = "S11";
            string tchl2 = "S21";
            // string tchl = "Test Channel:";
            string tchl = ":CALC:PAR:DEF ";
            string tcdef = "";
            if (this.radioButtonTC1.Checked)
            {
                tchl = tchl + tchl1;
                tcdef = tchl1;
            }
            if (this.radioButtonTC2.Checked)
            {
                tchl = tchl + tchl2;
                tcdef = tchl2;
            }
            fname = textBoxFile.Text;
            TextWriter tw = new StreamWriter("para.lis");
            //TextWriter tw = new StreamWriter(mainForm.currenDir + "para.lis");
            tw.WriteLine(fn);
            tw.WriteLine(startF);
            tw.WriteLine(stopF);
            tw.WriteLine(ifdef);
            tw.WriteLine(tcdef);
            tw.WriteLine(fname);
            tw.WriteLine(cableL);
            tw.Close();

            fname1 = fname + "p";

            double fst=Double.Parse(startF, System.Globalization.NumberStyles.Float);
            double fsp = Double.Parse(stopF, System.Globalization.NumberStyles.Float);
            fnr = Convert.ToInt32(fn);
            double dt = 1 / (fsp - fst) * (fnr-1)/512*1000000000;
            int cale=Convert.ToInt32(cableL);
            
            double vel = 0.1;
            int dep1 = Convert.ToInt32(dt * vel * 512 / 2 * 100);
            depS = dep1.ToString();
            double xtrange= 2 * dep1/vel/dt;
            trange = Convert.ToInt32(xtrange);
            
            double xijk = cale * 5 / dt;
            ijk = Convert.ToInt32(xijk);

            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }
            if (ijk > 512)
            { ijk = ijk - 512; }










            double xyratio=512 / xtrange;
            //yratio=Convert.ToInt32(xyratio);
            yratio = xyratio;


            //TextWriter tw1 = new StreamWriter(mainForm.currenDir + "parameter.txt");
            TextWriter tw1 = new StreamWriter( "parameter.txt");
            //  tw.WriteLine(startTime);
            tw1.WriteLine(fnum);
            tw1.WriteLine(startFrequncy);
            tw1.WriteLine(stopFrequncy);
            tw1.WriteLine(ifbw);
            tw1.WriteLine(tchl);
            tw1.WriteLine(fname);
            tw1.WriteLine(cableL);
            tw1.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog(); 
            op.ShowDialog();

           filename = op.FileName;

          textBoxFile.Text = filename; 


        }

       
    }
}
