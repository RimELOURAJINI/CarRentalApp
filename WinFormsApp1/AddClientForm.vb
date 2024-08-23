Imports System.Data.SqlClient

Public Class AddClientForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim conducteur As Boolean = chkConducteur.Checked
        Dim intitule As String = txtIntitule.Text
        Dim cinPasseport As String = txtCinPasseport.Text
        Dim lieuEmission As String = txtLieuEmission.Text
        Dim dateEmission As DateTime = dtpDateEmission.Value
        Dim adresseLocale As String = txtAdresseLocale.Text
        Dim adresseEtranger As String = txtAdresseEtranger.Text
        Dim gsm As String = txtGsm.Text
        Dim telFixe As String = txtTelFixe.Text
        Dim numPermis As String = txtNumPermis.Text
        Dim lieuPermis As String = txtLieuPermis.Text
        Dim datePermis As DateTime = dtpDatePermis.Value
        Dim observation As String = txtObservation.Text

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Clients (Conducteur, Intitule, CinPasseport, LieuEmission, DateEmission, AdresseLocale, AdresseEtranger, Gsm, TelFixe, NumPermis, LieuPermis, DatePermis, Observation) " &
                                  "VALUES (@Conducteur, @Intitule, @CinPasseport, @LieuEmission, @DateEmission, @AdresseLocale, @AdresseEtranger, @Gsm, @TelFixe, @NumPermis, @LieuPermis, @DatePermis, @Observation)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Conducteur", conducteur)
                command.Parameters.AddWithValue("@Intitule", intitule)
                command.Parameters.AddWithValue("@CinPasseport", cinPasseport)
                command.Parameters.AddWithValue("@LieuEmission", lieuEmission)
                command.Parameters.AddWithValue("@DateEmission", dateEmission)
                command.Parameters.AddWithValue("@AdresseLocale", adresseLocale)
                command.Parameters.AddWithValue("@AdresseEtranger", adresseEtranger)
                command.Parameters.AddWithValue("@Gsm", gsm)
                command.Parameters.AddWithValue("@TelFixe", telFixe)
                command.Parameters.AddWithValue("@NumPermis", numPermis)
                command.Parameters.AddWithValue("@LieuPermis", lieuPermis)
                command.Parameters.AddWithValue("@DatePermis", datePermis)
                command.Parameters.AddWithValue("@Observation", observation)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        Dim form1 As Form1 = CType(Me.Owner, Form1)
        form1.LoadClients()
        MessageBox.Show("Client ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
