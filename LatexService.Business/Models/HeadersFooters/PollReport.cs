using System;

namespace LatexService.Business.Models.HeadersFooters
{
    public class PollReport : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string TeacherName
        {
            get
            {
                CheckCreateAttribute("$var_teacher_name$");

                return (attributes["$var_teacher_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_teacher_name$");

                attributes["$var_teacher_name$"] = value;
            }
        }

        public string DREName
        {
            get
            {
                CheckCreateAttribute("$var_dre_name$");

                return (attributes["$var_dre_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_dre_name$");

                attributes["$var_dre_name$"] = value;
            }
        }

        public string SchoolName
        {
            get
            {
                CheckCreateAttribute("$var_school_name$");

                return (attributes["$var_school_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_school_name$");

                attributes["$var_school_name$"] = value;
            }
        }

        public string ClassYear
        {
            get
            {
                CheckCreateAttribute("$var_class_year$");

                return (attributes["$var_class_year$"]);
            }
            set
            {
                CheckCreateAttribute("$var_class_year$");

                attributes["$var_class_year$"] = value;
            }
        }

        public string ClassName
        {
            get
            {
                CheckCreateAttribute("$var_class_name$");

                return (attributes["$var_class_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_class_name$");

                attributes["$var_class_name$"] = value;
            }
        }

        public string Subject
        {
            get
            {
                CheckCreateAttribute("$var_subject$");

                return (attributes["$var_subject$"]);
            }
            set
            {
                CheckCreateAttribute("$var_subject$");

                attributes["$var_subject$"] = value;
            }
        }

        public string TestName
        {
            get
            {
                CheckCreateAttribute("$var_test_name$");

                return (attributes["$var_test_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test_name$");

                attributes["$var_test_name$"] = value;
            }
        }

        public string Period
        {
            get
            {
                CheckCreateAttribute("$var_period$");

                return (attributes["$var_period$"]);
            }
            set
            {
                CheckCreateAttribute("$var_period$");

                attributes["$var_period$"] = value;
            }
        }

        public string Type
        {
            get
            {
                CheckCreateAttribute("$var_type$");

                return (attributes["$var_type$"]);
            }
            set
            {
                CheckCreateAttribute("$var_type$");

                attributes["$var_type$"] = value;
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReport()
            : base()
        {
            CheckCreateAttribute("$var_date$");
            attributes["$var_date$"] = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public PollReport(string filePath)
            : base(filePath)
        {
            CheckCreateAttribute("$var_date$");
            attributes["$var_date$"] = DateTime.Now.ToString("dd/MM/yyyy");
        }

        #endregion ==================== CONSTRUCTORS ====================
    }
}