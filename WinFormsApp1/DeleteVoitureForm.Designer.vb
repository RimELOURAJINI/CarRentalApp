<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteVoitureForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCodeVoiture = New System.Windows.Forms.Label()
        Me.txtCodeVoiture = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        ' lblCodeVoiture
        Me.lblCodeVoiture.AutoSize = True
        Me.lblCodeVoiture.Location = New System.Drawing.Point(12, 15)
        Me.lblCodeVoiture.Name = "lblCodeVoiture"
        Me.lblCodeVoiture.Size = New System.Drawing.Size(75, 15)
        Me.lblCodeVoiture.TabIndex = 0
        Me.lblCodeVoiture.Text = "Code Voiture"

        ' txtCodeVoiture
        Me.txtCodeVoiture.Location = New System.Drawing.Point(93, 12)
        Me.txtCodeVoiture.Name = "txtCodeVoiture"
        Me.txtCodeVoiture.Size = New System.Drawing.Size(200, 23)
        Me.txtCodeVoiture.TabIndex = 1

        ' btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(93, 41)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.UseVisualStyleBackColor = True

        ' DeleteVoitureForm
        Me.ClientSize = New System.Drawing.Size(305, 76)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtCodeVoiture)
        Me.Controls.Add(Me.lblCodeVoiture)
        Me.Name = "DeleteVoitureForm"
        Me.Text = "Supprimer une Voiture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodeVoiture As Label
    Friend WithEvents txtCodeVoiture As TextBox
    Friend WithEvents btnDelete As Button

End Class
