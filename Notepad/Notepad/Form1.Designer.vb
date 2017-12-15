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
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnNewNote = New System.Windows.Forms.Button()
        Me.btnSaveNote = New System.Windows.Forms.Button()
        Me.txtNoteName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNameNote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(12, 39)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(360, 266)
        Me.txtNote.TabIndex = 0
        '
        'btnNewNote
        '
        Me.btnNewNote.Location = New System.Drawing.Point(12, 326)
        Me.btnNewNote.Name = "btnNewNote"
        Me.btnNewNote.Size = New System.Drawing.Size(75, 23)
        Me.btnNewNote.TabIndex = 1
        Me.btnNewNote.Text = "New"
        Me.btnNewNote.UseVisualStyleBackColor = True
        '
        'btnSaveNote
        '
        Me.btnSaveNote.Location = New System.Drawing.Point(297, 326)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNote.TabIndex = 3
        Me.btnSaveNote.Text = "Save"
        Me.btnSaveNote.UseVisualStyleBackColor = True
        '
        'txtNoteName
        '
        Me.txtNoteName.Location = New System.Drawing.Point(95, 8)
        Me.txtNoteName.Name = "txtNoteName"
        Me.txtNoteName.Size = New System.Drawing.Size(120, 20)
        Me.txtNoteName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name Note"
        '
        'btnNameNote
        '
        Me.btnNameNote.Location = New System.Drawing.Point(221, 6)
        Me.btnNameNote.Name = "btnNameNote"
        Me.btnNameNote.Size = New System.Drawing.Size(75, 23)
        Me.btnNameNote.TabIndex = 6
        Me.btnNameNote.Text = "Name"
        Me.btnNameNote.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.btnNameNote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoteName)
        Me.Controls.Add(Me.btnSaveNote)
        Me.Controls.Add(Me.btnNewNote)
        Me.Controls.Add(Me.txtNote)
        Me.Name = "Form1"
        Me.Text = "Note"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents btnNewNote As System.Windows.Forms.Button
    Friend WithEvents btnSaveNote As System.Windows.Forms.Button
    Friend WithEvents txtNoteName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNameNote As System.Windows.Forms.Button

End Class
