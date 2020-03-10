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
                    new Operators.Add().perform(input, this);
                    break;
                case 2:
                    new Operators.Substract().perform(input, this);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                default:
                    view.statusShow(0, "Unknown operation");
                    break;
            }
        }

        public void showStatus(int currentop, int localop, int globalop, string opname)
        {
            double percentage = (currentop / localop) * 100;
            view.statusShow(percentage, "Performing " + opname);
        }

        public void showHistory()
        {
            view.showHistory(model.getHistory(), model.getHpointer());
        }

        public void addHistory(double[] step, uint stepcnt)
        {
            string newstep = "";
            for(int i = 0; i < stepcnt; i++)
            {
                newstep += step[i].ToString() + " ";
            }
            model.addHistory(newstep);

        }
    }
}
