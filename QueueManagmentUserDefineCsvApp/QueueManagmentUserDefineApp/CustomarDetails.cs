using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSVLib;

namespace QueueManagmentUserDefineCsvApp
{
    class CustomarDetails
    {
        public  static string FileLocation = @"CustomarComplainRecord.csv";
        public static Queue<string> CustomarNameQueue=new Queue<string>();
        public static Queue<string> CustomarComplainQueue=new Queue<string>();
        public static Queue<int> CustomerSerialNumberQueue = new Queue<int>();
        public static int GetSerialNumber()
        {
            FileStream aStream=new FileStream(FileLocation,FileMode.OpenOrCreate);
            CsvFileReader aReader=new CsvFileReader(aStream);
            List<string> readLineOfFile=new List<string>();
            int serialNumber = 1001;
            
            while (aReader.ReadRow(readLineOfFile))
            {
                serialNumber++;
            }
            aStream.Close();
            return serialNumber;
        } 
    }
}
