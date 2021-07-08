Module modToolbar
    Public Sub ToolbarSetup(ByVal tbrAny As ToolBar)
        Dim btn As ToolBarButton

        With tbrAny
            .Appearance = ToolBarAppearance.Flat
            .BorderStyle = BorderStyle.FixedSingle
            '.Cursor = Cursors.Hand

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "New"
            btn.ToolTipText = "Nuevo"
            btn.ImageIndex = 0
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "Delete"
            btn.ToolTipText = "Eliminar"
            btn.ImageIndex = 1
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "Save"
            btn.ToolTipText = "Guardar"
            btn.ImageIndex = 2
            btn.Enabled = False
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "Cancel"
            btn.ToolTipText = "Cancelar"
            btn.ImageIndex = 3
            btn.Enabled = False
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "Find"
            btn.ToolTipText = "Buscar"
            btn.ImageIndex = 4
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "Print"
            btn.ToolTipText = "Imprimir"
            btn.ImageIndex = 5
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.PushButton
            btn.Tag = "Exit"
            btn.ToolTipText = "Salir"
            btn.ImageIndex = 6
            .Buttons.Add(btn)

            btn = New ToolBarButton
            btn.Style = ToolBarButtonStyle.Separator
            .Buttons.Add(btn)
        End With
    End Sub

    Public Sub ToolbarToggle(ByVal tbrAny As ToolBar)
        With tbrAny
            .Buttons(1).Enabled = Not .Buttons(1).Enabled
            .Buttons(3).Enabled = Not .Buttons(3).Enabled
            .Buttons(5).Enabled = Not .Buttons(5).Enabled
            .Buttons(7).Enabled = Not .Buttons(7).Enabled
        End With
    End Sub

End Module
