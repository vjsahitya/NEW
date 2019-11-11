using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2
{
    public class policyInformation
    {
        public int policyId { get; set; }
        public string policyName { get; set; }

        public bool insertPolicyTable(policyInformation em)
        {
            // Insert into employee table.
            return true;
        }
        /// <summary>
        /// Method to generate report
        /// </summary>
        
        public void GenerateReport(policyInformation em)
        {
            // Report generation with employee data using crystal report.
        }
    }

    public class openClose
    {

        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(policyInformation em)

        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }

        static void Main(string[] args)
        {
        }
    }


    public class IReportGeneration
    {
        public virtual void GenerateReport(policyInformation em)
        {
            // From base
        }
    }
    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(policyInformation em)
        {
            // Generate crystal report.
        }
    }
    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(policyInformation em)
        {
            // Generate PDF report.
        }
    }
}
