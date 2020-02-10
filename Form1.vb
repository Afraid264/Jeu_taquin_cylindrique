Public Class Form1

    Dim TEMPS_JEU As Integer
    Dim time As Integer
    '300 secondes soit 5 minutes
    Dim caseTab() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}
    Dim coordTab(1)() As Integer
    Dim premier_clic As Boolean = True
    Dim pause As Boolean = False
    Dim nbClic As Integer = 0
    Dim solution as Boolean = False


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        Dim Minutes As Integer = time \ 60
        Dim Secondes As Integer = time Mod 60
        Dim reponse As MsgBoxResult
        labelTemps.Text = Minutes.ToString("00") & ":" & Secondes.ToString("00")
        If Minutes = 0 And Secondes = 0 Then
            Timer1.Stop()
            remplirTabStat(TEMPS_JEU, labelJoueur.Text, nbClic, False)
            reponse = MsgBox("Vous avez perdu ! Voulez-vous recommencez ?", vbYesNo)
            If reponse = vbYes Then
                recommencer(caseTab, coordTab, PanelBTN)
                time = TEMPS_JEU
                premier_clic = True
            Else
                quitter(Me)
                Form2.Show()
            End If
        End If
            If Minutes < 1 And Secondes < 30 Then
            labelTemps.ForeColor = Color.Red
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initCoordTab(coordTab)
        MelangeTab(caseTab, coordTab)
        Dim nb As Integer = 15

        For Each btn As Button In PanelBTN.Controls
            btn.Text = caseTab(nb)
            If caseTab(nb) = 16 Then
                btn.Visible = False
            End If
            nb -= 1
        Next
        TEMPS_JEU = Form2.getTemps()
        time = TEMPS_JEU
        labelTemps.Text = (TEMPS_JEU \ 60).ToString("00") & ":" & (TEMPS_JEU Mod 60).ToString("00")
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click,
        Button2.Click, Button3.Click,
        Button4.Click, Button5.Click,
        Button6.Click, Button7.Click,
        Button8.Click, Button9.Click,
        Button10.Click, Button11.Click,
        Button12.Click, Button13.Click,
        Button14.Click, Button15.Click,
        Button16.Click
        nbClic += 1
        If premier_clic Then
            premier_clic = False
            nbClic = 1
            Timer1.Start()
        End If
        If peutBouger(caseTab, coordTab, Val(sender.text)) >= 0 And pause = False Then
            deplacer(Val(sender.text), indexBTN(caseTab, Val(sender.text)), indexVIDE(caseTab), caseTab, coordTab, PanelBTN)
            If estGagne(caseTab) And solution = False Then
                Timer1.Stop()
                Dim temps_Victoire As Integer = TEMPS_JEU - time
                Dim reponse As MsgBoxResult
                remplirTabStat(temps_Victoire, labelJoueur.Text, nbClic, False)
                reponse = MsgBox("Vous avez Réussi en : " & temps_Victoire \ 60 & " minutes " & temps_Victoire Mod 60 & " secondes" & vbCr & vbCr & " Voulez-vous rejouer?", vbYesNo)
                If reponse = vbYes Then
                    recommencer(caseTab, coordTab, PanelBTN)
                    time = TEMPS_JEU
                    premier_clic = True
                Else
                    quitter(Me)
                    Form2.Show()
                End If
            End If
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If pause = False Then
            pause = True
            Timer1.Stop()
        Else
            pause = False
            Timer1.Start()
        End If
    End Sub

    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
	
        remplirTabStat(TEMPS_JEU - time, labelJoueur.Text, nbClic, True)
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub btnSolution_Click(sender As Object, e As EventArgs) Handles btnSolution.Click
        btnPause.PerformClick()
        Dim reponse As MsgBoxResult = MsgBox("Etes-vous sur de vouloir abandonner et voir la solution ?", vbYesNo)
        If reponse = vbYes Then
            remplirTabStat(TEMPS_JEU - time, labelJoueur.Text, nbClic, True)
            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("Taquin.txt", False, utf8WithoutBom)
            file.WriteLine("4 4")
            For i = 0 To 15
                If i Mod 4 = 0 And i > 0 Then
                    file.WriteLine(vbCr)
                End If
                If caseTab(i) = 16 Then
                    file.Write("# ")
                Else
                    file.Write(caseTab(i) & " ")
                End If

            Next
            file.Close()

            Dim commande As String = "/c TestSprint5.exe < Taquin.txt > solution.txt"

            Dim p As New Process
            Dim psi As New ProcessStartInfo(
                "cmd.exe",
                commande)
            p.StartInfo = psi
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.Start()
            p.WaitForExit()
            Module1.solution(caseTab, coordTab, PanelBTN)
        Else
            MsgBox("Le temps est mis en pause, appuyez sur pause pour relancer !")
        End If


    End Sub

    Function getTEMPS_JEU() As Integer
        Return TEMPS_JEU
    End Function

    Function getTime() As Integer
        Return time
    End Function

    Sub setTime()
        time = TEMPS_JEU
    End Sub

    Sub setPremierClic()
        premier_clic = True
    End Sub
    Function getnbClic() As Integer
        Return nbClic
    End Function
    Function getLabelJoueur() As String
        Return labelJoueur.Text
    End Function
End Class
