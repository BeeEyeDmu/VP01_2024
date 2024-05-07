namespace _025_SensorMonitoring
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.시뮬레이션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.끝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lblConnectionTime = new System.Windows.Forms.Label();
      this.txtCount = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnPortValue = new System.Windows.Forms.Button();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.btnConnect = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.btnViewAll = new System.Windows.Forms.Button();
      this.btnZoom = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.시뮬레이션ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 시뮬레이션ToolStripMenuItem
      // 
      this.시뮬레이션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.끝ToolStripMenuItem});
      this.시뮬레이션ToolStripMenuItem.Name = "시뮬레이션ToolStripMenuItem";
      this.시뮬레이션ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
      this.시뮬레이션ToolStripMenuItem.Text = "시뮬레이션";
      // 
      // 시작ToolStripMenuItem
      // 
      this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
      this.시작ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.시작ToolStripMenuItem.Text = "시작";
      this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
      // 
      // 끝ToolStripMenuItem
      // 
      this.끝ToolStripMenuItem.Name = "끝ToolStripMenuItem";
      this.끝ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.끝ToolStripMenuItem.Text = "끝";
      this.끝ToolStripMenuItem.Click += new System.EventHandler(this.끝ToolStripMenuItem_Click);
      // 
      // lblConnectionTime
      // 
      this.lblConnectionTime.AutoSize = true;
      this.lblConnectionTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblConnectionTime.Location = new System.Drawing.Point(12, 41);
      this.lblConnectionTime.Name = "lblConnectionTime";
      this.lblConnectionTime.Size = new System.Drawing.Size(110, 15);
      this.lblConnectionTime.TabIndex = 1;
      this.lblConnectionTime.Text = "Connection Time : ";
      // 
      // txtCount
      // 
      this.txtCount.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtCount.Location = new System.Drawing.Point(427, 41);
      this.txtCount.Name = "txtCount";
      this.txtCount.Size = new System.Drawing.Size(143, 23);
      this.txtCount.TabIndex = 2;
      this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnPortValue);
      this.groupBox1.Controls.Add(this.btnDisconnect);
      this.groupBox1.Controls.Add(this.btnConnect);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(588, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 286);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Port";
      // 
      // btnPortValue
      // 
      this.btnPortValue.Location = new System.Drawing.Point(16, 129);
      this.btnPortValue.Name = "btnPortValue";
      this.btnPortValue.Size = new System.Drawing.Size(162, 141);
      this.btnPortValue.TabIndex = 3;
      this.btnPortValue.UseVisualStyleBackColor = true;
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(16, 94);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(162, 29);
      this.btnDisconnect.TabIndex = 2;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(16, 59);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(162, 29);
      this.btnConnect.TabIndex = 1;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(16, 32);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(162, 23);
      this.comboBox1.TabIndex = 0;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.progressBar1);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(14, 73);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(556, 76);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "PhotoCell";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(518, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "1023";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(14, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "0";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(6, 27);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(544, 23);
      this.progressBar1.TabIndex = 0;
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(14, 155);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(556, 169);
      this.listBox1.TabIndex = 5;
      // 
      // chart1
      // 
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.chart1.Legends.Add(legend3);
      this.chart1.Location = new System.Drawing.Point(14, 333);
      this.chart1.Name = "chart1";
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      this.chart1.Series.Add(series3);
      this.chart1.Size = new System.Drawing.Size(775, 280);
      this.chart1.TabIndex = 6;
      this.chart1.Text = "chart1";
      // 
      // chart2
      // 
      chartArea4.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea4);
      legend4.Name = "Legend1";
      this.chart2.Legends.Add(legend4);
      this.chart2.Location = new System.Drawing.Point(14, 619);
      this.chart2.Name = "chart2";
      series4.ChartArea = "ChartArea1";
      series4.Legend = "Legend1";
      series4.Name = "Series1";
      this.chart2.Series.Add(series4);
      this.chart2.Size = new System.Drawing.Size(775, 280);
      this.chart2.TabIndex = 7;
      this.chart2.Text = "chart2";
      // 
      // btnViewAll
      // 
      this.btnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnViewAll.Location = new System.Drawing.Point(271, 926);
      this.btnViewAll.Name = "btnViewAll";
      this.btnViewAll.Size = new System.Drawing.Size(75, 23);
      this.btnViewAll.TabIndex = 8;
      this.btnViewAll.Text = "View All";
      this.btnViewAll.UseVisualStyleBackColor = true;
      // 
      // btnZoom
      // 
      this.btnZoom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnZoom.Location = new System.Drawing.Point(403, 926);
      this.btnZoom.Name = "btnZoom";
      this.btnZoom.Size = new System.Drawing.Size(75, 23);
      this.btnZoom.TabIndex = 9;
      this.btnZoom.Text = "Zoom";
      this.btnZoom.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 961);
      this.Controls.Add(this.btnZoom);
      this.Controls.Add(this.btnViewAll);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtCount);
      this.Controls.Add(this.lblConnectionTime);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 시뮬레이션ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝ToolStripMenuItem;
    private System.Windows.Forms.Label lblConnectionTime;
    private System.Windows.Forms.TextBox txtCount;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button btnPortValue;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.Button btnViewAll;
    private System.Windows.Forms.Button btnZoom;
  }
}

