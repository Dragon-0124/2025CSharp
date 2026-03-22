
namespace CrapsGame
{
    partial class CrapsGame
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
            gbPoint = new GroupBox();
            lbStatus = new Label();
            btReset = new Button();
            btRoll = new Button();
            btPlay = new Button();
            pbSecondDie = new PictureBox();
            pbFirstDie = new PictureBox();
            pbSecondPoint = new PictureBox();
            pbFirstPoint = new PictureBox();
            gbPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSecondDie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFirstDie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSecondPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFirstPoint).BeginInit();
            SuspendLayout();
            // 
            // gbPoint
            // 
            gbPoint.Controls.Add(lbStatus);
            gbPoint.Controls.Add(btReset);
            gbPoint.Controls.Add(btRoll);
            gbPoint.Controls.Add(btPlay);
            gbPoint.Controls.Add(pbSecondDie);
            gbPoint.Controls.Add(pbFirstDie);
            gbPoint.Controls.Add(pbSecondPoint);
            gbPoint.Controls.Add(pbFirstPoint);
            gbPoint.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            gbPoint.Location = new Point(12, 12);
            gbPoint.Name = "gbPoint";
            gbPoint.Size = new Size(776, 426);
            gbPoint.TabIndex = 0;
            gbPoint.TabStop = false;
            gbPoint.Text = "Point";
            // 
            // lbStatus
            // 
            lbStatus.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbStatus.Location = new Point(307, 223);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(322, 174);
            lbStatus.TabIndex = 5;
            lbStatus.Text = "결과 : ";
            // 
            // btReset
            // 
            btReset.BackColor = Color.Red;
            btReset.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btReset.ForeColor = Color.White;
            btReset.Location = new Point(6, 390);
            btReset.Name = "btReset";
            btReset.Size = new Size(50, 30);
            btReset.TabIndex = 4;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = false;
            btReset.Click += btReset_Click;
            // 
            // btRoll
            // 
            btRoll.Location = new Point(441, 106);
            btRoll.Name = "btRoll";
            btRoll.Size = new Size(90, 50);
            btRoll.TabIndex = 4;
            btRoll.Text = "Roll";
            btRoll.UseVisualStyleBackColor = true;
            btRoll.Click += btRoll_Click;
            // 
            // btPlay
            // 
            btPlay.Location = new Point(307, 106);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(90, 50);
            btPlay.TabIndex = 4;
            btPlay.Text = "Play";
            btPlay.UseVisualStyleBackColor = true;
            btPlay.Click += btPlay_Click;
            // 
            // pbSecondDie
            // 
            pbSecondDie.AccessibleDescription = "";
            pbSecondDie.Location = new Point(207, 223);
            pbSecondDie.Name = "pbSecondDie";
            pbSecondDie.Size = new Size(70, 70);
            pbSecondDie.TabIndex = 3;
            pbSecondDie.TabStop = false;
            pbSecondDie.Tag = "";
            // 
            // pbFirstDie
            // 
            pbFirstDie.AccessibleDescription = "";
            pbFirstDie.Location = new Point(67, 223);
            pbFirstDie.Name = "pbFirstDie";
            pbFirstDie.Size = new Size(70, 70);
            pbFirstDie.TabIndex = 2;
            pbFirstDie.TabStop = false;
            pbFirstDie.Tag = "";
            // 
            // pbSecondPoint
            // 
            pbSecondPoint.AccessibleDescription = "";
            pbSecondPoint.Location = new Point(177, 80);
            pbSecondPoint.Name = "pbSecondPoint";
            pbSecondPoint.Size = new Size(100, 100);
            pbSecondPoint.TabIndex = 1;
            pbSecondPoint.TabStop = false;
            pbSecondPoint.Tag = "";
            // 
            // pbFirstPoint
            // 
            pbFirstPoint.AccessibleDescription = "";
            pbFirstPoint.Location = new Point(37, 80);
            pbFirstPoint.Name = "pbFirstPoint";
            pbFirstPoint.Size = new Size(100, 100);
            pbFirstPoint.TabIndex = 0;
            pbFirstPoint.TabStop = false;
            pbFirstPoint.Tag = "";
            // 
            // CrapsGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbPoint);
            Name = "CrapsGame";
            Text = "Form1";
            gbPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSecondDie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFirstDie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSecondPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFirstPoint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPoint;
        private PictureBox pbSecondPoint;
        private PictureBox pbFirstPoint;
        private PictureBox pbSecondDie;
        private PictureBox pbFirstDie;
        private Label lbStatus;
        private Button btRoll;
        private Button btPlay;
        private Button btReset;

    }
}
