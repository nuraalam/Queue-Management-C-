using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CSVLib;
using QueueManagmentUserDefineCsvApp;

namespace QueueManagmentUserDefineApp
{ 
    public partial class QueueManagmentUserDefineCsvApp : Form
    {
        public string csvFileLocation = @"CustomarComplainRecord.csv";
        public QueueManagmentUserDefineCsvApp()
        {
            InitializeComponent();
        }

        private int _countQueueWaittingNumber,_flag=0;
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if ((enqueueNameTextBox.Text == "") || (enqueueComplainTextBox.Text == ""))
            {
                MessageBox.Show("Entry is missing");
                return;
            }
            int serialNumber = CustomarDetails.GetSerialNumber();
            CustomarDetails.CustomarNameQueue.Enqueue(enqueueNameTextBox.Text);
            CustomarDetails.CustomarComplainQueue.Enqueue(enqueueComplainTextBox.Text);
            CustomarDetails.CustomerSerialNumberQueue.Enqueue(serialNumber);
            QueueRestoreManager();


            string msg = enqueueNameTextBox.Text + "'s serial number is " + serialNumber;
            if (dequeueSerialNoTextBox.Text == "")
            {
                dequeueSerialNoTextBox.Text = CustomarDetails.CustomerSerialNumberQueue.Dequeue().ToString();
                dequeueNameTextBox.Text = CustomarDetails.CustomarNameQueue.Dequeue();
                dequeueComplainTextBox.Text = CustomarDetails.CustomarComplainQueue.Dequeue();
                MessageBox.Show(msg + "\nPlease go to service section. We are ready to serve you.");
            }
            else
            {
                var items = new ListViewItem(serialNumber.ToString());
                items.SubItems.Add(enqueueNameTextBox.Text);
                items.SubItems.Add(enqueueComplainTextBox.Text);
                queueManagementListView.Items.Add(items);
                _countQueueWaittingNumber++;
                msg += "\nPlease have a seat.\n";
                if (_countQueueWaittingNumber == 1)
                    MessageBox.Show(msg += "Only you are waiting in our queue system");
                else
                    MessageBox.Show(msg + _countQueueWaittingNumber + " Coustomers are waiting in our queue system");

            }

            List<string> customarDetailsList = new List<string>();
            customarDetailsList.Add(serialNumber.ToString());
            customarDetailsList.Add(enqueueNameTextBox.Text);
            customarDetailsList.Add(enqueueComplainTextBox.Text);
            FileStream aStream = new FileStream(csvFileLocation, FileMode.Append);
            CsvFileWriter aCsvFileWriter = new CsvFileWriter(aStream);
            aCsvFileWriter.WriteRow(customarDetailsList);
            aStream.Close();
            enqueueNameTextBox.Text = "";
            enqueueComplainTextBox.Text = "";
            serialNumber++;

        }

        private void QueueRestoreManager()
        {
            if (_flag == 1)
            {
                queueManagementListView.Items.Clear();
                int index = 0;

                while (index < _countQueueWaittingNumber)
                {
                    var items = new ListViewItem(QueueList.SerialNumberList[index]);
                    items.SubItems.Add(QueueList.NameList[index]);
                    items.SubItems.Add(QueueList.ComplainList[index]);
                    queueManagementListView.Items.Add(items);
                    index++;
                }
                QueueList.SerialNumberList.Clear();
                QueueList.NameList.Clear();
                QueueList.ComplainList.Clear();
                _flag = 0;
                return;
            }
            else
            {
                return;
            }
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (CustomarDetails.CustomarNameQueue.Count == 0)
            {
                dequeueSerialNoTextBox.Text = "";
                dequeueNameTextBox.Text = "";
                dequeueComplainTextBox.Text = "";
                QueueRestoreManager();
                MessageBox.Show("Well Done Guyes! There is no customer in the queue.");
                return;
            }

            dequeueSerialNoTextBox.Text = CustomarDetails.CustomerSerialNumberQueue.Dequeue().ToString();
            dequeueNameTextBox.Text = CustomarDetails.CustomarNameQueue.Dequeue();
            dequeueComplainTextBox.Text = CustomarDetails.CustomarComplainQueue.Dequeue();
            string msg = dequeueNameTextBox.Text + "'s serial number is " + dequeueSerialNoTextBox.Text +
                         "\nPlease go to service section. We are ready to searve you.";
            QueueRestoreManager();
            queueManagementListView.Items.RemoveAt(0);
            _countQueueWaittingNumber--;
            MessageBox.Show(msg);

        }

        private void complainRecordButton_Click(object sender, EventArgs e)
        {
           // string msg="Serial No."+"\t\t"+"Name"+"\t\t"+"Complain"+"\n";
            FileStream aStream=new FileStream(csvFileLocation,FileMode.OpenOrCreate);
            CsvFileReader aReader=new CsvFileReader(aStream);
            List<string> recordList=new List<string>();
            _countQueueWaittingNumber = queueManagementListView.Items.Count;
            _flag = 1;
            int index = 0;
            while (index<_countQueueWaittingNumber)
            {
                QueueList.SerialNumberList.Add(queueManagementListView.Items[index].SubItems[0].Text);
                QueueList.NameList.Add(queueManagementListView.Items[index].SubItems[1].Text);
                QueueList.ComplainList.Add(queueManagementListView.Items[index].SubItems[2].Text);
               // queueManagementListView.Items.RemoveAt(0);
                index++;
            }
           queueManagementListView.Items.Clear();
            while (aReader.ReadRow(recordList))
            {
                var items = new ListViewItem(recordList[0]);
                items.SubItems.Add(recordList[1]);
                items.SubItems.Add(recordList[2]);
                queueManagementListView.Items.Add(items);
              //  msg +=
                   // recordList[0]+"\t\t" + recordList[1] +"\t\t "+ recordList[2]+"\n";
            }
            aStream.Close();
            //MessageBox.Show(_countQueueWaittingNumber.ToString());
          //  MessageBox.Show(msg);

           

        }
    }
}
