namespace project1
{
    partial class banan
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
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(322, 411);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(373, 20);
            this.txtNewItem.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(375, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(276, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить задачу";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1038, 349);
            this.checkedListBox1.TabIndex = 4;
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(375, 478);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(276, 35);
            this.btnShowSelected.TabIndex = 5;
            this.btnShowSelected.Text = "Получить задачу";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите задачу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // banan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewItem);
            this.Name = "banan";
            this.Text = "banan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.Label label1;
    }
}