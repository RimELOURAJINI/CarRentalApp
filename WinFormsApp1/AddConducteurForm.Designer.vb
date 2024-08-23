Partial Class AddConducteurForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.lblClient = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.lblIntitule = New System.Windows.Forms.Label()
        Me.txtIntitule = New System.Windows.Forms.TextBox()
        Me.lblCinPasseport = New System.Windows.Forms.Label()
        Me.txtCinPasseport = New System.Windows.Forms.TextBox()
        Me.lblLieuCin = New System.Windows.Forms.Label()
        Me.txtLieuCin = New System.Windows.Forms.TextBox()
        Me.lblDateEmissionCin = New System.Windows.Forms.Label()
        Me.dtpDateEmissionCin = New System.Windows.Forms.DateTimePicker()
        Me.lblAdresseLocale = New System.Windows.Forms.Label()
        Me.txtAdresseLocale = New System.Windows.Forms.TextBox()
        Me.lblAdresseEtranger = New System.Windows.Forms.Label()
        Me.txtAdresseEtranger = New System.Windows.Forms.TextBox()
        Me.lblGsm = New System.Windows.Forms.Label()
        Me.txtGsm = New System.Windows.Forms.TextBox()
        Me.lblTelFixe = New System.Windows.Forms.Label()
        Me.txtTelFixe = New System.Windows.Forms.TextBox()
        Me.lblNumPermis = New System.Windows.Forms.Label()
        Me.txtNumPermis = New System.Windows.Forms.TextBox()
        Me.lblLieuPermis = New System.Windows.Forms.Label()
        Me.txtLieuPermis = New System.Windows.Forms.TextBox()
        Me.lblDatePermis = New System.Windows.Forms.Label()
        Me.dtpDatePermis = New System.Windows.Forms.DateTimePicker()
        Me.lblObservation = New System.Windows.Forms.Label()
        Me.txtObservation = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' lblCodeConducteur
        '

        '
        ' lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(12, 44)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(36, 15)
        Me.lblClient.TabIndex = 2
        Me.lblClient.Text = "Client"
        '
        ' txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(121, 41)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(200, 23)
        Me.txtClient.TabIndex = 3
        '
        ' lblIntitule
        '
        Me.lblIntitule.AutoSize = True
        Me.lblIntitule.Location = New System.Drawing.Point(12, 73)
        Me.lblIntitule.Name = "lblIntitule"
        Me.lblIntitule.Size = New System.Drawing.Size(44, 15)
        Me.lblIntitule.TabIndex = 4
        Me.lblIntitule.Text = "Intitulé"
        '
        ' txtIntitule
        '
        Me.txtIntitule.Location = New System.Drawing.Point(121, 70)
        Me.txtIntitule.Name = "txtIntitule"
        Me.txtIntitule.Size = New System.Drawing.Size(200, 23)
        Me.txtIntitule.TabIndex = 5
        '
        ' lblCinPasseport
        '
        Me.lblCinPasseport.AutoSize = True
        Me.lblCinPasseport.Location = New System.Drawing.Point(12, 102)
        Me.lblCinPasseport.Name = "lblCinPasseport"
        Me.lblCinPasseport.Size = New System.Drawing.Size(89, 15)
        Me.lblCinPasseport.TabIndex = 6
        Me.lblCinPasseport.Text = "CIN / Passeport"
        '
        ' txtCinPasseport
        '
        Me.txtCinPasseport.Location = New System.Drawing.Point(121, 99)
        Me.txtCinPasseport.Name = "txtCinPasseport"
        Me.txtCinPasseport.Size = New System.Drawing.Size(200, 23)
        Me.txtCinPasseport.TabIndex = 7
        '
        ' lblLieuCin
        '
        Me.lblLieuCin.AutoSize = True
        Me.lblLieuCin.Location = New System.Drawing.Point(12, 131)
        Me.lblLieuCin.Name = "lblLieuCin"
        Me.lblLieuCin.Size = New System.Drawing.Size(73, 15)
        Me.lblLieuCin.TabIndex = 8
        Me.lblLieuCin.Text = "Lieu CIN"
        '
        ' txtLieuCin
        '
        Me.txtLieuCin.Location = New System.Drawing.Point(121, 128)
        Me.txtLieuCin.Name = "txtLieuCin"
        Me.txtLieuCin.Size = New System.Drawing.Size(200, 23)
        Me.txtLieuCin.TabIndex = 9
        '
        ' lblDateEmissionCin
        '
        Me.lblDateEmissionCin.AutoSize = True
        Me.lblDateEmissionCin.Location = New System.Drawing.Point(12, 160)
        Me.lblDateEmissionCin.Name = "lblDateEmissionCin"
        Me.lblDateEmissionCin.Size = New System.Drawing.Size(89, 15)
        Me.lblDateEmissionCin.TabIndex = 10
        Me.lblDateEmissionCin.Text = "Date d'Émission"
        '
        ' dtpDateEmissionCin
        '
        Me.dtpDateEmissionCin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDateEmissionCin.Location = New System.Drawing.Point(121, 155)
        Me.dtpDateEmissionCin.Name = "dtpDateEmissionCin"
        Me.dtpDateEmissionCin.Size = New System.Drawing.Size(200, 23)
        Me.dtpDateEmissionCin.TabIndex = 11
        '
        ' lblAdresseLocale
        '
        Me.lblAdresseLocale.AutoSize = True
        Me.lblAdresseLocale.Location = New System.Drawing.Point(12, 189)
        Me.lblAdresseLocale.Name = "lblAdresseLocale"
        Me.lblAdresseLocale.Size = New System.Drawing.Size(85, 15)
        Me.lblAdresseLocale.TabIndex = 12
        Me.lblAdresseLocale.Text = "Adresse Locale"
        '
        ' txtAdresseLocale
        '
        Me.txtAdresseLocale.Location = New System.Drawing.Point(121, 186)
        Me.txtAdresseLocale.Name = "txtAdresseLocale"
        Me.txtAdresseLocale.Size = New System.Drawing.Size(200, 23)
        Me.txtAdresseLocale.TabIndex = 13
        '
        ' lblAdresseEtranger
        '
        Me.lblAdresseEtranger.AutoSize = True
        Me.lblAdresseEtranger.Location = New System.Drawing.Point(12, 218)
        Me.lblAdresseEtranger.Name = "lblAdresseEtranger"
        Me.lblAdresseEtranger.Size = New System.Drawing.Size(110, 15)
        Me.lblAdresseEtranger.TabIndex = 14
        Me.lblAdresseEtranger.Text = "Adresse à l’Étranger"
        '
        ' txtAdresseEtranger
        '
        Me.txtAdresseEtranger.Location = New System.Drawing.Point(121, 215)
        Me.txtAdresseEtranger.Name = "txtAdresseEtranger"
        Me.txtAdresseEtranger.Size = New System.Drawing.Size(200, 23)
        Me.txtAdresseEtranger.TabIndex = 15
        '
        ' lblGsm
        '
        Me.lblGsm.AutoSize = True
        Me.lblGsm.Location = New System.Drawing.Point(12, 247)
        Me.lblGsm.Name = "lblGsm"
        Me.lblGsm.Size = New System.Drawing.Size(31, 15)
        Me.lblGsm.TabIndex = 16
        Me.lblGsm.Text = "Gsm"
        '
        ' txtGsm
        '
        Me.txtGsm.Location = New System.Drawing.Point(121, 244)
        Me.txtGsm.Name = "txtGsm"
        Me.txtGsm.Size = New System.Drawing.Size(200, 23)
        Me.txtGsm.TabIndex = 17
        '
        ' lblTelFixe
        '
        Me.lblTelFixe.AutoSize = True
        Me.lblTelFixe.Location = New System.Drawing.Point(12, 276)
        Me.lblTelFixe.Name = "lblTelFixe"
        Me.lblTelFixe.Size = New System.Drawing.Size(45, 15)
        Me.lblTelFixe.TabIndex = 18
        Me.lblTelFixe.Text = "Tel Fixe"
        '
        ' txtTelFixe
        '
        Me.txtTelFixe.Location = New System.Drawing.Point(121, 273)
        Me.txtTelFixe.Name = "txtTelFixe"
        Me.txtTelFixe.Size = New System.Drawing.Size(200, 23)
        Me.txtTelFixe.TabIndex = 19
        '
        ' lblNumPermis
        '
        Me.lblNumPermis.AutoSize = True
        Me.lblNumPermis.Location = New System.Drawing.Point(12, 305)
        Me.lblNumPermis.Name = "lblNumPermis"
        Me.lblNumPermis.Size = New System.Drawing.Size(65, 15)
        Me.lblNumPermis.TabIndex = 20
        Me.lblNumPermis.Text = "Num Permis"
        '
        ' txtNumPermis
        '
        Me.txtNumPermis.Location = New System.Drawing.Point(121, 302)
        Me.txtNumPermis.Name = "txtNumPermis"
        Me.txtNumPermis.Size = New System.Drawing.Size(200, 23)
        Me.txtNumPermis.TabIndex = 21
        '
        ' lblLieuPermis
        '
        Me.lblLieuPermis.AutoSize = True
        Me.lblLieuPermis.Location = New System.Drawing.Point(12, 334)
        Me.lblLieuPermis.Name = "lblLieuPermis"
        Me.lblLieuPermis.Size = New System.Drawing.Size(69, 15)
        Me.lblLieuPermis.TabIndex = 22
        Me.lblLieuPermis.Text = "Lieu Permis"
        '
        ' txtLieuPermis
        '
        Me.txtLieuPermis.Location = New System.Drawing.Point(121, 331)
        Me.txtLieuPermis.Name = "txtLieuPermis"
        Me.txtLieuPermis.Size = New System.Drawing.Size(200, 23)
        Me.txtLieuPermis.TabIndex = 23
        '
        ' lblDatePermis
        '
        Me.lblDatePermis.AutoSize = True
        Me.lblDatePermis.Location = New System.Drawing.Point(12, 363)
        Me.lblDatePermis.Name = "lblDatePermis"
        Me.lblDatePermis.Size = New System.Drawing.Size(82, 15)
        Me.lblDatePermis.TabIndex = 24
        Me.lblDatePermis.Text = "Date d’Émission"
        '
        ' dtpDatePermis
        '
        Me.dtpDatePermis.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDatePermis.Location = New System.Drawing.Point(121, 358)
        Me.dtpDatePermis.Name = "dtpDatePermis"
        Me.dtpDatePermis.Size = New System.Drawing.Size(200, 23)
        Me.dtpDatePermis.TabIndex = 25
        '
        ' lblObservation
        '
        Me.lblObservation.AutoSize = True
        Me.lblObservation.Location = New System.Drawing.Point(12, 392)
        Me.lblObservation.Name = "lblObservation"
        Me.lblObservation.Size = New System.Drawing.Size(76, 15)
        Me.lblObservation.TabIndex = 26
        Me.lblObservation.Text = "Observation"
        '
        ' txtObservation
        '
        Me.txtObservation.Location = New System.Drawing.Point(121, 389)
        Me.txtObservation.Multiline = True
        Me.txtObservation.Name = "txtObservation"
        Me.txtObservation.Size = New System.Drawing.Size(200, 60)
        Me.txtObservation.TabIndex = 27
        '
        ' btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(121, 455)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        ' AddConducteurForm
        '
        Me.ClientSize = New System.Drawing.Size(344, 490)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtObservation)
        Me.Controls.Add(Me.lblObservation)
        Me.Controls.Add(Me.dtpDatePermis)
        Me.Controls.Add(Me.lblDatePermis)
        Me.Controls.Add(Me.txtLieuPermis)
        Me.Controls.Add(Me.lblLieuPermis)
        Me.Controls.Add(Me.txtNumPermis)
        Me.Controls.Add(Me.lblNumPermis)
        Me.Controls.Add(Me.txtTelFixe)
        Me.Controls.Add(Me.lblTelFixe)
        Me.Controls.Add(Me.txtGsm)
        Me.Controls.Add(Me.lblGsm)
        Me.Controls.Add(Me.txtAdresseEtranger)
        Me.Controls.Add(Me.lblAdresseEtranger)
        Me.Controls.Add(Me.txtAdresseLocale)
        Me.Controls.Add(Me.lblAdresseLocale)
        Me.Controls.Add(Me.dtpDateEmissionCin)
        Me.Controls.Add(Me.lblDateEmissionCin)
        Me.Controls.Add(Me.txtLieuCin)
        Me.Controls.Add(Me.lblLieuCin)
        Me.Controls.Add(Me.txtCinPasseport)
        Me.Controls.Add(Me.lblCinPasseport)
        Me.Controls.Add(Me.txtIntitule)
        Me.Controls.Add(Me.lblIntitule)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.lblClient)

        Me.Name = "AddConducteurForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private lblClient As System.Windows.Forms.Label
    Private txtClient As System.Windows.Forms.TextBox
    Private lblIntitule As System.Windows.Forms.Label
    Private txtIntitule As System.Windows.Forms.TextBox
    Private lblCinPasseport As System.Windows.Forms.Label
    Private txtCinPasseport As System.Windows.Forms.TextBox
    Private lblLieuCin As System.Windows.Forms.Label
    Private txtLieuCin As System.Windows.Forms.TextBox
    Private lblDateEmissionCin As System.Windows.Forms.Label
    Private dtpDateEmissionCin As System.Windows.Forms.DateTimePicker
    Private lblAdresseLocale As System.Windows.Forms.Label
    Private txtAdresseLocale As System.Windows.Forms.TextBox
    Private lblAdresseEtranger As System.Windows.Forms.Label
    Private txtAdresseEtranger As System.Windows.Forms.TextBox
    Private lblGsm As System.Windows.Forms.Label
    Private txtGsm As System.Windows.Forms.TextBox
    Private lblTelFixe As System.Windows.Forms.Label
    Private txtTelFixe As System.Windows.Forms.TextBox
    Private lblNumPermis As System.Windows.Forms.Label
    Private txtNumPermis As System.Windows.Forms.TextBox
    Private lblLieuPermis As System.Windows.Forms.Label
    Private txtLieuPermis As System.Windows.Forms.TextBox
    Private lblDatePermis As System.Windows.Forms.Label
    Private dtpDatePermis As System.Windows.Forms.DateTimePicker
    Private lblObservation As System.Windows.Forms.Label
    Private txtObservation As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As Button
End Class
