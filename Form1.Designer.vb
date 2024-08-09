<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichBoxSum = New System.Windows.Forms.RichTextBox()
        Me.RichBoxdeclining = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAssetCost = New System.Windows.Forms.TextBox()
        Me.TxtSalvageValue = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbUsefulLife = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RichBoxSum)
        Me.GroupBox1.Controls.Add(Me.RichBoxdeclining)
        Me.GroupBox1.Location = New System.Drawing.Point(337, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 281)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation Schedules"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sum-of-the-year's digits:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Double-declining balances:"
        '
        'RichBoxSum
        '
        Me.RichBoxSum.Location = New System.Drawing.Point(241, 75)
        Me.RichBoxSum.Name = "RichBoxSum"
        Me.RichBoxSum.Size = New System.Drawing.Size(175, 180)
        Me.RichBoxSum.TabIndex = 1
        Me.RichBoxSum.Text = ""
        '
        'RichBoxdeclining
        '
        Me.RichBoxdeclining.Location = New System.Drawing.Point(34, 75)
        Me.RichBoxdeclining.Name = "RichBoxdeclining"
        Me.RichBoxdeclining.Size = New System.Drawing.Size(190, 180)
        Me.RichBoxdeclining.TabIndex = 0
        Me.RichBoxdeclining.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Asset Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salvage Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Useful Life:"
        '
        'TxtAssetCost
        '
        Me.TxtAssetCost.Location = New System.Drawing.Point(103, 68)
        Me.TxtAssetCost.Name = "TxtAssetCost"
        Me.TxtAssetCost.Size = New System.Drawing.Size(136, 23)
        Me.TxtAssetCost.TabIndex = 4
        '
        'TxtSalvageValue
        '
        Me.TxtSalvageValue.Location = New System.Drawing.Point(103, 125)
        Me.TxtSalvageValue.Name = "TxtSalvageValue"
        Me.TxtSalvageValue.Size = New System.Drawing.Size(136, 23)
        Me.TxtSalvageValue.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(20, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Display depreciation schedules"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 52)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbUsefulLife
        '
        Me.CmbUsefulLife.FormattingEnabled = True
        Me.CmbUsefulLife.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CmbUsefulLife.Location = New System.Drawing.Point(103, 180)
        Me.CmbUsefulLife.Name = "CmbUsefulLife"
        Me.CmbUsefulLife.Size = New System.Drawing.Size(136, 23)
        Me.CmbUsefulLife.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbUsefulLife)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtSalvageValue)
        Me.Controls.Add(Me.TxtAssetCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "RGIT annual depreciation App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichBoxSum As RichTextBox
    Friend WithEvents RichBoxdeclining As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAssetCost As TextBox
    Friend WithEvents TxtSalvageValue As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CmbUsefulLife As ComboBox
End Class
