
namespace DemoQuiz
{
    partial class frmCreateQuiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtExamID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grboxQuiz = new System.Windows.Forms.GroupBox();
            this.grBoxAnswer = new System.Windows.Forms.GroupBox();
            this.c = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.d = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.RadioButton();
            this.txtQuiz3 = new System.Windows.Forms.TextBox();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.txtQuiz4 = new System.Windows.Forms.TextBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddQuiz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuizName = new System.Windows.Forms.TextBox();
            this.lblNumberQuiz = new System.Windows.Forms.Label();
            this.lblAllQuantityQuiz = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAllQuiz = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grboxQuiz.SuspendLayout();
            this.grBoxAnswer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠO CÂU HỎI";
            // 
            // txtExamName
            // 
            this.txtExamName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExamName.Enabled = false;
            this.txtExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtExamName.Location = new System.Drawing.Point(235, 110);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(559, 24);
            this.txtExamName.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(232, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tên kỳ thi:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTeacher.Enabled = false;
            this.txtTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTeacher.Location = new System.Drawing.Point(854, 110);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(305, 24);
            this.txtTeacher.TabIndex = 35;
            // 
            // txtExamID
            // 
            this.txtExamID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExamID.Enabled = false;
            this.txtExamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtExamID.Location = new System.Drawing.Point(56, 110);
            this.txtExamID.Name = "txtExamID";
            this.txtExamID.Size = new System.Drawing.Size(137, 24);
            this.txtExamID.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(851, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Giáo viên tạo đề:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã kỳ thi:";
            // 
            // grboxQuiz
            // 
            this.grboxQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grboxQuiz.Controls.Add(this.grBoxAnswer);
            this.grboxQuiz.Controls.Add(this.btnUpdate);
            this.grboxQuiz.Controls.Add(this.btnQuit);
            this.grboxQuiz.Controls.Add(this.btnReset);
            this.grboxQuiz.Controls.Add(this.btnAddQuiz);
            this.grboxQuiz.Controls.Add(this.label6);
            this.grboxQuiz.Controls.Add(this.txtQuizName);
            this.grboxQuiz.Controls.Add(this.lblNumberQuiz);
            this.grboxQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grboxQuiz.Location = new System.Drawing.Point(12, 172);
            this.grboxQuiz.Name = "grboxQuiz";
            this.grboxQuiz.Size = new System.Drawing.Size(793, 379);
            this.grboxQuiz.TabIndex = 38;
            this.grboxQuiz.TabStop = false;
            this.grboxQuiz.Text = "Câu hỏi";
            // 
            // grBoxAnswer
            // 
            this.grBoxAnswer.Controls.Add(this.c);
            this.grBoxAnswer.Controls.Add(this.b);
            this.grBoxAnswer.Controls.Add(this.d);
            this.grBoxAnswer.Controls.Add(this.a);
            this.grBoxAnswer.Controls.Add(this.txtQuiz3);
            this.grBoxAnswer.Controls.Add(this.txtQuiz1);
            this.grBoxAnswer.Controls.Add(this.txtQuiz4);
            this.grBoxAnswer.Controls.Add(this.txtQuiz2);
            this.grBoxAnswer.Location = new System.Drawing.Point(30, 159);
            this.grBoxAnswer.Name = "grBoxAnswer";
            this.grBoxAnswer.Size = new System.Drawing.Size(751, 136);
            this.grBoxAnswer.TabIndex = 74;
            this.grBoxAnswer.TabStop = false;
            this.grBoxAnswer.Text = "Các câu trả lời";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(336, 94);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(17, 16);
            this.c.TabIndex = 73;
            this.c.TabStop = true;
            this.c.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(728, 27);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(17, 16);
            this.b.TabIndex = 72;
            this.b.TabStop = true;
            this.b.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(728, 94);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(17, 16);
            this.d.TabIndex = 71;
            this.d.TabStop = true;
            this.d.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(336, 27);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(17, 16);
            this.a.TabIndex = 70;
            this.a.TabStop = true;
            this.a.UseVisualStyleBackColor = true;
            // 
            // txtQuiz3
            // 
            this.txtQuiz3.Location = new System.Drawing.Point(8, 90);
            this.txtQuiz3.Multiline = true;
            this.txtQuiz3.Name = "txtQuiz3";
            this.txtQuiz3.Size = new System.Drawing.Size(321, 24);
            this.txtQuiz3.TabIndex = 69;
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Location = new System.Drawing.Point(8, 23);
            this.txtQuiz1.Multiline = true;
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(321, 24);
            this.txtQuiz1.TabIndex = 68;
            // 
            // txtQuiz4
            // 
            this.txtQuiz4.Location = new System.Drawing.Point(401, 90);
            this.txtQuiz4.Multiline = true;
            this.txtQuiz4.Name = "txtQuiz4";
            this.txtQuiz4.Size = new System.Drawing.Size(321, 24);
            this.txtQuiz4.TabIndex = 58;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Location = new System.Drawing.Point(401, 23);
            this.txtQuiz2.Multiline = true;
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(321, 24);
            this.txtQuiz2.TabIndex = 57;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(431, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 33);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Cập nhập";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuit.Location = new System.Drawing.Point(38, 319);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(145, 33);
            this.btnQuit.TabIndex = 62;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Location = new System.Drawing.Point(238, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 33);
            this.btnReset.TabIndex = 61;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddQuiz.Location = new System.Drawing.Point(631, 319);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(145, 33);
            this.btnAddQuiz.TabIndex = 60;
            this.btnAddQuiz.Text = "Thêm câu hỏi";
            this.btnAddQuiz.UseVisualStyleBackColor = true;
            this.btnAddQuiz.Click += new System.EventHandler(this.btnAddQuiz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tên câu hỏi:";
            // 
            // txtQuizName
            // 
            this.txtQuizName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuizName.Location = new System.Drawing.Point(38, 99);
            this.txtQuizName.Multiline = true;
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(738, 24);
            this.txtQuizName.TabIndex = 53;
            // 
            // lblNumberQuiz
            // 
            this.lblNumberQuiz.AutoSize = true;
            this.lblNumberQuiz.Location = new System.Drawing.Point(16, 27);
            this.lblNumberQuiz.Name = "lblNumberQuiz";
            this.lblNumberQuiz.Size = new System.Drawing.Size(96, 18);
            this.lblNumberQuiz.TabIndex = 52;
            this.lblNumberQuiz.Text = "Câu hỏi số: 0";
            // 
            // lblAllQuantityQuiz
            // 
            this.lblAllQuantityQuiz.AutoSize = true;
            this.lblAllQuantityQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAllQuantityQuiz.Location = new System.Drawing.Point(644, 151);
            this.lblAllQuantityQuiz.Name = "lblAllQuantityQuiz";
            this.lblAllQuantityQuiz.Size = new System.Drawing.Size(161, 18);
            this.lblAllQuantityQuiz.TabIndex = 39;
            this.lblAllQuantityQuiz.Text = "Số câu hỏi trong đề: 10";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvAllQuiz);
            this.groupBox2.Location = new System.Drawing.Point(817, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 378);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất cả câu hỏi";
            // 
            // dgvAllQuiz
            // 
            this.dgvAllQuiz.AllowUserToAddRows = false;
            this.dgvAllQuiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Content});
            this.dgvAllQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllQuiz.Location = new System.Drawing.Point(3, 18);
            this.dgvAllQuiz.Name = "dgvAllQuiz";
            this.dgvAllQuiz.RowHeadersWidth = 51;
            this.dgvAllQuiz.RowTemplate.Height = 24;
            this.dgvAllQuiz.Size = new System.Drawing.Size(374, 357);
            this.dgvAllQuiz.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Câu số";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 80;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Content.HeaderText = "Nội dung câu hỏi";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            // 
            // frmCreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAllQuantityQuiz);
            this.Controls.Add(this.grboxQuiz);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtExamID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateQuiz";
            this.Text = "frmCreateQuiz";
            this.Load += new System.EventHandler(this.frmCreateQuiz_Load);
            this.grboxQuiz.ResumeLayout(false);
            this.grboxQuiz.PerformLayout();
            this.grBoxAnswer.ResumeLayout(false);
            this.grBoxAnswer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtExamID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grboxQuiz;
        private System.Windows.Forms.Label lblAllQuantityQuiz;
        private System.Windows.Forms.TextBox txtQuiz3;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddQuiz;
        private System.Windows.Forms.TextBox txtQuiz4;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuizName;
        private System.Windows.Forms.Label lblNumberQuiz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAllQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.GroupBox grBoxAnswer;
    }
}