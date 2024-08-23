Partial Class DeleteClientForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblClientId = New Label()
        txtClientId = New TextBox()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lblClientId
        ' 
        lblClientId.AutoSize = True
        lblClientId.Location = New Point(12, 15)
        lblClientId.Name = "lblClientId"
        lblClientId.Size = New Size(69, 15)
        lblClientId.TabIndex = 0
        lblClientId.Text = "Code Client"
        ' 
        ' txtClientId
        ' 
        txtClientId.Location = New Point(120, 12)
        txtClientId.Name = "txtClientId"
        txtClientId.Size = New Size(200, 23)
        txtClientId.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(120, 38)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Supprimer"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' DeleteClientForm
        ' 
        ClientSize = New Size(342, 73)
        Controls.Add(btnDelete)
        Controls.Add(txtClientId)
        Controls.Add(lblClientId)
        Name = "DeleteClientForm"
        Text = "Supprimer un Client"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblClientId As Label
    Friend WithEvents txtClientId As TextBox
    Friend WithEvents btnDelete As Button
End Class
