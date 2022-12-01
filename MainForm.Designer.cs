namespace lab;

partial class MainForm
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.InputLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.VehicleBrandTextBox = new System.Windows.Forms.TextBox();
            this.VehicleReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.VehicleInitialPriceTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.VehicleGridView = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InputGroupBox.SuspendLayout();
            this.InputLayoutPanel.SuspendLayout();
            this.ControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).BeginInit();
            this.TableLayoutPanel.SuspendLayout();
            this.RightTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.InputLayoutPanel);
            this.InputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputGroupBox.Location = new System.Drawing.Point(3, 3);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(238, 208);
            this.InputGroupBox.TabIndex = 0;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Ввод";
            // 
            // InputLayoutPanel
            // 
            this.InputLayoutPanel.Controls.Add(this.VehicleBrandTextBox);
            this.InputLayoutPanel.Controls.Add(this.VehicleReleaseYearTextBox);
            this.InputLayoutPanel.Controls.Add(this.VehicleInitialPriceTextBox);
            this.InputLayoutPanel.Controls.Add(this.VehicleTypeComboBox);
            this.InputLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InputLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.InputLayoutPanel.Name = "InputLayoutPanel";
            this.InputLayoutPanel.Size = new System.Drawing.Size(232, 186);
            this.InputLayoutPanel.TabIndex = 0;
            // 
            // VehicleBrandTextBox
            // 
            this.VehicleBrandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleBrandTextBox.Location = new System.Drawing.Point(3, 3);
            this.VehicleBrandTextBox.Name = "VehicleBrandTextBox";
            this.VehicleBrandTextBox.PlaceholderText = "Марка";
            this.VehicleBrandTextBox.Size = new System.Drawing.Size(226, 23);
            this.VehicleBrandTextBox.TabIndex = 0;
            // 
            // VehicleReleaseYearTextBox
            // 
            this.VehicleReleaseYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleReleaseYearTextBox.Location = new System.Drawing.Point(3, 32);
            this.VehicleReleaseYearTextBox.MaxLength = 4;
            this.VehicleReleaseYearTextBox.Name = "VehicleReleaseYearTextBox";
            this.VehicleReleaseYearTextBox.PlaceholderText = "Год выпуска";
            this.VehicleReleaseYearTextBox.Size = new System.Drawing.Size(226, 23);
            this.VehicleReleaseYearTextBox.TabIndex = 1;
            this.VehicleReleaseYearTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.VehicleReleaseYearTextBox_Validating);
            // 
            // VehicleInitialPriceTextBox
            // 
            this.VehicleInitialPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleInitialPriceTextBox.Location = new System.Drawing.Point(3, 61);
            this.VehicleInitialPriceTextBox.Name = "VehicleInitialPriceTextBox";
            this.VehicleInitialPriceTextBox.PlaceholderText = "Стоимость";
            this.VehicleInitialPriceTextBox.Size = new System.Drawing.Size(226, 23);
            this.VehicleInitialPriceTextBox.TabIndex = 2;
            this.VehicleInitialPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.VehicleInitialPriceTextBox_Validating);
            // 
            // VehicleTypeComboBox
            // 
            this.VehicleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleTypeComboBox.FormattingEnabled = true;
            this.VehicleTypeComboBox.Items.AddRange(new object[] {
            "Легковой автомобиль",
            "Грузовик"});
            this.VehicleTypeComboBox.Location = new System.Drawing.Point(3, 90);
            this.VehicleTypeComboBox.Name = "VehicleTypeComboBox";
            this.VehicleTypeComboBox.Size = new System.Drawing.Size(226, 23);
            this.VehicleTypeComboBox.TabIndex = 3;
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.SortButton);
            this.ControlGroupBox.Controls.Add(this.CopyButton);
            this.ControlGroupBox.Controls.Add(this.DeleteButton);
            this.ControlGroupBox.Controls.Add(this.SaveButton);
            this.ControlGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlGroupBox.Location = new System.Drawing.Point(3, 217);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(238, 135);
            this.ControlGroupBox.TabIndex = 1;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Управление";
            // 
            // SortButton
            // 
            this.SortButton.Enabled = false;
            this.SortButton.Location = new System.Drawing.Point(6, 105);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(226, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Сортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Enabled = false;
            this.CopyButton.Location = new System.Drawing.Point(6, 77);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(226, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Копировать";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(6, 48);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(226, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(6, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(226, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // VehicleGridView
            // 
            this.VehicleGridView.AllowUserToAddRows = false;
            this.VehicleGridView.AllowUserToDeleteRows = false;
            this.VehicleGridView.AllowUserToResizeColumns = false;
            this.VehicleGridView.AllowUserToResizeRows = false;
            this.VehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleGridView.Location = new System.Drawing.Point(3, 3);
            this.VehicleGridView.Name = "VehicleGridView";
            this.VehicleGridView.ReadOnly = true;
            this.VehicleGridView.RowTemplate.Height = 25;
            this.VehicleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehicleGridView.Size = new System.Drawing.Size(428, 355);
            this.VehicleGridView.TabIndex = 2;
            this.VehicleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleGridView_CellClick);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.TableLayoutPanel.Controls.Add(this.VehicleGridView, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.RightTableLayoutPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(684, 361);
            this.TableLayoutPanel.TabIndex = 3;
            // 
            // RightTableLayoutPanel
            // 
            this.RightTableLayoutPanel.ColumnCount = 1;
            this.RightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightTableLayoutPanel.Controls.Add(this.InputGroupBox, 0, 0);
            this.RightTableLayoutPanel.Controls.Add(this.ControlGroupBox, 0, 1);
            this.RightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTableLayoutPanel.Location = new System.Drawing.Point(437, 3);
            this.RightTableLayoutPanel.Name = "RightTableLayoutPanel";
            this.RightTableLayoutPanel.RowCount = 2;
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.28169F));
            this.RightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.71831F));
            this.RightTableLayoutPanel.Size = new System.Drawing.Size(244, 355);
            this.RightTableLayoutPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.TableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.InputGroupBox.ResumeLayout(false);
            this.InputLayoutPanel.ResumeLayout(false);
            this.InputLayoutPanel.PerformLayout();
            this.ControlGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).EndInit();
            this.TableLayoutPanel.ResumeLayout(false);
            this.RightTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.GroupBox InputGroupBox;
	private System.Windows.Forms.GroupBox ControlGroupBox;
	private System.Windows.Forms.DataGridView VehicleGridView;
	private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
	private System.Windows.Forms.TableLayoutPanel RightTableLayoutPanel;
    private System.Windows.Forms.ComboBox VehicleTypeComboBox;
    private System.Windows.Forms.TextBox VehicleInitialPriceTextBox;
    private System.Windows.Forms.TextBox VehicleReleaseYearTextBox;
    private System.Windows.Forms.TextBox VehicleBrandTextBox;
    private System.Windows.Forms.FlowLayoutPanel InputLayoutPanel;
    private System.Windows.Forms.Button SortButton;
    private System.Windows.Forms.Button CopyButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button SaveButton;
}
