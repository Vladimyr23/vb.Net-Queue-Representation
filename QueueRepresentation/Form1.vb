Public Class Form1
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Dim myAssembly As System.Reflection.Assembly = _ System.Reflection.Assembly.GetExecutingAssembly()
        ''Dim myStream As Stream = _ myAssembly.GetManifestResourceStream("EmbeddingExample.polymer5features.jpg")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If RadioButton1.Checked Then
            If PictureBox1.Image Is Nothing Then
                PictureBox1.Image = My.Resources.polymer5features
            ElseIf PictureBox2.Image Is Nothing Then
                PictureBox2.Image = My.Resources.polymer5features
            ElseIf PictureBox3.Image Is Nothing Then
                PictureBox3.Image = My.Resources.polymer5features
            ElseIf PictureBox4.Image Is Nothing Then
                PictureBox4.Image = My.Resources.polymer5features
            ElseIf PictureBox5.Image Is Nothing Then
                PictureBox5.Image = My.Resources.polymer5features
            Else
                MessageBox.Show("The queue is full", "5 Elements Limit",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If
        ElseIf RadioButton2.Checked Then
            If PictureBox1.Image Is Nothing Then
                PictureBox1.Image = My.Resources._10
            ElseIf PictureBox2.Image Is Nothing Then
                PictureBox2.Image = My.Resources._10
            ElseIf PictureBox3.Image Is Nothing Then
                PictureBox3.Image = My.Resources._10
            ElseIf PictureBox4.Image Is Nothing Then
                PictureBox4.Image = My.Resources._10
            ElseIf PictureBox5.Image Is Nothing Then
                PictureBox5.Image = My.Resources._10
            Else
                MessageBox.Show("The queue is full", "5 Elements Limit",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If
        ElseIf RadioButton3.Checked Then
            If PictureBox1.Image Is Nothing Then
                PictureBox1.Image = My.Resources._20
            ElseIf PictureBox2.Image Is Nothing Then
                PictureBox2.Image = My.Resources._20
            ElseIf PictureBox3.Image Is Nothing Then
                PictureBox3.Image = My.Resources._20
            ElseIf PictureBox4.Image Is Nothing Then
                PictureBox4.Image = My.Resources._20
            ElseIf PictureBox5.Image Is Nothing Then
                PictureBox5.Image = My.Resources._20
            Else
                MessageBox.Show("The queue is full", "5 Elements Limit",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If
        ElseIf RadioButton4.Checked Then
            If PictureBox1.Image Is Nothing Then
                PictureBox1.Image = My.Resources._50
            ElseIf PictureBox2.Image Is Nothing Then
                PictureBox2.Image = My.Resources._50
            ElseIf PictureBox3.Image Is Nothing Then
                PictureBox3.Image = My.Resources._50
            ElseIf PictureBox4.Image Is Nothing Then
                PictureBox4.Image = My.Resources._50
            ElseIf PictureBox5.Image Is Nothing Then
                PictureBox5.Image = My.Resources._50
            Else
                MessageBox.Show("The queue is full", "5 Elements Limit",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        PictureBox1.Image = PictureBox2.Image
        PictureBox2.Image = PictureBox3.Image
        PictureBox3.Image = PictureBox4.Image
        PictureBox4.Image = PictureBox5.Image
        PictureBox5.Image = Nothing
    End Sub
End Class
