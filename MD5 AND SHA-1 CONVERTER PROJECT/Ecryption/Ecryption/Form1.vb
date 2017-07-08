Imports System.IO
Imports System
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Form1
    Public Function SHA1(ByVal number As String) As String
        Dim asciiSHA1 As New ASCIIEncoding
        Dim returnstringSHA1 As String
        returnstringSHA1 = vbNullString

        Dim bytesourceSHA1() As Byte = asciiSHA1.GetBytes(number)
        Dim SHA1hash As New SHA1CryptoServiceProvider
        Dim bytehashSHA1() As Byte = SHA1hash.ComputeHash(bytesourceSHA1)

        For Each x As Byte In bytehashSHA1
            returnstringSHA1 &= x.ToString("x2")

        Next
        Return returnstringSHA1


    End Function

    Public Function MD5(ByVal number As String) As String
        Dim asciiMD5 As New ASCIIEncoding
        Dim returnstringMD5 As String
        returnstringMD5 = vbNullString

        Dim bytesourceMD5() As Byte = asciiMD5.GetBytes(number)
        Dim MD5hash As New MD5CryptoServiceProvider
        Dim bytehashMD5() As Byte = MD5hash.ComputeHash(bytesourceMD5)

        For Each y As Byte In bytehashMD5
            returnstringMD5 &= y.ToString("x2")

        Next
        Return returnstringMD5


    End Function

    Private Sub MD5btn_Click(sender As Object, e As EventArgs) Handles MD5btn.Click
        If stringtxt.Text = "" Then
            MsgBox("Fill the field.")
        Else


            Dim conn As MySqlConnection
            Dim comm As MySqlCommand

            conn = New MySqlConnection
            conn.ConnectionString = "host=127.0.0.1; user=root; password=; database=encrypt;"
            Dim Reader As MySqlDataReader
            Try
                conn.Open()
                Dim Query As String

                md5box.Text = MD5(stringtxt.Text)
                sha1box.Text = SHA1(stringtxt.Text)


                Query = "insert into data (word,ensha1,enmd5) values ('" & stringtxt.Text & "','" & sha1box.Text & "', '" & md5box.Text & "')"
                comm = New MySqlCommand(Query, conn)
                Reader = comm.ExecuteReader
                MsgBox("Saved.")

                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub





    Private Sub lblsha1_Click(sender As Object, e As EventArgs) Handles lblsha1.Click

    End Sub

    Private Sub stringtxt_TextChanged(sender As Object, e As EventArgs) Handles stringtxt.Click


    End Sub

    Private Sub stringtxt_TextChanged_1(sender As Object, e As EventArgs) Handles stringtxt.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stringtxt.Text = ""
        md5box.Text = ""
        sha1box.Text = ""
    End Sub
End Class
