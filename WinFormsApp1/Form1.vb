Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure dgvClients is initialized before using it
        If dgvClients IsNot Nothing Then
            LoadClients()
        Else
            MessageBox.Show("DataGridView is not initialized.")
        End If
    End Sub

    Public Sub LoadClients()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Clients"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)

                If table IsNot Nothing AndAlso table.Rows.Count > 0 Then
                    dgvClients.DataSource = table
                Else
                    dgvClients.DataSource = Nothing
                    MessageBox.Show("No data found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading clients: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ButtonAddClient_Click(sender As Object, e As EventArgs) Handles ButtonAddClient.Click
        Dim addForm As New AddClientForm()
        addForm.Owner = Me
        addForm.ShowDialog()
        If dgvClients IsNot Nothing Then
            LoadClients()
        End If
    End Sub

    Private Sub ButtonDeleteClient_Click(sender As Object, e As EventArgs) Handles ButtonDeleteClient.Click
        Dim deleteForm As New DeleteClientForm()
        deleteForm.Owner = Me
        deleteForm.ShowDialog()
        If dgvClients IsNot Nothing Then
            LoadClients()
        End If
    End Sub

End Class
