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
            this.components = new System.ComponentModel.Container();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ball = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.scoreLineL = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.scoreLineR = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dividingLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.botBorder = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.topBorder = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.playerR = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.playerL = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ball,
            this.scoreLineL,
            this.scoreLineR,
            this.dividingLine,
            this.botBorder,
            this.topBorder,
            this.playerR,
            this.playerL});
            this.shapeContainer1.Size = new System.Drawing.Size(1084, 862);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ball
            // 
            this.ball.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BorderColor = System.Drawing.Color.White;
            this.ball.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ball.FillColor = System.Drawing.Color.White;
            this.ball.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ball.Location = new System.Drawing.Point(530, 430);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            // 
            // scoreLineL
            // 
            this.scoreLineL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreLineL.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.scoreLineL.BorderWidth = 20;
            this.scoreLineL.Name = "scoreLineL";
            this.scoreLineL.X1 = 50;
            this.scoreLineL.X2 = 50;
            this.scoreLineL.Y1 = 60;
            this.scoreLineL.Y2 = 800;
            // 
            // scoreLineR
            // 
            this.scoreLineR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreLineR.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.scoreLineR.BorderWidth = 20;
            this.scoreLineR.Name = "scoreLineR";
            this.scoreLineR.X1 = 1050;
            this.scoreLineR.X2 = 1050;
            this.scoreLineR.Y1 = 60;
            this.scoreLineR.Y2 = 800;
            // 
            // dividingLine
            // 
            this.dividingLine.BorderColor = System.Drawing.Color.Silver;
            this.dividingLine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.dividingLine.BorderWidth = 20;
            this.dividingLine.Name = "dividingLine";
            this.dividingLine.UseWaitCursor = true;
            this.dividingLine.X1 = 550;
            this.dividingLine.X2 = 550;
            this.dividingLine.Y1 = 60;
            this.dividingLine.Y2 = 800;
            // 
            // botBorder
            // 
            this.botBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botBorder.BorderColor = System.Drawing.Color.White;
            this.botBorder.BorderWidth = 20;
            this.botBorder.Name = "botBorder";
            this.botBorder.UseWaitCursor = true;
            this.botBorder.X1 = 50;
            this.botBorder.X2 = 1050;
            this.botBorder.Y1 = 810;
            this.botBorder.Y2 = 810;
            // 
            // topBorder
            // 
            this.topBorder.BorderColor = System.Drawing.Color.White;
            this.topBorder.BorderWidth = 20;
            this.topBorder.Name = "topBorder";
            this.topBorder.UseWaitCursor = true;
            this.topBorder.X1 = 50;
            this.topBorder.X2 = 1050;
            this.topBorder.Y1 = 50;
            this.topBorder.Y2 = 50;
            // 
            // playerR
            // 
            this.playerR.BackColor = System.Drawing.Color.White;
            this.playerR.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.playerR.BorderColor = System.Drawing.Color.White;
            this.playerR.FillColor = System.Drawing.Color.White;
            this.playerR.FillGradientColor = System.Drawing.Color.White;
            this.playerR.Location = new System.Drawing.Point(970, 290);
            this.playerR.Name = "playerR";
            this.playerR.Size = new System.Drawing.Size(30, 220);
            this.playerR.UseWaitCursor = true;
            // 
            // playerL
            // 
            this.playerL.BackColor = System.Drawing.Color.White;
            this.playerL.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.playerL.BorderColor = System.Drawing.Color.White;
            this.playerL.FillColor = System.Drawing.Color.White;
            this.playerL.FillGradientColor = System.Drawing.Color.White;
            this.playerL.Location = new System.Drawing.Point(80, 290);
            this.playerL.Name = "playerL";
            this.playerL.Size = new System.Drawing.Size(30, 220);
            this.playerL.UseWaitCursor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1084, 862);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Board";
            this.Text = "Board";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape playerL;
        private Microsoft.VisualBasic.PowerPacks.LineShape dividingLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape botBorder;
        private Microsoft.VisualBasic.PowerPacks.LineShape topBorder;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape playerR;
        private Microsoft.VisualBasic.PowerPacks.LineShape scoreLineL;
        private Microsoft.VisualBasic.PowerPacks.LineShape scoreLineR;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ball;
        public System.Windows.Forms.Timer timer;
    }
}