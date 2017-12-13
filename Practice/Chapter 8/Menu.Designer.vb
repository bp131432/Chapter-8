<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnPlane = New System.Windows.Forms.Button()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.btnFriends = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlane
        '
        Me.btnPlane.Location = New System.Drawing.Point(108, 32)
        Me.btnPlane.Name = "btnPlane"
        Me.btnPlane.Size = New System.Drawing.Size(75, 23)
        Me.btnPlane.TabIndex = 0
        Me.btnPlane.Text = "Plane"
        Me.btnPlane.UseVisualStyleBackColor = True
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(108, 95)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(75, 23)
        Me.btnNumber.TabIndex = 1
        Me.btnNumber.Text = "Number"
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'btnFriends
        '
        Me.btnFriends.Location = New System.Drawing.Point(108, 151)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.Size = New System.Drawing.Size(75, 23)
        Me.btnFriends.TabIndex = 2
        Me.btnFriends.Text = "Friends"
        Me.btnFriends.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnFriends)
        Me.Controls.Add(Me.btnNumber)
        Me.Controls.Add(Me.btnPlane)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlane As System.Windows.Forms.Button
    Friend WithEvents btnNumber As System.Windows.Forms.Button
    Friend WithEvents btnFriends As System.Windows.Forms.Button
End Class
