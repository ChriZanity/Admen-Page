namespace Admin_Page
{
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeftSideAdjust();
            NavCustomize();
            MainContainerCustomize();
        }
        private void navpanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle screensize = Screen.PrimaryScreen.Bounds;

            int height = (int)(screensize.Height * 0.15);
            int width = screensize.Width;

            navpanel.Size = new Size(width, height);
            navpanel.BackColor = Color.FromArgb(203, 7, 7);
        }

        private void maincontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftSideAdjust()
        {

        }

        private void header_text_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void header_logo_Click(object sender, EventArgs e)
        {

        }

        private void NavCustomize()
        {
            header_text.Font = new Font("Arial", 18, FontStyle.Bold);
            header_logo.Size = new Size(93, 110);

            header_logo.Top = 0;
            header_text.Left = (int)(navpanel.Width * 0.75);
        }

        private void OpenFile()
        {
            Process.Start("explorer.exe");

        }

        private void MainContainerCustomize()
        {
            //Resize maincontainer and panels inside it in a full screen size

            int mainwidth = body.Width;
            int mainheight = body.Height - navpanel.Height;

            maincontainer.Size = new Size(mainwidth, mainheight);
            maincontainer.Location = new Point(0, navpanel.Bottom);

            int leftheight = maincontainer.Height;
            int leftwidth = (int)(maincontainer.Width * 0.4);

            left_side.Size = new Size(leftwidth, leftheight);

            top_leftside.Width = left_side.Width;
            middle_leftside.Width = left_side.Width;
            bottom_leftside.Width = left_side.Width;

            top_leftside.Height = (int)(left_side.Height * 0.3);
            middle_leftside.Height = (int)(left_side.Height * 0.6);
            bottom_leftside.Height = (int)(left_side.Height * 0.1);

            top_leftside.Location = new Point(0, 0);
            middle_leftside.Top = top_leftside.Bottom;
            bottom_leftside.Top = middle_leftside.Bottom;

            //Resize top panel objects in left side of maincontainer 
            top_image.Size = new Size(124, 116);
            top_admintext.Font = new Font("Arial", 16, FontStyle.Bold);
            top_profile.Font = new Font("Arial", 14, FontStyle.Regular);

            int allheight = top_image.Height + top_admintext.Height + top_profile.Height;

            top_image.Left = (top_leftside.Width - top_image.Width) / 2;
            top_image.Top = 10;

            top_admintext.Left = (top_leftside.Width - top_admintext.Width) / 2;
            top_admintext.Top = top_image.Bottom;

            top_profile.Left = (top_leftside.Width - top_profile.Width) / 2;
            top_profile.Top = top_admintext.Bottom;

            //Resize middle panel objects in left side of maincontainer 

            tcu_mission.Font = new Font("Arial", 16, FontStyle.Bold);
            tcu_vision.Font = new Font("Arial", 16, FontStyle.Bold);
            tcu_philosophy.Font = new Font("Arial", 16, FontStyle.Bold);

            mission_statement.Font = new Font("Arial", 14, FontStyle.Regular);
            vision_statement.Font = new Font("Arial", 14, FontStyle.Regular);
            philosophy_statement.Font = new Font("Arial", 14, FontStyle.Regular);

            tcu_mission.Left = (middle_leftside.Width - tcu_mission.Width) / 2;
            tcu_mission.Top = 40;

            mission_statement.Left = (middle_leftside.Width - mission_statement.Width) / 2;
            mission_statement.Top = tcu_mission.Bottom + 10;

            tcu_vision.Left = (middle_leftside.Width - tcu_vision.Width) / 2;
            tcu_vision.Top = mission_statement.Bottom + 30;

            vision_statement.Left = (middle_leftside.Width - vision_statement.Width) / 2;
            vision_statement.Top = tcu_vision.Bottom + 10;

            tcu_philosophy.Left = (middle_leftside.Width - tcu_philosophy.Width) / 2;
            tcu_philosophy.Top = vision_statement.Bottom + 30;

            philosophy_statement.Left = (middle_leftside.Width - philosophy_statement.Width) / 2;
            philosophy_statement.Top = tcu_philosophy.Bottom + 10;

            //Resize bottom panel objects in left side of maincontainer

            tcu_truth.Font = new Font("Arial", 16, FontStyle.Bold);
            tcu_competence.Font = new Font("Arial", 16, FontStyle.Bold);
            tcu_unity.Font = new Font("Arial", 16, FontStyle.Bold);

            tcu_truth.Top = 20;
            tcu_truth.Left = (int)(bottom_leftside.Width * 0.15);
            tcu_competence.Top = 20;
            tcu_competence.Left = (int)(bottom_leftside.Width * 0.35);
            tcu_unity.Top = 20;
            tcu_unity.Left = (int)(bottom_leftside.Width * 0.7);

            //Resize right side of maincontainer

            int rightwidth = (int)(maincontainer.Width * 0.6);
            int rightheight = maincontainer.Height;

            right_side.Size = new Size(rightwidth, rightheight);
            right_side.Left = (int)(maincontainer.Width * 0.40);

            //Resize top panel objects in right side of maincontainer

            top_rightside.Width = right_side.Width;
            top_rightside.Height = (int)(right_side.Height * 0.4);

            tcu_bg.Width = (int)(top_rightside.Width * 0.95);
            tcu_bg.Height = (int)(top_rightside.Height * 0.9);

            tcu_bg.Top = 20;
            tcu_bg.Left = (top_rightside.Width - tcu_bg.Width) / 2;

            //Resize bottom panel in right side of maincontainer

            bottom_rightside.Width = (int)(right_side.Width * 0.95);
            bottom_rightside.Height = (int)(right_side.Height * 0.6);

            bottom_rightside.Left = (right_side.Width - bottom_rightside.Width) / 2;
            bottom_rightside.Top = top_rightside.Bottom;

            //Resize bottom panel objects in right side of maincontainer

            ButtonResize(add_stud);
            ButtonResize(add_prof);
            ButtonResize(add_sub);
            ButtonResize(add_del_sec);
            ButtonResize(delete_stud);
            ButtonResize(delete_prof);
            ButtonResize(assign_sec);
            ButtonResize(assign_irreg);
            ButtonResize(assign_prof);
            ButtonResize(change_sem);

            add_stud.Left = 0;
            delete_stud.Left = 0;
            assign_prof.Left = 0;

            add_prof.Left = add_stud.Right + 45;
            delete_prof.Left = delete_stud.Right + 45;
            change_sem.Left = assign_prof.Right + 45;

            add_sub.Left = add_prof.Right + 45;
            assign_sec.Left = delete_prof.Right + 45;

            add_del_sec.Left = add_sub.Right + 45;
            assign_irreg.Left = assign_sec.Right + 45;

            //Top adjust between columns

            delete_stud.Top = add_stud.Bottom + 10;
            assign_prof.Top = delete_stud.Bottom + 10;

            delete_prof.Top = add_prof.Bottom + 10;
            change_sem.Top = delete_prof.Bottom + 10;

            assign_sec.Top = add_sub.Bottom + 10;
            assign_irreg.Top = add_del_sec.Bottom + 10;

            //Resize background of the forms

            int form_bg_width = maincontainer.Width;
            int form_bg_height = maincontainer.Height;

            form_bg.Size = new Size(form_bg_width, form_bg_height);
            form_bg.Location = new Point(0, 0);
            form_bg.Visible = false;

            //Round close button

            close_button.BackColor = Color.FromArgb(203, 7, 7);
            close_button.FlatAppearance.BorderColor = Color.FromArgb(203, 7, 7);

            close_button.Left = (int)(form_bg.Width * 0.95);
            close_button.Top = 20;
            close_button.Size = new Size(50, 50);

            //Add Student Form Customize

            add_stud_form.Width = (int)(form_bg.Width * 0.5);
            add_stud_form.Height = (int)(form_bg.Height * 0.6);

            int add_stud_x = (form_bg.Width - add_stud_form.Width) / 2;
            int add_stud_y = (form_bg.Height - add_stud_form.Height) / 2;

            add_stud_form.Location = new Point(add_stud_x, add_stud_y);

            //Add Student Form Customize Content

            add_stud_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_stud_subheading.Top = add_stud_header.Bottom + 10;
            add_stud_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_stud_container.Top = add_stud_subheading.Bottom + 15;
            add_stud_container.Left = 30;
            add_stud_container.Size = new Size((int)(add_stud_form.Width * 0.9), (int)(add_stud_form.Width * 0.36));

            add_stud_upload.Top = (int)(add_stud_container.Height * 0.8);
            add_stud_upload.Left = 40;
            add_stud_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_stud_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_stud_drag.Top = (int)(add_stud_container.Height * 0.8);
            add_stud_drag.Left = add_stud_upload.Right - 10;
            add_stud_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            excel_pic.Top = 30;
            excel_pic.Left = (add_stud_container.Width - excel_pic.Width) / 2;

            excel_pic.Size = new Size(100, 100);

            //Add Prof Form Customize

            add_prof_form.Width = (int)(form_bg.Width * 0.5);
            add_prof_form.Height = (int)(form_bg.Height * 0.6);

            int add_prof_x = (form_bg.Width - add_prof_form.Width) / 2;
            int add_prof_y = (form_bg.Height - add_prof_form.Height) / 2;

            add_prof_form.Location = new Point(add_prof_x, add_prof_y);

            //Add Prof Form Customize

            add_prof_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_prof_subheading.Top = add_prof_header.Bottom + 10;
            add_prof_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_prof_container.Top = add_prof_subheading.Bottom + 15;
            add_prof_container.Left = 30;
            add_prof_container.Size = new Size((int)(add_prof_form.Width * 0.9), (int)(add_prof_form.Width * 0.36));

            add_prof_upload.Top = (int)(add_prof_container.Height * 0.8);
            add_prof_upload.Left = 40;
            add_prof_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_prof_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_prof_drag.Top = (int)(add_prof_container.Height * 0.8);
            add_prof_drag.Left = add_prof_upload.Right - 10;
            add_prof_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            add_prof_excel.Top = 30;
            add_prof_excel.Left = (add_prof_container.Width - add_prof_excel.Width) / 2;

            add_prof_excel.Size = new Size(100, 100);

            //Add Sub Form Customize

            add_sub_form.Width = (int)(form_bg.Width * 0.5);
            add_sub_form.Height = (int)(form_bg.Height * 0.6);

            int add_sub_x = (form_bg.Width - add_sub_form.Width) / 2;
            int add_sub_y = (form_bg.Height - add_sub_form.Height) / 2;

            add_sub_form.Location = new Point(add_stud_x, add_stud_y);

            //Add Sub Form Customize Content

            add_sub_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_sub_subheading.Top = add_sub_header.Bottom + 10;
            add_sub_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sub_container.Top = add_sub_subheading.Bottom + 10;
            add_sub_container.Left = 30;
            add_sub_container.Size = new Size((int)(add_sub_form.Width * 0.9), (int)(add_sub_form.Width * 0.36));

            add_sub_upload.Top = (int)(add_sub_container.Height * 0.7);
            add_sub_upload.Left = 40;
            add_sub_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_sub_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_sub_drag.Top = (int)(add_sub_container.Height * 0.7);
            add_sub_drag.Left = add_sub_upload.Right - 10;
            add_sub_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sub_excel.Top = 10;
            add_sub_excel.Left = (add_sub_container.Width - add_sub_excel.Width) / 2;

            add_sub_excel.Size = new Size(100, 100);


            //Add Sec Form Customize

            add_del_section.Width = (int)(form_bg.Width * 0.5);
            add_del_section.Height = (int)(form_bg.Height * 0.9);

            int add_del_sec_x = (form_bg.Width - add_del_section.Width) / 2;
            int add_del_sec_y = 40;

            add_del_section.Location = new Point(add_del_sec_x, add_del_sec_y);

            add_sec_form.Width = add_del_section.Width;
            add_sec_form.Height = (int)(add_del_section.Height * 0.6);

            int add_sec_x = 0;
            int add_sec_y = 0;

            add_sec_form.Location = new Point(add_sec_x, add_sec_y);

            //Add Sec Form Customize Content

            add_sec_header.Font = new Font("Arial", 20, FontStyle.Bold);

            add_sec_subheading.Top = add_sec_header.Bottom + 10;
            add_sec_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sec_container.Top = add_sec_subheading.Bottom + 10;
            add_sec_container.Left = 30;
            add_sec_container.Size = new Size((int)(add_sec_form.Width * 0.9), (int)(add_sec_form.Height * 0.6));

            add_sec_upload.Top = (int)(add_sec_container.Height * 0.8);
            add_sec_upload.Left = 40;
            add_sec_upload.Font = new Font("Arial", 14, FontStyle.Regular);
            add_sec_upload.ForeColor = Color.FromArgb(203, 7, 7);

            add_sec_drag.Top = (int)(add_sec_container.Height * 0.8);
            add_sec_drag.Left = add_sec_upload.Right - 10;
            add_sec_drag.Font = new Font("Arial", 14, FontStyle.Regular);

            add_sec_excel.Top = 30;
            add_sec_excel.Left = (add_sec_container.Width - add_sec_excel.Width) / 2;

            add_sec_excel.Size = new Size(100, 100);

            delete_sec_form.Width = add_del_section.Width;
            delete_sec_form.Height = (int)(add_del_section.Height * 0.35);

            int delete_sec_x = 0;
            int delete_sec_y = add_sec_form.Bottom + 10;

            delete_sec_form.Location = new Point(delete_sec_x, delete_sec_y);

            delete_sec_header.Font = new Font("Arial", 20, FontStyle.Bold);

            delete_sec_subheading.Top = delete_sec_header.Bottom + 10;
            delete_sec_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            delete_sec_searchbar.Top = delete_sec_subheading.Bottom + 15;
            delete_sec_searchbar.Height = 40;
            delete_sec_searchbar.Font = new Font("Arial", 12, FontStyle.Regular);

            delete_sec_searchresults.Top = delete_sec_searchbar.Bottom;

            delete_sec_searchresults.Visible = false;



            //Delete Batch Students Form Customize

            del_batchstud_form.Width = (int)(form_bg.Width * 0.5);
            del_batchstud_form.Height = (int)(form_bg.Height * 0.35);

            int del_batchstud_x = (form_bg.Width - del_batchstud_form.Width) / 2;
            int del_batchstud_y = (form_bg.Height - del_batchstud_form.Height) / 2;

            del_batchstud_form.Location = new Point(add_stud_x, add_stud_y);

            //Delete Batch Students Form Customize Content

            del_batchstud_header.Font = new Font("Arial", 20, FontStyle.Bold);

            del_batchstud_subheading.Top = del_batchstud_header.Bottom + 10;
            del_batchstud_subheading.Font = new Font("Arial", 14, FontStyle.Regular);

            del_batchstud_search.Top = del_batchstud_subheading.Bottom + 15;
            del_batchstud_search.Height = 40;
            del_batchstud_search.Font = new Font("Arial", 12, FontStyle.Regular);

            del_batchstud_searchresults.Top = del_batchstud_search.Bottom;

            del_batchstud_searchresults.Visible = false;
        }


        private void delete_stud_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_prof_form.Visible = false;
            add_stud_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = true;
        }

        private void ButtonResize(Button button)
        {
            button.BackColor = Color.FromArgb(203, 7, 7);
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 12, FontStyle.Regular);
            button.Size = new Size(160, 110);
        }

        private void form_bg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_stud_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_prof_form.Visible = false;
            add_stud_form.Visible = true;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            form_bg.Visible = false;

        }

        private void add_stud_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void add_prof_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = true;
            add_sub_form.Visible = false;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
        }

        private void add_sub_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = true;
            add_del_section.Visible = false;
            del_batchstud_form.Visible = false;
        }

        private void add_prof_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void add_sub_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void add_del_sec_Click(object sender, EventArgs e)
        {
            form_bg.Visible = true;
            add_stud_form.Visible = false;
            add_prof_form.Visible = false;
            add_sub_form.Visible = false;
            add_del_section.Visible = true;
            del_batchstud_form.Visible = false;
        }

        private void add_sec_upload_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void add_del_section_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
