namespace painter
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.m_colorDialog = new System.Windows.Forms.ColorDialog();
      this.PickonClick = new System.Windows.Forms.Button();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.BrushClick = new System.Windows.Forms.PictureBox();
      this.recClick = new System.Windows.Forms.PictureBox();
      this.lineClick = new System.Windows.Forms.PictureBox();
      this.penClick = new System.Windows.Forms.PictureBox();
      this.ellipseClick = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BrushClick)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recClick)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lineClick)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.penClick)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ellipseClick)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(667, 386);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Exit";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnExitClick);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(577, 386);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Clear";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.btnClearClick);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Window;
      this.panel1.Location = new System.Drawing.Point(13, 13);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(558, 396);
      this.panel1.TabIndex = 2;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(577, 122);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(256, 256);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
      this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
      this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(599, 148);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(32, 30);
      this.pictureBox2.TabIndex = 4;
      this.pictureBox2.TabStop = false;
      // 
      // PickonClick
      // 
      this.PickonClick.Location = new System.Drawing.Point(755, 386);
      this.PickonClick.Name = "PickonClick";
      this.PickonClick.Size = new System.Drawing.Size(75, 23);
      this.PickonClick.TabIndex = 5;
      this.PickonClick.Text = "PickonClick";
      this.PickonClick.UseVisualStyleBackColor = true;
      this.PickonClick.Click += new System.EventHandler(this.PickonClick_Click);
      // 
      // pictureBox3
      // 
      this.pictureBox3.Location = new System.Drawing.Point(634, 148);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(32, 30);
      this.pictureBox3.TabIndex = 6;
      this.pictureBox3.TabStop = false;
      // 
      // BrushClick
      // 
      this.BrushClick.Image = ((System.Drawing.Image)(resources.GetObject("BrushClick.Image")));
      this.BrushClick.Location = new System.Drawing.Point(639, 74);
      this.BrushClick.Name = "BrushClick";
      this.BrushClick.Size = new System.Drawing.Size(41, 42);
      this.BrushClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.BrushClick.TabIndex = 7;
      this.BrushClick.TabStop = false;
      this.BrushClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BrushClick_MouseClick);
      // 
      // recClick
      // 
      this.recClick.Image = ((System.Drawing.Image)(resources.GetObject("recClick.Image")));
      this.recClick.Location = new System.Drawing.Point(686, 74);
      this.recClick.Name = "recClick";
      this.recClick.Size = new System.Drawing.Size(41, 42);
      this.recClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.recClick.TabIndex = 8;
      this.recClick.TabStop = false;
      this.recClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recClick_MouseClick);
      // 
      // lineClick
      // 
      this.lineClick.Image = ((System.Drawing.Image)(resources.GetObject("lineClick.Image")));
      this.lineClick.Location = new System.Drawing.Point(733, 74);
      this.lineClick.Name = "lineClick";
      this.lineClick.Size = new System.Drawing.Size(41, 42);
      this.lineClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.lineClick.TabIndex = 9;
      this.lineClick.TabStop = false;
      this.lineClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineClick_MouseClick);
      // 
      // penClick
      // 
      this.penClick.Image = ((System.Drawing.Image)(resources.GetObject("penClick.Image")));
      this.penClick.Location = new System.Drawing.Point(781, 74);
      this.penClick.Name = "penClick";
      this.penClick.Size = new System.Drawing.Size(41, 42);
      this.penClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.penClick.TabIndex = 10;
      this.penClick.TabStop = false;
      this.penClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.penClick_MouseClick);
      // 
      // ellipseClick
      // 
      this.ellipseClick.Image = ((System.Drawing.Image)(resources.GetObject("ellipseClick.Image")));
      this.ellipseClick.Location = new System.Drawing.Point(592, 74);
      this.ellipseClick.Name = "ellipseClick";
      this.ellipseClick.Size = new System.Drawing.Size(41, 42);
      this.ellipseClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.ellipseClick.TabIndex = 11;
      this.ellipseClick.TabStop = false;
      this.ellipseClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ellipseClick_MouseClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(844, 411);
      this.Controls.Add(this.ellipseClick);
      this.Controls.Add(this.penClick);
      this.Controls.Add(this.lineClick);
      this.Controls.Add(this.recClick);
      this.Controls.Add(this.BrushClick);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.PickonClick);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BrushClick)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recClick)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lineClick)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.penClick)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ellipseClick)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog m_colorDialog;
        private System.Windows.Forms.Button PickonClick;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox BrushClick;
    private System.Windows.Forms.PictureBox recClick;
    private System.Windows.Forms.PictureBox lineClick;
    private System.Windows.Forms.PictureBox penClick;
    private System.Windows.Forms.PictureBox ellipseClick;
  }
}

