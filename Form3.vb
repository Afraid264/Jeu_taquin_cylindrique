Public Class Form3
    Dim ListDeNom(0) As String
    Dim ListDeTemps(0) As Integer
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub form3_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        afficherStat(comboxJoueurs.Items(0))
        Dim nbPers As Integer = getnbPers()
        ReDim ListDeNom(nbPers - 1)
        ReDim ListDeTemps(nbPers - 1)
        For i As Integer = 0 To nbPers - 1
            ListDeNom(i) = getJoueur(i).nom
            ListDeTemps(i) = getJoueur(i).record
        Next
        Dim temps As Integer
        For Each nom As String In listNom.Items
            temps = getRecord(indexPersonne(nom))
            If temps >= 0 Then
                listTemps.Items.Add((temps \ 60).ToString() & " minutes " & (temps Mod 60).ToString() & " secondes")
            Else
                listTemps.Items.Add(" ")
            End If
        Next
        btnTriAlpha.PerformClick()
    End Sub


    Private Sub comboxJoueurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxJoueurs.SelectedIndexChanged
        afficherStat(sender.text)
    End Sub


    Private Sub btnTriAlpha_Click(sender As Object, e As EventArgs) Handles btnTriAlpha.Click
        listNom.Items.Clear()
        listTemps.Items.Clear()
        listNom.Sorted = True
        For Each name As String In ListDeNom
            listNom.Items.Add(name)
        Next
        Dim temps As Integer
        For Each name As String In listNom.Items
            temps = getJoueur(indexPersonne(name)).record
            If temps > 0 Then
                listTemps.Items.Add((temps \ 60).ToString() & " minutes " & (temps Mod 60).ToString() & " secondes")
            End If
        Next
        btnTriTemps.Visible = True
        btnTriAlpha.Visible = False
    End Sub

    Private Sub btnTriTemps_Click(sender As Object, e As EventArgs) Handles btnTriTemps.Click
        listNom.Items.Clear()
        listTemps.Items.Clear()
        Dim copyTemps(getnbPers() - 1) As Integer
        Dim indices(getnbPers() - 1) As Integer
        Dim cpt As Integer = 0
        For Each tps As Integer In ListDeTemps
            copyTemps(cpt) = tps
            indices(cpt) = cpt
            cpt += 1
        Next
        Dim swapTemps As Integer
        Dim swapIndice As Integer
        For i As Integer = 0 To getnbPers() - 2
            For j As Integer = 0 To getnbPers() - 2
                If copyTemps(j + 1) < copyTemps(j) And copyTemps(j + 1) > 0 Then
                    swapTemps = copyTemps(j + 1)
                    swapIndice = indices(j + 1)
                    copyTemps(j + 1) = copyTemps(j)
                    indices(j + 1) = indices(j)
                    copyTemps(j) = swapTemps
                    indices(j) = swapIndice
                End If
            Next
        Next
        Dim temps As Integer
        listNom.Sorted = False
        For k As Integer = 0 To getnbPers() - 1
            listNom.Items.Add(ListDeNom(indices(k)))
            temps = copyTemps(k)
            If temps > 0 Then
                listTemps.Items.Add((temps \ 60).ToString() & " minutes " & (temps Mod 60).ToString() & " secondes")
            Else
                listTemps.Items.Add("")
            End If
        Next

        btnTriTemps.Visible = False
        btnTriAlpha.Visible = True
    End Sub
End Class