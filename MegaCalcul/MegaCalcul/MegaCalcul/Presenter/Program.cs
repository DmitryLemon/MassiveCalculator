using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

namespace Presenter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new Presenter(kernel);
            kernel.Bind<Model.IPresenter>().ToConstant(presenter);
            kernel.Bind<View.IPresenter>().ToConstant(presenter);

            var newForm = new View.Form1(kernel);
            kernel.Bind<View.IView>().ToConstant(newForm);
            kernel.Bind<Model.IModel>().ToConstant(new Model.Model(kernel));

            Application.Run(newForm);
        }
    }
}
