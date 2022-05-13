<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RhariniDataSet = New student_admission.rhariniDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c1 = New System.Windows.Forms.ComboBox()
        Me.c5 = New System.Windows.Forms.ComboBox()
        Me.c6 = New System.Windows.Forms.ComboBox()
        Me.c7 = New System.Windows.Forms.ComboBox()
        Me.c8 = New System.Windows.Forms.ComboBox()
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.c3 = New System.Windows.Forms.ComboBox()
        Me.c4 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CTableAdapter = New student_admission.rhariniDataSetTableAdapters.cTableAdapter()
        CType(Me.CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RhariniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(407, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Course Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No of years"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Admission fees"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(721, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Total"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aquamarine
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(457, 662)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 33)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "add course"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aquamarine
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(790, 662)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 31)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Courseid", True))
        Me.TextBox1.Location = New System.Drawing.Point(291, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 12
        '
        'CBindingSource
        '
        Me.CBindingSource.DataMember = "c"
        Me.CBindingSource.DataSource = Me.RhariniDataSet
        '
        'RhariniDataSet
        '
        Me.RhariniDataSet.DataSetName = "rhariniDataSet"
        Me.RhariniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "No of years", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2 ", "3 "})
        Me.ComboBox1.Location = New System.Drawing.Point(295, 250)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Admission fees", True))
        Me.TextBox2.Location = New System.Drawing.Point(295, 333)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(597, 565)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total seats"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Total seats", True))
        Me.TextBox3.Location = New System.Drawing.Point(751, 566)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 20)
        Me.TextBox3.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Management seats"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(334, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "General seats"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(359, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 19)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "BC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(355, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 19)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "MBC"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(355, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "SC/ST"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Military seats"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Sport seats"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Special ability seats"
        '
        'c1
        '
        Me.c1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Managements seats", True))
        Me.c1.FormattingEnabled = True
        Me.c1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.c1.Location = New System.Drawing.Point(163, 36)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(121, 30)
        Me.c1.TabIndex = 30
        '
        'c5
        '
        Me.c5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "General seats", True))
        Me.c5.FormattingEnabled = True
        Me.c5.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60"})
        Me.c5.Location = New System.Drawing.Point(458, 36)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(121, 30)
        Me.c5.TabIndex = 31
        '
        'c6
        '
        Me.c6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "BC", True))
        Me.c6.FormattingEnabled = True
        Me.c6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        Me.c6.Location = New System.Drawing.Point(458, 96)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(121, 30)
        Me.c6.TabIndex = 32
        '
        'c7
        '
        Me.c7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "MBC", True))
        Me.c7.FormattingEnabled = True
        Me.c7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        Me.c7.Location = New System.Drawing.Point(458, 160)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(121, 30)
        Me.c7.TabIndex = 33
        '
        'c8
        '
        Me.c8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "SC/ST", True))
        Me.c8.FormattingEnabled = True
        Me.c8.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.c8.Location = New System.Drawing.Point(458, 227)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(121, 30)
        Me.c8.TabIndex = 34
        '
        'c2
        '
        Me.c2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Military seats", True))
        Me.c2.FormattingEnabled = True
        Me.c2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.c2.Location = New System.Drawing.Point(163, 96)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(121, 30)
        Me.c2.TabIndex = 35
        '
        'c3
        '
        Me.c3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "sports seats", True))
        Me.c3.FormattingEnabled = True
        Me.c3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.c3.Location = New System.Drawing.Point(163, 160)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(121, 30)
        Me.c3.TabIndex = 36
        '
        'c4
        '
        Me.c4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Handicap seats", True))
        Me.c4.FormattingEnabled = True
        Me.c4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.c4.Location = New System.Drawing.Point(163, 227)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(121, 30)
        Me.c4.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.c1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.c4)
        Me.GroupBox1.Controls.Add(Me.c2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.c8)
        Me.GroupBox1.Controls.Add(Me.c3)
        Me.GroupBox1.Controls.Add(Me.c7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.c6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.c5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(495, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 282)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seats available"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(133, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 19)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Course name"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Course name", True))
        Me.TextBox4.Location = New System.Drawing.Point(291, 177)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(125, 20)
        Me.TextBox4.TabIndex = 40
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Aquamarine
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(626, 662)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 33)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Save course"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CTableAdapter
        '
        Me.CTableAdapter.ClearBeforeFill = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1235, 733)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "add course detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RhariniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents c1 As System.Windows.Forms.ComboBox
    Friend WithEvents c5 As System.Windows.Forms.ComboBox
    Friend WithEvents c6 As System.Windows.Forms.ComboBox
    Friend WithEvents c7 As System.Windows.Forms.ComboBox
    Friend WithEvents c8 As System.Windows.Forms.ComboBox
    Friend WithEvents c2 As System.Windows.Forms.ComboBox
    Friend WithEvents c3 As System.Windows.Forms.ComboBox
    Friend WithEvents c4 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RhariniDataSet As student_admission.rhariniDataSet
    Friend WithEvents CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTableAdapter As student_admission.rhariniDataSetTableAdapters.cTableAdapter
End Class
