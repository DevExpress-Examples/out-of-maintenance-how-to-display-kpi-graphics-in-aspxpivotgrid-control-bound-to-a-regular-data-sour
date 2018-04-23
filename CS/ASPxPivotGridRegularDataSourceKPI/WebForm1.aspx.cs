using System;
using DevExpress.Web.ASPxPivotGrid;

namespace ASPxPivotGridRegularDataSourceKPI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                // Specifies that unbound expressions for data fields are calculated against summary values.
                ASPxPivotGrid1.OptionsData.DataFieldUnboundExpressionMode =
                    DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues;

                // Creates a new unbound "Status" field to show KPI values.
                PivotGridField fieldStatus = ASPxPivotGrid1.Fields.Add("Status",
                    DevExpress.XtraPivotGrid.PivotArea.DataArea);

                // Sets a column's unbound type and specifies an unbound expression.
                fieldStatus.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                fieldStatus.UnboundExpression = string.Format("(Iif([{0}]<100000,-1,Iif([{0}]<150000,0,1)))",
                    fieldExtendedPrice.ExpressionFieldName);

                // Sets the Data Header Area within which the "Status" Field can be positioned.
                fieldStatus.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;

                // Specifies a graphic set used to indicate KPI values.
                fieldStatus.KPIGraphic = DevExpress.XtraPivotGrid.PivotKPIGraphic.Faces;
            }
        }
    }
}