Module modValidate

    'Function SoloLETRAS(ByVal KeyAscii As Integer) As Integer
    '    KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
    '    ' Intercepta un código ASCII recibido admitiendo solamente
    '    ' letras, además:
    '    ' deja pasar sin afectar si recibe tecla de Backspace o enter
    '    If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ", Chr(KeyAscii)) = 0 Then
    '        SoloLETRAS = 0
    '    Else
    '        SoloLETRAS = KeyAscii
    '    End If
    '    ' teclas adicionales permitidas
    '    If KeyAscii = 8 Then SoloLETRAS = KeyAscii ' Backspace
    '    If KeyAscii = 13 Then SoloLETRAS = KeyAscii ' Enter
    'End Function

    Public Function SoloLetras(ByVal KeyAscii As Short) As Short
        SoloLetras = KeyAscii
        Select Case KeyAscii
            Case 8              ' Backspace Key
            Case 13             ' Enter Key
            Case 65 To 90       ' Upper Case Chars
            Case 97 To 122      ' Lower Case Chars
            Case 32
            Case Else
                Beep()
                SoloLetras = 0  ' Cancels keystroke
        End Select
    End Function

    Public Function SoloMayusculas(ByVal KeyAscii As Short) As Short
        SoloMayusculas = CShort(Asc(UCase(Chr(KeyAscii))))
    End Function

    Public Function SoloNumeros(ByVal KeyAscii As Short) As Short
        SoloNumeros = KeyAscii
        Select Case KeyAscii
            Case 8              ' Backspace Key
            Case 13             ' Enter Key
            Case 48 To 57       ' Number 0-9
            Case Else
                Beep()
                SoloNumeros = 0 ' Cancels the keystroke
        End Select
    End Function

    Public Function SoloReales(ByVal KeyAscii As Short) As Short
        SoloReales = KeyAscii
        Select Case KeyAscii
            Case 8              ' Backspace Key
            Case 13             ' Enter Key
            Case 48 To 57       ' Number 0-9
            Case 44             ' Coma
            Case 46             ' Punto
                SoloReales = 44
            Case Else
                Beep()
                SoloReales = 0 ' Cancels the keystroke
        End Select
    End Function

    Public Function SoloFechas(ByVal KeyAscii As Short) As Short
        SoloFechas = KeyAscii
        Select Case KeyAscii
            Case 8              ' Backspace Key
            Case 13             ' Enter Key
            Case 48 To 57       ' Number 0-9
            Case 47
            Case Else
                Beep()
                SoloFechas = 0  ' Cancels the keystroke
        End Select
    End Function


    Public Function SoloTelefonos(ByVal KeyAscii As Short) As Short
        SoloTelefonos = KeyAscii
        Select Case KeyAscii
            Case 8              ' Backspace Key
            Case 13             ' Enter Key
            Case 48 To 57       ' Number 0-9
            Case 45
            Case Else
                Beep()
                SoloTelefonos = 0 ' Cancels the keystroke
        End Select
    End Function

    Public Function DateCheck(ByVal strValue As String) As Boolean
        DateCheck = True
        If strValue <> "" Then
            If Not IsDate(strValue) Then
                DateCheck = False
            End If
        Else
            DateCheck = False
        End If
    End Function

End Module
