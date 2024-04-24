namespace proiect2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            reprezToolStripMenuItem = new ToolStripMenuItem();
            printareToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbDenumire = new TextBox();
            tbPaturi = new TextBox();
            tbBai = new TextBox();
            button1 = new Button();
            button2 = new Button();
            errorProviderDenumire = new ErrorProvider(components);
            errorProviderPaturi = new ErrorProvider(components);
            errorProviderBai = new ErrorProvider(components);
            button3 = new Button();
            pictureBox1 = new PictureBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderDenumire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPaturi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { reprezToolStripMenuItem, printareToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(218, 52);
            // 
            // reprezToolStripMenuItem
            // 
            reprezToolStripMenuItem.Name = "reprezToolStripMenuItem";
            reprezToolStripMenuItem.Size = new Size(217, 24);
            reprezToolStripMenuItem.Text = "Reprezentare Grafica";
            reprezToolStripMenuItem.Click += reprezToolStripMenuItem_Click;
            // 
            // printareToolStripMenuItem
            // 
            printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            printareToolStripMenuItem.Size = new Size(217, 24);
            printareToolStripMenuItem.Text = "Printare";
            printareToolStripMenuItem.Click += printareToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(496, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Denumire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Nr paturi";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 134);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Nr bai";
            // 
            // tbDenumire
            // 
            tbDenumire.Location = new Point(123, 39);
            tbDenumire.Name = "tbDenumire";
            tbDenumire.Size = new Size(125, 27);
            tbDenumire.TabIndex = 3;
            // 
            // tbPaturi
            // 
            tbPaturi.Location = new Point(123, 84);
            tbPaturi.Name = "tbPaturi";
            tbPaturi.Size = new Size(125, 27);
            tbPaturi.TabIndex = 4;
            // 
            // tbBai
            // 
            tbBai.Location = new Point(123, 137);
            tbBai.Name = "tbBai";
            tbBai.Size = new Size(125, 27);
            tbBai.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 196);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 196);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Show List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProviderDenumire
            // 
            errorProviderDenumire.ContainerControl = this;
            // 
            // errorProviderPaturi
            // 
            errorProviderPaturi.ContainerControl = this;
            // 
            // errorProviderBai
            // 
            errorProviderBai.ContainerControl = this;
            // 
            // button3
            // 
            button3.Location = new Point(652, 253);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Imag";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(620, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 90);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbBai);
            Controls.Add(tbPaturi);
            Controls.Add(tbDenumire);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProviderDenumire).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPaturi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderBai).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem reprezToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbDenumire;
        private TextBox tbPaturi;
        private TextBox tbBai;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProviderDenumire;
        private ErrorProvider errorProviderPaturi;
        private ErrorProvider errorProviderBai;
        private ToolStripMenuItem printareToolStripMenuItem;
        private Button button3;
        private PictureBox pictureBox1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}