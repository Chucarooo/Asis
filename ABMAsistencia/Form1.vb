Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim strConector As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\documentos\desarrollo de software\segundo año\practica\Sistema de Asistencias.accdb;Persist Security Info=False;"

    Dim conector As New OleDbConnection(strConector)


    Private Sub Conectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Conectar.Click
        Try
            conector.Open()
        Catch ex As OleDbException
            MsgBox("Hay un problema con la cadena de conección")
        Catch ex As InvalidOperationException
            MsgBox("La conección con la base de datos ya está abierta")
        End Try

    End Sub

    Private Sub Desconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desconectar.Click
        conector.Close()
    End Sub

    Private Sub Recuperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recuperar.Click
        Dim strComando As String = "SELECT Count(Alumno.Documento) FROM Alumno;"
        Dim comando As New OleDbCommand(strComando, conector)
        Try
            TextBox1.Text = comando.ExecuteScalar
        Catch ex As InvalidOperationException
            MsgBox("La conección con la base de datos no está abierta")
        End Try


    End Sub

    Private Sub Alumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alumnos.Click
        Dim strComando As String = "SELECT * FROM Alumno;"
        Dim Comando As New OleDbCommand(strComando, conector)
        Dim tabla As New DataTable

        Try
            tabla.Load(Comando.ExecuteReader)
            DataGridView1.DataSource = tabla
        Catch ex As InvalidOperationException
            MsgBox("La conección con la base de datos no está abierta")
        End Try
    End Sub
End Class
