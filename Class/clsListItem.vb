Public Class clsListItem
   Private mlngTag As Long
   Private mstrValue As String

   Public Sub New()
      mstrValue = ""
      mlngTag = 0
   End Sub

   Public Sub New(ByVal lngTag As Long, ByVal strValue As String)
      mstrValue = strValue
      mlngTag = lngTag
   End Sub

   Public Property Value() As String
      Get
         Return mstrValue
      End Get

      Set(ByVal strValue As String)
         mstrValue = strValue
      End Set
   End Property

   Public Property Tag() As Long
      Get
         Return mlngTag
      End Get

      Set(ByVal lngValue As Long)
         mlngTag = lngValue
      End Set
   End Property

   Public Overrides Function ToString() As String
      Return mstrValue
   End Function

End Class
