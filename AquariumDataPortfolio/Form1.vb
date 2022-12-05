Imports System.Collections
Imports System.IO
Imports System.Data
Imports System.Text
Public Class Form1

#Region "OnLoad"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        'MessageBox.Show("Welcome, friend! Would you like to load a fish profile?")
        timerDateTime.Enabled = True
    End Sub

#End Region

#Region "Variable Declarations"

    Dim loadFile As String
    Dim linkStrippedName As String

    'The goal with beenLoaded is to work out the issue of how to treat the gridview when submitting new info to it..might ened to prompt yes/no to add to new form etc.
    Dim beenLoaded As Integer = 0

    'ok lets think about this..... reset button, save aka add to db button, history button (show all data), import file button for loading file, load file on load, create new profile on load which will create the save .txt file in csv format....wheee I'm stupid and smart 
    Dim tempList As New List(Of String)()
    Dim phList As New List(Of String)()
    Dim gHlist As New List(Of String)()
    Dim kHlist As New List(Of String)()
    Dim dateTime = System.DateTime.Now
    'this is supposed to be used in save function. on submit if not loaded file or new file logic etc
    Dim submitPromptFlag As Boolean

#End Region

#Region "Button Event Modulation"
    Private Sub btnSeeHistory_Click(sender As Object, e As EventArgs) Handles btnSeeHistory.Click
        btnSeeHistory.Visible = False
        btnCloseHistory.Visible = True
        DataGridView1.Visible = True
    End Sub

    Private Sub btnCloseHistory_Click(sender As Object, e As EventArgs) Handles btnCloseHistory.Click
        btnSeeHistory.Visible = True
        btnCloseHistory.Visible = False
        DataGridView1.Visible = False
    End Sub

#End Region

#Region "Save/Load/Submit"
    '
    'SAVE
    '
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim csv As String = String.Empty

        For Each column As DataGridViewColumn In DataGridView1.Columns
            csv += column.HeaderText & ","c
        Next

        csv += vbCr & vbLf

        Dim iterationToDeleteLastLine As Integer = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            iterationToDeleteLastLine += 1
            For Each cell As DataGridViewCell In row.Cells
                csv += cell.Value & ","c
            Next
            'Need to work this out from here, or from the angle of the extra row being processed and being assigned commas in the notepad csv. Or it might not even matter,
            'lets figure out load first then circle back here. 
            'If row.Cells.ToString IsNot Nothing Then
            'Add new line.
            'If iterationToDeleteLastLine = 2 Then
            '    Continue For
            'Else
            csv += vbCr & vbLf
            'End If

            'End If

        Next

        'Exporting to Excel
        Try
            Dim folderPath As String = "C:\Users\Sawyer\Documents\AquariumData\"
            File.WriteAllText(folderPath & "AquariumData.csv", csv)
            MsgBox("Save successful.")
            'Catch exception As IDictionary
            '
            'Exit Try
        Catch
            MessageBox.Show("Saving Failed: Try again, please.")
        End Try
    End Sub

    '
    'LOAD
    '

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'clear the current edit of data grid. 
        'todo - add prompt on load to warn of losing unsaved data if user was creating a new file before loading one in
        'If OpenFileDialog1.DialogResult IsNot True Then
        'MsgBox("nottrue")
        'End If

        OpenFileDialog1.InitialDirectory = "C:\Documents"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Open Parameter File (.csv format)"
        OpenFileDialog1.Filter = "CSV|*.csv"
        OpenFileDialog1.ShowDialog()
        clearDataGrid()
        loadFile = OpenFileDialog1.FileName
        linkStrippedName = System.IO.Path.GetFileName(loadFile)
        lblCurrentFile.Text = linkStrippedName


        Dim TextLine As String
        Dim SplitLine() As String
        Dim indexFirstLine As Integer = -1
        Dim indexHeaderCounter As Integer = 0
        If System.IO.File.Exists(loadFile) = True Then
            Using objReader As New System.IO.StreamReader(loadFile, Encoding.ASCII)
                Do While objReader.Peek() <> -1
                    indexFirstLine += 1
                    TextLine = objReader.ReadLine()
                    SplitLine = Split(TextLine, ",")
                    If (indexFirstLine <> 0) Then
                        Me.DataGridView1.Rows.Add(SplitLine)
                    Else
                        For Each column As DataGridViewColumn In DataGridView1.Columns
                            column.HeaderText = SplitLine(indexHeaderCounter)
                            indexHeaderCounter += 1
                        Next
                    End If
                Loop
            End Using
        Else
            MessageBox.Show("Error occured: Try again.")
        End If

    End Sub


    '
    'SUBMIT
    '

    Private Sub subButton_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        If String.IsNullOrEmpty(temperatureInputBox.Text) Or String.IsNullOrEmpty(phInputBox.Text) Or String.IsNullOrEmpty(ghInputBox.Text) Or String.IsNullOrEmpty(khInputBox.Text) Then
            'ErrorLabel.Text = "Ensure all input boxes have numeric values and try again."
            btnSubmit.BackColor = Color.Crimson
            MessageBox.Show("Ensure all input boxes have number values.")
        Else
            Try
                'add new file prompt logic here
                btnSubmit.BackColor = Color.LightGray
                dateTime = System.DateTime.Now
                tempList.Add(temperatureInputBox.Text)
                phList.Add(phInputBox.Text)
                gHlist.Add(ghInputBox.Text)
                kHlist.Add(khInputBox.Text)
                DataGridView1.Rows.Add(dateTime, temperatureInputBox.Text, phInputBox.Text, ghInputBox.Text, khInputBox.Text)
                clearInputs()
            Catch
                MessageBox.Show("Error saving: Try again!")
            End Try

        End If
        ErrorLabel.Text = "Done"
    End Sub
#End Region

#Region "Misc. Background Processes"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerDateTime.Tick
        lblDateTime.Text = Date.Now.ToString("MM:dd:yyyy hh:mm:ss")
    End Sub

    Private Sub lblCurrentFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCurrentFile.LinkClicked
        Process.Start("explorer.exe", loadFile)
    End Sub

#End Region

#Region "Clear Functions"

    Private Sub clearDataGrid()
        For Each row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows.Clear()


        Next
    End Sub

    Private Sub clearInputs()
        temperatureInputBox.Text = ""
        phInputBox.Text = ""
        ghInputBox.Text = ""
        khInputBox.Text = ""
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        clearDataGrid()
    End Sub

#End Region

    ''''''''''
    'Class end
    ''''''''''
End Class







'Private Sub temperatureInputBox_TextChanged(sender As Object, e As EventArgs) Handles temperatureInputBox.TextChanged, ghInputBox.TextChanged, khInputBox.TextChanged, phInputBox.TextChanged
'    ErrorLabel.Text = ""
'End Sub

'---------------
'---------------
'---------------
'proto a 'sensor' input (similar to loading a file) feature that can then adjust parameters. this will look like a 
'suggest changes feature I think which would be super cool!
'-----------------
'-----------------
'-----------------
