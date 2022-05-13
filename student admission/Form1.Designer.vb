<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.k = New System.Windows.Forms.Button()
        Me.ext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'k
        '
        Me.k.BackColor = System.Drawing.Color.Gray
        Me.k.Font = New System.Drawing.Font("Wide Latin", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.k.ForeColor = System.Drawing.Color.Lime
        Me.k.Location = New System.Drawing.Point(462, 431)
        Me.k.Name = "k"
        Me.k.Size = New System.Drawing.Size(134, 38)
        Me.k.TabIndex = 0
        Me.k.Text = "LOGIN"
        Me.k.UseVisualStyleBackColor = False
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.Color.Gray
        Me.ext.Font = New System.Drawing.Font("Wide Latin", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ext.ForeColor = System.Drawing.Color.Lime
        Me.ext.Location = New System.Drawing.Point(688, 431)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(140, 38)
        Me.ext.TabIndex = 1
        Me.ext.Text = "LOGOUT"
        Me.ext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(297, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(810, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ETHIRAJ COLLEGE ADMISSION SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(417, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(419, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(714, 182)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(151, 20)
        Me.uname.TabIndex = 5
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(714, 301)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(151, 20)
        Me.pass.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(194, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 654)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ext)
        Me.Controls.Add(Me.k)
        Me.Name = "Form1"
        Me.Text = "Ethiraj login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents k As System.Windows.Forms.Button
    Friend WithEvents ext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents uname As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
