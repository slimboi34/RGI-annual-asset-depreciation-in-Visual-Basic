Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichBoxdeclining.SelectedText = "Year" + vbTab + "Depreciation" + vbNewLine
        RichBoxSum.SelectedText = "Year" + vbTab + "Depreciation" + vbNewLine

        Dim asset As Double
        Dim salvage As Double
        Dim life As Double
        asset = Val(TxtAssetCost.Text)
        salvage = Val(TxtSalvageValue.Text)
        life = Val(CmbUsefulLife.Text)

        Dim DDB As Double
        Dim SYD As Double

        For a = 1 To life
            DDB = Financial.DDB(asset, salvage, life, a)
            SYD = Financial.SYD(asset, salvage, life, a)

            DDB = Math.Round([DDB], 2)
            SYD = Math.Round([SYD], 2)

            RichBoxdeclining.SelectedText = a.ToString + vbTab + DDB.ToString("0.00") + vbNewLine
            RichBoxSum.SelectedText = a.ToString + vbTab + SYD.ToString("0.00") + vbNewLine
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
