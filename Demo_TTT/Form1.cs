using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_TTT
{
    public partial class Form1 : Form
    {

        public ListViewItem _itemselected;

        
        public DateTime _validdatetime;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtOrigin_Path_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fbdOrigin_Path.ShowDialog();
            txtOrigin_Path.Text = fbdOrigin_Path.SelectedPath.ToString();
        }

        private void txtDestination_Path_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fbdDestination_Path.ShowDialog();
            txtDestination_Path.Text = fbdDestination_Path.SelectedPath.ToString();
        }

        private void btnStart_Stop_Click(object sender, EventArgs e)
        {
            if (btnStart_Stop.Text == "START")
            {             
                timer1.Enabled = true;
                btnStart_Stop.Text = "STOP";      
            }
            else if (btnStart_Stop.Text == "STOP")
            {              
                timer1.Enabled = false;
                btnStart_Stop.Text = "START";                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            var validdatetime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            lblMyDatetime.Text = validdatetime.ToString("dd/MM/yyyy");
            validdatetime = validdatetime.AddDays((double)(-(nudFiles.Value)));
            lblValidDatetime.Text = validdatetime.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Directory.Exists(txtOrigin_Path.Text))
            {
                TreeNode root = new TreeNode() { Text = txtOrigin_Path.Text };
                LoadExplorer(root);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 20)
            {
                MessageBox.Show("Đã đủ 20 trạm. Vui lòng xóa bớt!");
            }
            else
            {
                if (!listView1.Items.ContainsKey(txtStation_Name.Text))
                {
                   listView1.Items.Add(new ListViewItem { Text = txtStation_Name.Text, Name = txtStation_Name.Text, ImageIndex = 0 , ImageKey = txtStation_Name.Text });
                }
                else
                {
                    MessageBox.Show("Trạm đã tồn tại!");
                }
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _itemselected = e.Item;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(_itemselected);
        }

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
                return;
            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                {
                    string[] files_list = System.IO.Directory.GetFiles(root.Text, "*.txt");
                    foreach (string file in files_list)
                    {
                        try
                        {
                            string[] filenamelist = file.Split('\\');
                            string filename = filenamelist[filenamelist.Length - 1];
                            string stationcode = filename.Substring(0, filename.LastIndexOf('_'));
                            var year = int.Parse(filename.Substring(filename.LastIndexOf('_') + 1, 4));
                            var month = int.Parse(filename.Substring(filename.LastIndexOf('_') + 5, 2));
                            var day = int.Parse(filename.Substring(filename.LastIndexOf('_') + 7, 2));
                            var hour = int.Parse(filename.Substring(filename.LastIndexOf('_') + 9, 2));
                            var minute = int.Parse(filename.Substring(filename.LastIndexOf('_') + 11, 2));
                            var second = int.Parse(filename.Substring(filename.LastIndexOf('_') + 13, 2));

                            var mydatetime = new DateTime(year, month, day, hour, minute, second).ToLocalTime();
                            

                            var validdatetime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

                            validdatetime = validdatetime.AddDays((double)(-(nudFiles.Value)));
                            _validdatetime = validdatetime;

                            if ((DateTime.Compare(mydatetime, validdatetime) >= 0) && listView1.Items.ContainsKey(stationcode) && !File.Exists(txtDestination_Path.Text + "\\" + filename))
                            {
                                File.Copy(file, txtDestination_Path.Text + "\\" + filename);
                            }
                        }
                        catch { }         
                    }
                    return;
                }

                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        LoadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void nudFiles_ValueChanged(object sender, EventArgs e)
        {
            var validdatetime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            lblMyDatetime.Text = validdatetime.ToString("dd/MM/yyyy");
            validdatetime = validdatetime.AddDays((double)(-(nudFiles.Value)));
            lblValidDatetime.Text = validdatetime.ToString("dd/MM/yyyy");
            
           
        }
    }
}

