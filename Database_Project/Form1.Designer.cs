namespace Database_Project
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.surname1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.humGPA = new System.Windows.Forms.Label();
            this.techGPA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 200.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, -42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 386);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(81)))), ((int)(((byte)(134)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(376, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click me to continue!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id1);
            this.panel1.Controls.Add(this.surname1);
            this.panel1.Controls.Add(this.name1);
            this.panel1.Controls.Add(this.humGPA);
            this.panel1.Controls.Add(this.techGPA);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 515);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(673, 95);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 22);
            this.id.TabIndex = 13;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(716, 55);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(0, 22);
            this.surname.TabIndex = 12;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(698, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 22);
            this.name.TabIndex = 11;
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.id1.Location = new System.Drawing.Point(622, 90);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(36, 28);
            this.id1.TabIndex = 10;
            this.id1.Text = "ID:";
            // 
            // surname1
            // 
            this.surname1.AutoSize = true;
            this.surname1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.surname1.Location = new System.Drawing.Point(622, 50);
            this.surname1.Name = "surname1";
            this.surname1.Size = new System.Drawing.Size(88, 28);
            this.surname1.TabIndex = 9;
            this.surname1.Text = "Surname:";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.name1.Location = new System.Drawing.Point(622, 9);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(63, 28);
            this.name1.TabIndex = 8;
            this.name1.Text = "Name:";
            // 
            // humGPA
            // 
            this.humGPA.AutoSize = true;
            this.humGPA.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humGPA.Location = new System.Drawing.Point(887, 456);
            this.humGPA.Name = "humGPA";
            this.humGPA.Size = new System.Drawing.Size(0, 24);
            this.humGPA.TabIndex = 7;
            // 
            // techGPA
            // 
            this.techGPA.AutoSize = true;
            this.techGPA.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techGPA.Location = new System.Drawing.Point(844, 409);
            this.techGPA.Name = "techGPA";
            this.techGPA.Size = new System.Drawing.Size(0, 24);
            this.techGPA.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(622, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Humanitarian Subjects GPA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(622, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Technical Subjects GPA:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            chartArea6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(578, 132);
            this.chart1.Name = "chart1";
            series6.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series6.IsValueShownAsLabel = true;
            series6.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            series6.Name = "Student";
            series6.ShadowColor = System.Drawing.Color.LightGray;
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(385, 254);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            title3.Name = "Title1";
            title3.Text = "Student\'s Statistic";
            this.chart1.Titles.Add(title3);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.button2.Location = new System.Drawing.Point(110, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Statistic";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(102, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Students: ";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            legend3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(12, 172);
            this.chart2.Name = "chart2";
            series5.BackImageTransparentColor = System.Drawing.Color.White;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Color = System.Drawing.Color.White;
            series5.LabelForeColor = System.Drawing.Color.Transparent;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(541, 288);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(73)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(975, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(81)))), ((int)(((byte)(134)))));
            this.Name = "Form1";
            this.Text = "Database Project ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label humGPA;
        private System.Windows.Forms.Label techGPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label surname1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

