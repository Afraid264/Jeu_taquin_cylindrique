<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxTexteSaisi = New System.Windows.Forms.TextBox()
        Me.LabelTexteSaisi = New System.Windows.Forms.Label()
        Me.LabelTexteEcho = New System.Windows.Forms.Label()
        Me.ButtonGo = New System.Windows.Forms.Button()
        Me.TextBoxTexteRepondu = New System.Windows.Forms.TextBox()
        Me.LabelWaiting = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxTexteSaisi
        '
        Me.TextBoxTexteSaisi.Location = New System.Drawing.Point(29, 44)
        Me.TextBoxTexteSaisi.Multiline = True
        Me.TextBoxTexteSaisi.Name = "TextBoxTexteSaisi"
        Me.TextBoxTexteSaisi.Size = New System.Drawing.Size(295, 299)
        Me.TextBoxTexteSaisi.TabIndex = 0
        '
        'LabelTexteSaisi
        '
        Me.LabelTexteSaisi.AutoSize = True
        Me.LabelTexteSaisi.Location = New System.Drawing.Point(147, 9)
        Me.LabelTexteSaisi.Name = "LabelTexteSaisi"
        Me.LabelTexteSaisi.Size = New System.Drawing.Size(59, 13)
        Me.LabelTexteSaisi.TabIndex = 1
        Me.LabelTexteSaisi.Text = "Texte Saisi"
        '
        'LabelTexteEcho
        '
        Me.LabelTexteEcho.AutoSize = True
        Me.LabelTexteEcho.Location = New System.Drawing.Point(586, 9)
        Me.LabelTexteEcho.Name = "LabelTexteEcho"
        Me.LabelTexteEcho.Size = New System.Drawing.Size(62, 13)
        Me.LabelTexteEcho.TabIndex = 3
        Me.LabelTexteEcho.Text = "Texte Echo"
        '
        'ButtonGo
        '
        Me.ButtonGo.Location = New System.Drawing.Point(218, 385)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(341, 23)
        Me.ButtonGo.TabIndex = 4
        Me.ButtonGo.Text = "Go"
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'TextBoxTexteRepondu
        '
        Me.TextBoxTexteRepondu.Enabled = False
        Me.TextBoxTexteRepondu.Location = New System.Drawing.Point(472, 44)
        Me.TextBoxTexteRepondu.Multiline = True
        Me.TextBoxTexteRepondu.Name = "TextBoxTexteRepondu"
        Me.TextBoxTexteRepondu.ReadOnly = True
        Me.TextBoxTexteRepondu.Size = New System.Drawing.Size(295, 299)
        Me.TextBoxTexteRepondu.TabIndex = 5
        '
        'LabelWaiting
        '
        Me.LabelWaiting.AutoSize = True
        Me.LabelWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWaiting.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelWaiting.Location = New System.Drawing.Point(397, 176)
        Me.LabelWaiting.Name = "LabelWaiting"
        Me.LabelWaiting.Size = New System.Drawing.Size(0, 26)
        Me.LabelWaiting.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 427)
        Me.Controls.Add(Me.LabelWaiting)
        Me.Controls.Add(Me.TextBoxTexteRepondu)
        Me.Controls.Add(Me.ButtonGo)
        Me.Controls.Add(Me.LabelTexteEcho)
        Me.Controls.Add(Me.LabelTexteSaisi)
        Me.Controls.Add(Me.TextBoxTexteSaisi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxTexteSaisi As TextBox
    Friend WithEvents LabelTexteSaisi As Label
    Friend WithEvents LabelTexteEcho As Label
    Friend WithEvents ButtonGo As Button
    Friend WithEvents TextBoxTexteRepondu As TextBox
    Friend WithEvents LabelWaiting As Label
End Class
