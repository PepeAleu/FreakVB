Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Module bdfriki
    Private con As MySqlConnection
    Private com As New MySqlCommand
    Private col As MySqlDataReader
    Private dt As DataTable

    'Private con As ADODB.Connection
    'Private com As ADODB.Command
    'Private rs As ADODB.Recordset

    Public Sub Conectar()
        Try
            'con = New ADODB.Connection
            con = New MySqlConnection
            con.ConnectionString = "Database=friki;Data Source=127.0.0.1;User Id=root;Password=;allow zero datetime=true"
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & _
                            ex.Message, "Conectar con la base", _
                             MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub Ejecutar(ByVal str As String)
        'rs = New ADODB.Recordset
        'rs.Open(str, con)
        'rs = Nothing
        con.Open()
        com.Connection = con
        com.CommandText = str
        com.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Function Consultar(ByVal str As String)
        'rs = New ADODB.Recordset
        'rs.Open(str, con)
        'While Not rs.EOF
        '    AltaAventura.DataGridViewEsc.DataSource. = rs.Fields(1).Value
        '    rs.MoveNext()
        'End While
        con.Open()
        com.Connection = con
        com.CommandText = str
        col = com.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(col, LoadOption.OverwriteChanges)
        con.Close()
        Return dt
    End Function

End Module
