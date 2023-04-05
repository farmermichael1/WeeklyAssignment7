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
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cbKaraoke = New System.Windows.Forms.ComboBox()
        Me.lbHour = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lbCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(414, 30)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(283, 31)
        Me.lbTitle.TabIndex = 1
        Me.lbTitle.Text = "Karaoke Music Night"
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(333, 309)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(163, 39)
        Me.btnTotal.TabIndex = 2
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(609, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(163, 39)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cbKaraoke
        '
        Me.cbKaraoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKaraoke.FormattingEnabled = True
        Me.cbKaraoke.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cbKaraoke.Location = New System.Drawing.Point(320, 90)
        Me.cbKaraoke.Name = "cbKaraoke"
        Me.cbKaraoke.Size = New System.Drawing.Size(452, 32)
        Me.cbKaraoke.TabIndex = 4
        Me.cbKaraoke.Text = "Select Service"
        '
        'lbHour
        '
        Me.lbHour.AutoSize = True
        Me.lbHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHour.Location = New System.Drawing.Point(403, 177)
        Me.lbHour.Name = "lbHour"
        Me.lbHour.Size = New System.Drawing.Size(308, 24)
        Me.lbHour.TabIndex = 5
        Me.lbHour.Text = "Hourly Rental of Karaoke Room:"
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(522, 228)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(75, 38)
        Me.txtHours.TabIndex = 6
        '
        'lbCost
        '
        Me.lbCost.AutoSize = True
        Me.lbCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCost.Location = New System.Drawing.Point(403, 385)
        Me.lbCost.Name = "lbCost"
        Me.lbCost.Size = New System.Drawing.Size(320, 24)
        Me.lbCost.TabIndex = 7
        Me.lbCost.Text = "Total Cost of Karaoke Night - $Money"
        Me.lbCost.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment7.My.Resources.Resources.karaoke
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 462)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.lbCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lbHour)
        Me.Controls.Add(Me.cbKaraoke)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cbKaraoke As ComboBox
    Friend WithEvents lbHour As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lbCost As Label
End Class
