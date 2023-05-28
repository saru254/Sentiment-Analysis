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
        Label1 = New Label()
        txtInput = New TextBox()
        btnAnalyze = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(275, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 20)
        Label1.TabIndex = 0
        Label1.Text = "Sentiment Analysis Tool"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(275, 144)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(177, 23)
        txtInput.TabIndex = 1
        ' 
        ' btnAnalyze
        ' 
        btnAnalyze.Location = New Point(321, 216)
        btnAnalyze.Name = "btnAnalyze"
        btnAnalyze.Size = New Size(75, 23)
        btnAnalyze.TabIndex = 2
        btnAnalyze.Text = "Analyze"
        btnAnalyze.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(321, 279)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(66, 15)
        lblResult.TabIndex = 3
        lblResult.Text = "Sentiment"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btnAnalyze)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "sentiment analysis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents lblResult As Label
End Class
