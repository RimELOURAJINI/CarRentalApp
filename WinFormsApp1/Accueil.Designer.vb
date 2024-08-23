<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ButtonClients = New Button()
        ButtonConducteurs = New Button()
        ButtonVoitures = New Button()
        ButtonContrats = New Button()
        LabelTitle = New Label()
        SuspendLayout()
        ' 
        ' ButtonClients
        ' 
        ButtonClients.BackColor = Color.DodgerBlue
        ButtonClients.FlatAppearance.BorderSize = 0
        ButtonClients.FlatStyle = FlatStyle.Flat
        ButtonClients.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ButtonClients.ForeColor = Color.White
        ButtonClients.Location = New Point(117, 115)
        ButtonClients.Margin = New Padding(4, 3, 4, 3)
        ButtonClients.Name = "ButtonClients"
        ButtonClients.Size = New Size(233, 58)
        ButtonClients.TabIndex = 0
        ButtonClients.Text = "Clients"
        ButtonClients.UseVisualStyleBackColor = False
        ' 
        ' ButtonConducteurs
        ' 
        ButtonConducteurs.BackColor = Color.SeaGreen
        ButtonConducteurs.FlatAppearance.BorderSize = 0
        ButtonConducteurs.FlatStyle = FlatStyle.Flat
        ButtonConducteurs.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ButtonConducteurs.ForeColor = Color.White
        ButtonConducteurs.Location = New Point(117, 196)
        ButtonConducteurs.Margin = New Padding(4, 3, 4, 3)
        ButtonConducteurs.Name = "ButtonConducteurs"
        ButtonConducteurs.Size = New Size(233, 58)
        ButtonConducteurs.TabIndex = 1
        ButtonConducteurs.Text = "Conducteurs"
        ButtonConducteurs.UseVisualStyleBackColor = False
        ' 
        ' ButtonVoitures
        ' 
        ButtonVoitures.BackColor = Color.OrangeRed
        ButtonVoitures.FlatAppearance.BorderSize = 0
        ButtonVoitures.FlatStyle = FlatStyle.Flat
        ButtonVoitures.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ButtonVoitures.ForeColor = Color.White
        ButtonVoitures.Location = New Point(117, 277)
        ButtonVoitures.Margin = New Padding(4, 3, 4, 3)
        ButtonVoitures.Name = "ButtonVoitures"
        ButtonVoitures.Size = New Size(233, 58)
        ButtonVoitures.TabIndex = 2
        ButtonVoitures.Text = "Voitures"
        ButtonVoitures.UseVisualStyleBackColor = False
        ' 
        ' ButtonContrats
        ' 
        ButtonContrats.BackColor = Color.MediumPurple
        ButtonContrats.FlatAppearance.BorderSize = 0
        ButtonContrats.FlatStyle = FlatStyle.Flat
        ButtonContrats.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ButtonContrats.ForeColor = Color.White
        ButtonContrats.Location = New Point(117, 358)
        ButtonContrats.Margin = New Padding(4, 3, 4, 3)
        ButtonContrats.Name = "ButtonContrats"
        ButtonContrats.Size = New Size(233, 58)
        ButtonContrats.TabIndex = 3
        ButtonContrats.Text = "Contrats"
        ButtonContrats.UseVisualStyleBackColor = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.Gray
        LabelTitle.Location = New Point(99, 37)
        LabelTitle.Margin = New Padding(4, 0, 4, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(268, 32)
        LabelTitle.TabIndex = 4
        LabelTitle.Text = "Gestion de la Location"
        ' 
        ' Accueil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(467, 519)
        Controls.Add(LabelTitle)
        Controls.Add(ButtonContrats)
        Controls.Add(ButtonVoitures)
        Controls.Add(ButtonConducteurs)
        Controls.Add(ButtonClients)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Accueil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Accueil"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents ButtonClients As Button
    Friend WithEvents ButtonConducteurs As Button
    Friend WithEvents ButtonVoitures As Button
    Friend WithEvents ButtonContrats As Button
    Friend WithEvents LabelTitle As Label
End Class
