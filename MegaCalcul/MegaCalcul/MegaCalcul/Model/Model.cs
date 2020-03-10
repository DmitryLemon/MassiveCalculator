using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Model
{
    class Model : IModel
    {
        private IKernel kernel;
        private IPresenter presenter;
        private HistoryManager history = new HistoryManager();

        public Model(IKernel kernel)
        {
            this.kernel = kernel;
            this.presenter = kernel.Get<IPresenter>();



        }

        

        public void fileManager(string action)
        {
            if (action == "save")
            {
                new FileManager.Saver().perform();
            }

            if (action == "load")
            {

            }
        }

        public void addHistory(string newstep)
        {
            history.add(newstep);
        }

        public string[] getHistory()
        {
            return history.list;
        }

        public uint getHpointer()
        {
            return history.pointer;
        }

    }

    
}
