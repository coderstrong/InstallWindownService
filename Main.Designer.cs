namespace InstallWindownService
{
     partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bt_brower = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_install = new System.Windows.Forms.Button();
            this.bt_unstall = new System.Windows.Forms.Button();
            this.ofd_openfile = new System.Windows.Forms.OpenFileDialog();
            this.bt_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.bt_browser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_installandstart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_brower
            // 
            this.bt_brower.Location = new System.Drawing.Point(303, 50);
            this.bt_brower.Name = "bt_brower";
            this.bt_brower.Size = new System.Drawing.Size(68, 23);
            this.bt_brower.TabIndex = 0;
            this.bt_brower.Text = "Find";
            this.bt_brower.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File EXE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service Name";
            // 
            // bt_install
            // 
            this.bt_install.Location = new System.Drawing.Point(13, 31);
            this.bt_install.Name = "bt_install";
            this.bt_install.Size = new System.Drawing.Size(71, 44);
            this.bt_install.TabIndex = 0;
            this.bt_install.Text = "Install";
            this.bt_install.UseVisualStyleBackColor = true;
            this.bt_install.Click += new System.EventHandler(this.bt_install_Click);
            // 
            // bt_unstall
            // 
            this.bt_unstall.Location = new System.Drawing.Point(210, 31);
            this.bt_unstall.Name = "bt_unstall";
            this.bt_unstall.Size = new System.Drawing.Size(68, 44);
            this.bt_unstall.TabIndex = 0;
            this.bt_unstall.Text = "Unstall";
            this.bt_unstall.UseVisualStyleBackColor = true;
            this.bt_unstall.Click += new System.EventHandler(this.bt_unstall_Click);
            // 
            // ofd_openfile
            // 
            this.ofd_openfile.FileName = "ofd_openfile";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(303, 31);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(67, 44);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_brower);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_path);
            this.groupBox2.Controls.Add(this.bt_browser);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(198, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "File EXE";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(98, 51);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(199, 20);
            this.txt_path.TabIndex = 1;
            this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // bt_browser
            // 
            this.bt_browser.Location = new System.Drawing.Point(303, 50);
            this.bt_browser.Name = "bt_browser";
            this.bt_browser.Size = new System.Drawing.Size(68, 23);
            this.bt_browser.TabIndex = 0;
            this.bt_browser.Text = "Find";
            this.bt_browser.UseVisualStyleBackColor = true;
            this.bt_browser.Click += new System.EventHandler(this.bt_browser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_installandstart);
            this.groupBox3.Controls.Add(this.bt_install);
            this.groupBox3.Controls.Add(this.bt_exit);
            this.groupBox3.Controls.Add(this.bt_unstall);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONTROL";
            // 
            // bt_installandstart
            // 
            this.bt_installandstart.Location = new System.Drawing.Point(99, 31);
            this.bt_installandstart.Name = "bt_installandstart";
            this.bt_installandstart.Size = new System.Drawing.Size(89, 44);
            this.bt_installandstart.TabIndex = 0;
            this.bt_installandstart.Text = "Install and Start";
            this.bt_installandstart.UseVisualStyleBackColor = true;
            this.bt_installandstart.Click += new System.EventHandler(this.bt_installandstart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 222);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Install Windown Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button bt_brower;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button bt_install;
          private System.Windows.Forms.Button bt_unstall;
          private System.Windows.Forms.OpenFileDialog ofd_openfile;
          private System.Windows.Forms.Button bt_exit;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox txt_name;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox txt_path;
          private System.Windows.Forms.Button bt_browser;
          private System.Windows.Forms.GroupBox groupBox3;
          private System.Windows.Forms.Button bt_installandstart;
     }
}

