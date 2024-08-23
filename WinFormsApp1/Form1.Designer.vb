Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.ButtonAddClient = New System.Windows.Forms.Button()
        Me.ButtonDeleteClient = New System.Windows.Forms.Button()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClients
        '
        Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClients.Location = New System.Drawing.Point(12, 12)
        Me.dgvClients.Name = "dgvClients"
        Me.dgvClients.Size = New System.Drawing.Size(776, 396)
        Me.dgvClients.TabIndex = 0
        '
        'ButtonAddClient
        '
        Me.ButtonAddClient.Location = New System.Drawing.Point(12, 414)
        Me.ButtonAddClient.Name = "ButtonAddClient"
        Me.ButtonAddClient.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddClient.TabIndex = 1
        Me.ButtonAddClient.Text = "Add Client"
        Me.ButtonAddClient.UseVisualStyleBackColor = True
        '
        'ButtonDeleteClient
        '
        Me.ButtonDeleteClient.Location = New System.Drawing.Point(93, 414)
        Me.ButtonDeleteClient.Name = "ButtonDeleteClient"
        Me.ButtonDeleteClient.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleteClient.TabIndex = 2
        Me.ButtonDeleteClient.Text = "Delete Client"
        Me.ButtonDeleteClient.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonDeleteClient)
        Me.Controls.Add(Me.ButtonAddClient)
        Me.Controls.Add(Me.dgvClients)
        Me.Name = "Form1"
        Me.Text = "Client List"
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dgvClients As System.Windows.Forms.DataGridView
    Private WithEvents ButtonAddClient As System.Windows.Forms.Button
    Private WithEvents ButtonDeleteClient As System.Windows.Forms.Button
End Class
