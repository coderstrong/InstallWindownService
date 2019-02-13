using ServiceTools;
using System;
using System.Windows.Forms;

namespace InstallWindownService
{
     public partial class Main : Form
     {
          public Main()
          {
               InitializeComponent();
          }

          private void bt_exit_Click(object sender, EventArgs e)
          {
               Application.ExitThread();
               Application.Exit();
          }

          private void bt_install_Click(object sender, EventArgs e)
          {
               try
               {
                    if (!string.IsNullOrEmpty(txt_name.Text.Trim()) || !string.IsNullOrEmpty(txt_path.Text.Trim()))
                    {
                         if (System.IO.Path.GetExtension(txt_path.Text.Trim()).ToLower().Equals(".exe"))
                         {
                              if (!ServiceInstaller.ServiceIsInstalled(txt_name.Text.Trim()))
                              {
                                   ServiceInstaller.InstallAndStart(txt_name.Text, txt_name.Text.Trim(), txt_path.Text.Trim());
                                   MessageBox.Show("OK! is service start");
                              }
                              else
                              {
                                   MessageBox.Show("Service installed or Same name other service!");
                              }
                         }
                         else
                         {
                              MessageBox.Show("File is exe ? ");
                         }
                    }
                    else
                    {
                         MessageBox.Show("Input is missing value!");
                    }
               }
               catch (ApplicationException ex)
               {
                    MessageBox.Show("Messages: " + ex.Message + " \n " + "Trace: " + ex.StackTrace);
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Messages: " + ex.Message + " \n " + "Trace: " + ex.StackTrace);
               }

          }
          private void bt_installandstart_Click(object sender, EventArgs e)
          {
               try
               {
                    if (!string.IsNullOrEmpty(txt_name.Text.Trim()) || !string.IsNullOrEmpty(txt_path.Text.Trim()))
                    {
                         if (System.IO.Path.GetExtension(txt_path.Text.Trim()).ToLower().Equals(".exe"))
                         {
                              if (!ServiceInstaller.ServiceIsInstalled(txt_name.Text.Trim()))
                              {
                                   ServiceInstaller.InstallAndStart(txt_name.Text, txt_name.Text.Trim(), txt_path.Text.Trim(), true);
                                   MessageBox.Show("OK! is service start");
                              }
                              else
                              {
                                   MessageBox.Show("Service installed or Same name other service!");
                              }
                         }
                         else
                         {
                              MessageBox.Show("File is exe ? ");
                         }
                    }
                    else
                    {
                         MessageBox.Show("Input is missing value!");
                    }

               }
               catch (ApplicationException ex)
               {
                    MessageBox.Show("Messages: " + ex.Message + " \n " + "Trace: " + ex.StackTrace);
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Messages: " + ex.Message + " \n " + "Trace: " + ex.StackTrace);
               }
          }
          private void bt_browser_Click(object sender, EventArgs e)
          {
               ofd_openfile.Filter = "Service files (*.exe) |*.exe|All files (*.*)|*.*";
               DialogResult result = ofd_openfile.ShowDialog();
               if (result == DialogResult.OK)
               {
                    txt_path.Text = ofd_openfile.FileName;
               }
          }

          private void bt_unstall_Click(object sender, EventArgs e)
          {
               try
               {
                    if (!string.IsNullOrEmpty(txt_name.Text) || !string.IsNullOrEmpty(txt_name.Text.Trim()) || !string.IsNullOrEmpty(txt_path.Text.Trim()))
                    {
                         if (ServiceInstaller.ServiceIsInstalled(txt_name.Text.Trim()))
                         {
                              ServiceInstaller.Uninstall(txt_name.Text.Trim());
                              MessageBox.Show("Success!");
                         }
                         else
                         {
                              MessageBox.Show("Not installed!");
                         }
                    }
                    else
                    {
                         MessageBox.Show("Input is missing service name!");
                    }
               }
               catch (ApplicationException ex)
               {
                    MessageBox.Show("Messages: " + ex.Message + " \n " + "Trace: " + ex.StackTrace);
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Messages: " + ex.Message + " \n " + "Trace: " + ex.StackTrace);
               }
          }

          private void txt_path_TextChanged(object sender, EventArgs e)
          {

          }


     }
}
