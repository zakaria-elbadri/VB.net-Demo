<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.listedesoeuvres = New System.Windows.Forms.Label
        Me.titre = New System.Windows.Forms.Label
        Me.auteur = New System.Windows.Forms.Label
        Me.cbotitre = New System.Windows.Forms.ComboBox
        Me.txttitre = New System.Windows.Forms.TextBox
        Me.txtauteur = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'listedesoeuvres
        '
        Me.listedesoeuvres.AutoSize = True
        Me.listedesoeuvres.Location = New System.Drawing.Point(31, 86)
        Me.listedesoeuvres.Name = "listedesoeuvres"
        Me.listedesoeuvres.Size = New System.Drawing.Size(86, 13)
        Me.listedesoeuvres.TabIndex = 1
        Me.listedesoeuvres.Text = "liste des oeuvres"
        '
        'titre
        '
        Me.titre.AutoSize = True
        Me.titre.Location = New System.Drawing.Point(32, 128)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(24, 13)
        Me.titre.TabIndex = 2
        Me.titre.Text = "titre"
        '
        'auteur
        '
        Me.auteur.AutoSize = True
        Me.auteur.Location = New System.Drawing.Point(32, 165)
        Me.auteur.Name = "auteur"
        Me.auteur.Size = New System.Drawing.Size(37, 13)
        Me.auteur.TabIndex = 3
        Me.auteur.Text = "auteur"
        '
        'cbotitre
        '
        Me.cbotitre.FormattingEnabled = True
        Me.cbotitre.Location = New System.Drawing.Point(154, 78)
        Me.cbotitre.Name = "cbotitre"
        Me.cbotitre.Size = New System.Drawing.Size(54, 21)
        Me.cbotitre.TabIndex = 4
        '
        'txttitre
        '
        Me.txttitre.Location = New System.Drawing.Point(154, 121)
        Me.txttitre.Name = "txttitre"
        Me.txttitre.Size = New System.Drawing.Size(100, 20)
        Me.txttitre.TabIndex = 5
        '
        'txtauteur
        '
        Me.txtauteur.Location = New System.Drawing.Point(154, 165)
        Me.txtauteur.Name = "txtauteur"
        Me.txtauteur.Size = New System.Drawing.Size(100, 20)
        Me.txtauteur.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 273)
        Me.Controls.Add(Me.txtauteur)
        Me.Controls.Add(Me.txttitre)
        Me.Controls.Add(Me.cbotitre)
        Me.Controls.Add(Me.auteur)
        Me.Controls.Add(Me.titre)
        Me.Controls.Add(Me.listedesoeuvres)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listedesoeuvres As System.Windows.Forms.Label
    Friend WithEvents titre As System.Windows.Forms.Label
    Friend WithEvents auteur As System.Windows.Forms.Label
    Friend WithEvents cbotitre As System.Windows.Forms.ComboBox
    Friend WithEvents txttitre As System.Windows.Forms.TextBox
    Friend WithEvents txtauteur As System.Windows.Forms.TextBox

End Class
