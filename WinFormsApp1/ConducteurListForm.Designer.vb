Partial Class ConducteurListForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.dgvConducteurs = New System.Windows.Forms.DataGridView()
        Me.ButtonAddConducteur = New System.Windows.Forms.Button()
        Me.ButtonDeleteConducteur = New System.Windows.Forms.Button()
        CType(Me.dgvConducteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' dgvConducteurs
        '
        Me.dgvConducteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConducteurs.Location = New System.Drawing.Point(12, 12)
        Me.dgvConducteurs.Name = "dgvConducteurs"
        Me.dgvConducteurs.Size = New System.Drawing.Size(776, 396)
        Me.dgvConducteurs.TabIndex = 0
        '
        ' ButtonAddConducteur
        '
        Me.ButtonAddConducteur.Location = New System.Drawing.Point(12, 414)
        Me.ButtonAddConducteur.Name = "ButtonAddConducteur"
        Me.ButtonAddConducteur.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddConducteur.TabIndex = 1
        Me.ButtonAddConducteur.Text = "Add"
        Me.ButtonAddConducteur.UseVisualStyleBackColor = True
        '
        ' ButtonDeleteConducteur
        '
        Me.ButtonDeleteConducteur.Location = New System.Drawing.Point(93, 414)
        Me.ButtonDeleteConducteur.Name = "ButtonDeleteConducteur"
        Me.ButtonDeleteConducteur.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleteConducteur.TabIndex = 2
        Me.ButtonDeleteConducteur.Text = "Delete"
        Me.ButtonDeleteConducteur.UseVisualStyleBackColor = True
        '
        ' ConductorListForm
        '
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonDeleteConducteur)
        Me.Controls.Add(Me.ButtonAddConducteur)
        Me.Controls.Add(Me.dgvConducteurs)
        Me.Name = "ConductorListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conductors List"
        CType(Me.dgvConducteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dgvConducteurs As System.Windows.Forms.DataGridView
    Private WithEvents ButtonAddConducteur As System.Windows.Forms.Button
    Private WithEvents ButtonDeleteConducteur As System.Windows.Forms.Button
End Class
