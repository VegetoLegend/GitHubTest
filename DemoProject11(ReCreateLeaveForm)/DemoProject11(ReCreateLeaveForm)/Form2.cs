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
    public partial class Frm_ApprovalPortal : Form
    {
        SqlCommand cmd;
        SqlConnection ApprovalConnection ;
        int LeaveId;
        public Frm_ApprovalPortal()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ApprovalPortal_Load(object sender, EventArgs e)
        {
            StatusOpenData();
        }

        private void StatusOpenData()
        {
            try
            {
                using (ApprovalConnection = new SqlConnection(@"data source = KARTHIKESEAN\MSSQL2016;Database= LeaveApplication;Integrated Security= SSPI"))
                {
                    if (ApprovalConnection.State != ConnectionState.Open)
                    {
                        ApprovalConnection.Open();
                    }
                    try
                    {
                        using (cmd = new SqlCommand("dbo.forApprovalPortal", ApprovalConnection) { CommandType = CommandType.StoredProcedure })
                        {
                            DataTable dt = new DataTable();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            adp.Fill(dt);
                            gridControl_ApprovalPortal.DataSource = dt;
                        }
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex);
                    }
                    finally
                    {
                        if (ApprovalConnection.State == ConnectionState.Open)
                        {
                            ApprovalConnection.Close();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            DataTable ndt = getSelectedData();
            ApprovalStatus( ndt , 2 );
            StatusOpenData();
        }

        private void ApprovalStatus(DataTable ndt ,int StatusId )
        {
            try
            {
                using ( ApprovalConnection = new SqlConnection(@"data source = KARTHIKESEAN\MSSQL2016;Database= LeaveApplication;Integrated Security= SSPI"))
                {
                    if (ApprovalConnection.State != ConnectionState.Open)
                    {
                        ApprovalConnection.Open();
                    }
                    try
                    {
                        using (cmd = new SqlCommand("UpdateApprovalSheet", ApprovalConnection) { CommandType = CommandType.StoredProcedure })
                        {

                            cmd.Parameters.AddWithValue("@userLeaveID",ndt);
                            cmd.Parameters.AddWithValue("@StatusId", StatusId);
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            cmd.ExecuteNonQuery();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        if (ApprovalConnection.State == ConnectionState.Open)
                        {
                            ApprovalConnection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private DataTable getSelectedData()
        {
            DataTable dt = (DataTable)gridControl_ApprovalPortal.DataSource;
            DataTable ndt = new DataTable();
            ndt.Columns.Add("LeaveID",typeof(Int32));

            foreach (DataRow dr in dt.Rows)
            {
                bool isSelect = Convert.ToBoolean(dr["Chkvlue"]);
                if (isSelect)
                {
                    DataRow drr = ndt.NewRow();
                    drr["LeaveID"] = Convert.ToInt32(dr["LeaveID"]);
                    ndt.Rows.Add(drr);
                }
            }

            return ndt;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DataTable ndt = getSelectedData();
            ApprovalStatus(ndt, 3);
            StatusOpenData();
        }

        private void gridView_ApprovalPortal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LeaveId = Convert.ToInt32(gridView_ApprovalPortal.GetRowCellValue(e.FocusedRowHandle, "LeaveID"));
            picBox_ApprovalFrom.Image = null;
            if (LeaveId > 0)
            {
                try
                {
                    using (ApprovalConnection = new SqlConnection(@"data source = KARTHIKESEAN\MSSQL2016;Database= LeaveApplication;Integrated Security= SSPI"))
                    {
                        if (ApprovalConnection.State != ConnectionState.Open)
                        {
                            ApprovalConnection.Open();
                        }
                        try
                        {
                            using (cmd = new SqlCommand("dbo.SelectPictureByEmployeeID", ApprovalConnection) { CommandType = CommandType.StoredProcedure })
                            {
                                cmd.Parameters.AddWithValue("@lid", LeaveId);
                                byte[] bytes = (byte[])cmd.ExecuteScalar();
                                if (bytes != null)
                                {
                                    MemoryStream ms = new MemoryStream(bytes);
                                    picBox_ApprovalFrom.Image = Image.FromStream(ms);
                                } 
                            }
                        }
                        catch (Exception Ex)
                        {
                            Console.WriteLine(Ex);
                        }
                        finally
                        {
                            if (ApprovalConnection.State == ConnectionState.Open)
                            {
                                ApprovalConnection.Close();
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex);
                }
            }
        }

        private void gridView_ApprovalPortal_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }
    }
}
