using System.Windows.Forms;

namespace XParser
{
    partial class ParserForm : Form
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
            this.Filters = new System.Windows.Forms.Panel();
            this.SaxRadioButton = new System.Windows.Forms.RadioButton();
            this.DomRadioButton = new System.Windows.Forms.RadioButton();
            this.LinqRadioButton = new System.Windows.Forms.RadioButton();
            this.FiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateFilter = new System.Windows.Forms.ComboBox();
            this.TransformButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.CathedraLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TopicFilter = new System.Windows.Forms.ComboBox();
            this.CathedraFilter = new System.Windows.Forms.ComboBox();
            this.FacultyFilter = new System.Windows.Forms.ComboBox();
            this.MiddleNameFilter = new System.Windows.Forms.ComboBox();
            this.FirstNameFilter = new System.Windows.Forms.ComboBox();
            this.LastNameFilter = new System.Windows.Forms.ComboBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.Filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filters
            // 
            this.Filters.BackColor = System.Drawing.Color.LightYellow;
            this.Filters.Controls.Add(this.SaxRadioButton);
            this.Filters.Controls.Add(this.DomRadioButton);
            this.Filters.Controls.Add(this.LinqRadioButton);
            this.Filters.Controls.Add(this.FiltersCheckBox);
            this.Filters.Controls.Add(this.DateLabel);
            this.Filters.Controls.Add(this.DateFilter);
            this.Filters.Controls.Add(this.TransformButton);
            this.Filters.Controls.Add(this.SearchButton);
            this.Filters.Controls.Add(this.TopicLabel);
            this.Filters.Controls.Add(this.CathedraLabel);
            this.Filters.Controls.Add(this.FacultyLabel);
            this.Filters.Controls.Add(this.MiddleNameLabel);
            this.Filters.Controls.Add(this.FirstNameLabel);
            this.Filters.Controls.Add(this.TopicFilter);
            this.Filters.Controls.Add(this.CathedraFilter);
            this.Filters.Controls.Add(this.FacultyFilter);
            this.Filters.Controls.Add(this.MiddleNameFilter);
            this.Filters.Controls.Add(this.FirstNameFilter);
            this.Filters.Controls.Add(this.LastNameFilter);
            this.Filters.Controls.Add(this.LastNameLabel);
            this.Filters.Dock = System.Windows.Forms.DockStyle.Left;
            this.Filters.Location = new System.Drawing.Point(0, 0);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(410, 691);
            this.Filters.TabIndex = 0;
            // 
            // SaxRadioButton
            // 
            this.SaxRadioButton.AutoSize = true;
            this.SaxRadioButton.Location = new System.Drawing.Point(201, 376);
            this.SaxRadioButton.Name = "SaxRadioButton";
            this.SaxRadioButton.Size = new System.Drawing.Size(64, 29);
            this.SaxRadioButton.TabIndex = 8;
            this.SaxRadioButton.TabStop = true;
            this.SaxRadioButton.Text = "Sax";
            this.SaxRadioButton.UseVisualStyleBackColor = true;
            this.SaxRadioButton.CheckedChanged += new System.EventHandler(this.SaxRadioButton_CheckedChanged);
            // 
            // DomRadioButton
            // 
            this.DomRadioButton.AutoSize = true;
            this.DomRadioButton.Location = new System.Drawing.Point(112, 376);
            this.DomRadioButton.Name = "DomRadioButton";
            this.DomRadioButton.Size = new System.Drawing.Size(77, 29);
            this.DomRadioButton.TabIndex = 7;
            this.DomRadioButton.TabStop = true;
            this.DomRadioButton.Text = "Dom";
            this.DomRadioButton.UseVisualStyleBackColor = true;
            this.DomRadioButton.CheckedChanged += new System.EventHandler(this.DomRadioButton_CheckedChanged);
            // 
            // LinqRadioButton
            // 
            this.LinqRadioButton.AutoSize = true;
            this.LinqRadioButton.Location = new System.Drawing.Point(24, 376);
            this.LinqRadioButton.Name = "LinqRadioButton";
            this.LinqRadioButton.Size = new System.Drawing.Size(70, 29);
            this.LinqRadioButton.TabIndex = 6;
            this.LinqRadioButton.TabStop = true;
            this.LinqRadioButton.Text = "Linq";
            this.LinqRadioButton.UseVisualStyleBackColor = true;
            this.LinqRadioButton.CheckedChanged += new System.EventHandler(this.LinqRadioButton_CheckedChanged);
            // 
            // FiltersCheckBox
            // 
            this.FiltersCheckBox.AutoSize = true;
            this.FiltersCheckBox.Location = new System.Drawing.Point(12, 323);
            this.FiltersCheckBox.Name = "FiltersCheckBox";
            this.FiltersCheckBox.Size = new System.Drawing.Size(101, 29);
            this.FiltersCheckBox.TabIndex = 5;
            this.FiltersCheckBox.Text = "Фільтри";
            this.FiltersCheckBox.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 270);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(49, 25);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Дата";
            // 
            // DateFilter
            // 
            this.DateFilter.FormattingEnabled = true;
            this.DateFilter.Location = new System.Drawing.Point(130, 267);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(248, 33);
            this.DateFilter.TabIndex = 1;
            // 
            // TransformButton
            // 
            this.TransformButton.BackColor = System.Drawing.Color.Ivory;
            this.TransformButton.Location = new System.Drawing.Point(201, 455);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(177, 67);
            this.TransformButton.TabIndex = 3;
            this.TransformButton.Text = "Трасформувати в HTML";
            this.TransformButton.UseVisualStyleBackColor = false;
            this.TransformButton.Click += new System.EventHandler(this.TransformButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Ivory;
            this.SearchButton.Location = new System.Drawing.Point(12, 455);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(177, 67);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Location = new System.Drawing.Point(12, 231);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(52, 25);
            this.TopicLabel.TabIndex = 0;
            this.TopicLabel.Text = "Тема";
            // 
            // CathedraLabel
            // 
            this.CathedraLabel.AutoSize = true;
            this.CathedraLabel.Location = new System.Drawing.Point(12, 192);
            this.CathedraLabel.Name = "CathedraLabel";
            this.CathedraLabel.Size = new System.Drawing.Size(82, 25);
            this.CathedraLabel.TabIndex = 0;
            this.CathedraLabel.Text = "Кафедра";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(12, 153);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(93, 25);
            this.FacultyLabel.TabIndex = 0;
            this.FacultyLabel.Text = "Факультет";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(12, 114);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(112, 25);
            this.MiddleNameLabel.TabIndex = 0;
            this.MiddleNameLabel.Text = "По-батькові";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 75);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(43, 25);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Ім\'я";
            // 
            // TopicFilter
            // 
            this.TopicFilter.FormattingEnabled = true;
            this.TopicFilter.Location = new System.Drawing.Point(130, 228);
            this.TopicFilter.Name = "TopicFilter";
            this.TopicFilter.Size = new System.Drawing.Size(248, 33);
            this.TopicFilter.TabIndex = 1;
            // 
            // CathedraFilter
            // 
            this.CathedraFilter.FormattingEnabled = true;
            this.CathedraFilter.Location = new System.Drawing.Point(130, 189);
            this.CathedraFilter.Name = "CathedraFilter";
            this.CathedraFilter.Size = new System.Drawing.Size(248, 33);
            this.CathedraFilter.TabIndex = 1;
            // 
            // FacultyFilter
            // 
            this.FacultyFilter.FormattingEnabled = true;
            this.FacultyFilter.Location = new System.Drawing.Point(130, 150);
            this.FacultyFilter.Name = "FacultyFilter";
            this.FacultyFilter.Size = new System.Drawing.Size(248, 33);
            this.FacultyFilter.TabIndex = 1;
            // 
            // MiddleNameFilter
            // 
            this.MiddleNameFilter.FormattingEnabled = true;
            this.MiddleNameFilter.Location = new System.Drawing.Point(130, 111);
            this.MiddleNameFilter.Name = "MiddleNameFilter";
            this.MiddleNameFilter.Size = new System.Drawing.Size(248, 33);
            this.MiddleNameFilter.TabIndex = 1;
            // 
            // FirstNameFilter
            // 
            this.FirstNameFilter.FormattingEnabled = true;
            this.FirstNameFilter.Location = new System.Drawing.Point(130, 72);
            this.FirstNameFilter.Name = "FirstNameFilter";
            this.FirstNameFilter.Size = new System.Drawing.Size(248, 33);
            this.FirstNameFilter.TabIndex = 1;
            // 
            // LastNameFilter
            // 
            this.LastNameFilter.FormattingEnabled = true;
            this.LastNameFilter.Location = new System.Drawing.Point(130, 33);
            this.LastNameFilter.Name = "LastNameFilter";
            this.LastNameFilter.Size = new System.Drawing.Size(248, 33);
            this.LastNameFilter.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 36);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(92, 25);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Прізвище";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.Ivory;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.Location = new System.Drawing.Point(410, 0);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(670, 691);
            this.OutputTextBox.TabIndex = 1;
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 691);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Filters);
            this.Name = "ParserForm";
            this.Text = "Parser";
            this.Filters.ResumeLayout(false);
            this.Filters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Filters;
        private Label TopicLabel;
        private Label CathedraLabel;
        private Label FacultyLabel;
        private Label MiddleNameLabel;
        private Label FirstNameLabel;
        private ComboBox TopicFilter;
        private ComboBox CathedraFilter;
        private ComboBox FacultyFilter;
        private ComboBox MiddleNameFilter;
        private ComboBox FirstNameFilter;
        private ComboBox LastNameFilter;
        private Label LastNameLabel;
        private Button SearchButton;
        private Button TransformButton;
        private TextBox OutputTextBox;
        private ComboBox DateFilter;
        private Label DateLabel;
        private RadioButton SaxRadioButton;
        private RadioButton DomRadioButton;
        private RadioButton LinqRadioButton;
        private CheckBox FiltersCheckBox;
    }
}

