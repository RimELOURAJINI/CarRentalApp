Partial Class DeleteConducteurForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        lblCodeConducteur = New Label()
        txtCodeConducteur = New TextBox()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lblCodeConducteur
        ' 
        lblCodeConducteur.AutoSize = True
        lblCodeConducteur.Location = New Point(12, 15)
        lblCodeConducteur.Name = "lblCodeConducteur"
        lblCodeConducteur.Size = New Size(104, 15)
        lblCodeConducteur.TabIndex = 0
        lblCodeConducteur.Text = "Code Conducteur:"
        ' 
        ' txtCodeConducteur
        ' 
        txtCodeConducteur.Location = New Point(123, 12)
        txtCodeConducteur.Name = "txtCodeConducteur"
        txtCodeConducteur.Size = New Size(100, 23)
        txtCodeConducteur.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(15, 38)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' DeleteConducteurForm
        ' 
        ClientSize = New Size(234, 71)
        Controls.Add(btnDelete)
        Controls.Add(txtCodeConducteur)
        Controls.Add(lblCodeConducteur)
        Name = "DeleteConducteurForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete Conductor"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents lblCodeConducteur As System.Windows.Forms.Label
    Private WithEvents txtCodeConducteur As System.Windows.Forms.TextBox
    Private WithEvents btnDelete As System.Windows.Forms.Button
End Class
