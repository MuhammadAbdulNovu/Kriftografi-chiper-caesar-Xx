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
        Me.enkripsi = New System.Windows.Forms.Button()
        Me.dekripsi = New System.Windows.Forms.Button()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.txtTeks = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'enkripsi
        '
        Me.enkripsi.Location = New System.Drawing.Point(297, 222)
        Me.enkripsi.Name = "enkripsi"
        Me.enkripsi.Size = New System.Drawing.Size(75, 23)
        Me.enkripsi.TabIndex = 0
        Me.enkripsi.Text = "Enkripsi"
        Me.enkripsi.UseVisualStyleBackColor = True
        '
        'dekripsi
        '
        Me.dekripsi.Location = New System.Drawing.Point(470, 222)
        Me.dekripsi.Name = "dekripsi"
        Me.dekripsi.Size = New System.Drawing.Size(75, 23)
        Me.dekripsi.TabIndex = 1
        Me.dekripsi.Text = "Dekripsi"
        Me.dekripsi.UseVisualStyleBackColor = True
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(297, 64)
        Me.txtHasil.Multiline = True
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(248, 148)
        Me.txtHasil.TabIndex = 2
        '
        'txtTeks
        '
        Me.txtTeks.Location = New System.Drawing.Point(22, 64)
        Me.txtTeks.Multiline = True
        Me.txtTeks.Name = "txtTeks"
        Me.txtTeks.Size = New System.Drawing.Size(248, 148)
        Me.txtTeks.TabIndex = 3
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(89, 222)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(36, 20)
        Me.txtKey.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kunci"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TEXT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "HASIL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(670, 463)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtTeks)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.dekripsi)
        Me.Controls.Add(Me.enkripsi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enkripsi As System.Windows.Forms.Button
    Friend WithEvents dekripsi As System.Windows.Forms.Button
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents txtTeks As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
