namespace MBINCompilerGUI
{
    partial class MBINCompilerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBINCompilerGUI));
            this.fileDrop = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileDrop
            // 
            this.fileDrop.AllowDrop = true;
            this.fileDrop.AutoSize = true;
            this.fileDrop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileDrop.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileDrop.ForeColor = System.Drawing.Color.DarkGray;
            this.fileDrop.Location = new System.Drawing.Point(12, 9);
            this.fileDrop.Name = "fileDrop";
            this.fileDrop.Padding = new System.Windows.Forms.Padding(40);
            this.fileDrop.Size = new System.Drawing.Size(641, 192);
            this.fileDrop.TabIndex = 0;
            this.fileDrop.Text = "Drag files here";
            this.fileDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileDrop_DragDrop);
            this.fileDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileDrop_DragEnter);
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.outputBox.Location = new System.Drawing.Point(12, 248);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(641, 358);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Stream";
            // 
            // MBINCompilerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(667, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.fileDrop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MBINCompilerGUI";
            this.Text = "MBINCompiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileDrop;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label1;
    }
}

