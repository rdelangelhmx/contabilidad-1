Module modCifra
   Private VnumParcial As Double
   Private VUltimaCifra As Boolean

   Public Function CifraLiteral(ByVal VCifra) As String
      If VCifra >= 1000000000 Then   'cifra tope : 999.999.999,99
         MsgBox("La funcion no puede leer las cifras mayores a 999.999.999,99")
         Exit Function
      End If

      VnumParcial = VCifra

      Select Case VCifra
         Case 1000000 To 999999999.99
            CifraLiteral = UCase(leemillon() & leecienmil() & leecien())

         Case 1000 To 999999.99
            CifraLiteral = UCase(leecienmil() & leecien())

         Case 1 To 999.99
            CifraLiteral = UCase(leecien())

         Case 0.01 To 0.99
            CifraLiteral = UCase(Format(VCifra * 100, "##0") & "/100.-")

      End Select
   End Function

   Private Function leemillon() As String
      Dim Vnum

      Select Case VnumParcial
         Case 1000000 To 9999999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 2)

         Case 10000000 To 99999999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 3)

         Case 100000000 To 999999999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 4)

      End Select

      VnumParcial = VnumParcial - CDbl(Vnum & "000000")

      If Vnum = 1 Then
         leemillon = "un millón "
      Else
         leemillon = LeeCentena(CLng(Vnum)) & " millones "
      End If
   End Function

   Private Function leecienmil() As String
      Dim Vnum

      Select Case VnumParcial
         Case 1000 To 9999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 2)

         Case 10000 To 99999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 3)

         Case 100000 To 999999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 4)

      End Select

      VnumParcial = VnumParcial - CDbl(Vnum & "000")

      If Vnum > 0 Then
         leecienmil = LeeCentena(CLng(Vnum)) & "mil "
      End If
   End Function

   Private Function leecien() As String
      Dim Vnum

      VUltimaCifra = True

      Select Case VnumParcial
         Case 1 To 9.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 2)

         Case 10 To 99.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 3)

         Case 100 To 999.99
            Vnum = Microsoft.VisualBasic.Left(Str(VnumParcial), 4)

      End Select

      VnumParcial = VnumParcial - CDbl(Vnum)

      leecien = LeeCentena(CLng(Vnum)) + leecentavos()

      VUltimaCifra = False
   End Function

   Private Function LeeCentena(ByVal Vnumero) As String
      If Vnumero >= 100 Then
         Select Case Vnumero
            Case 900 To 999
               If Vnumero = 900 Then
                  LeeCentena = "novecientos "
               Else
                  LeeCentena = "novecientos " & LeeDecena(Vnumero - 900)
               End If

            Case 800 To 899
               If Vnumero = 800 Then
                  LeeCentena = "ochocientos "
               Else
                  LeeCentena = "ochocientos " & LeeDecena(Vnumero - 800)
               End If

            Case 700 To 799
               If Vnumero = 700 Then
                  LeeCentena = "setecientos "
               Else
                  LeeCentena = "setecientos " & LeeDecena(Vnumero - 700)
               End If

            Case 600 To 699
               If Vnumero = 600 Then
                  LeeCentena = "seiscientos "
               Else
                  LeeCentena = "seiscientos " & LeeDecena(Vnumero - 600)
               End If

            Case 500 To 599
               If Vnumero = 500 Then
                  LeeCentena = "quinientos "
               Else
                  LeeCentena = "quinientos " & LeeDecena(Vnumero - 500)
               End If

            Case 400 To 499
               If Vnumero = 400 Then
                  LeeCentena = "cuatrocientos "
               Else
                  LeeCentena = "cuatrocientos " & LeeDecena(Vnumero - 400)
               End If

            Case 300 To 399
               If Vnumero = 300 Then
                  LeeCentena = "trescientos "
               Else
                  LeeCentena = "trescientos " & LeeDecena(Vnumero - 300)
               End If

            Case 200 To 299
               If Vnumero = 200 Then
                  LeeCentena = "doscientos "
               Else
                  LeeCentena = "doscientos " & LeeDecena(Vnumero - 200)
               End If

            Case 100 To 199
               If Vnumero = 100 Then
                  LeeCentena = "cien "
               Else
                  LeeCentena = "ciento " & LeeDecena(Vnumero - 100)
               End If

         End Select
      Else
         LeeCentena = LeeDecena(Vnumero)
      End If
   End Function

   Private Function LeeDecena(ByVal Vnum) As String
      If Vnum >= 10 Then
         Select Case Vnum
            Case 90 To 99
               If Vnum = 90 Then
                  LeeDecena = "noventa "
               Else
                  LeeDecena = "noventa y " & leeunidad(Vnum - 90)
               End If

            Case 80 To 89
               If Vnum = 80 Then
                  LeeDecena = "ochenta "
               Else
                  LeeDecena = "ochenta y " & leeunidad(Vnum - 80)
               End If

            Case 70 To 79
               If Vnum = 70 Then
                  LeeDecena = "setenta "
               Else
                  LeeDecena = "setenta y " & leeunidad(Vnum - 70)
               End If

            Case 60 To 69
               If Vnum = 60 Then
                  LeeDecena = "sesenta "
               Else
                  LeeDecena = "sesenta y " & leeunidad(Vnum - 60)
               End If

            Case 50 To 59
               If Vnum = 50 Then
                  LeeDecena = "cincuenta "
               Else
                  LeeDecena = "cincuenta y " & leeunidad(Vnum - 50)
               End If

            Case 40 To 49
               If Vnum = 40 Then
                  LeeDecena = "cuarenta "
               Else
                  LeeDecena = "cuarenta y " & leeunidad(Vnum - 40)
               End If

            Case 30 To 39
               If Vnum = 30 Then
                  LeeDecena = "treinta "
               Else
                  LeeDecena = "treinta y " & leeunidad(Vnum - 30)
               End If

            Case 20 To 29
               If Vnum = 20 Then
                  LeeDecena = "veinte "
               Else
                  LeeDecena = "veinti" & leeunidad(Vnum - 20)
               End If

            Case 10 To 19
               Select Case Vnum
                  Case Is = 10
                     LeeDecena = "diez "

                  Case Is = 11
                     LeeDecena = "once "

                  Case Is = 12
                     LeeDecena = "doce "

                  Case Is = 13
                     LeeDecena = "trece "

                  Case Is = 14
                     LeeDecena = "catorce "

                  Case Is = 15
                     LeeDecena = "quince "

                  Case Is = 16
                     LeeDecena = "dieciseis "

                  Case Is = 17
                     LeeDecena = "diecisiete "

                  Case Is = 18
                     LeeDecena = "dieciocho "

                  Case Is = 19
                     LeeDecena = "diecinueve "

               End Select
         End Select
      Else
         LeeDecena = leeunidad(Vnum)
      End If
   End Function

   Private Function leeunidad(ByVal VNumUnidad) As String
      Select Case VNumUnidad
         Case Is = 9
            leeunidad = "nueve "

         Case Is = 8
            leeunidad = "ocho "

         Case Is = 7
            leeunidad = "siete "

         Case Is = 6
            leeunidad = "seis "

         Case Is = 5
            leeunidad = "cinco "

         Case Is = 4
            leeunidad = "cuatro "

         Case Is = 3
            leeunidad = "tres "

         Case Is = 2
            leeunidad = "dos "

         Case Is = 1
            If VUltimaCifra = False Then
               leeunidad = "un "
            Else
               leeunidad = "uno "
            End If

      End Select

   End Function

   Private Function leecentavos() As String
      Dim VDecimales As Long

      VDecimales = VnumParcial * 100

      If VDecimales > 0 Then
         If VDecimales > 9 Then
            leecentavos = "con " & Format(VDecimales, "##0") & "/100.-"
         Else
            leecentavos = "con 0" & Format(VDecimales, "##0") & "/100.-"
         End If
      Else
         leecentavos = "con 00/100.-"
      End If
   End Function

End Module
