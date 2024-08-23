Public Class Accueil

    Private Sub ButtonClients_Click(sender As Object, e As EventArgs) Handles ButtonClients.Click
        Dim clientListForm As New Form1()  ' Form1 représente la liste des clients
        clientListForm.Show()
    End Sub

    Private Sub ButtonConducteurs_Click(sender As Object, e As EventArgs) Handles ButtonConducteurs.Click
        Dim conducteurListForm As New ConducteurListForm()
        conducteurListForm.Show()
    End Sub

    Private Sub BtnVoitures_Click(sender As Object, e As EventArgs) Handles ButtonVoitures.Click
        ' Ouvrir le formulaire de gestion des voitures
        Dim voitureListForm As New VoitureListForm()
        voitureListForm.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
