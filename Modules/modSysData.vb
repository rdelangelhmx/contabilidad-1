Module modSysData
    Public Const LikeOperator As String = "%"

   Public Function NumberToField(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0"
      ElseIf IsNumeric(Value) Then
         Return CStr(Value)
      Else
         Return "0"
      End If
   End Function

   Public Function DecimalToField(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0.0"
      ElseIf IsNumeric(Value) Then
         Return Replace(CStr(Value), ",", ".")
      Else
         Return "0.0"
      End If
   End Function

   Public Function StringToField(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "''"
      ElseIf Value = Nothing Then
         Return "''"
      ElseIf Value.Trim() <> String.Empty Then
         Return "'" & Trim(Value) & "'"
      Else
         Return "''"
      End If
   End Function

   Public Function DateToField(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "Null"
      ElseIf Value.Trim() = String.Empty Then
         Return "Null"
      ElseIf Value = "#12:00:00 AM#" Then
         Return "Null"
      ElseIf IsDate(ToDateDMY(Value)) Then
         If clsAppInfo.ProviderId = 1 Then
            Return "#" & CStr(Value) & "#"
         Else
            Return "'" & CStr(Value) & "'"
         End If
      Else
         Return "Null"
      End If
   End Function

   Public Function ToBoolean(ByVal Value As Object) As Byte
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return IIf(Value, 1, 0)
      Else
         Return 0
      End If
   End Function

   Public Function ToByte(ByVal Value As Object) As Byte
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return CByte(Value)
      Else
         Return 0
      End If
   End Function

   Public Function ToSingle(ByVal Value As Object) As Single
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return CSng(Value)
      Else
         Return 0
      End If
   End Function

   Public Function ToShort(ByVal Value As Object) As Short
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return CShort(Value)
      Else
         Return 0
      End If
   End Function

   Public Function ToInteger(ByVal Value As Object) As Integer
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return CInt(Value)
      Else
         Return 0
      End If
   End Function

   Public Function ToLong(ByVal Value As Object) As Long
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return CLng(Value)
      Else
         Return 0
      End If
   End Function

   Public Function ToDouble(ByVal Value As Object) As Double
      If IsDBNull(Value) Then
         Return 0
      ElseIf IsNumeric(Value) Then
         Return CDbl(Value)
      Else
         Return 0
      End If
   End Function

   Public Function ToDecimal(ByVal Value As Object) As Decimal
      If IsDBNull(Value) Then
         Return 0.0
      ElseIf IsNumeric(Value) Then
         Return Math.Round(CDec(Value), clsAppInfo.DecimalNro)
      Else
         Return 0.0
      End If
   End Function

   Public Function ToDecimalUno(ByVal Value As Object) As Decimal
      If IsDBNull(Value) Then
         Return 0.0
      ElseIf IsNumeric(Value) Then
         Return Math.Round(CDec(Value), 1)
      Else
         Return 0.0
      End If
   End Function

   Public Function ToDecimalDos(ByVal Value As Object) As Decimal
      If IsDBNull(Value) Then
         Return 0.0
      ElseIf IsNumeric(Value) Then
         Return Math.Round(CDec(Value), 2)
      Else
         Return 0.0
      End If
   End Function

   Public Function ToDecimalCinco(ByVal Value As Object) As Decimal
      If IsDBNull(Value) Then
         Return 0.0
      ElseIf IsNumeric(Value) Then
         Return Math.Round(CDec(Value), 5)
      Else
         Return 0.0
      End If
   End Function

   Public Function ToDecimalMinor(ByVal Value As Object) As Decimal
      If IsDBNull(Value) Then
         Return 0.0

      ElseIf IsNumeric(Value) Then
         Select Case clsAppInfo.DecimalNro
            Case 1
               If CDec(Value) < 0.1 Then
                  Return 0
               End If

            Case 2
               If CDec(Value) < 0.01 Then
                  Return 0
               End If

            Case 3
               If CDec(Value) < 0.001 Then
                  Return 0
               End If

            Case 4
               If CDec(Value) < 0.0001 Then
                  Return 0
               End If

            Case 5
               If CDec(Value) < 0.00001 Then
                  Return 0
               End If
         End Select

         Return CDec(Value)

      Else
         Return 0.0
      End If
   End Function

   Public Function ToStr(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return String.Empty
      ElseIf CStr(Value) <> String.Empty Then
         Return Trim(Value)
      Else
         Return String.Empty
      End If
   End Function

   Public Function DecimalMask() As String
      Select Case clsAppInfo.DecimalNro
         Case 1
            Return "##,##0.0"
         Case 2
            Return "##,##0.00"
         Case 3
            Return "##,##0.000"
         Case 4
            Return "##,##0.0000"
         Case 5
            Return "##,##0.00000"
      End Select
   End Function

   Public Function ToDecStr(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0.0"
      ElseIf IsNumeric(Value) Then
         Select Case clsAppInfo.DecimalNro
            Case 1
               Return Format(Value, "##,##0.0")
            Case 2
               Return Format(Value, "##,##0.00")
            Case 3
               Return Format(Value, "##,##0.000")
            Case 4
               Return Format(Value, "##,##0.0000")
            Case 5
               Return Format(Value, "##,##0.00000")
         End Select
      Else
         Return "0.0"
      End If
   End Function

   Public Function ToDecStrDos(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0.0"
      ElseIf IsNumeric(Value) Then
         Return Format(Value, "##,##0.00")
      Else
         Return "0.0"
      End If
   End Function

   Public Function ToDecStrTres(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0.0"
      ElseIf IsNumeric(Value) Then
         Return Format(Value, "##,##0.000")
      Else
         Return "0.0"
      End If
   End Function

   Public Function ToDecStrCuatro(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0.0"
      ElseIf IsNumeric(Value) Then
         Return Format(Value, "##,##0.0000")
      Else
         Return "0.0"
      End If
   End Function

   Public Function ToDecStrCinco(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "0.0"
      ElseIf IsNumeric(Value) Then
         Return Format(Value, "##,##0.00000")
      Else
         Return "0.0"
      End If
   End Function

   Public Function toDivByCero(ByVal Value As Object) As Decimal
      If IsDBNull(Value) Then
         Return 1
      ElseIf IsNumeric(Value) Then
         If CDec(Value) <> 0 Then
            Return Math.Round(CDec(Value), clsAppInfo.DecimalNro)
         Else
            Return 1
         End If
      Else
         Return 1
      End If
   End Function

   Function ToDateTime(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "#12:00:00 AM#"
      ElseIf CStr(Value) = String.Empty Then
         Return "#12:00:00 AM#"
      ElseIf IsDate(Value) Then
         Return Format(CDate(Value), "MM/dd/yyyy H:mm:ss")
      Else
         Return "#12:00:00 AM#"
      End If
   End Function

   Function ToDate(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "#12:00:00 AM#"
      ElseIf CStr(Value) = String.Empty Then
         Return "#12:00:00 AM#"
      ElseIf IsDate(Value) Then
         Return Format(CDate(Value), "MM/dd/yyyy")
      Else
         Return "#12:00:00 AM#"
      End If
   End Function

   Function ToDateDMY(ByVal Value As Object) As String
      If IsDBNull(Value) Then
         Return "#12:00:00 AM#"
      ElseIf CStr(Value) = String.Empty Then
         Return "#12:00:00 AM#"
      ElseIf IsDate(Value) Then
         Return Format(CDate(Value), "dd/MM/yyyy")
      Else
         Return "#12:00:00 AM#"
      End If
   End Function

   Function ToDate2(ByVal Value As Object) As Date
      If IsDBNull(Value) Then
         Return #12:00:00 AM#
      ElseIf CStr(Value) = String.Empty Then
         Return #12:00:00 AM#
      ElseIf IsDate(Value) Then
         Return CDate(Value)
      Else
         Return #12:00:00 AM#
      End If
   End Function

   Public Function ConvertDMY(ByVal strDate As String) As String
      Dim strFechaNormal As String

      strFechaNormal = Mid$(strDate, 4, 2)
      strFechaNormal &= "/"
      strFechaNormal &= Mid$(strDate, 1, 2)
      strFechaNormal &= "/"
      strFechaNormal &= Mid$(strDate, 7, 4)

      ConvertDMY = strFechaNormal
   End Function

   Public Function ConvertDDMMYYYY(ByVal strDate As String) As String
      Dim strFechaNormal As String

      strFechaNormal = Mid$(strDate, 1, 2)
      strFechaNormal &= Mid$(strDate, 4, 2)
      strFechaNormal &= Mid$(strDate, 7, 4)

      ConvertDDMMYYYY = strFechaNormal
   End Function

   Public Function ConvertMMYYYY(ByVal strDate As String) As String
      Dim strFechaNormal As String

      strFechaNormal = Mid$(strDate, 4, 2)
      strFechaNormal &= Mid$(strDate, 7, 4)

      ConvertMMYYYY = strFechaNormal
   End Function

   Function ToPhone(ByVal Value As String) As String
      Dim strReturn As String
      Dim intX As Integer

      For intX = 0 To (Value.Length() - 1)
         If Char.IsDigit(Value.Chars(intX)) Then
            strReturn += Value.Chars(intX)
         End If
      Next

      If Len(strReturn) = 11 Then
         strReturn = "(" & Mid(strReturn, 2, 3) & ") " & Mid(strReturn, 4, 3) & "-" & Right(strReturn, 4)
      ElseIf Len(strReturn) = 10 Then
         strReturn = "(" & Left(strReturn, 3) & ") " & Mid(strReturn, 4, 3) & "-" & Right(strReturn, 4)
      ElseIf Len(strReturn) = 7 Then
         strReturn = Left(strReturn, 3) & "-" & Right(strReturn, 4)
      Else
         Dim ex As New Exception("Invalid phone number")
         Throw ex
      End If

      Return strReturn
   End Function

   Function DateBOM(ByVal datDate As Date) As String
      If IsDate(datDate) Then
         DateBOM = "01/" & ToStr(datDate.Month) & "/" & (datDate.Year)
      Else
         DateBOM = Format(Now.Date, "dd/MM/yyyy")
      End If
   End Function

   Function DateEOM(ByVal datDate As Date) As String
      If IsDate(datDate) Then
         datDate = DateAdd("m", 1, datDate)
         datDate = DateBOM(datDate)
         datDate = DateAdd("d", -1, datDate)

         DateEOM = Format$(datDate, "dd/MM/yyyy")
      Else
         DateEOM = Format(Now.Date, "dd/MM/yyyy")
      End If
   End Function

    Function ToCeroComplete(ByVal strValue As String, ByVal intCantidad As Integer) As String
        If (Len(strValue) > 0) And (intCantidad > Len(strValue)) Then
            Dim strCero As String = ""

            For i As Integer = 1 To intCantidad
                strCero &= "0"
            Next

            Return Right(strCero & strValue, intCantidad)
        Else
            Return strValue
        End If
    End Function

    Function ToNextCod(ByVal strValue As String, ByVal intCantidad As Integer) As String
        If Len(strValue) > 0 Then
            Dim strCero As String = ""
            Dim strAux As String = ""
            Dim strAux2 As String = ""
            Dim i As Integer

            For i = strValue.Length To 1 Step -1
                If IsNumeric(Mid$(strValue, i, 1)) Then
                    strAux = Mid$(strValue, i, 1) & strAux
                Else
                    strAux2 = Left(strValue, i)
                    Exit For
                End If
            Next

            If Len(strAux) > 0 Then
                strAux = ToStr(ToLong(strAux) + 1)
            End If

            If (Len(strAux) > 0) And (intCantidad > Len(strAux)) Then
                For i = 1 To intCantidad
                    strCero &= "0"
                Next

                strAux = Right(strCero & strAux, intCantidad)
            End If

            Return strAux2 & strAux

        Else
            Return strValue
        End If
    End Function

    Function ToPartInt(ByVal strValue As String) As String
        If Len(strValue) > 0 Then
            Dim strAux As String = ""
            Dim i As Integer

            For i = strValue.Length To 1 Step -1
                If IsNumeric(Mid$(strValue, i, 1)) Then
                    strAux = Mid$(strValue, i, 1) & strAux
                Else
                    Exit For
                End If
            Next

            Return strAux

        Else
            Return strValue
        End If
    End Function

   Public Function ConcurInsert() As String
      Dim strSQL As String

      strSQL &= "sLastUpdate_id, "
      strSQL &= "dtLastUpdate_dt, "
      strSQL &= "iConcurrency_id "

      ConcurInsert = strSQL
   End Function

   Public Function ConcurDateInserted(ByVal strLoginId As String) As String
      Dim strSQL As String

      strSQL &= StringToField(strLoginId) & ", "
      strSQL &= "'" & Format(Now, "MM/dd/yyyy H:mm:ss") & "', "
      strSQL &= "1)"

      ConcurDateInserted = strSQL
   End Function

   Public Function ConcurDateUpdated(ByVal intConcur As Integer, ByVal strLoginId As String) As String
      Dim strSQL As String

      strSQL &= "sLastUpdate_id = " & StringToField(strLoginId) & ", "
      strSQL &= "dtLastUpdate_dt = '" & Format(Now, "MM/dd/yyyy H:mm:ss") & "', "
      If intConcur = -1 Then
         strSQL &= "iConcurrency_id = 1"
      Else
         If intConcur > 32000 Then
            strSQL &= "iConcurrency_id = 1"
         Else
            strSQL &= "iConcurrency_id = iConcurrency_id + 1 "
         End If
      End If

      ConcurDateUpdated = strSQL
   End Function

   Public Function TableIDGet(ByVal strTable As String, ByVal strPrimaryKey As String, ByVal oConnection As Data.OleDb.OleDbConnection) As Integer
      Dim oCommand As Data.OleDb.OleDbCommand
      Dim oReader As Data.OleDb.OleDbDataReader
      Dim strSQL As String
      Dim intNext As Integer
      Dim intRecordsAffected As Integer
      Dim intConcurrencyId As Integer

      Try
         strSQL = " SELECT * "
         strSQL &= " FROM tblTableIDs  "
         strSQL &= " WHERE szTable_nm = '" & strTable & "' "

         oCommand = New Data.OleDb.OleDbCommand(strSQL, oConnection)
         oReader = oCommand.ExecuteReader()

         If Not oReader.Read Then
            oReader.Close()

            strSQL = "SELECT Max(" & strPrimaryKey & ") As lMaxValue "
            strSQL &= " FROM " & strTable

            oCommand = New Data.OleDb.OleDbCommand(strSQL, oConnection)
            oReader = oCommand.ExecuteReader()

            If Not oReader.Read Then
               intNext = 1
            Else
               If (oReader.IsDBNull(0)) Then
                  intNext = 1
               Else
                  intNext = oReader("lMaxValue") + 1
               End If
            End If
            oReader.Close()

            strSQL = "INSERT INTO tblTableIDs("
            strSQL &= "szTable_nm, "
            strSQL &= "lNext_id, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= StringToField(strTable) & ", "
            strSQL &= NumberToField(intNext) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

            oCommand = New Data.OleDb.OleDbCommand
            oCommand.CommandText = strSQL
            oCommand.Connection = oConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               Return intNext
            Else
               intNext = -1
            End If
         Else
            intNext = oReader("lNext_id") + 1
            intConcurrencyId = ToInteger(oReader("iConcurrency_id"))
            oReader.Close()

            strSQL = "UPDATE tblTableIDs SET "
            strSQL &= "lNext_id = " & NumberToField(intNext) & ", "
            strSQL &= ConcurDateUpdated(intConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " szTable_nm = " & StringToField(strTable) & " "

            oCommand = New Data.OleDb.OleDbCommand
            oCommand.CommandText = strSQL
            oCommand.Connection = oConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               Return intNext
            Else
               intNext = -1
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function TableExits(ByVal strConnectString As String, ByVal strTablaName As String) As Boolean
      Dim oConnection As New Data.OleDb.OleDbConnection(strConnectString)
      Dim oDataTable As New DataTable
      Dim dbNull As System.DBNull
      Dim oRestrictions() As Object = {dbNull, dbNull, dbNull, "TABLE"}

      Try
         If oConnection.State = ConnectionState.Closed Then
            oConnection.Open()
         End If

         'Dim oDataAdapter As New Data.OleDb.OleDbDataAdapter( _
         '                "SELECT * FROM INFORMATION_SCHEMA.TABLES " & _
         '                "WHERE TABLE_TYPE = 'BASE TABLE' " & _
         '                "ORDER BY TABLE_TYPE", _
         '                oConnection)

         'oDataAdapter.Fill(oDataTable)

         oDataTable = oConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, oRestrictions)

         For Each oDataRow As DataRow In oDataTable.Rows
            If oDataRow("TABLE_NAME").ToString() = strTablaName Then
               Return True
            End If
         Next

         Return False

      Catch exp As Exception
         Throw exp
         Return False

      End Try
   End Function

   Public Function EncryptPWD(ByVal strPWD As String) As String
      Dim intLoop As Integer
      Dim intPos As Integer
      Dim strPassword As String

      Const PWD_ENCRYPT As String = "akdirhjsi893kdc,.o93jksmfdhujdy398olakhdo89ljkcidp33k497"

      If Len(strPWD) Then
         intPos = Len(strPWD) / 2 + Len(PWD_ENCRYPT) / 2
         strPassword = Mid$(PWD_ENCRYPT, intPos - 2, 2)
         For intLoop = 1 To Len(strPWD)
            strPassword = strPassword & _
                          Chr(Asc(Mid$(strPWD, intLoop)) + _
                              Asc(Mid$(PWD_ENCRYPT, intPos)))
            intPos = intPos + 1
         Next
         If Len(strPassword) < 16 Then
            strPassword = strPassword & Mid$(PWD_ENCRYPT, intPos, 16 - Len(strPassword))
         End If
      Else
         strPassword = strPWD
      End If

      EncryptPWD = strPassword
   End Function

   Function ComplexPassword(ByVal pwd As String) As Boolean
      ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
      Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
      Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
      Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
      ' Special is "none of the above".
      Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

      ' Check the length.
      If Len(pwd) < clsAppInfo.MinLength Then Return False
      ' Check for minimum number of occurrences.
      If upper.Matches(pwd).Count < clsAppInfo.NumUpper Then Return False
      If lower.Matches(pwd).Count < clsAppInfo.NumLower Then Return False
      If number.Matches(pwd).Count < clsAppInfo.NumNumbers Then Return False
      If special.Matches(pwd).Count < clsAppInfo.NumSpecial Then Return False

      ' Passed all checks.
      Return True
   End Function

   Public Function DateSrvNow(ByVal oConnection As Data.OleDb.OleDbConnection) As String
      Dim oCommand As Data.OleDb.OleDbCommand
      Dim oReader As Data.OleDb.OleDbDataReader
      Dim strSQL As String
      Dim strFechaNow As String

      Try

         strSQL = " SELECT GETDATE() AS FechaNow"
         oCommand = New Data.OleDb.OleDbCommand(strSQL, oConnection)
         oReader = oCommand.ExecuteReader()

         If oReader.Read Then

            strFechaNow = ToDateTime(oReader("FechaNow"))
            oReader.Close()
            Return strFechaNow
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function DateTimeToField(ByVal Value As Object, ByVal Opc As Long) As String
      If IsDBNull(Value) Then
         Return "Null"
      ElseIf Value.Trim() = String.Empty Then
         Return "Null"
      ElseIf Value = "#12:00:00 AM#" Then
         Return "Null"
      ElseIf IsDate(ToDateDMY(Value)) Then
         If Opc = 0 Then
            Value = Format(CDate(Value), "MM/dd/yyyy 00:00:00")
         ElseIf Opc = 1 Then
            Value = Format(CDate(Value), "MM/dd/yyyy 23:59:59")
            'Else
            '   Value = Format(CDate(Value), "MM/dd/yyyy H:mm:ss")
         End If

         If clsAppInfo.ProviderId = 1 Then
            Return "#" & CStr(Value) & "#"
         Else
            Return "'" & CStr(Value) & "'"
         End If
      Else
         Return "Null"
      End If
   End Function
End Module
