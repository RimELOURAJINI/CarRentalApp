Imports System.Data.SqlClient

Public Class VoitureListForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ConducteurListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure dgvClients is initialized before using it
        If dgvVoitures IsNot Nothing Then
            LoadVoitures()
        Else
            MessageBox.Show("DataGridView is not initialized.")
        End If
    End Sub

    Public Sub LoadVoitures()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Voitures"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)

                If table IsNot Nothing AndAlso table.Rows.Count > 0 Then
                    dgvVoitures.DataSource = table

                Else
                    dgvVoitures.DataSource = Nothing
                    MessageBox.Show("No data found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading voiture: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnAddVoiture_Click(sender As Object, e As EventArgs) Handles btnAddVoiture.Click
        ' Ouvrir le formulaire pour ajouter une nouvelle voiture
        Dim addVoitureForm As New AddVoitureForm()
        addVoitureForm.Owner = Me
        addVoitureForm.ShowDialog()
        If dgvVoitures IsNot Nothing Then
            LoadVoitures()
        End If
    End Sub

    Private Sub btnDeleteVoiture_Click(sender As Object, e As EventArgs) Handles btnDeleteVoiture.Click
        Dim deleteForm As New DeleteVoitureForm()
        deleteForm.Owner = Me
        deleteForm.ShowDialog()
        If dgvVoitures IsNot Nothing Then
            LoadVoitures()
        End If
    End Sub
End Class
