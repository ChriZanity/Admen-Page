namespace Admin_Page
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
            navpanel = new Panel();
            header_logo = new PictureBox();
            header_text = new Label();
            menu = new PictureBox();
            maincontainer = new Panel();
            form_bg = new Panel();
            del_batchstud_form = new Panel();
            del_batchstud_searchresults = new ListBox();
            del_batchstud_search = new TextBox();
            del_batchstud_subheading = new Label();
            del_batchstud_header = new Label();
            add_del_section = new Panel();
            delete_sec_form = new Panel();
            delete_sec_searchresults = new ListBox();
            delete_sec_searchbar = new TextBox();
            delete_sec_subheading = new Label();
            delete_sec_header = new Label();
            add_sub_form = new Panel();
            add_sub_container = new Panel();
            add_sub_drag = new Label();
            add_sub_upload = new Label();
            add_sub_excel = new PictureBox();
            add_sub_subheading = new Label();
            add_sub_header = new Label();
            add_prof_form = new Panel();
            add_prof_container = new Panel();
            add_prof_drag = new Label();
            add_prof_upload = new Label();
            add_prof_excel = new PictureBox();
            add_prof_subheading = new Label();
            add_prof_header = new Label();
            add_stud_form = new Panel();
            add_stud_container = new Panel();
            add_stud_drag = new Label();
            add_stud_upload = new Label();
            excel_pic = new PictureBox();
            add_stud_subheading = new Label();
            add_stud_header = new Label();
            close_button = new Button();
            left_side = new Panel();
            top_leftside = new Panel();
            top_profile = new Label();
            top_admintext = new Label();
            top_image = new PictureBox();
            panel2 = new Panel();
            middle_leftside = new Panel();
            philosophy_statement = new Label();
            tcu_philosophy = new Label();
            vision_statement = new Label();
            tcu_vision = new Label();
            mission_statement = new Label();
            tcu_mission = new Label();
            bottom_leftside = new Panel();
            tcu_unity = new Label();
            tcu_competence = new Label();
            tcu_truth = new Label();
            right_side = new Panel();
            top_rightside = new Panel();
            tcu_bg = new PictureBox();
            bottom_rightside = new Panel();
            change_sem = new Button();
            assign_prof = new Button();
            assign_irreg = new Button();
            assign_sec = new Button();
            delete_prof = new Button();
            delete_stud = new Button();
            add_del_sec = new Button();
            add_sub = new Button();
            add_prof = new Button();
            add_stud = new Button();
            body = new Panel();
            add_sec_form = new Panel();
            add_sec_container = new Panel();
            add_sec_drag = new Label();
            add_sec_upload = new Label();
            add_sec_excel = new PictureBox();
            add_sec_subheading = new Label();
            add_sec_header = new Label();
            navpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)header_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            maincontainer.SuspendLayout();
            form_bg.SuspendLayout();
            del_batchstud_form.SuspendLayout();
            add_del_section.SuspendLayout();
            delete_sec_form.SuspendLayout();
            add_sub_form.SuspendLayout();
            add_sub_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)add_sub_excel).BeginInit();
            add_prof_form.SuspendLayout();
            add_prof_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)add_prof_excel).BeginInit();
            add_stud_form.SuspendLayout();
            add_stud_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)excel_pic).BeginInit();
            left_side.SuspendLayout();
            top_leftside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)top_image).BeginInit();
            middle_leftside.SuspendLayout();
            bottom_leftside.SuspendLayout();
            right_side.SuspendLayout();
            top_rightside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tcu_bg).BeginInit();
            bottom_rightside.SuspendLayout();
            body.SuspendLayout();
            add_sec_form.SuspendLayout();
            add_sec_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)add_sec_excel).BeginInit();
            SuspendLayout();
            // 
            // navpanel
            // 
            navpanel.Controls.Add(header_logo);
            navpanel.Controls.Add(header_text);
            navpanel.Controls.Add(menu);
            navpanel.Dock = DockStyle.Top;
            navpanel.Location = new Point(0, 0);
            navpanel.Name = "navpanel";
            navpanel.Size = new Size(919, 103);
            navpanel.TabIndex = 0;
            navpanel.Paint += navpanel_Paint;
            // 
            // header_logo
            // 
            header_logo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            header_logo.BackgroundImage = Properties.Resources.tculogo1;
            header_logo.BackgroundImageLayout = ImageLayout.Zoom;
            header_logo.Location = new Point(822, 12);
            header_logo.Name = "header_logo";
            header_logo.Size = new Size(85, 69);
            header_logo.TabIndex = 1;
            header_logo.TabStop = false;
            header_logo.Click += header_logo_Click;
            // 
            // header_text
            // 
            header_text.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            header_text.AutoSize = true;
            header_text.ForeColor = Color.White;
            header_text.ImageAlign = ContentAlignment.MiddleRight;
            header_text.Location = new Point(677, 40);
            header_text.Name = "header_text";
            header_text.Size = new Size(114, 15);
            header_text.TabIndex = 2;
            header_text.Text = "ADMIN'S ACCOUNT";
            header_text.Click += header_text_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.BackgroundImage = Properties.Resources.menu1;
            menu.BackgroundImageLayout = ImageLayout.Zoom;
            menu.Location = new Point(12, 21);
            menu.Name = "menu";
            menu.Size = new Size(60, 60);
            menu.TabIndex = 1;
            menu.TabStop = false;
            // 
            // maincontainer
            // 
            maincontainer.BackColor = Color.Transparent;
            maincontainer.BackgroundImageLayout = ImageLayout.Stretch;
            maincontainer.Controls.Add(form_bg);
            maincontainer.Controls.Add(left_side);
            maincontainer.Controls.Add(right_side);
            maincontainer.Location = new Point(0, 103);
            maincontainer.Name = "maincontainer";
            maincontainer.Size = new Size(919, 426);
            maincontainer.TabIndex = 1;
            maincontainer.Paint += maincontainer_Paint;
            // 
            // form_bg
            // 
            form_bg.BackColor = Color.Transparent;
            form_bg.BackgroundImageLayout = ImageLayout.Center;
            form_bg.Controls.Add(del_batchstud_form);
            form_bg.Controls.Add(add_del_section);
            form_bg.Controls.Add(add_sub_form);
            form_bg.Controls.Add(add_prof_form);
            form_bg.Controls.Add(add_stud_form);
            form_bg.Controls.Add(close_button);
            form_bg.Location = new Point(0, 0);
            form_bg.Name = "form_bg";
            form_bg.Size = new Size(919, 426);
            form_bg.TabIndex = 5;
            form_bg.Paint += form_bg_Paint;
            // 
            // del_batchstud_form
            // 
            del_batchstud_form.BackColor = Color.White;
            del_batchstud_form.BorderStyle = BorderStyle.FixedSingle;
            del_batchstud_form.Controls.Add(del_batchstud_searchresults);
            del_batchstud_form.Controls.Add(del_batchstud_search);
            del_batchstud_form.Controls.Add(del_batchstud_subheading);
            del_batchstud_form.Controls.Add(del_batchstud_header);
            del_batchstud_form.Location = new Point(29, 11);
            del_batchstud_form.Name = "del_batchstud_form";
            del_batchstud_form.Size = new Size(128, 148);
            del_batchstud_form.TabIndex = 7;
            // 
            // del_batchstud_searchresults
            // 
            del_batchstud_searchresults.FormattingEnabled = true;
            del_batchstud_searchresults.ItemHeight = 15;
            del_batchstud_searchresults.Location = new Point(23, 135);
            del_batchstud_searchresults.Name = "del_batchstud_searchresults";
            del_batchstud_searchresults.Size = new Size(190, 49);
            del_batchstud_searchresults.TabIndex = 9;
            // 
            // del_batchstud_search
            // 
            del_batchstud_search.Location = new Point(23, 112);
            del_batchstud_search.Multiline = true;
            del_batchstud_search.Name = "del_batchstud_search";
            del_batchstud_search.Size = new Size(190, 23);
            del_batchstud_search.TabIndex = 8;
            del_batchstud_search.Text = "Year(e.g., 2023)";
            // 
            // del_batchstud_subheading
            // 
            del_batchstud_subheading.AutoSize = true;
            del_batchstud_subheading.Location = new Point(24, 80);
            del_batchstud_subheading.Name = "del_batchstud_subheading";
            del_batchstud_subheading.Size = new Size(218, 15);
            del_batchstud_subheading.TabIndex = 7;
            del_batchstud_subheading.Text = "Enter Batch Year (e.g., 23 for Batch 2023)";
            // 
            // del_batchstud_header
            // 
            del_batchstud_header.AutoSize = true;
            del_batchstud_header.BackColor = Color.White;
            del_batchstud_header.Location = new Point(24, 50);
            del_batchstud_header.Name = "del_batchstud_header";
            del_batchstud_header.Size = new Size(122, 15);
            del_batchstud_header.TabIndex = 6;
            del_batchstud_header.Text = "Delete Batch Students";
            // 
            // add_del_section
            // 
            add_del_section.Controls.Add(add_sec_form);
            add_del_section.Controls.Add(delete_sec_form);
            add_del_section.Location = new Point(201, 0);
            add_del_section.Name = "add_del_section";
            add_del_section.Size = new Size(545, 426);
            add_del_section.TabIndex = 6;
            add_del_section.Paint += add_del_section_Paint;
            // 
            // delete_sec_form
            // 
            delete_sec_form.BackColor = Color.White;
            delete_sec_form.BorderStyle = BorderStyle.FixedSingle;
            delete_sec_form.Controls.Add(delete_sec_searchresults);
            delete_sec_form.Controls.Add(delete_sec_searchbar);
            delete_sec_form.Controls.Add(delete_sec_subheading);
            delete_sec_form.Controls.Add(delete_sec_header);
            delete_sec_form.Location = new Point(0, 272);
            delete_sec_form.Name = "delete_sec_form";
            delete_sec_form.Size = new Size(539, 142);
            delete_sec_form.TabIndex = 5;
            // 
            // delete_sec_searchresults
            // 
            delete_sec_searchresults.FormattingEnabled = true;
            delete_sec_searchresults.ItemHeight = 15;
            delete_sec_searchresults.Location = new Point(26, 83);
            delete_sec_searchresults.Name = "delete_sec_searchresults";
            delete_sec_searchresults.Size = new Size(190, 49);
            delete_sec_searchresults.TabIndex = 9;
            // 
            // delete_sec_searchbar
            // 
            delete_sec_searchbar.Location = new Point(26, 62);
            delete_sec_searchbar.Multiline = true;
            delete_sec_searchbar.Name = "delete_sec_searchbar";
            delete_sec_searchbar.Size = new Size(190, 23);
            delete_sec_searchbar.TabIndex = 8;
            delete_sec_searchbar.Text = "Year(e.g., 2023)";
            // 
            // delete_sec_subheading
            // 
            delete_sec_subheading.AutoSize = true;
            delete_sec_subheading.Location = new Point(23, 31);
            delete_sec_subheading.Name = "delete_sec_subheading";
            delete_sec_subheading.Size = new Size(315, 15);
            delete_sec_subheading.TabIndex = 7;
            delete_sec_subheading.Text = "To delete, enter the year from the section name (e.g., 2023)";
            // 
            // delete_sec_header
            // 
            delete_sec_header.AutoSize = true;
            delete_sec_header.BackColor = Color.White;
            delete_sec_header.Location = new Point(23, 12);
            delete_sec_header.Name = "delete_sec_header";
            delete_sec_header.Size = new Size(87, 15);
            delete_sec_header.TabIndex = 6;
            delete_sec_header.Text = "Delete Sections";
            // 
            // add_sub_form
            // 
            add_sub_form.BackColor = Color.White;
            add_sub_form.BorderStyle = BorderStyle.FixedSingle;
            add_sub_form.Controls.Add(add_sub_container);
            add_sub_form.Controls.Add(add_sub_subheading);
            add_sub_form.Controls.Add(add_sub_header);
            add_sub_form.Location = new Point(201, 66);
            add_sub_form.Name = "add_sub_form";
            add_sub_form.Size = new Size(539, 311);
            add_sub_form.TabIndex = 3;
            // 
            // add_sub_container
            // 
            add_sub_container.BackColor = Color.White;
            add_sub_container.BorderStyle = BorderStyle.FixedSingle;
            add_sub_container.Controls.Add(add_sub_drag);
            add_sub_container.Controls.Add(add_sub_upload);
            add_sub_container.Controls.Add(add_sub_excel);
            add_sub_container.Location = new Point(26, 81);
            add_sub_container.Name = "add_sub_container";
            add_sub_container.Size = new Size(482, 202);
            add_sub_container.TabIndex = 2;
            // 
            // add_sub_drag
            // 
            add_sub_drag.AutoSize = true;
            add_sub_drag.Location = new Point(177, 166);
            add_sub_drag.Name = "add_sub_drag";
            add_sub_drag.Size = new Size(202, 15);
            add_sub_drag.TabIndex = 2;
            add_sub_drag.Text = "or Drag and Drop your Excel File here";
            // 
            // add_sub_upload
            // 
            add_sub_upload.AutoSize = true;
            add_sub_upload.Location = new Point(56, 167);
            add_sub_upload.Name = "add_sub_upload";
            add_sub_upload.Size = new Size(121, 15);
            add_sub_upload.TabIndex = 1;
            add_sub_upload.Text = "Click to Upload a File ";
            add_sub_upload.Click += add_sub_upload_Click;
            // 
            // add_sub_excel
            // 
            add_sub_excel.BackgroundImage = Properties.Resources.excel2;
            add_sub_excel.BackgroundImageLayout = ImageLayout.Zoom;
            add_sub_excel.Location = new Point(170, 15);
            add_sub_excel.Name = "add_sub_excel";
            add_sub_excel.Size = new Size(155, 99);
            add_sub_excel.TabIndex = 0;
            add_sub_excel.TabStop = false;
            // 
            // add_sub_subheading
            // 
            add_sub_subheading.AutoSize = true;
            add_sub_subheading.Location = new Point(24, 52);
            add_sub_subheading.Name = "add_sub_subheading";
            add_sub_subheading.Size = new Size(199, 15);
            add_sub_subheading.TabIndex = 1;
            add_sub_subheading.Text = "Upload and attach file to this project";
            // 
            // add_sub_header
            // 
            add_sub_header.AutoSize = true;
            add_sub_header.BackColor = Color.White;
            add_sub_header.Location = new Point(24, 26);
            add_sub_header.Name = "add_sub_header";
            add_sub_header.Size = new Size(97, 15);
            add_sub_header.TabIndex = 0;
            add_sub_header.Text = "Upload Subject/s";
            // 
            // add_prof_form
            // 
            add_prof_form.BackColor = Color.White;
            add_prof_form.BorderStyle = BorderStyle.FixedSingle;
            add_prof_form.Controls.Add(add_prof_container);
            add_prof_form.Controls.Add(add_prof_subheading);
            add_prof_form.Controls.Add(add_prof_header);
            add_prof_form.Location = new Point(201, 66);
            add_prof_form.Name = "add_prof_form";
            add_prof_form.Size = new Size(539, 311);
            add_prof_form.TabIndex = 2;
            // 
            // add_prof_container
            // 
            add_prof_container.BackColor = Color.White;
            add_prof_container.BorderStyle = BorderStyle.FixedSingle;
            add_prof_container.Controls.Add(add_prof_drag);
            add_prof_container.Controls.Add(add_prof_upload);
            add_prof_container.Controls.Add(add_prof_excel);
            add_prof_container.Location = new Point(26, 81);
            add_prof_container.Name = "add_prof_container";
            add_prof_container.Size = new Size(482, 202);
            add_prof_container.TabIndex = 2;
            // 
            // add_prof_drag
            // 
            add_prof_drag.AutoSize = true;
            add_prof_drag.Location = new Point(177, 166);
            add_prof_drag.Name = "add_prof_drag";
            add_prof_drag.Size = new Size(202, 15);
            add_prof_drag.TabIndex = 2;
            add_prof_drag.Text = "or Drag and Drop your Excel File here";
            // 
            // add_prof_upload
            // 
            add_prof_upload.AutoSize = true;
            add_prof_upload.Location = new Point(56, 167);
            add_prof_upload.Name = "add_prof_upload";
            add_prof_upload.Size = new Size(121, 15);
            add_prof_upload.TabIndex = 1;
            add_prof_upload.Text = "Click to Upload a File ";
            add_prof_upload.Click += add_prof_upload_Click;
            // 
            // add_prof_excel
            // 
            add_prof_excel.BackgroundImage = Properties.Resources.excel2;
            add_prof_excel.BackgroundImageLayout = ImageLayout.Zoom;
            add_prof_excel.Location = new Point(170, 15);
            add_prof_excel.Name = "add_prof_excel";
            add_prof_excel.Size = new Size(155, 99);
            add_prof_excel.TabIndex = 0;
            add_prof_excel.TabStop = false;
            // 
            // add_prof_subheading
            // 
            add_prof_subheading.AutoSize = true;
            add_prof_subheading.Location = new Point(24, 52);
            add_prof_subheading.Name = "add_prof_subheading";
            add_prof_subheading.Size = new Size(199, 15);
            add_prof_subheading.TabIndex = 1;
            add_prof_subheading.Text = "Upload and attach file to this project";
            // 
            // add_prof_header
            // 
            add_prof_header.AutoSize = true;
            add_prof_header.Location = new Point(24, 26);
            add_prof_header.Name = "add_prof_header";
            add_prof_header.Size = new Size(107, 15);
            add_prof_header.TabIndex = 0;
            add_prof_header.Text = "Upload Professor/s";
            // 
            // add_stud_form
            // 
            add_stud_form.BorderStyle = BorderStyle.FixedSingle;
            add_stud_form.Controls.Add(add_stud_container);
            add_stud_form.Controls.Add(add_stud_subheading);
            add_stud_form.Controls.Add(add_stud_header);
            add_stud_form.Location = new Point(201, 66);
            add_stud_form.Name = "add_stud_form";
            add_stud_form.Size = new Size(539, 311);
            add_stud_form.TabIndex = 1;
            // 
            // add_stud_container
            // 
            add_stud_container.BackColor = Color.White;
            add_stud_container.BorderStyle = BorderStyle.FixedSingle;
            add_stud_container.Controls.Add(add_stud_drag);
            add_stud_container.Controls.Add(add_stud_upload);
            add_stud_container.Controls.Add(excel_pic);
            add_stud_container.Location = new Point(23, 77);
            add_stud_container.Name = "add_stud_container";
            add_stud_container.Size = new Size(474, 193);
            add_stud_container.TabIndex = 2;
            // 
            // add_stud_drag
            // 
            add_stud_drag.AutoSize = true;
            add_stud_drag.Location = new Point(186, 155);
            add_stud_drag.Name = "add_stud_drag";
            add_stud_drag.Size = new Size(202, 15);
            add_stud_drag.TabIndex = 2;
            add_stud_drag.Text = "or Drag and Drop your Excel File here";
            // 
            // add_stud_upload
            // 
            add_stud_upload.AutoSize = true;
            add_stud_upload.Location = new Point(71, 155);
            add_stud_upload.Name = "add_stud_upload";
            add_stud_upload.Size = new Size(121, 15);
            add_stud_upload.TabIndex = 1;
            add_stud_upload.Text = "Click to Upload a File ";
            add_stud_upload.Click += add_stud_upload_Click;
            // 
            // excel_pic
            // 
            excel_pic.BackgroundImage = Properties.Resources.excel2;
            excel_pic.BackgroundImageLayout = ImageLayout.Zoom;
            excel_pic.Location = new Point(174, 27);
            excel_pic.Name = "excel_pic";
            excel_pic.Size = new Size(111, 84);
            excel_pic.TabIndex = 0;
            excel_pic.TabStop = false;
            // 
            // add_stud_subheading
            // 
            add_stud_subheading.AutoSize = true;
            add_stud_subheading.Location = new Point(23, 51);
            add_stud_subheading.Name = "add_stud_subheading";
            add_stud_subheading.Size = new Size(199, 15);
            add_stud_subheading.TabIndex = 1;
            add_stud_subheading.Text = "Upload and attach file to this project";
            // 
            // add_stud_header
            // 
            add_stud_header.AutoSize = true;
            add_stud_header.Location = new Point(23, 25);
            add_stud_header.Name = "add_stud_header";
            add_stud_header.Size = new Size(99, 15);
            add_stud_header.TabIndex = 0;
            add_stud_header.Text = "Upload Student/s";
            // 
            // close_button
            // 
            close_button.Cursor = Cursors.Hand;
            close_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_button.ForeColor = Color.White;
            close_button.Location = new Point(855, 22);
            close_button.Name = "close_button";
            close_button.Size = new Size(49, 33);
            close_button.TabIndex = 0;
            close_button.Text = "X";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // left_side
            // 
            left_side.BackColor = Color.Transparent;
            left_side.Controls.Add(top_leftside);
            left_side.Controls.Add(middle_leftside);
            left_side.Controls.Add(bottom_leftside);
            left_side.Location = new Point(0, 0);
            left_side.Name = "left_side";
            left_side.Size = new Size(405, 426);
            left_side.TabIndex = 0;
            // 
            // top_leftside
            // 
            top_leftside.BackColor = Color.White;
            top_leftside.Controls.Add(top_profile);
            top_leftside.Controls.Add(top_admintext);
            top_leftside.Controls.Add(top_image);
            top_leftside.Controls.Add(panel2);
            top_leftside.Location = new Point(0, 0);
            top_leftside.Name = "top_leftside";
            top_leftside.Size = new Size(405, 147);
            top_leftside.TabIndex = 1;
            // 
            // top_profile
            // 
            top_profile.AutoSize = true;
            top_profile.Location = new Point(173, 107);
            top_profile.Name = "top_profile";
            top_profile.Size = new Size(41, 15);
            top_profile.TabIndex = 4;
            top_profile.Text = "Profile";
            // 
            // top_admintext
            // 
            top_admintext.AutoSize = true;
            top_admintext.Location = new Point(141, 92);
            top_admintext.Name = "top_admintext";
            top_admintext.Size = new Size(99, 15);
            top_admintext.TabIndex = 3;
            top_admintext.Text = "Admin's Account";
            // 
            // top_image
            // 
            top_image.BackgroundImage = Properties.Resources.tculogo1;
            top_image.BackgroundImageLayout = ImageLayout.Zoom;
            top_image.Location = new Point(141, 6);
            top_image.Name = "top_image";
            top_image.Size = new Size(100, 74);
            top_image.TabIndex = 1;
            top_image.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 212);
            panel2.TabIndex = 2;
            // 
            // middle_leftside
            // 
            middle_leftside.BackColor = Color.White;
            middle_leftside.Controls.Add(philosophy_statement);
            middle_leftside.Controls.Add(tcu_philosophy);
            middle_leftside.Controls.Add(vision_statement);
            middle_leftside.Controls.Add(tcu_vision);
            middle_leftside.Controls.Add(mission_statement);
            middle_leftside.Controls.Add(tcu_mission);
            middle_leftside.Location = new Point(0, 146);
            middle_leftside.Name = "middle_leftside";
            middle_leftside.Size = new Size(405, 219);
            middle_leftside.TabIndex = 2;
            // 
            // philosophy_statement
            // 
            philosophy_statement.AutoSize = true;
            philosophy_statement.Location = new Point(54, 173);
            philosophy_statement.Name = "philosophy_statement";
            philosophy_statement.Size = new Size(279, 30);
            philosophy_statement.TabIndex = 5;
            philosophy_statement.Text = "\"Social transformation for a caring community and \r\nan ecologically balanced country.\"\r\n";
            philosophy_statement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcu_philosophy
            // 
            tcu_philosophy.AutoSize = true;
            tcu_philosophy.Location = new Point(141, 149);
            tcu_philosophy.Name = "tcu_philosophy";
            tcu_philosophy.Size = new Size(103, 15);
            tcu_philosophy.TabIndex = 1;
            tcu_philosophy.Text = "TCU PHILOSOPHY";
            // 
            // vision_statement
            // 
            vision_statement.AutoSize = true;
            vision_statement.Location = new Point(54, 109);
            vision_statement.Name = "vision_statement";
            vision_statement.Size = new Size(270, 30);
            vision_statement.TabIndex = 4;
            vision_statement.Text = "\"An eminent center of excellent higher education \r\ntowards societal advancement.\"\r\n";
            vision_statement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcu_vision
            // 
            tcu_vision.AutoSize = true;
            tcu_vision.Location = new Point(151, 83);
            tcu_vision.Name = "tcu_vision";
            tcu_vision.Size = new Size(68, 15);
            tcu_vision.TabIndex = 1;
            tcu_vision.Text = "TCU VISION";
            // 
            // mission_statement
            // 
            mission_statement.AutoSize = true;
            mission_statement.Location = new Point(54, 31);
            mission_statement.Name = "mission_statement";
            mission_statement.Size = new Size(279, 45);
            mission_statement.TabIndex = 3;
            mission_statement.Text = "\"To nurture a vibrant culture of academic wellness \r\nresponsive to the challenges of technology and the \r\nglobal community.\"\r\n";
            mission_statement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcu_mission
            // 
            tcu_mission.AutoSize = true;
            tcu_mission.Location = new Point(151, 16);
            tcu_mission.Name = "tcu_mission";
            tcu_mission.Size = new Size(78, 15);
            tcu_mission.TabIndex = 1;
            tcu_mission.Text = "TCU MISSION";
            // 
            // bottom_leftside
            // 
            bottom_leftside.BackColor = Color.White;
            bottom_leftside.Controls.Add(tcu_unity);
            bottom_leftside.Controls.Add(tcu_competence);
            bottom_leftside.Controls.Add(tcu_truth);
            bottom_leftside.Location = new Point(0, 364);
            bottom_leftside.Name = "bottom_leftside";
            bottom_leftside.Size = new Size(405, 62);
            bottom_leftside.TabIndex = 1;
            // 
            // tcu_unity
            // 
            tcu_unity.AutoSize = true;
            tcu_unity.Location = new Point(240, 28);
            tcu_unity.Name = "tcu_unity";
            tcu_unity.Size = new Size(40, 15);
            tcu_unity.TabIndex = 2;
            tcu_unity.Text = "UNITY";
            // 
            // tcu_competence
            // 
            tcu_competence.AutoSize = true;
            tcu_competence.Location = new Point(139, 28);
            tcu_competence.Name = "tcu_competence";
            tcu_competence.Size = new Size(83, 15);
            tcu_competence.TabIndex = 1;
            tcu_competence.Text = "COMPETENCE";
            // 
            // tcu_truth
            // 
            tcu_truth.AutoSize = true;
            tcu_truth.Location = new Point(82, 28);
            tcu_truth.Name = "tcu_truth";
            tcu_truth.Size = new Size(43, 15);
            tcu_truth.TabIndex = 0;
            tcu_truth.Text = "TRUTH";
            // 
            // right_side
            // 
            right_side.BackColor = Color.Transparent;
            right_side.BackgroundImageLayout = ImageLayout.Zoom;
            right_side.Controls.Add(top_rightside);
            right_side.Controls.Add(bottom_rightside);
            right_side.Location = new Point(406, 0);
            right_side.Name = "right_side";
            right_side.Size = new Size(513, 426);
            right_side.TabIndex = 1;
            // 
            // top_rightside
            // 
            top_rightside.BackColor = Color.White;
            top_rightside.Controls.Add(tcu_bg);
            top_rightside.Location = new Point(0, 0);
            top_rightside.Name = "top_rightside";
            top_rightside.Size = new Size(514, 186);
            top_rightside.TabIndex = 0;
            // 
            // tcu_bg
            // 
            tcu_bg.BackgroundImage = Properties.Resources.tcubg;
            tcu_bg.BackgroundImageLayout = ImageLayout.Stretch;
            tcu_bg.Location = new Point(17, 22);
            tcu_bg.Name = "tcu_bg";
            tcu_bg.Size = new Size(469, 146);
            tcu_bg.TabIndex = 0;
            tcu_bg.TabStop = false;
            // 
            // bottom_rightside
            // 
            bottom_rightside.BackColor = Color.White;
            bottom_rightside.Controls.Add(change_sem);
            bottom_rightside.Controls.Add(assign_prof);
            bottom_rightside.Controls.Add(assign_irreg);
            bottom_rightside.Controls.Add(assign_sec);
            bottom_rightside.Controls.Add(delete_prof);
            bottom_rightside.Controls.Add(delete_stud);
            bottom_rightside.Controls.Add(add_del_sec);
            bottom_rightside.Controls.Add(add_sub);
            bottom_rightside.Controls.Add(add_prof);
            bottom_rightside.Controls.Add(add_stud);
            bottom_rightside.Location = new Point(0, 186);
            bottom_rightside.Name = "bottom_rightside";
            bottom_rightside.Size = new Size(514, 240);
            bottom_rightside.TabIndex = 1;
            // 
            // change_sem
            // 
            change_sem.Location = new Point(154, 169);
            change_sem.Name = "change_sem";
            change_sem.Size = new Size(71, 52);
            change_sem.TabIndex = 9;
            change_sem.Text = "Change Semester";
            change_sem.UseVisualStyleBackColor = true;
            // 
            // assign_prof
            // 
            assign_prof.Location = new Point(34, 169);
            assign_prof.Name = "assign_prof";
            assign_prof.Size = new Size(114, 59);
            assign_prof.TabIndex = 8;
            assign_prof.Text = "Assign/Unassign Subject(Professor)";
            assign_prof.UseVisualStyleBackColor = true;
            // 
            // assign_irreg
            // 
            assign_irreg.Location = new Point(386, 90);
            assign_irreg.Name = "assign_irreg";
            assign_irreg.Size = new Size(113, 61);
            assign_irreg.TabIndex = 7;
            assign_irreg.Text = "Assign/Unassign Subject(Irregular Students)";
            assign_irreg.UseVisualStyleBackColor = true;
            // 
            // assign_sec
            // 
            assign_sec.Location = new Point(262, 90);
            assign_sec.Name = "assign_sec";
            assign_sec.Size = new Size(104, 61);
            assign_sec.TabIndex = 6;
            assign_sec.Text = "Assign/Unassign Subject(Section)\r\n";
            assign_sec.UseVisualStyleBackColor = true;
            // 
            // delete_prof
            // 
            delete_prof.Location = new Point(154, 90);
            delete_prof.Name = "delete_prof";
            delete_prof.Size = new Size(71, 52);
            delete_prof.TabIndex = 5;
            delete_prof.Text = "Delete Professor";
            delete_prof.UseVisualStyleBackColor = true;
            // 
            // delete_stud
            // 
            delete_stud.Location = new Point(34, 90);
            delete_stud.Name = "delete_stud";
            delete_stud.Size = new Size(71, 61);
            delete_stud.TabIndex = 4;
            delete_stud.Text = "Delete Batch Students";
            delete_stud.UseVisualStyleBackColor = true;
            delete_stud.Click += delete_stud_Click;
            // 
            // add_del_sec
            // 
            add_del_sec.Location = new Point(386, 17);
            add_del_sec.Name = "add_del_sec";
            add_del_sec.Size = new Size(81, 52);
            add_del_sec.TabIndex = 3;
            add_del_sec.Text = "Add/Delete Section";
            add_del_sec.UseVisualStyleBackColor = true;
            add_del_sec.Click += add_del_sec_Click;
            // 
            // add_sub
            // 
            add_sub.Location = new Point(262, 17);
            add_sub.Name = "add_sub";
            add_sub.Size = new Size(71, 52);
            add_sub.TabIndex = 2;
            add_sub.Text = "Add Subjects";
            add_sub.UseVisualStyleBackColor = true;
            add_sub.Click += add_sub_Click;
            // 
            // add_prof
            // 
            add_prof.Location = new Point(154, 17);
            add_prof.Name = "add_prof";
            add_prof.Size = new Size(71, 52);
            add_prof.TabIndex = 1;
            add_prof.Text = "Add Professors";
            add_prof.UseVisualStyleBackColor = true;
            add_prof.Click += add_prof_Click;
            // 
            // add_stud
            // 
            add_stud.Location = new Point(34, 17);
            add_stud.Name = "add_stud";
            add_stud.Size = new Size(71, 52);
            add_stud.TabIndex = 0;
            add_stud.Text = "Add Students";
            add_stud.UseVisualStyleBackColor = true;
            add_stud.Click += add_stud_Click;
            // 
            // body
            // 
            body.BackColor = Color.White;
            body.Controls.Add(maincontainer);
            body.Controls.Add(navpanel);
            body.Dock = DockStyle.Fill;
            body.Location = new Point(0, 0);
            body.Name = "body";
            body.Size = new Size(919, 529);
            body.TabIndex = 0;
            // 
            // add_sec_form
            // 
            add_sec_form.BackColor = Color.White;
            add_sec_form.BorderStyle = BorderStyle.FixedSingle;
            add_sec_form.Controls.Add(add_sec_container);
            add_sec_form.Controls.Add(add_sec_subheading);
            add_sec_form.Controls.Add(add_sec_header);
            add_sec_form.Location = new Point(0, 0);
            add_sec_form.Name = "add_sec_form";
            add_sec_form.Size = new Size(535, 270);
            add_sec_form.TabIndex = 8;
            // 
            // add_sec_container
            // 
            add_sec_container.BackColor = Color.White;
            add_sec_container.BorderStyle = BorderStyle.FixedSingle;
            add_sec_container.Controls.Add(add_sec_drag);
            add_sec_container.Controls.Add(add_sec_upload);
            add_sec_container.Controls.Add(add_sec_excel);
            add_sec_container.Location = new Point(26, 81);
            add_sec_container.Name = "add_sec_container";
            add_sec_container.Size = new Size(482, 162);
            add_sec_container.TabIndex = 2;
            // 
            // add_sec_drag
            // 
            add_sec_drag.AutoSize = true;
            add_sec_drag.Location = new Point(182, 120);
            add_sec_drag.Name = "add_sec_drag";
            add_sec_drag.Size = new Size(202, 15);
            add_sec_drag.TabIndex = 2;
            add_sec_drag.Text = "or Drag and Drop your Excel File here";
            // 
            // add_sec_upload
            // 
            add_sec_upload.AutoSize = true;
            add_sec_upload.Location = new Point(56, 120);
            add_sec_upload.Name = "add_sec_upload";
            add_sec_upload.Size = new Size(121, 15);
            add_sec_upload.TabIndex = 1;
            add_sec_upload.Text = "Click to Upload a File ";
            // 
            // add_sec_excel
            // 
            add_sec_excel.BackgroundImage = Properties.Resources.excel2;
            add_sec_excel.BackgroundImageLayout = ImageLayout.Zoom;
            add_sec_excel.Location = new Point(170, 15);
            add_sec_excel.Name = "add_sec_excel";
            add_sec_excel.Size = new Size(127, 79);
            add_sec_excel.TabIndex = 0;
            add_sec_excel.TabStop = false;
            // 
            // add_sec_subheading
            // 
            add_sec_subheading.AutoSize = true;
            add_sec_subheading.Location = new Point(24, 52);
            add_sec_subheading.Name = "add_sec_subheading";
            add_sec_subheading.Size = new Size(199, 15);
            add_sec_subheading.TabIndex = 1;
            add_sec_subheading.Text = "Upload and attach file to this project";
            // 
            // add_sec_header
            // 
            add_sec_header.AutoSize = true;
            add_sec_header.BackColor = Color.White;
            add_sec_header.Location = new Point(24, 26);
            add_sec_header.Name = "add_sec_header";
            add_sec_header.Size = new Size(97, 15);
            add_sec_header.TabIndex = 0;
            add_sec_header.Text = "Upload Subject/s";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(919, 529);
            Controls.Add(body);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            navpanel.ResumeLayout(false);
            navpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)header_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            maincontainer.ResumeLayout(false);
            form_bg.ResumeLayout(false);
            del_batchstud_form.ResumeLayout(false);
            del_batchstud_form.PerformLayout();
            add_del_section.ResumeLayout(false);
            delete_sec_form.ResumeLayout(false);
            delete_sec_form.PerformLayout();
            add_sub_form.ResumeLayout(false);
            add_sub_form.PerformLayout();
            add_sub_container.ResumeLayout(false);
            add_sub_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)add_sub_excel).EndInit();
            add_prof_form.ResumeLayout(false);
            add_prof_form.PerformLayout();
            add_prof_container.ResumeLayout(false);
            add_prof_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)add_prof_excel).EndInit();
            add_stud_form.ResumeLayout(false);
            add_stud_form.PerformLayout();
            add_stud_container.ResumeLayout(false);
            add_stud_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)excel_pic).EndInit();
            left_side.ResumeLayout(false);
            top_leftside.ResumeLayout(false);
            top_leftside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)top_image).EndInit();
            middle_leftside.ResumeLayout(false);
            middle_leftside.PerformLayout();
            bottom_leftside.ResumeLayout(false);
            bottom_leftside.PerformLayout();
            right_side.ResumeLayout(false);
            top_rightside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tcu_bg).EndInit();
            bottom_rightside.ResumeLayout(false);
            body.ResumeLayout(false);
            add_sec_form.ResumeLayout(false);
            add_sec_form.PerformLayout();
            add_sec_container.ResumeLayout(false);
            add_sec_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)add_sec_excel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navpanel;
        private PictureBox header_logo;
        private Label header_text;
        private PictureBox menu;
        private Panel maincontainer;
        private Panel right_side;
        private Panel bottom_rightside;
        private Button change_sem;
        private Button assign_prof;
        private Button assign_irreg;
        private Button assign_sec;
        private Button delete_prof;
        private Button delete_stud;
        private Button add_del_sec;
        private Button add_sub;
        private Button add_prof;
        private Button add_stud;
        private Panel top_rightside;
        private PictureBox tcu_bg;
        private Panel left_side;
        private Panel bottom_leftside;
        private Label tcu_unity;
        private Label tcu_competence;
        private Label tcu_truth;
        private Panel middle_leftside;
        private Label philosophy_statement;
        private Label tcu_philosophy;
        private Label vision_statement;
        private Label tcu_vision;
        private Label mission_statement;
        private Label tcu_mission;
        private Panel top_leftside;
        private Label top_profile;
        private Label top_admintext;
        private PictureBox top_image;
        private Panel panel2;
        private Panel body;
        private Panel form_bg;
        private Button close_button;
        private Panel add_stud_form;
        private Label add_stud_header;
        private Label add_stud_subheading;
        private Panel add_stud_container;
        private PictureBox excel_pic;
        private Label add_stud_upload;
        private Label add_stud_drag;
        private Panel add_prof_form;
        private Label add_prof_subheading;
        private Label add_prof_header;
        private Panel add_prof_container;
        private Label add_prof_drag;
        private Label add_prof_upload;
        private PictureBox add_prof_excel;
        private Panel add_sub_form;
        private Panel add_sub_container;
        private Label add_sub_drag;
        private Label add_sub_upload;
        private PictureBox add_sub_excel;
        private Label add_sub_subheading;
        private Label add_sub_header;
        private Panel delete_sec_form;
        private Label delete_sec_subheading;
        private Label delete_sec_header;
        private Label delete_sec_heading;
        private TextBox delete_sec_searchbar;
        private ListBox delete_sec_searchresults;
        private Panel add_del_section;
        private Panel del_batchstud_form;
        private ListBox del_batchstud_searchresults;
        private TextBox del_batchstud_search;
        private Label del_batchstud_subheading;
        private Label del_batchstud_header;
        private Panel add_sec_form;
        private Panel add_sec_container;
        private Label add_sec_drag;
        private Label add_sec_upload;
        private PictureBox add_sec_excel;
        private Label add_sec_subheading;
        private Label add_sec_header;
    }
}
