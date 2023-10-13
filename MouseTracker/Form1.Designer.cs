namespace MouseTracker
{
    partial class MousePointer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MousePointer));
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.mousePointerValueX = new System.Windows.Forms.Label();
            this.mousePointerValueY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(77, 53);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(26, 28);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y.Location = new System.Drawing.Point(77, 114);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(25, 28);
            this.Y.TabIndex = 1;
            this.Y.Text = "Y";
            // 
            // mousePointerValueX
            // 
            this.mousePointerValueX.AutoSize = true;
            this.mousePointerValueX.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mousePointerValueX.Location = new System.Drawing.Point(125, 53);
            this.mousePointerValueX.Name = "mousePointerValueX";
            this.mousePointerValueX.Size = new System.Drawing.Size(48, 28);
            this.mousePointerValueX.TabIndex = 2;
            this.mousePointerValueX.Text = "000";
            // 
            // mousePointerValueY
            // 
            this.mousePointerValueY.AutoSize = true;
            this.mousePointerValueY.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mousePointerValueY.Location = new System.Drawing.Point(125, 114);
            this.mousePointerValueY.Name = "mousePointerValueY";
            this.mousePointerValueY.Size = new System.Drawing.Size(48, 28);
            this.mousePointerValueY.TabIndex = 4;
            this.mousePointerValueY.Text = "000";
            // 
            // MousePointer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 196);
            this.Controls.Add(this.mousePointerValueY);
            this.Controls.Add(this.mousePointerValueX);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MousePointer";
            this.Text = "Mouse pointer tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label mousePointerValueX;
        private System.Windows.Forms.Label mousePointerValueY;
    }
}

