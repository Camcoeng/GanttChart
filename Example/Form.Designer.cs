namespace Example
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.ganttChart1 = new GanttChart.GanttChart();
            this.SuspendLayout();
            // 
            // ganttChart1
            // 
            this.ganttChart1.AutoScroll = true;
            this.ganttChart1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ganttChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ganttChart1.DayLabelFormats = ((System.Collections.Generic.Dictionary<System.DateTime, string>)(resources.GetObject("ganttChart1.DayLabelFormats")));
            this.ganttChart1.DefaultDayLabelFormat = "dddd";
            this.ganttChart1.DefaultTimeLabelFormat = "htt";
            this.ganttChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttChart1.EndDate = new System.DateTime(((long)(0)));
            this.ganttChart1.EndHourInDay = 24;
            this.ganttChart1.HeaderBackgroundColor = System.Drawing.Color.LightBlue;
            this.ganttChart1.Holidays = ((System.Collections.Generic.Dictionary<System.DateTime, string>)(resources.GetObject("ganttChart1.Holidays")));
            this.ganttChart1.HorizontalGridLinesVisible = false;
            this.ganttChart1.Location = new System.Drawing.Point(0, 0);
            this.ganttChart1.MinTimeIntervalWidth = 0;
            this.ganttChart1.Name = "ganttChart1";
            this.ganttChart1.NowIndicatorHourOffset = 0;
            this.ganttChart1.RowIconLocation = GanttChart.Enums.Corner.SW;
            this.ganttChart1.RowIconSize = new System.Drawing.Size(15, 15);
            this.ganttChart1.ShowNowIndicator = false;
            this.ganttChart1.Size = new System.Drawing.Size(800, 450);
            this.ganttChart1.StartDate = new System.DateTime(((long)(0)));
            this.ganttChart1.StartHourInDay = 0;
            this.ganttChart1.TabIndex = 0;
            this.ganttChart1.TextColor = System.Drawing.Color.Black;
            this.ganttChart1.TimeLabelFormats = ((System.Collections.Generic.Dictionary<System.DateTime, string>)(resources.GetObject("ganttChart1.TimeLabelFormats")));
            this.ganttChart1.TopHeaderHeight = 40;
            this.ganttChart1.VerticalGridLinesVisible = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ganttChart1);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GanttChart.GanttChart ganttChart1;
    }
}

