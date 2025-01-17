﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
//using Network.Connect;
//copy right EM Earth Consulting 2012
namespace EmDraw
{
    public partial class Form1 : Form
    {
        public Bitmap[] mPicture;
        public BitmapData[] mPictureData;
        public int mFrontBuf;
        public int mBackBuf;

        static bool tomoBtn = false;

        static bool stopBtnClk = false;
        static bool startBtnClk = false;

        public const int dimx = 512; //mEmData.mDataSize;
        public const int dimy = 512; //mEmData.mItemSize;

        public int totalCount;

        public Form1()
        {
            InitializeComponent();
            mFrontBuf = 0;
            mBackBuf = 1;

            mPicture = new Bitmap[2];
            mPictureData = new BitmapData[2];

            for (int i = 0; i < 2; i++)
            {
                mPicture[i] = new Bitmap(dimx, dimy);

                Rectangle rect = new Rectangle(0, 0, mPicture[i].Width, mPicture[i].Height);
                mPictureData[0] = mPicture[i].LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    mPicture[i].PixelFormat);
            }

            Controls.Add(button1);
            Controls.Add(button3);
        }

        private void aquiSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new instance of the MDI child template form
            setupForm chForm = new setupForm();

            //Set parent form for the child window 
            chForm.MdiParent = this;

            //Display the child window
            chForm.Show();
        }

        
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (mPicture[mFrontBuf] != null)
            {
               Rectangle destRect = new Rectangle(0, 0, dimx,dimy);

                // Draw image to screen.
                e.Graphics.DrawImage(mPicture[mFrontBuf], destRect);

                labelTotalCount.Text = totalCount.ToString();
            }
        }

                 
         public void DrawFFTGraph(EmData theEmData)
         {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("61");
            Console.WriteLine(sw.ElapsedMilliseconds);

            totalCount = theEmData.mItemSize;
             theEmData.CalcScaledFFTValue();

            Console.WriteLine("62");
            Console.WriteLine(sw.ElapsedMilliseconds);

            int ijk1 = setupForm.ijk;
            int trange1 = setupForm.trange;
            double yratio1 = setupForm.yratio;
            int dimy1 = ijk1;
           // int dimy2 = trange1;


            //Fill Picture With Data
           /* if (this.mPicture == null)
            {
                this.mPicture = new Bitmap(dimx, dimy);
            }*/

            double uppercutoff = Double.Parse(this.textBoxUpper.Text, System.Globalization.CultureInfo.InvariantCulture);
            double lowercutoff = Double.Parse(this.textBoxLower.Text, System.Globalization.CultureInfo.InvariantCulture);
            int flipLine = int.Parse(this.textBoxFlip.Text, System.Globalization.CultureInfo.InvariantCulture);
            int lineWidthx = int.Parse(this.textBoxWidth.Text, System.Globalization.CultureInfo.InvariantCulture);
            int lineWidthy = lineWidthx;
            lineWidthy = 1;
            int dataLength = theEmData.mItemSize;
            int numvisibleData = dimx / lineWidthx;
            int startDataposx = 0;

            if (numvisibleData < dataLength)
            {
                startDataposx = dataLength - numvisibleData;
            }


            byte[] rgbvalue = new byte[dimx * dimy];

            for (int i = 0; i < dimx; i++)
            {
             
                int    dataPosX = startDataposx + i/lineWidthx ;

                for (int j1 = 0; j1 < dimy; j1++)
                {
                 
                    int dataPosY = j1 / lineWidthy;
                   
                    int j = dataPosY + ijk1/lineWidthy;

                   if (j > (dimy/lineWidthy-1))

                    { j = j - dimy/lineWidthy; }


                   /* if (j > 512)

                    { j = j - 512; } */
                  

                 //   int scale = (int)(255 * theEmData.GetScaledFFTValue(dataPosX, dataPosY, lowercutoff, uppercutoff));
                    byte scale = (byte)(255 * theEmData.GetScaledFFTValue(dataPosX, j, lowercutoff, uppercutoff));
                 //   Color greyScale = Color.FromArgb(255, 210, scale, scale);
                    //2013-01-21, 2013-01-29
                    //Color greyScale = Color.FromArgb(255, scale, scale, scale);
                    //mPicture[mBackBuf].SetPixel(i, j1, greyScale);
                    rgbvalue[i * dimy + j1] = scale;

                }
            }

            Console.WriteLine("63");
            Console.WriteLine(sw.ElapsedMilliseconds);

            IntPtr ptr = mPictureData[mBackBuf].Scan0;
            System.Runtime.InteropServices.Marshal.Copy(mRgbValues[mBackBuf], 0, ptr, dimx*dimy);

            Console.WriteLine("64");
            Console.WriteLine(sw.ElapsedMilliseconds);

            int buf = mFrontBuf;
            mFrontBuf = mBackBuf;
            mBackBuf = buf;
            this.Refresh();

            Console.WriteLine("65");
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        //*private void buttonDrawFromFile_Click(object sender, EventArgs e)
         public void buttonDrawFromFile_Click(object sender, EventArgs e)
        {
            //read data from file
            StreamReader dataFile = new StreamReader(setupForm.fname);

             //"C:\\MyWork\\EMTest1\\bin\\Debug\\floor_horn1.txt C:\\lucky1.txt"

            //Read the first line of text
            string line = dataFile.ReadLine(); //skip 1
            line = dataFile.ReadLine(); //skip 1
            line = dataFile.ReadLine();

            EmData theEmData = new EmData();

            //Continue to read until you reach end of file
            while (line != null)
            {
                //read the line to EmDataItem
                theEmData.AddOneItem(line);

                //Read the next line
                line = dataFile.ReadLine(); //skip 1
                line = dataFile.ReadLine();

                DrawFFTGraph(theEmData);
            }

            //close the file
            dataFile.Close();
        }


         public void button1_Click(object sender, EventArgs e)
         {
             startBtnClk = false;
             stopBtnClk = true;
             

         }
         public void button2_Click(object sender, EventArgs e)
         {
             //Create a new instance of the MDI child template form
             setupForm chForm = new setupForm();

             //Set parent form for the child window 
             //chForm.MdiParent = this;

             //Display the child window
             chForm.Show();   

         }

         public void button3_Click(object sender, EventArgs e)
         {
             tomoBtn = true;


         }

      

        private void buttonCollect_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = setupForm.depS;
            startBtnClk = true;
            stopBtnClk = false;
            //DataCollector.StartCollect(this);
            Form1.StartCollect(this);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
