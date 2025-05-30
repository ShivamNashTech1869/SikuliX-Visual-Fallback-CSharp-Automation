using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;

namespace MyNamespace.Base
{
    public static class ExtentReportManager
    {
        private static ExtentReports extent = null!;
        private static ExtentSparkReporter sparkReporter = null!;

        public static ExtentReports GetExtentReports()
        {
            if (extent == null)
            {
                string reportPath = $"{AppDomain.CurrentDomain.BaseDirectory}ExtentReports/SparkReport.html";
                sparkReporter = new ExtentSparkReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Tester", "Shivam Singh");
            }
            return extent;
        }
    }
}
