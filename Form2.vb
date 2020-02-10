Imports System.IO

Public Class Form2
    Dim TEMPS_DE_JEU As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboxNom.Select()
        Dim j As Joueur
        Dim monStreamReader As StreamReader = New StreamReader("Joueurs.txt")
        Dim ligne As String
        Dim cpt As Integer = 0
        Do
            ligne = monStreamReader.ReadLine()
            If cpt Mod 6 = 0 Then
                j.nom = ligne
            ElseIf cpt Mod 6 = 1 Then
                j.nbParties = Val(ligne)
            ElseIf cpt Mod 6 = 2 Then
                j.nbVictoires = Val(ligne)
            ElseIf cpt Mod 6 = 3 Then
                j.record = Val(ligne)
            ElseIf cpt Mod 6 = 4 Then
                j.tempsJeu = Val(ligne)
            ElseIf cpt Mod 6 = 5 Then
                j.nbClics = Val(ligne)
                ajouterPersonne(j)
                comboxNom.Items.Add(j.nom)
            End If
            cpt += 1
        Loop Until ligne Is Nothing
        monStreamReader.Close()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim reponse As MsgBoxResult
        reponse = MsgBox("Etes-vous sur de vouloir quitter ?", vbYesNo + MsgBoxStyle.Information + vbDefaultButton1)
        If reponse = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim niveau As Integer = 0

        For Each rbtn As RadioButton In panelDifficulte.Controls
            If rbtn.Checked = True Then
                If rbtn.Text = "Facile" Then
                    niveau = 3
                ElseIf rbtn.Text = "Moyen" Then
                    niveau = 2
                ElseIf rbtn.Text = "Difficile" Then
                    niveau = 1
                End If
            End If
        Next
        If comboxNom.Text <> "" And existeDeja(comboxNom.Text) = False And niveau > 0 Then
            ajouterPersonne(comboxNom.Text)
            comboxNom.Items.Add(comboxNom.Text)
            TEMPS_DE_JEU = niveau * 100
            Me.Hide()
            Form1.Show()
            Form1.labelJoueur.Text = comboxNom.Text
        ElseIf comboxNom.Text = "" Then
            MsgBox("Vous devez inscrire un nom !")
            comboxNom.Select()
        ElseIf niveau = 0 Then
            MsgBox("Vous devez choisir une difficulté de niveau !")
        ElseIf existeDeja(comboxNom.Text) Then
            TEMPS_DE_JEU = niveau * 100
            Me.Hide()
            Form1.Show()
            Form1.labelJoueur.Text = comboxNom.Text
        End If
    End Sub


    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub comboxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboxNom.KeyPress
        If e.KeyChar = vbCr Then
            btnStart.PerformClick()
        End If
    End Sub

    Private Sub Form2_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Dim nbPers As Integer = getnbPers()
        Dim joueur As Joueur
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("Joueurs.txt", False)
        For i As Integer = 0 To nbPers - 1
            joueur = getJoueur(i)
            file.WriteLine(joueur.nom)
            file.WriteLine(joueur.nbParties.ToString())
            file.WriteLine(joueur.nbVictoires.ToString())
            file.WriteLine(joueur.record.ToString())
            file.WriteLine(joueur.tempsJeu.ToString())
            file.WriteLine(joueur.nbClics.ToString())
        Next
        file.Close()
    End Sub

    Function getTemps() As Integer
        Return TEMPS_DE_JEU
    End Function
End Class