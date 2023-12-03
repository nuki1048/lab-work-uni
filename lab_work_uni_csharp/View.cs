
namespace lab_work_uni_csharp
{
    abstract class View: IDisposable
    {
        protected View(Model model, Controller controller)
        {
            this.Model = model;
            this.Controller = controller;
        }

        protected readonly  Model Model;

        private Controller Controller
        {
            get;
            set;            
        }

        public void ReactToUserActions(ModelOperations modelOperation, Settings settings = null)
        {
            Controller.Execute(modelOperation, Model);
        }
        public void Dispose()
        {
            DataUnbind();
        }

        public abstract void DataBind();
        public abstract void DataUnbind();
    }
}