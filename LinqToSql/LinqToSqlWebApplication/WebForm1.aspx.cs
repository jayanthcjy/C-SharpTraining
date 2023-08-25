using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToSqlWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext("JayanthConnectionString");
            //var d = data.students;
            List<student> studentData = data.students.ToList();

        }
    }
}