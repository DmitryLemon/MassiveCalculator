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
        private HistoryManager historyManager;
        private int Hpointer;

        public Model(IKernel kernel)
        {



            
        }

        int IModel.getHpointer()
        {
            return Hpointer;
        }

    }

    
}
