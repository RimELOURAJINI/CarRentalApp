Partial Class VoitureListForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.dgvVoitures = New System.Windows.Forms.DataGridView()
        Me.btnAddVoiture = New System.Windows.Forms.Button()
        Me.btnDeleteVoiture = New System.Windows.Forms.Button()
        CType(Me.dgvVoitures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVoitures
        '
        Me.dgvVoitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoitures.Location = New System.Drawing.Point(12, 12)
        Me.dgvVoitures.Name = "dgvVoitures"
        Me.dgvVoitures.Size = New System.Drawing.Size(760, 400)
        Me.dgvVoitures.TabIndex = 0
        '
        'btnAddVoiture
        '
        Me.btnAddVoiture.Location = New System.Drawing.Point(12, 420)
        Me.btnAddVoiture.Name = "btnAddVoiture"
        Me.btnAddVoiture.Size = New System.Drawing.Size(100, 30)
        Me.btnAddVoiture.TabIndex = 1
        Me.btnAddVoiture.Text = "Ajouter"
        Me.btnAddVoiture.UseVisualStyleBackColor = True
        '
        'btnDeleteVoiture
        '
        Me.btnDeleteVoiture.Location = New System.Drawing.Point(120, 420)
        Me.btnDeleteVoiture.Name = "btnDeleteVoiture"
        Me.btnDeleteVoiture.Size = New System.Drawing.Size(100, 30)
        Me.btnDeleteVoiture.TabIndex = 2
        Me.btnDeleteVoiture.Text = "Supprimer"
        Me.btnDeleteVoiture.UseVisualStyleBackColor = True
        '
        'VoitureListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.btnDeleteVoiture)
        Me.Controls.Add(Me.btnAddVoiture)
        Me.Controls.Add(Me.dgvVoitures)
        Me.Name = "VoitureListForm"
        Me.Text = "Liste des Voitures"
        CType(Me.dgvVoitures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dgvVoitures As System.Windows.Forms.DataGridView
    Private WithEvents btnAddVoiture As System.Windows.Forms.Button
    Private WithEvents btnDeleteVoiture As System.Windows.Forms.Button
End Class
