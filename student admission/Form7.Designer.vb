<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RhariniDataSet = New student_admission.rhariniDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Course Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Of  Years"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Admission fees"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Management seats"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "General seats"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "BC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(318, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "MBC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(318, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SC/ST"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Military seats"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Sport seats"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Special ability seats"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(562, 459)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Total seats"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "No of years", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2 ", "3 "})
        Me.ComboBox2.Location = New System.Drawing.Point(271, 238)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox2.TabIndex = 14
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
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Admission fees", True))
        Me.TextBox1.Location = New System.Drawing.Point(271, 326)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 15
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Managements seats", True))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox3.Location = New System.Drawing.Point(152, 32)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox3.TabIndex = 16
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "General seats", True))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60"})
        Me.ComboBox4.Location = New System.Drawing.Point(422, 28)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox4.TabIndex = 17
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "BC", True))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        Me.ComboBox5.Location = New System.Drawing.Point(422, 82)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox5.TabIndex = 18
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "MBC", True))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        Me.ComboBox6.Location = New System.Drawing.Point(422, 152)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox6.TabIndex = 19
        '
        'ComboBox7
        '
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "SC/ST", True))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox7.Location = New System.Drawing.Point(422, 213)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox7.TabIndex = 20
        '
        'ComboBox8
        '
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Military seats", True))
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.ComboBox8.Location = New System.Drawing.Point(152, 94)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox8.TabIndex = 21
        '
        'ComboBox9
        '
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "sports seats", True))
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.ComboBox9.Location = New System.Drawing.Point(152, 156)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox9.TabIndex = 22
        '
        'ComboBox10
        '
        Me.ComboBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Handicap seats", True))
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.ComboBox10.Location = New System.Drawing.Point(152, 217)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox10.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SandyBrown
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(726, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Total"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Total seats", True))
        Me.TextBox2.Location = New System.Drawing.Point(722, 458)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SandyBrown
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(518, 522)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 33)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SandyBrown
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(726, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 33)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Courseid", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"104", "105", "106", "107", "108", "109", "110"})
        Me.ComboBox1.Location = New System.Drawing.Point(271, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(100, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 19)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Course name"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CBindingSource, "Course name", True))
        Me.TextBox3.Location = New System.Drawing.Point(271, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ComboBox9)
        Me.GroupBox1.Controls.Add(Me.ComboBox10)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Me.ComboBox7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBox6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(495, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 268)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seats available"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(414, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 31)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CTableAdapter
        '
        Me.CTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1129, 582)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form7"
        Me.Text = "Edit course details"
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RhariniDataSet As student_admission.rhariniDataSet
    Friend WithEvents CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTableAdapter As student_admission.rhariniDataSetTableAdapters.cTableAdapter
End Class
