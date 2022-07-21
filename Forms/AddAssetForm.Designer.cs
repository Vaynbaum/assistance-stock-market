
namespace coursework.Forms
{
    partial class AddAssetForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.selectAssetListView = new System.Windows.Forms.ListView();
            this.filterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(566, 575);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 48);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "&Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.White;
            this.warningLabel.Location = new System.Drawing.Point(266, 9);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(200, 29);
            this.warningLabel.TabIndex = 8;
            this.warningLabel.Text = "Выберите актив";
            this.warningLabel.Visible = false;
            // 
            // selectAssetListView
            // 
            this.selectAssetListView.FullRowSelect = true;
            this.selectAssetListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.selectAssetListView.HideSelection = false;
            this.selectAssetListView.Location = new System.Drawing.Point(12, 53);
            this.selectAssetListView.MultiSelect = false;
            this.selectAssetListView.Name = "selectAssetListView";
            this.selectAssetListView.Size = new System.Drawing.Size(701, 516);
            this.selectAssetListView.TabIndex = 9;
            this.selectAssetListView.UseCompatibleStateImageBehavior = false;
            this.selectAssetListView.View = System.Windows.Forms.View.Details;
            // 
            // filterButton
            // 
            this.filterButton.Enabled = false;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(12, 575);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(183, 48);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "&Фильтрация";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // AddAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 635);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.selectAssetListView);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.addButton);
            this.Name = "AddAssetForm";
            this.Text = "Добавить актив";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.ListView selectAssetListView;
        private System.Windows.Forms.Button filterButton;
    }
}