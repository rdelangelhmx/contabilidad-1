Imports Microsoft.Office.Interop

Module modExcel
   Dim boolRunning As Boolean

   Public Function ExcelNew(ByRef oExcel As Excel.Application) As Boolean
      Try
         boolRunning = True

         If oExcel Is Nothing Then
            'oExcel = GetObject(, "Excel.Application")
            oExcel = New Excel.Application
            boolRunning = False
         End If

         If oExcel Is Nothing Then
            MsgBox("No se pudo crear el objeto Excel")
            ExcelNew = False

         Else
            If Not oExcel.Visible Then
               oExcel.Visible = True
            End If

            ExcelNew = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function ExcelOpen(ByRef oExcel As Excel.Application, ByVal strSource As String) As Boolean
      Try
         boolRunning = True

         oExcel = New Excel.Application
         oExcel.Workbooks.Open(strSource)

         If oExcel Is Nothing Then
            oExcel = New Excel.Application
            boolRunning = False
         End If

         If oExcel Is Nothing Then
            MsgBox("No se pudo abrir el objeto Excel")
            ExcelOpen = False

         Else
            If Not oExcel.Visible Then
               oExcel.Visible = False
            End If

            ExcelOpen = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub ExcelKill(ByRef oExcel As Excel.Application)
      Try
         If Not oExcel Is Nothing Then
            If oExcel.Workbooks.Count > 0 Then
               'If MsgBox("Quiere cerrar el libro Excel", vbYesNo + vbQuestion, "Reportes en Excel") = vbYes Then
               oExcel.ActiveWorkbook.Close(False)
               'End If
            End If

            If Not boolRunning Then
               oExcel.Quit()
            End If

            oExcel = Nothing
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Sub

   'Public Function ExportDataTableToExcel(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
   '   Try
   '      Dim oApp As New Microsoft.Office.Interop.Excel.Application
   '      Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
   '      Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
   '      Dim oDataRow As System.Data.DataRow


   '      'Añadimos el Libro al programa, y la hoja al libro
   '      oWorkbook = oApp.Workbooks.Add
   '      oWorksheet = oWorkbook.Worksheets.Add()

   '      ' ¿Cuantas columnas y cuantas filas?
   '      Dim NCol As Integer = oDataTable.Columns.Count
   '      Dim NRow As Integer = oDataTable.Rows.Count

   '      'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
   '      For i As Integer = 1 To NCol
   '         oWorksheet.Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
   '         'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
   '      Next

   '      For Fila As Integer = 0 To NRow - 1
   '         oDataRow = oDataTable.Rows(Fila)

   '         For Col As Integer = 0 To NCol - 1

   '            oWorksheet.Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
   '         Next
   '      Next

   '      'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
   '      oWorksheet.Rows.Item(1).Font.Bold = 1
   '      oWorksheet.Rows.Item(1).HorizontalAlignment = 3
   '      oWorksheet.Columns.AutoFit()

   '      'Dim objHojaExcel As Microsoft.Office.Interop.Excel.Worksheet = oWorkbook.Worksheets(1)
   '      'objHojaExcel.Range("M1", "M9").Activate()
   '      'Dim strValue As Object = objHojaExcel.Range("M1", "M9").Value
   '      'strValue = strValue.Replace("'", "")
   '      'objHojaExcel.Range("M1", "M9").Value = strValue
   '      ''Aplicación visible
   '      'exApp.Application.Visible = True

   '      oWorkbook.Application.DisplayAlerts = False
   '      oWorksheet.SaveAs(strFileName)
   '      oWorkbook.Close()
   '      oApp.Quit()

   '      oWorksheet = Nothing
   '      oWorkbook = Nothing
   '      oApp = Nothing

   '      ExportDataTableToExcel = True

   '   Catch ex As Exception
   '      MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
   '      ExportDataTableToExcel = False
   '   End Try
   'End Function

   Public Function ExportDataTableToExcel(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ","

         'oApp.Workbooks(1).SaveAs(, Excel.XlFileFormat.xlCSV)


         'oWorksheet = oWorkbook.Worksheets.Selec
         oWorksheet = oWorkbook.Worksheets(1)

         'oWorksheet.Select()
         'oWorksheet.ClearContents()

         '' Referenciamos la hoja de cálculo del libro.
         ''
         'oWorksheet = DirectCast(oWorkbook.Sheets("Hoja1"), Excel.Worksheet)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()
         oWorkbook.Worksheets(1).Rows.Item(1).ColumnWidth = 12
         oWorkbook.Worksheets(1).Rows.Item(1).RowHeight = 57
       
         oApp.Selection.NumberFormat = "#.00"
         oWorkbook.Worksheets(1).Rows.Item(1).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
         oWorkbook.Worksheets(1).Rows.Item(1).WrapText() = True
         'oWorksheet.Range("M2", "M" & NRow + 1).Style = "Numero"
         oApp.Columns(13).Select()
         oApp.Selection.NumberFormat = "#,##0.00"
         oWorksheet.Range("A2").Select()

         ''Aplicación visible
         'exApp.Application.Visible = True

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName)
         oWorkbook.Close()
         'oWorksheet = Nothing
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()

      
         oApp = Nothing

         ExportDataTableToExcel = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcel = False
      End Try
   End Function

   Public Function ExportDataTableToExcelRetro(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ","

         'oApp.Workbooks(1).SaveAs(, Excel.XlFileFormat.xlCSV)


         'oWorksheet = oWorkbook.Worksheets.Selec
         oWorksheet = oWorkbook.Worksheets(1)

         'oWorksheet.Select()
         'oWorksheet.ClearContents()

         '' Referenciamos la hoja de cálculo del libro.
         ''
         'oWorksheet = DirectCast(oWorkbook.Sheets("Hoja1"), Excel.Worksheet)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()
         oWorkbook.Worksheets(1).Rows.Item(1).ColumnWidth = 12
         oWorkbook.Worksheets(1).Rows.Item(1).RowHeight = 57

         oApp.Selection.NumberFormat = "#.00"
         oWorkbook.Worksheets(1).Rows.Item(1).VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
         oWorkbook.Worksheets(1).Rows.Item(1).WrapText() = True
         'oWorksheet.Range("M2", "M" & NRow + 1).Style = "Numero"
         oApp.Columns(13).Select()
         oApp.Selection.NumberFormat = "#,##0.00"
         oApp.Columns(14).Select()
         oApp.Selection.NumberFormat = "#,##0.00"
         oWorksheet.Range("A2").Select()

         ''Aplicación visible
         'exApp.Application.Visible = True

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName)
         oWorkbook.Close()
         'oWorksheet = Nothing
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()


         oApp = Nothing

         ExportDataTableToExcelRetro = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcelRetro = False
      End Try
   End Function

   Public Function ExportDataTableToExcelNormal(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ","

         'oApp.Workbooks(1).SaveAs(, Excel.XlFileFormat.xlCSV)


         'oWorksheet = oWorkbook.Worksheets.Selec
         oWorksheet = oWorkbook.Worksheets(1)

         'oWorksheet.Select()
         'oWorksheet.ClearContents()

         '' Referenciamos la hoja de cálculo del libro.
         ''
         'oWorksheet = DirectCast(oWorkbook.Sheets("Hoja1"), Excel.Worksheet)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()
         'oWorksheet.Range("M2", "M" & NRow + 1).Style = "Numero"
         'oApp.Columns(13).Select()
         'oApp.Selection.NumberFormat = "#,##0.00"
         'oWorksheet.Range("A2").Select()
         With oWorkbook.Worksheets(1)
            '.Cells(1, 1).HorizontalAlignment = xlVAlignCenter
            '.Cells(1, 1).VerticalAlignment = xlCenter
            '.Cells(1, 1).WrapText = True
            Dim range As Excel.Range = .Range("A1:AE1")
            range.WrapText = True
            range.ColumnWidth = 12
            range.Font.Name = "Arial"
            range.Font.Bold = True
            range.Font.Size = 8
            range.RowHeight = 57
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            range.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium
            range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            'range.AutoFit()

         End With
         ''Aplicación visible
         'exApp.Application.Visible = True

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName)
         oWorkbook.Close()
         'oWorksheet = Nothing
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()


         oApp = Nothing

         ExportDataTableToExcelNormal = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcelNormal = False
      End Try
   End Function

   Public Function ExportDataTableToExcelPlanillaCSV(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ","

         oWorksheet = oWorkbook.Worksheets(1)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()

         oApp.Columns(27).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(28).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(29).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(30).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(31).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(32).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(33).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(34).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(35).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(37).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(38).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(39).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(40).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(41).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(42).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(43).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(44).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(45).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(46).Select()
         oApp.Selection.NumberFormat = "#.00"

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName, Excel.XlFileFormat.xlCSV)
         oWorkbook.Close()
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()


         oApp = Nothing

         ExportDataTableToExcelPlanillaCSV = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcelPlanillaCSV = False
      End Try
   End Function

   Public Function ExportDataTableToExcelCSVAFP(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ""

         oWorksheet = oWorkbook.Worksheets(1)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()
         oApp.Columns(16).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(17).Select()
         oApp.Selection.NumberFormat = "#,00"
         oApp.Columns(18).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(19).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(21).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(22).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(23).Select()
         oApp.Selection.NumberFormat = "#.00"
         oWorksheet.Range("A2").Select()
         oApp.Columns("A").ColumnWidth = 20

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName, Excel.XlFileFormat.xlCSV)
         oWorkbook.Close()
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()


         oApp = Nothing

         ExportDataTableToExcelCSVAFP = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcelCSVAFP = False
      End Try
   End Function

   Public Function ExportDataTableToExcelCSVANS(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ""

         'oApp.Workbooks(1).SaveAs(, Excel.XlFileFormat.xlCSV)


         'oWorksheet = oWorkbook.Worksheets.Selec
         oWorksheet = oWorkbook.Worksheets(1)

         'oWorksheet.Select()
         'oWorksheet.ClearContents()

         '' Referenciamos la hoja de cálculo del libro.
         ''
         'oWorksheet = DirectCast(oWorkbook.Sheets("Hoja1"), Excel.Worksheet)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
            'oWorkbook.Worksheets(1).Cells.Item(Fila + 2, 16).Select()
            'oWorkbook.Worksheets(1).Selection.NumberFormat = "#.00"
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()
         'oWorksheet.Range("M2", "M" & NRow + 1).Style = "Numero"
         oApp.Columns(16).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(15).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(17).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(18).Select()
         oApp.Selection.NumberFormat = "#.00"
         'oApp.Columns(22).Select()
         'oApp.Selection.NumberFormat = "#.00"
         oWorksheet.Range("A2").Select()
         'For intCont As Int16 = 1 To 18
         '   oApp.Columns(intCont).ColumnWidth = 10
         'Next

         ''Aplicación visible
         'exApp.Application.Visible = True

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName, Excel.XlFileFormat.xlCSV)
         oWorkbook.Close()
         'oWorksheet = Nothing
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()


         oApp = Nothing

         ExportDataTableToExcelCSVANS = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcelCSVANS = False
      End Try
   End Function

   Public Function ExportDataTableToExcelCSVANSRetro(ByVal strFileName As String, ByVal oDataTable As DataTable) As Boolean
      Try
         Dim oApp As New Microsoft.Office.Interop.Excel.Application
         Dim oWorkbook As Microsoft.Office.Interop.Excel.Workbook
         Dim oWorksheet As Microsoft.Office.Interop.Excel.Worksheet
         Dim oDataRow As System.Data.DataRow

         'Añadimos el Libro al programa, y la hoja al libro
         oWorkbook = oApp.Workbooks.Add
         oApp.DecimalSeparator = "."
         oApp.ThousandsSeparator = ""

         'oApp.Workbooks(1).SaveAs(, Excel.XlFileFormat.xlCSV)


         'oWorksheet = oWorkbook.Worksheets.Selec
         oWorksheet = oWorkbook.Worksheets(1)

         'oWorksheet.Select()
         'oWorksheet.ClearContents()

         '' Referenciamos la hoja de cálculo del libro.
         ''
         'oWorksheet = DirectCast(oWorkbook.Sheets("Hoja1"), Excel.Worksheet)

         ' ¿Cuantas columnas y cuantas filas?
         Dim NCol As Integer = oDataTable.Columns.Count
         Dim NRow As Integer = oDataTable.Rows.Count

         'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
         For i As Integer = 1 To NCol
            oWorkbook.Worksheets(1).Cells.Item(1, i) = oDataTable.Columns(i - 1).Caption
            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
         Next

         For Fila As Integer = 0 To NRow - 1
            oDataRow = oDataTable.Rows(Fila)

            For Col As Integer = 0 To NCol - 1
               oWorkbook.Worksheets(1).Cells.Item(Fila + 2, Col + 1) = oDataRow(Col)
            Next
            'oWorkbook.Worksheets(1).Cells.Item(Fila + 2, 16).Select()
            'oWorkbook.Worksheets(1).Selection.NumberFormat = "#.00"
         Next

         'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
         oWorkbook.Worksheets(1).Rows.Item(1).Font.Bold = 1
         oWorkbook.Worksheets(1).Rows.Item(1).HorizontalAlignment = 3
         oWorkbook.Worksheets(1).Columns.AutoFit()
         'oWorksheet.Range("M2", "M" & NRow + 1).Style = "Numero"
         oApp.Columns(16).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(15).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(17).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(18).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(19).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(20).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(21).Select()
         oApp.Selection.NumberFormat = "#.00"
         oApp.Columns(22).Select()
         oApp.Selection.NumberFormat = "#.00"
         'oApp.Columns(22).Select()
         'oApp.Selection.NumberFormat = "#.00"
         oWorksheet.Range("A2").Select()
         'For intCont As Int16 = 1 To 18
         '   oApp.Columns(intCont).ColumnWidth = 10
         'Next

         ''Aplicación visible
         'exApp.Application.Visible = True

         oWorkbook.Application.DisplayAlerts = False
         oWorkbook.Worksheets(1).SaveAs(strFileName, Excel.XlFileFormat.xlCSV)
         oWorkbook.Close()
         'oWorksheet = Nothing
         oWorkbook = Nothing
         oApp.Quit()
         GC.Collect()


         oApp = Nothing

         ExportDataTableToExcelCSVANSRetro = True

      Catch ex As Exception
         MessageBox.Show(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
         ExportDataTableToExcelCSVANSRetro = False
      End Try
   End Function


   Public Function getHojasExcel(ByVal strSource As String, ByRef lstHojas As List(Of String)) As Boolean
      Try

         Dim oExcel As Excel.Application

         If ExcelOpen(oExcel, strSource) Then

            For Each Hoja As Microsoft.Office.Interop.Excel.Worksheet In oExcel.Worksheets
               lstHojas.Add(Hoja.Name)
            Next

            Call ExcelKill(oExcel)

            Return True
         End If
      Catch exp As Exception
         Throw exp

      End Try
   End Function

End Module
