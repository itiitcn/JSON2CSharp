namespace JSON2CSharp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtJSON = new System.Windows.Forms.RichTextBox();
            this.txtCSharp = new System.Windows.Forms.RichTextBox();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.btnCopyCSharp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.htnFormat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJSON
            // 
            this.txtJSON.BackColor = System.Drawing.Color.Gainsboro;
            this.txtJSON.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJSON.Location = new System.Drawing.Point(0, 0);
            this.txtJSON.Name = "txtJSON";
            this.txtJSON.Size = new System.Drawing.Size(383, 607);
            this.txtJSON.TabIndex = 1;
            this.txtJSON.Text = "";
            this.txtJSON.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtJSON_KeyUp);
            // 
            // txtCSharp
            // 
            this.txtCSharp.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCSharp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCSharp.Location = new System.Drawing.Point(0, 0);
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.ReadOnly = true;
            this.txtCSharp.Size = new System.Drawing.Size(379, 607);
            this.txtCSharp.TabIndex = 3;
            this.txtCSharp.Text = "";
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.BackColor = System.Drawing.Color.Gainsboro;
            this.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitMain.Location = new System.Drawing.Point(15, 78);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.txtJSON);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.txtCSharp);
            this.splitMain.Size = new System.Drawing.Size(770, 609);
            this.splitMain.SplitterDistance = 385;
            this.splitMain.TabIndex = 4;
            // 
            // btnCopyCSharp
            // 
            this.btnCopyCSharp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyCSharp.AutoSize = true;
            this.btnCopyCSharp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyCSharp.Depth = 0;
            this.btnCopyCSharp.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCopyCSharp.Icon = null;
            this.btnCopyCSharp.Location = new System.Drawing.Point(473, 26);
            this.btnCopyCSharp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyCSharp.Name = "btnCopyCSharp";
            this.btnCopyCSharp.Primary = true;
            this.btnCopyCSharp.Size = new System.Drawing.Size(110, 36);
            this.btnCopyCSharp.TabIndex = 9;
            this.btnCopyCSharp.Text = "CopyCSharp";
            this.btnCopyCSharp.UseVisualStyleBackColor = true;
            this.btnCopyCSharp.Click += new System.EventHandler(this.btnCopyCSharp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F);
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(405, 26);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(63, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // htnFormat
            // 
            this.htnFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.htnFormat.AutoSize = true;
            this.htnFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.htnFormat.Depth = 0;
            this.htnFormat.Font = new System.Drawing.Font("宋体", 12F);
            this.htnFormat.Icon = null;
            this.htnFormat.Location = new System.Drawing.Point(588, 26);
            this.htnFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.htnFormat.Name = "htnFormat";
            this.htnFormat.Primary = true;
            this.htnFormat.Size = new System.Drawing.Size(76, 36);
            this.htnFormat.TabIndex = 5;
            this.htnFormat.Text = "Format";
            this.htnFormat.UseVisualStyleBackColor = true;
            this.htnFormat.Click += new System.EventHandler(this.htnFormat_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.AutoSize = true;
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.Depth = 0;
            this.btn1.Font = new System.Drawing.Font("宋体", 12F);
            this.btn1.Icon = null;
            this.btn1.Location = new System.Drawing.Point(668, 26);
            this.btn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn1.Name = "btn1";
            this.btn1.Primary = true;
            this.btn1.Size = new System.Drawing.Size(117, 36);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "JSON2CSharp";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.btnCopyCSharp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.htnFormat);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON2CSharp&Format";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtJSON;
        private MaterialSkin.Controls.MaterialRaisedButton btn1;
        private System.Windows.Forms.RichTextBox txtCSharp;
        private System.Windows.Forms.SplitContainer splitMain;
        private MaterialSkin.Controls.MaterialRaisedButton htnFormat;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnCopyCSharp;
    }
}

