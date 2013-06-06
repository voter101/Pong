namespace Pong
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.MiddleLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BottomBarrier = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TopBarrier = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.RightPalette = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.MiddleLine,
            this.BottomBarrier,
            this.TopBarrier,
            this.RightPalette});
            this.shapeContainer1.Size = new System.Drawing.Size(984, 712);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // MiddleLine
            // 
            this.MiddleLine.BorderColor = System.Drawing.Color.White;
            this.MiddleLine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.MiddleLine.BorderWidth = 10;
            this.MiddleLine.Name = "MiddleLine";
            this.MiddleLine.X1 = 500;
            this.MiddleLine.X2 = 500;
            this.MiddleLine.Y1 = 30;
            this.MiddleLine.Y2 = 680;
            // 
            // BottomBarrier
            // 
            this.BottomBarrier.BorderColor = System.Drawing.Color.White;
            this.BottomBarrier.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BottomBarrier.BorderWidth = 20;
            this.BottomBarrier.Name = "BottomBarrier";
            this.BottomBarrier.X1 = 0;
            this.BottomBarrier.X2 = 1000;
            this.BottomBarrier.Y1 = 700;
            this.BottomBarrier.Y2 = 700;
            // 
            // TopBarrier
            // 
            this.TopBarrier.BorderColor = System.Drawing.Color.White;
            this.TopBarrier.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TopBarrier.BorderWidth = 20;
            this.TopBarrier.Name = "TopBarrier";
            this.TopBarrier.X1 = 0;
            this.TopBarrier.X2 = 1000;
            this.TopBarrier.Y1 = 15;
            this.TopBarrier.Y2 = 15;
            // 
            // RightPalette
            // 
            this.RightPalette.BackColor = System.Drawing.Color.White;
            this.RightPalette.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.RightPalette.Location = new System.Drawing.Point(930, 30);
            this.RightPalette.Name = "RightPalette";
            this.RightPalette.Size = new System.Drawing.Size(25, 150);
            this.RightPalette.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightPalette_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RightPalette;
        private Microsoft.VisualBasic.PowerPacks.LineShape MiddleLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape BottomBarrier;
        private Microsoft.VisualBasic.PowerPacks.LineShape TopBarrier;
    }
}

