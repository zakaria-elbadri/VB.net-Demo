Imports System.xml

Public Class Form1
    Dim monxmldocument As String = "Mediatheque_Dom.xml"
    Dim xmldoc As New XmlDocument


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xmldoc.Load(monxmldocument)
        Dim monxmlreader As XmlReader
        monxmlreader = XmlReader.Create(monxmldocument)
        Do While monxmlreader.Read
            If monxmlreader.NodeType = XmlNodeType.Element And monxmlreader.Name = "Titre" Then
                cbotitre.Items.Add(monxmlreader.ReadElementString)
            End If
        Loop
    End Sub

    Private Sub cbotitre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotitre.SelectedIndexChanged
        Dim monnoeud As XmlNode
        Dim mesnoeud As XmlNodeList
        Dim moncritere As String
        moncritere = "/Mediatheque/Oeuvre[Titre=""" & cbotitre.SelectedItem & """]"
        monnoeud = xmldoc.SelectSingleNode(moncritere)
        mesnoeud = monnoeud.ChildNodes
        For Each monnoeud In mesnoeud
            Select Case monnoeud.Name
                Case "Titre"
                    txttitre.Text = monnoeud.InnerText
                Case "Auteur"
                    txtauteur.Text = monnoeud.InnerText
            End Select
        Next


    End Sub

End Class
