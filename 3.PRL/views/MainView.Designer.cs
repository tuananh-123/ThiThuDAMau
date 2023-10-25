namespace _3.PRL.views
{
    partial class MainView
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
            dataGridViewNV=new DataGridView();
            textBox_ID=new TextBox();
            label1=new Label();
            label2=new Label();
            textBox_DiaChi=new TextBox();
            label3=new Label();
            textBox_NTD=new TextBox();
            label4=new Label();
            textBox_Ten=new TextBox();
            label5=new Label();
            textBox_SDT=new TextBox();
            button_Add=new Button();
            textBox_Search=new TextBox();
            button_Search=new Button();
            button_Save=new Button();
            button_Cancel=new Button();
            button_Show=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNV).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNV
            // 
            dataGridViewNV.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dataGridViewNV.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNV.Location=new Point(12, 288);
            dataGridViewNV.Name="dataGridViewNV";
            dataGridViewNV.RowTemplate.Height=25;
            dataGridViewNV.Size=new Size(561, 150);
            dataGridViewNV.TabIndex=0;
            // 
            // textBox_ID
            // 
            textBox_ID.Location=new Point(12, 29);
            textBox_ID.Name="textBox_ID";
            textBox_ID.Size=new Size(176, 23);
            textBox_ID.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(20, 15);
            label1.TabIndex=2;
            label1.Text="ID";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(12, 66);
            label2.Name="label2";
            label2.Size=new Size(44, 15);
            label2.TabIndex=4;
            label2.Text="Địa chỉ";
            // 
            // textBox_DiaChi
            // 
            textBox_DiaChi.Location=new Point(12, 86);
            textBox_DiaChi.Name="textBox_DiaChi";
            textBox_DiaChi.Size=new Size(176, 23);
            textBox_DiaChi.TabIndex=3;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(12, 128);
            label3.Name="label3";
            label3.Size=new Size(101, 15);
            label3.TabIndex=6;
            label3.Text="Ngày tuyển dụng";
            // 
            // textBox_NTD
            // 
            textBox_NTD.Location=new Point(12, 148);
            textBox_NTD.Name="textBox_NTD";
            textBox_NTD.Size=new Size(176, 23);
            textBox_NTD.TabIndex=5;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(223, 9);
            label4.Name="label4";
            label4.Size=new Size(27, 15);
            label4.TabIndex=8;
            label4.Text="Tên";
            // 
            // textBox_Ten
            // 
            textBox_Ten.Location=new Point(223, 29);
            textBox_Ten.Name="textBox_Ten";
            textBox_Ten.Size=new Size(176, 23);
            textBox_Ten.TabIndex=7;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(223, 66);
            label5.Name="label5";
            label5.Size=new Size(80, 15);
            label5.TabIndex=10;
            label5.Text="Số điện thoại";
            // 
            // textBox_SDT
            // 
            textBox_SDT.Location=new Point(223, 86);
            textBox_SDT.Name="textBox_SDT";
            textBox_SDT.Size=new Size(176, 23);
            textBox_SDT.TabIndex=9;
            // 
            // button_Add
            // 
            button_Add.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            button_Add.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Add.Location=new Point(12, 246);
            button_Add.Name="button_Add";
            button_Add.Size=new Size(129, 36);
            button_Add.TabIndex=11;
            button_Add.Text="+ Thêm mới";
            button_Add.UseVisualStyleBackColor=true;
            // 
            // textBox_Search
            // 
            textBox_Search.Anchor=AnchorStyles.Top|AnchorStyles.Right;
            textBox_Search.Font=new Font("Segoe UI", 15.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Search.Location=new Point(316, 247);
            textBox_Search.Name="textBox_Search";
            textBox_Search.PlaceholderText="Nhập từ khóa...";
            textBox_Search.Size=new Size(147, 35);
            textBox_Search.TabIndex=12;
            // 
            // button_Search
            // 
            button_Search.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Right;
            button_Search.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Search.Location=new Point(469, 246);
            button_Search.Name="button_Search";
            button_Search.Size=new Size(104, 35);
            button_Search.TabIndex=13;
            button_Search.Text="Tìm kiếm";
            button_Search.UseVisualStyleBackColor=true;
            // 
            // button_Save
            // 
            button_Save.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Save.Location=new Point(491, 23);
            button_Save.Name="button_Save";
            button_Save.Size=new Size(82, 32);
            button_Save.TabIndex=14;
            button_Save.Text="Lưu";
            button_Save.UseVisualStyleBackColor=true;
            // 
            // button_Cancel
            // 
            button_Cancel.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancel.Location=new Point(491, 74);
            button_Cancel.Name="button_Cancel";
            button_Cancel.Size=new Size(82, 35);
            button_Cancel.TabIndex=15;
            button_Cancel.Text="Hủy";
            button_Cancel.UseVisualStyleBackColor=true;
            // 
            // button_Show
            // 
            button_Show.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            button_Show.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Show.Location=new Point(12, 204);
            button_Show.Name="button_Show";
            button_Show.Size=new Size(129, 36);
            button_Show.TabIndex=16;
            button_Show.Text="Show";
            button_Show.UseVisualStyleBackColor=true;
            // 
            // MainView
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(595, 450);
            Controls.Add(button_Show);
            Controls.Add(button_Cancel);
            Controls.Add(button_Save);
            Controls.Add(button_Search);
            Controls.Add(textBox_Search);
            Controls.Add(button_Add);
            Controls.Add(label5);
            Controls.Add(textBox_SDT);
            Controls.Add(label4);
            Controls.Add(textBox_Ten);
            Controls.Add(label3);
            Controls.Add(textBox_NTD);
            Controls.Add(label2);
            Controls.Add(textBox_DiaChi);
            Controls.Add(label1);
            Controls.Add(textBox_ID);
            Controls.Add(dataGridViewNV);
            Name="MainView";
            Text="MainView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewNV;
        private TextBox textBox_ID;
        private Label label1;
        private Label label2;
        private TextBox textBox_DiaChi;
        private Label label3;
        private TextBox textBox_NTD;
        private Label label4;
        private TextBox textBox_Ten;
        private Label label5;
        private TextBox textBox_SDT;
        private Button button_Add;
        private TextBox textBox_Search;
        private Button button_Search;
        private Button button_Save;
        private Button button_Cancel;
        private Button button_Show;
    }
}