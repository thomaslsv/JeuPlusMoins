Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LeNombre As Integer
        Dim NbCoups As Integer = 0
        Randomize()
        LeNombre = Int((Rnd() * 100) + 1)
        'MessageBox.Show(LeNombre)
        Dim laReponse As Integer
        Do While laReponse <> LeNombre
            laReponse = InputBox("Quel est le nombre mystère ?", "Jeu Plus ou Moins")
            NbCoups += 1

            If laReponse > LeNombre Then
                MessageBox.Show("Plus petit !")
            ElseIf laReponse < LeNombre Then
                MessageBox.Show("Plus grand !")
            End If

        Loop

        'Si le nombre a été trouvé
        MessageBox.Show("Bravo, Tu as trouvé le nombre mystère en " & NbCoups & " coups")

        'MessageBox.Show(LeNombre)
        'MessageBox.Show(laReponse)
    End Sub
End Class
