using AgeRanger.Core.Interfaces;
using AgeRanger.Core.Services;
using AgeRanger.SinglePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgeRanger.SinglePage
{
    public partial class AgeGroupListPage : BasePage
    {
        public IPersonService personService { get; set; }
        string strPreviousRowID = string.Empty;

        int intSubTotalIndex = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGridView();
            }
        }

        private void BindGridView()
        {
            grdViewGroupAge.DataSource = personService.ListAgeGroupPerson().OrderBy(l => l.PersonAgeGroup);
            grdViewGroupAge.DataBind();
        }

        protected void grdViewGroupAge_RowCreated(object sender, GridViewRowEventArgs e)
        {
            GridView grdViewOrders = (GridView)sender;
            TableCell cell = new TableCell();
            cell.ColumnSpan = 6;

            if ((strPreviousRowID == string.Empty) && (DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup") != null))
            {
                GridViewRow row = new GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert);
                cell.Text = "Age Group : " + DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup").ToString();
                row.Cells.Add(cell);
                grdViewOrders.Controls[0].Controls.AddAt(e.Row.RowIndex + intSubTotalIndex, row);
                intSubTotalIndex++;
            }

            if ((strPreviousRowID != string.Empty) && (DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup") != null))
                if (strPreviousRowID != DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup").ToString())
                {
                    GridViewRow row = new GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert);
                    grdViewOrders.Controls[0].Controls.AddAt(e.Row.RowIndex + intSubTotalIndex, row);
                    intSubTotalIndex++;

                    if (DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup") != null)
                    {
                        row = new GridViewRow(0, 0, DataControlRowType.DataRow, DataControlRowState.Insert);
                        cell.Text = "Age Group : " + DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup").ToString();
                        row.Cells.Add(cell);
                        grdViewOrders.Controls[0].Controls.AddAt(e.Row.RowIndex + intSubTotalIndex, row);
                        intSubTotalIndex++;
                    }
                }

        }
        protected void grdViewGroupAge_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                strPreviousRowID = DataBinder.Eval(e.Row.DataItem, "PersonAgeGroup").ToString();
            }
        }


    }
}