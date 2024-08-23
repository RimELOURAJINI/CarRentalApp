Partial Class AddClientForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        chkConducteur = New CheckBox()
        lblIntitule = New Label()
        txtIntitule = New TextBox()
        lblCinPasseport = New Label()
        txtCinPasseport = New TextBox()
        lblLieuEmission = New Label()
        txtLieuEmission = New TextBox()
        lblDateEmission = New Label()
        dtpDateEmission = New DateTimePicker()
        lblAdresseLocale = New Label()
        txtAdresseLocale = New TextBox()
        lblAdresseEtranger = New Label()
        txtAdresseEtranger = New TextBox()
        lblGsm = New Label()
        txtGsm = New TextBox()
        lblTelFixe = New Label()
        txtTelFixe = New TextBox()
        lblNumPermis = New Label()
        txtNumPermis = New TextBox()
        lblLieuPermis = New Label()
        txtLieuPermis = New TextBox()
        lblDatePermis = New Label()
        dtpDatePermis = New DateTimePicker()
        lblObservation = New Label()
        txtObservation = New TextBox()
        btnAdd = New Button()
        SuspendLayout()

        ' 
        ' chkConducteur
        ' 
        chkConducteur.AutoSize = True
        chkConducteur.Location = New Point(120, 38)
        chkConducteur.Name = "chkConducteur"
        chkConducteur.Size = New Size(89, 19)
        chkConducteur.TabIndex = 2
        chkConducteur.Text = "Conducteur"
        chkConducteur.UseVisualStyleBackColor = True
        ' 
        ' lblIntitule
        ' 
        lblIntitule.AutoSize = True
        lblIntitule.Location = New Point(12, 65)
        lblIntitule.Name = "lblIntitule"
        lblIntitule.Size = New Size(44, 15)
        lblIntitule.TabIndex = 3
        lblIntitule.Text = "Intitulé"
        ' 
        ' txtIntitule
        ' 
        txtIntitule.Location = New Point(120, 62)
        txtIntitule.Name = "txtIntitule"
        txtIntitule.Size = New Size(200, 23)
        txtIntitule.TabIndex = 4
        ' 
        ' lblCinPasseport
        ' 
        lblCinPasseport.AutoSize = True
        lblCinPasseport.Location = New Point(12, 91)
        lblCinPasseport.Name = "lblCinPasseport"
        lblCinPasseport.Size = New Size(89, 15)
        lblCinPasseport.TabIndex = 5
        lblCinPasseport.Text = "CIN / Passeport"
        ' 
        ' txtCinPasseport
        ' 
        txtCinPasseport.Location = New Point(120, 88)
        txtCinPasseport.Name = "txtCinPasseport"
        txtCinPasseport.Size = New Size(200, 23)
        txtCinPasseport.TabIndex = 6
        ' 
        ' lblLieuEmission
        ' 
        lblLieuEmission.AutoSize = True
        lblLieuEmission.Location = New Point(12, 117)
        lblLieuEmission.Name = "lblLieuEmission"
        lblLieuEmission.Size = New Size(89, 15)
        lblLieuEmission.TabIndex = 7
        lblLieuEmission.Text = "Lieu d'Émission"
        ' 
        ' txtLieuEmission
        ' 
        txtLieuEmission.Location = New Point(120, 114)
        txtLieuEmission.Name = "txtLieuEmission"
        txtLieuEmission.Size = New Size(200, 23)
        txtLieuEmission.TabIndex = 8
        ' 
        ' lblDateEmission
        ' 
        lblDateEmission.AutoSize = True
        lblDateEmission.Location = New Point(12, 143)
        lblDateEmission.Name = "lblDateEmission"
        lblDateEmission.Size = New Size(91, 15)
        lblDateEmission.TabIndex = 9
        lblDateEmission.Text = "Date d'Émission"
        ' 
        ' dtpDateEmission
        ' 
        dtpDateEmission.Format = DateTimePickerFormat.Short
        dtpDateEmission.Location = New Point(120, 140)
        dtpDateEmission.Name = "dtpDateEmission"
        dtpDateEmission.Size = New Size(200, 23)
        dtpDateEmission.TabIndex = 10
        ' 
        ' lblAdresseLocale
        ' 
        lblAdresseLocale.AutoSize = True
        lblAdresseLocale.Location = New Point(12, 169)
        lblAdresseLocale.Name = "lblAdresseLocale"
        lblAdresseLocale.Size = New Size(85, 15)
        lblAdresseLocale.TabIndex = 11
        lblAdresseLocale.Text = "Adresse Locale"
        ' 
        ' txtAdresseLocale
        ' 
        txtAdresseLocale.Location = New Point(120, 166)
        txtAdresseLocale.Name = "txtAdresseLocale"
        txtAdresseLocale.Size = New Size(200, 23)
        txtAdresseLocale.TabIndex = 12
        ' 
        ' lblAdresseEtranger
        ' 
        lblAdresseEtranger.AutoSize = True
        lblAdresseEtranger.Location = New Point(12, 195)
        lblAdresseEtranger.Name = "lblAdresseEtranger"
        lblAdresseEtranger.Size = New Size(110, 15)
        lblAdresseEtranger.TabIndex = 13
        lblAdresseEtranger.Text = "Adresse à l’Étranger"
        ' 
        ' txtAdresseEtranger
        ' 
        txtAdresseEtranger.Location = New Point(120, 192)
        txtAdresseEtranger.Name = "txtAdresseEtranger"
        txtAdresseEtranger.Size = New Size(200, 23)
        txtAdresseEtranger.TabIndex = 14
        ' 
        ' lblGsm
        ' 
        lblGsm.AutoSize = True
        lblGsm.Location = New Point(12, 221)
        lblGsm.Name = "lblGsm"
        lblGsm.Size = New Size(31, 15)
        lblGsm.TabIndex = 15
        lblGsm.Text = "Gsm"
        ' 
        ' txtGsm
        ' 
        txtGsm.Location = New Point(120, 218)
        txtGsm.Name = "txtGsm"
        txtGsm.Size = New Size(200, 23)
        txtGsm.TabIndex = 16
        ' 
        ' lblTelFixe
        ' 
        lblTelFixe.AutoSize = True
        lblTelFixe.Location = New Point(12, 247)
        lblTelFixe.Name = "lblTelFixe"
        lblTelFixe.Size = New Size(45, 15)
        lblTelFixe.TabIndex = 17
        lblTelFixe.Text = "Tél Fixe"
        ' 
        ' txtTelFixe
        ' 
        txtTelFixe.Location = New Point(120, 244)
        txtTelFixe.Name = "txtTelFixe"
        txtTelFixe.Size = New Size(200, 23)
        txtTelFixe.TabIndex = 18
        ' 
        ' lblNumPermis
        ' 
        lblNumPermis.AutoSize = True
        lblNumPermis.Location = New Point(12, 273)
        lblNumPermis.Name = "lblNumPermis"
        lblNumPermis.Size = New Size(60, 15)
        lblNumPermis.TabIndex = 19
        lblNumPermis.Text = "N° Permis"
        ' 
        ' txtNumPermis
        ' 
        txtNumPermis.Location = New Point(120, 270)
        txtNumPermis.Name = "txtNumPermis"
        txtNumPermis.Size = New Size(200, 23)
        txtNumPermis.TabIndex = 20
        ' 
        ' lblLieuPermis
        ' 
        lblLieuPermis.AutoSize = True
        lblLieuPermis.Location = New Point(12, 299)
        lblLieuPermis.Name = "lblLieuPermis"
        lblLieuPermis.Size = New Size(68, 15)
        lblLieuPermis.TabIndex = 21
        lblLieuPermis.Text = "Lieu Permis"
        ' 
        ' txtLieuPermis
        ' 
        txtLieuPermis.Location = New Point(120, 296)
        txtLieuPermis.Name = "txtLieuPermis"
        txtLieuPermis.Size = New Size(200, 23)
        txtLieuPermis.TabIndex = 22
        ' 
        ' lblDatePermis
        ' 
        lblDatePermis.AutoSize = True
        lblDatePermis.Location = New Point(12, 325)
        lblDatePermis.Name = "lblDatePermis"
        lblDatePermis.Size = New Size(70, 15)
        lblDatePermis.TabIndex = 23
        lblDatePermis.Text = "Date Permis"
        ' 
        ' dtpDatePermis
        ' 
        dtpDatePermis.Format = DateTimePickerFormat.Short
        dtpDatePermis.Location = New Point(120, 322)
        dtpDatePermis.Name = "dtpDatePermis"
        dtpDatePermis.Size = New Size(200, 23)
        dtpDatePermis.TabIndex = 24
        ' 
        ' lblObservation
        ' 
        lblObservation.AutoSize = True
        lblObservation.Location = New Point(12, 351)
        lblObservation.Name = "lblObservation"
        lblObservation.Size = New Size(71, 15)
        lblObservation.TabIndex = 25
        lblObservation.Text = "Observation"
        ' 
        ' txtObservation
        ' 
        txtObservation.Location = New Point(120, 348)
        txtObservation.Name = "txtObservation"
        txtObservation.Size = New Size(200, 23)
        txtObservation.TabIndex = 26
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(120, 374)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 27
        btnAdd.Text = "Ajouter"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' AddClientForm
        ' 
        ClientSize = New Size(342, 409)
        Controls.Add(btnAdd)
        Controls.Add(txtObservation)
        Controls.Add(lblObservation)
        Controls.Add(dtpDatePermis)
        Controls.Add(lblDatePermis)
        Controls.Add(txtLieuPermis)
        Controls.Add(lblLieuPermis)
        Controls.Add(txtNumPermis)
        Controls.Add(lblNumPermis)
        Controls.Add(txtTelFixe)
        Controls.Add(lblTelFixe)
        Controls.Add(txtGsm)
        Controls.Add(lblGsm)
        Controls.Add(txtAdresseEtranger)
        Controls.Add(lblAdresseEtranger)
        Controls.Add(txtAdresseLocale)
        Controls.Add(lblAdresseLocale)
        Controls.Add(dtpDateEmission)
        Controls.Add(lblDateEmission)
        Controls.Add(txtLieuEmission)
        Controls.Add(lblLieuEmission)
        Controls.Add(txtCinPasseport)
        Controls.Add(lblCinPasseport)
        Controls.Add(txtIntitule)
        Controls.Add(lblIntitule)
        Controls.Add(chkConducteur)
        Controls.Add(txtCodeClient)
        Controls.Add(lblCodeClient)
        Name = "AddClientForm"
        Text = "Ajouter un Client"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblCodeClient As Label
    Friend WithEvents txtCodeClient As TextBox
    Friend WithEvents chkConducteur As CheckBox
    Friend WithEvents lblIntitule As Label
    Friend WithEvents txtIntitule As TextBox
    Friend WithEvents lblCinPasseport As Label
    Friend WithEvents txtCinPasseport As TextBox
    Friend WithEvents lblLieuEmission As Label
    Friend WithEvents txtLieuEmission As TextBox
    Friend WithEvents lblDateEmission As Label
    Friend WithEvents dtpDateEmission As DateTimePicker
    Friend WithEvents lblAdresseLocale As Label
    Friend WithEvents txtAdresseLocale As TextBox
    Friend WithEvents lblAdresseEtranger As Label
    Friend WithEvents txtAdresseEtranger As TextBox
    Friend WithEvents lblGsm As Label
    Friend WithEvents txtGsm As TextBox
    Friend WithEvents lblTelFixe As Label
    Friend WithEvents txtTelFixe As TextBox
    Friend WithEvents lblNumPermis As Label
    Friend WithEvents txtNumPermis As TextBox
    Friend WithEvents lblLieuPermis As Label
    Friend WithEvents txtLieuPermis As TextBox
    Friend WithEvents lblDatePermis As Label
    Friend WithEvents dtpDatePermis As DateTimePicker
    Friend WithEvents lblObservation As Label
    Friend WithEvents txtObservation As TextBox
    Friend WithEvents btnAdd As Button
End Class

