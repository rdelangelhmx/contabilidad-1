Imports System.Reflection.Assembly

' Al declararlo como Module no es necesario crear una clase.
' Si se convirtiera en clase, habr�a que declarar las funciones como Shared

Public Module modWinAPI
   '
#Region " Funciones para saber el path y nombre del ejecutable (y esta DLL) "
   '
   '<summary>
   ' Devuelve el path de la aplicaci�n.
   ' Al usarse desde una librer�a (DLL), hay que usar GetCallingAssembly
   ' para que devuelva el path del ejecutable (o librer�a) que llama a esta funci�n.
   ' Si no se usa GetCallingAssembly, devolver�a el path de la librer�a.
   '</summary>
   '<param name="backSlash">Opcional. True si debe devolver el path terminado en \</param>
   '<returns>
   ' El path de la aplicaci�n con o sin backslash, seg�n el valor del par�metro.
   '</returns>
   Public Function AppPath(Optional ByVal backSlash As Boolean = False) As String
      Dim s As String = IO.Path.GetDirectoryName(GetExecutingAssembly.GetCallingAssembly.Location)
      ' si hay que a�adirle el backslash
      If backSlash Then
         s &= "\"
      End If

      Return s
   End Function
   '
   '<summary>
   ' Devuelve el nombre del ejecutable.
   ' Al usarse desde una librer�a (DLL), hay que usar GetCallingAssembly
   ' para que devuelva el nombre del ejecutable (o librer�a) que llama a esta funci�n.
   ' Si no se usa GetCallingAssembly, devolver�a el nombre de esta librer�a.
   '</summary>
   '<param name="fullPath">Opcional. True si debe devolver nombre completo.</param>
   '<returns>El nombre del ejecutable, con o sin el path completo, seg�n el valor del par�metro.
   '</returns>
   Public Function AppExeName(Optional ByVal fullPath As Boolean = False) As String
      Dim s As String = GetExecutingAssembly.GetCallingAssembly.Location
      Dim fi As New IO.FileInfo(s)

      If fullPath Then
         s = fi.FullName
      Else
         s = fi.Name
      End If

      Return s
   End Function
   '
   '<summary>
   ' Devuelve el path de esta librer�a.
   '</summary>
   '<param name="backSlash">Opcional. True si debe devolver el path terminado en \
   '</param>
   '<returns>
   ' El path de esta librer�a, con o sin backslash, seg�n el valor del par�metro.
   '</returns>
   Public Function DLLPath(Optional ByVal backSlash As Boolean = False) As String
      Dim s As String = IO.Path.GetDirectoryName(GetExecutingAssembly.Location)
      ' si hay que a�adirle el backslash
      If backSlash Then
         s &= "\"
      End If

      Return s
   End Function
   '
   '<summary>
   ' Devuelve el nombre de esta librer�a.
   '</summary>
   '<param name="fullPath">Opcional. True si debe devolver nombre completo.</param>
   '<returns>El nombre de esta librer�a, con o sin el path completo, seg�n el valor del par�metro.
   '</returns>
   Public Function DLLName(Optional ByVal fullPath As Boolean = False) As String
      Dim s As String = GetExecutingAssembly.Location
      Dim fi As New IO.FileInfo(s)

      If fullPath Then
         s = fi.FullName
      Else
         s = fi.Name
      End If

      Return s
   End Function

#End Region

   Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

   Public Sub ClearMemory()
      Try
         Dim Mem As Process
         Mem = Process.GetCurrentProcess()
         SetProcessWorkingSetSize(Mem.Handle, -1, -1)

      Catch exp As Exception
         MessageBox.Show(exp.Message, "WinAPI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

End Module

