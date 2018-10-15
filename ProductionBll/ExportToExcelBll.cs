using ProductionDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionBll
{
    public partial class ExportToExcelBll
    {

        ExportToExcelDll ExportDate = new ExportToExcelDll();
        public bool ExportToExcel(string filename, DataGridView dgvList)
        {
            return ExportDate.GridToExcel(filename, dgvList);
        }

    }
}
