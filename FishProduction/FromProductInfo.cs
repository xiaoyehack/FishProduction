using ProductionBll;
using ProductionModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FishProduction
{
    public partial class FromProductInfo : Form
    {

        private static FromProductInfo _form;


        public FromProductInfo()
        {
            InitializeComponent();
        }

        private static FromProductInfo Create()
        {
            if(_form == null)
            {
                _form = new FromProductInfo();

            }
            return _form;

        }

        ProductInfoBll mibll = new ProductInfoBll();

        private void FromProductInfo_Load(object sender, EventArgs e)
        {
            monthSelect.Hide();
            LoadList();
        }

        private void LoadList()
        {
            //使用键值对存储条件

            Dictionary<string, string> dic = new Dictionary<string, string>();

            if(txtBoardidSearch.Text != "")
            {
                dic.Add("boardid", txtBoardidSearch.Text);
            }

            if(txtSimIdSearch.Text != "")
            {
                dic.Add("SimId", txtSimIdSearch.Text);
            }


            dgvList.AutoGenerateColumns = false;

            dgvList.DataSource = mibll.GetList(dic);

            //设置某行选中
            if (dgvSelectedIndex >= 0)
            {
                dgvList.Rows[dgvSelectedIndex].Selected = true;
            }
        }

        private void txtBoardidSearch_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtSimIdSearch_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void butDisplayAll_Click(object sender, EventArgs e)
        {
            txtSimIdSearch.Text = "";
            txtBoardidSearch.Text = ""; 
            LoadList();
        }

        private int dgvSelectedIndex = -1;
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSelectedIndex = e.RowIndex;

            //获取点击的行
            var row = dgvList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtBoardAdd.Text = row.Cells[1].Value.ToString().Substring(2);
            txtSimIdAdd.Text = row.Cells[2].Value.ToString();
            txtSoftCombox.Text = row.Cells[3].Value.ToString();

            txtProdate.Text = row.Cells[4].Value.ToString();
            txtOther.Text = row.Cells[5].Value.ToString();
            txtNote.Text = row.Cells[6].Value.ToString();

            butSave.Text = "修改";



            

        }

        private void txtProdate_Enter(object sender, EventArgs e)
        {
            monthSelect.Show();

        }

        private void monthSelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtProdate.Text = monthSelect.SelectionEnd.ToString();
            monthSelect.Hide();
        }

        private void txtProdate_Leave(object sender, EventArgs e)
        {
            monthSelect.Hide();
        }

        private void butDelect_Click(object sender, EventArgs e)
        {

        
            try
            {
                int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (mibll.Remove(id))
                {
                    LoadList();
                }
                else
                {
                    MessageBox.Show("删除失败，请稍后重试!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(  ex.Message); 
                    
            }
               
 
            
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtBoardAdd.Text = "";
            txtSimIdAdd.Text = "";
            txtSoftCombox.Text = "";

            txtProdate.Text = "";
            txtOther.Text = "";
            txtNote.Text = "";

            butSave.Text = "添加";

            txtId.Text = "添加时无编号";
        }

        private void butSave_Click(object sender, EventArgs e)
         {

            try
            {
                if (txtBoardAdd.Text.Length != 0x08)
                {
                    MessageBox.Show("请检查板子ID输入长度是否正确");
                    txtBoardAdd.Focus();
                    return;
                }
                else if(txtSimIdAdd.Text.Length < 10)
                {
                    MessageBox.Show("请检查SIM卡输入长度是否正确");
                    txtSimIdAdd.Focus();
                    return;
                }
                else if (txtProdate.Text.Length < 0x10)
                {
                    MessageBox.Show("请检查日期输入是否正确");
                    txtProdate.Focus();
                    return;
                }
            



                //接收用户输入信息

                ProductInfo mi = new ProductInfo()
                {
                    BoardId ="0x" + txtBoardAdd.Text,
                    SimId = txtSimIdAdd.Text,
                    SofeEdti = txtSoftCombox.Text,
                    Prodate = Convert.ToDateTime(txtProdate.Text),
                    OtherOne = txtOther.Text,
                    OtherTwo = txtNote.Text
                };

                if (txtId.Text.Equals("添加时无编号"))
                {
                    if (mibll.Add(mi))
                    {
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("添加失败，请稍后重试");
                    }

                }
                else
                {
                    mi.ID = int.Parse(txtId.Text);
                    if (mibll.Edit(mi))
                    {
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                 
            }
 
            //值有效判断

        }


        ExportToExcelBll exportBll = new ExportToExcelBll();
        private void butExport_Click(object sender, EventArgs e)
        {
            if(exportBll.ExportToExcel("数据表格", dgvList))
            {
                MessageBox.Show("导出成功！", "导出提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
