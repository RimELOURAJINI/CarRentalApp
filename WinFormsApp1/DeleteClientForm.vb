Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DeleteClientForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim clientId As String = txtClientId.Text

        If String.IsNullOrEmpty(clientId) Then
            MessageBox.Show("Le Code Client est requis pour la suppression.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM Clients WHERE CodeClient = @CodeClient"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CodeClient", clientId)
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    Dim Form1 As Form1 = CType(Me.Owner, Form1)
                    Form1.LoadClients()
                    MessageBox.Show("Client supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Aucun client trouvé avec ce Code Client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using

        Me.Close()
    End Sub

    Private Sub DeleteClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
