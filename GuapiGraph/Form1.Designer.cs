﻿namespace GuapiGraph
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.menuitem_start = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_func_catchInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.TabControl();
            this.job_chart_page = new System.Windows.Forms.TabPage();
            this.job_chart_combo = new System.Windows.Forms.ComboBox();
            this.companyList_label = new System.Windows.Forms.Label();
            this.job_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.skill_tree_page = new System.Windows.Forms.TabPage();
            this.skill_tree_combo = new System.Windows.Forms.ComboBox();
            this.radar_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.companyList_skill_label = new System.Windows.Forms.Label();
            this.linearRegressionPage = new System.Windows.Forms.TabPage();
            this.LRText = new System.Windows.Forms.Label();
            this.predictionYearLabel3 = new System.Windows.Forms.Label();
            this.predictionYearLabel2 = new System.Windows.Forms.Label();
            this.predictionYearLabel1 = new System.Windows.Forms.Label();
            this.Split1 = new System.Windows.Forms.Label();
            this.PredictionsLabel = new System.Windows.Forms.Label();
            this.SelectPositionLabel = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.predictionLabel = new System.Windows.Forms.Label();
            this.PredictionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.state_label = new System.Windows.Forms.Label();
            this.infomation_state = new System.Windows.Forms.Label();
            this.menubar.SuspendLayout();
            this.table.SuspendLayout();
            this.job_chart_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.job_chart)).BeginInit();
            this.skill_tree_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radar_chart)).BeginInit();
            this.linearRegressionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_start});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1064, 25);
            this.menubar.TabIndex = 0;
            this.menubar.Text = "menu";
            // 
            // menuitem_start
            // 
            this.menuitem_start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_func_catchInfo});
            this.menuitem_start.Name = "menuitem_start";
            this.menuitem_start.Size = new System.Drawing.Size(46, 21);
            this.menuitem_start.Text = "start";
            // 
            // menu_func_catchInfo
            // 
            this.menu_func_catchInfo.Name = "menu_func_catchInfo";
            this.menu_func_catchInfo.Size = new System.Drawing.Size(177, 22);
            this.menu_func_catchInfo.Text = "catch information";
            this.menu_func_catchInfo.Click += new System.EventHandler(this.menu_func_catchInfo_Click);
            // 
            // table
            // 
            this.table.Controls.Add(this.job_chart_page);
            this.table.Controls.Add(this.skill_tree_page);
            this.table.Controls.Add(this.linearRegressionPage);
            this.table.Location = new System.Drawing.Point(0, 48);
            this.table.Name = "table";
            this.table.SelectedIndex = 0;
            this.table.Size = new System.Drawing.Size(1039, 739);
            this.table.TabIndex = 1;
            // 
            // job_chart_page
            // 
            this.job_chart_page.BackColor = System.Drawing.SystemColors.Control;
            this.job_chart_page.Controls.Add(this.job_chart_combo);
            this.job_chart_page.Controls.Add(this.companyList_label);
            this.job_chart_page.Controls.Add(this.job_chart);
            this.job_chart_page.Location = new System.Drawing.Point(4, 30);
            this.job_chart_page.Name = "job_chart_page";
            this.job_chart_page.Padding = new System.Windows.Forms.Padding(3);
            this.job_chart_page.Size = new System.Drawing.Size(1031, 705);
            this.job_chart_page.TabIndex = 0;
            this.job_chart_page.Text = "Overview";
            // 
            // job_chart_combo
            // 
            this.job_chart_combo.FormattingEnabled = true;
            this.job_chart_combo.Location = new System.Drawing.Point(147, 19);
            this.job_chart_combo.Name = "job_chart_combo";
            this.job_chart_combo.Size = new System.Drawing.Size(405, 29);
            this.job_chart_combo.TabIndex = 2;
            this.job_chart_combo.Click += new System.EventHandler(this.job_chart_combo_Click);
            // 
            // companyList_label
            // 
            this.companyList_label.AutoSize = true;
            this.companyList_label.Location = new System.Drawing.Point(8, 22);
            this.companyList_label.Name = "companyList_label";
            this.companyList_label.Size = new System.Drawing.Size(106, 21);
            this.companyList_label.TabIndex = 5;
            this.companyList_label.Text = "company list";
            // 
            // job_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.job_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.job_chart.Legends.Add(legend1);
            this.job_chart.Location = new System.Drawing.Point(13, 69);
            this.job_chart.Name = "job_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.job_chart.Series.Add(series1);
            this.job_chart.Size = new System.Drawing.Size(1012, 627);
            this.job_chart.TabIndex = 3;
            this.job_chart.Text = "job_cahrt";
            this.job_chart.Visible = false;
            // 
            // skill_tree_page
            // 
            this.skill_tree_page.BackColor = System.Drawing.SystemColors.Control;
            this.skill_tree_page.Controls.Add(this.skill_tree_combo);
            this.skill_tree_page.Controls.Add(this.radar_chart);
            this.skill_tree_page.Controls.Add(this.companyList_skill_label);
            this.skill_tree_page.Location = new System.Drawing.Point(4, 30);
            this.skill_tree_page.Name = "skill_tree_page";
            this.skill_tree_page.Padding = new System.Windows.Forms.Padding(3);
            this.skill_tree_page.Size = new System.Drawing.Size(1031, 705);
            this.skill_tree_page.TabIndex = 1;
            this.skill_tree_page.Text = "Skill Trees";
            // 
            // skill_tree_combo
            // 
            this.skill_tree_combo.FormattingEnabled = true;
            this.skill_tree_combo.Location = new System.Drawing.Point(147, 19);
            this.skill_tree_combo.Name = "skill_tree_combo";
            this.skill_tree_combo.Size = new System.Drawing.Size(405, 29);
            this.skill_tree_combo.TabIndex = 2;
            this.skill_tree_combo.Click += new System.EventHandler(this.skill_tree_combo_Click);
            // 
            // radar_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.radar_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.radar_chart.Legends.Add(legend2);
            this.radar_chart.Location = new System.Drawing.Point(13, 69);
            this.radar_chart.Name = "radar_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.radar_chart.Series.Add(series2);
            this.radar_chart.Size = new System.Drawing.Size(1012, 627);
            this.radar_chart.TabIndex = 7;
            this.radar_chart.Text = "radar_chart";
            this.radar_chart.Visible = false;
            // 
            // companyList_skill_label
            // 
            this.companyList_skill_label.AutoSize = true;
            this.companyList_skill_label.Location = new System.Drawing.Point(8, 22);
            this.companyList_skill_label.Name = "companyList_skill_label";
            this.companyList_skill_label.Size = new System.Drawing.Size(106, 21);
            this.companyList_skill_label.TabIndex = 6;
            this.companyList_skill_label.Text = "company list";
            // 
            // linearRegressionPage
            // 
            this.linearRegressionPage.Controls.Add(this.LRText);
            this.linearRegressionPage.Controls.Add(this.predictionYearLabel3);
            this.linearRegressionPage.Controls.Add(this.predictionYearLabel2);
            this.linearRegressionPage.Controls.Add(this.predictionYearLabel1);
            this.linearRegressionPage.Controls.Add(this.Split1);
            this.linearRegressionPage.Controls.Add(this.PredictionsLabel);
            this.linearRegressionPage.Controls.Add(this.SelectPositionLabel);
            this.linearRegressionPage.Controls.Add(this.positionComboBox);
            this.linearRegressionPage.Controls.Add(this.predictionLabel);
            this.linearRegressionPage.Controls.Add(this.PredictionChart);
            this.linearRegressionPage.Location = new System.Drawing.Point(4, 30);
            this.linearRegressionPage.Name = "linearRegressionPage";
            this.linearRegressionPage.Padding = new System.Windows.Forms.Padding(3);
            this.linearRegressionPage.Size = new System.Drawing.Size(1031, 705);
            this.linearRegressionPage.TabIndex = 2;
            this.linearRegressionPage.Text = "Predictions";
            this.linearRegressionPage.UseVisualStyleBackColor = true;
            // 
            // LRText
            // 
            this.LRText.AutoSize = true;
            this.LRText.Location = new System.Drawing.Point(422, 528);
            this.LRText.Name = "LRText";
            this.LRText.Size = new System.Drawing.Size(215, 21);
            this.LRText.TabIndex = 9;
            this.LRText.Text = "Linear Regression Formula:";
            // 
            // predictionYearLabel3
            // 
            this.predictionYearLabel3.AutoSize = true;
            this.predictionYearLabel3.Location = new System.Drawing.Point(17, 651);
            this.predictionYearLabel3.Name = "predictionYearLabel3";
            this.predictionYearLabel3.Size = new System.Drawing.Size(171, 21);
            this.predictionYearLabel3.TabIndex = 8;
            this.predictionYearLabel3.Text = "Prediction for 2018-3";
            // 
            // predictionYearLabel2
            // 
            this.predictionYearLabel2.AutoSize = true;
            this.predictionYearLabel2.Location = new System.Drawing.Point(17, 607);
            this.predictionYearLabel2.Name = "predictionYearLabel2";
            this.predictionYearLabel2.Size = new System.Drawing.Size(171, 21);
            this.predictionYearLabel2.TabIndex = 7;
            this.predictionYearLabel2.Text = "Prediction for 2018-2";
            // 
            // predictionYearLabel1
            // 
            this.predictionYearLabel1.AutoSize = true;
            this.predictionYearLabel1.Location = new System.Drawing.Point(17, 569);
            this.predictionYearLabel1.Name = "predictionYearLabel1";
            this.predictionYearLabel1.Size = new System.Drawing.Size(171, 21);
            this.predictionYearLabel1.TabIndex = 6;
            this.predictionYearLabel1.Text = "Prediction for 2018-1";
            // 
            // Split1
            // 
            this.Split1.BackColor = System.Drawing.Color.Silver;
            this.Split1.Location = new System.Drawing.Point(13, 454);
            this.Split1.Name = "Split1";
            this.Split1.Size = new System.Drawing.Size(691, 1);
            this.Split1.TabIndex = 5;
            this.Split1.Text = "label1";
            // 
            // PredictionsLabel
            // 
            this.PredictionsLabel.AutoSize = true;
            this.PredictionsLabel.Font = new System.Drawing.Font("Calibri", 15F);
            this.PredictionsLabel.Location = new System.Drawing.Point(16, 528);
            this.PredictionsLabel.Name = "PredictionsLabel";
            this.PredictionsLabel.Size = new System.Drawing.Size(102, 24);
            this.PredictionsLabel.TabIndex = 4;
            this.PredictionsLabel.Text = "Predictions";
            // 
            // SelectPositionLabel
            // 
            this.SelectPositionLabel.AutoSize = true;
            this.SelectPositionLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.SelectPositionLabel.Location = new System.Drawing.Point(16, 483);
            this.SelectPositionLabel.Name = "SelectPositionLabel";
            this.SelectPositionLabel.Size = new System.Drawing.Size(143, 27);
            this.SelectPositionLabel.TabIndex = 3;
            this.SelectPositionLabel.Text = "Select Position";
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(194, 483);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(227, 29);
            this.positionComboBox.TabIndex = 2;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.positionComboBox_SelectedIndexChanged_1);
            // 
            // predictionLabel
            // 
            this.predictionLabel.AutoSize = true;
            this.predictionLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.predictionLabel.Location = new System.Drawing.Point(6, 15);
            this.predictionLabel.Name = "predictionLabel";
            this.predictionLabel.Size = new System.Drawing.Size(321, 27);
            this.predictionLabel.TabIndex = 1;
            this.predictionLabel.Text = "Future Predictions(2018.1-2018.3)";
            // 
            // PredictionChart
            // 
            chartArea3.Name = "ChartArea1";
            this.PredictionChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PredictionChart.Legends.Add(legend3);
            this.PredictionChart.Location = new System.Drawing.Point(3, 45);
            this.PredictionChart.Name = "PredictionChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.PredictionChart.Series.Add(series3);
            this.PredictionChart.Size = new System.Drawing.Size(1022, 406);
            this.PredictionChart.TabIndex = 0;
            this.PredictionChart.Text = "PredictionChart";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(-1, 781);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(140, 21);
            this.state_label.TabIndex = 3;
            this.state_label.Text = "infomation state:";
            // 
            // infomation_state
            // 
            this.infomation_state.AutoSize = true;
            this.infomation_state.Location = new System.Drawing.Point(177, 781);
            this.infomation_state.Name = "infomation_state";
            this.infomation_state.Size = new System.Drawing.Size(38, 21);
            this.infomation_state.TabIndex = 4;
            this.infomation_state.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 817);
            this.Controls.Add(this.infomation_state);
            this.Controls.Add(this.state_label);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menubar);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MainMenuStrip = this.menubar;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpiderStorm plus";
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.table.ResumeLayout(false);
            this.job_chart_page.ResumeLayout(false);
            this.job_chart_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.job_chart)).EndInit();
            this.skill_tree_page.ResumeLayout(false);
            this.skill_tree_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radar_chart)).EndInit();
            this.linearRegressionPage.ResumeLayout(false);
            this.linearRegressionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem menuitem_start;
        private System.Windows.Forms.ToolStripMenuItem menu_func_catchInfo;
        private System.Windows.Forms.TabControl table;
        private System.Windows.Forms.TabPage job_chart_page;
        private System.Windows.Forms.DataVisualization.Charting.Chart job_chart;
        private System.Windows.Forms.TabPage skill_tree_page;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Label infomation_state;
        private System.Windows.Forms.Label companyList_label;
        private System.Windows.Forms.Label companyList_skill_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart radar_chart;
        private System.Windows.Forms.TabPage linearRegressionPage;
        private System.Windows.Forms.Label SelectPositionLabel;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label predictionLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart PredictionChart;
        private System.Windows.Forms.Label PredictionsLabel;
        private System.Windows.Forms.Label LRText;
        private System.Windows.Forms.Label predictionYearLabel3;
        private System.Windows.Forms.Label predictionYearLabel2;
        private System.Windows.Forms.Label predictionYearLabel1;
        private System.Windows.Forms.Label Split1;
        private System.Windows.Forms.ComboBox job_chart_combo;
        private System.Windows.Forms.ComboBox skill_tree_combo;
    }
}

