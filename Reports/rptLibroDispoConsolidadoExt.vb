Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptLibroDispoConsolidadoExt

   Private mboolIntervaloFecha As Boolean
   Public Property IntervaloFecha() As Boolean
      Get
         Return mboolIntervaloFecha
      End Get
      Set(ByVal value As Boolean)
         mboolIntervaloFecha = value
      End Set
   End Property

   Private mboolSaldoAnterior As Boolean
   Public Property SaldoAnterior() As Boolean
      Get
         Return mboolSaldoAnterior
      End Get
      Set(ByVal value As Boolean)
         mboolSaldoAnterior = value
      End Set
   End Property

   Private Sub rptLibroDispoConsolidado_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
      lblFechaIni.Visible = mboolIntervaloFecha
      txtFechaIni.Visible = mboolIntervaloFecha
      lblFechaFin.Visible = mboolIntervaloFecha
      txtFechaFin.Visible = mboolIntervaloFecha

      If Not mboolSaldoAnterior Then
         lblSaldoAnt.Text = ""
         txtSaldoAnt.Text = ""
         txtSaldoAnt.DataField = ""
         lblSaldoAntUs.Visible = False
         txtSaldoAntUs.Visible = False

         lblPlanDes.Width = lblPlanDes.Width + (txtSaldoAnt.Width * 2)
         txtPlanDes.Width = txtPlanDes.Width + (txtSaldoAnt.Width * 2)

         lblDebe.Location = New PointF(txtPlanDes.Location.X + txtPlanDes.Width, lblDebe.Location.Y)
         txtDebe.Location = New PointF(txtPlanDes.Location.X + txtPlanDes.Width, txtDebe.Location.Y)

         lblHaber.Location = New PointF(lblDebe.Location.X + lblDebe.Width, lblHaber.Location.Y)
         txtHaber.Location = New PointF(txtDebe.Location.X + txtDebe.Width, txtHaber.Location.Y)
      
         lblSaldo.Location = New PointF(lblSaldoAntUs.Location.X, lblSaldoAntUs.Location.Y)
         txtSaldo.Location = New PointF(txtSaldoAntUs.Location.X, txtSaldoAntUs.Location.Y)
      End If
   End Sub
End Class
