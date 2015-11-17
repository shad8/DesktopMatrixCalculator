namespace DesktopMatrixCalculator
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadMatrixAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadMatrixBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveMatrixCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculateSumeCABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculateDifferenceCABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculateDifferenceCBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculateProductCABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.calculateProductCBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutMatrixCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.listView1 = new System.Windows.Forms.ListView();
      this.listView2 = new System.Windows.Forms.ListView();
      this.listView3 = new System.Windows.Forms.ListView();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(663, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMatrixAToolStripMenuItem,
            this.loadMatrixBToolStripMenuItem,
            this.saveMatrixCToolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // loadMatrixAToolStripMenuItem
      // 
      this.loadMatrixAToolStripMenuItem.Name = "loadMatrixAToolStripMenuItem";
      this.loadMatrixAToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.loadMatrixAToolStripMenuItem.Text = "Load matrix A";
      this.loadMatrixAToolStripMenuItem.Click += new System.EventHandler(this.loadMatrixAToolStripMenuItem_Click);
      // 
      // loadMatrixBToolStripMenuItem
      // 
      this.loadMatrixBToolStripMenuItem.Name = "loadMatrixBToolStripMenuItem";
      this.loadMatrixBToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.loadMatrixBToolStripMenuItem.Text = "Load matrix B";
      // 
      // saveMatrixCToolStripMenuItem
      // 
      this.saveMatrixCToolStripMenuItem.Name = "saveMatrixCToolStripMenuItem";
      this.saveMatrixCToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.saveMatrixCToolStripMenuItem.Text = "Save matrix C";
      // 
      // separatorToolStripMenuItem
      // 
      this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
      this.separatorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.separatorToolStripMenuItem.Text = "Separator";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateSumeCABToolStripMenuItem,
            this.calculateDifferenceCABToolStripMenuItem,
            this.calculateDifferenceCBAToolStripMenuItem,
            this.calculateProductCABToolStripMenuItem,
            this.calculateProductCBAToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // calculateSumeCABToolStripMenuItem
      // 
      this.calculateSumeCABToolStripMenuItem.Name = "calculateSumeCABToolStripMenuItem";
      this.calculateSumeCABToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateSumeCABToolStripMenuItem.Text = "Calculate sum C=A+B";
      // 
      // calculateDifferenceCABToolStripMenuItem
      // 
      this.calculateDifferenceCABToolStripMenuItem.Name = "calculateDifferenceCABToolStripMenuItem";
      this.calculateDifferenceCABToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateDifferenceCABToolStripMenuItem.Text = "Calculate difference C=A-B";
      // 
      // calculateDifferenceCBAToolStripMenuItem
      // 
      this.calculateDifferenceCBAToolStripMenuItem.Name = "calculateDifferenceCBAToolStripMenuItem";
      this.calculateDifferenceCBAToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateDifferenceCBAToolStripMenuItem.Text = "Calculate difference C=B-A";
      // 
      // calculateProductCABToolStripMenuItem
      // 
      this.calculateProductCABToolStripMenuItem.Name = "calculateProductCABToolStripMenuItem";
      this.calculateProductCABToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateProductCABToolStripMenuItem.Text = "Calculate product C=A*B";
      // 
      // calculateProductCBAToolStripMenuItem
      // 
      this.calculateProductCBAToolStripMenuItem.Name = "calculateProductCBAToolStripMenuItem";
      this.calculateProductCBAToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateProductCBAToolStripMenuItem.Text = "Calculate product C=B*A";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMatrixCalculatorToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutMatrixCalculatorToolStripMenuItem
      // 
      this.aboutMatrixCalculatorToolStripMenuItem.Name = "aboutMatrixCalculatorToolStripMenuItem";
      this.aboutMatrixCalculatorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
      this.aboutMatrixCalculatorToolStripMenuItem.Text = "About Matrix Calculator ";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 339);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(663, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(12, 27);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(209, 309);
      this.listView1.TabIndex = 2;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // listView2
      // 
      this.listView2.Location = new System.Drawing.Point(227, 27);
      this.listView2.Name = "listView2";
      this.listView2.Size = new System.Drawing.Size(210, 309);
      this.listView2.TabIndex = 3;
      this.listView2.UseCompatibleStateImageBehavior = false;
      // 
      // listView3
      // 
      this.listView3.Location = new System.Drawing.Point(443, 27);
      this.listView3.Name = "listView3";
      this.listView3.Size = new System.Drawing.Size(208, 309);
      this.listView3.TabIndex = 4;
      this.listView3.UseCompatibleStateImageBehavior = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 361);
      this.Controls.Add(this.listView3);
      this.Controls.Add(this.listView2);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadMatrixAToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadMatrixBToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveMatrixCToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem separatorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMatrixCalculatorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculateSumeCABToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculateDifferenceCABToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculateDifferenceCBAToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculateProductCABToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculateProductCBAToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.ListView listView3;
  }
}

