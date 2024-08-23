Imports System.Data.SqlClient

Public Class AddVoitureForm
    Private connectionString As String = "Data Source=DESKTOP-BOD8BMO;Initial Catalog=CarRentalDB;Integrated Security=True"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Récupérer les valeurs des TextBox et DatePicker

        Dim designation As String = DesignationTextBox.Text
        Dim numImmatriculation As String = NumImmatriculationTextBox.Text
        Dim numCarteGrise As String = NumCarteGriseTextBox.Text
        Dim dateMiseEnCirculation As DateTime = DateMiseEnCirculationPicker.Value
        Dim puissance As String = PuissanceTextBox.Text
        Dim couleur As String = CouleurTextBox.Text
        Dim energie As String = EnergieTextBox.Text
        Dim nombrePlaces As String = NombrePlacesTextBox.Text
        Dim observation As String = ObservationTextBox.Text
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Voitures ( Designation, NumImmatriculation, NumCarteGrise, DateMiseEnCirculation, Puissance, Couleur, Energie, NombrePlaces, Observation) " &
                          "VALUES ( @Designation, @NumImmatriculation, @NumCarteGrise, @DateMiseEnCirculation, @Puissance, @Couleur, @Energie, @NombrePlaces, @Observation)"
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@Designation", designation)
                command.Parameters.AddWithValue("@NumImmatriculation", numImmatriculation)
                command.Parameters.AddWithValue("@NumCarteGrise", numCarteGrise)
                command.Parameters.AddWithValue("@DateMiseEnCirculation", dateMiseEnCirculation)
                command.Parameters.AddWithValue("@Puissance", puissance)
                command.Parameters.AddWithValue("@Couleur", couleur)
                command.Parameters.AddWithValue("@Energie", energie)
                command.Parameters.AddWithValue("@NombrePlaces", nombrePlaces)
                command.Parameters.AddWithValue("@Observation", observation)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        Dim form1 As VoitureListForm = CType(Me.Owner, VoitureListForm)
        VoitureListForm.LoadVoitures()
        MessageBox.Show("voiture ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Ici, vous pouvez ajouter le code pour insérer ces informations dans votre base de données

        ' Fermer le formulaire après sauvegarde
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Fermer le formulaire sans sauvegarder
        Me.Close()
    End Sub
End Class
