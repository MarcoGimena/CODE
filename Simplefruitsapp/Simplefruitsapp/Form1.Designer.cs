namespace Simplefruitsapp
{
    partial class Form1
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
            fruitlist = new CheckedListBox();
            listbox = new ListBox();
            add = new Button();
            remove = new Button();
            clearAll = new Button();
            SuspendLayout();
            // 
            // fruitlist
            // 
            fruitlist.FormattingEnabled = true;
            fruitlist.Location = new Point(36, 95);
            fruitlist.Name = "fruitlist";
            fruitlist.Size = new Size(176, 130);
            fruitlist.TabIndex = 0;
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 15;
            listbox.Location = new Point(259, 95);
            listbox.Name = "listbox";
            listbox.Size = new Size(151, 124);
            listbox.TabIndex = 1;
            // 
            // add
            // 
            add.Location = new Point(45, 245);
            add.Name = "add";
            add.Size = new Size(98, 34);
            add.TabIndex = 2;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(416, 95);
            remove.Name = "remove";
            remove.Size = new Size(98, 34);
            remove.TabIndex = 3;
            remove.Text = "Delete";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // clearAll
            // 
            clearAll.Location = new Point(416, 155);
            clearAll.Name = "clearAll";
            clearAll.Size = new Size(98, 34);
            clearAll.TabIndex = 4;
            clearAll.Text = "Clear All";
            clearAll.UseVisualStyleBackColor = true;
            clearAll.Click += clearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearAll);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(listbox);
            Controls.Add(fruitlist);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox fruitlist;
        private ListBox listbox;
        private Button add;
        private Button remove;
        private Button clearAll;
    }
}
