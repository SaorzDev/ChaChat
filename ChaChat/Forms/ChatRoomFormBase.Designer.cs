
namespace ChaChat.Forms
{
    partial class ChatRoomFormBase
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
            this.txtChat = new MetroFramework.Controls.MetroTextBox();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            // 
            // 
            // 
            this.txtChat.CustomButton.Image = null;
            this.txtChat.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.txtChat.CustomButton.Name = "";
            this.txtChat.CustomButton.Size = new System.Drawing.Size(341, 341);
            this.txtChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChat.CustomButton.TabIndex = 1;
            this.txtChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChat.CustomButton.UseSelectable = true;
            this.txtChat.CustomButton.Visible = false;
            this.txtChat.Lines = new string[0];
            this.txtChat.Location = new System.Drawing.Point(23, 63);
            this.txtChat.MaxLength = 32767;
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.PasswordChar = '\0';
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChat.SelectedText = "";
            this.txtChat.SelectionLength = 0;
            this.txtChat.SelectionStart = 0;
            this.txtChat.ShortcutsEnabled = true;
            this.txtChat.Size = new System.Drawing.Size(754, 343);
            this.txtChat.TabIndex = 0;
            this.txtChat.UseSelectable = true;
            this.txtChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(702, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "終了";
            this.btnExit.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(656, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(23, 412);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(678, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(702, 412);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "送信";
            this.metroButton1.UseSelectable = true;
            // 
            // ChatRoomFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtChat);
            this.Name = "ChatRoomFormBase";
            this.Text = "ChatRoomForm";
            this.ResumeLayout(false);

        }

        #endregion
        protected MetroFramework.Controls.MetroTextBox txtChat;
        protected MetroFramework.Controls.MetroButton btnExit;
        protected MetroFramework.Controls.MetroTextBox metroTextBox1;
        protected MetroFramework.Controls.MetroButton metroButton1;
    }
}