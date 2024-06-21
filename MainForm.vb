Public Class MainForm
    Inherits Form

    Public Sub New()
        InitializeComponent()
        ' Set the KeyPreview property to True to allow the form to capture key presses before they are passed to the controls.
        Me.KeyPreview = True
        ' Center controls in the form
        CenterControls()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterControls()
    End Sub

    Private Sub CenterControls()
        Me.Label1.Location = New System.Drawing.Point((Me.ClientSize.Width - Me.Label1.Width) \ 2, 20)
        Me.btnViewSubmissions.Location = New System.Drawing.Point((Me.ClientSize.Width - Me.btnViewSubmissions.Width) \ 2, 70)
        Me.btnCreateSubmission.Location = New System.Drawing.Point((Me.ClientSize.Width - Me.btnCreateSubmission.Width) \ 2, 120)
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check for Ctrl + V shortcut
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        End If

        ' Check for Ctrl + N shortcut
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub
End Class


