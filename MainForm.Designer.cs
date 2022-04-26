
namespace GoodMatchApp
{
    partial class MainForm
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
            this.lblHeadingMain = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.lblPlayerNameInputHeading = new System.Windows.Forms.Label();
            this.btnViewMatchPercentage = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblCSVHeading = new System.Windows.Forms.Label();
            this.btnSelectCSVFile = new System.Windows.Forms.Button();
            this.txtCSVFileName = new System.Windows.Forms.TextBox();
            this.btnViewGroupPercentage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeadingMain
            // 
            this.lblHeadingMain.AutoSize = true;
            this.lblHeadingMain.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingMain.Location = new System.Drawing.Point(173, 9);
            this.lblHeadingMain.Name = "lblHeadingMain";
            this.lblHeadingMain.Size = new System.Drawing.Size(474, 45);
            this.lblHeadingMain.TabIndex = 0;
            this.lblHeadingMain.Text = "Good Match Tennis Application";
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Location = new System.Drawing.Point(72, 150);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(64, 20);
            this.lblPlayerOne.TabIndex = 1;
            this.lblPlayerOne.Text = "Player 1:";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(72, 209);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(64, 20);
            this.lblPlayerTwo.TabIndex = 2;
            this.lblPlayerTwo.Text = "Player 2:";
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(194, 143);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(125, 27);
            this.txtPlayerOne.TabIndex = 3;
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(194, 206);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(125, 27);
            this.txtPlayerTwo.TabIndex = 4;
            // 
            // lblPlayerNameInputHeading
            // 
            this.lblPlayerNameInputHeading.AutoSize = true;
            this.lblPlayerNameInputHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerNameInputHeading.Location = new System.Drawing.Point(63, 80);
            this.lblPlayerNameInputHeading.Name = "lblPlayerNameInputHeading";
            this.lblPlayerNameInputHeading.Size = new System.Drawing.Size(285, 40);
            this.lblPlayerNameInputHeading.TabIndex = 5;
            this.lblPlayerNameInputHeading.Text = "Please enter the first names of the two\r\nplayers participating in the mixed doubl" +
    "e.";
            this.lblPlayerNameInputHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnViewMatchPercentage
            // 
            this.btnViewMatchPercentage.Location = new System.Drawing.Point(111, 271);
            this.btnViewMatchPercentage.Name = "btnViewMatchPercentage";
            this.btnViewMatchPercentage.Size = new System.Drawing.Size(182, 49);
            this.btnViewMatchPercentage.TabIndex = 6;
            this.btnViewMatchPercentage.Text = "View match percentage";
            this.btnViewMatchPercentage.UseVisualStyleBackColor = true;
            this.btnViewMatchPercentage.Click += new System.EventHandler(this.btnViewMatchPercentage_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(385, 90);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(25, 20);
            this.lblOr.TabIndex = 7;
            this.lblOr.Text = "Or";
            // 
            // lblCSVHeading
            // 
            this.lblCSVHeading.AutoSize = true;
            this.lblCSVHeading.Location = new System.Drawing.Point(453, 80);
            this.lblCSVHeading.Name = "lblCSVHeading";
            this.lblCSVHeading.Size = new System.Drawing.Size(236, 40);
            this.lblCSVHeading.TabIndex = 8;
            this.lblCSVHeading.Text = "Input a CSV file to view the match\r\n percentage for a group of players";
            this.lblCSVHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectCSVFile
            // 
            this.btnSelectCSVFile.Location = new System.Drawing.Point(514, 141);
            this.btnSelectCSVFile.Name = "btnSelectCSVFile";
            this.btnSelectCSVFile.Size = new System.Drawing.Size(119, 39);
            this.btnSelectCSVFile.TabIndex = 9;
            this.btnSelectCSVFile.Text = "Open CSV File";
            this.btnSelectCSVFile.UseVisualStyleBackColor = true;
            this.btnSelectCSVFile.Click += new System.EventHandler(this.btnSelectCSVFile_Click);
            // 
            // txtCSVFileName
            // 
            this.txtCSVFileName.Location = new System.Drawing.Point(453, 206);
            this.txtCSVFileName.Name = "txtCSVFileName";
            this.txtCSVFileName.Size = new System.Drawing.Size(236, 27);
            this.txtCSVFileName.TabIndex = 10;
            // 
            // btnViewGroupPercentage
            // 
            this.btnViewGroupPercentage.Location = new System.Drawing.Point(453, 271);
            this.btnViewGroupPercentage.Name = "btnViewGroupPercentage";
            this.btnViewGroupPercentage.Size = new System.Drawing.Size(220, 49);
            this.btnViewGroupPercentage.TabIndex = 11;
            this.btnViewGroupPercentage.Text = "Write group match percentage results to textfile";
            this.btnViewGroupPercentage.UseVisualStyleBackColor = true;
            this.btnViewGroupPercentage.Click += new System.EventHandler(this.btnViewGroupPercentage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.btnViewGroupPercentage);
            this.Controls.Add(this.txtCSVFileName);
            this.Controls.Add(this.btnSelectCSVFile);
            this.Controls.Add(this.lblCSVHeading);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.btnViewMatchPercentage);
            this.Controls.Add(this.lblPlayerNameInputHeading);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.lblHeadingMain);
            this.Name = "MainForm";
            this.Text = "Good Match";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingMain;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Label lblPlayerNameInputHeading;
        private System.Windows.Forms.Button btnViewMatchPercentage;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblCSVHeading;
        private System.Windows.Forms.Button btnSelectCSVFile;
        private System.Windows.Forms.TextBox txtCSVFileName;
        private System.Windows.Forms.Button btnViewGroupPercentage;
    }
}

