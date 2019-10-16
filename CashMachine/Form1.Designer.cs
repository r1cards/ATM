namespace CashMachine
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
            this.InsertCardImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertCardImage
            // 
            this.InsertCardImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertCardImage.AutoSize = true;
            this.InsertCardImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.InsertCardImage.BackgroundImage = global::CashMachine.Properties.Resources.Insert_Cardd1;
            this.InsertCardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InsertCardImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertCardImage.Location = new System.Drawing.Point(267, 227);
            this.InsertCardImage.Name = "InsertCardImage";
            this.InsertCardImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsertCardImage.Size = new System.Drawing.Size(739, 664);
            this.InsertCardImage.TabIndex = 0;
            this.InsertCardImage.Text = " ";
            this.InsertCardImage.UseVisualStyleBackColor = false;
            this.InsertCardImage.Click += new System.EventHandler(this.InsertCardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1274, 1018);
            this.ControlBox = false;
            this.Controls.Add(this.InsertCardImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InsertCardScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertCardImage;
    }
}

