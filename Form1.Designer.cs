namespace BrownianMotion
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
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.temperatureInput = new System.Windows.Forms.TrackBar();
            this.numberField = new System.Windows.Forms.NumericUpDown();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberField)).BeginInit();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.White;
            this.drawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawBox.Location = new System.Drawing.Point(12, 12);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(600, 400);
            this.drawBox.TabIndex = 0;
            this.drawBox.TabStop = false;
            // 
            // temperatureInput
            // 
            this.temperatureInput.LargeChange = 50;
            this.temperatureInput.Location = new System.Drawing.Point(678, 69);
            this.temperatureInput.Maximum = 1000;
            this.temperatureInput.Name = "temperatureInput";
            this.temperatureInput.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.temperatureInput.Size = new System.Drawing.Size(45, 347);
            this.temperatureInput.SmallChange = 10;
            this.temperatureInput.TabIndex = 1;
            this.temperatureInput.ValueChanged += new System.EventHandler(this.temperatureInput_ValueChanged);
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(626, 12);
            this.numberField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(146, 22);
            this.numberField.TabIndex = 2;
            this.numberField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(626, 40);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(146, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Смоделировать";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 426);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.temperatureInput);
            this.Controls.Add(this.drawBox);
            this.MaximumSize = new System.Drawing.Size(800, 465);
            this.MinimumSize = new System.Drawing.Size(800, 465);
            this.Name = "Form1";
            this.Text = "Brownian motion";
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.TrackBar temperatureInput;
        private System.Windows.Forms.NumericUpDown numberField;
        private System.Windows.Forms.Button refreshButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

