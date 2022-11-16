<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_streamonline
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.btn_plan = New System.Windows.Forms.Button()
        Me.btn_display = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.txt_dispay = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_signup
        '
        Me.btn_signup.Location = New System.Drawing.Point(12, 12)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(91, 23)
        Me.btn_signup.TabIndex = 0
        Me.btn_signup.Text = "SIGN UP"
        Me.btn_signup.UseVisualStyleBackColor = True
        '
        'btn_plan
        '
        Me.btn_plan.Location = New System.Drawing.Point(12, 61)
        Me.btn_plan.Name = "btn_plan"
        Me.btn_plan.Size = New System.Drawing.Size(91, 23)
        Me.btn_plan.TabIndex = 1
        Me.btn_plan.Text = "CHOOSE PLAN"
        Me.btn_plan.UseVisualStyleBackColor = True
        '
        'btn_display
        '
        Me.btn_display.Location = New System.Drawing.Point(12, 103)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(91, 23)
        Me.btn_display.TabIndex = 2
        Me.btn_display.Text = "DISPLAY PLAN"
        Me.btn_display.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(12, 185)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(91, 23)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'txt_dispay
        '
        Me.txt_dispay.Location = New System.Drawing.Point(140, 12)
        Me.txt_dispay.Multiline = True
        Me.txt_dispay.Name = "txt_dispay"
        Me.txt_dispay.Size = New System.Drawing.Size(347, 196)
        Me.txt_dispay.TabIndex = 4
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(12, 145)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(91, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_streamonline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_dispay)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.btn_plan)
        Me.Controls.Add(Me.btn_signup)
        Me.Name = "frm_streamonline"
        Me.Text = "streamonline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_signup As Button
    Friend WithEvents btn_plan As Button
    Friend WithEvents btn_display As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt_dispay As TextBox
    Friend WithEvents btn_clear As Button
End Class
