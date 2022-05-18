
namespace Demo_TTT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFiles = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart_Stop = new System.Windows.Forms.Button();
            this.txtDestination_Path = new System.Windows.Forms.TextBox();
            this.txtOrigin_Path = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fbdOrigin_Path = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDestination_Path = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtStation_Name = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiles)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo_TTT.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(849, 300);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Days";
            // 
            // nudFiles
            // 
            this.nudFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFiles.Location = new System.Drawing.Point(37, 192);
            this.nudFiles.Margin = new System.Windows.Forms.Padding(4);
            this.nudFiles.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudFiles.Name = "nudFiles";
            this.nudFiles.Size = new System.Drawing.Size(92, 26);
            this.nudFiles.TabIndex = 22;
            this.nudFiles.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "From";
            // 
            // btnStart_Stop
            // 
            this.btnStart_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart_Stop.Location = new System.Drawing.Point(363, 183);
            this.btnStart_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart_Stop.Name = "btnStart_Stop";
            this.btnStart_Stop.Size = new System.Drawing.Size(117, 43);
            this.btnStart_Stop.TabIndex = 13;
            this.btnStart_Stop.Text = "START";
            this.btnStart_Stop.UseVisualStyleBackColor = true;
            this.btnStart_Stop.Click += new System.EventHandler(this.btnStart_Stop_Click);
            // 
            // txtDestination_Path
            // 
            this.txtDestination_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination_Path.Location = new System.Drawing.Point(96, 82);
            this.txtDestination_Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestination_Path.Name = "txtDestination_Path";
            this.txtDestination_Path.Size = new System.Drawing.Size(381, 26);
            this.txtDestination_Path.TabIndex = 12;
            this.txtDestination_Path.Text = "D:\\Data-TTT";
            this.txtDestination_Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtDestination_Path_MouseDoubleClick);
            // 
            // txtOrigin_Path
            // 
            this.txtOrigin_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigin_Path.Location = new System.Drawing.Point(96, 37);
            this.txtOrigin_Path.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigin_Path.Name = "txtOrigin_Path";
            this.txtOrigin_Path.Size = new System.Drawing.Size(381, 26);
            this.txtOrigin_Path.TabIndex = 10;
            this.txtOrigin_Path.Text = "D:\\DataX";
            this.txtOrigin_Path.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtOrigin_Path_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 94);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 483);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // txtStation_Name
            // 
            this.txtStation_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStation_Name.Location = new System.Drawing.Point(16, 30);
            this.txtStation_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtStation_Name.Name = "txtStation_Name";
            this.txtStation_Name.Size = new System.Drawing.Size(163, 26);
            this.txtStation_Name.TabIndex = 26;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(212, 26);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(109, 34);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Add";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.txtOrigin_Path);
            this.grb1.Controls.Add(this.txtDestination_Path);
            this.grb1.Controls.Add(this.btnStart_Stop);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.nudFiles);
            this.grb1.Location = new System.Drawing.Point(487, 15);
            this.grb1.Margin = new System.Windows.Forms.Padding(4);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(4);
            this.grb1.Size = new System.Drawing.Size(504, 250);
            this.grb1.TabIndex = 28;
            this.grb1.TabStop = false;
            this.grb1.Text = "Move File";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(329, 26);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Within:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 597);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtStation_Name);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTT Auto Restore File Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiles)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart_Stop;
        private System.Windows.Forms.TextBox txtDestination_Path;
        private System.Windows.Forms.TextBox txtOrigin_Path;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.FolderBrowserDialog fbdOrigin_Path;
        private System.Windows.Forms.FolderBrowserDialog fbdDestination_Path;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtStation_Name;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
    }
}

