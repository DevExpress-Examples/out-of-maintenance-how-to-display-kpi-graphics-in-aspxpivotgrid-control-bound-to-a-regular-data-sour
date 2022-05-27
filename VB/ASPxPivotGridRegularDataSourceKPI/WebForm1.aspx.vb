Imports System
Imports DevExpress.Web.ASPxPivotGrid

Namespace ASPxPivotGridRegularDataSourceKPI
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If (Not IsPostBack) AndAlso (Not IsCallback) Then
                ' Specifies that unbound expressions for data fields are calculated 
                ' against summary values.
                ASPxPivotGrid1.OptionsData.DataFieldUnboundExpressionMode =
                    DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues

                ' Creates a new unbound "Status" field to show KPI values.
                Dim fieldStatus As PivotGridField = ASPxPivotGrid1.Fields.Add("Status", _
                                                         DevExpress.XtraPivotGrid.PivotArea.DataArea)

                ' Sets a column's unbound type and specifies an unbound expression.
                fieldStatus.DataBinding = New ExpressionDataBinding(String.Format("Iif(Sum([{0}])<100000,-1,Sum([{0}])<150000,0,1)", fieldExtendedPrice.ExpressionFieldName))

                ' Sets the Data Header Area within which the "Status" Field can be positioned.
                fieldStatus.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea

                ' Specifies a graphic set used to indicate KPI values.
                fieldStatus.KPIGraphic = DevExpress.XtraPivotGrid.PivotKPIGraphic.Faces
            End If
        End Sub
    End Class
End Namespace