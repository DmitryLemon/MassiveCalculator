using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presenter
{
    class Presenter : View.IPresenter, Model.IPresenter
    {
        private View.IView view;
        private Model.IModel model;
        private IKernel kernel;

        public Presenter(IKernel kernel)
        {
            this.kernel = kernel;

        }

        public void bind()
        {
            this.model = kernel.Get<Model.IModel>();
            this.view = kernel.Get<View.IView>();
        }

        public void doAction(int index, string arg)
        {
            double argdouble = 0;

            if (!Double.TryParse(arg, out argdouble))
            {
                view.statusShow(0, "Incorrect number");
                return;
            }

            doCounting(index, argdouble);
        }

        public void doCounting(int index, double input)
        {
            switch(index)
            {
                case 1:
                    new Operators.Add().perform(input, model.getHpointer());
                    break;
                default:
                    view.statusShow(0, "Unknown operation");
                    break;
            }
        }
    }
}
