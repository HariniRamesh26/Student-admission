<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet = New student_admission.studentDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.AddTableAdapter = New student_admission.studentDataSetTableAdapters.addTableAdapter()
        CType(Me.AddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Admission"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Register No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(339, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Student name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(338, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Father name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(338, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phone no"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "DOB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(348, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Sex"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(330, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Community"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(320, 517)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Admission date"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(430, 621)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(612, 621)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 33)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "regno", True))
        Me.TextBox1.Location = New System.Drawing.Point(482, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 13
        '
        'AddBindingSource
        '
        Me.AddBindingSource.DataMember = "add"
        Me.AddBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "course", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BCA", "MCA", "BCOM", "MCOM", "MBA", "ENGLISH", "PHYSICS", "CHEMISTRY", "MICROBIOLOGY", "ECONOMICS", "BBA", "VISCOM", "TOURISM"})
        Me.ComboBox1.Location = New System.Drawing.Point(482, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "stuname", True))
        Me.TextBox2.Location = New System.Drawing.Point(482, 151)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "father", True))
        Me.TextBox3.Location = New System.Drawing.Point(482, 195)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(118, 20)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "address", True))
        Me.TextBox4.Location = New System.Drawing.Point(482, 242)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(118, 20)
        Me.TextBox4.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "phnum", True))
        Me.TextBox5.Location = New System.Drawing.Point(482, 287)
        Me.TextBox5.MaxLength = 10
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(118, 20)
        Me.TextBox5.TabIndex = 20
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "sex", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox2.Location = New System.Drawing.Point(482, 397)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "comm", True))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"MBC", "BC", "SC/ST", "OC"})
        Me.ComboBox3.Location = New System.Drawing.Point(485, 454)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(250, 621)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 33)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "dob", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(482, 341)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "admdate", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(485, 517)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(345, 577)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Fees paid"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddBindingSource, "feepaid", True))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"yes", "no"})
        Me.ComboBox4.Location = New System.Drawing.Point(510, 572)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 27
        '
        'AddTableAdapter
        '
        Me.AddTableAdapter.ClearBeforeFill = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1189, 666)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Make admission"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents StudentDataSet As student_admission.studentDataSet
    Friend WithEvents AddBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddTableAdapter As student_admission.studentDataSetTableAdapters.addTableAdapter
End Class
