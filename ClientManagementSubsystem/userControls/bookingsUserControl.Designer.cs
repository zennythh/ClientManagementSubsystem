namespace ClientManagementSubsystem
{
    partial class bookingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.approvedSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.pendingSelected = new Guna.UI2.WinForms.Guna2Shapes();
            this.innerHeaderPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.approvedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pendingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bookingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.innerHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.innerHeaderPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.bookingsPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1622, 943);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // approvedSelected
            // 
            this.approvedSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedSelected.Location = new System.Drawing.Point(235, 105);
            this.approvedSelected.Name = "approvedSelected";
            this.approvedSelected.PolygonSkip = 1;
            this.approvedSelected.Rotate = 0F;
            this.approvedSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.approvedSelected.Size = new System.Drawing.Size(215, 5);
            this.approvedSelected.TabIndex = 3;
            this.approvedSelected.Text = "guna2Shapes2";
            this.approvedSelected.Zoom = 100;
            // 
            // pendingSelected
            // 
            this.pendingSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingSelected.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingSelected.Location = new System.Drawing.Point(43, 105);
            this.pendingSelected.Margin = new System.Windows.Forms.Padding(0);
            this.pendingSelected.Name = "pendingSelected";
            this.pendingSelected.PolygonSkip = 1;
            this.pendingSelected.Rotate = 0F;
            this.pendingSelected.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.pendingSelected.Size = new System.Drawing.Size(186, 5);
            this.pendingSelected.TabIndex = 2;
            this.pendingSelected.Text = "guna2Shapes1";
            this.pendingSelected.Zoom = 100;
            // 
            // innerHeaderPanel
            // 
            this.innerHeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.innerHeaderPanel.BorderRadius = 25;
            this.innerHeaderPanel.Controls.Add(this.pendingSelected);
            this.innerHeaderPanel.Controls.Add(this.approvedSelected);
            this.innerHeaderPanel.Controls.Add(this.approvedBtn);
            this.innerHeaderPanel.Controls.Add(this.pendingBtn);
            this.innerHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerHeaderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.innerHeaderPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.innerHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.innerHeaderPanel.Name = "innerHeaderPanel";
            this.innerHeaderPanel.Size = new System.Drawing.Size(1616, 135);
            this.innerHeaderPanel.TabIndex = 4;
            // 
            // approvedBtn
            // 
            this.approvedBtn.BackColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approvedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.approvedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.approvedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.approvedBtn.FillColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.approvedBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.approvedBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.approvedBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.approvedBtn.Location = new System.Drawing.Point(235, 36);
            this.approvedBtn.Name = "approvedBtn";
            this.approvedBtn.PressedColor = System.Drawing.Color.Transparent;
            this.approvedBtn.Size = new System.Drawing.Size(215, 63);
            this.approvedBtn.TabIndex = 1;
            this.approvedBtn.Text = "Approved";
            this.approvedBtn.Click += new System.EventHandler(this.approvedBtn_Click);
            // 
            // pendingBtn
            // 
            this.pendingBtn.BackColor = System.Drawing.Color.Transparent;
            this.pendingBtn.BorderColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pendingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pendingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pendingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pendingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pendingBtn.FillColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.pendingBtn.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pendingBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.pendingBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(225)))));
            this.pendingBtn.Location = new System.Drawing.Point(43, 36);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.PressedColor = System.Drawing.Color.Transparent;
            this.pendingBtn.Size = new System.Drawing.Size(186, 63);
            this.pendingBtn.TabIndex = 0;
            this.pendingBtn.Text = "Pending";
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // bookingsPanel
            // 
            this.bookingsPanel.AutoScroll = true;
            this.bookingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsPanel.Location = new System.Drawing.Point(3, 144);
            this.bookingsPanel.Name = "bookingsPanel";
            this.bookingsPanel.Size = new System.Drawing.Size(1616, 796);
            this.bookingsPanel.TabIndex = 1;
            // 
            // bookingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "bookingsUserControl";
            this.Size = new System.Drawing.Size(1622, 943);
            this.tableLayoutPanel.ResumeLayout(false);
            this.innerHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button pendingBtn;
        private Guna.UI2.WinForms.Guna2Button approvedBtn;
        private Guna.UI2.WinForms.Guna2Shapes pendingSelected;
        private Guna.UI2.WinForms.Guna2Shapes approvedSelected;
        private System.Windows.Forms.FlowLayoutPanel bookingsPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel innerHeaderPanel;
    }
}
