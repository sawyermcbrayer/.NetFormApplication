<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.temperatureInputBox = New System.Windows.Forms.TextBox()
        Me.phInputBox = New System.Windows.Forms.TextBox()
        Me.ghInputBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.khInputBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dateTimeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pHColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gHColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.khColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeeHistory = New System.Windows.Forms.Button()
        Me.btnCloseHistory = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblCurrentFile = New System.Windows.Forms.LinkLabel()
        Me.btnClearForm = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1030, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(707, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Neocaridina Parameter Form"
        '
        'temperatureInputBox
        '
        Me.temperatureInputBox.Location = New System.Drawing.Point(1341, 199)
        Me.temperatureInputBox.Name = "temperatureInputBox"
        Me.temperatureInputBox.Size = New System.Drawing.Size(200, 39)
        Me.temperatureInputBox.TabIndex = 2
        '
        'phInputBox
        '
        Me.phInputBox.Location = New System.Drawing.Point(1341, 276)
        Me.phInputBox.Name = "phInputBox"
        Me.phInputBox.Size = New System.Drawing.Size(200, 39)
        Me.phInputBox.TabIndex = 3
        '
        'ghInputBox
        '
        Me.ghInputBox.Location = New System.Drawing.Point(1341, 339)
        Me.ghInputBox.Name = "ghInputBox"
        Me.ghInputBox.Size = New System.Drawing.Size(200, 39)
        Me.ghInputBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1173, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1186, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "pH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1186, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "gH"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(1225, 491)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 46)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit Readings"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Location = New System.Drawing.Point(1266, 574)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(0, 32)
        Me.ErrorLabel.TabIndex = 9
        '
        'khInputBox
        '
        Me.khInputBox.Location = New System.Drawing.Point(1341, 413)
        Me.khInputBox.Name = "khInputBox"
        Me.khInputBox.Size = New System.Drawing.Size(200, 39)
        Me.khInputBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1188, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "kH"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateTimeColumn, Me.tempColumn, Me.pHColumn, Me.gHColumn, Me.khColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(886, 669)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 41
        Me.DataGridView1.Size = New System.Drawing.Size(1059, 267)
        Me.DataGridView1.TabIndex = 12
        Me.DataGridView1.Visible = False
        '
        'dateTimeColumn
        '
        Me.dateTimeColumn.HeaderText = "Date Collected"
        Me.dateTimeColumn.MinimumWidth = 10
        Me.dateTimeColumn.Name = "dateTimeColumn"
        Me.dateTimeColumn.ReadOnly = True
        Me.dateTimeColumn.Width = 200
        '
        'tempColumn
        '
        Me.tempColumn.HeaderText = "Temp."
        Me.tempColumn.MinimumWidth = 10
        Me.tempColumn.Name = "tempColumn"
        Me.tempColumn.ReadOnly = True
        Me.tempColumn.Width = 200
        '
        'pHColumn
        '
        Me.pHColumn.HeaderText = "pH"
        Me.pHColumn.MinimumWidth = 10
        Me.pHColumn.Name = "pHColumn"
        Me.pHColumn.ReadOnly = True
        Me.pHColumn.Width = 200
        '
        'gHColumn
        '
        Me.gHColumn.HeaderText = "gH"
        Me.gHColumn.MinimumWidth = 10
        Me.gHColumn.Name = "gHColumn"
        Me.gHColumn.ReadOnly = True
        Me.gHColumn.Width = 200
        '
        'khColumn
        '
        Me.khColumn.HeaderText = "kH"
        Me.khColumn.MinimumWidth = 10
        Me.khColumn.Name = "khColumn"
        Me.khColumn.ReadOnly = True
        Me.khColumn.Width = 200
        '
        'btnSeeHistory
        '
        Me.btnSeeHistory.Location = New System.Drawing.Point(1393, 491)
        Me.btnSeeHistory.Name = "btnSeeHistory"
        Me.btnSeeHistory.Size = New System.Drawing.Size(150, 46)
        Me.btnSeeHistory.TabIndex = 13
        Me.btnSeeHistory.Text = "See History"
        Me.btnSeeHistory.UseVisualStyleBackColor = True
        '
        'btnCloseHistory
        '
        Me.btnCloseHistory.Location = New System.Drawing.Point(1393, 491)
        Me.btnCloseHistory.Name = "btnCloseHistory"
        Me.btnCloseHistory.Size = New System.Drawing.Size(231, 46)
        Me.btnCloseHistory.TabIndex = 14
        Me.btnCloseHistory.Text = "Close History"
        Me.btnCloseHistory.UseVisualStyleBackColor = True
        Me.btnCloseHistory.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1224, 557)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 46)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(1393, 557)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(150, 46)
        Me.btnLoad.TabIndex = 16
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(1304, 142)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 32)
        Me.lblDateTime.TabIndex = 17
        '
        'timerDateTime
        '
        Me.timerDateTime.Enabled = True
        Me.timerDateTime.Interval = 50
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblCurrentFile
        '
        Me.lblCurrentFile.AutoSize = True
        Me.lblCurrentFile.Location = New System.Drawing.Point(1213, 620)
        Me.lblCurrentFile.Name = "lblCurrentFile"
        Me.lblCurrentFile.Size = New System.Drawing.Size(0, 32)
        Me.lblCurrentFile.TabIndex = 18
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(1561, 557)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(150, 46)
        Me.btnClearForm.TabIndex = 19
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(2740, 948)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.lblCurrentFile)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCloseHistory)
        Me.Controls.Add(Me.btnSeeHistory)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.khInputBox)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ghInputBox)
        Me.Controls.Add(Me.phInputBox)
        Me.Controls.Add(Me.temperatureInputBox)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Tank Parameters"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents temperatureInputBox As TextBox
    Friend WithEvents phInputBox As TextBox
    Friend WithEvents ghInputBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents khInputBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dateTimeColumn As DataGridViewTextBoxColumn
    Friend WithEvents tempColumn As DataGridViewTextBoxColumn
    Friend WithEvents pHColumn As DataGridViewTextBoxColumn
    Friend WithEvents gHColumn As DataGridViewTextBoxColumn
    Friend WithEvents khColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSeeHistory As Button
    Friend WithEvents btnCloseHistory As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents timerDateTime As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblCurrentFile As LinkLabel
    Friend WithEvents btnClearForm As Button
End Class
