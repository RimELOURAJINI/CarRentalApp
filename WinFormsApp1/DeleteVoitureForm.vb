Imports System.Data.SqlClient

Public Class DeleteVoitureForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim voitureCode As String = txtCodeVoiture.Text

        If String.IsNullOrEmpty(voitureCode) Then
            MessageBox.Show("Veuillez entrer le code de la voiture à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM Voitures WHERE CodeVoiture = @CodeVoiture"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CodeVoiture", voitureCode)

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Voiture supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim voitureListForm As Form = Me.Owner
                    If TypeOf voitureListForm Is VoitureListForm Then
                        CType(voitureListForm, VoitureListForm).LoadVoitures()
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("Aucune voiture trouvée avec ce code.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
End Class
