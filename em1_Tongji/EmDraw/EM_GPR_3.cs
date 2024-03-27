using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Drawing;
using EmDraw;
using System.Windows.Forms;

//namespace Network.Connect
//copy right EM Earth Consulting 2012
namespace EmDraw
{
    //class DataCollector

  partial  class Form1
    {
        //System.IO.StreamWriter file; 
	    static System.IO.StreamWriter file;
        static TelnetConnection tc;

        static EmData mEmData; //Xinwei
        static Form1 mForm; //Xinwei

        public static int StartCollect(Form1 form)
        
        {
            File.Copy("para.lis", setupForm.fname1);
            // defaultHostName is host name to use if one is not specified on the command line.

            string defaultHostName = "138.198.1.1";
            string hostName = defaultHostName;

            mEmData = new EmData(); //Xinwei
           mForm = form; //Xinwei
            

            try
            {
                tc = new TelnetConnection();
                tc.ReadTimeout = 10000; // 10 sec
                tc.Open(hostName); 

                if( tc.IsOpen )
                {
                    //Write(":SENS:SWE:POIN 101");
                    //Write(":SENS:FREQ:STAR 1e8"); 
                    //Write(":SENS:FREQ:STOP 1e9"); 
                    //Write(":SENS:BWID 300"); 
                    //Write(":CALC:PAR:DEF S21");
                    StreamReader reader = new StreamReader("parameter.txt");
                    string line = string.Empty;

                    for (int i1 = 0; i1 < 5; i1++)
                        
                    {
                        // Console.WriteLine(line);
                        line = reader.ReadLine();
                        Write(line);
                    }

                    line = reader.ReadLine();
                    file = new System.IO.StreamWriter(line); //do it around line 73,

                    reader.Close();

                    Write("SOUR:POW MAX");                   
                    Write("INIT:CONT OFF");
                    Write("INIT:IMM;*OPC?");

                  //  Console.WriteLine("start time"+DateTime.Now);
                  //  file.WriteLine("start time" + DateTime.Now); //XINWEI 
                    int i = 1;
//*
                   // while( true )

                     int i7 = 0;
                 //   for (int i2=0; i2<100;i2++)
                    while(true)
                    {
                        i7 = i7 + 1;
                        Write("INIT:IMM;*OPC?");
                        //Write(":TRAC:DATA? SDAT");
                        Write(":CALC:DATA:SDAT?");

                        string dataStr = tc.Read();
                        file.WriteLine(dataStr);
                        
                        Application.DoEvents();
                        if (Form1.stopBtnClk == true)
                        {
                            break;
                        }


                        if (i7 == 3)
                        {
                            mEmData.AddOneItem(dataStr); //Xinwei
                            mForm.DrawFFTGraph(mEmData); //Xinwei
                            i7 = 1;
                        }

                        //Read();

                       
                       // if( Console.KeyAvailable && Console.ReadKey( true ).Key == ConsoleKey.Escape ) 
                       //     break;

                       // Console.WriteLine( i++ );

                       

                        

                    }

                    Write("INIT:CONT ON;*OPC?");

                    //End your program here
                    tc.Dispose();

                  // Console.WriteLine("stop time"+DateTime.Now);
                 //  file.WriteLine("stop time" + DateTime.Now); //XINWEI 

               //    Console.WriteLine("Press any key to exit.");
               //    Console.ReadKey(); // continue after reading a key from the keyboard.
                }
                else
                {
                    Console.WriteLine("Error opening " + hostName);
                    return -1;
                }

                //FieldFox Programming Guide 5
                file.Close();

               
                //*
                  //read data from file
            StreamReader dataFile = new StreamReader("C:\\data\\job_bbb.txt");
//"C:\\MyWork\\EMTest1\\bin\\Debug\\floor_horn1.txt C:\\lucky1.txt"

            //Read the first line of text


            string line1 = dataFile.ReadLine(); //skip 1
            line1 = dataFile.ReadLine(); //skip 1
            line1 = dataFile.ReadLine();

            //EmData themEmData = new EmData();

            //Continue to read until you reach end of file
            while (line1 != null)
            {
                //read the line to EmDataItem
               // mEmData.AddOneItem(line1);

                //Read the next line
                line1 = dataFile.ReadLine(); //skip 1
                line1 = dataFile.ReadLine();
            }

            //close the file
            dataFile.Close();

            //mForm.DrawFFTGraph(mEmData); //Xinwei
        

                //*
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }

            // exit normally.
            return 0;
        }

                
        static void Write(string s)
        {
            //Console.WriteLine(s);
            tc.WriteLine(s);
            //if (s.IndexOf('?') >= 0)
            //  Read();

        }

