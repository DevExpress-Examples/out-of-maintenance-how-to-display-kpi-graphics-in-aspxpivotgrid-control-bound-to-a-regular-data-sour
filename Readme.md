<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/ASPxPivotGridRegularDataSourceKPI/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/ASPxPivotGridRegularDataSourceKPI/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/ASPxPivotGridRegularDataSourceKPI/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/ASPxPivotGridRegularDataSourceKPI/WebForm1.aspx.vb))
<!-- default file list end -->
# How to display KPI graphics in ASPxPivotGrid control bound to a regular data source
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t152368/)**
<!-- run online end -->


The following example shows how to display KPI graphics in the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxPivotGridASPxPivotGridtopic">ASPxPivotGrid</a> control bound to a regular data source.<br /><br />The <strong>ASPxPivotGrid</strong> control is bound to a "Sales Person" view in the Northwind database. To display KPI graphics, we create an unbound field whose values correspond to images contained within a KPI graphic set.<br /><br />In this example the unbound field values depend on the "Extended Price" field's values: if "Extended Price" field's value is less then 100000, the unbound field value is "-1", if "Extended Price" field's value is less then 150000, the unbound field value is "0", in other cases the unbound field value is "1".<br /><br />The <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridOptionsData_DataFieldUnboundExpressionModetopic">DataFieldUnboundExpressionMode</a> property is set to <strong>DataFieldUnboundExpressionMode.UseSummaryValues</strong> to calculate unbound expressions for data fields against summary values. The <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_KPIGraphictopic">KPIGraphic</a> property specifies a graphic set used to visualize unbound field values.

<br/>


