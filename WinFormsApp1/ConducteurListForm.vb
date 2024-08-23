Imports System.Data
Imports System.Data.SqlClient

Public Class ConducteurListForm

    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ConducteurListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure dgvClients is initialized before using it
        If dgvConducteurs IsNot Nothing Then
            LoadConducteurs()
        Else
            MessageBox.Show("DataGridView is not initialized.")
        End If
    End Sub

    Public Sub LoadConducteurs()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Conducteurs"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)

                If table IsNot Nothing AndAlso table.Rows.Count > 0 Then
                    dgvConducteurs.DataSource = table

                Else
                    dgvConducteurs.DataSource = Nothing
                    MessageBox.Show("No data found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading clients: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ButtonAddConducteur_Click(sender As Object, e As EventArgs) Handles ButtonAddConducteur.Click
        Dim addForm As New AddConducteurForm()
        addForm.Owner = Me
        addForm.ShowDialog()
        If dgvConducteurs IsNot Nothing Then
            LoadConducteurs()
        End If
    End Sub

    Private Sub ButtonDeleteConducteur_Click(sender As Object, e As EventArgs) Handles ButtonDeleteConducteur.Click
        Dim deleteForm As New DeleteConducteurForm()
        deleteForm.Owner = Me
        deleteForm.ShowDialog()
        If dgvConducteurs IsNot Nothing Then
            LoadConducteurs()
        End If
    End Sub

End Class
