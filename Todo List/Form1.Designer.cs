
namespace Todo_List
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.deleteItems = new System.Windows.Forms.Button();
            this.checkAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddTaskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskBtn.Location = new System.Drawing.Point(637, 380);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(223, 38);
            this.AddTaskBtn.TabIndex = 0;
            this.AddTaskBtn.Text = "Add Task";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(111, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(111, 41);
            this.checkedListBox1.MaximumSize = new System.Drawing.Size(1000, 600);
            this.checkedListBox1.MinimumSize = new System.Drawing.Size(749, 317);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(749, 317);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // deleteItems
            // 
            this.deleteItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteItems.Location = new System.Drawing.Point(111, 424);
            this.deleteItems.Name = "deleteItems";
            this.deleteItems.Size = new System.Drawing.Size(749, 49);
            this.deleteItems.TabIndex = 5;
            this.deleteItems.Text = "Delete checked items";
            this.deleteItems.UseVisualStyleBackColor = true;
            this.deleteItems.Click += new System.EventHandler(this.deleteItems_Click);
            // 
            // checkAllBtn
            // 
            this.checkAllBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAllBtn.Location = new System.Drawing.Point(111, 2);
            this.checkAllBtn.Name = "checkAllBtn";
            this.checkAllBtn.Size = new System.Drawing.Size(136, 37);
            this.checkAllBtn.TabIndex = 6;
            this.checkAllBtn.Text = "Check all";
            this.checkAllBtn.UseVisualStyleBackColor = true;
            this.checkAllBtn.Click += new System.EventHandler(this.checkAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 486);
            this.Controls.Add(this.checkAllBtn);
            this.Controls.Add(this.deleteItems);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddTaskBtn);
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TODO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button deleteItems;
        private System.Windows.Forms.Button checkAllBtn;
    }
}

