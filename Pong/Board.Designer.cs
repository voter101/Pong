namespace Pong
{
    partial class Board
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
            this.playerL = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.playerR = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.topBorder = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.botBorder = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dividingLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.dividingLine,
            this.botBorder,
            this.topBorder,
            this.playerR,
            this.playerL});
            this.shapeContainer1.Size = new System.Drawing.Size(984, 762);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            this.shapeContainer1.UseWaitCursor = true;
            // 
            // playerL
            // 
            this.playerL.BackColor = System.Drawing.Color.White;
            this.playerL.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.playerL.BorderColor = System.Drawing.Color.White;
            this.playerL.FillColor = System.Drawing.Color.White;
            this.playerL.FillGradientColor = System.Drawing.Color.White;
            this.playerL.Location = new System.Drawing.Point(30, 290);
            this.playerL.Name = "playerL";
            this.playerL.Size = new System.Drawing.Size(30, 220);
            this.playerL.UseWaitCursor = true;
            // 
            // playerR
            // 
            this.playerR.BackColor = System.Drawing.Color.White;
            this.playerR.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.playerR.BorderColor = System.Drawing.Color.White;
            this.playerR.FillColor = System.Drawing.Color.White;
            this.playerR.FillGradientColor = System.Drawing.Color.White;
            this.playerR.Location = new System.Drawing.Point(920, 290);
            this.playerR.Name = "playerR";
            this.playerR.Size = new System.Drawing.Size(30, 220);
            this.playerR.UseWaitCursor = true;
            // 
            // topBorder
            // 
            this.topBorder.BorderColor = System.Drawing.Color.White;
            this.topBorder.BorderWidth = 20;
            this.topBorder.Name = "topBorder";
            this.topBorder.UseWaitCursor = true;
            this.topBorder.X1 = -1;
            this.topBorder.X2 = 1000;
            this.topBorder.Y1 = 0;
            this.topBorder.Y2 = 0;
            // 
            // botBorder
            // 
            this.botBorder.BorderColor = System.Drawing.Color.White;
            this.botBorder.BorderWidth = 20;
            this.botBorder.Name = "botBorder";
            this.botBorder.UseWaitCursor = true;
            this.botBorder.X1 = -1;
            this.botBorder.X2 = 1000;
            this.botBorder.Y1 = 760;
            this.botBorder.Y2 = 760;
            // 
            // dividingLine
            // 
            this.dividingLine.BorderColor = System.Drawing.Color.White;
            this.dividingLine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.dividingLine.BorderWidth = 20;
            this.dividingLine.Name = "dividingLine";
            this.dividingLine.UseWaitCursor = true;
            this.dividingLine.X1 = 500;
            this.dividingLine.X2 = 500;
            this.dividingLine.Y1 = -1;
            this.dividingLine.Y2 = 800;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Board";
            this.Text = "Board";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape playerL;
        private Microsoft.VisualBasic.PowerPacks.LineShape dividingLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape botBorder;
        private Microsoft.VisualBasic.PowerPacks.LineShape topBorder;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape playerR;
    }
}