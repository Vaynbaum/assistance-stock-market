
namespace coursework.Forms
{
    partial class AddMarketForm
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
            this.filterButton = new System.Windows.Forms.Button();
            this.selectMarketListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(561, 486);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 48);
            this.addButton.TabIndex = 0;
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
            this.warningLabel.Location = new System.Drawing.Point(267, 9);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(207, 29);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "Выберите биржу";
            this.warningLabel.Visible = false;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(12, 486);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(183, 48);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "&Фильтрация";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // selectMarketListView
            // 
            this.selectMarketListView.FullRowSelect = true;
            this.selectMarketListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.selectMarketListView.HideSelection = false;
            this.selectMarketListView.Location = new System.Drawing.Point(12, 54);
            this.selectMarketListView.MultiSelect = false;
            this.selectMarketListView.Name = "selectMarketListView";
            this.selectMarketListView.Size = new System.Drawing.Size(696, 426);
            this.selectMarketListView.TabIndex = 4;
            this.selectMarketListView.UseCompatibleStateImageBehavior = false;
            this.selectMarketListView.View = System.Windows.Forms.View.Details;
            this.selectMarketListView.Click += new System.EventHandler(this.selectMarketListView_Click);
            // 
            // AddMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 546);
            this.Controls.Add(this.selectMarketListView);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.addButton);
            this.Name = "AddMarketForm";
            this.Text = "Добавить биржу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ListView selectMarketListView;
    }
}