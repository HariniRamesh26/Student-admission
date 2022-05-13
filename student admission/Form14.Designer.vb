<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RhariniDataSet1 = New student_admission.rhariniDataSet1()
        Me.CBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTableAdapter = New student_admission.rhariniDataSet1TableAdapters.cTableAdapter()
        Me.CourseidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfYearsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmissionFeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagementsSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneralSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MBCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilitarySeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SportsSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandicapSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalSeatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RhariniDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course report"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseidDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.NoOfYearsDataGridViewTextBoxColumn, Me.AdmissionFeesDataGridViewTextBoxColumn, Me.ManagementsSeatsDataGridViewTextBoxColumn, Me.GeneralSeatsDataGridViewTextBoxColumn, Me.BCDataGridViewTextBoxColumn, Me.MBCDataGridViewTextBoxColumn, Me.SCSTDataGridViewTextBoxColumn, Me.MilitarySeatsDataGridViewTextBoxColumn, Me.SportsSeatsDataGridViewTextBoxColumn, Me.HandicapSeatsDataGridViewTextBoxColumn, Me.TotalSeatsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(52, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1058, 267)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Course count"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(539, 501)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(407, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(586, 578)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RhariniDataSet1
        '
        Me.RhariniDataSet1.DataSetName = "rhariniDataSet1"
        Me.RhariniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBindingSource
        '
        Me.CBindingSource.DataMember = "c"
        Me.CBindingSource.DataSource = Me.RhariniDataSet1
        '
        'CTableAdapter
        '
        Me.CTableAdapter.ClearBeforeFill = True
        '
        'CourseidDataGridViewTextBoxColumn
        '
        Me.CourseidDataGridViewTextBoxColumn.DataPropertyName = "Courseid"
        Me.CourseidDataGridViewTextBoxColumn.HeaderText = "Courseid"
        Me.CourseidDataGridViewTextBoxColumn.Name = "CourseidDataGridViewTextBoxColumn"
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "Course name"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "Course name"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        '
        'NoOfYearsDataGridViewTextBoxColumn
        '
        Me.NoOfYearsDataGridViewTextBoxColumn.DataPropertyName = "No of years"
        Me.NoOfYearsDataGridViewTextBoxColumn.HeaderText = "No of years"
        Me.NoOfYearsDataGridViewTextBoxColumn.Name = "NoOfYearsDataGridViewTextBoxColumn"
        '
        'AdmissionFeesDataGridViewTextBoxColumn
        '
        Me.AdmissionFeesDataGridViewTextBoxColumn.DataPropertyName = "Admission fees"
        Me.AdmissionFeesDataGridViewTextBoxColumn.HeaderText = "Admission fees"
        Me.AdmissionFeesDataGridViewTextBoxColumn.Name = "AdmissionFeesDataGridViewTextBoxColumn"
        '
        'ManagementsSeatsDataGridViewTextBoxColumn
        '
        Me.ManagementsSeatsDataGridViewTextBoxColumn.DataPropertyName = "Managements seats"
        Me.ManagementsSeatsDataGridViewTextBoxColumn.HeaderText = "Managements seats"
        Me.ManagementsSeatsDataGridViewTextBoxColumn.Name = "ManagementsSeatsDataGridViewTextBoxColumn"
        '
        'GeneralSeatsDataGridViewTextBoxColumn
        '
        Me.GeneralSeatsDataGridViewTextBoxColumn.DataPropertyName = "General seats"
        Me.GeneralSeatsDataGridViewTextBoxColumn.HeaderText = "General seats"
        Me.GeneralSeatsDataGridViewTextBoxColumn.Name = "GeneralSeatsDataGridViewTextBoxColumn"
        '
        'BCDataGridViewTextBoxColumn
        '
        Me.BCDataGridViewTextBoxColumn.DataPropertyName = "BC"
        Me.BCDataGridViewTextBoxColumn.HeaderText = "BC"
        Me.BCDataGridViewTextBoxColumn.Name = "BCDataGridViewTextBoxColumn"
        '
        'MBCDataGridViewTextBoxColumn
        '
        Me.MBCDataGridViewTextBoxColumn.DataPropertyName = "MBC"
        Me.MBCDataGridViewTextBoxColumn.HeaderText = "MBC"
        Me.MBCDataGridViewTextBoxColumn.Name = "MBCDataGridViewTextBoxColumn"
        '
        'SCSTDataGridViewTextBoxColumn
        '
        Me.SCSTDataGridViewTextBoxColumn.DataPropertyName = "SC/ST"
        Me.SCSTDataGridViewTextBoxColumn.HeaderText = "SC/ST"
        Me.SCSTDataGridViewTextBoxColumn.Name = "SCSTDataGridViewTextBoxColumn"
        '
        'MilitarySeatsDataGridViewTextBoxColumn
        '
        Me.MilitarySeatsDataGridViewTextBoxColumn.DataPropertyName = "Military seats"
        Me.MilitarySeatsDataGridViewTextBoxColumn.HeaderText = "Military seats"
        Me.MilitarySeatsDataGridViewTextBoxColumn.Name = "MilitarySeatsDataGridViewTextBoxColumn"
        '
        'SportsSeatsDataGridViewTextBoxColumn
        '
        Me.SportsSeatsDataGridViewTextBoxColumn.DataPropertyName = "sports seats"
        Me.SportsSeatsDataGridViewTextBoxColumn.HeaderText = "sports seats"
        Me.SportsSeatsDataGridViewTextBoxColumn.Name = "SportsSeatsDataGridViewTextBoxColumn"
        '
        'HandicapSeatsDataGridViewTextBoxColumn
        '
        Me.HandicapSeatsDataGridViewTextBoxColumn.DataPropertyName = "Handicap seats"
        Me.HandicapSeatsDataGridViewTextBoxColumn.HeaderText = "Handicap seats"
        Me.HandicapSeatsDataGridViewTextBoxColumn.Name = "HandicapSeatsDataGridViewTextBoxColumn"
        '
        'TotalSeatsDataGridViewTextBoxColumn
        '
        Me.TotalSeatsDataGridViewTextBoxColumn.DataPropertyName = "Total seats"
        Me.TotalSeatsDataGridViewTextBoxColumn.HeaderText = "Total seats"
        Me.TotalSeatsDataGridViewTextBoxColumn.Name = "TotalSeatsDataGridViewTextBoxColumn"
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1288, 648)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form14"
        Me.Text = "Course reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RhariniDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RhariniDataSet1 As student_admission.rhariniDataSet1
    Friend WithEvents CBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTableAdapter As student_admission.rhariniDataSet1TableAdapters.cTableAdapter
    Friend WithEvents CourseidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfYearsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmissionFeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManagementsSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneralSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MBCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCSTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MilitarySeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SportsSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HandicapSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalSeatsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
