using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueManagmentUserDefineApp
{
    public partial class QueueManagmentUserDefineApp : Form
    {
        public QueueManagmentUserDefineApp()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if ((enqueueNameTextBox.Text == "") || (enqueueComplainTextBox.Text == ""))
            {
                MessageBox.Show("Entry is missing");
                return;
            }
            CustomarDetails.CustomarNameQueue.Enqueue(enqueueNameTextBox.Text);
            CustomarDetails.CustomarComplainQueue.Enqueue(enqueueComplainTextBox.Text);
            CustomarDetails.CustomerSerialNumberQueue.Enqueue(CustomarDetails.SerialNumber);
            string msg = enqueueNameTextBox.Text + "'s serial number is " + CustomarDetails.SerialNumber;
            MessageBox.Show(msg);
            var items = new ListViewItem(CustomarDetails.SerialNumber.ToString());
            items.SubItems.Add(enqueueNameTextBox.Text);
            items.SubItems.Add(enqueueComplainTextBox.Text);
            queueManagementListView.Items.Add(items);
            enqueueNameTextBox.Text = "";
            enqueueComplainTextBox.Text = "";
            CustomarDetails.SerialNumber++;

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (CustomarDetails.CustomarNameQueue.Count == 0)
            {
                dequeueSerialNoTextBox.Text = "";
                dequeueNameTextBox.Text = "";
                dequeueComplainTextBox.Text = "";
                MessageBox.Show("Congratulation! There is no customer in the queue");
                return;
            }
            dequeueSerialNoTextBox.Text = CustomarDetails.CustomerSerialNumberQueue.Dequeue().ToString();
            dequeueNameTextBox.Text = CustomarDetails.CustomarNameQueue.Dequeue();
            dequeueComplainTextBox.Text = CustomarDetails.CustomarComplainQueue.Dequeue();
            queueManagementListView.Items.RemoveAt(0);
          
        }
    }
}
