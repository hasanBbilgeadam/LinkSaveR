using System.Drawing.Design;
using System.Security.Cryptography.X509Certificates;

namespace LinkSaveR
{
    internal static class Program
    {
        public static Form currentForm;


        [STAThread]
        static void Main()
        {
            

            using (Mutex mutext = new Mutex(false,"sdasd"))
            {

                if (!mutext.WaitOne(0,false))
                {
                    MessageBox.Show("Instance already running"); //uygulaman�n birden fazla kez �al��mas�n� engelliyor

                    return;

                    
                    
                
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new Login());
            }
            
         
        }
    }
}