namespace TabStops
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
            if (disposing && (components != null)) {
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 52);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(790, 379);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(790, 52);
            this.panelControl1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Tab stops";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(130, 14);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Set Tab Leader character to the following:";
            this.checkEdit1.Size = new System.Drawing.Size(228, 19);
            this.checkEdit1.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "\\tGBP ";
            this.textEdit1.Location = new System.Drawing.Point(364, 14);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(35, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 431);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

