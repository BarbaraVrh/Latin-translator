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
        btnLeft = New Button()
        btnMedium = New Button()
        btnRight = New Button()
        btnExit = New Button()
        Label1 = New Label()
        lblMessage = New Label()
        SuspendLayout()
        ' 
        ' btnLeft
        ' 
        btnLeft.Location = New Point(75, 218)
        btnLeft.Name = "btnLeft"
        btnLeft.Size = New Size(131, 50)
        btnLeft.TabIndex = 0
        btnLeft.Text = "Sinister"
        btnLeft.UseVisualStyleBackColor = True
        ' 
        ' btnMedium
        ' 
        btnMedium.Location = New Point(267, 218)
        btnMedium.Name = "btnMedium"
        btnMedium.Size = New Size(131, 50)
        btnMedium.TabIndex = 1
        btnMedium.Text = "Medium"
        btnMedium.UseVisualStyleBackColor = True
        ' 
        ' btnRight
        ' 
        btnRight.Location = New Point(455, 218)
        btnRight.Name = "btnRight"
        btnRight.Size = New Size(131, 50)
        btnRight.TabIndex = 2
        btnRight.Text = "Dexter"
        btnRight.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(267, 314)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(131, 50)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(291, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 4
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.None
        lblMessage.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblMessage.Location = New Point(164, 51)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(309, 90)
        lblMessage.TabIndex = 5
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(665, 384)
        Controls.Add(lblMessage)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnRight)
        Controls.Add(btnMedium)
        Controls.Add(btnLeft)
        Name = "Form1"
        Text = "Latin Translator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLeft As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMessage As Label
End Class
