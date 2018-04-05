namespace AnovaTest
{
    partial class anovaTest
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
            this.numOfAlternatives = new System.Windows.Forms.TextBox();
            this.numOfMeasurements = new System.Windows.Forms.TextBox();
            this.generateTable = new System.Windows.Forms.Button();
            this.entriesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateResults = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ssaLabel = new System.Windows.Forms.Label();
            this.sseLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sstLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fCalculatedValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabulated99Label = new System.Windows.Forms.Label();
            this.tabulated95Label = new System.Windows.Forms.Label();
            this.tabulated90Label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sseDivSstLabel = new System.Windows.Forms.Label();
            this.ssaDivSstLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.contrastDataGridView = new System.Windows.Forms.DataGridView();
            this.contrastTrustIntervalDataGridView = new System.Windows.Forms.DataGridView();
            this.probability99RadioButton = new System.Windows.Forms.RadioButton();
            this.probability95RadioButton = new System.Windows.Forms.RadioButton();
            this.probability90RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrustIntervalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numOfAlternatives
            // 
            this.numOfAlternatives.Location = new System.Drawing.Point(122, 16);
            this.numOfAlternatives.Name = "numOfAlternatives";
            this.numOfAlternatives.Size = new System.Drawing.Size(100, 22);
            this.numOfAlternatives.TabIndex = 0;
            this.numOfAlternatives.TextChanged += new System.EventHandler(this.numOfAlternatives_TextChanged);
            // 
            // numOfMeasurements
            // 
            this.numOfMeasurements.Location = new System.Drawing.Point(326, 16);
            this.numOfMeasurements.Name = "numOfMeasurements";
            this.numOfMeasurements.Size = new System.Drawing.Size(100, 22);
            this.numOfMeasurements.TabIndex = 1;
            this.numOfMeasurements.TextChanged += new System.EventHandler(this.numOfMeasurements_TextChanged);
            // 
            // generateTable
            // 
            this.generateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateTable.Location = new System.Drawing.Point(630, 15);
            this.generateTable.Name = "generateTable";
            this.generateTable.Size = new System.Drawing.Size(140, 23);
            this.generateTable.TabIndex = 2;
            this.generateTable.Text = "Generiši tabelu";
            this.generateTable.UseVisualStyleBackColor = true;
            this.generateTable.Click += new System.EventHandler(this.generateTable_Click);
            // 
            // entriesDataGridView
            // 
            this.entriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.entriesDataGridView.Name = "entriesDataGridView";
            this.entriesDataGridView.RowTemplate.Height = 24;
            this.entriesDataGridView.Size = new System.Drawing.Size(370, 409);
            this.entriesDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj alternativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj mjerenja";
            // 
            // generateResults
            // 
            this.generateResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateResults.Location = new System.Drawing.Point(489, 16);
            this.generateResults.Name = "generateResults";
            this.generateResults.Size = new System.Drawing.Size(135, 23);
            this.generateResults.TabIndex = 6;
            this.generateResults.Text = "Generiši rezultate";
            this.generateResults.UseVisualStyleBackColor = true;
            this.generateResults.Click += new System.EventHandler(this.generateResults_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SSE:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "SSA:";
            // 
            // ssaLabel
            // 
            this.ssaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ssaLabel.AutoSize = true;
            this.ssaLabel.Location = new System.Drawing.Point(133, 457);
            this.ssaLabel.Name = "ssaLabel";
            this.ssaLabel.Size = new System.Drawing.Size(0, 17);
            this.ssaLabel.TabIndex = 9;
            // 
            // sseLabel
            // 
            this.sseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sseLabel.AutoSize = true;
            this.sseLabel.Location = new System.Drawing.Point(133, 474);
            this.sseLabel.Name = "sseLabel";
            this.sseLabel.Size = new System.Drawing.Size(0, 17);
            this.sseLabel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "SST:";
            // 
            // sstLabel
            // 
            this.sstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sstLabel.AutoSize = true;
            this.sstLabel.Location = new System.Drawing.Point(133, 491);
            this.sstLabel.Name = "sstLabel";
            this.sstLabel.Size = new System.Drawing.Size(0, 17);
            this.sstLabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "F-izračunato: ";
            // 
            // fCalculatedValue
            // 
            this.fCalculatedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fCalculatedValue.AutoSize = true;
            this.fCalculatedValue.Location = new System.Drawing.Point(471, 526);
            this.fCalculatedValue.Name = "fCalculatedValue";
            this.fCalculatedValue.Size = new System.Drawing.Size(0, 17);
            this.fCalculatedValue.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "F-tabelarno 99%: ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "F-tabelarno 95%: ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "F-tabelarno 90%: ";
            // 
            // tabulated99Label
            // 
            this.tabulated99Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabulated99Label.AutoSize = true;
            this.tabulated99Label.Location = new System.Drawing.Point(471, 508);
            this.tabulated99Label.Name = "tabulated99Label";
            this.tabulated99Label.Size = new System.Drawing.Size(0, 17);
            this.tabulated99Label.TabIndex = 18;
            // 
            // tabulated95Label
            // 
            this.tabulated95Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabulated95Label.AutoSize = true;
            this.tabulated95Label.Location = new System.Drawing.Point(471, 492);
            this.tabulated95Label.Name = "tabulated95Label";
            this.tabulated95Label.Size = new System.Drawing.Size(0, 17);
            this.tabulated95Label.TabIndex = 19;
            // 
            // tabulated90Label
            // 
            this.tabulated90Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabulated90Label.AutoSize = true;
            this.tabulated90Label.Location = new System.Drawing.Point(471, 474);
            this.tabulated90Label.Name = "tabulated90Label";
            this.tabulated90Label.Size = new System.Drawing.Size(0, 17);
            this.tabulated90Label.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(16, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.entriesDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(754, 409);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "SSE / SST(%):";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "SSA / SST(%): ";
            // 
            // sseDivSstLabel
            // 
            this.sseDivSstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sseDivSstLabel.AutoSize = true;
            this.sseDivSstLabel.Location = new System.Drawing.Point(133, 525);
            this.sseDivSstLabel.Name = "sseDivSstLabel";
            this.sseDivSstLabel.Size = new System.Drawing.Size(0, 17);
            this.sseDivSstLabel.TabIndex = 25;
            // 
            // ssaDivSstLabel
            // 
            this.ssaDivSstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ssaDivSstLabel.AutoSize = true;
            this.ssaDivSstLabel.Location = new System.Drawing.Point(133, 508);
            this.ssaDivSstLabel.Name = "ssaDivSstLabel";
            this.ssaDivSstLabel.Size = new System.Drawing.Size(0, 17);
            this.ssaDivSstLabel.TabIndex = 26;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.contrastDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.contrastTrustIntervalDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(380, 409);
            this.splitContainer2.SplitterDistance = 175;
            this.splitContainer2.TabIndex = 0;
            // 
            // contrastDataGridView
            // 
            this.contrastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contrastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastDataGridView.Location = new System.Drawing.Point(0, 0);
            this.contrastDataGridView.Name = "contrastDataGridView";
            this.contrastDataGridView.RowTemplate.Height = 24;
            this.contrastDataGridView.Size = new System.Drawing.Size(380, 175);
            this.contrastDataGridView.TabIndex = 0;
            // 
            // contrastTrustIntervalDataGridView
            // 
            this.contrastTrustIntervalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contrastTrustIntervalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contrastTrustIntervalDataGridView.Location = new System.Drawing.Point(0, 0);
            this.contrastTrustIntervalDataGridView.Name = "contrastTrustIntervalDataGridView";
            this.contrastTrustIntervalDataGridView.RowTemplate.Height = 24;
            this.contrastTrustIntervalDataGridView.Size = new System.Drawing.Size(380, 230);
            this.contrastTrustIntervalDataGridView.TabIndex = 0;
            // 
            // probability99RadioButton
            // 
            this.probability99RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.probability99RadioButton.AutoSize = true;
            this.probability99RadioButton.Location = new System.Drawing.Point(713, 460);
            this.probability99RadioButton.Name = "probability99RadioButton";
            this.probability99RadioButton.Size = new System.Drawing.Size(57, 21);
            this.probability99RadioButton.TabIndex = 27;
            this.probability99RadioButton.TabStop = true;
            this.probability99RadioButton.Text = "99%";
            this.probability99RadioButton.UseVisualStyleBackColor = true;
            // 
            // probability95RadioButton
            // 
            this.probability95RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.probability95RadioButton.AutoSize = true;
            this.probability95RadioButton.Location = new System.Drawing.Point(650, 460);
            this.probability95RadioButton.Name = "probability95RadioButton";
            this.probability95RadioButton.Size = new System.Drawing.Size(57, 21);
            this.probability95RadioButton.TabIndex = 28;
            this.probability95RadioButton.TabStop = true;
            this.probability95RadioButton.Text = "95%";
            this.probability95RadioButton.UseVisualStyleBackColor = true;
            // 
            // probability90RadioButton
            // 
            this.probability90RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.probability90RadioButton.AutoSize = true;
            this.probability90RadioButton.Location = new System.Drawing.Point(587, 460);
            this.probability90RadioButton.Name = "probability90RadioButton";
            this.probability90RadioButton.Size = new System.Drawing.Size(57, 21);
            this.probability90RadioButton.TabIndex = 29;
            this.probability90RadioButton.TabStop = true;
            this.probability90RadioButton.Text = "90%";
            this.probability90RadioButton.UseVisualStyleBackColor = true;
            // 
            // anovaTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.probability90RadioButton);
            this.Controls.Add(this.probability95RadioButton);
            this.Controls.Add(this.probability99RadioButton);
            this.Controls.Add(this.ssaDivSstLabel);
            this.Controls.Add(this.sseDivSstLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabulated90Label);
            this.Controls.Add(this.tabulated95Label);
            this.Controls.Add(this.tabulated99Label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fCalculatedValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sstLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sseLabel);
            this.Controls.Add(this.ssaLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateTable);
            this.Controls.Add(this.numOfMeasurements);
            this.Controls.Add(this.numOfAlternatives);
            this.Name = "anovaTest";
            this.Text = "Anova Test";
            this.Load += new System.EventHandler(this.anovaTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entriesDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contrastDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrustIntervalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numOfAlternatives;
        private System.Windows.Forms.TextBox numOfMeasurements;
        private System.Windows.Forms.Button generateTable;
        private System.Windows.Forms.DataGridView entriesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ssaLabel;
        private System.Windows.Forms.Label sseLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sstLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fCalculatedValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tabulated99Label;
        private System.Windows.Forms.Label tabulated95Label;
        private System.Windows.Forms.Label tabulated90Label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sseDivSstLabel;
        private System.Windows.Forms.Label ssaDivSstLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView contrastDataGridView;
        private System.Windows.Forms.DataGridView contrastTrustIntervalDataGridView;
        private System.Windows.Forms.RadioButton probability99RadioButton;
        private System.Windows.Forms.RadioButton probability95RadioButton;
        private System.Windows.Forms.RadioButton probability90RadioButton;
    }
}

