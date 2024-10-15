
namespace _03_FormsDialogs
{
    partial class FormMain
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
            this.buttonMessageBoxSimple = new System.Windows.Forms.Button();
            this.buttonMessageBox = new System.Windows.Forms.Button();
            this.buttonColorDialog = new System.Windows.Forms.Button();
            this.buttonFontDialog = new System.Windows.Forms.Button();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.buttonSaveFileDialog = new System.Windows.Forms.Button();
            this.buttonFolderBrowserDialog = new System.Windows.Forms.Button();
            this.buttonFormExample = new System.Windows.Forms.Button();
            this.buttonFormExampleDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMessageBoxSimple
            // 
            this.buttonMessageBoxSimple.Location = new System.Drawing.Point(24, 31);
            this.buttonMessageBoxSimple.Name = "buttonMessageBoxSimple";
            this.buttonMessageBoxSimple.Size = new System.Drawing.Size(156, 30);
            this.buttonMessageBoxSimple.TabIndex = 0;
            this.buttonMessageBoxSimple.Text = "MessageBox Simple";
            this.buttonMessageBoxSimple.UseVisualStyleBackColor = true;
            this.buttonMessageBoxSimple.Click += new System.EventHandler(this.buttonMessageBoxSimple_Click);
            // 
            // buttonMessageBox
            // 
            this.buttonMessageBox.Location = new System.Drawing.Point(24, 67);
            this.buttonMessageBox.Name = "buttonMessageBox";
            this.buttonMessageBox.Size = new System.Drawing.Size(156, 30);
            this.buttonMessageBox.TabIndex = 1;
            this.buttonMessageBox.Text = "MessageBox";
            this.buttonMessageBox.UseVisualStyleBackColor = true;
            this.buttonMessageBox.Click += new System.EventHandler(this.buttonMessageBox_Click);
            // 
            // buttonColorDialog
            // 
            this.buttonColorDialog.Location = new System.Drawing.Point(186, 31);
            this.buttonColorDialog.Name = "buttonColorDialog";
            this.buttonColorDialog.Size = new System.Drawing.Size(156, 30);
            this.buttonColorDialog.TabIndex = 2;
            this.buttonColorDialog.Text = "ColorDialog";
            this.buttonColorDialog.UseVisualStyleBackColor = true;
            this.buttonColorDialog.Click += new System.EventHandler(this.buttonColorDialog_Click);
            // 
            // buttonFontDialog
            // 
            this.buttonFontDialog.Location = new System.Drawing.Point(186, 67);
            this.buttonFontDialog.Name = "buttonFontDialog";
            this.buttonFontDialog.Size = new System.Drawing.Size(156, 30);
            this.buttonFontDialog.TabIndex = 3;
            this.buttonFontDialog.Text = "FontDialog";
            this.buttonFontDialog.UseVisualStyleBackColor = true;
            this.buttonFontDialog.Click += new System.EventHandler(this.buttonFontDialog_Click);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(186, 103);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(156, 30);
            this.buttonOpenFileDialog.TabIndex = 4;
            this.buttonOpenFileDialog.Text = "OpenFileDialog";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // buttonSaveFileDialog
            // 
            this.buttonSaveFileDialog.Location = new System.Drawing.Point(186, 139);
            this.buttonSaveFileDialog.Name = "buttonSaveFileDialog";
            this.buttonSaveFileDialog.Size = new System.Drawing.Size(156, 30);
            this.buttonSaveFileDialog.TabIndex = 5;
            this.buttonSaveFileDialog.Text = "SaveFileDialog";
            this.buttonSaveFileDialog.UseVisualStyleBackColor = true;
            this.buttonSaveFileDialog.Click += new System.EventHandler(this.buttonSaveFileDialog_Click);
            // 
            // buttonFolderBrowserDialog
            // 
            this.buttonFolderBrowserDialog.Location = new System.Drawing.Point(186, 175);
            this.buttonFolderBrowserDialog.Name = "buttonFolderBrowserDialog";
            this.buttonFolderBrowserDialog.Size = new System.Drawing.Size(156, 30);
            this.buttonFolderBrowserDialog.TabIndex = 6;
            this.buttonFolderBrowserDialog.Text = "FolderBrowserDialog";
            this.buttonFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.buttonFolderBrowserDialog.Click += new System.EventHandler(this.buttonFolderBrowserDialog_Click);
            // 
            // buttonFormExample
            // 
            this.buttonFormExample.Location = new System.Drawing.Point(348, 31);
            this.buttonFormExample.Name = "buttonFormExample";
            this.buttonFormExample.Size = new System.Drawing.Size(156, 30);
            this.buttonFormExample.TabIndex = 7;
            this.buttonFormExample.Text = "FormExample";
            this.buttonFormExample.UseVisualStyleBackColor = true;
            this.buttonFormExample.Click += new System.EventHandler(this.buttonFormExample_Click);
            // 
            // buttonFormExampleDialog
            // 
            this.buttonFormExampleDialog.Location = new System.Drawing.Point(510, 31);
            this.buttonFormExampleDialog.Name = "buttonFormExampleDialog";
            this.buttonFormExampleDialog.Size = new System.Drawing.Size(156, 30);
            this.buttonFormExampleDialog.TabIndex = 8;
            this.buttonFormExampleDialog.Text = "FormExampleDialog";
            this.buttonFormExampleDialog.UseVisualStyleBackColor = true;
            this.buttonFormExampleDialog.Click += new System.EventHandler(this.buttonFormExampleDialog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFormExampleDialog);
            this.Controls.Add(this.buttonFormExample);
            this.Controls.Add(this.buttonFolderBrowserDialog);
            this.Controls.Add(this.buttonSaveFileDialog);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.buttonFontDialog);
            this.Controls.Add(this.buttonColorDialog);
            this.Controls.Add(this.buttonMessageBox);
            this.Controls.Add(this.buttonMessageBoxSimple);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMessageBoxSimple;
        private System.Windows.Forms.Button buttonMessageBox;
        private System.Windows.Forms.Button buttonColorDialog;
        private System.Windows.Forms.Button buttonFontDialog;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Button buttonSaveFileDialog;
        private System.Windows.Forms.Button buttonFolderBrowserDialog;
        private System.Windows.Forms.Button buttonFormExample;
        private System.Windows.Forms.Button buttonFormExampleDialog;
    }
}

