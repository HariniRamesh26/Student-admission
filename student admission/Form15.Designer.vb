<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RegnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeepaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet1 = New student_admission.studentDataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AddTableAdapter = New student_admission.studentDataSet1TableAdapters.addTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student reports"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegnoDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.StunameDataGridViewTextBoxColumn, Me.FatherDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhnumDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CommDataGridViewTextBoxColumn, Me.AdmdateDataGridViewTextBoxColumn, Me.FeepaidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AddBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(53, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1014, 262)
        Me.DataGridView1.TabIndex = 1
        '
        'RegnoDataGridViewTextBoxColumn
        '
        Me.RegnoDataGridViewTextBoxColumn.DataPropertyName = "regno"
        Me.RegnoDataGridViewTextBoxColumn.HeaderText = "regno"
        Me.RegnoDataGridViewTextBoxColumn.Name = "RegnoDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'StunameDataGridViewTextBoxColumn
        '
        Me.StunameDataGridViewTextBoxColumn.DataPropertyName = "stuname"
        Me.StunameDataGridViewTextBoxColumn.HeaderText = "stuname"
        Me.StunameDataGridViewTextBoxColumn.Name = "StunameDataGridViewTextBoxColumn"
        '
        'FatherDataGridViewTextBoxColumn
        '
        Me.FatherDataGridViewTextBoxColumn.DataPropertyName = "father"
        Me.FatherDataGridViewTextBoxColumn.HeaderText = "father"
        Me.FatherDataGridViewTextBoxColumn.Name = "FatherDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhnumDataGridViewTextBoxColumn
        '
        Me.PhnumDataGridViewTextBoxColumn.DataPropertyName = "phnum"
        Me.PhnumDataGridViewTextBoxColumn.HeaderText = "phnum"
        Me.PhnumDataGridViewTextBoxColumn.Name = "PhnumDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'CommDataGridViewTextBoxColumn
        '
        Me.CommDataGridViewTextBoxColumn.DataPropertyName = "comm"
        Me.CommDataGridViewTextBoxColumn.HeaderText = "comm"
        Me.CommDataGridViewTextBoxColumn.Name = "CommDataGridViewTextBoxColumn"
        '
        'AdmdateDataGridViewTextBoxColumn
        '
        Me.AdmdateDataGridViewTextBoxColumn.DataPropertyName = "admdate"
        Me.AdmdateDataGridViewTextBoxColumn.HeaderText = "admdate"
        Me.AdmdateDataGridViewTextBoxColumn.Name = "AdmdateDataGridViewTextBoxColumn"
        '
        'FeepaidDataGridViewTextBoxColumn
        '
        Me.FeepaidDataGridViewTextBoxColumn.DataPropertyName = "feepaid"
        Me.FeepaidDataGridViewTextBoxColumn.HeaderText = "feepaid"
        Me.FeepaidDataGridViewTextBoxColumn.Name = "FeepaidDataGridViewTextBoxColumn"
        '
        'AddBindingSource
        '
        Me.AddBindingSource.DataMember = "add"
        Me.AddBindingSource.DataSource = Me.StudentDataSet1
        '
        'StudentDataSet1
        '
        Me.StudentDataSet1.DataSetName = "studentDataSet1"
        Me.StudentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(484, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(393, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(557, 543)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 39)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 455)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student count"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(546, 452)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'AddTableAdapter
        '
        Me.AddTableAdapter.ClearBeforeFill = True
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1305, 686)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form15"
        Me.Text = "student reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StudentDataSet1 As student_admission.studentDataSet1
    Friend WithEvents AddBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddTableAdapter As student_admission.studentDataSet1TableAdapters.addTableAdapter
    Friend WithEvents RegnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StunameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeepaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
