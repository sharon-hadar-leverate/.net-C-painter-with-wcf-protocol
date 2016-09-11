namespace Savefile
{
  partial class SaveGraphicsForm
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.Save = new System.Windows.Forms.Button();
      this.fileName = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(56, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(138, 20);
      this.textBox1.TabIndex = 1;
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(200, 7);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(75, 23);
      this.Save.TabIndex = 2;
      this.Save.Text = "Save";
      this.Save.UseVisualStyleBackColor = true;
      this.Save.Click += new System.EventHandler(this.button1_Click);
      // 
      // fileName
      // 
      this.fileName.AutoSize = true;
      this.fileName.Location = new System.Drawing.Point(12, 12);
      this.fileName.Name = "fileName";
      this.fileName.Size = new System.Drawing.Size(38, 13);
      this.fileName.TabIndex = 3;
      this.fileName.Text = "Name:";
      // 
      // SaveGraphicsForm
      // 
      this.AcceptButton = this.Save;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(287, 34);
      this.Controls.Add(this.fileName);
      this.Controls.Add(this.Save);
      this.Controls.Add(this.textBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SaveGraphicsForm";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "SaveGraphicsForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button Save;
    private System.Windows.Forms.Label fileName;
  }
}

