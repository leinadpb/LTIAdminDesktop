﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private string actual_survey_student_link = "";
        private string actual_survey_teacher_link = "";

        public Dashboard()
        {
            InitializeComponent();
            _context = new LTIContext();
        }

        /**
         * CONFIGURAITON PANEL  ---- START
         * */
        private void ConfigControl_Click(object sender, EventArgs e)
        {
            ResetFormLayout();
            ConfigurationPanel.Show();
            //---
            ConfigControl.BackColor = Color.DarkRed;
            ConfigControl.ForeColor = Color.WhiteSmoke;
            lbPantallaPrincipal.Text = "Configuraciones Globales";
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
                        ActivateSurvey.Checked = true;
                    }
                }
                else if (config.Key.ToUpper().Equals(SURVEY_TIME_TEACHER))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        ActivateSurveyTeacher.Checked = true;
                    }
                }
                else if (config.Key.ToUpper().Equals(SURVEY_URL_STUDENT))
                {
                    if (!val.Equals(""))
                    {
                        SurveyLink.Text = val;
                        actual_survey_student_link = val;
                    }
                }
                else if (config.Key.ToUpper().Equals(FULLSCREEN_STUDENT))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        OpenStudentSurveyFullscreen.Checked = true;
                    }
                }
                else if (config.Key.ToUpper().Equals(FULLSCREEN_TEACHER))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        OpenTeacherSurveyFullscreen.Checked = true;
                    }
                }
                else if (config.Key.ToUpper().Equals(SURVEY_URL_TEACHER))
                {
                    if (!val.Equals(""))
                    {
                        SurveyLinkTeacher.Text = val;
                        actual_survey_teacher_link = val;
                    }

                }
                else if (config.Key.ToUpper().Equals(ACCEPT_TERMS))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        AcceptTermsPeriod.Checked = true;
                    }
                }
                else if (config.Key.ToUpper().Equals(SHOW_RULES_REMINDER))
                {
                    if (val.ToUpper().Equals(TRUE))
                    {
                        ShowRulesReminder.Checked = true;
                    }
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

        private void TermsControl_Click(object sender, EventArgs e)
        {
            ResetFormLayout();
            //---
            TermsControl.BackColor = Color.DarkRed;
            TermsControl.ForeColor = Color.WhiteSmoke;
            lbPantallaPrincipal.Text = "Control de Normas";
            //---

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

            //Show Dashboard
            DashBoardPanel.Show();

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

        
    }
}