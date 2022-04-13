using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace DemoProject11_ReCreateLeaveForm_
{
    public partial class Frm_LeavePortal : Form
    {
        SqlCommand cmd;
        SqlConnection LeavePortalConnection;
        public Frm_LeavePortal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbBx_EmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComboBoxEmpName()
        {
            try
            {
                using (SqlConnection leavePortalConnection = new SqlConnection(@"data source = KARTHIKESEAN\MSSQL2016 ;database=LeaveApplication;Integrated Security =SSPI"))
                {
                    if (leavePortalConnection.State != ConnectionState.Open)
                    {
                        leavePortalConnection.Open();
                    }
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("dbo.EmpIDCOmboBox", leavePortalConnection) { CommandType = CommandType.StoredProcedure })
                        {
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            cmbBx_EmpName.DataSource = dt;
                            cmbBx_EmpName.DisplayMember = "EmpName";
                            cmbBx_EmpName.ValueMember = "EmpId";
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        if (leavePortalConnection.State == ConnectionState.Open)
                        {
                            leavePortalConnection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }                                                                   /*var binary max*/

        private void cmbBx_EmpName_Click(object sender, EventArgs e)
        {
            ComboBoxEmpName();
        }

        private void cmbBx_LeaveType_Click(object sender, EventArgs e)
        {
            ComboBoxLeaveType();
        }

        private void ComboBoxLeaveType()
        {
            try
            {
                using (SqlConnection LeavePortalConnection = new SqlConnection(@"Data Source = KARTHIKESEAN\MSSQL2016;DataBase=LeaveApplication;Integrated Security = SSPI"))
                {
                    if (LeavePortalConnection.State != ConnectionState.Open)
                    {
                        LeavePortalConnection.Open();
                    }
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("dbo.leaveTypeComboBox", LeavePortalConnection) { CommandType = CommandType.StoredProcedure })
                        {
                            DataTable dt = new DataTable();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            adp.Fill(dt);
                            cmbBx_LeaveType.DataSource = dt;
                            cmbBx_LeaveType.DisplayMember = "Description";
                            cmbBx_LeaveType.ValueMember = "LeaveTypeID";
                        }
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex);
                    }
                    finally
                    {
                        if (LeavePortalConnection.State == ConnectionState.Open)
                        {
                            LeavePortalConnection.Close();
                        }
                    }
                  }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }

        private void Frm_LeavePortal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            saveLeaveInfo();
            clear();
        }

        private void saveLeaveInfo()
        {
            try
            {
                using (SqlConnection LeavePortalConnections = new SqlConnection
                    ("Data source= MANAS-DAS\\SQLEXPRESS;database = Test ; integrated security = SSPI"))
                {
                    if (LeavePortalConnections.State != ConnectionState.Open)
                    {
                        LeavePortalConnections.Open();
                    }
                    try
                    {
                        using (cmd = new SqlCommand("InsertIntoLeaveForm", LeavePortalConnections) { CommandType = CommandType.StoredProcedure })
                        {
                            cmd.Parameters.AddWithValue("@eid", 1);
                            //cmd.Parameters.AddWithValue("@lid",cmbBx_LeaveType.SelectedValue);
                            //cmd.Parameters.AddWithValue("@from",dtpicker_from.Text);
                            //cmd.Parameters.AddWithValue("@to",dtpicker_to.Text);
                            //cmd.Parameters.AddWithValue("@desc",richTb_Des.Text);
                            conv_pic();
                            DataTable dt = new DataTable();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            adp.Fill(dt);
                            gridControl_LeavePortal.DataSource = dt;
                        }
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex);
                    }
                    finally
                    {
                        if (LeavePortalConnection.State == ConnectionState.Open)
                        {
                            LeavePortalConnections.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //clear();
            try
            {
                using (SqlConnection LeavePortalConnections = new SqlConnection
                    ("Data source= MANAS-DAS\\SQLEXPRESS;database = Test ; integrated security = SSPI"))
                {
                    if (LeavePortalConnections.State != ConnectionState.Open)
                    {
                        LeavePortalConnections.Open();
                    }
                    try
                    {
                        using (cmd = new SqlCommand("showImage", LeavePortalConnections) { CommandType = CommandType.StoredProcedure })
                        {
                            byte[] bytes = (byte[])cmd.ExecuteScalar();
                            if (bytes != null)
                            {
                                MemoryStream ms = new MemoryStream(bytes);
                                picBox_LeaveForm.Image = Image.FromStream(ms);
                            } 
                        }
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex);
                    }
                    finally
                    {
                        if (LeavePortalConnection.State == ConnectionState.Open)
                        {
                            LeavePortalConnections.Close();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void clear()
        {
            cmbBx_EmpName.Focus();
            cmbBx_EmpName.ResetText();
            cmbBx_LeaveType.ResetText();
            richTb_Des.Clear();
            txt_imageName.Clear();
            picBox_LeaveForm.Image = null;
        }

        private void btn_picLoader_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.png;*.jpg;*.gif;*.jpeg;*.bmp;*.jfif)|*.png;*.jpg;*.gif;*.jpeg;*.bmp;*.jfif";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                picBox_LeaveForm.Image = new Bitmap(openFileDialog1.FileName);
                txt_imageName.Text = selectedFile;
            }
        }

        private void conv_pic()
        {
            if (picBox_LeaveForm.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                picBox_LeaveForm.Image.Save(ms, ImageFormat.Png);
                byte[] pic_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(pic_array, 0, pic_array.Length);
                cmd.Parameters.AddWithValue("@image", pic_array);
            }
        }
        
    }
}
