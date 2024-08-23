Imports System.Data.SqlClient

Public Class AddConducteurForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim clientID As String = txtClient.Text

        Dim intitule As String = txtIntitule.Text
        Dim cinPasseport As String = txtCinPasseport.Text
        Dim lieuCin As String = txtLieuCin.Text
        Dim dateEmissionCin As DateTime = dtpDateEmissionCin.Value
        Dim adresseLocale As String = txtAdresseLocale.Text
        Dim adresseEtranger As String = txtAdresseEtranger.Text
        Dim gsm As String = txtGsm.Text
        Dim telFixe As String = txtTelFixe.Text
        Dim numPermis As String = txtNumPermis.Text
        Dim lieuPermis As String = txtLieuPermis.Text
        Dim dateEmissionPermis As DateTime = dtpDatePermis.Value

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Conducteurs (ClientID,  Intitule, CinPasseport, LieuCin, DateEmissionCin, AdresseLocale, AdresseEtranger, Gsm, TelFixe, NumPermis, LieuPermis, DateEmissionPermis) " &
                                  "VALUES (@ClientID, @Intitule, @CinPasseport, @LieuCin, @DateEmissionCin, @AdresseLocale, @AdresseEtranger, @Gsm, @TelFixe, @NumPermis, @LieuPermis, @DateEmissionPermis)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ClientID", clientID)

                command.Parameters.AddWithValue("@Intitule", intitule)
                command.Parameters.AddWithValue("@CinPasseport", cinPasseport)
                command.Parameters.AddWithValue("@LieuCin", lieuCin)
                command.Parameters.AddWithValue("@DateEmissionCin", dateEmissionCin)
                command.Parameters.AddWithValue("@AdresseLocale", adresseLocale)
                command.Parameters.AddWithValue("@AdresseEtranger", adresseEtranger)
                command.Parameters.AddWithValue("@Gsm", gsm)
                command.Parameters.AddWithValue("@TelFixe", telFixe)
                command.Parameters.AddWithValue("@NumPermis", numPermis)
                command.Parameters.AddWithValue("@LieuPermis", lieuPermis)
                command.Parameters.AddWithValue("@DateEmissionPermis", dateEmissionPermis)


                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        Dim form1 As ConducteurListForm = CType(Me.Owner, ConducteurListForm)
        ConducteurListForm.LoadConducteurs()
        MessageBox.Show("Conducteur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
