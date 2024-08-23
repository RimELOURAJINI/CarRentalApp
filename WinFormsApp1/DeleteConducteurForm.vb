Imports System.Data.SqlClient

Public Class DeleteConducteurForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim codeConducteur As String = txtCodeConducteur.Text

        If String.IsNullOrWhiteSpace(codeConducteur) Then
            MessageBox.Show("Please enter a valid code for the conductor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this conductor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Conducteurs WHERE CodeConducteur = @CodeConducteur"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CodeConducteur", codeConducteur)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Conductor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        Else
                            MessageBox.Show("No conductor found with the specified code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error deleting conductor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub DeleteConducteurForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
