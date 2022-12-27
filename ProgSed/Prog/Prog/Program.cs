using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog
{
    class CDocument
    {
        protected string Name;
        protected string Status;
        protected string Type;
        protected string Author_1;
        protected string Author_2;
        protected string Admin;
        protected string Number;
        protected string Comments;
        protected double Summa;
        protected DateTime Date_Start;
        protected DateTime Date_Finish;

        CDocument()
        {
            Name = Status = Type = Author_1 = Author_2 = Admin = Number = Comments = "";
            Summa = 0.0;
            var Date_Start = new DateTime(1, 1, 1900);
            var Date_Finish = new DateTime(1, 1, 9999);
        }
        CDocument(string na, string st, string ty, string a1, string a2, string ad, string nu, string co, double su, DateTime ds, DateTime df)
        {
            Name = na; Status = st; Type = ty; Author_1 = a1; Author_2 = a2; Admin = ad; Number = nu; Comments = co;
            Summa = su;
            Date_Start = ds;
            Date_Finish = df;
        }
        public void Create()
        {

        }
        public void Edit()
        {

        }
        public void Remove()
        {

        }
        public void Watch()
        {

        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<CDocument> Doc = new List<CDocument>();

        }
    }
}
