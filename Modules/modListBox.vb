Module modListBox

   Public Sub ListAddItem(ByVal lstCtrl As Janus.Windows.EditControls.UIComboBox, ByVal lngID As Long, ByVal strValue As String)
      Dim oItem As New clsListItem

      oItem.Tag = lngID
      oItem.Value = strValue

      lstCtrl.Items.Add(oItem)
   End Sub

   Public Function ListPosition(ByVal lstCtrl As Janus.Windows.EditControls.UIComboBox, ByVal intIndex As Integer) As Long
      Dim oItem As New clsListItem

      If intIndex = -1 Then
         Return 0
      Else
         oItem = lstCtrl.Items(intIndex).Value
         Return oItem.Tag
      End If
   End Function

   Public Function ListFindItem(ByVal lstCtrl As Janus.Windows.EditControls.UIComboBox, ByVal lngValue As Long) As Integer
      Dim intLoop As Integer
      Dim boolFound As Boolean = False
      Dim oItem As clsListItem

      For intLoop = 0 To lstCtrl.Items.Count - 1
         oItem = lstCtrl.Items(intLoop).Value

         If oItem.Tag = lngValue Then
            ListFindItem = intLoop

            boolFound = True
            Exit For
         End If
      Next

      If Not boolFound Then
         ListFindItem = -1
      End If
   End Function

   Public Function ListPosition(ByVal lstCtrl As Janus.Windows.GridEX.EditControls.MultiColumnCombo) As Long
      ' MessageBox.Show(lstCtrl.DropDownList.RowCount)
      '  lstCtrl.DropDownList.RowCount
      '      If lstCtrl.DropDownList.SelectedItems.Count = 0 Then
      If lstCtrl.DropDownList.RowCount = 0 Then
         Return 0
      Else
         'Return ToLong(lstCtrl.Value)
         If Not lstCtrl.DropDownList.GetRow(lstCtrl.SelectedIndex) Is Nothing Then
            Return ToLong(lstCtrl.DropDownList.GetRow(lstCtrl.SelectedIndex).Cells(lstCtrl.ValueMember).Value)
         Else
            Return 0
         End If
      End If
   End Function

   Public Function ListFindItem(ByVal lstCtrl As Janus.Windows.GridEX.EditControls.MultiColumnCombo, ByVal lngValue As Long) As Object
      Dim boolFound As Boolean = False

      For Each oRow As Janus.Windows.GridEX.GridEXRow In lstCtrl.DropDownList.GetRows
         If ToLong(oRow.Cells(0).Value) = lngValue Then
            ListFindItem = oRow.Cells(0).Value

            boolFound = True
            Exit For
         End If
      Next

      If Not boolFound Then
         ListFindItem = Nothing
      End If
   End Function

End Module
