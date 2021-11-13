
namespace Laboratour2
{
    partial class Table
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.checkBoxПІБ = new System.Windows.Forms.CheckBox();
            this.checkBoxФакультет = new System.Windows.Forms.CheckBox();
            this.checkBoxКафедра = new System.Windows.Forms.CheckBox();
            this.checkBoxПредмет = new System.Windows.Forms.CheckBox();
            this.checkBoxОцінка = new System.Windows.Forms.CheckBox();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculties = new System.Windows.Forms.ComboBox();
            this.comboBoxCathedras = new System.Windows.Forms.ComboBox();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.comboBoxMarks = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTrans = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.checkBoxСпеціальність = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(0, 1);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(1273, 353);
            this.Answer.TabIndex = 0;
            this.Answer.Text = "";
            // 
            // checkBoxПІБ
            // 
            this.checkBoxПІБ.AutoSize = true;
            this.checkBoxПІБ.Location = new System.Drawing.Point(12, 373);
            this.checkBoxПІБ.Name = "checkBoxПІБ";
            this.checkBoxПІБ.Size = new System.Drawing.Size(55, 24);
            this.checkBoxПІБ.TabIndex = 2;
            this.checkBoxПІБ.Text = "ПІБ";
            this.checkBoxПІБ.UseVisualStyleBackColor = true;
            // 
            // checkBoxФакультет
            // 
            this.checkBoxФакультет.AutoSize = true;
            this.checkBoxФакультет.Location = new System.Drawing.Point(258, 373);
            this.checkBoxФакультет.Name = "checkBoxФакультет";
            this.checkBoxФакультет.Size = new System.Drawing.Size(100, 24);
            this.checkBoxФакультет.TabIndex = 3;
            this.checkBoxФакультет.Text = "Факультет";
            this.checkBoxФакультет.UseVisualStyleBackColor = true;
            // 
            // checkBoxКафедра
            // 
            this.checkBoxКафедра.AutoSize = true;
            this.checkBoxКафедра.Location = new System.Drawing.Point(572, 373);
            this.checkBoxКафедра.Name = "checkBoxКафедра";
            this.checkBoxКафедра.Size = new System.Drawing.Size(91, 24);
            this.checkBoxКафедра.TabIndex = 4;
            this.checkBoxКафедра.Text = "Кафедра";
            this.checkBoxКафедра.UseVisualStyleBackColor = true;
            // 
            // checkBoxПредмет
            // 
            this.checkBoxПредмет.AutoSize = true;
            this.checkBoxПредмет.Location = new System.Drawing.Point(729, 373);
            this.checkBoxПредмет.Name = "checkBoxПредмет";
            this.checkBoxПредмет.Size = new System.Drawing.Size(92, 24);
            this.checkBoxПредмет.TabIndex = 5;
            this.checkBoxПредмет.Text = "Предмет";
            this.checkBoxПредмет.UseVisualStyleBackColor = true;
            // 
            // checkBoxОцінка
            // 
            this.checkBoxОцінка.AutoSize = true;
            this.checkBoxОцінка.Location = new System.Drawing.Point(886, 373);
            this.checkBoxОцінка.Name = "checkBoxОцінка";
            this.checkBoxОцінка.Size = new System.Drawing.Size(79, 24);
            this.checkBoxОцінка.TabIndex = 6;
            this.checkBoxОцінка.Text = "Оцінка";
            this.checkBoxОцінка.UseVisualStyleBackColor = true;
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Location = new System.Drawing.Point(12, 426);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(240, 28);
            this.comboBoxNames.TabIndex = 7;
            // 
            // comboBoxFaculties
            // 
            this.comboBoxFaculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculties.FormattingEnabled = true;
            this.comboBoxFaculties.Location = new System.Drawing.Point(258, 426);
            this.comboBoxFaculties.Name = "comboBoxFaculties";
            this.comboBoxFaculties.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFaculties.TabIndex = 8;
            // 
            // comboBoxCathedras
            // 
            this.comboBoxCathedras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCathedras.FormattingEnabled = true;
            this.comboBoxCathedras.Location = new System.Drawing.Point(572, 427);
            this.comboBoxCathedras.Name = "comboBoxCathedras";
            this.comboBoxCathedras.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCathedras.TabIndex = 9;
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(729, 426);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSubjects.TabIndex = 10;
            // 
            // comboBoxMarks
            // 
            this.comboBoxMarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarks.FormattingEnabled = true;
            this.comboBoxMarks.Location = new System.Drawing.Point(886, 426);
            this.comboBoxMarks.Name = "comboBoxMarks";
            this.comboBoxMarks.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMarks.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1153, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTrans
            // 
            this.buttonTrans.Location = new System.Drawing.Point(1136, 426);
            this.buttonTrans.Name = "buttonTrans";
            this.buttonTrans.Size = new System.Drawing.Size(126, 29);
            this.buttonTrans.TabIndex = 13;
            this.buttonTrans.Text = "Трансформація";
            this.buttonTrans.UseVisualStyleBackColor = true;
            this.buttonTrans.Click += new System.EventHandler(this.buttonTrans_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1153, 477);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(277, 484);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.radioButtonDOM.TabIndex = 15;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(348, 484);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonSAX.TabIndex = 16;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(421, 484);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(114, 24);
            this.radioButtonLINQ.TabIndex = 17;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ to XML";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.Location = new System.Drawing.Point(415, 427);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSpeciality.TabIndex = 18;
            // 
            // checkBoxСпеціальність
            // 
            this.checkBoxСпеціальність.AutoSize = true;
            this.checkBoxСпеціальність.Location = new System.Drawing.Point(421, 373);
            this.checkBoxСпеціальність.Name = "checkBoxСпеціальність";
            this.checkBoxСпеціальність.Size = new System.Drawing.Size(128, 24);
            this.checkBoxСпеціальність.TabIndex = 19;
            this.checkBoxСпеціальність.Text = "Спеціальність";
            this.checkBoxСпеціальність.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 518);
            this.Controls.Add(this.checkBoxСпеціальність);
            this.Controls.Add(this.comboBoxSpeciality);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTrans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxMarks);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.comboBoxCathedras);
            this.Controls.Add(this.comboBoxFaculties);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.checkBoxОцінка);
            this.Controls.Add(this.checkBoxПредмет);
            this.Controls.Add(this.checkBoxКафедра);
            this.Controls.Add(this.checkBoxФакультет);
            this.Controls.Add(this.checkBoxПІБ);
            this.Controls.Add(this.Answer);
            this.Name = "Table";
            this.Text = "InfoSearch";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Table_FormClosing);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.CheckBox checkBoxПІБ;
        private System.Windows.Forms.CheckBox checkBoxФакультет;
        private System.Windows.Forms.CheckBox checkBoxКафедра;
        private System.Windows.Forms.CheckBox checkBoxПредмет;
        private System.Windows.Forms.CheckBox checkBoxОцінка;
        private System.Windows.Forms.ComboBox comboBoxNames;
        private System.Windows.Forms.ComboBox comboBoxFaculties;
        private System.Windows.Forms.ComboBox comboBoxCathedras;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.ComboBox comboBoxMarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTrans;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.ComboBox comboBoxSpeciality;
        private System.Windows.Forms.CheckBox checkBoxСпеціальність;
    }
}

