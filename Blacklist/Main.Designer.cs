namespace BlackList
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.fsw = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtGridList = new System.Windows.Forms.DataGridView();
            this.lvFileText = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(8, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(231, 20);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Insira o texto e pressione enter:";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlacklist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBlacklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlacklist.Location = new System.Drawing.Point(649, 134);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(165, 32);
            this.btnBlacklist.TabIndex = 2;
            this.btnBlacklist.Text = "ADD +";
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbInput.DetectUrls = false;
            this.rtbInput.Location = new System.Drawing.Point(12, 36);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(802, 92);
            this.rtbInput.TabIndex = 4;
            this.rtbInput.Text = "";
            this.rtbInput.WordWrap = false;
            this.rtbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbInput_KeyDown);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Location = new System.Drawing.Point(12, 134);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(631, 155);
            this.rtbOutput.TabIndex = 5;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.Filter = "blacklist.txt";
            this.fsw.SynchronizingObject = this;
            this.fsw.Changed += new System.IO.FileSystemEventHandler(this.fsw_Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dtGridList
            // 
            this.dtGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridList.Location = new System.Drawing.Point(12, 295);
            this.dtGridList.Name = "dtGridList";
            this.dtGridList.Size = new System.Drawing.Size(802, 201);
            this.dtGridList.TabIndex = 8;
            // 
            // lvFileText
            // 
            this.lvFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFileText.FullRowSelect = true;
            this.lvFileText.HideSelection = false;
            this.lvFileText.LabelWrap = false;
            this.lvFileText.Location = new System.Drawing.Point(804, 486);
            this.lvFileText.MultiSelect = false;
            this.lvFileText.Name = "lvFileText";
            this.lvFileText.ShowGroups = false;
            this.lvFileText.Size = new System.Drawing.Size(10, 10);
            this.lvFileText.TabIndex = 6;
            this.lvFileText.TileSize = new System.Drawing.Size(160, 20);
            this.lvFileText.UseCompatibleStateImageBehavior = false;
            this.lvFileText.View = System.Windows.Forms.View.Tile;
            this.lvFileText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFileText_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 508);
            this.Controls.Add(this.dtGridList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvFileText);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnBlacklist);
            this.Controls.Add(this.lbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackList League of Legends";
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnBlacklist;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtGridList;
        private System.Windows.Forms.ListView lvFileText;
    }
}

