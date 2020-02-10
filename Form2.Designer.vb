<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.comboxNom = New System.Windows.Forms.ComboBox()
        Me.rbtnFacile = New System.Windows.Forms.RadioButton()
        Me.rbtnMoyen = New System.Windows.Forms.RadioButton()
        Me.rbtnDifficile = New System.Windows.Forms.RadioButton()
        Me.panelDifficulte = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDifficulte.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(247, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 26)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Quitter"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(370, 368)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(102, 26)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Commencer"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetVB.My.Resources.Resources.image_taquin
        Me.PictureBox1.Location = New System.Drawing.Point(247, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 213)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(631, 102)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(87, 38)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "Informations Joueurs"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'comboxNom
        '
        Me.comboxNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboxNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboxNom.FormattingEnabled = True
        Me.comboxNom.Location = New System.Drawing.Point(289, 316)
        Me.comboxNom.Name = "comboxNom"
        Me.comboxNom.Size = New System.Drawing.Size(183, 21)
        Me.comboxNom.Sorted = True
        Me.comboxNom.TabIndex = 6
        '
        'rbtnFacile
        '
        Me.rbtnFacile.AutoSize = True
        Me.rbtnFacile.Location = New System.Drawing.Point(20, 7)
        Me.rbtnFacile.Name = "rbtnFacile"
        Me.rbtnFacile.Size = New System.Drawing.Size(53, 17)
        Me.rbtnFacile.TabIndex = 7
        Me.rbtnFacile.TabStop = True
        Me.rbtnFacile.Text = "Facile"
        Me.rbtnFacile.UseVisualStyleBackColor = True
        '
        'rbtnMoyen
        '
        Me.rbtnMoyen.AutoSize = True
        Me.rbtnMoyen.Location = New System.Drawing.Point(20, 44)
        Me.rbtnMoyen.Name = "rbtnMoyen"
        Me.rbtnMoyen.Size = New System.Drawing.Size(57, 17)
        Me.rbtnMoyen.TabIndex = 8
        Me.rbtnMoyen.TabStop = True
        Me.rbtnMoyen.Text = "Moyen"
        Me.rbtnMoyen.UseVisualStyleBackColor = True
        '
        'rbtnDifficile
        '
        Me.rbtnDifficile.AutoSize = True
        Me.rbtnDifficile.Location = New System.Drawing.Point(20, 82)
        Me.rbtnDifficile.Name = "rbtnDifficile"
        Me.rbtnDifficile.Size = New System.Drawing.Size(59, 17)
        Me.rbtnDifficile.TabIndex = 9
        Me.rbtnDifficile.TabStop = True
        Me.rbtnDifficile.Text = "Difficile"
        Me.rbtnDifficile.UseVisualStyleBackColor = True
        '
        'panelDifficulte
        '
        Me.panelDifficulte.Controls.Add(Me.rbtnDifficile)
        Me.panelDifficulte.Controls.Add(Me.rbtnMoyen)
        Me.panelDifficulte.Controls.Add(Me.rbtnFacile)
        Me.panelDifficulte.Location = New System.Drawing.Point(502, 247)
        Me.panelDifficulte.Name = "panelDifficulte"
        Me.panelDifficulte.Size = New System.Drawing.Size(129, 109)
        Me.panelDifficulte.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelDifficulte)
        Me.Controls.Add(Me.comboxNom)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDifficulte.ResumeLayout(False)
        Me.panelDifficulte.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents comboxNom As ComboBox
    Friend WithEvents rbtnFacile As RadioButton
    Friend WithEvents rbtnMoyen As RadioButton
    Friend WithEvents rbtnDifficile As RadioButton
    Friend WithEvents panelDifficulte As Panel
End Class
