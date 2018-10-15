using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Windows.Forms;

namespace ProductionDll
{
    public class ExportToExcelDll
    {
        public bool GridToExcel(string fileName,DataGridView dgvList)
        {
            if(dgvList.Rows.Count == 0)
            {
                return false;
            }

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Excel 2003格式|*.xls";
            saveFile.FileName = fileName + DateTime.Now.ToString("yyyyMMddHH");

            if(saveFile.ShowDialog() != DialogResult.OK)
            {
                return false ;
            }

            HSSFWorkbook workbook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(fileName);

            HSSFRow headRow = (HSSFRow)sheet.CreateRow(0);
            for (int i = 0; i < dgvList.ColumnCount ; i++)
            {
                HSSFCell headCell = (HSSFCell)headRow.CreateCell(i, CellType.String);
                headCell.SetCellValue(dgvList.Columns[i].HeaderText); 

            }

            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                HSSFRow row = (HSSFRow)sheet.CreateRow(i + 1);
                for(int j = 0;j< dgvList.Columns.Count;j++)
                {
                    HSSFCell cell = (HSSFCell)row.CreateCell(j);

                    if (dgvList.Rows[i].Cells[j].Value == null)
                    {
                        cell.SetCellType(CellType.Blank);
                    }
                    else
                    {
                        if(dgvList.Rows[i].Cells[j].ValueType.FullName.Contains("System.Int32"))
                        {
                            cell.SetCellValue(Convert.ToInt32(dgvList.Rows[i].Cells[j].Value));
                        }
                        else if (dgvList.Rows[i].Cells[j].ValueType.FullName.Contains("System.String"))
                        {
                            cell.SetCellValue(dgvList.Rows[i].Cells[j].Value.ToString());
                        }
                        else if (dgvList.Rows[i].Cells[j].ValueType.FullName.Contains("System.Single"))
                        {
                            cell.SetCellValue(Convert.ToSingle(dgvList.Rows[i].Cells[j].Value));
                        }
                        else if (dgvList.Rows[i].Cells[j].ValueType.FullName.Contains("System.Double"))
                        {
                            cell.SetCellValue(Convert.ToDouble(dgvList.Rows[i].Cells[j].Value));
                        }
                        else if (dgvList.Rows[i].Cells[j].ValueType.FullName.Contains("System.Decimal"))
                        {
                            cell.SetCellValue(Convert.ToDouble(dgvList.Rows[i].Cells[j].Value));
                        }
                        else if (dgvList.Rows[i].Cells[j].ValueType.FullName.Contains("System.DateTime"))
                        {
                            cell.SetCellValue(Convert.ToDateTime(dgvList.Rows[i].Cells[j].Value).ToString("yyyy-MM-dd"));
                        }

                    }
                }

            }

            for (int i=0;i < dgvList.Columns.Count;i++)
            {
                sheet.AutoSizeColumn(i);

            }

            using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create))
            {
                workbook.Write(fs);
            }



            return true;


        }


    }
}
