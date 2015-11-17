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
      this.listViewMatrixA = new System.Windows.Forms.ListView();
      this.listViewMatrixB = new System.Windows.Forms.ListView();
      this.listViewMatrixC = new System.Windows.Forms.ListView();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
      this.loadMatrixBToolStripMenuItem.Click += new System.EventHandler(this.loadMatrixBToolStripMenuItem_Click);
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
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
      this.calculateSumeCABToolStripMenuItem.Click += new System.EventHandler(this.calculateSumeCABToolStripMenuItem_Click);
      // 
      // calculateDifferenceCABToolStripMenuItem
      // 
      this.calculateDifferenceCABToolStripMenuItem.Name = "calculateDifferenceCABToolStripMenuItem";
      this.calculateDifferenceCABToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateDifferenceCABToolStripMenuItem.Text = "Calculate difference C=A-B";
      this.calculateDifferenceCABToolStripMenuItem.Click += new System.EventHandler(this.calculateDifferenceCABToolStripMenuItem_Click);
      // 
      // calculateDifferenceCBAToolStripMenuItem
      // 
      this.calculateDifferenceCBAToolStripMenuItem.Name = "calculateDifferenceCBAToolStripMenuItem";
      this.calculateDifferenceCBAToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateDifferenceCBAToolStripMenuItem.Text = "Calculate difference C=B-A";
      this.calculateDifferenceCBAToolStripMenuItem.Click += new System.EventHandler(this.calculateDifferenceCBAToolStripMenuItem_Click);
      // 
      // calculateProductCABToolStripMenuItem
      // 
      this.calculateProductCABToolStripMenuItem.Name = "calculateProductCABToolStripMenuItem";
      this.calculateProductCABToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateProductCABToolStripMenuItem.Text = "Calculate product C=A*B";
      this.calculateProductCABToolStripMenuItem.Click += new System.EventHandler(this.calculateProductCABToolStripMenuItem_Click);
      // 
      // calculateProductCBAToolStripMenuItem
      // 
      this.calculateProductCBAToolStripMenuItem.Name = "calculateProductCBAToolStripMenuItem";
      this.calculateProductCBAToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.calculateProductCBAToolStripMenuItem.Text = "Calculate product C=B*A";
      this.calculateProductCBAToolStripMenuItem.Click += new System.EventHandler(this.calculateProductCBAToolStripMenuItem_Click);
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
      this.aboutMatrixCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutMatrixCalculatorToolStripMenuItem_Click);
      // 
      // listViewMatrixA
      // 
      this.listViewMatrixA.GridLines = true;
      this.listViewMatrixA.Location = new System.Drawing.Point(0, 24);
      this.listViewMatrixA.Name = "listViewMatrixA";
      this.listViewMatrixA.Size = new System.Drawing.Size(234, 315);
      this.listViewMatrixA.TabIndex = 2;
      this.listViewMatrixA.UseCompatibleStateImageBehavior = false;
      // 
      // listViewMatrixB
      // 
      this.listViewMatrixB.GridLines = true;
      this.listViewMatrixB.Location = new System.Drawing.Point(234, 24);
      this.listViewMatrixB.Name = "listViewMatrixB";
      this.listViewMatrixB.Size = new System.Drawing.Size(217, 315);
      this.listViewMatrixB.TabIndex = 3;
      this.listViewMatrixB.UseCompatibleStateImageBehavior = false;
      // 
      // listViewMatrixC
      // 
      this.listViewMatrixC.GridLines = true;
      this.listViewMatrixC.Location = new System.Drawing.Point(451, 24);
      this.listViewMatrixC.Name = "listViewMatrixC";
      this.listViewMatrixC.Size = new System.Drawing.Size(213, 315);
      this.listViewMatrixC.TabIndex = 4;
      this.listViewMatrixC.UseCompatibleStateImageBehavior = false;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 339);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(663, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "Foo";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 361);
      this.Controls.Add(this.listViewMatrixC);
      this.Controls.Add(this.listViewMatrixB);
      this.Controls.Add(this.listViewMatrixA);
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
    private System.Windows.Forms.ListView listViewMatrixA;
    private System.Windows.Forms.ListView listViewMatrixB;
    private System.Windows.Forms.ListView listViewMatrixC;
    private System.Windows.Forms.StatusStrip statusStrip1;
  }
}

