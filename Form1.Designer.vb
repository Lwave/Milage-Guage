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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.lblGallonsOfGas = New System.Windows.Forms.Label()
        Me.txtMPG = New System.Windows.Forms.TextBox()
        Me.txtGallonsOfGas = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(48, 70)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(203, 13)
        Me.lblMPG.TabIndex = 0
        Me.lblMPG.Text = "Enter in the miles per gallon your car gets:"
        '
        'lblGallonsOfGas
        '
        Me.lblGallonsOfGas.AutoSize = True
        Me.lblGallonsOfGas.Location = New System.Drawing.Point(65, 113)
        Me.lblGallonsOfGas.Name = "lblGallonsOfGas"
        Me.lblGallonsOfGas.Size = New System.Drawing.Size(182, 13)
        Me.lblGallonsOfGas.TabIndex = 1
        Me.lblGallonsOfGas.Text = "Enter in the amount of gallons of gas:"
        '
        'txtMPG
        '
        Me.txtMPG.Location = New System.Drawing.Point(257, 70)
        Me.txtMPG.Name = "txtMPG"
        Me.txtMPG.Size = New System.Drawing.Size(100, 20)
        Me.txtMPG.TabIndex = 2
        '
        'txtGallonsOfGas
        '
        Me.txtGallonsOfGas.Location = New System.Drawing.Point(257, 110)
        Me.txtGallonsOfGas.Name = "txtGallonsOfGas"
        Me.txtGallonsOfGas.Size = New System.Drawing.Size(100, 20)
        Me.txtGallonsOfGas.TabIndex = 3
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmount.Location = New System.Drawing.Point(257, 155)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblAmount.TabIndex = 4
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Lime
        Me.btnShow.Location = New System.Drawing.Point(184, 206)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(86, 39)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Calculate Miles"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(95, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Miles your car will go before 0:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "An app that calculates your car's gas milage to gallons of gas to get a simple, e" &
    "ffective gauge to determine miles until empty."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(384, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(496, 275)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtGallonsOfGas)
        Me.Controls.Add(Me.txtMPG)
        Me.Controls.Add(Me.lblGallonsOfGas)
        Me.Controls.Add(Me.lblMPG)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMPG As Label
    Friend WithEvents lblGallonsOfGas As Label
    Friend WithEvents txtMPG As TextBox
    Friend WithEvents txtGallonsOfGas As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
