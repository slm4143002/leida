//#define CHECK_REGISTRY_KEY //xinweiFeb2012: comment this out to not registery key
#define CHECK_DATE //xinweiMar2012: comment this out to not check date

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using TestFFT;


//copy right EM Earth Consulting 2012
namespace EmDraw
{
    public class EmDataItem
    {
        public int mDataSize; //number of items
        public int mFFTSize;
        public double[] mRawData;
        public double[] mFFTData;
        public double[] mScaledFFTData;

        public EmDataItem(int dataSize)
        {
            mDataSize = dataSize;
            mRawData = new double[dataSize];

          //  int log = (int)(Math.Log(dataSize/2, 2) + 1);
          //  mFFTSize = 2*(int)Math.Pow(2, log);
            mFFTSize = 512;
            mFFTData = new double[mFFTSize];
            mScaledFFTData = new double[mFFTSize];
        }
    }

    public class EmData
    {
        public const int MAX_ITEM_SIZE = 4*512*512;
        public int mItemSize; //number of raw data-points in item
        public EmDataItem[] mItemList;
        public Lomont3FFT mLomont3FFT;

        public EmData()
        {
            mItemList = new EmDataItem[MAX_ITEM_SIZE];
            mLomont3FFT = new Lomont3FFT();
        }

        public void AddOneItem(string dataStr)
        {
            string [] split = dataStr.Split(new Char [] {','});
            mItemList[mItemSize] = new EmDataItem(split.Length);

            for (int i = 0; i < mItemList[mItemSize].mDataSize; i++)
            {
                mItemList[mItemSize].mRawData[i] = double.Parse(split[i], System.Globalization.CultureInfo.InvariantCulture);
                mItemList[mItemSize].mFFTData[i] = mItemList[mItemSize].mRawData[i];
            }

            for (int i = mItemList[mItemSize].mDataSize; i < mItemList[mItemSize].mFFTSize; i++)
            {
                mItemList[mItemSize].mFFTData[i] = 0;
            }

            mLomont3FFT.FFT(mItemList[mItemSize].mFFTData, true);

            mItemSize++;
        }

        public void CalcScaledFFTValue()
        {
            double maxValue = Double.MinValue;
            double minValue = Double.MaxValue;

            //for (int n=0; n<mItemSize; n++)
            //{
            //    for (int i = 0; i < mItemList[n].mFFTSize; i++)
            //    {
            //        if (mItemList[n].mFFTData[i] > maxValue)
            //        {
            //            maxValue = mItemList[n].mFFTData[i];
            //        }
            //        else if (mItemList[n].mFFTData[i] < minValue)
            //        {
            //            minValue = mItemList[n].mFFTData[i];
            //        }
            //    }
            //}

            for (int n = 0; n < mItemSize; n++)
            {
                for (int i = 0; i < mItemList[n].mFFTSize; i++)
                {
                    if (mItemList[n].mFFTData[i] > maxValue)
                    {
                        maxValue = mItemList[n].mFFTData[i];
                    }
                    else if (mItemList[n].mFFTData[i] < minValue)
                    {
                        minValue = mItemList[n].mFFTData[i];
                    }
                    minValue = -1 * maxValue;
                }
                
                
                
                for (int i = 0; i < mItemList[n].mFFTSize; i++)
                {
                    mItemList[n].mScaledFFTData[i] = (mItemList[n].mFFTData[i] - minValue) / (maxValue - minValue);
                }
            }
        }

        public double GetScaledFFTValue(int n, int i, double lowercutoff, double uppercutoff)
        {
            if (n >= mItemSize || i >= mItemList[n].mFFTSize)
                return 1.0;

            double value = 1.0;

            if (mItemList[n].mScaledFFTData[i] < lowercutoff)
            {
                value = 0.0;
            }
            else if (mItemList[n].mScaledFFTData[i] < uppercutoff)
            {
                value = (mItemList[n].mScaledFFTData[i] - lowercutoff) / (uppercutoff - lowercutoff);
            }

            return value;
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


#if CHECK_DATE //xinweiFeb2012: the code checks dates
            DateTime timeNow = DateTime.Now;
            DateTime dateExpire = new DateTime(2012, 12, 29, 15, 27, 0); //year, month, day, hour, minute, second

            int result = DateTime.Compare(timeNow, dateExpire);
            if (result > 0)
            {
                MessageBox.Show("Run time error. Please contact with the software developer");
                return;
            }
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
