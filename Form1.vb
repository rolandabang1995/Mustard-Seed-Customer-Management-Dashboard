Imports CrystalDecisions.CrystalReports.Engine
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\ABANG 5-30-20\source\repos\Mustard Seed Customer Management Dashboard\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\ABANG 5-30-20\source\repos\Mustard Seed Customer Management Dashboard\CrystalReport2.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\ABANG 5-30-20\source\repos\Mustard Seed Customer Management Dashboard\CrystalReport3.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub


End Class
