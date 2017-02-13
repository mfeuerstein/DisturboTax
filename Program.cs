using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Left to do:
    
    6. Create QUIT form
    7. Ss search validate
    8. Clean up
  
 */
namespace DisturboTax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 one;
            Form2 two;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            one = new Form1();
            two = new Form2();
            one.setForm2(two);
            two.setForm1(one);
            Application.Run(one);
        }
    }
}
