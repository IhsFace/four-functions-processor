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
        Label1 = New Label()
        Label2 = New Label()
        txtInputInteger = New TextBox()
        GroupBox1 = New GroupBox()
        txtCubeInteger = New TextBox()
        txtSquareInteger = New TextBox()
        txtHalfInteger = New TextBox()
        txtDoubleInteger = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnGenerate = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(245, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(497, 59)
        Label1.TabIndex = 0
        Label1.Text = "Four Functions Processor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(282, 32)
        Label2.TabIndex = 1
        Label2.Text = "Type in a Whole Number"
        ' 
        ' txtInputInteger
        ' 
        txtInputInteger.Location = New Point(539, 176)
        txtInputInteger.Name = "txtInputInteger"
        txtInputInteger.Size = New Size(200, 39)
        txtInputInteger.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtCubeInteger)
        GroupBox1.Controls.Add(txtSquareInteger)
        GroupBox1.Controls.Add(txtHalfInteger)
        GroupBox1.Controls.Add(txtDoubleInteger)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(172, 334)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(570, 344)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "RESULTS"
        ' 
        ' txtCubeInteger
        ' 
        txtCubeInteger.Location = New Point(214, 257)
        txtCubeInteger.Name = "txtCubeInteger"
        txtCubeInteger.Size = New Size(200, 39)
        txtCubeInteger.TabIndex = 7
        ' 
        ' txtSquareInteger
        ' 
        txtSquareInteger.Location = New Point(214, 197)
        txtSquareInteger.Name = "txtSquareInteger"
        txtSquareInteger.Size = New Size(200, 39)
        txtSquareInteger.TabIndex = 6
        ' 
        ' txtHalfInteger
        ' 
        txtHalfInteger.Location = New Point(214, 124)
        txtHalfInteger.Name = "txtHalfInteger"
        txtHalfInteger.Size = New Size(200, 39)
        txtHalfInteger.TabIndex = 5
        ' 
        ' txtDoubleInteger
        ' 
        txtDoubleInteger.Location = New Point(214, 66)
        txtDoubleInteger.Name = "txtDoubleInteger"
        txtDoubleInteger.Size = New Size(200, 39)
        txtDoubleInteger.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(73, 248)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 32)
        Label6.TabIndex = 3
        Label6.Text = "Cube"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(73, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 32)
        Label5.TabIndex = 2
        Label5.Text = "Square"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 32)
        Label4.TabIndex = 1
        Label4.Text = "Half"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 32)
        Label3.TabIndex = 0
        Label3.Text = "Double"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(375, 257)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(150, 46)
        btnGenerate.TabIndex = 4
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 729)
        Controls.Add(btnGenerate)
        Controls.Add(GroupBox1)
        Controls.Add(txtInputInteger)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Functions Challenge Task"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInputInteger As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCubeInteger As TextBox
    Friend WithEvents txtSquareInteger As TextBox
    Friend WithEvents txtHalfInteger As TextBox
    Friend WithEvents txtDoubleInteger As TextBox
    Friend WithEvents btnGenerate As Button

End Class
