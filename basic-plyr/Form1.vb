Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()


    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()


    End Sub
    Dim paths As String()
    Dim filenames As String()
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (OpenFileDialog2.ShowDialog = DialogResult.OK) Then
            filenames = OpenFileDialog2.SafeFileNames
            paths = OpenFileDialog2.FileNames
            For i As Integer = 0 To filenames.Length - 1
                ListBox1.Items.Add(filenames(i))
            Next


        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL=paths(ListBox1.SelectedIndex)
    End Sub
End Class
