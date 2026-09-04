
namespace LTTimer
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonResetPosition;
        private System.Windows.Forms.Button buttonClearSavedPosition;

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
            this.buttonResetPosition = new System.Windows.Forms.Button();
            this.buttonClearSavedPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 613);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSetting";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            // 
            // buttonResetPosition
            // 
            this.buttonResetPosition.Location = new System.Drawing.Point(16, 520);
            this.buttonResetPosition.Name = "buttonResetPosition";
            this.buttonResetPosition.Size = new System.Drawing.Size(200, 40);
            this.buttonResetPosition.TabIndex = 0;
            this.buttonResetPosition.Text = "位置をリセット";
            this.buttonResetPosition.UseVisualStyleBackColor = true;
            this.buttonResetPosition.Click += new System.EventHandler(this.buttonResetPosition_Click);
            // 
            // buttonClearSavedPosition
            // 
            this.buttonClearSavedPosition.Location = new System.Drawing.Point(232, 520);
            this.buttonClearSavedPosition.Name = "buttonClearSavedPosition";
            this.buttonClearSavedPosition.Size = new System.Drawing.Size(200, 40);
            this.buttonClearSavedPosition.TabIndex = 1;
            this.buttonClearSavedPosition.Text = "保存位置をクリア";
            this.buttonClearSavedPosition.UseVisualStyleBackColor = true;
            this.buttonClearSavedPosition.Click += new System.EventHandler(this.buttonClearSavedPosition_Click);

            this.Controls.Add(this.buttonResetPosition);
            this.Controls.Add(this.buttonClearSavedPosition);
            this.ResumeLayout(false);

        }

        #endregion
    }
}