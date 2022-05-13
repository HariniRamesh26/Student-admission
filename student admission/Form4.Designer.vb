<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(410, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student master"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.HotPink
        Me.Button1.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(806, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Make admission"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.HotPink
        Me.Button2.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(601, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(259, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Edit admission"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.HotPink
        Me.Button3.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(397, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 48)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete admission"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.HotPink
        Me.Button4.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(12, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 42)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.HotPink
        Me.Button5.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Lime
        Me.Button5.Location = New System.Drawing.Point(169, 341)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(259, 42)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "View"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1100, 494)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "student master form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
