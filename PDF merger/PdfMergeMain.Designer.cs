/*
 * 
 *  The MIT License (MIT)
 *  Copyright © 2020 <copyright holders>
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files 
 *  (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, 
 *  publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
 *  subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 *  OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 *  LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR 
 *  IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *  
 *  
 */

namespace PdfMerger
{
    partial class PdfMerge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfMerge));
            this.firstFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.secondFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.filelist = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTool = new System.Windows.Forms.ToolStripButton();
            this.removeTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mergeTool = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.waitPanelText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstFileOpen
            // 
            this.firstFileOpen.DefaultExt = "*.pdf";
            this.firstFileOpen.FileName = "firstFileOpen";
            this.firstFileOpen.InitialDirectory = "@\"C:\\\";  ";
            // 
            // secondFileOpen
            // 
            this.secondFileOpen.DefaultExt = "*.pdf";
            this.secondFileOpen.FileName = "secondFileOpen";
            this.secondFileOpen.InitialDirectory = "@\"C:\\\";  ";
            // 
            // filelist
            // 
            this.filelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filelist.FormattingEnabled = true;
            this.filelist.Location = new System.Drawing.Point(0, 28);
            this.filelist.Name = "filelist";
            this.filelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.filelist.Size = new System.Drawing.Size(664, 277);
            this.filelist.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTool,
            this.removeTool,
            this.toolStripButton1,
            this.mergeTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addTool
            // 
            this.addTool.Image = ((System.Drawing.Image)(resources.GetObject("addTool.Image")));
            this.addTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTool.Name = "addTool";
            this.addTool.Size = new System.Drawing.Size(75, 22);
            this.addTool.Text = "Add pdfs";
            this.addTool.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // removeTool
            // 
            this.removeTool.Image = ((System.Drawing.Image)(resources.GetObject("removeTool.Image")));
            this.removeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeTool.Name = "removeTool";
            this.removeTool.Size = new System.Drawing.Size(117, 22);
            this.removeTool.Text = "Remove from list";
            this.removeTool.Click += new System.EventHandler(this.removeTool_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "Clear list";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // mergeTool
            // 
            this.mergeTool.Image = ((System.Drawing.Image)(resources.GetObject("mergeTool.Image")));
            this.mergeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mergeTool.Name = "mergeTool";
            this.mergeTool.Size = new System.Drawing.Size(87, 22);
            this.mergeTool.Text = "Merge pdfs";
            this.mergeTool.Click += new System.EventHandler(this.mergeTool_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(16, 17);
            this.statusText.Text = "...";
            // 
            // statusPanel
            // 
            this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusPanel.Controls.Add(this.progressBar1);
            this.statusPanel.Controls.Add(this.waitPanelText);
            this.statusPanel.Location = new System.Drawing.Point(141, 86);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(357, 146);
            this.statusPanel.TabIndex = 6;
            this.statusPanel.Visible = false;
            // 
            // waitPanelText
            // 
            this.waitPanelText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waitPanelText.AutoSize = true;
            this.waitPanelText.Location = new System.Drawing.Point(3, 45);
            this.waitPanelText.Name = "waitPanelText";
            this.waitPanelText.Size = new System.Drawing.Size(41, 13);
            this.waitPanelText.TabIndex = 0;
            this.waitPanelText.Text = "Wait ...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // PdfMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 327);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.filelist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PdfMerge";
            this.Text = "PDF Merger";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog firstFileOpen;
        private System.Windows.Forms.OpenFileDialog secondFileOpen;
        private System.Windows.Forms.ListBox filelist;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addTool;
        private System.Windows.Forms.ToolStripButton removeTool;
        private System.Windows.Forms.ToolStripButton mergeTool;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label waitPanelText;
    }
}

