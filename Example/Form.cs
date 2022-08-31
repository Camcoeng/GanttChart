using GanttChart;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            InitChart();
        }

        public void InitChart()
        {

            ganttChart1.StartDate = DateTime.Today;
            ganttChart1.EndDate = DateTime.Today.AddDays(5);
            ganttChart1.StartHourInDay = 8;
            ganttChart1.EndHourInDay = 17;

           
            //Add data
            Row row1 = new Row("Row 1");
            row1.TimeBlocks.Add(new TimeBlock("Shift 1", DateTime.Today.AddHours(8), DateTime.Today.AddHours(13)) { Color = Color.Red });
            ganttChart1.Rows.Add(row1);

            Row row2 = new Row("Row 2");
            row2.TimeBlocks.Add(new TimeBlock("Shift 1", DateTime.Today.AddHours(8), DateTime.Today.AddHours(10)) { Color = Color.Yellow });
            row2.TimeBlocks.Add(new TimeBlock("Shift 2", DateTime.Today.AddHours(13), DateTime.Today.AddHours(17)) { Color = Color.Purple });
            ganttChart1.Rows.Add(row2);


            ganttChart1.UpdateView();
        }
    }
}
