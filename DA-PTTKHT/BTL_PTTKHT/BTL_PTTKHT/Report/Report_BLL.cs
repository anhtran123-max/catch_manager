using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_PTTKHT
{
    class Report_BLL
    {
        Report_DAL dalReport;

        public Report_BLL()
        {
            dalReport = new Report_DAL();
        }

        public DataSet getReport(tbl_Report report)
        {
            return dalReport.getReport(report);
        }
    }
}
