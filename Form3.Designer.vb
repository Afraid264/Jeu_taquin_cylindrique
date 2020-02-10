<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.labelNom = New System.Windows.Forms.Label()
        Me.labelNBParties = New System.Windows.Forms.Label()
        Me.labelNBVictoires = New System.Windows.Forms.Label()
        Me.labelRecord = New System.Windows.Forms.Label()
        Me.comboxJoueurs = New System.Windows.Forms.ComboBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.labelTemps = New System.Windows.Forms.Label()
        Me.listNom = New System.Windows.Forms.ListBox()
        Me.listTemps = New System.Windows.Forms.ListBox()
        Me.btnTriAlpha = New System.Windows.Forms.Button()
        Me.btnTriTemps = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelClic = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Récapitulatif des scores des joueurs"
        '
        'labelNom
        '
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(92, 88)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(39, 13)
        Me.labelNom.TabIndex = 2
        Me.labelNom.Text = "Label2"
        '
        'labelNBParties
        '
        Me.labelNBParties.AutoSize = True
        Me.labelNBParties.Location = New System.Drawing.Point(92, 151)
        Me.labelNBParties.Name = "labelNBParties"
        Me.labelNBParties.Size = New System.Drawing.Size(39, 13)
        Me.labelNBParties.TabIndex = 3
        Me.labelNBParties.Text = "Label2"
        '
        'labelNBVictoires
        '
        Me.labelNBVictoires.AutoSize = True
        Me.labelNBVictoires.Location = New System.Drawing.Point(92, 217)
        Me.labelNBVictoires.Name = "labelNBVictoires"
        Me.labelNBVictoires.Size = New System.Drawing.Size(39, 13)
        Me.labelNBVictoires.TabIndex = 4
        Me.labelNBVictoires.Text = "Label2"
        '
        'labelRecord
        '
        Me.labelRecord.AutoSize = True
        Me.labelRecord.Location = New System.Drawing.Point(92, 289)
        Me.labelRecord.Name = "labelRecord"
        Me.labelRecord.Size = New System.Drawing.Size(39, 13)
        Me.labelRecord.TabIndex = 5
        Me.labelRecord.Text = "Label2"
        '
        'comboxJoueurs
        '
        Me.comboxJoueurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboxJoueurs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboxJoueurs.FormattingEnabled = True
        Me.comboxJoueurs.Location = New System.Drawing.Point(12, 49)
        Me.comboxJoueurs.Name = "comboxJoueurs"
        Me.comboxJoueurs.Size = New System.Drawing.Size(216, 21)
        Me.comboxJoueurs.Sorted = True
        Me.comboxJoueurs.TabIndex = 6
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(349, 381)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(75, 23)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre de parties jouées"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre de parties gagnées"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Record du joueur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(479, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Classement"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(61, 319)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(94, 13)
        Me.label7.TabIndex = 12
        Me.label7.Text = "Temps de jeu total"
        '
        'labelTemps
        '
        Me.labelTemps.AutoSize = True
        Me.labelTemps.Location = New System.Drawing.Point(61, 357)
        Me.labelTemps.Name = "labelTemps"
        Me.labelTemps.Size = New System.Drawing.Size(39, 13)
        Me.labelTemps.TabIndex = 13
        Me.labelTemps.Text = "Label6"
        '
        'listNom
        '
        Me.listNom.FormattingEnabled = True
        Me.listNom.Location = New System.Drawing.Point(379, 165)
        Me.listNom.Name = "listNom"
        Me.listNom.Size = New System.Drawing.Size(150, 95)
        Me.listNom.Sorted = True
        Me.listNom.TabIndex = 14
        '
        'listTemps
        '
        Me.listTemps.FormattingEnabled = True
        Me.listTemps.Location = New System.Drawing.Point(535, 165)
        Me.listTemps.Name = "listTemps"
        Me.listTemps.Size = New System.Drawing.Size(219, 95)
        Me.listTemps.TabIndex = 15
        '
        'btnTriAlpha
        '
        Me.btnTriAlpha.Location = New System.Drawing.Point(379, 289)
        Me.btnTriAlpha.Name = "btnTriAlpha"
        Me.btnTriAlpha.Size = New System.Drawing.Size(120, 26)
        Me.btnTriAlpha.TabIndex = 16
        Me.btnTriAlpha.Text = "Tri Alphabétique"
        Me.btnTriAlpha.UseVisualStyleBackColor = True
        '
        'btnTriTemps
        '
        Me.btnTriTemps.Location = New System.Drawing.Point(584, 289)
        Me.btnTriTemps.Name = "btnTriTemps"
        Me.btnTriTemps.Size = New System.Drawing.Size(120, 26)
        Me.btnTriTemps.TabIndex = 17
        Me.btnTriTemps.Text = "Tri Temporel"
        Me.btnTriTemps.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nombre de Clic"
        '
        'labelClic
        '
        Me.labelClic.AutoSize = True
        Me.labelClic.Location = New System.Drawing.Point(92, 415)
        Me.labelClic.Name = "labelClic"
        Me.labelClic.Size = New System.Drawing.Size(39, 13)
        Me.labelClic.TabIndex = 19
        Me.labelClic.Text = "Label6"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelClic)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTriTemps)
        Me.Controls.Add(Me.btnTriAlpha)
        Me.Controls.Add(Me.listTemps)
        Me.Controls.Add(Me.listNom)
        Me.Controls.Add(Me.labelTemps)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.comboxJoueurs)
        Me.Controls.Add(Me.labelRecord)
        Me.Controls.Add(Me.labelNBVictoires)
        Me.Controls.Add(Me.labelNBParties)
        Me.Controls.Add(Me.labelNom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelNom As Label
    Friend WithEvents labelNBParties As Label
    Friend WithEvents labelNBVictoires As Label
    Friend WithEvents labelRecord As Label
    Friend WithEvents comboxJoueurs As ComboBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents label7 As Label
    Friend WithEvents labelTemps As Label
    Friend WithEvents listNom As ListBox
    Friend WithEvents listTemps As ListBox
    Friend WithEvents btnTriAlpha As Button
    Friend WithEvents btnTriTemps As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents labelClic As Label
End Class
