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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chblarge = New System.Windows.Forms.RadioButton()
        Me.chbmedium = New System.Windows.Forms.RadioButton()
        Me.chbsmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rbseda = New System.Windows.Forms.RadioButton()
        Me.Rblona = New System.Windows.Forms.RadioButton()
        Me.Rbalgodon = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chblarge)
        Me.GroupBox1.Controls.Add(Me.chbmedium)
        Me.GroupBox1.Controls.Add(Me.chbsmall)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'chblarge
        '
        Me.chblarge.AutoSize = True
        Me.chblarge.Location = New System.Drawing.Point(30, 110)
        Me.chblarge.Name = "chblarge"
        Me.chblarge.Size = New System.Drawing.Size(51, 19)
        Me.chblarge.TabIndex = 2
        Me.chblarge.TabStop = True
        Me.chblarge.Text = "large"
        Me.chblarge.UseVisualStyleBackColor = True
        '
        'chbmedium
        '
        Me.chbmedium.AutoSize = True
        Me.chbmedium.Location = New System.Drawing.Point(30, 68)
        Me.chbmedium.Name = "chbmedium"
        Me.chbmedium.Size = New System.Drawing.Size(70, 19)
        Me.chbmedium.TabIndex = 1
        Me.chbmedium.TabStop = True
        Me.chbmedium.Text = "medium"
        Me.chbmedium.UseVisualStyleBackColor = True
        '
        'chbsmall
        '
        Me.chbsmall.AutoSize = True
        Me.chbsmall.Location = New System.Drawing.Point(31, 28)
        Me.chbsmall.Name = "chbsmall"
        Me.chbsmall.Size = New System.Drawing.Size(56, 19)
        Me.chbsmall.TabIndex = 0
        Me.chbsmall.TabStop = True
        Me.chbsmall.Text = "smalll"
        Me.chbsmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rbseda)
        Me.GroupBox2.Controls.Add(Me.Rblona)
        Me.GroupBox2.Controls.Add(Me.Rbalgodon)
        Me.GroupBox2.Location = New System.Drawing.Point(61, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'Rbseda
        '
        Me.Rbseda.AutoSize = True
        Me.Rbseda.Location = New System.Drawing.Point(22, 69)
        Me.Rbseda.Name = "Rbseda"
        Me.Rbseda.Size = New System.Drawing.Size(50, 19)
        Me.Rbseda.TabIndex = 2
        Me.Rbseda.TabStop = True
        Me.Rbseda.Text = "Seda"
        Me.Rbseda.UseVisualStyleBackColor = True
        '
        'Rblona
        '
        Me.Rblona.AutoSize = True
        Me.Rblona.Location = New System.Drawing.Point(22, 105)
        Me.Rblona.Name = "Rblona"
        Me.Rblona.Size = New System.Drawing.Size(51, 19)
        Me.Rblona.TabIndex = 1
        Me.Rblona.TabStop = True
        Me.Rblona.Text = "Lona"
        Me.Rblona.UseVisualStyleBackColor = True
        '
        'Rbalgodon
        '
        Me.Rbalgodon.AutoSize = True
        Me.Rbalgodon.Location = New System.Drawing.Point(22, 25)
        Me.Rbalgodon.Name = "Rbalgodon"
        Me.Rbalgodon.Size = New System.Drawing.Size(71, 19)
        Me.Rbalgodon.TabIndex = 0
        Me.Rbalgodon.TabStop = True
        Me.Rbalgodon.Text = "Algodon"
        Me.Rbalgodon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingresar a la cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(420, 95)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(162, 23)
        Me.txtcantidad.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(450, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(450, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(450, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "201801223_chumpa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chblarge As RadioButton
    Friend WithEvents chbmedium As RadioButton
    Friend WithEvents chbsmall As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Rbseda As RadioButton
    Friend WithEvents Rblona As RadioButton
    Friend WithEvents Rbalgodon As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
