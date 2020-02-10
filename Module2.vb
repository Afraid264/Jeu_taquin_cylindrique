Module Module2

    Structure Joueur
        Dim nom As String
        Dim nbParties As Integer
        Dim nbVictoires As Integer
        Dim record As Integer
        Dim tempsJeu As Integer
        Dim nbClics As Integer
    End Structure

    Dim tabJoueur(0) As Joueur
    Dim nbPers As Integer = 0

    Function existeDeja(ByRef nom As String) As Boolean
        For Each joueur In tabJoueur
            If joueur.nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function
    Sub ajouterPersonne(ByRef nom As String)
        If nbPers = 0 Then
            Dim j As Joueur
            j.nom = nom
            j.nbParties = 0
            j.nbVictoires = 0
            j.record = -1
            j.tempsJeu = 0
            j.nbClics = 0
            tabJoueur(0) = j
            Form3.comboxJoueurs.Items.Add(j.nom)
            nbPers += 1
        Else
            ReDim Preserve tabJoueur(nbPers)
            Dim j As Joueur
            j.nom = nom
            j.nbParties = 0
            j.nbVictoires = 0
            j.record = -1
            j.tempsJeu = 0
            j.nbClics = 0
            tabJoueur(nbPers) = j
            Form3.comboxJoueurs.Items.Add(j.nom)
            nbPers += 1
        End If
    End Sub
    Sub ajouterPersonne(ByRef joueur As Joueur)
        tabJoueur(nbPers) = joueur
        Form3.comboxJoueurs.Items.Add(joueur.nom)
        nbPers += 1
        ReDim Preserve tabJoueur(nbPers)
    End Sub
    Function indexPersonne(ByRef nom As String) As Integer
        Dim i As Integer = 0
        For Each joueur In tabJoueur
            If joueur.nom = nom Then
                Return i
            End If
            i += 1
        Next
        Return -1
    End Function
    Sub remplirTabStat(ByVal temps As Integer, ByRef nom As String, ByVal nbClic As Integer, ByVal abandon As Boolean)
        Dim index As Integer = indexPersonne(nom)
        tabJoueur(index).nbParties += 1
        tabJoueur(index).nbClics += nbClic
        If temps > 0 And abandon = False Then
            tabJoueur(index).nbVictoires += 1
            tabJoueur(index).tempsJeu += temps
            If tabJoueur(index).record = -1 Then
                tabJoueur(index).record = temps
            Else
                If temps < tabJoueur(index).record Then
                    tabJoueur(index).record = temps
                End If
            End If
        ElseIf abandon = True And temps > 0 Then
            tabJoueur(index).tempsJeu += temps
        End If


    End Sub
    Function getNBParties(ByVal index As Integer) As Integer
        Return tabJoueur(index).nbParties
    End Function
    Function getNBVictoires(ByVal index As Integer) As Integer
        Return tabJoueur(index).nbVictoires
    End Function
    Function getRecord(ByVal index As Integer) As Integer
        Return tabJoueur(index).record
    End Function
    Function getTempsDeJeu(ByVal index As Integer) As Integer
        Return tabJoueur(index).tempsJeu
    End Function
    Function getJoueur(ByVal index As Integer) As Joueur
        Return tabJoueur(index)
    End Function
    Function getnbPers() As Integer
        Return nbPers
    End Function
    Sub Main()
        Application.Run(Form2)
    End Sub

    Sub afficherStat(ByRef nom As String)
        Dim index As Integer = indexPersonne(nom)
        Dim record As Integer = getRecord(index)
        Dim joueur As Joueur = getJoueur(index)
        Form3.labelNom.Text = joueur.nom
        Form3.labelNBParties.Text = joueur.nbParties.ToString()
        Form3.labelNBVictoires.Text = joueur.nbVictoires.ToString()
        If record > 0 Then
            Form3.labelRecord.Text = (joueur.record \ 60).ToString() & " minutes " & (joueur.record Mod 60).ToString() & " secondes"
        Else
            Form3.labelRecord.Text = "-- : --"
        End If
        Dim temps As Integer = joueur.tempsJeu
        Form3.labelTemps.Text = temps \ 3600 & " heures " & temps \ 60 & " minutes " & temps Mod 60 & " secondes"
        Form3.labelClic.Text = joueur.nbClics.ToString()
    End Sub
End Module