        /// <summary>
        /// Read the telnet connection for a response, and print the response to the
        /// Console.
        /// </summary>
        static void Read()
        {
            //Console.WriteLine(tc.Read()); //earliest
           // file.WriteLine(tc.Read()); //save file version
            string dataStr = tc.Read();
            file.WriteLine(dataStr);

            
                mEmData.AddOneItem(dataStr); //Xinwei
              mForm.DrawFFTGraph(mEmData); //Xinwei

                
         
            
           // mEmData.AddOneItem(dataStr); //Xinwei
            //mForm.DrawFFTGraph(mEmData); //Xinwei
            
        }
    }


#region TelnetConnection - no need to edit

    /// <summary>
    /// Telnet Connection on port 5025 to an instrument
    /// </summary>
    public class TelnetConnection : IDisposable
    {
        TcpClient m_Client;
        NetworkStream m_Stream;

        bool m_IsOpen = false;
        public static int bb=0;


        string m_Hostname;
        int m_ReadTimeout = 1000; // ms
        public delegate void ConnectionDelegate();
        public event ConnectionDelegate Opened;
        public event ConnectionDelegate Closed;

        public bool IsOpen { get { return m_IsOpen; } }

        public TelnetConnection() { }

        public TelnetConnection(bool open) : this("localhost", true) { }

        public TelnetConnection(string host, bool open)
        {
            if (open)
                Open(host);
        }

        void CheckOpen()
        {
            if (!IsOpen)
                throw new Exception("Connection not open.");
        }

        public string Hostname
        {
            get { return m_Hostname; }
        }

        public int ReadTimeout
        {
            set { m_ReadTimeout = value; if (IsOpen) m_Stream.ReadTimeout = value; }
            get { return m_ReadTimeout; }
        }

        public void Write(string str)
        {
            //FieldFox Programming Guide 6
            CheckOpen();
            byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
            m_Stream.Write(bytes, 0, bytes.Length);
            m_Stream.Flush();
        }

        public void WriteLine(string str)
        {
            CheckOpen();
            byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
            m_Stream.Write(bytes, 0, bytes.Length);
            WriteTerminator();
            bb=bb+bytes.Length;
        }

        void WriteTerminator()
        {
            byte[] bytes = System.Text.ASCIIEncoding.ASCII.GetBytes("\r\n\0");
            m_Stream.Write(bytes, 0, bytes.Length);
            m_Stream.Flush();
        }

        public string Read()
        {
            CheckOpen();
            return System.Text.ASCIIEncoding.ASCII.GetString(ReadBytes());
        }

        /// <summary>
        /// Reads bytes from the socket and returns them as a byte[].
        /// </summary>
        /// <returns></returns>
        public byte[] ReadBytes()
        {
            int i = m_Stream.ReadByte();
            byte b = (byte)i;
            int bytesToRead = 0;
            var bytes = new List<byte>();

            if ((char)b == '#')
            {
                bytesToRead = ReadLengthHeader();

                if (bytesToRead > 0)
                {
                    i = m_Stream.ReadByte();
                    if ((char)i != '\n') // discard carriage return after length header.
                        bytes.Add((byte)i);
                }
            }

            if (bytesToRead == 0)
            {
                while (i != -1 && b != (byte)'\n')
                {
                    bytes.Add(b);
                    i = m_Stream.ReadByte();
                    b = (byte)i;
                }
            }
            else
            {

                int bytesRead = 0;

                while (bytesRead < bytesToRead && i != -1)

                {

                    i = m_Stream.ReadByte();

                    if (i != -1)

                    {

                        bytesRead++;

                        // record all bytes except \n if it is the last char.

                        if (bytesRead < bytesToRead || (char)i != '\n')

                            bytes.Add((byte)i);

                    }

                }

            }

            return bytes.ToArray();

        }

        int ReadLengthHeader()

        {

            int numDigits = Convert.ToInt32(new string(new char[] { (char)m_Stream.ReadByte() }));

            string bytes = "";

            for (int i = 0; i < numDigits; ++i)

                bytes = bytes + (char)m_Stream.ReadByte();

            return Convert.ToInt32(bytes);

        }

        public void Open(string hostname)

        {

            if (IsOpen)

                Close();

            m_Hostname = hostname;

            m_Client = new TcpClient(hostname, 5025);

            m_Stream = m_Client.GetStream();

            m_Stream.ReadTimeout = ReadTimeout;

            m_IsOpen = true;

            if (Opened != null)

                Opened();

        }

        public void Close()
        {
            if (!m_IsOpen)
                //FieldFox Programming Guide 7
                return;

            m_Stream.Close();

            m_Client.Close();

            m_IsOpen = false;

            if (Closed != null)
                Closed();
        }

        public void Dispose()
        {
            Close();
        }

    }

#endregion
}
