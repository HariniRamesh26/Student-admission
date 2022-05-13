<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.StudentDataSet = New student_admission.studentDataSet()
        Me.AddTableAdapter = New student_admission.studentDataSetTableAdapters.addTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "View student details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegnoDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.StunameDataGridViewTextBoxColumn, Me.FatherDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhnumDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CommDataGridViewTextBoxColumn, Me.AdmdateDataGridViewTextBoxColumn, Me.FeepaidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AddBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1142, 268)
        Me.DataGridView1.TabIndex = 3
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
        Me.AddBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddTableAdapter
        '
        Me.AddTableAdapter.ClearBeforeFill = True
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1242, 541)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form13"
        Me.Text = "student master view"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StudentDataSet As student_admission.studentDataSet
    Friend WithEvents AddBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddTableAdapter As student_admission.studentDataSetTableAdapters.addTableAdapter
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
