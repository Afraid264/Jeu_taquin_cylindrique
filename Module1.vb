
Imports System.IO
Imports System.Threading

Module Module1
    Const NUM_CASE_VIDE As Integer = 16
    Structure Coordonnee
        Dim Ligne As Integer
        Dim Colonne As Integer
    End Structure


    Sub initCoordTab(ByRef coordTab As Integer()())
        ReDim coordTab(0)(15)
        ReDim coordTab(1)(15)
        For i As Integer = 0 To 15
            coordTab(0)(i) = i \ 4
            coordTab(1)(i) = i Mod 4
        Next
    End Sub
    Sub setCoordTab(ByVal index As Integer, ByVal ligne As Integer, ByVal col As Integer, ByRef coordTab() As Coordonnee)
        coordTab(index).Ligne = ligne
        coordTab(index).Colonne = col
    End Sub
    Public Sub MelangeTab(ByRef caseTab() As Integer, ByRef coordTab As Integer()())
        If caseTab Is Nothing Or coordTab Is Nothing Then
            Throw New NullReferenceException
        End If
        Dim ran As New Random()
        Dim swap As Integer
        Dim rd As Integer
        For i As Integer = 15 To 0 Step -1
            rd = ran.Next(0, i)
            swap = caseTab(i)
            caseTab(i) = caseTab(rd)
            caseTab(rd) = swap
        Next
        Dim compteur As Integer = 0
        For Each valeur In caseTab
            coordTab(0)(valeur - 1) = compteur \ 4
            coordTab(1)(valeur - 1) = compteur Mod 4
            compteur += 1
        Next
    End Sub
    Function indexBTN(ByRef caseTab() As Integer, ByRef numBTN As Integer) As Integer
        Dim i As Integer = 0
        For Each numbutt In caseTab
            If numBTN = numbutt Then
                Return i
            End If
            i += 1
        Next
        Return -1
    End Function
    Function indexVIDE(ByRef caseTab() As Integer) As Integer
        Return indexBTN(caseTab, 16)
    End Function

    Function peutBouger(ByRef caseTab() As Integer, ByRef coordTab As Integer()(), ByRef numBTN As Integer) As Integer
        If numBTN = 16 Then
            Return -1
        End If
        Dim index As Integer = indexBTN(caseTab, numBTN)
        Dim coordBTN As Coordonnee
        coordBTN.Ligne = coordTab(0)(numBTN - 1)
        coordBTN.Colonne = coordTab(1)(numBTN - 1)
        'PREMIERE LIGNE DU TAQUIN
        If coordBTN.Ligne = 0 And coordBTN.Colonne < 3 And coordBTN.Colonne > 0 Then 'Deux cases du milieu
            If caseTab(index + 4) = 16 Or caseTab(index - 1) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 0 And coordBTN.Colonne = 0 Then 'Coin Gauche
            If caseTab(index + 4) = 16 Or caseTab(index + 3) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 0 And coordBTN.Colonne = 3 Then 'Coin Droite
            If caseTab(index + 4) = 16 Or caseTab(index - 3) = 16 Or caseTab(index - 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        End If
        'DEUXIEME LIGNE DU TAQUIN
        If coordBTN.Ligne = 1 And coordBTN.Colonne < 3 And coordBTN.Colonne > 0 Then 'Deux cases du milieu
            If caseTab(index + 4) = 16 Or caseTab(index - 4) = 16 Or caseTab(index - 1) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 1 And coordBTN.Colonne = 0 Then 'Coin Gauche
            If caseTab(index + 4) = 16 Or caseTab(index - 4) = 16 Or caseTab(index + 3) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 1 And coordBTN.Colonne = 3 Then 'Coin Droite
            If caseTab(index + 4) = 16 Or caseTab(index - 4) = 16 Or caseTab(index - 3) = 16 Or caseTab(index - 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        End If
        'TROISIEME LIGNE DU TAQUIN
        If coordBTN.Ligne = 2 And coordBTN.Colonne < 3 And coordBTN.Colonne > 0 Then 'Deux cases du milieu
            If caseTab(index + 4) = 16 Or caseTab(index - 4) = 16 Or caseTab(index - 1) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 2 And coordBTN.Colonne = 0 Then 'Coin Gauche
            If caseTab(index + 4) = 16 Or caseTab(index - 4) = 16 Or caseTab(index + 3) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 2 And coordBTN.Colonne = 3 Then 'Coin Droite
            If caseTab(index + 4) = 16 Or caseTab(index - 4) = 16 Or caseTab(index - 3) = 16 Or caseTab(index - 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        End If
        'QUATRIEME LIGNE DU TAQUIN
        If coordBTN.Ligne = 3 And coordBTN.Colonne < 3 And coordBTN.Colonne > 0 Then 'Deux cases du milieu
            If caseTab(index - 4) = 16 Or caseTab(index - 1) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 3 And coordBTN.Colonne = 0 Then 'Coin Gauche
            If caseTab(index - 4) = 16 Or caseTab(index + 3) = 16 Or caseTab(index + 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        ElseIf coordBTN.Ligne = 3 And coordBTN.Colonne = 3 Then 'Coin Droite
            If caseTab(index - 4) = 16 Or caseTab(index - 3) = 16 Or caseTab(index - 1) = 16 Then
                Return indexVIDE(caseTab)
            Else
                Return -1
            End If
        End If
        Return -1
    End Function
    Sub deplacer(ByRef numBTN As Integer, ByRef indexCase As Integer, ByRef indexCaseVide As Integer, ByRef casetab() As Integer, ByRef coordTab As Integer()(), ByRef panelBTN As Panel)
        Dim swapCase As Integer = casetab(indexCase)
        casetab(indexCase) = casetab(indexCaseVide)
        casetab(indexCaseVide) = swapCase
        Dim swapCoord As Coordonnee
        swapCoord.Ligne = coordTab(0)(numBTN - 1)
        swapCoord.Colonne = coordTab(1)(numBTN - 1)
        coordTab(0)(numBTN - 1) = coordTab(0)(NUM_CASE_VIDE - 1)
        coordTab(1)(numBTN - 1) = coordTab(1)(NUM_CASE_VIDE - 1)
        coordTab(0)(NUM_CASE_VIDE - 1) = swapCoord.Ligne
        coordTab(1)(NUM_CASE_VIDE - 1) = swapCoord.Colonne
        Dim i As Integer = 15
        For Each btn In panelBTN.Controls
            If i = indexCase Then
                btn.Visible = False
                btn.text = 16
            End If
            If i = indexCaseVide Then
                btn.Visible = True
                btn.text = swapCase
                btn.Select()
            End If
            i -= 1
        Next
    End Sub
    Function estGagne(ByRef caseTab() As Integer) As Boolean
        Dim sol1() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}
        'Dim sol2() As Integer = {4, 3, 2, 1, 8, 7, 6, 5, 12, 11, 10, 9, 16, 15, 14, 13}
        'Dim sol3() As Integer = {3, 2, 1, 4, 7, 6, 5, 8, 11, 10, 9, 12, 15, 14, 13, 16}
        'Dim sol4() As Integer = {2, 1, 4, 3, 6, 5, 8, 7, 10, 9, 12, 11, 14, 13, 16, 15}
        'Dim cas1 As Boolean
        'Dim cas2 As Boolean
        'Dim cas3 As Boolean
        'Dim cas4 As Boolean
        'For i As Integer = 0 To 15
        '    If caseTab(i) <> sol1(i) Then
        '        cas1 = False
        '        Exit For
        '    End If
        'Next
        'For i As Integer = 0 To 15
        '    If caseTab(i) <> sol2(i) Then
        '        cas2 = False
        '        Exit For
        '    End If
        'Next
        'For i As Integer = 0 To 15
        '    If caseTab(i) <> sol3(i) Then
        '        cas3 = False
        '        Exit For
        '    End If
        'Next
        'For i As Integer = 0 To 15
        '    If caseTab(i) <> sol4(i) Then
        '        cas4 = False
        '        Exit For
        '    End If
        'Next
        'If cas1 = False And cas2 = False And cas3 = False And cas4 = False Then
        '    Return False
        'Else Then
        '    Return True
        'End If
        For i As Integer = 0 To 15
            If caseTab(i) <> sol1(i) Then
                Return False
            End If
        Next
        Return True
    End Function
    Sub recommencer(ByRef caseTab() As Integer, ByRef coordTab()() As Integer, ByRef PanelBTN As Panel)
        initCoordTab(coordTab)
        MelangeTab(caseTab, coordTab)
        Dim nb As Integer = 15

        For Each btn As Button In PanelBTN.Controls
            btn.Visible = True
            btn.Text = caseTab(nb)
            If caseTab(nb) = 16 Then
                btn.Visible = False
            End If
            nb -= 1
        Next
    End Sub
    Sub quitter(ByRef formulaire As Form)
        formulaire.Close()
    End Sub

    Sub solution(ByRef caseTab() As Integer, ByRef coordTab()() As Integer, ByRef panelBTN As Panel)
        Dim monStreamReader As StreamReader = New StreamReader("solution.txt")
        Dim ligne As String
        Dim index As Integer
        Do
            ligne = monStreamReader.ReadLine()
            index = indexVIDE(caseTab)
            If ligne = "OUEST" Then
                If index = 0 Or index = 4 Or index = 8 Or index = 12 Then
                    'commande = "button" & index + 3 & ".Performclick()"
                    deplacer(caseTab(index + 3), index + 3, index, caseTab, coordTab, panelBTN)
                Else
                    'commande = "button" & index - 1 & ".Performclick()"
                    deplacer(caseTab(index - 1), index - 1, index, caseTab, coordTab, panelBTN)
                End If
            ElseIf ligne = "EST" Then
                If index = 3 Or index = 7 Or index = 11 Or index = 15 Then
                    'commande = "button" & index - 3 & ".Performclick()"
                    deplacer(caseTab(index - 3), index - 3, index, caseTab, coordTab, panelBTN)
                Else
                    'commande = "button" & index + 1 & ".Performclick()"
                    deplacer(caseTab(index + 1), index + 1, index, caseTab, coordTab, panelBTN)
                End If
            ElseIf ligne = "SUD" Then
                'commande = "button" & index + 4 & ".Performclick()"
                deplacer(caseTab(index + 4), index + 4, index, caseTab, coordTab, panelBTN)

            ElseIf ligne = "NORD" Then
                'commande = "button" & index - 4 & ".Performclick()"
                deplacer(caseTab(index - 4), index - 4, index, caseTab, coordTab, panelBTN)
            End If
            panelBTN.Refresh()
            Thread.Sleep(500)
        Loop Until ligne Is Nothing
        monStreamReader.Close()
        Form1.btnPause.PerformClick()
        MsgBox("Il n'y a pas de solution pour ce taquin !")
        If estGagne(caseTab) Then
            Form1.Timer1.Stop()
            Dim temps_Victoire As Integer = Form1.getTEMPS_JEU() - Form1.getTime()
            Dim reponse As MsgBoxResult
            remplirTabStat(temps_Victoire, Form1.getLabelJoueur(), Form1.getnbClic(), False)
            reponse = MsgBox("Vous avez Réussi en : " & temps_Victoire \ 60 & " minutes " & temps_Victoire Mod 60 & " secondes" & vbCr & vbCr & " Voulez-vous rejouer?", vbYesNo)
            If reponse = vbYes Then
                recommencer(caseTab, coordTab, panelBTN)
                Form1.setTime()
                Form1.setPremierClic()
            Else
                quitter(Form1)
                Form2.Show()
            End If
        End If
    End Sub
End Module
