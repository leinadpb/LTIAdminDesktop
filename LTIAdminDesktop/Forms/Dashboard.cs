using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTIAdminDesktop.Forms;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Forms
{
    public partial class Dashboard : Form
    {
        private string PantallaPrincipal = "Pantalla Principal";
        private readonly LTIContext _context;
        private string TRUE = "TRUE";
        private string FALSE = "FALSE";
        private string ACCEPT_TERMS = "ACCEPT_TERMS";
        private string SURVEY_TIME_STUDENT = "SURVEY_TIME_STUDENT";
        private string SURVEY_TIME_TEACHER = "SURVEY_TIME_TEACHER";
        private string SURVEY_URL_STUDENT = "SURVEY_URL_STUDENT";
        private string FULLSCREEN_STUDENT = "FULLSCREEN_STUDENT";
        private string SURVEY_URL_TEACHER = "SURVEY_URL_TEACHER";
        private string FULLSCREEN_TEACHER = "FULLSCREEN_TEACHER";
        private string SHOW_RULES_REMINDER = "SHOW_RULES_REMINDER";
        private string RULES_REMINDER_TEXT = "RULES_REMINDER_TEXT";
        private string ALLOW_SELECT_TEACHER_SUBJECT = "ALLOW_SELECT_TEACHER_SUBJECT";

        private string actual_survey_student_link = "";
        private string actual_survey_teacher_link = "";

        private bool PopulateDataGrid = true;
        private bool HaveFilledLists = false;

        string[] columns = { "ID", "Nombre", "Fecha Registro", "Computador", "Nombre Asignatura", "Código", "Sección" };

        public Dashboard()
        {
            InitializeComponent();
            _context = new LTIContext();
        }

        /**
         * CONFIGURAITON PANEL  ---- START
         * */
        private async void ConfigControl_Click(object sender, EventArgs e)
        {
            loadingIcon.Visible = true;

            ResetFormLayout();
            ConfigurationPanel.Show();
            //---
            ConfigControl.BackColor = Color.DarkRed;
            ConfigControl.ForeColor = Color.WhiteSmoke;
            lbPantallaPrincipal.Text = "Configuraciones Globales";
            label1.Text = "Configuraciones";

            await Task.Run(() => {
                //--
                List<Configurations> configs = _context.Configurations.ToList();
                GetConfigInfo(configs);
                //---
                if (!ActivateSurvey.Checked)
                {
                    SurveyLink.Enabled = false;
                    OpenStudentSurveyFullscreen.Enabled = false;
                }
                else
                {
                    SurveyLink.Enabled = true;
                    OpenStudentSurveyFullscreen.Enabled = true;
                }
                if (!ActivateSurveyTeacher.Checked)
                {
                    SurveyLinkTeacher.Enabled = false;
                    OpenTeacherSurveyFullscreen.Enabled = false;
                }
                else
                {
                    SurveyLinkTeacher.Enabled = true;
                    OpenTeacherSurveyFullscreen.Enabled = true;
                }
            });

            loadingIcon.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) // Save Configurations options
        {
            var configs = _context.Configurations.Select(c => c);
            Configurations AcceptTermsCF = configs.Where(c => c.Key.ToUpper().Equals(ACCEPT_TERMS)).FirstOrDefault();
            Configurations ShowRulesReminderCF = configs.Where(c => c.Key.ToUpper().Equals(SHOW_RULES_REMINDER)).FirstOrDefault();
            Configurations StudentSurveyTimeCF = configs.Where(c => c.Key.ToUpper().Equals(SURVEY_TIME_STUDENT)).FirstOrDefault();
            Configurations TeacherSurveyTimeCF = configs.Where(c => c.Key.ToUpper().Equals(SURVEY_TIME_TEACHER)).FirstOrDefault();
            Configurations StudentFullscreenCF = configs.Where(c => c.Key.ToUpper().Equals(FULLSCREEN_STUDENT)).FirstOrDefault();
            Configurations TeacherFullscreenCF = configs.Where(c => c.Key.ToUpper().Equals(FULLSCREEN_TEACHER)).FirstOrDefault();
            Configurations StudentLinkCF = configs.Where(c => c.Key.ToUpper().Equals(SURVEY_URL_STUDENT)).FirstOrDefault();
            Configurations TeacherLinkCF = configs.Where(c => c.Key.ToUpper().Equals(SURVEY_URL_TEACHER)).FirstOrDefault();
            Configurations AllowSelectTeacherSubjectCF = configs.Where(c => c.Key.ToUpper().Equals(ALLOW_SELECT_TEACHER_SUBJECT)).FirstOrDefault();
            Configurations ReminderTextCF = configs.Where(c => c.Key.ToUpper().Equals(RULES_REMINDER_TEXT)).FirstOrDefault();

            // Terms configurations
            if (AcceptTermsPeriod.Checked)
            {
                AcceptTermsCF.Value = TRUE;
            }
            else
            {
                AcceptTermsCF.Value = FALSE;
            }
            if (ShowRulesReminder.Checked)
            {
                ShowRulesReminderCF.Value = TRUE;
            }
            else
            {
                ShowRulesReminderCF.Value = FALSE;
            }
            if (SelectTeacherSubject.Checked)
            {
                AllowSelectTeacherSubjectCF.Value = TRUE;
            }
            else
            {
                AllowSelectTeacherSubjectCF.Value = FALSE;
            }

            if (!ReminderText.Text.Equals("") && ShowRulesReminder.Checked)
            {
                ReminderTextCF.Value = ReminderText.Text;
            }
            else
            {
                MessageBox.Show("El texto del recordatorio no puede estar vacío.");
                return;
            }
            

            // Survey configurations
            if (ActivateSurvey.Checked)
            {
                StudentSurveyTimeCF.Value = TRUE;

                //Set new url?
                string student_survey_link = SurveyLink.Text;
                if (!actual_survey_student_link.Equals(student_survey_link)) {
                    StudentLinkCF.Value = SurveyLink.Text;
                }

                //Is fullscreen?
                if (OpenStudentSurveyFullscreen.Checked)
                {
                    StudentFullscreenCF.Value = TRUE;
                }
                else
                {
                    StudentFullscreenCF.Value = FALSE;
                }
            }
            else
            {
                StudentSurveyTimeCF.Value = FALSE;
            }
            if (ActivateSurveyTeacher.Checked)
            {
                TeacherSurveyTimeCF.Value = TRUE;
                //Set new url?
                string teacher_survey_link = SurveyLinkTeacher.Text;
                if (!actual_survey_teacher_link.Equals(teacher_survey_link))
                {
                    TeacherLinkCF.Value = SurveyLinkTeacher.Text;
                }

                //Is fullscreen?
                if (OpenTeacherSurveyFullscreen.Checked)
                {
                    TeacherFullscreenCF.Value = TRUE;
                }
                else
                {
                    TeacherFullscreenCF.Value = FALSE;
                }
            }
            else
            {
               TeacherSurveyTimeCF.Value = FALSE;
            }

            try
            {
                _context.SaveChanges();
                MessageBox.Show("¡Los cambios se han guardado exitosamente!", "LABTI - INTEC");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                MessageBox.Show("Lo sentimos, no se han podido guardar los cambios.");
            }
        }

        private void GetConfigInfo(List<Configurations> configs)
        {
            string val = "";
            foreach (Configurations config in configs)
            {
                val = config.Value;
                if (config.Key.ToUpper().Equals(SURVEY_TIME_STUDENT))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        ActivateSurvey.BeginInvoke(new Action(() => {
                            ActivateSurvey.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(SURVEY_TIME_TEACHER))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        ActivateSurveyTeacher.BeginInvoke(new Action(() => {
                            ActivateSurveyTeacher.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(SURVEY_URL_STUDENT))
                {
                    if (!val.Equals(""))
                    {
                        SurveyLink.BeginInvoke(new Action(() => {
                            SurveyLink.Text = val;
                        }));
                        actual_survey_student_link = val;
                    }
                }
                else if (config.Key.ToUpper().Equals(FULLSCREEN_STUDENT))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        OpenStudentSurveyFullscreen.BeginInvoke(new Action(() => {
                            OpenStudentSurveyFullscreen.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(FULLSCREEN_TEACHER))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        OpenTeacherSurveyFullscreen.BeginInvoke(new Action(() => {
                            OpenTeacherSurveyFullscreen.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(SURVEY_URL_TEACHER))
                {
                    if (!val.Equals(""))
                    {
                        SurveyLinkTeacher.BeginInvoke(new Action(() => {
                            SurveyLinkTeacher.Text = val;
                        }));
                        actual_survey_teacher_link = val;
                    }
                }
                else if (config.Key.ToUpper().Equals(ACCEPT_TERMS))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        AcceptTermsPeriod.BeginInvoke(new Action(() =>
                        {
                            AcceptTermsPeriod.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(SHOW_RULES_REMINDER))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        ShowRulesReminder.BeginInvoke(new Action(() => {
                            ShowRulesReminder.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(ALLOW_SELECT_TEACHER_SUBJECT))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        SelectTeacherSubject.BeginInvoke(new Action(() => {
                            SelectTeacherSubject.Checked = true;
                        }));
                    }
                }
                else if (config.Key.ToUpper().Equals(RULES_REMINDER_TEXT))
                {
                    ReminderText.BeginInvoke(new Action(() => {
                        ReminderText.Text = val;
                    }));
                }
            }
        }
        /**
         * CONFIGURAITON PANEL ---- END
         * */

        private void SurveyControl_Click(object sender, EventArgs e)
        {
            ResetFormLayout();
            //---
            SurveyControl.BackColor = Color.DarkRed;
            SurveyControl.ForeColor = Color.WhiteSmoke;
            lbPantallaPrincipal.Text = "Control de Encuestas";
            //---
        }

        private async void TermsControl_Click(object sender, EventArgs e)
        {
            loadingIcon.Visible = true;
            await ShowTermsForm();
            loadingIcon.Visible = false;

        }

        private async Task ShowTermsForm()
        {
            ResetFormLayout();
            TermsPanel.Show();
            //---
            TermsControl.BackColor = Color.DarkRed;
            TermsControl.ForeColor = Color.WhiteSmoke;
            lbPantallaPrincipal.Text = "Control de Normas";
            label1.Text = "";
            //---
            if (ActivateFilter.Checked)
            {
                ListTrimestres.Enabled = true;
                ListTeachers.Enabled = true;
                ListSubjects.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                ListTrimestres.Enabled = false;
                ListTeachers.Enabled = false;
                ListSubjects.Enabled = false;
                textBox1.Enabled = false;
            }
            //---
            if (PopulateDataGrid)
            {

                for (int i = 0; i < columns.Length; i++)
                {
                    ReportBox.Columns.Add(columns[i], columns[i]);
                }
                PopulateDataGrid = false;
            }
            await Task.Run(() => {
                if (!HaveFilledLists)
                {
                    fillLists();
                }
            });
        }
        private void DashControl_Click(object sender, EventArgs e)
        {
            ResetFormLayout();
            //---
            DashControl.BackColor = Color.DarkRed;
            DashControl.ForeColor = Color.WhiteSmoke;
            lbPantallaPrincipal.Text = "Pantalla Principal";
            //---
        }

        private void ExitControl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DashControl.BackColor = Color.DarkRed;
            DashControl.ForeColor = Color.White;

            //Configuration Panel
            SurveyLink.Enabled = false;
            SurveyLinkTeacher.Enabled = false;
            OpenStudentSurveyFullscreen.Enabled = false;
            OpenTeacherSurveyFullscreen.Enabled = false;

            //---
            ResetFormLayout();

            // Disable Survey Management View (Not yet implemented!)
            SurveyControl.Enabled = false;

            // Perform Click in Dashboard
            DashControl.PerformClick();

            loadingIcon.Visible = false;
        }
        private void ResetFormLayout()
        {
            lbPantallaPrincipal.Text = PantallaPrincipal;

            ConfigControl.BackColor = Color.White;
            TermsControl.BackColor = Color.White;
            SurveyControl.BackColor = Color.White;
            DashControl.BackColor = Color.White;

            ConfigControl.ForeColor = Color.DarkRed;
            TermsControl.ForeColor = Color.DarkRed;
            SurveyControl.ForeColor = Color.DarkRed;
            DashControl.ForeColor = Color.DarkRed;

            SecondNavBack.BackColor = Color.DarkRed;

            //Hide Panels
            ConfigurationPanel.Hide();
            TermsPanel.Hide();

            //Show Dashboard


            //Other
            label1.Text = "";
            ReportBox.Rows.Clear();
            results.Text = "";
            ActivateFilter.Checked = false;

        }

        private void ActivateSurvey_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chbox = (CheckBox)sender;
            if (chbox.Checked)
            {
                SurveyLink.Enabled = true;
                OpenStudentSurveyFullscreen.Enabled = true;
            }
            else
            {
                SurveyLink.Enabled = false;
                OpenStudentSurveyFullscreen.Enabled = false;
            }
        }

        private void ActivateSurveyTeacher_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chbox = (CheckBox)sender;
            if (chbox.Checked)
            {
                SurveyLinkTeacher.Enabled = true;
                OpenTeacherSurveyFullscreen.Enabled = true;
            }
            else
            {
                SurveyLinkTeacher.Enabled = false;
                OpenTeacherSurveyFullscreen.Enabled = false;
            }
        }

        private void fillLists()
        {
            var asigs = _context.Subjects.OrderBy(s => s.SubjectName).Select(s => s).ToList();
            var teachs = _context.Teachers.OrderBy(t => t.DisplayName).Select(t => t).ToList();
            var trimes = _context.Trimestres.OrderBy(t => t.Name).Select(t => t).ToList();

            asigs.Insert(0, new Subjects { SubjectId = -1, SubjectName = "Seleccione ---"});
            teachs.Insert(0, new Teachers { TeacherId = -1, DisplayName = "Seleccione ---"});
            trimes.Insert(0, new Trimestres { TrimestreId = -1, Name = "Seleccione ---"});

            ListTrimestres.BeginInvoke(new Action(() => {
                ListTrimestres.DisplayMember = "Name";
            }));
            ListTrimestres.BeginInvoke(new Action(() => {
                ListTrimestres.ValueMember = "TrimestreID";
            }));
            ListTrimestres.BeginInvoke(new Action(() => {
                ListTrimestres.DataSource = trimes;
            }));

            ListTeachers.BeginInvoke(new Action(() => {
                ListTeachers.DisplayMember = "DisplayName";
            }));
            ListTeachers.BeginInvoke(new Action(() => {
                ListTeachers.ValueMember = "TeacherID";
            }));
            ListTeachers.BeginInvoke(new Action(() => {
                ListTeachers.DataSource = teachs;
            }));

            ListSubjects.BeginInvoke(new Action(() => {
                ListSubjects.DisplayMember = "SubjectName";
            }));
            ListSubjects.BeginInvoke(new Action(() => {
                ListSubjects.ValueMember = "SubjectID";
            }));
            ListSubjects.BeginInvoke(new Action(() => {
                ListSubjects.DataSource = asigs;
            }));

            this.Invoke(new MethodInvoker(() => {
                HaveFilledLists = true;
            }));
           // HaveFilledLists = true;
        }

        private void AdminsControl_Click(object sender, EventArgs e)
        {
            AdminsForm AdminForm = new AdminsForm(_context);
            AdminForm.ShowDialog();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            var students = _context.Students.Select(s => s);

            var oldStudents = _context.HistoryStudents.Select(hs => hs);

            bool includeOld = true;
            if (ActivateFilter.Checked)
            {
                if (ListTrimestres.SelectedItem != null && ListTrimestres.SelectedIndex > 0)
                {
                    int id = Int32.Parse(ListTrimestres.SelectedValue.ToString());
                    Trimestres trimestre = _context.Trimestres.Where(t => t.TrimestreId == id).FirstOrDefault();
                    students = students.Where(s => s.RegisteredDate >= trimestre.StartDate && s.RegisteredDate <= trimestre.EndDate).Select(s => s);
                    includeOld = false;
                }
                if (ListTeachers.SelectedItem != null && ListTeachers.SelectedIndex > 0)
                {
                    int id = Int32.Parse(ListTeachers.SelectedValue.ToString());
                    students = students.Where(s => s.TeacherId == id).Select(t => t);
                }
                if (ListSubjects.SelectedItem != null && ListSubjects.SelectedIndex > 0)
                {
                    int id = Int32.Parse(ListSubjects.SelectedValue.ToString());
                    Subjects subject = _context.Subjects.Where(sb => sb.SubjectId == id).FirstOrDefault();
                    students = students.Where(s => s.SubjectCode == subject.SubjectCode).Select(s => s);
                }
                if (!textBox1.Text.Equals(""))
                {
                    string txt = textBox1.Text;
                    students = students.Where(s => s.LoginName.ToLower().Contains(txt.ToLower().Trim()) || s.DisplayName.ToLower().Contains(txt.ToLower().Trim())).Select(s => s);
                }
            }
            ReportBox.Rows.Clear();
            ShowStudents(students.ToList());
            int count = students.Count();
            if (includeOld)
            {
                ShowOldStudents(oldStudents.ToList());
                count += oldStudents.Count();
            }
            
            results.Text = count.ToString() + " resultados encontrados.";
        }
        private void ShowStudents(List<Students> students)
        {
            foreach(var s in students)
            {
                ReportBox.Rows.Add(s.LoginName, s.DisplayName, s.RegisteredDate, s.ComputerName, s.SubjectName, s.SubjectCode, s.SubjectSection);
            }
        }
        private void ShowOldStudents(List<HistoryStudents> students)
        {
            foreach (var s in students)
            {
                ReportBox.Rows.Add(s.LoginName, s.DisplayName, s.RegisteredDate, s.ComputerName, s.SubjectName, s.SubjectSection, s.SubjectSection);
            }
        }

        private void ActivateFilter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = (CheckBox)sender;
            if (ch.Checked)
            {
                ListTrimestres.Enabled = true;
                ListTrimestres.SelectedIndex = 0;
                ListTeachers.Enabled = true;
                ListTeachers.SelectedIndex = 0;
                ListSubjects.Enabled = true;
                ListSubjects.SelectedIndex = 0;
                textBox1.Enabled = true;
            }
            else
            {
                ListTrimestres.Enabled = false;
                ListTeachers.Enabled = false;
                ListSubjects.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void ReportBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TrimestresBtn_Click(object sender, EventArgs e)
        {
            TrimestresForm TForm = new TrimestresForm(_context);
            TForm.ShowDialog();
        }

        private void NormasBtn_Click(object sender, EventArgs e)
        {
            NormasForm NForm = new NormasForm(_context);
            NForm.ShowDialog();
        }
    }
}
