using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Todo_List
{
    public partial class Form1 : Form
    {
        List<Task> Tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            FetchTasks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        void AddTask()
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                Tasks.Add(new Task(textBox1.Text, false));

                checkedListBox1.Items.Add(textBox1.Text, false);

                textBox1.Text = "";

                SaveData();
            }
        }

        void FetchTasks()
        {
            checkedListBox1.Items.Clear();

            foreach (var task in Tasks)
            {
                checkedListBox1.Items.Add(task.Description, task.isChecked);
            }
        }

        void SaveData()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var subFolderPath = Path.Combine(path, "TODO List DATA");

            System.IO.Directory.CreateDirectory(subFolderPath);

            string[] TaskArray = new string[Tasks.Count];
            string[] TaskChecks = new string[Tasks.Count];


            for (int i = 0; i < Tasks.Count; i++)
            {
                TaskArray[i] = Tasks[i].Description;
                TaskChecks[i] = Tasks[i].isChecked.ToString().ToLower();
            }

            File.WriteAllLines($"{subFolderPath}/TaskArray.txt", TaskArray);
            File.WriteAllLines($"{subFolderPath}/TaskChecks.txt", TaskChecks);
        }

        void LoadData()
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var subFolderPath = Path.Combine(path, "TODO List DATA");

                string[] TaskArray = File.ReadLines($"{subFolderPath}/TaskArray.txt").ToArray();
                string[] TaskChecks = File.ReadLines($"{subFolderPath}/TaskChecks.txt").ToArray();


                if (TaskArray != null)
                {
                    for (int i = 0; i < TaskArray.Length; i++)
                    {
                        Task task = new Task(TaskArray[i], Convert.ToBoolean(TaskChecks[i]));
                        Tasks.Add(task);
                    }
                }
            }
            catch
            {
                Console.WriteLine("No Saves");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    Tasks[i].isChecked = true;
                }
                else
                {
                    Tasks[i].isChecked = false;
                }
            }

            SaveData();
        }

        private void deleteItems_Click(object sender, EventArgs e)
        {

            List<Task> tasksToRemove = new List<Task>();

            for (int i = 0; i < Tasks.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    Task TempTask = Tasks[i];
                    tasksToRemove.Add(TempTask);
                }
            }

            foreach (var task in tasksToRemove)
            {
                Tasks.Remove(task);
            }

            FetchTasks();
            SaveData();
        }

        private void checkAllBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count < checkedListBox1.Items.Count)
            {
                foreach (var task in Tasks)
                {
                    task.isChecked = true;
                }
            }
            else
            {
                foreach (var task in Tasks)
                {
                    task.isChecked = false;
                }
            }

            FetchTasks();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddTask();
                e.Handled = true;
            }
        }
    }

    class Task
    {
        public bool isChecked { get; set; }
        public string Description { get; set; }

        public Task(string description, bool IsChecked)
        {
            Description = description;
            isChecked = IsChecked;
        }
    }

}
