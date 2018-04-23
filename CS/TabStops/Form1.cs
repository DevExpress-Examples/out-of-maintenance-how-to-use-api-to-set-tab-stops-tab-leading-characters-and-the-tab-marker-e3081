using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings
using DevExpress.XtraRichEdit.Commands;

namespace TabStops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richEditControl1.CreateNewDocument();
            #region #tabs
            richEditControl1.Document.Unit = DevExpress.XtraRichEdit.DocumentUnit.Inch;
            TabInfoCollection tabs = richEditControl1.Document.Paragraphs[0].BeginUpdateTabs(true);
            TabInfo tab1 = new TabInfo();
            // Sets tab stop at 2.5 inch
            tab1.Position = 2.5f;
            tab1.Alignment = TabAlignmentType.Left;
            tab1.Leader = TabLeaderType.MiddleDots;
            tabs.Add(tab1);
            TabInfo tab2 = new TabInfo();
            tab2.Position = 5.5f;
            tab2.Alignment = TabAlignmentType.Decimal;
            tab2.Leader = TabLeaderType.EqualSign;
            tabs.Add(tab2);
            richEditControl1.Document.Paragraphs[0].EndUpdateTabs(tabs);
            #endregion #tabs
            if (checkEdit1.Checked) {
                string s = textEdit1.Text.Replace("\\t","\t");
                richEditControl1.Options.Behavior.TabMarker = s ;
            }
            
            InsertTabCommand cmd = new InsertTabCommand(richEditControl1);
            cmd.Execute();
            richEditControl1.Document.InsertSingleLineText(richEditControl1.Document.Selection.Start, "Amount");
            cmd.Execute();
            richEditControl1.Document.InsertSingleLineText(richEditControl1.Document.Selection.Start, "222.22");

        }
    }
}