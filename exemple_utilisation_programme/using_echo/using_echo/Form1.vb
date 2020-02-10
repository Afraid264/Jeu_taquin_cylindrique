Public Class Form1

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        TextBoxTexteRepondu.Text = ""
        ecrit_fichier()
        appelle_echo()
        TextBoxTexteRepondu.Text = lit_fichier()
    End Sub
    Sub ecrit_fichier()
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("TexteSaisi.txt", False, utf8WithoutBom)
        file.WriteLine(TextBoxTexteSaisi.Text)
        file.Close()
    End Sub
    Function lit_fichier() As String
        Return My.Computer.FileSystem.ReadAllText("TexteRepondu.txt")
    End Function
    Sub appelle_echo()
        '"echo.exe < TexteSaisi.txt > TexteRepondu.txt"

        Dim commande As String =
            "echo.exe < TexteSaisi.txt > TexteRepondu.txt"

        Dim p As New Process
        Dim psi As New ProcessStartInfo(
            "cmd.exe",
            "/c " & commande
        )
        p.StartInfo = psi
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        LabelWaiting.Text = ChrW(8987)
        p.Start()
        p.WaitForExit()
        LabelWaiting.Text = ""
    End Sub
End Class
