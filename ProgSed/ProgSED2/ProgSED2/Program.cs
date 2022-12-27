using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgSED2
{
    public class CDocument
    {


        public string Name;
        public string Status;
        public string Type;
        public string Author_1;
        public string Author_2;
        public string Number;
        public string Comments;
        public int Summa;
        public DateTime Date_Start;
        public DateTime Date_Finish;

        CDocument()
        {
            Name = Status = Type = Author_1 = Author_2 = Number = Comments = "";
            Summa = 0;
            var Date_Start = new DateTime(1, 1, 1900);
            var Date_Finish = new DateTime(1, 1, 9999);
        }
        public CDocument(string na, string st, string ty, string a1, string a2, string nu, string co, int su, DateTime ds, DateTime df)
        {
            Name = na; Status = st; Type = ty; Author_1 = a1; Author_2 = a2; Number = nu; Comments = co;
            Summa = su;
            Date_Start = ds;
            Date_Finish = df; 
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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<CDocument> Doc = new List<CDocument>();

            Doc.Add(new CDocument("орв", "fdwed", "dfc", "sfc", "efdce", "sfrvg", "gv", 3234, new DateTime(2000, 12, 12), new DateTime(2022, 11, 12)));
            Doc.Add(new CDocument("орв", "fdwed", "dfc", "sfc", "efdce", "sfrvg", "gv", 3234, new DateTime(2000, 12, 12), new DateTime(2022, 11, 12)));
            Doc.Add(new CDocument("орв", "fdwed", "dfc", "sfc", "efdce", "sfrvg", "gv", 3234, new DateTime(2000, 12, 12), new DateTime(2022, 11, 12)));
            Application.Run(new DataForm(Doc));

         }

        
    }
}
