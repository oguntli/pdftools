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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp;
using PdfSharp.Pdf.IO;
using System.Windows.Forms;

namespace PdfMerger
{
    public partial class PdfMerge : Form
    {
        public PdfMerge()
        {
            InitializeComponent();

        }

        private void pdf1Button_Click(object sender, EventArgs e)
        {
           
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPdfFile = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select PDF",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = true,
                DefaultExt = "pdf",
                Filter = "PDF (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,
                ShowReadOnly = true
            };

            if (openPdfFile.ShowDialog() == DialogResult.OK)
            {
                filelist.Items.AddRange(openPdfFile.FileNames);
                statusText.Text = openPdfFile.FileNames.Length.ToString() + " documents added";
            }
            else
            {
                statusText.Text = "0 documents added";
            }
        }

        private void removeTool_Click(object sender, EventArgs e)
        {
            for(int i = filelist.SelectedIndices.Count - 1; i >= 0; i--)
            {
                filelist.Items.RemoveAt(filelist.SelectedIndices[i]);
            }
            statusText.Text = filelist.SelectedIndices.Count.ToString() + " documents removed";
        }

        private async void mergeTool_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePdf = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Save merged PDF",
                CheckPathExists = true,
                DefaultExt = "pdf",
                Filter = "PDF (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            waitPanelText.Text = "Select destination, waiting on user...";
            if (savePdf.ShowDialog() == DialogResult.OK)
            {
                statusPanel.Visible = true;
                waitPanelText.Text = "Processing documents...";
                await (Task.Run(() =>
                {
                   
                    int numberOfPages = 0;
                    using (PdfDocument targetDoc = new PdfDocument())
                    {
                        foreach (string pdf in filelist.Items)
                        {
                            using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                            {
                                for (int i = 0; i < pdfDoc.PageCount; i++)
                                {
                                    targetDoc.AddPage(pdfDoc.Pages[i]);
                                    numberOfPages += 1;
                                    statusText.Text = numberOfPages.ToString() + " pages processd.";
                                }
                            }
                        }
                        try
                        {
                            targetDoc.Save(savePdf.FileName);
                        }
                        catch (System.InvalidOperationException ex)
                        {
                            statusText.Text = "Nothing to do";
                        }
                    }
                }));
            }
            filelist.Items.Clear();
            statusPanel.Visible = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            filelist.Items.Clear();
            statusText.Text = " all documents removed.";
        }
    }
}
